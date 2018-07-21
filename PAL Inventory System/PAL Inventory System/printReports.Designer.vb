<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printReports
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
        Me.viewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'viewer1
        '
        Me.viewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewer1.Location = New System.Drawing.Point(12, 12)
        Me.viewer1.Name = "viewer1"
        Me.viewer1.Size = New System.Drawing.Size(413, 251)
        Me.viewer1.TabIndex = 0
        '
        'printReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 275)
        Me.Controls.Add(Me.viewer1)
        Me.Name = "printReports"
        Me.Text = "Print Inventory"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
