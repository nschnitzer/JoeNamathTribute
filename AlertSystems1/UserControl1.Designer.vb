<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnUpgradeNow = New System.Windows.Forms.Button()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.lblUpgrade1 = New System.Windows.Forms.Label()
        Me.lblUpgrade2 = New System.Windows.Forms.Label()
        Me.lblUpgrade3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUpgradeNow
        '
        Me.btnUpgradeNow.Location = New System.Drawing.Point(53, 176)
        Me.btnUpgradeNow.Name = "btnUpgradeNow"
        Me.btnUpgradeNow.Size = New System.Drawing.Size(92, 28)
        Me.btnUpgradeNow.TabIndex = 0
        Me.btnUpgradeNow.Text = "Upgrade Now"
        Me.btnUpgradeNow.UseVisualStyleBackColor = True
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(247, 176)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(83, 28)
        Me.btnInstall.TabIndex = 1
        Me.btnInstall.Text = "Install Now"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'lblUpgrade1
        '
        Me.lblUpgrade1.AutoSize = True
        Me.lblUpgrade1.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade1.Location = New System.Drawing.Point(3, 25)
        Me.lblUpgrade1.Name = "lblUpgrade1"
        Me.lblUpgrade1.Size = New System.Drawing.Size(418, 28)
        Me.lblUpgrade1.TabIndex = 2
        Me.lblUpgrade1.Text = "UPGRADE TO WINDOWS 10 NOW"
        '
        'lblUpgrade2
        '
        Me.lblUpgrade2.AutoSize = True
        Me.lblUpgrade2.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade2.Location = New System.Drawing.Point(3, 78)
        Me.lblUpgrade2.Name = "lblUpgrade2"
        Me.lblUpgrade2.Size = New System.Drawing.Size(418, 28)
        Me.lblUpgrade2.TabIndex = 3
        Me.lblUpgrade2.Text = "UPGRADE TO WINDOWS 10 NOW"
        '
        'lblUpgrade3
        '
        Me.lblUpgrade3.AutoSize = True
        Me.lblUpgrade3.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrade3.Location = New System.Drawing.Point(3, 135)
        Me.lblUpgrade3.Name = "lblUpgrade3"
        Me.lblUpgrade3.Size = New System.Drawing.Size(418, 28)
        Me.lblUpgrade3.TabIndex = 4
        Me.lblUpgrade3.Text = "UPGRADE TO WINDOWS 10 NOW"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblUpgrade3)
        Me.Controls.Add(Me.lblUpgrade2)
        Me.Controls.Add(Me.lblUpgrade1)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.btnUpgradeNow)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(424, 230)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpgradeNow As Button
    Friend WithEvents btnInstall As Button
    Friend WithEvents lblUpgrade1 As Label
    Friend WithEvents lblUpgrade2 As Label
    Friend WithEvents lblUpgrade3 As Label
End Class
