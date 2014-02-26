<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabManagement
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
        Me.btnNewBar = New System.Windows.Forms.Button()
        Me.btnNewTable = New System.Windows.Forms.Button()
        Me.btnCloseTab = New System.Windows.Forms.Button()
        Me.btnEditTab = New System.Windows.Forms.Button()
        Me.picEstabIcon = New System.Windows.Forms.PictureBox()
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewBar
        '
        Me.btnNewBar.Location = New System.Drawing.Point(313, 156)
        Me.btnNewBar.Name = "btnNewBar"
        Me.btnNewBar.Size = New System.Drawing.Size(85, 56)
        Me.btnNewBar.TabIndex = 0
        Me.btnNewBar.Text = "Open Bar Tab"
        Me.btnNewBar.UseVisualStyleBackColor = True
        '
        'btnNewTable
        '
        Me.btnNewTable.Location = New System.Drawing.Point(434, 156)
        Me.btnNewTable.Name = "btnNewTable"
        Me.btnNewTable.Size = New System.Drawing.Size(85, 56)
        Me.btnNewTable.TabIndex = 1
        Me.btnNewTable.Text = "Open Table Tab"
        Me.btnNewTable.UseVisualStyleBackColor = True
        '
        'btnCloseTab
        '
        Me.btnCloseTab.Location = New System.Drawing.Point(434, 246)
        Me.btnCloseTab.Name = "btnCloseTab"
        Me.btnCloseTab.Size = New System.Drawing.Size(85, 56)
        Me.btnCloseTab.TabIndex = 2
        Me.btnCloseTab.Text = "Close Tab"
        Me.btnCloseTab.UseVisualStyleBackColor = True
        '
        'btnEditTab
        '
        Me.btnEditTab.Location = New System.Drawing.Point(313, 246)
        Me.btnEditTab.Name = "btnEditTab"
        Me.btnEditTab.Size = New System.Drawing.Size(85, 56)
        Me.btnEditTab.TabIndex = 3
        Me.btnEditTab.Text = "Edit Tab"
        Me.btnEditTab.UseVisualStyleBackColor = True
        '
        'picEstabIcon
        '
        Me.picEstabIcon.Location = New System.Drawing.Point(683, 13)
        Me.picEstabIcon.Name = "picEstabIcon"
        Me.picEstabIcon.Size = New System.Drawing.Size(164, 102)
        Me.picEstabIcon.TabIndex = 4
        Me.picEstabIcon.TabStop = False
        '
        'frmTabManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 462)
        Me.Controls.Add(Me.picEstabIcon)
        Me.Controls.Add(Me.btnEditTab)
        Me.Controls.Add(Me.btnCloseTab)
        Me.Controls.Add(Me.btnNewTable)
        Me.Controls.Add(Me.btnNewBar)
        Me.Name = "frmTabManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pub and Eatery Point of Sale - Tab Management"
        CType(Me.picEstabIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewBar As System.Windows.Forms.Button
    Friend WithEvents btnNewTable As System.Windows.Forms.Button
    Friend WithEvents btnCloseTab As System.Windows.Forms.Button
    Friend WithEvents btnEditTab As System.Windows.Forms.Button
    Friend WithEvents picEstabIcon As System.Windows.Forms.PictureBox

End Class
