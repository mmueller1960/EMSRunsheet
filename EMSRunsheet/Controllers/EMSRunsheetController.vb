Imports System.Web.Mvc

Public Class EMSRunsheetController
    Inherits Controller

    ' GET: /HelloWorld

    Public Function Index() As ActionResult
        Return View()
    End Function

    Public Function Welcome(ByVal name As String, Optional ByVal numTimes As Integer = 1) As ActionResult

        ViewBag.Message = "Hello " & name
        ViewBag.numTimes = numTimes

        Return View()

    End Function
End Class