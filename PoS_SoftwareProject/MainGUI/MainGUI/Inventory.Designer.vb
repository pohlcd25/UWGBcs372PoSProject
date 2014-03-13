<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtLow = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.chkAdd = New System.Windows.Forms.CheckBox()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(51, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 394)
        Me.ListBox1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(367, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(261, 20)
        Me.txtName.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(367, 176)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 20)
        Me.txtQty.TabIndex = 2
        '
        'txtLow
        '
        Me.txtLow.Location = New System.Drawing.Point(367, 241)
        Me.txtLow.Name = "txtLow"
        Me.txtLow.Size = New System.Drawing.Size(100, 20)
        Me.txtLow.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(367, 30)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(58, 13)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "Item Name"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(367, 150)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(92, 13)
        Me.lblQty.TabIndex = 5
        Me.lblQty.Text = "Quantity On Hand"
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Location = New System.Drawing.Point(367, 215)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(99, 13)
        Me.lblLow.TabIndex = 6
        Me.lblLow.Text = "Low Level Warning"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(367, 91)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(60, 13)
        Me.lblDesc.TabIndex = 8
        Me.lblDesc.Text = "Description"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(367, 118)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(445, 20)
        Me.txtDesc.TabIndex = 7
        '
        'chkAdd
        '
        Me.chkAdd.AutoSize = True
        Me.chkAdd.Location = New System.Drawing.Point(367, 292)
        Me.chkAdd.Name = "chkAdd"
        Me.chkAdd.Size = New System.Drawing.Size(85, 17)
        Me.chkAdd.TabIndex = 9
        Me.chkAdd.Text = "New Stock?"
        Me.chkAdd.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(469, 292)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(123, 13)
        Me.lblAdd.TabIndex = 11
        Me.lblAdd.Text = "Quantity to Add to Stock"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(469, 318)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtAdd.TabIndex = 10
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(355, 361)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(87, 23)
        Me.btnPrev.TabIndex = 12
        Me.btnPrev.Text = "Previous Item"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(471, 361)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(568, 361)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save Item"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(667, 361)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next Item"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(515, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 462)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.chkAdd)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtLow)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmInventory"
        Me.Text = "Pub and Eatery Point of Sale - Inventory Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtLow As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblLow As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents chkAdd As System.Windows.Forms.CheckBox
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
