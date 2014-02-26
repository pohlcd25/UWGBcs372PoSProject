<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeLogin
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
        Me.picEstabIcon = New System.Windows.Forms.PictureBox()
        Me.txtEmplUsername = New System.Windows.Forms.TextBox()
        Me.txtEmplPass = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmplPass = New System.Windows.Forms.Label()
        Me.btnEmplLogin = New System.Windows.Forms.Button()
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEstabIcon
        '
        Me.picEstabIcon.Location = New System.Drawing.Point(683, 12)
        Me.picEstabIcon.Name = "picEstabIcon"
        Me.picEstabIcon.Size = New System.Drawing.Size(164, 102)
        Me.picEstabIcon.TabIndex = 5
        Me.picEstabIcon.TabStop = False
        '
        'txtEmplUsername
        '
        Me.txtEmplUsername.Location = New System.Drawing.Point(362, 181)
        Me.txtEmplUsername.Name = "txtEmplUsername"
        Me.txtEmplUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtEmplUsername.TabIndex = 6
        '
        'txtEmplPass
        '
        Me.txtEmplPass.Location = New System.Drawing.Point(362, 245)
        Me.txtEmplPass.Name = "txtEmplPass"
        Me.txtEmplPass.Size = New System.Drawing.Size(100, 20)
        Me.txtEmplPass.TabIndex = 7
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(359, 154)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 13)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Employee Username"
        '
        'lblEmplPass
        '
        Me.lblEmplPass.AutoSize = True
        Me.lblEmplPass.Location = New System.Drawing.Point(362, 218)
        Me.lblEmplPass.Name = "lblEmplPass"
        Me.lblEmplPass.Size = New System.Drawing.Size(53, 13)
        Me.lblEmplPass.TabIndex = 9
        Me.lblEmplPass.Text = "Password"
        '
        'btnEmplLogin
        '
        Me.btnEmplLogin.Location = New System.Drawing.Point(362, 297)
        Me.btnEmplLogin.Name = "btnEmplLogin"
        Me.btnEmplLogin.Size = New System.Drawing.Size(100, 59)
        Me.btnEmplLogin.TabIndex = 10
        Me.btnEmplLogin.Text = "Login to PEPS"
        Me.btnEmplLogin.UseVisualStyleBackColor = True
        '
        'frmEmployeeLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 462)
        Me.Controls.Add(Me.btnEmplLogin)
        Me.Controls.Add(Me.lblEmplPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtEmplPass)
        Me.Controls.Add(Me.txtEmplUsername)
        Me.Controls.Add(Me.picEstabIcon)
        Me.Name = "frmEmployeeLogin"
        Me.Text = "Pub and Eatery Point of Sale - Employee Login"
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picEstabIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmplUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmplPass As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblEmplPass As System.Windows.Forms.Label
    Friend WithEvents btnEmplLogin As System.Windows.Forms.Button
End Class
