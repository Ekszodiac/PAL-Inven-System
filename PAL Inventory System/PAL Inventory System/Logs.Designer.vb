﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logs
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
        Me.closeBut = New System.Windows.Forms.Button()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.editdelBut = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(540, 461)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 1
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'dgv3
        '
        Me.dgv3.AllowUserToAddRows = False
        Me.dgv3.AllowUserToDeleteRows = False
        Me.dgv3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(13, 127)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.ReadOnly = True
        Me.dgv3.Size = New System.Drawing.Size(602, 328)
        Me.dgv3.TabIndex = 2
        '
        'editdelBut
        '
        Me.editdelBut.BackColor = System.Drawing.SystemColors.Control
        Me.editdelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editdelBut.Location = New System.Drawing.Point(330, 11)
        Me.editdelBut.Name = "editdelBut"
        Me.editdelBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.editdelBut.Size = New System.Drawing.Size(98, 85)
        Me.editdelBut.TabIndex = 4
        Me.editdelBut.Text = "EDIT/DELETE"
        Me.editdelBut.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(198, 12)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(98, 83)
        Me.addBtn.TabIndex = 3
        Me.addBtn.Text = "ADD "
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.editdelBut)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.dgv3)
        Me.Controls.Add(Me.closeBut)
        Me.Name = "Logs"
        Me.Text = "Logs"
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents editdelBut As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
End Class
