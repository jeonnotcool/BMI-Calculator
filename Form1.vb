Public Class BMICalculator
    ' BMI Calculator
    ' Gabriel Martin Guillergan (jeonnotcool)
    ' Licensed under GNU General Public License v3.0

    ' Declaring Variables
    Dim h As Double
    Dim w As Double
    Dim hConverted As Double
    Dim t As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculate.Click
        ' Sets the variables to the values of the textboxes
        w = txtWeight.Text
        h = txtHeight.Text
        ' Converts the height to meters
        hConverted = h / 100

        ' BMI Formula = weight / (height * height)
        t = w / (hConverted * hConverted)

        ' Format the value of t as a floating-point number with two decimal places.
        calculated.Text = String.Format("{0:f}", t)

        ' If statements to determine the status of the user
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
        ' Clears the textboxes and labels
        calculated.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()
        Status.Text = ""
        Status.BackColor = Color.White
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exits the application
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Shows the AboutApp form
        AboutApp.Show()
    End Sub

End Class
