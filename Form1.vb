Public Class BMICalculator
    Dim h As Double
    Dim w As Double
    Dim hConverted As Double
    Dim t As Double


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculate.Click
        w = txtWeight.Text
        h = txtHeight.Text
        hConverted = h / 100

        t = w / (hConverted * hConverted)

        calculated.Text = String.Format("{0:f}", t)

        If t < 18.5 Then
            Status.BackColor = Color.SkyBlue
            Status.Text = "You are underweight."
        ElseIf t <= 24.9 Then
            Status.BackColor = Color.LightGreen
            Status.Text = "You are within the normal range."
        ElseIf t <= 29.9 Then
            Status.BackColor = Color.LightYellow
            Status.Text = "You are overweight."
        ElseIf t >= 30 Then
            Status.BackColor = Color.Red
            Status.Text = "You are obese."
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles reset.Click
        calculated.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()
        Status.Text = ""
        Status.BackColor = Color.White
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutApp.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
