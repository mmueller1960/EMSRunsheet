Imports System.Web.Mvc

Public Class HelloWorldController
    Inherits Controller

    ' GET: /HelloWorld

    Public Function Index() As ActionResult
        Return View()
    End Function

    Public Function Welcome(ByVal name As String, Optional ByVal ID As Integer = 1) As String
        Dim message As String = "Hello " & name & ", ID: " & ID
        Return "" & Server.HtmlEncode(message) & ""
    End Function

End Class