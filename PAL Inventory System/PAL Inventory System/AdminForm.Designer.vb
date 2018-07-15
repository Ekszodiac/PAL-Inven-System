<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.signOutBut = New System.Windows.Forms.Button()
        Me.printBut = New System.Windows.Forms.Button()
        Me.editdelBut = New System.Windows.Forms.Button()
        Me.actmgmtBut = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.logBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.logBtn)
        Me.Panel1.Controls.Add(Me.actmgmtBut)
        Me.Panel1.Controls.Add(Me.signOutBut)
        Me.Panel1.Controls.Add(Me.printBut)
        Me.Panel1.Controls.Add(Me.editdelBut)
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 89)
        Me.Panel1.TabIndex = 0
        '
        'signOutBut
        '
        Me.signOutBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signOutBut.BackColor = System.Drawing.SystemColors.Control
        Me.signOutBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signOutBut.Location = New System.Drawing.Point(661, 3)
        Me.signOutBut.Name = "signOutBut"
        Me.signOutBut.Size = New System.Drawing.Size(98, 83)
        Me.signOutBut.TabIndex = 3
        Me.signOutBut.Text = "SIGN OUT"
        Me.signOutBut.UseVisualStyleBackColor = False
        '
        'printBut
        '
        Me.printBut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.printBut.BackColor = System.Drawing.SystemColors.Control
        Me.printBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBut.Location = New System.Drawing.Point(275, 4)
        Me.printBut.Name = "printBut"
        Me.printBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.printBut.Size = New System.Drawing.Size(98, 85)
        Me.printBut.TabIndex = 2
        Me.printBut.Text = "PRINT"
        Me.printBut.UseVisualStyleBackColor = False
        '
        'editdelBut
        '
        Me.editdelBut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.editdelBut.BackColor = System.Drawing.SystemColors.Control
        Me.editdelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editdelBut.Location = New System.Drawing.Point(135, 3)
        Me.editdelBut.Name = "editdelBut"
        Me.editdelBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.editdelBut.Size = New System.Drawing.Size(98, 85)
        Me.editdelBut.TabIndex = 1
        Me.editdelBut.Text = "EDIT/DELETE"
        Me.editdelBut.UseVisualStyleBackColor = False
        '
        'actmgmtBut
        '
        Me.actmgmtBut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.actmgmtBut.BackColor = System.Drawing.SystemColors.Control
        Me.actmgmtBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.actmgmtBut.Location = New System.Drawing.Point(527, 3)
        Me.actmgmtBut.Name = "actmgmtBut"
        Me.actmgmtBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.actmgmtBut.Size = New System.Drawing.Size(98, 85)
        Me.actmgmtBut.TabIndex = 4
        Me.actmgmtBut.Text = "ACCOUNT MANAGEMENT"
        Me.actmgmtBut.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(3, 4)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(98, 83)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "ADD "
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'lv1
        '
        Me.lv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv1.Location = New System.Drawing.Point(12, 108)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(778, 295)
        Me.lv1.TabIndex = 1
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'logBtn
        '
        Me.logBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logBtn.BackColor = System.Drawing.SystemColors.Control
        Me.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logBtn.Location = New System.Drawing.Point(406, 3)
        Me.logBtn.Name = "logBtn"
        Me.logBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logBtn.Size = New System.Drawing.Size(98, 83)
        Me.logBtn.TabIndex = 5
        Me.logBtn.Text = "LOGS"
        Me.logBtn.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents signOutBut As System.Windows.Forms.Button
    Friend WithEvents printBut As System.Windows.Forms.Button
    Friend WithEvents editdelBut As System.Windows.Forms.Button
    Friend WithEvents actmgmtBut As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents lv1 As System.Windows.Forms.ListView
    Friend WithEvents logBtn As System.Windows.Forms.Button
End Class
