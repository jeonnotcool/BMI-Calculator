<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMICalculator
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
        Me.calculate = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.calculated = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.weighLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.calcLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.calculate.Location = New System.Drawing.Point(174, 430)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(190, 49)
        Me.calculate.TabIndex = 4
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.reset.Location = New System.Drawing.Point(402, 430)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(190, 49)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(348, 135)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(193, 38)
        Me.txtWeight.TabIndex = 7
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(348, 212)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(193, 38)
        Me.txtHeight.TabIndex = 8
        '
        'calculated
        '
        Me.calculated.BackColor = System.Drawing.Color.White
        Me.calculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.calculated.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculated.Location = New System.Drawing.Point(348, 284)
        Me.calculated.Name = "calculated"
        Me.calculated.Size = New System.Drawing.Size(244, 38)
        Me.calculated.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Text", 25.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(218, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 57)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "BMI Calculator"
        '
        'weighLabel
        '
        Me.weighLabel.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.weighLabel.Location = New System.Drawing.Point(107, 135)
        Me.weighLabel.Name = "weighLabel"
        Me.weighLabel.Size = New System.Drawing.Size(180, 45)
        Me.weighLabel.TabIndex = 11
        Me.weighLabel.Text = "Weight in kg"
        '
        'heightLabel
        '
        Me.heightLabel.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.heightLabel.Location = New System.Drawing.Point(107, 215)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(171, 36)
        Me.heightLabel.TabIndex = 12
        Me.heightLabel.Text = "Height in cm"
        '
        'calcLabel
        '
        Me.calcLabel.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.calcLabel.Location = New System.Drawing.Point(107, 284)
        Me.calcLabel.Name = "calcLabel"
        Me.calcLabel.Size = New System.Drawing.Size(200, 38)
        Me.calcLabel.TabIndex = 13
        Me.calcLabel.Text = "Calculated BMI"
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.StatusLabel.Location = New System.Drawing.Point(107, 346)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(171, 38)
        Me.StatusLabel.TabIndex = 15
        Me.StatusLabel.Text = "Status"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.White
        Me.Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Status.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(348, 346)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(342, 38)
        Me.Status.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 28)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(557, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 45)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "kg"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(557, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 45)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "cm"
        '
        'BMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 536)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.calcLabel)
        Me.Controls.Add(Me.heightLabel)
        Me.Controls.Add(Me.weighLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.calculated)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Text", 7.8!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BMICalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculate As Button
    Friend WithEvents reset As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents calculated As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents weighLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents calcLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Status As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
