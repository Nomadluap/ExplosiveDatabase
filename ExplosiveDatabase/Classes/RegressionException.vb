Imports System.Runtime.Serialization

''' <summary>
''' Exception signifying that the linear regression of an ExplosiveProduct has failed. 
''' </summary>
<Serializable>
Friend Class RegressionException
	Inherits Exception

	Public Sub New()
	End Sub

	Public Sub New(message As String)
		MyBase.New(message)
	End Sub

	Public Sub New(message As String, innerException As Exception)
		MyBase.New(message, innerException)
	End Sub

	Protected Sub New(info As SerializationInfo, context As StreamingContext)
		MyBase.New(info, context)
	End Sub
End Class
