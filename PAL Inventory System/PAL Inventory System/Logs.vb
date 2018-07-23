Public Class Logs
    Public SQL As New SQLControl

    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadLogs()
    End Sub

    Private Sub LoadLogs()
        SQL.ExecQuery("SELECT log_action as 'ACTION', log_paltag AS 'PALTAG', log_userID as 'USER', log_timestamp as 'TIMESTAMP', log_loc as 'LOCATION', log_dept AS 'DEPARTMENT' FROM logs")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkCol.HeaderText = "CheckBox"
        checkCol.Name = "CheckCol"

        dgv3.Columns.Add(checkCol)
        dgv3.DataSource = SQL.DBDT
        dgv3.ReadOnly = False

        dgv3.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("ACTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("USER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("LOCATION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("DEPARTMENT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellContentClick
        If e.ColumnIndex = dgv3.Columns("CheckCol").Index Then
            DataGridViewCheckBoxColumn_Uncheck()
            Dim cell As DataGridViewCheckBoxCell = dgv3.Rows(e.RowIndex).Cells("CheckCol")
            cell.Value = cell.TrueValue
        End If
    End Sub

    Private Sub DataGridViewCheckBoxColumn_Uncheck()
        For Each row As DataGridViewRow In dgv3.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells("CheckCol")
            cell.Value = cell.FalseValue
        Next
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.LoadInven()
    End Sub
End Class