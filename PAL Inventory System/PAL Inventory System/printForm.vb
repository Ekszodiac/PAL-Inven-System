Public Class printForm
    Public SQL As New SQLControl

    Private Sub printForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadItems()
    End Sub

    Private Sub loadItems()
        dgv2.Columns.Clear()
        SQL.ExecQuery("SELECT log_action as 'ACTION', log_paltag AS 'PALTAG', log_userID as 'USER', log_timestamp as 'TIMESTAMP', log_loc as 'LOCATION', log_dept AS 'DEPARTMENT' FROM logs")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        checkCol.HeaderText = "Checkbox"
        checkCol.Name = "CheckCol"

        dgv2.Columns.Add(checkCol)
        dgv2.DataSource = SQL.DBDT
        dgv2.ReadOnly = False

        dgv2.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("ACTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("USER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("LOCATION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("DEPARTMENT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub

    Private Sub printBut_Click(sender As Object, e As EventArgs) Handles printBut.Click
        printReports.Show()
    End Sub

    Private Sub cancelBut_Click(sender As Object, e As EventArgs) Handles cancelBut.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.LoadInven()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        dgv2.Columns.Clear()
        SQL.AddParam("@item", "%" & txtbxSearch.Text & "%")
        SQL.ExecQuery("SELECT log_action as 'ACTION', log_paltag AS 'PALTAG', log_userID as 'USER', log_timestamp as 'TIMESTAMP', log_loc as 'LOCATION', log_dept AS 'DEPARTMENT' FROM logs WHERE log_action LIKE @item OR log_paltag LIKE @item OR log_userID LIKE @item OR log_loc LIKE @item OR log_dept LIKE @item;")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        checkCol.HeaderText = "Checkbox"
        checkCol.Name = "CheckCol"

        dgv2.Columns.Add(checkCol)
        dgv2.DataSource = SQL.DBDT
        dgv2.ReadOnly = False

        dgv2.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("ACTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("USER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("LOCATION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("DEPARTMENT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub
End Class