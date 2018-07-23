Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class printReports
    Public SQL As SQLControl

    Private Sub printReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub showRep_Click_1(sender As Object, e As EventArgs) Handles showRep.Click
        Dim report As New PALInventory

        Dim dt As New DataTable

        With dt
            .Columns.Add("log_action")
            .Columns.Add("log_paltag")
            .Columns.Add("log_userID")
            .Columns.Add("log_timestamp")
            .Columns.Add("log_loc")
            .Columns.Add("log_dept")
        End With

        For Each dr As DataGridViewRow In printForm.dgv2.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(dr.Cells("checkCol").Value)
            If isSelected Then
                dt.Rows.Add(dr.Cells("ACTION").Value, dr.Cells("PALTAG").Value, dr.Cells("USER").Value, dr.Cells("TIMESTAMP").Value, dr.Cells("LOCATION").Value, dr.Cells("DEPARTMENT").Value)
            End If
        Next

        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New PALInventory
        rptDoc.SetDataSource(dt)
        crv1.ReportSource = rptDoc
    End Sub
End Class