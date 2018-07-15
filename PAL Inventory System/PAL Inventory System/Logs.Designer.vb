<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.logsView = New System.Windows.Forms.ListView()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logsView
        '
        Me.logsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logsView.Location = New System.Drawing.Point(12, 12)
        Me.logsView.Name = "logsView"
        Me.logsView.Size = New System.Drawing.Size(771, 419)
        Me.logsView.TabIndex = 0
        Me.logsView.UseCompatibleStateImageBehavior = False
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(700, 444)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 1
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeBut)
        Me.Controls.Add(Me.logsView)
        Me.Name = "Logs"
        Me.Text = "Logs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logsView As System.Windows.Forms.ListView
    Friend WithEvents closeBut As System.Windows.Forms.Button
End Class
