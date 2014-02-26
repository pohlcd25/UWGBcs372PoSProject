<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloseTab
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
        Me.cboOpenTabs = New System.Windows.Forms.ComboBox()
        Me.lblCboOpenTabs = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkGuestCheck = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblGuestEmail = New System.Windows.Forms.Label()
        Me.txtGuestEmail = New System.Windows.Forms.TextBox()
        Me.chkPaymentMethod = New System.Windows.Forms.CheckBox()
        Me.chkDebitCredit = New System.Windows.Forms.CheckBox()
        Me.chkGift = New System.Windows.Forms.CheckBox()
        Me.chkCash = New System.Windows.Forms.CheckBox()
        Me.txtCreditDebitNumber = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.txtExpirDate = New System.Windows.Forms.TextBox()
        Me.lblCCVN = New System.Windows.Forms.Label()
        Me.txtCCVN = New System.Windows.Forms.TextBox()
        Me.lblGiftCardNum = New System.Windows.Forms.Label()
        Me.txtGiftNum = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.picEstabIcon = New System.Windows.Forms.PictureBox()
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOpenTabs
        '
        Me.cboOpenTabs.FormattingEnabled = True
        Me.cboOpenTabs.Location = New System.Drawing.Point(62, 57)
        Me.cboOpenTabs.Name = "cboOpenTabs"
        Me.cboOpenTabs.Size = New System.Drawing.Size(121, 21)
        Me.cboOpenTabs.TabIndex = 0
        '
        'lblCboOpenTabs
        '
        Me.lblCboOpenTabs.AutoSize = True
        Me.lblCboOpenTabs.Location = New System.Drawing.Point(59, 30)
        Me.lblCboOpenTabs.Name = "lblCboOpenTabs"
        Me.lblCboOpenTabs.Size = New System.Drawing.Size(60, 13)
        Me.lblCboOpenTabs.TabIndex = 1
        Me.lblCboOpenTabs.Text = "Open Tabs"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Commit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkGuestCheck
        '
        Me.chkGuestCheck.AutoSize = True
        Me.chkGuestCheck.Location = New System.Drawing.Point(62, 101)
        Me.chkGuestCheck.Name = "chkGuestCheck"
        Me.chkGuestCheck.Size = New System.Drawing.Size(124, 17)
        Me.chkGuestCheck.TabIndex = 3
        Me.chkGuestCheck.Text = "Guest Check Printed"
        Me.chkGuestCheck.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(62, 136)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Email Receipt"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblGuestEmail
        '
        Me.lblGuestEmail.AutoSize = True
        Me.lblGuestEmail.Location = New System.Drawing.Point(215, 137)
        Me.lblGuestEmail.Name = "lblGuestEmail"
        Me.lblGuestEmail.Size = New System.Drawing.Size(63, 13)
        Me.lblGuestEmail.TabIndex = 5
        Me.lblGuestEmail.Text = "Guest Email"
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.Location = New System.Drawing.Point(284, 136)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtGuestEmail.TabIndex = 6
        '
        'chkPaymentMethod
        '
        Me.chkPaymentMethod.AutoSize = True
        Me.chkPaymentMethod.Location = New System.Drawing.Point(62, 171)
        Me.chkPaymentMethod.Name = "chkPaymentMethod"
        Me.chkPaymentMethod.Size = New System.Drawing.Size(147, 17)
        Me.chkPaymentMethod.TabIndex = 7
        Me.chkPaymentMethod.Text = "Payment Method In Hand"
        Me.chkPaymentMethod.UseVisualStyleBackColor = True
        '
        'chkDebitCredit
        '
        Me.chkDebitCredit.AutoSize = True
        Me.chkDebitCredit.Location = New System.Drawing.Point(121, 295)
        Me.chkDebitCredit.Name = "chkDebitCredit"
        Me.chkDebitCredit.Size = New System.Drawing.Size(108, 17)
        Me.chkDebitCredit.TabIndex = 8
        Me.chkDebitCredit.Text = "Debit/Credit Card"
        Me.chkDebitCredit.UseVisualStyleBackColor = True
        '
        'chkGift
        '
        Me.chkGift.AutoSize = True
        Me.chkGift.Location = New System.Drawing.Point(121, 334)
        Me.chkGift.Name = "chkGift"
        Me.chkGift.Size = New System.Drawing.Size(67, 17)
        Me.chkGift.TabIndex = 9
        Me.chkGift.Text = "Gift Card"
        Me.chkGift.UseVisualStyleBackColor = True
        '
        'chkCash
        '
        Me.chkCash.AutoSize = True
        Me.chkCash.Location = New System.Drawing.Point(121, 373)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Size = New System.Drawing.Size(50, 17)
        Me.chkCash.TabIndex = 10
        Me.chkCash.Text = "Cash"
        Me.chkCash.UseVisualStyleBackColor = True
        '
        'txtCreditDebitNumber
        '
        Me.txtCreditDebitNumber.Location = New System.Drawing.Point(284, 295)
        Me.txtCreditDebitNumber.Name = "txtCreditDebitNumber"
        Me.txtCreditDebitNumber.Size = New System.Drawing.Size(191, 20)
        Me.txtCreditDebitNumber.TabIndex = 11
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(281, 279)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(99, 13)
        Me.lblCardNumber.TabIndex = 12
        Me.lblCardNumber.Text = "Credit Card Number"
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Location = New System.Drawing.Point(492, 280)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(51, 13)
        Me.lblExpDate.TabIndex = 14
        Me.lblExpDate.Text = "Exp Date"
        '
        'txtExpirDate
        '
        Me.txtExpirDate.Location = New System.Drawing.Point(495, 296)
        Me.txtExpirDate.Name = "txtExpirDate"
        Me.txtExpirDate.Size = New System.Drawing.Size(55, 20)
        Me.txtExpirDate.TabIndex = 13
        '
        'lblCCVN
        '
        Me.lblCCVN.AutoSize = True
        Me.lblCCVN.Location = New System.Drawing.Point(573, 280)
        Me.lblCCVN.Name = "lblCCVN"
        Me.lblCCVN.Size = New System.Drawing.Size(36, 13)
        Me.lblCCVN.TabIndex = 16
        Me.lblCCVN.Text = "CCVN"
        '
        'txtCCVN
        '
        Me.txtCCVN.Location = New System.Drawing.Point(576, 296)
        Me.txtCCVN.Name = "txtCCVN"
        Me.txtCCVN.Size = New System.Drawing.Size(62, 20)
        Me.txtCCVN.TabIndex = 15
        '
        'lblGiftCardNum
        '
        Me.lblGiftCardNum.AutoSize = True
        Me.lblGiftCardNum.Location = New System.Drawing.Point(281, 318)
        Me.lblGiftCardNum.Name = "lblGiftCardNum"
        Me.lblGiftCardNum.Size = New System.Drawing.Size(88, 13)
        Me.lblGiftCardNum.TabIndex = 17
        Me.lblGiftCardNum.Text = "Gift Card Number"
        '
        'txtGiftNum
        '
        Me.txtGiftNum.Location = New System.Drawing.Point(284, 334)
        Me.txtGiftNum.Name = "txtGiftNum"
        Me.txtGiftNum.Size = New System.Drawing.Size(100, 20)
        Me.txtGiftNum.TabIndex = 18
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(284, 373)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 20)
        Me.txtCash.TabIndex = 20
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Location = New System.Drawing.Point(281, 357)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(31, 13)
        Me.lblCash.TabIndex = 19
        Me.lblCash.Text = "Cash"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.Location = New System.Drawing.Point(440, 357)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(67, 13)
        Me.lblChangeDue.TabIndex = 21
        Me.lblChangeDue.Text = "Change Due"
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Location = New System.Drawing.Point(443, 373)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeDue.TabIndex = 22
        '
        'picEstabIcon
        '
        Me.picEstabIcon.Location = New System.Drawing.Point(683, 12)
        Me.picEstabIcon.Name = "picEstabIcon"
        Me.picEstabIcon.Size = New System.Drawing.Size(164, 102)
        Me.picEstabIcon.TabIndex = 23
        Me.picEstabIcon.TabStop = False
        '
        'frmCloseTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 462)
        Me.Controls.Add(Me.picEstabIcon)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtGiftNum)
        Me.Controls.Add(Me.lblGiftCardNum)
        Me.Controls.Add(Me.lblCCVN)
        Me.Controls.Add(Me.txtCCVN)
        Me.Controls.Add(Me.lblExpDate)
        Me.Controls.Add(Me.txtExpirDate)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.txtCreditDebitNumber)
        Me.Controls.Add(Me.chkCash)
        Me.Controls.Add(Me.chkGift)
        Me.Controls.Add(Me.chkDebitCredit)
        Me.Controls.Add(Me.chkPaymentMethod)
        Me.Controls.Add(Me.txtGuestEmail)
        Me.Controls.Add(Me.lblGuestEmail)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkGuestCheck)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCboOpenTabs)
        Me.Controls.Add(Me.cboOpenTabs)
        Me.Name = "frmCloseTab"
        Me.Text = "Pub and Eatery Point of Sale - Close Out Tab"
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboOpenTabs As System.Windows.Forms.ComboBox
    Friend WithEvents lblCboOpenTabs As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkGuestCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblGuestEmail As System.Windows.Forms.Label
    Friend WithEvents txtGuestEmail As System.Windows.Forms.TextBox
    Friend WithEvents chkPaymentMethod As System.Windows.Forms.CheckBox
    Friend WithEvents chkDebitCredit As System.Windows.Forms.CheckBox
    Friend WithEvents chkGift As System.Windows.Forms.CheckBox
    Friend WithEvents chkCash As System.Windows.Forms.CheckBox
    Friend WithEvents txtCreditDebitNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCardNumber As System.Windows.Forms.Label
    Friend WithEvents lblExpDate As System.Windows.Forms.Label
    Friend WithEvents txtExpirDate As System.Windows.Forms.TextBox
    Friend WithEvents lblCCVN As System.Windows.Forms.Label
    Friend WithEvents txtCCVN As System.Windows.Forms.TextBox
    Friend WithEvents lblGiftCardNum As System.Windows.Forms.Label
    Friend WithEvents txtGiftNum As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblChangeDue As System.Windows.Forms.Label
    Friend WithEvents txtChangeDue As System.Windows.Forms.TextBox
    Friend WithEvents picEstabIcon As System.Windows.Forms.PictureBox
End Class
