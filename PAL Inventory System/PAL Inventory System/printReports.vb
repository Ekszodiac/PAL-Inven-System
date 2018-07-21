Public Class printReports

    Private Sub printReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.viewer1.RefreshReport()
    End Sub

    Private Sub viewer1_Load(sender As Object, e As EventArgs) Handles viewer1.Load

    End Sub
End Class