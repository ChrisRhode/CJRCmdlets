Imports System.Management.Automation

<Cmdlet(VerbsCommon.Get, "DaysBeforeNowOfDate")>
Public Class GetDaysBeforeNow
    Inherits Cmdlet

    Dim theDate As String

    <Parameter(Position:=0, ValueFromPipeline:=True)> Public Property DateValue As String
        Get
            Return theDate
        End Get
        Set(value As String)
            If (Not IsDate(value)) Then
                Throw New Exception("DateValue is not a date")
            End If
            theDate = value
        End Set
    End Property


    Protected Overrides Sub EndProcessing()
        Dim d As Date
        Dim dn As Date
        Dim n As Integer

        dn = Date.Now.Date
        d = Convert.ToDateTime(theDate).Date
        n = DateDiff(DateInterval.Day, d, dn)

        WriteObject(n)
    End Sub
End Class
