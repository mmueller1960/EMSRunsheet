@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Welcome"
End Code

<h2>Welcome</h2>
    @code
        @For i As Integer = 0 To ViewBag.numTimes
            @<h3> @ViewBag.message @i.ToString</h3>
        Next i
    End code
