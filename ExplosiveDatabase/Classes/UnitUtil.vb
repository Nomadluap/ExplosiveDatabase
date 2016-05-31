''' <summary>
''' Module which contains unit-conversion utilities. 
''' </summary>
Module UnitUtil
    ''' <summary>
    ''' Enum for specifying required unit system in various areas. 
    ''' </summary>
    Public Enum UnitSystem
		METRIC
		IMPERIAL
	End Enum

    ''' <summary>
    ''' Convert a measurement in mm to a measurement in inches
    ''' </summary>
    ''' <param name="mm"></param>
    ''' <returns></returns>
    Public Function MmToInch(mm As Double) As Double
		Return mm / 25.4
	End Function

    ''' <summary>
    ''' Convert a measurement in inches to a measurement in mm
    ''' </summary>
    ''' <param name="inches"></param>
    ''' <returns></returns>
    Public Function InchToMm(inches As Double) As Double
		Return inches * 25.4
	End Function

    ''' <summary>
    ''' Convert a measurement in metres to a measurement in feet. 
    ''' </summary>
    ''' <param name="metres"></param>
    ''' <returns></returns>
    Public Function MetresToFeet(metres As Double) As Double
        Return metres * 3.28084
    End Function

    ''' <summary>
    ''' Convert a measurement in feet to a measurement in metres. 
    ''' </summary>
    ''' <param name="feet"></param>
    ''' <returns></returns>
    Public Function FeetToMetres(feet As Double) As Double
        Return feet / 3.28084
    End Function

End Module
