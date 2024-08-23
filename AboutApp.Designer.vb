<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cls = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SourceCode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Text", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(21, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(312, 45)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "BMI Calculator"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 106)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "This is a project for Computer Education 10. A simple BMI calculator written on V" &
    "isual Basic."
        '
        'cls
        '
        Me.cls.Font = New System.Drawing.Font("SF UI Display", 14.8!, System.Drawing.FontStyle.Bold)
        Me.cls.Location = New System.Drawing.Point(116, 294)
        Me.cls.Name = "cls"
        Me.cls.Size = New System.Drawing.Size(217, 46)
        Me.cls.TabIndex = 13
        Me.cls.Text = "OK"
        Me.cls.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 68)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "This application is for our Major Performance Task Project."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Text", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(411, 45)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "- jeonnotcool"
        '
        'SourceCode
        '
        Me.SourceCode.Font = New System.Drawing.Font("SF UI Display", 10.8!, System.Drawing.FontStyle.Bold)
        Me.SourceCode.Location = New System.Drawing.Point(116, 346)
        Me.SourceCode.Name = "SourceCode"
        Me.SourceCode.Size = New System.Drawing.Size(217, 31)
        Me.SourceCode.TabIndex = 16
        Me.SourceCode.Text = "Source Code"
        Me.SourceCode.UseVisualStyleBackColor = True
        '
        'AboutApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 457)
        Me.Controls.Add(Me.SourceCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cls)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutApp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cls As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SourceCode As Button
End Class
