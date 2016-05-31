Imports System.Data.SQLite
Imports System.IO

''' <summary>
''' Class which represents a connection to a SQLite Database holding the explosive cap information. 
''' This class handles communication with the SQLite database as well as serialization between 
''' the database structure and the ExplosiveProduct class. 
''' 
''' Each individual explosive product is listed as a row in the 'products' field of the database. This table contains all 
''' information about the explosive product except for the entries in its velocity table, which are stored their own table, velocity_table_entries. 
''' Each entry in the velocity_table_entries table has a key that points to its respective product. 
''' </summary>
Public Class DatabaseConnection
	Private Shared EMPTY_DB_CREATION_SQL As String = "CREATE TABLE [products] (
[id] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,
[mine_location] TEXT  NULL,
[product_name] TEXT  NULL,
[end_use] TEXT  NULL,
[fume_class] TEXT  NULL,
[density] REAL  NULL
);

CREATE TABLE [velocity_table_entries] (
[id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[product_id] INTEGER  NULL,
[diameter] REAL  NULL,
[velocity] REAL  NULL
);"

	Private db As SQLite.SQLiteConnection


	Public Shared Function CreateNewDatabase(filename As String) As DatabaseConnection
		' zero out the database if it exists by opening with create then closing
		' otherwise we may get errors trying to create tables that already exist if we overwrite an existing database. 
		Dim f = File.Open(filename, FileMode.Create)
		f.Close()
		' Then connect to the file through SQLite
		Dim connectionString = String.Format("Data Source=""{0}""; Version=3", filename)
		Dim db = New SQLite.SQLiteConnection(connectionString)
		db.Open()
        ' set up the new database as empty
        Dim command = New SQLiteCommand(db)
		command.CommandText = EMPTY_DB_CREATION_SQL
		command.ExecuteNonQuery()
		db.Close()
		Return New DatabaseConnection(filename)
	End Function

    ''' <summary>
    ''' Create a new SQLiteDatabase object using the specified filename for the SQLite database. It is assumed that the 
    ''' </summary>
    ''' <param name="filename"></param>
    Public Sub New(filename As String)
        ' open the database
        Dim connectionString = String.Format("Data Source=""{0}""; Version=3", filename)
		Try
			db = New SQLite.SQLiteConnection(connectionString)
			db.Open()
		Catch ex As Exception
			Trace.WriteLine("Error connecting: " & ex.Message)
		End Try
	End Sub

	Public Sub Finalize()
		db.Close()
	End Sub

    ''' <summary>
    ''' Find the entries in the velocity table for a specified product id. 
    ''' </summary>
    ''' <param name="productID">table id of the product to query</param>
    ''' <returns>The list of elements of the velocity table for this explosive product. </returns>
    Private Function GetVelocityData(productID As Integer) As List(Of DetVelocityEntry)
        Dim entries = New List(Of DetVelocityEntry)
        Dim query = New SQLiteCommand(db)

        query.CommandText = "SELECT id, diameter, velocity FROM velocity_table_entries WHERE product_id = @product_id;"
        query.Parameters.Add(New SQLiteParameter("@product_id", productID))
        Dim reader = query.ExecuteReader()
        While reader.Read()
            Dim entry = New DetVelocityEntry(reader.GetDouble(1), reader.GetDouble(2))
            entry.rowID = reader.GetInt32(0)
            entries.Add(entry)
        End While
        Return entries
    End Function

    ''' <summary>
    ''' Read the database and compile a list of ExplosiveProducts that reside in the list. 
    ''' </summary>
    ''' <returns></returns>
    Public Function ReadAllProducts() As List(Of ExplosiveProduct)
        Dim products = New List(Of ExplosiveProduct)
        Dim query = New SQLiteCommand(db)
		query.CommandText = "SELECT id, mine_location, product_name, end_use, fume_class, density FROM products;"
		Dim reader = query.ExecuteReader()

        While reader.Read() ' create product objects from lines returned by the query
            Dim product = New ExplosiveProduct(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDouble(5))
            product.RowID = reader.GetInt32(0)
            product.VelocityEntries = Me.GetVelocityData(product.RowID)
            products.Add(product)
        End While
        Return products
    End Function

    ''' <summary>
    ''' Insert a new Explosive Product into the database and return the row ID number corresponding to that new item in the products table. 
    ''' Also update the rowID of the product itself.
    ''' </summary>
    ''' <param name="p">The ExplosiveProduct to enter</param>
    Public Sub InsertProduct(p As ExplosiveProduct)
        ' pull values from object
        Dim mineLocation = p.MineName
		Dim productName = p.ProductName
		Dim endUse = p.ApplicationEndUse
		Dim fumeClass = p.FumeClass
		Dim density = p.Density
		Dim regressionA = p.RegressionA
		Dim regressionB = p.RegressionB
		Dim regressionC = p.RegressionC

        ' first insert the product into the products table
        Dim sql = New SQLiteCommand(db)
		sql.CommandText = "INSERT INTO products (mine_location, product_name, end_use, fume_class, density)" _
							+ "VALUES (@mine_location, @product_name, @end_use, @fume_class, @density);"
		sql.Parameters.Add(New SQLiteParameter("@mine_location", mineLocation))
		sql.Parameters.Add(New SQLiteParameter("@product_name", productName))
		sql.Parameters.Add(New SQLiteParameter("@end_use", endUse))
		sql.Parameters.Add(New SQLiteParameter("@fume_class", fumeClass))
		sql.Parameters.Add(New SQLiteParameter("@density", density))

		sql.ExecuteNonQuery()
		Dim retRowID = db.LastInsertRowId ' Apparently this is NOT thread safe and therefore is bad. Don't do this. 

		p.RowID = retRowID ' NB: this needs to be set before the velocity table is updated. 
        ' Now push the velocity table entries for this product into the velocity table. 
        Me.UpdateVelocityTable(p)
	End Sub


    ''' <summary>
    ''' Update the database entry for the specified explosive product. The supplied product must have a non-negative TableID parameter. 
    ''' </summary>
    ''' <param name="p">The explosive product to update. </param>
    ''' <returns>True if the modify was successful, otherwise False if the update is unsuccsessful. </returns>
    Public Function UpdateProduct(p As ExplosiveProduct) As Boolean
        ' pull values from object
        Dim mineLocation = p.MineName
        Dim productName = p.ProductName
        Dim endUse = p.ApplicationEndUse
        Dim fumeClass = p.FumeClass
        Dim density = p.Density
        Dim regressionA = p.RegressionA
        Dim regressionB = p.RegressionB
        Dim regressionC = p.RegressionC
        Dim rowID = p.RowID

        If rowID >= 0 Then
            ' sql magic
            Dim sql = New SQLiteCommand(db)
			sql.CommandText = "UPDATE products Set mine_location = @mine_location, product_name = @product_name, end_use = @end_use, fume_class = @fume_class, density = @density " _
							  + "WHERE id = @rowID;"
			sql.Parameters.Add(New SQLiteParameter("@mine_location", mineLocation))
            sql.Parameters.Add(New SQLiteParameter("@product_name", productName))
            sql.Parameters.Add(New SQLiteParameter("@end_use", endUse))
            sql.Parameters.Add(New SQLiteParameter("@fume_class", fumeClass))
			sql.Parameters.Add(New SQLiteParameter("@density", density))
			sql.Parameters.Add(New SQLiteParameter("@rowID", rowID))
            sql.ExecuteNonQuery()
			' update the velocity entries
			Me.UpdateVelocityTable(p)


			Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Remove the specified ExplosiveProduct from the database. The supplied product must have a non-negative TableID parameter. 
    ''' </summary>
    ''' <param name="p">Object to be removed from the table. </param>
    ''' <returns>True if the delete was successful, otherwise False if the delete is unsucessful. </returns>
    Public Function DeleteProduct(p As ExplosiveProduct) As Boolean
        Dim rowID = p.RowID
        If rowID < 0 Then
            Return False
        Else
            Dim sql = New SQLiteCommand(db)
            'we must delete both the product itself as well as the entries from velocity_table_entries which reference that row.
            sql.CommandText = "DELETE FROM velocity_table_entries WHERE product_id = @rowID; DELETE FROM products WHERE id = @rowID;"
            sql.Parameters.Add(New SQLiteParameter("@rowID", rowID))
            sql.ExecuteNonQuery()
            Return True
        End If
    End Function

    ''' <summary>
    ''' Attempt to update the product in the database. If the product product does not exist in the database, then insert it instead. 
    ''' </summary>
    ''' <param name="p"></param>
    Public Sub UpdateOrInsertProduct(p As ExplosiveProduct)
		If p.RowID < 0 Then ' product is not already in the databse
            Me.InsertProduct(p)
		Else
			Me.UpdateProduct(p)
		End If
	End Sub

	''' <summary>
	''' Update the database velocity table to reflect the current velocity table of an explosive product. 
	''' </summary>
	''' <param name="p">The product to update. </param>
	Private Sub UpdateVelocityTable(p As ExplosiveProduct)
		Dim rowID = p.RowID
		' first remove all the velocity table entries for this product, since we don't keep a record of the ones we've deleted. 
		Dim sql = New SQLiteCommand(db)
		sql.CommandText = "DELETE FROM velocity_table_entries WHERE product_id = @rowID;"
		sql.Parameters.Add(New SQLiteParameter("@rowID", rowID))
		sql.ExecuteNonQuery()
		' then populate. Make sure the list is sorted first
		p.VelocityEntries.Sort()
		For Each line As DetVelocityEntry In p.VelocityEntries
			Dim sql1 = New SQLiteCommand(db)
			sql1.Transaction = db.BeginTransaction()
			If line.rowID < 0 Then
				sql1.CommandText = "INSERT INTO velocity_table_entries (product_id, diameter, velocity) VALUES (@product_id, @diameter, @velocity);"
				sql1.Parameters.Add(New SQLiteParameter("@product_id", p.RowID))
				sql1.Parameters.Add(New SQLiteParameter("@diameter", line.Diameter))
				sql1.Parameters.Add(New SQLiteParameter("@velocity", line.DetVelocity))
				sql1.ExecuteNonQuery()
				line.rowID = db.LastInsertRowId()
			Else
				sql1.CommandText = "UPDATE velocity_table_entries SET diameter=@diameter, velocity=@velocity WHERE id=@id AND product_id=@product_id;"
				sql1.Parameters.Add(New SQLiteParameter("@id", line.rowID))
				sql1.Parameters.Add(New SQLiteParameter("@product_id", p.RowID))
				sql1.Parameters.Add(New SQLiteParameter("@diameter", line.Diameter))
				sql1.Parameters.Add(New SQLiteParameter("@velocity", line.DetVelocity))
				sql1.ExecuteNonQuery()
			End If
			sql1.Transaction.Commit()
		Next

	End Sub

End Class
