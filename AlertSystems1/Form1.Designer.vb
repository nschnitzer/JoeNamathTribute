<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblColon = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblCurTimeLabel = New System.Windows.Forms.Label()
        Me.lblCurTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtmPicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(61, 34)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(155, 13)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Please enter the alert message:"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(45, 50)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(185, 85)
        Me.txtMessage.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(22, 147)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(234, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Enter the time you want the alert to go off (12hr):"
        '
        'lblColon
        '
        Me.lblColon.AutoSize = True
        Me.lblColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.Location = New System.Drawing.Point(116, 186)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(12, 16)
        Me.lblColon.TabIndex = 5
        Me.lblColon.Text = ":"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(76, 212)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Create Alert"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblCurTimeLabel
        '
        Me.lblCurTimeLabel.AutoSize = True
        Me.lblCurTimeLabel.Location = New System.Drawing.Point(42, 160)
        Me.lblCurTimeLabel.Name = "lblCurTimeLabel"
        Me.lblCurTimeLabel.Size = New System.Drawing.Size(70, 13)
        Me.lblCurTimeLabel.TabIndex = 8
        Me.lblCurTimeLabel.Text = "Current Time:"
        '
        'lblCurTime
        '
        Me.lblCurTime.AutoSize = True
        Me.lblCurTime.Location = New System.Drawing.Point(137, 160)
        Me.lblCurTime.Name = "lblCurTime"
        Me.lblCurTime.Size = New System.Drawing.Size(0, 13)
        Me.lblCurTime.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dtmPicker1
        '
        Me.dtmPicker1.CustomFormat = ""
        Me.dtmPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmPicker1.Location = New System.Drawing.Point(45, 186)
        Me.dtmPicker1.Name = "dtmPicker1"
        Me.dtmPicker1.Size = New System.Drawing.Size(200, 20)
        Me.dtmPicker1.TabIndex = 10
        Me.dtmPicker1.Value = New Date(2018, 5, 7, 12, 32, 0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.dtmPicker1)
        Me.Controls.Add(Me.lblCurTime)
        Me.Controls.Add(Me.lblCurTimeLabel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblColon As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblCurTimeLabel As Label
    Friend WithEvents lblCurTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dtmPicker1 As DateTimePicker
End Class
