Imports MySql.Data.MySqlClient

Public Class SearchStudent
    Private Sub SearchStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM from student_info  "
        Dim Adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "student_info")
        DataGridView1.DataSource = ds.Tables(0)
        Dim studentCount As Integer
        studentCount = DataGridView1.RowCount
        Dim column As DataGridViewColumn = DataGridView1.Columns(0)
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        lblNoOfStudent.Text = studentCount

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub filterText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles filterText.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub filterText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterText.TextChanged
        If (filterBox.SelectedItem = "") Then
        ElseIf filterBox.SelectedItem = "GradeLevel" Or filterBox.SelectedItem = "Section" Then

            Dim selected As String = filterBox.SelectedItem.ToString
            Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
            Dim con As New MySqlConnection(str)
            'Dim com As String = "select * From student_info where Student_ID_No like'%" & filterText.Text & "%'"
            Dim com As String = "select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM From student_info where " & selected & " like'%" & filterText.Text & "%'"
            Dim Adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "student_info")
            DataGridView1.DataSource = ds.Tables(0)
            Dim studentCount As Integer
            studentCount = DataGridView1.RowCount
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            lblNoOfStudent.Text = studentCount
        Else
            Dim selected As String = filterBox.SelectedItem.ToString
            Dim str As String = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
            Dim con As New MySqlConnection(str)
            'Dim com As String = "select * From student_info where Student_ID_No like'%" & filterText.Text & "%'"
            Dim com As String = "select Student_ID_No, LastName, GivenName, MiddleName, Birthday, Gender, SchoolYear, GradeLevel, Section, MotherName, OccupationM From student_info where " & selected & " like'%" & filterText.Text & "%'"
            Dim Adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()
            Adpt.Fill(ds, "student_info")
            DataGridView1.DataSource = ds.Tables(0)
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            AdminPanel.Show()
            Screen_Admin.Show()
            Me.Close()
        End If
    End Sub
End Class