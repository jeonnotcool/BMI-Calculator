Imports System.Diagnostics

Public Class AboutApp

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles cls.Click
        ' When this button is clicked, the AboutApp form will be closed
        Me.Close()
    End Sub

    Private Sub SourceCode_Click(sender As Object, e As EventArgs) Handles SourceCode.Click
        ' When this button is clicked, the user will be redirected to the source code of the application
        Dim url As String = "https://github.com/jeonnotcool/bmi-calculator"
        Process.Start(url)
    End Sub
End Class