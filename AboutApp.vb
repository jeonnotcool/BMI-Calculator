Imports System.Diagnostics

Public Class AboutApp

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()
    End Sub

    Private Sub SourceCode_Click(sender As Object, e As EventArgs) Handles SourceCode.Click
        Dim url As String = "https://github.com/jeonnotcool/bmi-calculator"
        Process.Start(url)
    End Sub
End Class