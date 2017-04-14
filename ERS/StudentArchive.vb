Imports MySql.Data.MySqlClient

Public Class StudentArchive
    Private Sub StudentArchive_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      Dim a As Integer
        a = MsgBox("Are you sure do you want to cancel?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            Screen_Admin.Enabled = True
            Screen_Admin.Show()
            AdminPanel.Show()
        End If
    End Sub
    Private Sub StudentArchive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM from student_info_archive  "
        Dim Adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "student_info")
        DataGridView1.DataSource = ds.Tables(0)
        Dim studentCount As Integer
        studentCount = DataGridView1.RowCount
        Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub filterText_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sn.MouseClick
        Dim a As String
        a = DataGridView1.CurrentCell.Value.ToString()
        sn.Text = a
    End Sub

    Private Sub filterText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sn.TextChanged
        Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
        Dim con As New MySqlConnection(str)
        'Dim com As String = "select * From student_info where Student_ID_No like'%" & filterText.Text & "%'"
        Dim com As String = "select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM From student_info_archive where Student_ID_No like'%" & sn.Text & "%'"
        Dim Adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "student_info")
        DataGridView1.DataSource = ds.Tables(0)
        Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub

    Private Sub Retrieve_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retrieve_btn.Click

        retrieve123_btn()
        insertArchive()
        sn.Clear()
    End Sub
End Class