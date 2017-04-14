Imports MySql.Data.MySqlClient

Public Class UpdatePriceItem

    Private Sub UpdatePriceItem_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Dim a As Integer
        a = MsgBox("Are you sure do you want to exit?", MsgBoxStyle.YesNo)
        If (a = MsgBoxResult.Yes) Then
            AdminPanel.Show()
            Screen_Admin.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        price.Text = ""
        gradelvl.SelectedIndex = -1
        ItemName.SelectedIndex = -1
    End Sub

    Private Sub UpdatePriceItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height + 60)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2) - 10
    End Sub
    Private Sub gradelvl_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gradelvl.SelectedValueChanged
        Try
            cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT ItemName FROM items_tbl where gradelevel = '" & gradelvl.SelectedItem.ToString & "'"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                ItemName.Items.Clear()
                ItemName.Items.Add(r("ItemName").ToString())
                While (r.Read())
                    ItemName.Items.Add(r("ItemName").ToString())
                End While
            Else
                MessageBox.Show("No Items Found")
            End If
            cn.Close()
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'eto yung sql query natin, which is UPDATE.
            Dim reg1 As String = "UPDATE items_tbl SET 	price = '" & price.Text & "' WHERE ItemName = '" & ItemName.SelectedItem.ToString & "' and gradelevel = '" & gradelvl.SelectedItem.ToString & "' "
            'eto yung connection string natin, (insert() noon), cn1 dito.
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg1, cn1)
                    cn1.Open() 'open connection
                    sqlCmd.ExecuteNonQuery() 'execute sql query
                    price.Text = ""
                    gradelvl.SelectedIndex = -1
                    ItemName.SelectedIndex = -1
                    MsgBox("Item price successfully update.")
                    cn1.Close()
                End Using
                cn1.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try

    End Sub
End Class