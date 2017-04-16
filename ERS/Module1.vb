Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing.Imaging
Module Module1
    Public pic As String
    Public cn1 As New MySqlConnection
    Public cn As New MySqlConnection
    Public r As MySqlDataReader
    Public ins As New MySqlCommand
    Public objConn As New MySqlConnection
    Public encodeType As ImageFormat = ImageFormat.Jpeg
    Public decoding As String = String.Empty
    Public Address As String
    Public Birthday As String
    Public GradeLevel As String
    Public SchoolYear As String
    Public MotherName As String
    Public MotherOccupation As String
    Public FatherName As String
    Public age As String
    Public FatherOccupation As String
    Public Gender As String
    Public Guardian As String
    Public Relation As String
    Public Contact As String
    Public AddressLastSchool As String
    Public NameLastSchool As String
    Public Section As String
    Public Birthplace As String
    Public Scholar As String
    Public FirstN As String
    Public StudentNo As String
    Public MiddleN As String
    Public LastN As String
    Public religion As String
    Public Citizen As String
    Public NSO2 As String = "none"
    Public baptis As String = "none"
    Public card As String = "none"
    Public form137 As String = "none"
    Public goodMoral As String = "none"

    Public server As String = "192.168.254.115" 'papalitan to ng ip address ng server pag need na siya i connect sa LAN
    Public port As String = "3306" 'gagawing 3306 to pag need na i connect sa LAN, or kung anong port yung na set natin
    Public user As String = "ers_admin" 'for now, root yung user, pero, magdadagdag tayo ng new username pag LAN
    Public password As String = "1234" 'no password si root dun sa wamp natin, so leave it empty
    Public database As String = "ers" ' eto yung name ng database natin, ers.

    'Public server As String = "127.0.0.1" 'papalitan to ng ip address ng server pag need na siya i connect sa LAN
    'Public port As String = "" 'gagawing 3306 to pag need na i connect sa LAN, or kung anong port yung na set natin
    'Public user As String = "root" 'for now, root yung user, pero, magdadagdag tayo ng new username pag LAN
    'Public password As String = "" 'no password si root dun sa wamp natin, so leave it empty
    'Public database As String = "ers" ' eto yung name ng database natin, ers.
    Public Sub splash()
        'connection string na ginagamit ng system natin para mag connect sa database
        cn.ConnectionString = "server= '" & server & "';port= '" & port & "';userid= '" & user & "';password= '" & password & "';database='" & database & "'"
        cn.Open()

        'change
        'Splash screen if database is null
        Dim stm As String = "SELECT * FROM admin WHERE EmployeeID IS NOT NULL"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, cn)
        Dim r As MySqlDataReader
        r = cmd.ExecuteReader()
        'pag may laman si admin table sa database natin, show yung MainScreen para makapag login
        If r.Read Then
            MainScreen.Show()
            My.Forms.SplashScreen1.Close()
            cn.Close()
            'else, show yung AdminCreate para magcreate ng Admin Account.
        Else
            My.Forms.AdminCreate.Button5.Visible = False 'hina hide nito yung cancel button'
            AdminCreate.Show()
            My.Forms.SplashScreen1.Close()
            cn.Close()
        End If
    End Sub
    Public Sub registrarPanelDisplay()
        cn.Close()
        insert()
        Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.RegistrarPanel.empl.Text & "')"
        cn1.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
        r = cmd.ExecuteReader()
        If r.Read Then
            My.Forms.RegistrarPanel.n1.Text = r("Surname").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
            My.Forms.RegistrarPanel.email.Text = r("Email_Account").ToString() & "."
            My.Forms.RegistrarPanel.cn.Text = r("ContactNumber").ToString() & "."
            pic = r("Photo").ToString()
            cn1.Close()
        Else
            MsgBox("Employee number not Found!")
            cn1.Close()
        End If
    End Sub
    Public Sub createAdmin()

        'reSurname as Regex, nire require si user na alpha number yung itype sa password para
        'atleast strong yung password (kaya ka ipaglaban) haha.
        Dim reSurname As New Regex("^.*(?=.*[a-zA-Z])(?=.*\d)(?=.*[\.@_-]).*$")

        If Not reSurname.IsMatch(My.Forms.AdminCreate.pw.Text) Then
            MsgBox("AlphaNumericSymbol needed to Password!")
            My.Forms.AdminCreate.pw.Clear()

        ElseIf (My.Forms.AdminCreate.ln.Text = "" Or My.Forms.AdminCreate.fn.Text = "" Or My.Forms.AdminCreate.mn.Text = "" Or My.Forms.AdminCreate.bd.Text = "" Or My.Forms.AdminCreate.add.Text = "" Or My.Forms.AdminCreate.eadd.Text = "" Or My.Forms.AdminCreate.cno.Text = "" Or My.Forms.AdminCreate.sq1.SelectedItem = "" Or My.Forms.AdminCreate.sq2.SelectedItem = "" Or My.Forms.AdminCreate.ans1.Text = "" Or My.Forms.AdminCreate.ans2.Text = "" Or My.Forms.AdminCreate.en.Text = "" Or My.Forms.AdminCreate.pw.Text = "" Or My.Forms.AdminCreate.rtp.Text = "") Then
            MsgBox("Fill the empty box")
        Else
            'if no errors, save sa tables, which is sa accounts table(dito naka store lahat ng usernames ni admin, cashier, and registrar)'
            'and sa admin table (kasi gumagawa tayo ng admin account)
            If (My.Forms.AdminCreate.rtp.Text = My.Forms.AdminCreate.pw.Text) Then

                'bakit 2 yung connection string natin? yung isa, gagamitin for admin table, yung isa, para kay accounts table
                'remember, every time na magccreate tayo ng user account, automatic na nagse save siya kay accounts table.
                'why? to avoid repetitions. best practice na unique ang bawat username ni admin, cashier, and registrar.

                'eto yung ginamit na connection string for admin table
                Dim objConn As New MySqlConnection
                Dim ins As New MySqlCommand
                Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn.ConnectionString = cn
                objConn.Open()

                'eto yung ginamit na connection string for accounts table
                Dim objConn1 As New MySqlConnection
                Dim ins1 As New MySqlCommand
                Dim cn1 = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn1.ConnectionString = cn1
                objConn1.Open()

                Dim b As String = My.Forms.AdminCreate.bd.Value.ToString("MM/dd/yyyy")
                Try
                    ins1.Connection = objConn1

                    'first Try, iiinsert kay accounts yung value nung employee id text box.
                    'pag hindi pa existing, mai insert siya, else, error. (check yung pinaka huling Catch)
                    ins1.CommandText = "INSERT INTO accounts VALUES(@EmployeeID)"
                    ins1.Parameters.AddWithValue("@EmployeeID", My.Forms.AdminCreate.en.Text) 'mispelled variable lol si tolits. haha
                    ins1.ExecuteNonQuery() 'need din nito dito para pumasok sa accounts table si admin
                    Try
                        'second try, iiinsert kay admin tables yung value nung employee id text box.
                        ins.Connection = objConn

                        'admin create (insert to database)
                        ins.CommandText = "INSERT INTO admin VALUES(@Photo, @Surname, @GivenName, @MiddleName, @Birthday, @Address, @Email_Account, @ContactNumber, @Security_Question1, @Answer1, @Security_Question2, @Answer2, @EmployeeID, @Password, @status, @LogIn_Attempts)"
                        ins.Parameters.AddWithValue("@Photo", pic)
                        ins.Parameters.AddWithValue("@Surname", My.Forms.AdminCreate.ln.Text)
                        ins.Parameters.AddWithValue("@GivenName", My.Forms.AdminCreate.fn.Text)
                        ins.Parameters.AddWithValue("@MiddleName", My.Forms.AdminCreate.mn.Text)
                        ins.Parameters.AddWithValue("@Birthday", b)
                        ins.Parameters.AddWithValue("@Address", My.Forms.AdminCreate.add.Text)
                        ins.Parameters.AddWithValue("@Email_Account", My.Forms.AdminCreate.eadd.Text)
                        ins.Parameters.AddWithValue("@ContactNumber", My.Forms.AdminCreate.cno.Text)
                        ins.Parameters.AddWithValue("@Security_Question1", My.Forms.AdminCreate.sq1.Text)
                        ins.Parameters.AddWithValue("@Answer1", My.Forms.AdminCreate.ans1.Text)
                        ins.Parameters.AddWithValue("@Security_Question2", My.Forms.AdminCreate.sq2.Text)
                        ins.Parameters.AddWithValue("@Answer2", My.Forms.AdminCreate.ans2.Text)
                        ins.Parameters.AddWithValue("@EmployeeID", My.Forms.AdminCreate.en.Text)
                        ins.Parameters.AddWithValue("@Password", My.Forms.AdminCreate.pw.Text)
                        ins.Parameters.AddWithValue("@status", "Active")
                        ins.Parameters.AddWithValue("@LogIn_Attempts", 0)
                        ins.ExecuteNonQuery()
                        My.Forms.AdminCreate.pw.Text = ""
                        My.Forms.AdminCreate.rtp.Text = ""
                        pic = ""
                        MsgBox("Admin Account Successfully Created!")
                        My.Forms.AdminCreate.ln.Focus()
                        MainScreen.Show()
                        My.Forms.AdminCreate.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate_1.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate.Close()
                        Screen_Admin.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch
                    'eto yung catch pag existing na yung username sa accounts table.
                    MessageBox.Show("Account already exists in the database")
                End Try
            Else
                MsgBox("Passwords did'nt match!")
                My.Forms.AdminCreate.pw.Text = ""
                My.Forms.AdminCreate.rtp.Text = ""
                My.Forms.AdminCreate.pw.Focus()
            End If
        End If
    End Sub

    Public Sub createAdmin_1()
        Dim reSurname As New Regex("^.*(?=.*[a-zA-Z])(?=.*\d)(?=.*[\.@_-]).*$")

        If Not reSurname.IsMatch(My.Forms.AdminCreate_1.pw.Text) Then
            MsgBox("AlphaNumericSymbol needed to Password!")
            My.Forms.AdminCreate_1.pw.Clear()

        ElseIf (My.Forms.AdminCreate_1.ln.Text = "" Or My.Forms.AdminCreate_1.fn.Text = "" Or My.Forms.AdminCreate_1.mn.Text = "" Or My.Forms.AdminCreate_1.bd.Text = "" Or My.Forms.AdminCreate_1.add.Text = "" Or My.Forms.AdminCreate_1.eadd.Text = "" Or My.Forms.AdminCreate_1.cno.Text = "" Or My.Forms.AdminCreate_1.sq1.SelectedItem = "" Or My.Forms.AdminCreate_1.sq2.SelectedItem = "" Or My.Forms.AdminCreate_1.ans1.Text = "" Or My.Forms.AdminCreate_1.ans2.Text = "" Or My.Forms.AdminCreate_1.en.Text = "" Or My.Forms.AdminCreate_1.pw.Text = "" Or My.Forms.AdminCreate_1.rtp.Text = "") Then
            MsgBox("Fill the empty box")
        Else
            'if no errors, save sa tables, which is sa accounts table(dito naka store lahat ng usernames ni admin, cashier, and registrar)'
            'and sa admin table (kasi gumagawa tayo ng admin account)
            If (My.Forms.AdminCreate_1.rtp.Text = My.Forms.AdminCreate_1.pw.Text) Then

                'bakit 2 yung connection string natin? yung isa, gagamitin for admin table, yung isa, para kay accounts table
                'remember, every time na magccreate tayo ng user account, automatic na nagse save siya kay accounts table.
                'why? to avoid repetitions. best practice na unique ang bawat username ni admin, cashier, and registrar.

                'eto yung ginamit na connection string for admin table
                Dim objConn As New MySqlConnection
                Dim ins As New MySqlCommand
                Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn.ConnectionString = cn
                objConn.Open()

                'eto yung ginamit na connection string for accounts table
                Dim objConn1 As New MySqlConnection
                Dim ins1 As New MySqlCommand
                Dim cn1 = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn1.ConnectionString = cn1
                objConn1.Open()


                Try
                    ins1.Connection = objConn1
                    Dim b As String = My.Forms.AdminCreate_1.bd.Value.ToString("MM/dd/yyyy")
                    'first Try, iiinsert kay accounts yung value nung employee id text box.
                    'pag hindi pa existing, mai insert siya, else, error. (check yung pinaka huling Catch)
                    ins1.CommandText = "INSERT INTO accounts VALUES(@EmployeeID)"
                    ins1.Parameters.AddWithValue("@EmployeeID", My.Forms.AdminCreate_1.en.Text) 'mispelled variable lol si tolits. haha
                    ins1.ExecuteNonQuery() 'need din nito dito para pumasok sa accounts table si admin
                    Try
                        'second try, iiinsert kay admin tables yung value nung employee id text box.
                        ins.Connection = objConn

                        'admin create (insert to database)
                        ins.CommandText = "INSERT INTO admin VALUES(@Photo, @Surname, @GivenName, @MiddleName, @Birthday, @Address, @Email_Account, @ContactNumber, @Security_Question1, @Answer1, @Security_Question2, @Answer2, @EmployeeID, @Password, @status, @LogIn_Attempts)"
                        ins.Parameters.AddWithValue("@Photo", pic)
                        ins.Parameters.AddWithValue("@Surname", My.Forms.AdminCreate_1.ln.Text)
                        ins.Parameters.AddWithValue("@GivenName", My.Forms.AdminCreate_1.fn.Text)
                        ins.Parameters.AddWithValue("@MiddleName", My.Forms.AdminCreate_1.mn.Text)
                        ins.Parameters.AddWithValue("@Birthday", b)
                        ins.Parameters.AddWithValue("@Address", My.Forms.AdminCreate_1.add.Text)
                        ins.Parameters.AddWithValue("@Email_Account", My.Forms.AdminCreate_1.eadd.Text)
                        ins.Parameters.AddWithValue("@ContactNumber", My.Forms.AdminCreate_1.cno.Text)
                        ins.Parameters.AddWithValue("@Security_Question1", My.Forms.AdminCreate_1.sq1.Text)
                        ins.Parameters.AddWithValue("@Answer1", My.Forms.AdminCreate_1.ans1.Text)
                        ins.Parameters.AddWithValue("@Security_Question2", My.Forms.AdminCreate_1.sq2.Text)
                        ins.Parameters.AddWithValue("@Answer2", My.Forms.AdminCreate_1.ans2.Text)
                        ins.Parameters.AddWithValue("@EmployeeID", My.Forms.AdminCreate_1.en.Text)
                        ins.Parameters.AddWithValue("@Password", My.Forms.AdminCreate_1.pw.Text)
                        ins.Parameters.AddWithValue("@status", "Active")
                        ins.Parameters.AddWithValue("@LogIn_Attempts", 0)
                        ins.ExecuteNonQuery()
                        pic = ""
                        My.Forms.AdminCreate_1.pw.Text = ""
                        My.Forms.AdminCreate_1.rtp.Text = ""
                        MsgBox("Admin Account Successfully Created!")
                        My.Forms.AdminCreate_1.ln.Focus()
                        Screen_Admin.Enabled = True
                        My.Forms.AdminPanel.Show()
                        My.Forms.AdminCreate_1.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate_1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch
                    'eto yung catch pag existing na yung username sa accounts table.
                    MessageBox.Show("Account already exists in the database!")
                End Try
            Else
                MsgBox("Passwords did'nt match!")
                My.Forms.AdminCreate_1.pw.Text = ""
                My.Forms.AdminCreate_1.rtp.Text = ""
                My.Forms.AdminCreate_1.pw.Focus()
            End If
        End If
    End Sub
    Public Sub registrarCreate1()
        'reSurname as Regex, same lang din sa explanation nung sa create ng admin,
        'ang use ni regex is para kaya kang ipaglaban ng password mo sa mga 'hackers'. haha 

        'actually, same lang din ito nung sa create admin account guys. same code lang,
        'ang nababago lang dito is yung sql queries
        'dun sa admin create, INSERT INTO admin, dito naman, since registrar ginagawa natin,
        'check niyo yung sql query, INSERT INTO registrar_account lang yung nagbago. yun lang naman yung nagbabago dito,
        'saka minsan yung feelings niya para sayo. hahaha!
        Dim reSurname As New Regex("^.*(?=.*[a-zA-Z])(?=.*\d)(?=.*[\.@_-]).*$")
        If Not reSurname.IsMatch(My.Forms.RegistrarCreate.pw.Text) Then
            MsgBox("AlphaNumericSymbol needed to Password!")
            My.Forms.RegistrarCreate.pw.Clear()

        ElseIf (My.Forms.RegistrarCreate.ln.Text = "" Or My.Forms.RegistrarCreate.fn.Text = "" Or My.Forms.RegistrarCreate.mn.Text = "" Or My.Forms.RegistrarCreate.bd.Text = "" Or My.Forms.RegistrarCreate.add.Text = "" Or My.Forms.RegistrarCreate.eadd.Text = "" Or My.Forms.RegistrarCreate.cno.Text = "" Or My.Forms.RegistrarCreate.sq1.SelectedItem = "" Or My.Forms.RegistrarCreate.sq2.SelectedItem = "" Or My.Forms.RegistrarCreate.ans1.Text = "" Or My.Forms.RegistrarCreate.ans2.Text = "" Or My.Forms.RegistrarCreate.en.Text = "" Or My.Forms.RegistrarCreate.pw.Text = "" Or My.Forms.RegistrarCreate.rtp.Text = "") Then
            MsgBox("Fill the empty box")
        Else
            If (My.Forms.RegistrarCreate.rtp.Text = My.Forms.RegistrarCreate.pw.Text) Then

                'alam na natin kung bakit dalawa yung connection string natin ha?
                'yung isang connection string, para sa accounts, yung isa para sa kung san natin ise save.
                'ang iccheck niyo lagi is yung ins or ins1 para malaman niyo kung para san yung object connection.

                Dim objConn As New MySqlConnection
                Dim ins As New MySqlCommand 'eto yung ins
                Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn.ConnectionString = cn
                objConn.Open()

                Dim objConn1 As New MySqlConnection
                Dim ins1 As New MySqlCommand 'eto yung ins1database
                Dim cn1 = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                objConn1.ConnectionString = cn1
                objConn1.Open()
                Try
                    ins1.Connection = objConn1

                    'accounts table to avoid repeatition of EmployeeID
                    ins1.CommandText = "INSERT INTO accounts VALUES(@EmployeeID)" 'ins1 yung ginamit dito, so si ins1 ay para sa pag insert ng username sa accounts table
                    ins1.Parameters.AddWithValue("@EmployeeID", My.Forms.RegistrarCreate.en.Text)
                    ins1.ExecuteNonQuery()
                    Try
                        ins.Connection = objConn 'ins lang yung ginamit dito, so ginamit siya para sa pag save sa registrar. check niyo yung sa admin saka sa cashier.
                        Dim b As String = My.Forms.RegistrarCreate.bd.Value.ToString("MM/dd/yyyy")
                        'registrar create (insert to database)
                        ins.CommandText = "INSERT INTO registrar_account VALUES(@Photo, @Surname, @GivenName, @MiddleName, @Birthday, @Address, @Email_Account, @ContactNumber, @Security_Question1, @Answer1, @Security_Question2, @Answer2, @EmployeeID, @Password, @status, @LogIn_Attempts)"

                        ins.Parameters.AddWithValue("@Photo", pic)
                        ins.Parameters.AddWithValue("@Surname", My.Forms.RegistrarCreate.ln.Text)
                        ins.Parameters.AddWithValue("@GivenName", My.Forms.RegistrarCreate.fn.Text)
                        ins.Parameters.AddWithValue("@MiddleName", My.Forms.RegistrarCreate.mn.Text)
                        ins.Parameters.AddWithValue("@Birthday", b)
                        ins.Parameters.AddWithValue("@Address", My.Forms.RegistrarCreate.add.Text)
                        ins.Parameters.AddWithValue("@Email_Account", My.Forms.RegistrarCreate.eadd.Text)
                        ins.Parameters.AddWithValue("@ContactNumber", My.Forms.RegistrarCreate.cno.Text)
                        ins.Parameters.AddWithValue("@Security_Question1", My.Forms.RegistrarCreate.sq1.Text)
                        ins.Parameters.AddWithValue("@Answer1", My.Forms.RegistrarCreate.ans1.Text)
                        ins.Parameters.AddWithValue("@Security_Question2", My.Forms.RegistrarCreate.sq2.Text)
                        ins.Parameters.AddWithValue("@Answer2", My.Forms.RegistrarCreate.ans2.Text)
                        ins.Parameters.AddWithValue("@EmployeeID", My.Forms.RegistrarCreate.en.Text)
                        ins.Parameters.AddWithValue("@Password", My.Forms.RegistrarCreate.pw.Text)
                        ins.Parameters.AddWithValue("@status", "Active")
                        ins.Parameters.AddWithValue("@LogIn_Attempts", 0)
                        ins.ExecuteNonQuery()
                        pic = ""
                        My.Forms.RegistrarCreate.pw.Text = ""
                        My.Forms.RegistrarCreate.rtp.Text = ""
                        MsgBox("Registrar Account Successfully Created!")
                        My.Forms.RegistrarCreate.ln.Focus()
                        AdminPanel.Show()
                        My.Forms.RegistrarCreate.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate_1.PictureBox1.Image = Nothing
                        My.Forms.RegistrarCreate.Close()
                        Screen_Admin.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch
                    'same lang din, eto yung catch para dun sa first try, which is error kung existing na yung username
                    'sa accounts table.
                    MessageBox.Show("Account already exists in the database!")
                End Try
            Else
                MsgBox("Passwords did'nt match!")
                My.Forms.RegistrarCreate.pw.Text = ""
                My.Forms.RegistrarCreate.rtp.Text = ""
                My.Forms.RegistrarCreate.pw.Focus()
            End If
        End If
    End Sub
    Public Sub createCashier()
        'create cashier. as usual, ganun pa din. same lang naman yung code.
        'ang pagkakaiba lang is, yung SQL Query.
        'INSERT INTO cashier_account naman dito. kasi cashier account yung ginagawa natin
        Dim reSurname As New Regex("^.*(?=.*[a-zA-Z])(?=.*\d)(?=.*[\.@_-]).*$")
        If Not reSurname.IsMatch(My.Forms.CashierCreate.pw.Text) Then
            MsgBox("AlphaNumericSymbol needed to Password!")
            My.Forms.CashierCreate.pw.Clear()

        ElseIf (My.Forms.CashierCreate.ln.Text = "" Or My.Forms.CashierCreate.fn.Text = "" Or My.Forms.CashierCreate.mn.Text = "" Or My.Forms.CashierCreate.bd.Text = "" Or My.Forms.CashierCreate.add.Text = "" Or My.Forms.CashierCreate.eadd.Text = "" Or My.Forms.CashierCreate.cno.Text = "" Or My.Forms.CashierCreate.sq1.SelectedItem = "" Or My.Forms.CashierCreate.sq2.SelectedItem = "" Or My.Forms.CashierCreate.ans1.Text = "" Or My.Forms.CashierCreate.ans2.Text = "" Or My.Forms.CashierCreate.en.Text = "" Or My.Forms.CashierCreate.pw.Text = "" Or My.Forms.CashierCreate.rtp.Text = "") Then
            MsgBox("Fill the empty box")
        Else
            If (My.Forms.CashierCreate.rtp.Text = My.Forms.CashierCreate.pw.Text) Then
                Dim objConn As New MySqlConnection
                Dim ins As New MySqlCommand
                Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"

                objConn.ConnectionString = cn
                objConn.Open()
                Dim objConn1 As New MySqlConnection
                Dim ins1 As New MySqlCommand
                Dim cn1 = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"

                objConn1.ConnectionString = cn1
                objConn1.Open()
                Try
                    ins1.Connection = objConn1
                    Dim b As String = My.Forms.CashierCreate.bd.Value.ToString("MM/dd/yyyy")
                    'accounts table to avoid repeatition of EmployeeID
                    ins1.CommandText = "INSERT INTO accounts VALUES(@EmployeeID)"
                    ins1.Parameters.AddWithValue("@EmployeeID", My.Forms.CashierCreate.en.Text)
                    ins1.ExecuteNonQuery()
                    Try
                        ins.Connection = objConn

                        'cashier_accounts create (insert to database)
                        ins.CommandText = "INSERT INTO cashier_account VALUES(@Photo, @Surname, @GivenName, @MiddleName, @Birthday, @Address, @Email_Account, @ContactNumber, @Security_Question1, @Answer1, @Security_Question2, @Answer2, @EmployeeID, @Password, @status, @LogIn_Attempts)"
                        ins.Parameters.AddWithValue("@Photo", pic)
                        ins.Parameters.AddWithValue("@Surname", My.Forms.CashierCreate.ln.Text)
                        ins.Parameters.AddWithValue("@GivenName", My.Forms.CashierCreate.fn.Text)
                        ins.Parameters.AddWithValue("@MiddleName", My.Forms.CashierCreate.mn.Text)
                        ins.Parameters.AddWithValue("@Birthday", b)
                        ins.Parameters.AddWithValue("@Address", My.Forms.CashierCreate.add.Text)
                        ins.Parameters.AddWithValue("@Email_Account", My.Forms.CashierCreate.eadd.Text)
                        ins.Parameters.AddWithValue("@ContactNumber", My.Forms.CashierCreate.cno.Text)
                        ins.Parameters.AddWithValue("@Security_Question1", My.Forms.CashierCreate.sq1.Text)
                        ins.Parameters.AddWithValue("@Answer1", My.Forms.CashierCreate.ans1.Text)
                        ins.Parameters.AddWithValue("@Security_Question2", My.Forms.CashierCreate.sq2.Text)
                        ins.Parameters.AddWithValue("@Answer2", My.Forms.CashierCreate.ans2.Text)
                        ins.Parameters.AddWithValue("@EmployeeID", My.Forms.CashierCreate.en.Text)
                        ins.Parameters.AddWithValue("@Password", My.Forms.CashierCreate.pw.Text)
                        ins.Parameters.AddWithValue("@status", "Active")
                        ins.Parameters.AddWithValue("@LogIn_Attempts", 0)
                        ins.ExecuteNonQuery()
                        pic = ""
                        MsgBox("Cashier Account Successfuly Created!")
                        My.Forms.CashierCreate.pw.Text = ""
                        My.Forms.CashierCreate.rtp.Text = ""
                        My.Forms.CashierCreate.ln.Focus()
                        AdminPanel.Show()
                        My.Forms.CashierCreate.PictureBox1.Image = Nothing
                        My.Forms.RegistrarCreate.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate.PictureBox1.Image = Nothing
                        My.Forms.AdminCreate_1.PictureBox1.Image = Nothing

                        My.Forms.CashierCreate.Close()
                        Screen_Admin.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Catch
                    MessageBox.Show("Account already exists in the database!")
                End Try
            Else
                MsgBox("Passwords did'nt match!")
                My.Forms.CashierCreate.pw.Text = ""
                My.Forms.CashierCreate.rtp.Text = ""
                My.Forms.CashierCreate.pw.Focus()
            End If
        End If
    End Sub
    Public Sub qwe()
        'Adding Subjects (insert to database table "subject_tbl")
        Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
        objConn.ConnectionString = cn
        objConn.Open()
        Try
            If (My.Forms.AddClass.gl.SelectedIndex = -1 Or My.Forms.AddClass.sec.Text = "") Then
                MsgBox("Enter the empty fields!")
            Else
                ins.Connection = objConn

                ins.CommandText = "INSERT INTO subject_tbl VALUES(@Grade_Level , @Section)"
                ins.Parameters.AddWithValue("@Grade_Level", My.Forms.AddClass.gl.SelectedItem.ToString)
                ins.Parameters.AddWithValue("@Section", My.Forms.AddClass.sec.Text.ToString)

                ins.ExecuteNonQuery()
                ins.Parameters.Clear()
                MsgBox("Class saved successfully!")
                objConn.Close()

                Dim a As Integer
                a = MsgBox("Do you want to Add another Class?", MsgBoxStyle.YesNo)
                If (a = MsgBoxResult.Yes) Then
                    My.Forms.AddClass.gl.SelectedIndex = -1
                    My.Forms.AddClass.sec.Text = ""
                ElseIf (a = MsgBoxResult.No) Then
                    My.Forms.AddClass_A.Close()
                    Screen_Admin.Enabled = True
                    Screen_Admin.TopMost = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        objConn.Close()
    End Sub
    Public Sub qweR()
        'Adding Subjects (insert to database table "subject_tbl")
        Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
        objConn.ConnectionString = cn
        objConn.Open()
        Try
            If (My.Forms.AddClassR.gl.SelectedIndex = -1 Or My.Forms.AddClassR.sec.Text = "") Then
                MsgBox("Enter the empty fields!")
            Else
                ins.Connection = objConn
                ins.CommandText = "INSERT INTO subject_tbl VALUES(@Grade_Level, @Section)"
                ins.Parameters.AddWithValue("@Grade_Level", My.Forms.AddClassR.gl.SelectedItem.ToString)
                ins.Parameters.AddWithValue("@Section", My.Forms.AddClassR.sec.Text.ToString)
                ins.ExecuteNonQuery()
                ins.Parameters.Clear()
                MsgBox("Class saved successfully!")
                objConn.Close()
                Dim a As Integer
                a = MsgBox("Do you want to Add another class?", MsgBoxStyle.YesNo)
                If (a = MsgBoxResult.Yes) Then
                    AddSubClear()
                ElseIf (a = MsgBoxResult.No) Then
                    My.Forms.AddClassR.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        objConn.Close()
    End Sub

    Public Sub insert()
        'insert method to. tandaan lang natin na kapag may nakita tayong 'insert()' sa ibang method, eto yung tinatawag niya.
        'bakit kelangan nito? para hindi na natin paulit ulit na copy paste etong 2 lines of code sa lahat ng method.
        cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
        cn1.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
    End Sub

    Public Sub AddSubClear()

        'so eto yung method para mag clear yung mga text boxes and stuff sa code natin.
        'para hindi mahirapan si user na mag clear pa isa isa, si system na natin yung nagcclear para kay user
        'every successful query. naka automate na kumbaga.

        'clearing fields per forms
        My.Forms.AddClass_A.gl.SelectedIndex = -1
        My.Forms.AddClass_A.sec.Text = ""


        My.Forms.AdminCreate.ln.Text = ""
        My.Forms.AdminCreate.fn.Text = ""
        My.Forms.AdminCreate.mn.Text = ""
        My.Forms.AdminCreate.bd.Value = Date.Now
        My.Forms.AdminCreate.add.Text = ""
        My.Forms.AdminCreate.eadd.Text = ""
        My.Forms.AdminCreate.cno.Text = ""
        My.Forms.AdminCreate.sq1.SelectedItem = ""
        My.Forms.AdminCreate.ans1.Text = ""
        My.Forms.AdminCreate.sq2.SelectedItem = ""
        My.Forms.AdminCreate.ans2.Text = ""
        My.Forms.AdminCreate.en.Text = ""
        My.Forms.AdminCreate.pw.Text = ""
        My.Forms.AdminCreate.rtp.Text = ""

        My.Forms.StudentCreate.addScho.Text = ""
        My.Forms.StudentCreate.nols.Text = ""
        My.Forms.StudentCreate.sn.Text = ""
        My.Forms.StudentCreate.ln.Text = ""
        My.Forms.StudentCreate.fn.Text = ""
        My.Forms.StudentCreate.mn.Text = ""
        My.Forms.StudentCreate.bd.Text = ""
        My.Forms.StudentCreate.cont.Text = ""
        My.Forms.StudentCreate.bp.Text = ""
        My.Forms.StudentCreate.gen.SelectedItem = ""
        My.Forms.StudentCreate.add.Text = ""
        My.Forms.StudentCreate.citi.Text = ""
        My.Forms.StudentCreate.rel.Text = ""
        My.Forms.StudentCreate.sy.Text = ""
        My.Forms.StudentCreate.gl.SelectedItem = ""
        My.Forms.StudentCreate.mon.Text = ""
        My.Forms.StudentCreate.mono.Text = ""
        My.Forms.StudentCreate.fon.Text = ""
        My.Forms.StudentCreate.fono.Text = ""
        My.Forms.StudentCreate.gdn.Text = ""
        My.Forms.StudentCreate.rl.Text = ""
        NSO2 = ""
        baptis = ""
        card = ""
        form137 = ""
        goodMoral = ""
    End Sub
    Public Sub LoginReg()
        'method to para mag login si registrar, from here, magbabago yung SQL Query natin, instead na INSERT,
        'SELECT na. iccheck natin kung meron bang username sa database table.

        'Login registrar account for security(selecting from registrar_account table)
        Dim statusAttempts As String
        Dim statusCount As Integer
        'Login registrar account for security(selecting from registrar_account table)
        Try
            If (My.Forms.RegistrarLogin.en.Text = "") Then
                MsgBox("Please enter EmployeeNo.")
                My.Forms.RegistrarLogin.en.Focus()
            ElseIf (My.Forms.RegistrarLogin.pw.Text = "") Then
                MsgBox("Please enter Password.")
                My.Forms.RegistrarLogin.pw.Focus()
            ElseIf (My.Forms.RegistrarLogin.en.Text = "" And My.Forms.RegistrarLogin.pw.Text = "") Then
                MsgBox("Please fill the empty fields.")
                My.Forms.RegistrarLogin.en.Focus()
            Else
                insert() 'eto yung insert method. instead na 2 lines of code, eto na lang ilalagay. dali diba? haha
                cn.Open() 'siyempre, para maka connect tayo sa database, need natin iopen yung connection.

                'see, yung SQL Query natin, select all from registrar_account where yung EmployeeID ay equals dun sa nakatype textbox and yung Password ay equals dun sa password na nakatype sa text box.
                Dim ad As String = "SELECT * FROM registrar_account WHERE EmployeeID ='" & My.Forms.RegistrarLogin.en.Text & "' "

                Dim cmd As MySqlCommand = New MySqlCommand(ad, cn)
                r = cmd.ExecuteReader() 'execute query

                'if r.Read, ibig sabihin nun, merong username and password dun sa databae na nag match dun sa username and password na
                'naka type sa login screen. 
                If r.Read Then
                    If r.GetString("status") = "Active" Then

                        If r.GetString("Password") = My.Forms.RegistrarLogin.pw.Text Then
                            'add if else here to check if account status is active!
                            'if active, login, else, show error that error is blocked.
                            My.Forms.MainScreen.Hide()
                            My.Forms.RegistrarLogin.Hide()
                            RegistrarPanel.TopLevel = False
                            My.Forms.Screen_Registrar.RegistrarPanelPictureBox.Controls.Add(RegistrarPanel)
                            My.Forms.MainScreen.Enabled = True
                            Screen_Registrar.Show()
                            RegistrarPanel.Show() 'show natin yung registrar panel kasi successful yung login.
                            My.Forms.MainScreen.Button5.Visible = False
                            cn.Close() 'need natin iclose lagi yung connection sa database. why? para ma prevent yung database leaks.

                            statusAttempts = "Update registrar_account SET LogIn_Attempts = 0 WHERE EmployeeID= ' " & My.Forms.RegistrarLogin.en.Text & "'"
                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using
                            cn1.Close()

                        Else
                            statusAttempts = "Update registrar_account SET LogIn_Attempts= LogIn_Attempts +1  WHERE EmployeeID = '" & My.Forms.RegistrarLogin.en.Text & " '"

                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using


                            If Val(r.GetString("LogIn_Attempts")) > 2 Then

                                statusAttempts = "Update registrar_account SET status= 'Blocked ' WHERE EmployeeID = '" & My.Forms.RegistrarLogin.en.Text & " '"
                                Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                    sqlCmdStatus.ExecuteNonQuery()
                                End Using

                            End If

                            statusCount = Val(r.GetString("LogIn_Attempts") + 1)
                            cn1.Close()
                            MsgBox("Employee number and Password did not match !", vbCritical, "St. Martin De Porres")

                        End If
                    Else
                        MsgBox("Sorry! Your Account has been Blocked", vbCritical, "St. Martin De Porres")
                        My.Forms.RegistrarLogin.en.Focus()
                        My.Forms.RegistrarLogin.pw.Text = ""
                        My.Forms.RegistrarLogin.en.Text = ""


                    End If
                Else
                    cn.Close()
                    MsgBox("Employee number and Password did not match!", vbExclamation, "St. Martin De Porres")
                    My.Forms.CashierLogin.en.Focus()
                    My.Forms.CashierLogin.pw.Text = ""


                End If
                Dim att As String = "Update registrar_account SET LogIn_Attempts= ' 0 ' WHERE EmployeeID <> '" & My.Forms.RegistrarLogin.en.Text & " '  AND  LogIn_Attempts<> '3'"
                Using sqlCmdAtt = New MySqlCommand(att, cn1)
                    cn1.Open()
                    sqlCmdAtt.ExecuteNonQuery()
                End Using
                cn.Close()
                cn1.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub LoginAdm()

        cn.Close()
        cn1.Close()

        Dim statusAttempts As String
        Dim statusCount As Integer

        Try
            If (My.Forms.LoginAdmin.en.Text = "") Then
                MsgBox("Please enter Employee Number.", vbInformation, "St. Martin De Porres")
                My.Forms.LoginAdmin.en.Focus()
            ElseIf (My.Forms.LoginAdmin.pw.Text = "") Then
                MsgBox("Please enter Password.", vbInformation, "St. Martin De Porres")
                My.Forms.LoginAdmin.pw.Focus()
            ElseIf (My.Forms.LoginAdmin.en.Text = "" And My.Forms.LoginAdmin.pw.Text = "") Then
                MsgBox("Please fill the empty fields.", vbInformation, "St. Martin De Porres")
                My.Forms.LoginAdmin.en.Focus()
            Else

                insert()
                cn.Open()

                Dim status As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.LoginAdmin.en.Text & "') "
                Dim comd As MySqlCommand = New MySqlCommand(status, cn)
                r = comd.ExecuteReader()
                If r.Read = True Then

                    If r.GetString("status") = "Active" Then

                        If r.GetString("Password") = My.Forms.LoginAdmin.pw.Text Then

                            cn.Close()
                            My.Forms.MainScreen.Hide()
                            My.Forms.LoginAdmin.Hide()
                            AdminPanel.TopLevel = False
                            My.Forms.MainScreen.Enabled = True
                            My.Forms.Screen_Admin.AdminPanelPictureBox.Controls.Add(AdminPanel)
                            Screen_Admin.Show()
                            AdminPanel.Show()


                            statusAttempts = "Update admin Set LogIn_Attempts= 0 WHERE EmployeeID = ' " & My.Forms.LoginAdmin.en.Text & " '"


                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using
                            cn1.Close()
                        Else
                            statusAttempts = "Update admin SET LogIn_Attempts= LogIn_Attempts + 1 WHERE EmployeeID = '" & My.Forms.LoginAdmin.en.Text & " '"
                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using


                            If Val(r.GetString("LogIn_Attempts")) > 2 Then

                                statusAttempts = "Update admin SET status= 'Blocked ' WHERE EmployeeID = '" & My.Forms.LoginAdmin.en.Text & " '"
                                Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                    sqlCmdStatus.ExecuteNonQuery()
                                End Using

                            End If

                            statusCount = Val(r.GetString("LogIn_Attempts") + 1)
                            cn1.Close()
                            MsgBox("Employee number and Password did not match !", vbCritical, "St. Martin De Porres")

                        End If

                    Else

                        MsgBox("Sorry! Your Account has been Blocked", vbCritical, "St. Martin De Porres")
                        My.Forms.LoginAdmin.en.Focus()
                        My.Forms.LoginAdmin.pw.Text = ""
                        My.Forms.LoginAdmin.en.Text = ""

                    End If

                Else
                    cn.Close()
                    MsgBox("Employee number and Password did not match!", vbExclamation, "St. Martin De Porres")
                    My.Forms.LoginAdmin.en.Focus()
                    My.Forms.LoginAdmin.pw.Text = ""

                End If

                Dim att As String = "Update admin SET LogIn_Attempts= ' 0 ' WHERE EmployeeID <> '" & My.Forms.LoginAdmin.en.Text & " '  AND  LogIn_Attempts<> '3'"
                Using sqlCmdAtt = New MySqlCommand(att, cn1)
                    cn1.Open()
                    sqlCmdAtt.ExecuteNonQuery()
                End Using
                cn.Close()
                cn1.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            cn1.Close()
            cn.Close()
        End Try


    End Sub
    Public Sub LoginCash()
        'login cashier naman toooo. 
        'Login cashier account for security(selecting from cashier_account table)
        Dim statusAttempts As String
        Dim statusCount As Integer

        Try
            If (My.Forms.CashierLogin.en.Text = "") Then
                MsgBox("Please enter Employee Number.", vbInformation, "St. Martin De Porres")
                My.Forms.CashierLogin.en.Focus()
            ElseIf (My.Forms.CashierLogin.pw.Text = "") Then
                MsgBox("Please enter Password.", vbInformation, "St. Martin De Porres")
                My.Forms.CashierLogin.pw.Focus()
            ElseIf (My.Forms.CashierLogin.en.Text = "" And My.Forms.CashierLogin.pw.Text = "") Then
                MsgBox("Please fill the empty fields.", vbInformation, "St. Martin De Porres")
                My.Forms.CashierLogin.en.Focus()
            Else

                insert()
                cn.Open()

                Dim status As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.CashierLogin.en.Text & "') "
                Dim comd As MySqlCommand = New MySqlCommand(status, cn)
                r = comd.ExecuteReader()

                If r.Read = True Then

                    If r.GetString("status") = "Active" Then

                        If r.GetString("Password") = My.Forms.CashierLogin.pw.Text Then

                            cn.Close()
                            My.Forms.MainScreen.Hide()
                            My.Forms.CashierLogin.Hide()
                            CashierPanel.TopLevel = False
                            My.Forms.MainScreen.Enabled = True
                            My.Forms.Screen_Cashier.CashierPanelPictureBox.Controls.Add(CashierPanel)
                            Screen_Cashier.Show()
                            CashierPanel.Show()

                            statusAttempts = "Update cashier_account Set LogIn_Attempts= 0 WHERE EmployeeID = ' " & My.Forms.CashierLogin.en.Text & " '"


                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using
                            cn1.Close()

                        Else

                            statusAttempts = "Update cashier_account SET LogIn_Attempts= LogIn_Attempts + 1 WHERE EmployeeID = '" & My.Forms.CashierLogin.en.Text & " '"
                            Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                cn1.Open()
                                sqlCmdStatus.ExecuteNonQuery()
                            End Using


                            If Val(r.GetString("LogIn_Attempts")) > 2 Then

                                statusAttempts = "Update cashier_account SET status= 'Blocked ' WHERE EmployeeID = '" & My.Forms.CashierLogin.en.Text & " '"
                                Using sqlCmdStatus = New MySqlCommand(statusAttempts, cn1)
                                    sqlCmdStatus.ExecuteNonQuery()
                                End Using

                            End If

                            statusCount = Val(r.GetString("LogIn_Attempts") + 1)
                            cn1.Close()
                            MsgBox("Employee number and Password did not match !", vbCritical, "St. Martin De Porres")

                        End If

                    Else

                        MsgBox("Sorry! Your Account has been Blocked", vbCritical, "St. Martin De Porres")
                        My.Forms.CashierLogin.en.Focus()
                        My.Forms.CashierLogin.pw.Text = ""
                        My.Forms.CashierLogin.en.Text = ""

                    End If

                Else
                    cn.Close()
                    MsgBox("Employee number and Password did not match!", vbExclamation, "St. Martin De Porres")
                    My.Forms.CashierLogin.en.Focus()
                    My.Forms.CashierLogin.pw.Text = ""

                End If

                Dim att As String = "Update cashier_account SET LogIn_Attempts= ' 0 ' WHERE EmployeeID <> '" & My.Forms.CashierLogin.en.Text & " '  AND  LogIn_Attempts<> '3'"
                Using sqlCmdAtt = New MySqlCommand(att, cn1)
                    cn1.Open()
                    sqlCmdAtt.ExecuteNonQuery()
                End Using
                cn.Close()
                cn1.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            cn1.Close()
            cn.Close()
        End Try
    End Sub
    Public Sub adminPan()
        'Admin panel. To display Picture of Admin, Name, ContactNumber, etc.
        insert() 'okay andito nanaman tong insert() na to, para san nga ulit to guys? remember! hehe

        Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.AdminPanel.empl.Text & "')"
        cn1.Open() 'open database connection ulit para maka connect tayo sa databae.

        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
        r = cmd.ExecuteReader() 'execute sql query
        'alam na natin kung ano ibig sabihin ng r.Read diba guys? ibig sabihin, meron nun sa database. so,
        'ididisplay niya kung ano yung nakita niya sa database na under nung employee id
        Try
            If r.Read Then
                My.Forms.AdminPanel.n1.Text = r("Surname").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.AdminPanel.email.Text = r("Email_Account").ToString() & "."
                My.Forms.AdminPanel.cn.Text = r("ContactNumber").ToString() & "."
                pic = r("Photo").ToString()
            Else
                MsgBox("Employee number not Found!")
                cn1.Close()
            End If
        Catch ex As Exception
        End Try
        cn1.Close()

    End Sub
    Public Sub close1()
        'eto yung pag close method ng mga forms.
        '    Try
        Application.Exit()
        'My.Forms.LoginAdmin.Close()
        'My.Forms.CashierLogin.Close()
        'My.Forms.RegistrarLogin.Close()
        'My.Forms.AdminPanel.Close()
        'My.Forms.ViewStudentInfo.Close()
        'My.Forms.RegistrarCreate.Close()
        'My.Forms.CashierCreate.Close()
        'My.Forms.AdminCreate.Close()
        'My.Forms.StudentCreate.Close()
        'My.Forms.Screen_Admin.Close()
        'My.Forms.Screen_Cashier.Close()
        'My.Forms.Screen_Registrar.Close()
        'My.Forms.MainScreen.Close()

        '   Catch
        '  End Try
    End Sub
    Public Sub chapass()

        'change password na tayo guys, ibang sql query na gamit natin dito. change password, need natin mag update sa database,
        'so UPDATE table SET fields = laman ng text box
        'Change password of Admin
        Try
            If (My.Forms.ChangePass.pw.Text = "") Then
                MsgBox("Please enter Password")
                My.Forms.ChangePass.pw.Focus()
            ElseIf (My.Forms.ChangePass.rtp.Text = "") Then
                MsgBox("Please enter re-type password!")
                My.Forms.ChangePass.rtp.Focus()
            ElseIf (My.Forms.ChangePass.rtp.Text = "" And My.Forms.ChangePass.pw.Text = "") Then
                MsgBox("Please enter the empty fields")
                My.Forms.ChangePass.pw.Focus()
            Else
                If (My.Forms.ChangePass.pw.Text = My.Forms.ChangePass.rtp.Text) Then
                    'eto yung sql query natin for changing password. medyo magbabago lang dito, kasi wala na yung insert().
                    'hindi naman na kasi tayo mag i insert or titingin sa db, mag a update na tayo.
                    Dim reg As String = "UPDATE admin SET Password = '" & My.Forms.ChangePass.rtp.Text & "' where EmployeeID = '" & My.Forms.ForgotV.ne1.Text & "'"
                    Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                        Using sqlCmd = New MySqlCommand(reg, cn1)
                            cn1.Open() 'pero siyempre andito pa din yung mag o open tayo ng connection,
                            sqlCmd.ExecuteNonQuery() 'mag e execute ng query,
                            MsgBox("Password changed successfully!")
                            My.Forms.MainScreen.AdminBtn.Visible = True
                            My.Forms.MainScreen.CashierBtn.Visible = True
                            My.Forms.MainScreen.RegistrarBtn.Visible = True
                            My.Forms.MainScreen.AboutUsBtn.Visible = True
                            My.Forms.MainScreen.PictureBox1.Visible = True
                            My.Forms.MainScreen.Enabled = True
                            My.Forms.ChangePass.Close()
                            My.Forms.ForgotV.Close()
                            cn1.Close() 'at close connection. para san ulit to guys? remember! para ma prevent yung db leaks.
                            'pag kasi may naka open lang na connection ng database, bukod sa prone sa database leaks,
                            'kumakain pa siya ng resources (memory) ng computer. which is cause ng pagbagal ng computer
                            'na gamit ni admin, or cashier, or registrar. kaya important na every open ng database connection,
                            'perform yung database transaction (SELECT or INSERT or UPDATE, etc.)
                            'then close connection.
                        End Using
                        cn1.Close()
                    End Using
                Else
                    MsgBox("Passwords are not mathced!")
                    My.Forms.ChangePass.pw.Text = ""
                    My.Forms.ChangePass.rtp.Text = ""
                    My.Forms.ChangePass.pw.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub chapassC()

        'change password na tayo guys, ibang sql query na gamit natin dito. change password, need natin mag update sa database,
        'so UPDATE table SET fields = laman ng text box
        'Change password of Admin
        Try
            If (My.Forms.ChangePassC.pw.Text = "") Then
                MsgBox("Please enter Password")
                My.Forms.ChangePassC.pw.Focus()
            ElseIf (My.Forms.ChangePassC.rtp.Text = "") Then
                MsgBox("Please enter re-type password!")
                My.Forms.ChangePassC.rtp.Focus()
            ElseIf (My.Forms.ChangePassC.rtp.Text = "" And My.Forms.ChangePassC.pw.Text = "") Then
                MsgBox("Please enter the empty fields")
                My.Forms.ChangePassC.pw.Focus()
            Else
                If (My.Forms.ChangePassC.pw.Text = My.Forms.ChangePassC.rtp.Text) Then
                    'eto yung sql query natin for changing password. medyo magbabago lang dito, kasi wala na yung insert().
                    'hindi naman na kasi tayo mag i insert or titingin sa db, mag a update na tayo.
                    Dim reg As String = "UPDATE cashier_account SET Password = '" & My.Forms.ChangePassC.rtp.Text & "' where EmployeeID = '" & My.Forms.ChangePassC.ne1.Text & "'"
                    Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                        Using sqlCmd = New MySqlCommand(reg, cn1)
                            cn1.Open() 'pero siyempre andito pa din yung mag o open tayo ng connection,
                            sqlCmd.ExecuteNonQuery() 'mag e execute ng query,
                            MsgBox("Password changed successfully!")
                            My.Forms.MainScreen.Enabled = True
                            My.Forms.MainScreen.AdminBtn.Visible = True
                            My.Forms.MainScreen.CashierBtn.Visible = True
                            My.Forms.MainScreen.RegistrarBtn.Visible = True
                            My.Forms.MainScreen.AboutUsBtn.Visible = True
                            My.Forms.MainScreen.PictureBox1.Visible = True
                            MainScreen.Enabled = True
                            My.Forms.ChangePassC.Close()
                            My.Forms.ForgotC.Close()
                            cn1.Close() 'at close connection. para san ulit to guys? remember! para ma prevent yung db leaks.
                            'pag kasi may naka open lang na connection ng database, bukod sa prone sa database leaks,
                            'kumakain pa siya ng resources (memory) ng computer. which is cause ng pagbagal ng computer
                            'na gamit ni admin, or cashier, or registrar. kaya important na every open ng database connection,
                            'perform yung database transaction (SELECT or INSERT or UPDATE, etc.)
                            'then close connection.
                        End Using
                        cn1.Close()
                    End Using
                Else
                    MsgBox("Passwords are not mathced!")
                    My.Forms.ChangePassC.pw.Text = ""
                    My.Forms.ChangePassC.rtp.Text = ""
                    My.Forms.ChangePassC.pw.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub chapassR()

        'change password na tayo guys, ibang sql query na gamit natin dito. change password, need natin mag update sa database,
        'so UPDATE table SET fields = laman ng text box
        'Change password of Admin
        Try
            If (My.Forms.ChangePassR.pw.Text = "") Then
                MsgBox("Please enter Password")
                My.Forms.ChangePassR.pw.Focus()
            ElseIf (My.Forms.ChangePassR.rtp.Text = "") Then
                MsgBox("Please enter re-type password!")
                My.Forms.ChangePassR.rtp.Focus()
            ElseIf (My.Forms.ChangePassR.rtp.Text = "" And My.Forms.ChangePassR.pw.Text = "") Then
                MsgBox("Please enter the empty fields")
                My.Forms.ChangePassR.pw.Focus()
            Else
                If (My.Forms.ChangePassR.pw.Text = My.Forms.ChangePassR.rtp.Text) Then
                    'eto yung sql query natin for changing password. medyo magbabago lang dito, kasi wala na yung insert().
                    'hindi naman na kasi tayo mag i insert or titingin sa db, mag a update na tayo.
                    Dim reg As String = "UPDATE registrar_account SET Password = '" & My.Forms.ChangePassR.rtp.Text & "' where EmployeeID = '" & My.Forms.ChangePassR.ne1.Text & "'"
                    Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                        Using sqlCmd = New MySqlCommand(reg, cn1)
                            cn1.Open() 'pero siyempre andito pa din yung mag o open tayo ng connection,
                            sqlCmd.ExecuteNonQuery() 'mag e execute ng query,
                            MsgBox("Password changed successfully!")
                            My.Forms.MainScreen.AdminBtn.Visible = True
                            My.Forms.MainScreen.CashierBtn.Visible = True
                            My.Forms.MainScreen.RegistrarBtn.Visible = True
                            My.Forms.MainScreen.AboutUsBtn.Visible = True
                            My.Forms.MainScreen.PictureBox1.Visible = True
                            MainScreen.Enabled = True
                            My.Forms.ChangePassR.Close()
                            My.Forms.ForgotR.Close()
                            cn1.Close() 'at close connection. para san ulit to guys? remember! para ma prevent yung db leaks.
                            'pag kasi may naka open lang na connection ng database, bukod sa prone sa database leaks,
                            'kumakain pa siya ng resources (memory) ng computer. which is cause ng pagbagal ng computer
                            'na gamit ni admin, or cashier, or registrar. kaya important na every open ng database connection,
                            'perform yung database transaction (SELECT or INSERT or UPDATE, etc.)
                            'then close connection.
                        End Using
                        cn1.Close()
                    End Using
                Else
                    MsgBox("Passwords are not mathced!")
                    My.Forms.ChangePassR.pw.Text = ""
                    My.Forms.ChangePassR.rtp.Text = ""
                    My.Forms.ChangePassR.pw.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub forgot()

        'sa forgot password naman to. 
        'Forgot password (To verify secret question)
        Try
            insert() 'andito na ulit si insert() kasi SELECT lang naman tayo eh. nakuha na natin yung employeeid dun sa unang text box,
            'so kapag yung employee id sa unang textbox at si answer1 and answer2 sa text box ngayon ay matched dun sa database,
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.Forgot1.ne1.Text & "' and Answer1 ='" & My.Forms.Forgot1.ans1.Text & "' and Answer2 ='" & My.Forms.Forgot1.ans2.Text & "')"
            cn1.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
            r = cmd.ExecuteReader()
            'eto yun. open si change password form para mai type niya yung bago niyang password.
            If r.Read Then
                'ChangePass.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(ChangePass)
                ChangePass.TopMost = True
                ChangePass.Show()
                My.Forms.Forgot1.Close()
                cn1.Close()
            Else
                MsgBox("Secret Question and Answer are not Matched!")
                My.Forms.Forgot1.ans1.Focus()
                cn1.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub forgotCC()

        'sa forgot password naman to. 
        'Forgot password (To verify secret question)
        Try
            insert() 'andito na ulit si insert() kasi SELECT lang naman tayo eh. nakuha na natin yung employeeid dun sa unang text box,
            'so kapag yung employee id sa unang textbox at si answer1 and answer2 sa text box ngayon ay matched dun sa database,
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.forgot2.ne1.Text & "' and Answer1 ='" & My.Forms.forgot2.ans1.Text & "' and Answer2 ='" & My.Forms.forgot2.ans2.Text & "')"
            cn1.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
            r = cmd.ExecuteReader()
            'eto yun. open si change password form para mai type niya yung bago niyang password.
            If r.Read Then
                'ChangePassC.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(ChangePassC)
                ChangePassC.TopMost = True
                ChangePassC.Show()
                My.Forms.forgot2.Close()
                cn1.Close()
            Else
                MsgBox("Secret Question and Answer are not Matched!")
                My.Forms.forgot2.ans1.Focus()
                cn1.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub forgotRR()

        'sa forgot password naman to. 
        'Forgot password (To verify secret question)
        Try
            insert() 'andito na ulit si insert() kasi SELECT lang naman tayo eh. nakuha na natin yung employeeid dun sa unang text box,
            'so kapag yung employee id sa unang textbox at si answer1 and answer2 sa text box ngayon ay matched dun sa database,
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.forgot3.ne1.Text & "' and Answer1 ='" & My.Forms.forgot3.ans1.Text & "' and Answer2 ='" & My.Forms.forgot3.ans2.Text & "')"
            cn1.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
            r = cmd.ExecuteReader()
            'eto yun. open si change password form para mai type niya yung bago niyang password.
            If r.Read Then
                'ChangePassR.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(ChangePassR)
                ChangePassR.TopMost = True
                ChangePassR.Show()
                My.Forms.forgot3.Close()
                cn1.Close()
            Else
                MsgBox("Secret Question and Answer are not Matched!")
                My.Forms.forgot3.ans1.Focus()
                cn1.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub forgor01()
        'etong method na to, nagveverify lang kung existing si employee number sa database.
        'same explanation lang din to guys tulad ng ibang methods natin.

        'Verification for EmployeeNumber of Admin to change password
        Try
            'eto yung connection string natin, same lang din ng nasa insert()
            cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            'eto yung sql query naten. check natin kung yung ni type ni user sa text box ay existing sa databaes.
            Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.ForgotV.ne1.Text & "')"
            cn.Open() 'open database connection
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn) 'lagay natin kay cmd yung reg saka cn1
            r = cmd.ExecuteReader() 'execute natin

            'kung meron ngang username na tinype ni user sa database, show yung next form. else, error
            If r.Read Then
                'Forgot1.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(Forgot1)
                Forgot1.TopMost = True
                Forgot1.Show()
                My.Forms.ForgotV.Hide()
                cn.Close()
            Else
                MsgBox("Employee number not Found!")
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Public Sub forgor02()
        'etong method na to, nagveverify lang kung existing si employee number sa database.
        'same explanation lang din to guys tulad ng ibang methods natin.

        'Verification for EmployeeNumber of Admin to change password
        Try
            'eto yung connection string natin, same lang din ng nasa insert()
            cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            'eto yung sql query naten. check natin kung yung ni type ni user sa text box ay existing sa databaes.
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.ForgotC.ne1.Text & "')"
            cn.Open() 'open database connection
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn) 'lagay natin kay cmd yung reg saka cn1
            r = cmd.ExecuteReader() 'execute natin

            'kung meron ngang username na tinype ni user sa database, show yung next form. else, error
            If r.Read Then
                'forgot2.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(forgot2)
                forgot2.TopMost = True
                forgot2.Show()
                My.Forms.ForgotC.Hide()
                cn.Close()
            Else
                MsgBox("Employee number not Found!")
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Public Sub forgor03()
        'etong method na to, nagveverify lang kung existing si employee number sa database.
        'same explanation lang din to guys tulad ng ibang methods natin.

        'Verification for EmployeeNumber of Admin to change password
        Try
            'eto yung connection string natin, same lang din ng nasa insert()
            cn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            'eto yung sql query naten. check natin kung yung ni type ni user sa text box ay existing sa databaes.
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.ForgotR.ne1.Text & "')"
            cn.Open() 'open database connection
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn) 'lagay natin kay cmd yung reg saka cn1
            r = cmd.ExecuteReader() 'execute natin

            'kung meron ngang username na tinype ni user sa database, show yung next form. else, error
            If r.Read Then
                'forgot3.TopLevel = False
                'My.Forms.MainScreen.Pi.Controls.Add(forgot3)
                forgot3.TopMost = True
                forgot3.Show()
                My.Forms.ForgotR.Hide()
                cn.Close()
            Else
                MsgBox("Employee number not Found!")
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Public Sub veditR()
        'not implemented in system
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.RegistrarEdit.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.RegistrarEdit.ln.Text = r("Surname").ToString()
                My.Forms.RegistrarEdit.fn.Text = r("GivenName").ToString()
                My.Forms.RegistrarEdit.mn.Text = r("MiddleName").ToString()
                My.Forms.RegistrarEdit.bd.Text = r("Birthday").ToString()
                My.Forms.RegistrarEdit.add.Text = r("Address").ToString()
                My.Forms.RegistrarEdit.eadd.Text = r("Email_Account").ToString()
                My.Forms.RegistrarEdit.cno.Text = r("ContactNumber").ToString()
                My.Forms.RegistrarEdit.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.RegistrarEdit.GroupBox2.Enabled = True
                My.Forms.RegistrarEdit.Button1.Enabled = False
                My.Forms.RegistrarEdit.en.Enabled = False
                cn.Close()
            Else
                MsgBox("Employee number not Found!")
                My.Forms.RegistrarEdit.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub editr()
        'not implemented
        Dim reg As String = "UPDATE registrar_account SET Surname = '" & My.Forms.RegistrarEdit.ln.Text & "', GivenName = '" & My.Forms.RegistrarEdit.fn.Text & "', MiddleName = '" & My.Forms.RegistrarEdit.mn.Text & "', Birthday = '" & My.Forms.RegistrarEdit.bd.Text & "', Address = '" & My.Forms.RegistrarEdit.add.Text & "', Email_Account = '" & My.Forms.RegistrarEdit.eadd.Text & "', ContactNumber = '" & My.Forms.RegistrarEdit.cno.Text & "' WHERE EmployeeID = '" & My.Forms.RegistrarEdit.en.Text & "'"
        Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
            Using sqlCmd = New MySqlCommand(reg, cn)
                cn.Open()
                sqlCmd.ExecuteNonQuery()
                MsgBox("Edited Successfully!")
                My.Forms.RegistrarEdit.Button1.Enabled = True
                My.Forms.RegistrarEdit.GroupBox2.Enabled = False
                My.Forms.RegistrarEdit.en.Enabled = True
                My.Forms.RegistrarEdit.en.Text = ""
                My.Forms.RegistrarEdit.ln.Text = ""
                My.Forms.RegistrarEdit.fn.Text = ""
                My.Forms.RegistrarEdit.mn.Text = ""
                My.Forms.RegistrarEdit.bd.Text = ""
                My.Forms.RegistrarEdit.add.Text = ""
                My.Forms.RegistrarEdit.eadd.Text = ""
                My.Forms.RegistrarEdit.cno.Text = ""
                cn.Close()
            End Using
            cn.Close()
        End Using
    End Sub
    Public Sub vedit()
        'not implement
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.CashierEdit.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.CashierEdit.ln.Text = r("Surname").ToString()
                My.Forms.CashierEdit.fn.Text = r("GivenName").ToString()
                My.Forms.CashierEdit.mn.Text = r("MiddleName").ToString()
                My.Forms.CashierEdit.bd.Text = r("Birthday").ToString()
                My.Forms.CashierEdit.add.Text = r("Address").ToString()
                My.Forms.CashierEdit.eadd.Text = r("Email_Account").ToString()
                My.Forms.CashierEdit.cno.Text = r("ContactNumber").ToString()
                My.Forms.CashierEdit.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.CashierEdit.GroupBox2.Enabled = True
                My.Forms.CashierEdit.Button1.Enabled = False
                My.Forms.CashierEdit.en.Enabled = False
                cn.Close()
            Else
                MsgBox("Employee number not Found!")
                My.Forms.CashierEdit.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub editC()
        'not implemented
        Try
            Dim reg As String = "UPDATE cashier_account SET Surname = '" & My.Forms.CashierEdit.ln.Text & "', GivenName = '" & My.Forms.CashierEdit.fn.Text & "', MiddleName = '" & My.Forms.CashierEdit.mn.Text & "', Birthday = '" & My.Forms.CashierEdit.bd.Text & "', Address = '" & My.Forms.CashierEdit.add.Text & "', Email_Account = '" & My.Forms.CashierEdit.eadd.Text & "', ContactNumber = '" & My.Forms.CashierEdit.cno.Text & "' WHERE EmployeeID = '" & My.Forms.CashierEdit.en.Text & "'"
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Edited Successfully!")
                    My.Forms.CashierEdit.Button1.Enabled = True
                    My.Forms.CashierEdit.GroupBox2.Enabled = False
                    My.Forms.CashierEdit.en.Enabled = True
                    My.Forms.CashierEdit.en.Text = ""
                    My.Forms.CashierEdit.ln.Text = ""
                    My.Forms.CashierEdit.fn.Text = ""
                    My.Forms.CashierEdit.mn.Text = ""
                    My.Forms.CashierEdit.bd.Text = ""
                    My.Forms.CashierEdit.add.Text = ""
                    My.Forms.CashierEdit.eadd.Text = ""
                    My.Forms.CashierEdit.cno.Text = ""
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub RegE()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.DeleteRegistrar.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.DeleteRegistrar.ln.Text = r("Surname").ToString()
                My.Forms.DeleteRegistrar.fn.Text = r("GivenName").ToString()
                My.Forms.DeleteRegistrar.mn.Text = r("MiddleName").ToString()
                My.Forms.DeleteRegistrar.bd.Text = r("Birthday").ToString()
                My.Forms.DeleteRegistrar.add.Text = r("Address").ToString()
                My.Forms.DeleteRegistrar.eadd.Text = r("Email_Account").ToString()
                My.Forms.DeleteRegistrar.cno.Text = r("ContactNumber").ToString()
                My.Forms.DeleteRegistrar.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.DeleteRegistrar.GroupBox2.Enabled = True
                My.Forms.DeleteRegistrar.Button1.Enabled = False
                My.Forms.DeleteRegistrar.en.Enabled = False
                My.Forms.DeleteRegistrar.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.DeleteRegistrar.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub regdel()
        'not implemented
        Try
            Dim reg As String = "DELETE FROM registrar_account WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Deleted!")
                    My.Forms.DeleteRegistrar.Button1.Enabled = True
                    My.Forms.DeleteRegistrar.GroupBox2.Enabled = False
                    My.Forms.DeleteRegistrar.en.Enabled = True
                    My.Forms.DeleteRegistrar.en.Text = ""
                    My.Forms.DeleteRegistrar.ln.Text = ""
                    My.Forms.DeleteRegistrar.fn.Text = ""
                    My.Forms.DeleteRegistrar.mn.Text = ""
                    My.Forms.DeleteRegistrar.bd.Text = ""
                    My.Forms.DeleteRegistrar.add.Text = ""
                    My.Forms.DeleteRegistrar.eadd.Text = ""
                    My.Forms.DeleteRegistrar.cno.Text = ""
                    My.Forms.DeleteRegistrar.cno.Text = ""
                    My.Forms.DeleteRegistrar.PictureBox1.Image = Nothing
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub delcas()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.DeleteCashier.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.DeleteCashier.ln.Text = r("Surname").ToString()
                My.Forms.DeleteCashier.fn.Text = r("GivenName").ToString()
                My.Forms.DeleteCashier.mn.Text = r("MiddleName").ToString()
                My.Forms.DeleteCashier.bd.Text = r("Birthday").ToString()
                My.Forms.DeleteCashier.add.Text = r("Address").ToString()
                My.Forms.DeleteCashier.eadd.Text = r("Email_Account").ToString()
                My.Forms.DeleteCashier.cno.Text = r("ContactNumber").ToString()
                My.Forms.DeleteCashier.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.DeleteCashier.GroupBox2.Enabled = True
                My.Forms.DeleteCashier.Button1.Enabled = False
                My.Forms.DeleteCashier.en.Enabled = False
                My.Forms.DeleteCashier.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.DeleteCashier.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub delad()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.deleteAdmin.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.deleteAdmin.ln.Text = r("Surname").ToString()
                My.Forms.deleteAdmin.fn.Text = r("GivenName").ToString()
                My.Forms.deleteAdmin.mn.Text = r("MiddleName").ToString()
                My.Forms.deleteAdmin.bd.Text = r("Birthday").ToString()
                My.Forms.deleteAdmin.add.Text = r("Address").ToString()
                My.Forms.deleteAdmin.eadd.Text = r("Email_Account").ToString()
                My.Forms.deleteAdmin.cno.Text = r("ContactNumber").ToString()
                My.Forms.deleteAdmin.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.deleteAdmin.GroupBox2.Enabled = True
                My.Forms.deleteAdmin.Button1.Enabled = False
                My.Forms.deleteAdmin.en.Enabled = False
                My.Forms.deleteAdmin.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.deleteAdmin.en.Text = ""
                My.Forms.deleteAdmin.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub deleteCashierAccounts()
        '   For Each FRM As Form In Application.OpenForms
        Try
            '  Dim deleteAccountUser As String = "My.Forms." & FRM.Name.ToString & ".en.Text"
            '  Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteCashier.en.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd1 = New MySqlCommand(reg1, cn1)
                    cn1.Open()
                    sqlCmd1.ExecuteNonQuery()
                    cn1.Close()
                End Using
                cn1.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn1.Close()
        End Try
        '  Next
    End Sub
    Public Sub deleteAdminAccounts()
        '   For Each FRM As Form In Application.OpenForms
        Try
            '  Dim deleteAccountUser As String = "My.Forms." & FRM.Name.ToString & ".en.Text"
            '  Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.deleteAdmin.en.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd1 = New MySqlCommand(reg1, cn1)
                    cn1.Open()
                    sqlCmd1.ExecuteNonQuery()
                    cn1.Close()
                End Using
                cn1.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn1.Close()
        End Try
        '  Next
    End Sub
    Public Sub deleteRegistrarAccounts()
        '   For Each FRM As Form In Application.OpenForms
        Try
            '  Dim deleteAccountUser As String = "My.Forms." & FRM.Name.ToString & ".en.Text"
            '  Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd1 = New MySqlCommand(reg1, cn1)
                    cn1.Open()
                    sqlCmd1.ExecuteNonQuery()
                    cn1.Close()
                End Using
                cn1.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn1.Close()
        End Try
        '  Next
    End Sub
    Public Sub delad1()
        'not implemented

        Dim reg As String = "DELETE FROM admin WHERE EmployeeID = '" & My.Forms.deleteAdmin.en.Text & "'"
        Try
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Deleted!")
                    My.Forms.deleteAdmin.Button1.Enabled = True
                    My.Forms.deleteAdmin.GroupBox2.Enabled = False
                    My.Forms.deleteAdmin.en.Enabled = True
                    My.Forms.deleteAdmin.en.Text = ""
                    My.Forms.deleteAdmin.ln.Text = ""
                    My.Forms.deleteAdmin.fn.Text = ""
                    My.Forms.deleteAdmin.mn.Text = ""
                    My.Forms.deleteAdmin.bd.Text = ""
                    My.Forms.deleteAdmin.add.Text = ""
                    My.Forms.deleteAdmin.eadd.Text = ""
                    My.Forms.deleteAdmin.cno.Text = ""
                    My.Forms.deleteAdmin.PictureBox1.Image = Nothing
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub delcas1()
        'not implemented
        Dim reg As String = "DELETE FROM cashier_account WHERE EmployeeID = '" & My.Forms.DeleteCashier.en.Text & "'"
        Try
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Deleted!")
                    My.Forms.DeleteCashier.Button1.Enabled = True
                    My.Forms.DeleteCashier.GroupBox2.Enabled = False
                    My.Forms.DeleteCashier.en.Enabled = True
                    My.Forms.DeleteCashier.en.Text = ""
                    My.Forms.DeleteCashier.ln.Text = ""
                    My.Forms.DeleteCashier.fn.Text = ""
                    My.Forms.DeleteCashier.mn.Text = ""
                    My.Forms.DeleteCashier.bd.Text = ""
                    My.Forms.DeleteCashier.add.Text = ""
                    My.Forms.DeleteCashier.eadd.Text = ""
                    My.Forms.DeleteCashier.cno.Text = ""
                    My.Forms.DeleteCashier.PictureBox1.Image = Nothing
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub dropstud()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO student_info_archive VALUES(@Photo, @Student_ID_No, @LastName, @GivenName, @MiddleName, @Birthday, @Birth_Place, @Gender, @Address, @Age, @Citizenship, @Religion, @SchoolYear, @GradeLevel, @Section, @Scholar, @MotherName, @OccupationM, @FatherName, @OccupationF, @Guardian, @Relation, @Contact, @NSO, @Baptismal, @Name_Of_LastSchool, @Address_of_LastSchool, @UploadCard, @UploadForm137, @UploadGoodMoral)"
            ins.Parameters.AddWithValue("@Photo", pic)
            ins.Parameters.AddWithValue("@Student_ID_No", My.Forms.DeleteStudent_A.sn.Text)
            ins.Parameters.AddWithValue("@LastName", LastN)
            ins.Parameters.AddWithValue("@GivenName", FirstN)
            ins.Parameters.AddWithValue("@MiddleName", MiddleN)
            ins.Parameters.AddWithValue("@Birthday", My.Forms.DeleteStudent_A.bd.Text)
            ins.Parameters.AddWithValue("@Birth_Place", Birthplace)
            ins.Parameters.AddWithValue("@Gender", Gender)
            ins.Parameters.AddWithValue("@Address", My.Forms.DeleteStudent_A.add.Text)
            ins.Parameters.AddWithValue("@Age", My.Forms.DeleteStudent_A.ag.Text)
            ins.Parameters.AddWithValue("@Citizenship", Citizen)
            ins.Parameters.AddWithValue("@Religion", religion)
            ins.Parameters.AddWithValue("@SchoolYear", My.Forms.DeleteStudent_A.sy.Text)
            ins.Parameters.AddWithValue("@GradeLevel", My.Forms.DeleteStudent_A.gl.Text)
            ins.Parameters.AddWithValue("@Section", Section)
            ins.Parameters.AddWithValue("@Scholar", Scholar)
            ins.Parameters.AddWithValue("@MotherName", MotherName)
            ins.Parameters.AddWithValue("@OccupationM", MotherOccupation)
            ins.Parameters.AddWithValue("@FatherName", FatherName)
            ins.Parameters.AddWithValue("@OccupationF", FatherOccupation)
            ins.Parameters.AddWithValue("@Guardian", Guardian)
            ins.Parameters.AddWithValue("@Relation", Relation)
            ins.Parameters.AddWithValue("@Contact", My.Forms.DeleteStudent_A.con.Text)
            ins.Parameters.AddWithValue("@NSO", NSO2)
            ins.Parameters.AddWithValue("@Baptismal", baptis)
            ins.Parameters.AddWithValue("@Name_Of_LastSchool", NameLastSchool)
            ins.Parameters.AddWithValue("@Address_of_LastSchool", AddressLastSchool)
            ins.Parameters.AddWithValue("@UploadCard", card)
            ins.Parameters.AddWithValue("@UploadForm137", form137)
            ins.Parameters.AddWithValue("@UploadGoodMoral", goodMoral)
            ins.ExecuteNonQuery()
            MotherName = ""
            MotherOccupation = ""
            FatherName = ""
            FatherOccupation = ""
            Guardian = ""
            Relation = ""
            Contact = ""
            AddressLastSchool = ""
            NameLastSchool = ""
            Section = ""
            Birthplace = ""
            Scholar = ""
            FirstN = ""
            MiddleN = ""
            LastN = ""
            religion = ""
            Citizen = ""
            Gender = ""
            objConn.Close()
            Dim reg As String = "DELETE FROM student_info WHERE Student_ID_No = '" & My.Forms.DeleteStudent_A.sn.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn1)
                    cn1.Open()
                    sqlCmd.ExecuteNonQuery()
                    pic = ""
                    My.Forms.DeleteStudent_A.DeleteButton_a_Student.Enabled = False
                    My.Forms.DeleteStudent_A.sn.Text = ""
                    My.Forms.DeleteStudent_A.nam.Text = ""
                    My.Forms.DeleteStudent_A.add.Text = ""
                    My.Forms.DeleteStudent_A.bd.Text = ""
                    My.Forms.DeleteStudent_A.gl.Text = ""
                    My.Forms.DeleteStudent_A.ag.Text = ""
                    My.Forms.DeleteStudent_A.sy.Text = ""
                    My.Forms.DeleteStudent_A.con.Text = ""
                    My.Forms.DeleteStudent_A.SearchStudent_btn.Enabled = True
                    My.Forms.DeleteStudent_A.sn.Enabled = True
                    My.Forms.DeleteStudent_A.PictureBox2.Image = Nothing
                    cn1.Close()
                End Using
                cn1.Close()
            End Using
            MsgBox("Student Info Deleted!!")
            My.Forms.DeleteStudent_A.DeleteButton_a_Student.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub dropstudR()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO student_info_archive VALUES(@Photo, @Student_ID_No, @LastName, @GivenName, @MiddleName, @Birthday, @Birth_Place, @Gender, @Address, @Age, @Citizenship, @Religion, @SchoolYear, @GradeLevel, @Section, @Scholar, @MotherName, @OccupationM, @FatherName, @OccupationF, @Guardian, @Relation, @Contact, @NSO, @Baptismal, @Name_Of_LastSchool, @Address_of_LastSchool, @UploadCard, @UploadForm137, @UploadGoodMoral)"
            ins.Parameters.AddWithValue("@Photo", pic)
            ins.Parameters.AddWithValue("@Student_ID_No", My.Forms.DeleteStudent_A.sn.Text)
            ins.Parameters.AddWithValue("@LastName", LastN)
            ins.Parameters.AddWithValue("@GivenName", FirstN)
            ins.Parameters.AddWithValue("@MiddleName", MiddleN)
            ins.Parameters.AddWithValue("@Birthday", My.Forms.DeleteStudent_A.bd.Text)
            ins.Parameters.AddWithValue("@Birth_Place", Birthplace)
            ins.Parameters.AddWithValue("@Gender", Gender)
            ins.Parameters.AddWithValue("@Address", My.Forms.DeleteStudent_A.add.Text)
            ins.Parameters.AddWithValue("@Age", My.Forms.DeleteStudent_A.ag.Text)
            ins.Parameters.AddWithValue("@Citizenship", Citizen)
            ins.Parameters.AddWithValue("@Religion", religion)
            ins.Parameters.AddWithValue("@SchoolYear", My.Forms.DeleteStudent_A.sy.Text)
            ins.Parameters.AddWithValue("@GradeLevel", My.Forms.DeleteStudent_A.gl.Text)
            ins.Parameters.AddWithValue("@Section", Section)
            ins.Parameters.AddWithValue("@Scholar", Scholar)
            ins.Parameters.AddWithValue("@MotherName", MotherName)
            ins.Parameters.AddWithValue("@OccupationM", MotherOccupation)
            ins.Parameters.AddWithValue("@FatherName", FatherName)
            ins.Parameters.AddWithValue("@OccupationF", FatherOccupation)
            ins.Parameters.AddWithValue("@Guardian", Guardian)
            ins.Parameters.AddWithValue("@Relation", Relation)
            ins.Parameters.AddWithValue("@Contact", My.Forms.DeleteStudent_A.con.Text)
            ins.Parameters.AddWithValue("@NSO", NSO2)
            ins.Parameters.AddWithValue("@Baptismal", baptis)
            ins.Parameters.AddWithValue("@Name_Of_LastSchool", NameLastSchool)
            ins.Parameters.AddWithValue("@Address_of_LastSchool", AddressLastSchool)
            ins.Parameters.AddWithValue("@UploadCard", card)
            ins.Parameters.AddWithValue("@UploadForm137", form137)
            ins.Parameters.AddWithValue("@UploadGoodMoral", goodMoral)
            ins.ExecuteNonQuery()
            MotherName = ""
            MotherOccupation = ""
            FatherName = ""
            FatherOccupation = ""
            Guardian = ""
            Relation = ""
            Contact = ""
            AddressLastSchool = ""
            NameLastSchool = ""
            Section = ""
            Birthplace = ""
            Scholar = ""
            FirstN = ""
            MiddleN = ""
            LastN = ""
            religion = ""
            Citizen = ""
            Gender = ""
            objConn.Close()
            Dim reg As String = "DELETE FROM student_info WHERE Student_ID_No = '" & My.Forms.DeleteStudent_A.sn.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn1)
                    cn1.Open()
                    sqlCmd.ExecuteNonQuery()
                    pic = ""
                    My.Forms.DeleteStudent_R.DeleteButton_a_Student.Enabled = False
                    My.Forms.DeleteStudent_R.sn.Text = ""
                    My.Forms.DeleteStudent_R.nam.Text = ""
                    My.Forms.DeleteStudent_R.add.Text = ""
                    My.Forms.DeleteStudent_R.bd.Text = ""
                    My.Forms.DeleteStudent_R.gl.Text = ""
                    My.Forms.DeleteStudent_R.ag.Text = ""
                    My.Forms.DeleteStudent_R.sy.Text = ""
                    My.Forms.DeleteStudent_R.con.Text = ""
                    My.Forms.DeleteStudent_R.SearchStudent_btn.Enabled = True
                    My.Forms.DeleteStudent_R.sn.Enabled = True
                    My.Forms.DeleteStudent_R.PictureBox2.Image = Nothing
                    cn1.Close()
                End Using
                cn1.Close()
            End Using
            MsgBox("Student Deleted!!")
            My.Forms.DeleteStudent_R.DeleteButton_a_Student.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub

    Public Sub editstud()
        'edit student info method guys, easy lang to maintindihan. alam naman na natin yung
        'routine natin kapag magttransact tayo kay database eh.
        If My.Forms.UpdateStudent_A.CheckBox2.Checked = True Then
            NSO2 = ""
            NSO2 = "YES"
        ElseIf My.Forms.UpdateStudent_A.CheckBox2.Checked = False Then
            NSO2 = ""
            NSO2 = "No"
        End If
        If My.Forms.UpdateStudent_A.CheckBox3.Checked = True Then
            baptis = ""
            baptis = "YES"
        ElseIf My.Forms.UpdateStudent_A.CheckBox3.Checked = False Then
            baptis = ""
            baptis = "No"
        End If

        If My.Forms.UpdateStudent_A.CheckBox4.Checked = True Then
            card = ""
            card = "YES"
        ElseIf My.Forms.UpdateStudent_A.CheckBox4.Checked = False Then
            card = ""
            card = "No"
        End If

        If My.Forms.UpdateStudent_A.CheckBox5.Checked = True Then
            goodMoral = ""
            goodMoral = "YES"
        ElseIf My.Forms.UpdateStudent_A.CheckBox5.Checked = False Then
            goodMoral = ""
            goodMoral = "No"
        End If
        If My.Forms.UpdateStudent_A.CheckBox6.Checked = True Then
            form137 = ""
            form137 = "YES"
        ElseIf My.Forms.UpdateStudent_A.CheckBox6.Checked = False Then
            form137 = ""
            form137 = "No"
        End If
        'edit Student info
        Try
            'eto yung sql query natin, which is UPDATE.
            Dim reg1 As String = "UPDATE student_info SET Address = '" & My.Forms.UpdateStudent_A.add.Text & "', Birthday = '" & My.Forms.UpdateStudent_A.bd.Text & "', GradeLevel = '" & My.Forms.UpdateStudent_A.gl.Text & "', Birthday = '" & My.Forms.UpdateStudent_A.bd.Text & "', Contact = '" & My.Forms.UpdateStudent_A.con.Text & "', SchoolYear = '" & My.Forms.UpdateStudent_A.sy.Text & "', Age = '" & My.Forms.UpdateStudent_A.ag.Text & "', NSO= '" & NSO2 & "', Baptismal = '" & baptis & "', UploadCard= '" & card & "', UploadForm137 = '" & form137 & "', UploadGoodMoral= '" & goodMoral & "' WHERE Student_ID_No = '" & My.Forms.UpdateStudent_A.sn.Text & "'"
            'eto yung connection string natin, (insert() noon), cn1 dito.
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg1, cn1)
                    cn1.Open() 'open connection
                    sqlCmd.ExecuteNonQuery() 'execute sql query
                    MsgBox("Student Information Updated Succesful!")
                    My.Forms.UpdateStudent_A.SearchStudent_btn.Enabled = True
                    My.Forms.UpdateStudent_A.UpdateButton_a_Student.Enabled = False
                    My.Forms.UpdateStudent_A.SearchStudent_btn.Enabled = True
                    My.Forms.UpdateStudent_A.sn.Enabled = True
                    My.Forms.UpdateStudent_A.sn.Text = ""
                    My.Forms.UpdateStudent_A.nam.Text = ""
                    My.Forms.UpdateStudent_A.add.Text = ""
                    My.Forms.UpdateStudent_A.bd.Text = ""
                    My.Forms.UpdateStudent_A.gl.Text = ""
                    My.Forms.UpdateStudent_A.con.Text = ""
                    My.Forms.UpdateStudent_A.sy.Text = ""
                    My.Forms.UpdateStudent_A.ag.Text = ""
                    NSO2 = ""
                    baptis = ""
                    card = ""
                    form137 = ""
                    goodMoral = ""
                    My.Forms.UpdateStudent_A.nso_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_A.baptismal_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_A.form_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_A.card_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_A.gm_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_A.PictureBox2.Image = Nothing
                    My.Forms.UpdateStudent_A.GroupBox1.Enabled = False

                    cn1.Close() 'close connection
                End Using
                cn1.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub editstud_R()
        Try
            If My.Forms.UpdateStudent_R.CheckBox2.Checked = True Then
                NSO2 = ""
                NSO2 = "YES"
            ElseIf My.Forms.UpdateStudent_R.CheckBox2.Checked = False Then
                NSO2 = ""
                NSO2 = "No"
            End If
            If My.Forms.UpdateStudent_R.CheckBox3.Checked = True Then
                baptis = ""
                baptis = "YES"
            ElseIf My.Forms.UpdateStudent_R.CheckBox3.Checked = False Then
                baptis = ""
                baptis = "No"
            End If

            If My.Forms.UpdateStudent_R.CheckBox4.Checked = True Then
                card = ""
                card = "YES"
            ElseIf My.Forms.UpdateStudent_R.CheckBox4.Checked = False Then
                card = ""
                card = "No"
            End If

            If My.Forms.UpdateStudent_R.CheckBox5.Checked = True Then
                goodMoral = ""
                goodMoral = "YES"
            ElseIf My.Forms.UpdateStudent_R.CheckBox5.Checked = False Then
                goodMoral = ""
                goodMoral = "No"
            End If
            If My.Forms.UpdateStudent_R.CheckBox6.Checked = True Then
                form137 = ""
                form137 = "YES"
            ElseIf My.Forms.UpdateStudent_R.CheckBox6.Checked = False Then
                form137 = ""
                form137 = "No"
            End If
            Dim reg1 As String = "UPDATE student_info SET Address = '" & My.Forms.UpdateStudent_R.add.Text & "', Birthday = '" & My.Forms.UpdateStudent_R.bd.Text & "', GradeLevel = '" & My.Forms.UpdateStudent_R.gl.Text & "', Birthday = '" & My.Forms.UpdateStudent_R.bd.Text & "', Contact = '" & My.Forms.UpdateStudent_R.con.Text & "', SchoolYear = '" & My.Forms.UpdateStudent_R.sy.Text & "', Age = '" & My.Forms.UpdateStudent_R.ag.Text & "', NSO= '" & NSO2 & "', Baptismal = '" & baptis & "', UploadCard= '" & card & "', UploadForm137 = '" & form137 & "', UploadGoodMoral= '" & goodMoral & "' WHERE Student_ID_No = '" & My.Forms.UpdateStudent_A.sn.Text & "'"
            'eto yung connection string natin, (insert() noon), cn1 dito.
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg1, cn1)
                    cn1.Open() 'open connection
                    sqlCmd.ExecuteNonQuery() 'execute sql query
                    MsgBox("Student Information Updated Succesful!")
                    My.Forms.UpdateStudent_R.SearchStudent_btn.Enabled = True
                    My.Forms.UpdateStudent_R.UpdateButton_a_Student.Enabled = False
                    My.Forms.UpdateStudent_R.SearchStudent_btn.Enabled = True
                    My.Forms.UpdateStudent_R.sn.Enabled = True
                    My.Forms.UpdateStudent_R.sn.Text = ""
                    My.Forms.UpdateStudent_R.nam.Text = ""
                    My.Forms.UpdateStudent_R.add.Text = ""
                    My.Forms.UpdateStudent_R.bd.Text = ""
                    My.Forms.UpdateStudent_R.gl.Text = ""
                    My.Forms.UpdateStudent_R.con.Text = ""
                    My.Forms.UpdateStudent_R.sy.Text = ""
                    My.Forms.UpdateStudent_R.ag.Text = ""
                    NSO2 = ""
                    baptis = ""
                    card = ""
                    form137 = ""
                    goodMoral = ""
                    My.Forms.UpdateStudent_R.nso_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_R.baptismal_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_R.form_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_R.card_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_R.gm_lbl.BackColor = Color.Transparent
                    My.Forms.UpdateStudent_R.PictureBox2.Image = Nothing
                    My.Forms.UpdateStudent_R.GroupBox1.Enabled = False
                    cn1.Close() 'close connection
                End Using
                cn1.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub vadmmin_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & My.Forms.UpdateAdmin.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateAdmin.ln.Text = r("Surname").ToString()
                My.Forms.UpdateAdmin.fn.Text = r("GivenName").ToString()
                My.Forms.UpdateAdmin.mn.Text = r("MiddleName").ToString()
                My.Forms.UpdateAdmin.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateAdmin.add.Text = r("Address").ToString()
                My.Forms.UpdateAdmin.eadd.Text = r("Email_Account").ToString()
                My.Forms.UpdateAdmin.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateAdmin.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateAdmin.GroupBox2.Enabled = True
                My.Forms.UpdateAdmin.ValidateAccountUpdate_btn.Enabled = False
                My.Forms.UpdateAdmin.en.Enabled = False
                My.Forms.UpdateAdmin.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.UpdateAdmin.en.Text = ""
                My.Forms.UpdateAdmin.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub updateAccntAdmin_btn()
        Try
            If (My.Forms.UpdateAdmin.ln.Text = "" And My.Forms.UpdateAdmin.fn.Text = "" _
              And My.Forms.UpdateAdmin.mn.Text = "" And My.Forms.UpdateAdmin.bd.Text = "" _
              And My.Forms.UpdateAdmin.add.Text = "" And My.Forms.UpdateAdmin.eadd.Text = "" _
              And My.Forms.UpdateAdmin.cno.Text = "") Then
                MsgBox("Please enter the empty fields")
            Else
                Dim reg As String = "UPDATE admin SET Surname = '" & My.Forms.UpdateAdmin.ln.Text & "', GivenName = '" & My.Forms.UpdateAdmin.fn.Text & "', MiddleName = '" & My.Forms.UpdateAdmin.mn.Text & "', Birthday = '" & My.Forms.UpdateAdmin.bd.Text & "', Address = '" & My.Forms.UpdateAdmin.add.Text & "', Email_Account = '" & My.Forms.UpdateAdmin.eadd.Text & "', ContactNumber = '" & My.Forms.UpdateAdmin.cno.Text & "', status = '" & My.Forms.UpdateAdmin.status.Text & "', LogIn_Attempts = 0 where EmployeeID = '" & My.Forms.UpdateAdmin.en.Text & "'"
                Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                    Using sqlCmd = New MySqlCommand(reg, cn1)
                        cn1.Open()
                        sqlCmd.ExecuteNonQuery()
                        MsgBox("Admin Account Updated!")
                        My.Forms.UpdateAdmin.en.Text = ""
                        My.Forms.UpdateAdmin.ln.Text = ""
                        My.Forms.UpdateAdmin.fn.Text = ""
                        My.Forms.UpdateAdmin.mn.Text = ""
                        My.Forms.UpdateAdmin.bd.Text = ""
                        My.Forms.UpdateAdmin.add.Text = ""
                        My.Forms.UpdateAdmin.eadd.Text = ""
                        My.Forms.UpdateAdmin.cno.Text = ""
                        My.Forms.UpdateAdmin.GroupBox2.Enabled = False
                        My.Forms.UpdateAdmin.ValidateAccountUpdate_btn.Enabled = True
                        My.Forms.UpdateAdmin.en.Enabled = True
                        My.Forms.UpdateAdmin.en.Focus()
                        My.Forms.UpdateAdmin.PictureBox1.Image = Nothing
                        cn1.Close()
                    End Using
                    cn1.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub vRegistrar_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.UpdateRegistrar.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateRegistrar.ln.Text = r("Surname").ToString()
                My.Forms.UpdateRegistrar.fn.Text = r("GivenName").ToString()
                My.Forms.UpdateRegistrar.mn.Text = r("MiddleName").ToString()
                My.Forms.UpdateRegistrar.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateRegistrar.add.Text = r("Address").ToString()
                My.Forms.UpdateRegistrar.eadd.Text = r("Email_Account").ToString()
                My.Forms.UpdateRegistrar.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateRegistrar.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateRegistrar.GroupBox2.Enabled = True
                My.Forms.UpdateRegistrar.ValidateAccountUpdate_btn.Enabled = False
                My.Forms.UpdateRegistrar.en.Enabled = False
                My.Forms.UpdateRegistrar.PictureBox1.Image = base64toimage(pic)
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.UpdateRegistrar.en.Text = ""
                My.Forms.UpdateRegistrar.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub rRegistrar_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM registrar_account WHERE (EmployeeID ='" & My.Forms.UpdateRegistrarR.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateRegistrarR.ln.Text = r("Surname").ToString()
                My.Forms.UpdateRegistrarR.fn.Text = r("GivenName").ToString()
                My.Forms.UpdateRegistrarR.mn.Text = r("MiddleName").ToString()
                My.Forms.UpdateRegistrarR.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateRegistrarR.add.Text = r("Address").ToString()
                My.Forms.UpdateRegistrarR.eadd.Text = r("Email_Account").ToString()
                My.Forms.UpdateRegistrarR.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateRegistrarR.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateRegistrarR.GroupBox2.Enabled = True
                My.Forms.UpdateRegistrarR.ValidateAccountUpdate_btn.Enabled = False
                My.Forms.UpdateRegistrarR.en.Enabled = False
                My.Forms.UpdateRegistrarR.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.UpdateRegistrarR.en.Text = ""
                My.Forms.UpdateRegistrarR.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub updateAccntRegistrar_btn()
        Try
            If (My.Forms.UpdateRegistrar.ln.Text = "" And My.Forms.UpdateRegistrar.fn.Text = "" _
              And My.Forms.UpdateRegistrar.mn.Text = "" And My.Forms.UpdateRegistrar.bd.Text = "" _
              And My.Forms.UpdateRegistrar.add.Text = "" And My.Forms.UpdateRegistrar.eadd.Text = "" _
              And My.Forms.UpdateRegistrar.cno.Text = "") Then
                MsgBox("Please enter the empty fields")
            Else
                Dim reg As String = "UPDATE registrar_account SET Surname = '" & My.Forms.UpdateRegistrar.ln.Text & "', GivenName = '" & My.Forms.UpdateRegistrar.fn.Text & "', MiddleName = '" & My.Forms.UpdateRegistrar.mn.Text & "', Birthday = '" & My.Forms.UpdateRegistrar.bd.Text & "', Address = '" & My.Forms.UpdateRegistrar.add.Text & "', Email_Account = '" & My.Forms.UpdateRegistrar.eadd.Text & "', ContactNumber = '" & My.Forms.UpdateRegistrar.cno.Text & "' , status = '" & My.Forms.UpdateRegistrar.status.Text & "', LogIn_Attempts = 0 WHERE EmployeeID = '" & My.Forms.UpdateRegistrar.en.Text & "' "
                Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                    Using sqlCmd = New MySqlCommand(reg, cn1)
                        cn1.Open()
                        sqlCmd.ExecuteNonQuery()
                        MsgBox("Registrar Account Updated!")
                        My.Forms.UpdateRegistrar.en.Text = ""
                        My.Forms.UpdateRegistrar.ln.Text = ""
                        My.Forms.UpdateRegistrar.fn.Text = ""
                        My.Forms.UpdateRegistrar.mn.Text = ""
                        My.Forms.UpdateRegistrar.bd.Text = ""
                        My.Forms.UpdateRegistrar.add.Text = ""
                        My.Forms.UpdateRegistrar.eadd.Text = ""
                        My.Forms.UpdateRegistrar.cno.Text = ""
                        My.Forms.UpdateRegistrar.GroupBox2.Enabled = False
                        My.Forms.UpdateRegistrar.ValidateAccountUpdate_btn.Enabled = True
                        My.Forms.UpdateRegistrar.en.Enabled = True
                        My.Forms.UpdateRegistrar.en.Focus()
                        My.Forms.UpdateRegistrar.PictureBox1.Image = Nothing
                        cn1.Close()
                    End Using
                    cn1.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub updateAccntRegistrarR_btn()
        Try
            If (My.Forms.UpdateRegistrarR.ln.Text = "" And My.Forms.UpdateRegistrarR.fn.Text = "" _
              And My.Forms.UpdateRegistrarR.mn.Text = "" And My.Forms.UpdateRegistrarR.bd.Text = "" _
              And My.Forms.UpdateRegistrarR.add.Text = "" And My.Forms.UpdateRegistrarR.eadd.Text = "" _
              And My.Forms.UpdateRegistrarR.cno.Text = "") Then
                MsgBox("Please enter the empty fields")
            Else
                Dim reg As String = "UPDATE registrar_account SET Surname = '" & My.Forms.UpdateRegistrarR.ln.Text & "', GivenName = '" & My.Forms.UpdateRegistrarR.fn.Text & "', MiddleName = '" & My.Forms.UpdateRegistrarR.mn.Text & "', Birthday = '" & My.Forms.UpdateRegistrarR.bd.Text & "', Address = '" & My.Forms.UpdateRegistrarR.add.Text & "', Email_Account = '" & My.Forms.UpdateRegistrarR.eadd.Text & "', ContactNumber = '" & My.Forms.UpdateRegistrarR.cno.Text & "' , status = '" & My.Forms.UpdateRegistrarR.status.Text & "', LogIn_Attempts = 0 WHERE EmployeeID = '" & My.Forms.UpdateRegistrarR.en.Text & "' "
                Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                    Using sqlCmd = New MySqlCommand(reg, cn1)
                        cn1.Open()
                        sqlCmd.ExecuteNonQuery()
                        MsgBox("Registrar Account Updated!")
                        My.Forms.UpdateRegistrarR.en.Text = ""
                        My.Forms.UpdateRegistrarR.ln.Text = ""
                        My.Forms.UpdateRegistrarR.fn.Text = ""
                        My.Forms.UpdateRegistrarR.mn.Text = ""
                        My.Forms.UpdateRegistrarR.bd.Text = ""
                        My.Forms.UpdateRegistrarR.add.Text = ""
                        My.Forms.UpdateRegistrarR.eadd.Text = ""
                        My.Forms.UpdateRegistrarR.cno.Text = ""
                        My.Forms.UpdateRegistrarR.GroupBox2.Enabled = False
                        My.Forms.UpdateRegistrarR.ValidateAccountUpdate_btn.Enabled = True
                        My.Forms.UpdateRegistrarR.en.Enabled = True
                        My.Forms.UpdateRegistrarR.en.Focus()
                        My.Forms.UpdateRegistrarR.PictureBox1.Image = Nothing
                        cn1.Close()
                    End Using
                    cn1.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub vCashier_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.UpdateCashier.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateCashier.ln.Text = r("Surname").ToString()
                My.Forms.UpdateCashier.fn.Text = r("GivenName").ToString()
                My.Forms.UpdateCashier.mn.Text = r("MiddleName").ToString()
                My.Forms.UpdateCashier.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateCashier.add.Text = r("Address").ToString()
                My.Forms.UpdateCashier.eadd.Text = r("Email_Account").ToString()
                My.Forms.UpdateCashier.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateCashier.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateCashier.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateCashier.GroupBox2.Enabled = True
                My.Forms.UpdateCashier.ValidateAccountUpdate_btn.Enabled = False
                My.Forms.UpdateCashier.en.Enabled = False
                My.Forms.UpdateCashier.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.UpdateCashier.en.Text = ""
                My.Forms.UpdateCashier.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SCashier_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM cashier_account WHERE (EmployeeID ='" & My.Forms.UpdateCashierC.en.Text & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateCashierC.ln.Text = r("Surname").ToString()
                My.Forms.UpdateCashierC.fn.Text = r("GivenName").ToString()
                My.Forms.UpdateCashierC.mn.Text = r("MiddleName").ToString()
                My.Forms.UpdateCashierC.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateCashierC.add.Text = r("Address").ToString()
                My.Forms.UpdateCashierC.eadd.Text = r("Email_Account").ToString()
                My.Forms.UpdateCashierC.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateCashierC.eadd.Text = r("Email_Account").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateCashierC.cno.Text = r("ContactNumber").ToString()
                My.Forms.UpdateCashierC.GroupBox2.Enabled = True
                My.Forms.UpdateCashierC.ValidateAccountUpdate_btn.Enabled = False
                My.Forms.UpdateCashierC.en.Enabled = False
                My.Forms.UpdateCashierC.PictureBox1.Image = base64toimage(pic)
                pic = ""
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.UpdateCashierC.en.Text = ""
                My.Forms.UpdateCashierC.en.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function
    Public Sub updateAccntCashier_btn()
        Try
            If (My.Forms.UpdateCashier.ln.Text = "" And My.Forms.UpdateCashier.fn.Text = "" _
              And My.Forms.UpdateCashier.mn.Text = "" And My.Forms.UpdateCashier.bd.Text = "" _
              And My.Forms.UpdateCashier.add.Text = "" And My.Forms.UpdateCashier.eadd.Text = "" _
              And My.Forms.UpdateCashier.cno.Text = "") Then
                MsgBox("Please enter the empty fields")
            Else
                Dim reg As String = "UPDATE cashier_account SET Surname = '" & My.Forms.UpdateCashier.ln.Text & "', GivenName = '" & My.Forms.UpdateCashier.fn.Text & "', MiddleName = '" & My.Forms.UpdateCashier.mn.Text & "', Birthday = '" & My.Forms.UpdateCashier.bd.Text & "', Address = '" & My.Forms.UpdateCashier.add.Text & "', Email_Account = '" & My.Forms.UpdateCashier.eadd.Text & "', ContactNumber = '" & My.Forms.UpdateCashier.cno.Text & "', status = '" & My.Forms.UpdateCashier.status.Text & "', LogIn_Attempts = 0 where EmployeeID = '" & My.Forms.UpdateCashier.en.Text & "'"
                Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                    Using sqlCmd = New MySqlCommand(reg, cn1)
                        cn1.Open()
                        sqlCmd.ExecuteNonQuery()
                        MsgBox("Cashier Account Updated!")
                        My.Forms.UpdateCashier.en.Text = ""
                        My.Forms.UpdateCashier.ln.Text = ""
                        My.Forms.UpdateCashier.fn.Text = ""
                        My.Forms.UpdateCashier.mn.Text = ""
                        My.Forms.UpdateCashier.bd.Text = ""
                        My.Forms.UpdateCashier.add.Text = ""
                        My.Forms.UpdateCashier.eadd.Text = ""
                        My.Forms.UpdateCashier.cno.Text = ""
                        My.Forms.UpdateCashier.GroupBox2.Enabled = False
                        My.Forms.UpdateCashier.ValidateAccountUpdate_btn.Enabled = True
                        My.Forms.UpdateCashier.en.Enabled = True
                        My.Forms.UpdateCashier.PictureBox1.Image = Nothing
                        My.Forms.UpdateCashier.en.Focus()
                        cn1.Close()
                    End Using
                    cn1.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub UpdateCashiercc()
        Try
            If (My.Forms.UpdateCashierC.ln.Text = "" And My.Forms.UpdateCashierC.fn.Text = "" _
              And My.Forms.UpdateCashierC.mn.Text = "" And My.Forms.UpdateCashierC.bd.Text = "" _
              And My.Forms.UpdateCashierC.add.Text = "" And My.Forms.UpdateCashierC.eadd.Text = "" _
              And My.Forms.UpdateCashierC.cno.Text = "") Then
                MsgBox("Please enter the empty fields")
            Else
                Dim reg As String = "UPDATE cashier_account SET Surname = '" & My.Forms.UpdateCashierC.ln.Text & "', GivenName = '" & My.Forms.UpdateCashierC.fn.Text & "', MiddleName = '" & My.Forms.UpdateCashierC.mn.Text & "', Birthday = '" & My.Forms.UpdateCashierC.bd.Text & "', Address = '" & My.Forms.UpdateCashierC.add.Text & "', Email_Account = '" & My.Forms.UpdateCashierC.eadd.Text & "', ContactNumber = '" & My.Forms.UpdateCashierC.cno.Text & "', status = '" & My.Forms.UpdateCashierC.status.Text & "', LogIn_Attempts = 0 where EmployeeID = '" & My.Forms.UpdateCashierC.en.Text & "'"
                Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                    Using sqlCmd = New MySqlCommand(reg, cn1)
                        cn1.Open()
                        sqlCmd.ExecuteNonQuery()
                        MsgBox("Cashier Account Updated!")
                        My.Forms.UpdateCashierC.en.Text = ""
                        My.Forms.UpdateCashierC.ln.Text = ""
                        My.Forms.UpdateCashierC.fn.Text = ""
                        My.Forms.UpdateCashierC.mn.Text = ""
                        My.Forms.UpdateCashierC.bd.Text = ""
                        My.Forms.UpdateCashierC.add.Text = ""
                        My.Forms.UpdateCashierC.eadd.Text = ""
                        My.Forms.UpdateCashierC.cno.Text = ""
                        My.Forms.UpdateCashierC.GroupBox2.Enabled = False
                        My.Forms.UpdateCashierC.ValidateAccountUpdate_btn.Enabled = True
                        My.Forms.UpdateCashierC.en.Enabled = True
                        My.Forms.UpdateCashierC.PictureBox1.Image = Nothing
                        My.Forms.UpdateCashierC.en.Focus()
                        cn1.Close()
                    End Using
                    cn1.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub updateSubjA_btn()
        'Try
        '    If (My.Forms.UpdateClass_A.nm.Text = "" And My.Forms.UpdateClass_A.teacher.Text = "" _
        '      And My.Forms.UpdateClass_A.sy.Text = "" And My.Forms.UpdateClass_A.nm.Text = "") Then
        '        MsgBox("Please enter the empty fields")
        '    Else
        '        Dim reg As String = "UPDATE subject_tbl SET Grade_Level = '" & My.Forms.UpdateClass_A.gl.Text & "', School_Year = '" & My.Forms.UpdateClass_A.sy.Text & "', Time = '" & My.Forms.UpdateClass_A.tim.Text & "', No_Minutes = '" & My.Forms.UpdateClass_A.nm.Text = "" & "', Teacher = '" & My.Forms.UpdateClass_A.teacher.Text & "'"
        '        Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
        '            Using sqlCmd = New MySqlCommand(reg, cn1)
        '                cn1.Open()
        '                sqlCmd.ExecuteNonQuery()
        '                MsgBox("Subject Updated!")
        '                My.Forms.UpdateClass_A.gl.Text = ""
        '                'My.Forms.UpdateClass_A.sec.Text = ""
        '                My.Forms.UpdateClass_A.nm.Text = ""
        '                My.Forms.UpdateClass_A.teacher.Text = ""
        '                My.Forms.UpdateClass_A.sy.Text = ""
        '                My.Forms.UpdateClass_A.tim.Text = ""
        '                My.Forms.UpdateClass_A.GroupBox2.Enabled = False
        '                My.Forms.UpdateClass_A.SearchSubj_btn.Enabled = True
        '                My.Forms.UpdateClass_A.subj.Enabled = True
        '                My.Forms.UpdateClass_A.subj.Focus()
        '                cn1.Close()
        '            End Using
        '            cn1.Close()
        '        End Using
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    cn.Close()
        'End Try
    End Sub
    Public Sub SearchSubjR_btn()
        ''not implemented
        'Try
        '    insert()
        '    Dim r As MySqlDataReader
        '    Dim reg As String = "SELECT * FROM subject_tbl WHERE (Subject_Name ='" & My.Forms.UpdateClass_A.subj.Text & "')"
        '    cn.Open()
        '    Dim cmd As MySqlCommand = New MySqlCommand(reg, cn)
        '    r = cmd.ExecuteReader()
        '    If r.Read Then
        '        My.Forms.UpdateClass_A.gl.Text = r("Grade_Level").ToString()
        '        'My.Forms.UpdateClass_A.sec.Text = r("Section").ToString()
        '        My.Forms.UpdateClass_A.sy.Text = r("School_Year").ToString()
        '        My.Forms.UpdateClass_A.tim.Text = r("Time").ToString()
        '        My.Forms.UpdateClass_A.nm.Text = r("No_Minutes").ToString()
        '        My.Forms.UpdateClass_A.teacher.Text = r("Teacher").ToString()
        '        My.Forms.UpdateClass_A.SearchSubj_btn.Enabled = False
        '        My.Forms.UpdateClass_A.subj.Enabled = False
        '        cn.Close()
        '    Else
        '        MsgBox("EmployeeID not Found!")
        '        My.Forms.UpdateClass_A.subj.Text = ""
        '        My.Forms.UpdateClass_A.subj.Focus()
        '        cn.Close()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    cn.Close()
        'End Try
    End Sub
    Public Sub updateSubjR_btn()
        'Try
        '    If (My.Forms.UpdateClass_A.nm.Text = "" And My.Forms.UpdateClass_A.teacher.Text = "" _
        '      And My.Forms.UpdateClass_A.sy.Text = "" And My.Forms.UpdateClass_A.nm.Text = "") Then
        '        MsgBox("Please enter the empty fields")
        '    Else
        '        Dim reg As String = "UPDATE subject_tbl SET Grade_Level = '" & My.Forms.UpdateClass_A.gl.Text & "', School_Year = '" & My.Forms.UpdateClass_A.sy.Text & "', Time = '" & My.Forms.UpdateClass_A.tim.Text & "', No_Minutes = '" & My.Forms.UpdateClass_A.nm.Text = "" & "', Teacher = '" & My.Forms.UpdateClass_A.teacher.Text & "'"
        '        Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
        '            Using sqlCmd = New MySqlCommand(reg, cn1)
        '                cn1.Open()
        '                sqlCmd.ExecuteNonQuery()
        '                MsgBox("Subject Updated!")
        '                My.Forms.UpdateClass_A.gl.Text = ""
        '                'My.Forms.UpdateClass_A.sec.Text = ""
        '                My.Forms.UpdateClass_A.nm.Text = ""
        '                My.Forms.UpdateClass_A.teacher.Text = ""
        '                My.Forms.UpdateClass_A.sy.Text = ""
        '                My.Forms.UpdateClass_A.tim.Text = ""
        '                My.Forms.UpdateClass_A.GroupBox2.Enabled = False
        '                My.Forms.UpdateClass_A.SearchSubj_btn.Enabled = True
        '                My.Forms.UpdateClass_A.subj.Enabled = True
        '                My.Forms.UpdateClass_A.subj.Focus()
        '                cn1.Close()
        '            End Using
        '            cn1.Close()
        '        End Using
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    cn.Close()
        'End Try
    End Sub
    Public Sub SearchSubject_A_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader

            Dim ViewSubject_frm As String = "SELECT * FROM subject_tbl WHERE (Subject_Name ='" & My.Forms.ViewClass.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(ViewSubject_frm, cn)
            r = cmd.ExecuteReader()
            If r.Read Then
                'For form ViewSubject_frm search button
                cn.Close()
            Else
                MsgBox("EmployeeID not Found!")
                My.Forms.ViewClass.subj.Text = ""
                My.Forms.ViewClass.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub deleteSubject_A()
        'not implemented

        Dim reg As String = "DELETE FROM subject_tbl WHERE Grade_Level = '" & My.Forms.DeleteSub_A.subj.SelectedItem.ToString & "' and Section = '" & My.Forms.DeleteSub_A.sec.SelectedItem.ToString & "' "
        Try
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    My.Forms.DeleteSub_A.GroupBox2.Enabled = False
                    My.Forms.DeleteSub_A.GroupBox1.Enabled = True
                    MsgBox("Subject Deleted!")
                    My.Forms.DeleteSub_A.subj.SelectedItem.index = -1
                    My.Forms.DeleteSub_A.sec.SelectedItem.index = -1
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub deleteSubject_R()
        Dim reg As String = "DELETE FROM subject_tbl WHERE Grade_Level = '" & My.Forms.DeleteClass.subj.SelectedItem.ToString & "' and Section = '" & My.Forms.DeleteClass.sec.SelectedItem.ToString & "' "
        Try
            Using cn = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn)
                    cn.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Class Deleted!")
                    My.Forms.DeleteClass.GroupBox2.Enabled = False
                    My.Forms.DeleteClass.GroupBox1.Enabled = True
                    cn.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchSubject_A_Update_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim UpdateSub_A_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.UpdateClass_A.subj.Text & "')"
            cn.Open()
            Dim cmd1 As MySqlCommand = New MySqlCommand(UpdateSub_A_frm, cn)
            r = cmd1.ExecuteReader()
            If r.Read Then

                'For form UpdateSub_A search button
                My.Forms.UpdateClass_A.sec.Items.Clear()
                My.Forms.UpdateClass_A.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.UpdateClass_A.sec.Items.Add(r("Section").ToString())
                End While
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchSubject_R_Update_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim UpdateSub_A_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.UpdateClass_R.subj.Text & "')"
            cn.Open()
            Dim cmd1 As MySqlCommand = New MySqlCommand(UpdateSub_A_frm, cn)
            r = cmd1.ExecuteReader()
            If r.Read Then

                'For form UpdateSub_A search button
                My.Forms.UpdateClass_R.sec.Items.Clear()
                My.Forms.UpdateClass_R.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.UpdateClass_R.sec.Items.Add(r("Section").ToString())
                End While
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.UpdateClass_R.subj.Text = ""
                My.Forms.UpdateClass_R.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchSubject_A_Delete_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim DeleteSubj_R_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.DeleteSub_A.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(DeleteSubj_R_frm, cn)

            r = cmd.ExecuteReader()
            If r.Read Then

                My.Forms.DeleteSub_A.sec.Items.Clear()
                My.Forms.DeleteSub_A.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.DeleteSub_A.sec.Items.Add(r("Section").ToString())
                End While
                My.Forms.DeleteSub_A.GroupBox2.Enabled = True
                My.Forms.DeleteSub_A.GroupBox1.Enabled = False
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.DeleteSub_A.subj.Text = ""
                My.Forms.DeleteSub_A.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchSubject_R_Delete_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim DeleteSubj_R_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.DeleteSubj_R.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(DeleteSubj_R_frm, cn)

            r = cmd.ExecuteReader()
            If r.Read Then

                My.Forms.DeleteSubj_R.sec.Items.Clear()
                My.Forms.DeleteSubj_R.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.DeleteSubj_R.sec.Items.Add(r("Section").ToString())
                End While
                My.Forms.DeleteSubj_R.GroupBox2.Enabled = True
                My.Forms.DeleteSubj_R.GroupBox1.Enabled = False
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.DeleteSubj_R.subj.Text = ""
                My.Forms.DeleteSubj_R.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub

    Public Sub SearchSubject_A_View_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim DeleteSubj_R_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.ViewClass.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(DeleteSubj_R_frm, cn)

            r = cmd.ExecuteReader()
            If r.Read Then

                My.Forms.ViewClass.sec.Items.Clear()
                My.Forms.ViewClass.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.ViewClass.sec.Items.Add(r("Section").ToString())
                End While
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.ViewClass.subj.Text = ""
                My.Forms.ViewClass.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try

    End Sub
    Public Sub SearchSubject_R_View_btn()
        'not implemented
        Try
            insert()
            Dim r As MySqlDataReader
            Dim DeleteSubj_R_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.ViewClassR.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(DeleteSubj_R_frm, cn)

            r = cmd.ExecuteReader()
            If r.Read Then

                My.Forms.ViewClassR.sec.Items.Clear()
                My.Forms.ViewClassR.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.ViewClassR.sec.Items.Add(r("Section").ToString())
                End While
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.ViewClassR.subj.Text = ""
                My.Forms.ViewClassR.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchStudent_A_Update_btn()
        Dim conn As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.UpdateStudent_A.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateStudent_A.sn.Text = r("Student_ID_No").ToString()
                My.Forms.UpdateStudent_A.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.UpdateStudent_A.add.Text = r("Address").ToString()
                My.Forms.UpdateStudent_A.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateStudent_A.gl.Text = r("GradeLevel").ToString()
                My.Forms.UpdateStudent_A.con.Text = r("Contact").ToString()
                My.Forms.UpdateStudent_A.sy.Text = r("SchoolYear").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateStudent_A.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()

                My.Forms.UpdateStudent_A.add.Enabled = True
                My.Forms.UpdateStudent_A.bd.Enabled = True
                My.Forms.UpdateStudent_A.gl.Enabled = True
                My.Forms.UpdateStudent_A.con.Enabled = True
                My.Forms.UpdateStudent_A.sy.Enabled = True

                My.Forms.UpdateStudent_A.ag.Enabled = True
                My.Forms.UpdateStudent_A.sn.Enabled = False
                My.Forms.UpdateStudent_A.SearchStudent_btn.Enabled = False
                My.Forms.UpdateStudent_A.UpdateButton_a_Student.Enabled = True
                My.Forms.UpdateStudent_A.PictureBox2.Image = base64toimage(pic)
                pic = ""

              


                NSO2 = r("NSO").ToString()
                If NSO2 = "No" Then
                    My.Forms.UpdateStudent_A.nso_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_A.CheckBox2.Checked = False
                Else
                    My.Forms.UpdateStudent_A.nso_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_A.CheckBox2.Checked = True
                End If


                baptis = r("Baptismal").ToString()
                If baptis = "No" Then
                    My.Forms.UpdateStudent_A.baptismal_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_A.CheckBox3.Checked = False
                Else
                    My.Forms.UpdateStudent_A.baptismal_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_A.CheckBox3.Checked = True
                End If

                card = r("UploadCard").ToString()
                If card = "No" Then
                    My.Forms.UpdateStudent_A.card_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_A.CheckBox4.Checked = False
                Else
                    My.Forms.UpdateStudent_A.card_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_A.CheckBox4.Checked = True
                End If

                form137 = r("UploadForm137").ToString()
                If form137 = "No" Then
                    My.Forms.UpdateStudent_A.form_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_A.CheckBox5.Checked = False
                Else
                    My.Forms.UpdateStudent_A.form_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_A.CheckBox5.Checked = True
                End If

                goodMoral = r("UploadGoodMoral").ToString()
                If goodMoral = "No" Then
                    My.Forms.UpdateStudent_A.gm_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_A.CheckBox6.Checked = False
                Else
                    My.Forms.UpdateStudent_A.gm_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_A.CheckBox6.Checked = True
                End If

                My.Forms.UpdateStudent_A.GroupBox1.Enabled = True
                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.UpdateStudent_A.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub SearchClass_A_Delete_btn()
        Try
            insert()
            Dim r As MySqlDataReader
            Dim DeleteSubj_R_frm As String = "SELECT * FROM subject_tbl WHERE (Grade_Level ='" & My.Forms.DeleteClass.subj.SelectedItem & "')"
            cn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(DeleteSubj_R_frm, cn)

            r = cmd.ExecuteReader()
            If r.Read Then

                My.Forms.DeleteClass.sec.Items.Clear()
                My.Forms.DeleteClass.sec.Items.Add(r("Section").ToString())
                While (r.Read())
                    My.Forms.DeleteClass.sec.Items.Add(r("Section").ToString())
                End While
                My.Forms.DeleteClass.GroupBox1.Enabled = False
                My.Forms.DeleteClass.GroupBox2.Enabled = True
                cn.Close()
            Else
                MsgBox("Subject not Found!")
                My.Forms.DeleteClass.subj.Text = ""
                My.Forms.DeleteClass.subj.Focus()
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchStudent_A_Delete_btn()
        Dim conn1 As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn1.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg1 As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.DeleteStudent_A.sn.Text & "')"
            conn1.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg1, conn1) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.DeleteStudent_A.sn.Text = r("Student_ID_No").ToString()
                My.Forms.DeleteStudent_A.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.DeleteStudent_A.add.Text = r("Address").ToString()
                My.Forms.DeleteStudent_A.bd.Text = r("Birthday").ToString()
                My.Forms.DeleteStudent_A.gl.Text = r("GradeLevel").ToString()
                My.Forms.DeleteStudent_A.con.Text = r("Contact").ToString()
                My.Forms.DeleteStudent_A.sy.Text = r("SchoolYear").ToString()
                MotherName = r("MotherName").ToString
                MotherOccupation = r("OccupationM").ToString
                FatherName = r("FatherName").ToString
                FatherOccupation = r("OccupationF").ToString
                Guardian = r("Guardian").ToString
                Relation = r("Relation").ToString
                Contact = r("Contact").ToString
                AddressLastSchool = r("Address_of_LastSchool").ToString
                NameLastSchool = r("Name_Of_LastSchool").ToString
                Section = r("Section").ToString
                Birthplace = r("Birth_Place").ToString
                Scholar = r("Scholar").ToString
                FirstN = r("GivenName").ToString
                MiddleN = r("MiddleName").ToString
                LastN = r("LastName").ToString
                religion = r("Religion").ToString
                Citizen = r("Citizenship").ToString
                Gender = r("Gender").ToString



                pic = r("Photo").ToString()
                My.Forms.DeleteStudent_A.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()
                My.Forms.DeleteStudent_A.PictureBox2.Image = base64toimage(pic)

                My.Forms.DeleteStudent_A.SearchStudent_btn.Enabled = False
                My.Forms.DeleteStudent_A.DeleteButton_a_Student.Enabled = True


                conn1.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.DeleteStudent_A.sn.Focus()
                conn1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn1.Close()
    End Sub
    Public Sub SearchStudent_R_Delete_btn()
        Dim conn As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.DeleteStudent_R.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.DeleteStudent_R.sn.Text = r("Student_ID_No").ToString()
                My.Forms.DeleteStudent_R.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.DeleteStudent_R.add.Text = r("Address").ToString()
                My.Forms.DeleteStudent_R.bd.Text = r("Birthday").ToString()
                My.Forms.DeleteStudent_R.gl.Text = r("GradeLevel").ToString()
                My.Forms.DeleteStudent_R.con.Text = r("Contact").ToString()
                My.Forms.DeleteStudent_R.sy.Text = r("SchoolYear").ToString()
                MotherName = r("MotherName").ToString
                MotherOccupation = r("OccupationM").ToString
                FatherName = r("FatherName").ToString
                FatherOccupation = r("OccupationF").ToString
                Guardian = r("Guardian").ToString
                Relation = r("Relation").ToString
                Contact = r("Contact").ToString
                AddressLastSchool = r("Address_of_LastSchool").ToString
                NameLastSchool = r("Name_Of_LastSchool").ToString
                Section = r("Section").ToString
                Birthplace = r("Birth_Place").ToString
                Scholar = r("Scholar").ToString
                FirstN = r("GivenName").ToString
                MiddleN = r("MiddleName").ToString
                LastN = r("LastName").ToString
                religion = r("Religion").ToString
                Citizen = r("Citizenship").ToString
                Gender = r("Gender").ToString



                pic = r("Photo").ToString()
                My.Forms.DeleteStudent_R.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()
                My.Forms.DeleteStudent_R.PictureBox2.Image = base64toimage(pic)

                My.Forms.DeleteStudent_R.SearchStudent_btn.Enabled = False
                My.Forms.DeleteStudent_R.DeleteButton_a_Student.Enabled = True


                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.DeleteStudent_A.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub SearchStudent_r_Update_btn()
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.UpdateStudent_R.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.UpdateStudent_R.sn.Text = r("Student_ID_No").ToString()
                My.Forms.UpdateStudent_R.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.UpdateStudent_R.add.Text = r("Address").ToString()
                My.Forms.UpdateStudent_R.bd.Text = r("Birthday").ToString()
                My.Forms.UpdateStudent_R.gl.Text = r("GradeLevel").ToString()
                My.Forms.UpdateStudent_R.con.Text = r("Contact").ToString()
                My.Forms.UpdateStudent_R.sy.Text = r("SchoolYear").ToString()
                pic = r("Photo").ToString()
                My.Forms.UpdateStudent_R.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()

                My.Forms.UpdateStudent_R.add.Enabled = True
                My.Forms.UpdateStudent_R.bd.Enabled = True
                My.Forms.UpdateStudent_R.gl.Enabled = True
                My.Forms.UpdateStudent_R.con.Enabled = True
                My.Forms.UpdateStudent_R.sy.Enabled = True

                My.Forms.UpdateStudent_R.ag.Enabled = True
                My.Forms.UpdateStudent_R.sn.Enabled = False
                My.Forms.UpdateStudent_R.SearchStudent_btn.Enabled = False
                My.Forms.UpdateStudent_R.UpdateButton_a_Student.Enabled = True
                My.Forms.UpdateStudent_R.PictureBox2.Image = base64toimage(pic)
                pic = ""

                NSO2 = r("NSO").ToString()
                If NSO2 = "No" Then
                    My.Forms.UpdateStudent_R.nso_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_R.CheckBox2.Checked = False
                Else
                    My.Forms.UpdateStudent_R.nso_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_R.CheckBox2.Checked = True
                End If


                baptis = r("Baptismal").ToString()
                If baptis = "No" Then
                    My.Forms.UpdateStudent_R.baptismal_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_R.CheckBox3.Checked = False
                Else
                    My.Forms.UpdateStudent_R.baptismal_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_R.CheckBox3.Checked = True
                End If

                card = r("UploadCard").ToString()
                If card = "No" Then
                    My.Forms.UpdateStudent_R.card_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_R.CheckBox4.Checked = False
                Else
                    My.Forms.UpdateStudent_R.card_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_R.CheckBox4.Checked = True
                End If

                form137 = r("UploadForm137").ToString()
                If form137 = "No" Then
                    My.Forms.UpdateStudent_R.form_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_R.CheckBox5.Checked = False
                Else
                    My.Forms.UpdateStudent_R.form_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_R.CheckBox5.Checked = True
                End If

                goodMoral = r("UploadGoodMoral").ToString()
                If goodMoral = "No" Then
                    My.Forms.UpdateStudent_R.gm_lbl.BackColor = Color.Red
                    My.Forms.UpdateStudent_R.CheckBox6.Checked = False
                Else
                    My.Forms.UpdateStudent_R.gm_lbl.BackColor = Color.Green
                    My.Forms.UpdateStudent_R.CheckBox6.Checked = True
                End If

                My.Forms.UpdateStudent_R.GroupBox1.Enabled = True
                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.UpdateStudent_R.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub SearchStudent_A_ViewStudent_btn()
        Dim conn As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.ViewStudent.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.ViewStudent.sn.Text = r("Student_ID_No").ToString()
                My.Forms.ViewStudent.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.ViewStudent.add.Text = r("Address").ToString()
                My.Forms.ViewStudent.bd.Text = r("Birthday").ToString()
                My.Forms.ViewStudent.gl.Text = r("GradeLevel").ToString()
                My.Forms.ViewStudent.con.Text = r("Contact").ToString()
                My.Forms.ViewStudent.sy.Text = r("SchoolYear").ToString()
                pic = r("Photo").ToString()
                My.Forms.ViewStudent.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()

                My.Forms.ViewStudent.add.Enabled = True
                My.Forms.ViewStudent.bd.Enabled = True
                My.Forms.ViewStudent.gl.Enabled = True
                My.Forms.ViewStudent.con.Enabled = True
                My.Forms.ViewStudent.sy.Enabled = True

                My.Forms.ViewStudent.ag.Enabled = True
                My.Forms.ViewStudent.sn.Enabled = False
                My.Forms.ViewStudent.SearchStudent_btn.Enabled = False
                My.Forms.ViewStudent.PictureBox2.Image = base64toimage(pic)
                pic = ""

                NSO2 = r("NSO").ToString()
                If NSO2 = "No" Then
                    My.Forms.ViewStudent.nso_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent.nso_lbl.BackColor = Color.Green
                End If


                baptis = r("Baptismal").ToString()
                If baptis = "No" Then
                    My.Forms.ViewStudent.baptismal_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent.baptismal_lbl.BackColor = Color.Green
                End If

                card = r("UploadCard").ToString()
                If card = "No" Then
                    My.Forms.ViewStudent.card_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent.card_lbl.BackColor = Color.Green
                End If

                form137 = r("UploadForm137").ToString()
                If form137 = "No" Then
                    My.Forms.ViewStudent.form_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent.form_lbl.BackColor = Color.Green
                End If

                goodMoral = r("UploadGoodMoral").ToString()
                If goodMoral = "No" Then
                    My.Forms.ViewStudent.gm_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent.gm_lbl.BackColor = Color.Green
                End If

                My.Forms.ViewStudent.GroupBox1.Enabled = True
                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.ViewStudent.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub

    Public Sub SearchStudent_R_ViewStudent_btn()
        Dim conn As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.ViewStudent_R.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.ViewStudent_R.sn.Text = r("Student_ID_No").ToString()
                My.Forms.ViewStudent_R.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.ViewStudent_R.add.Text = r("Address").ToString()
                My.Forms.ViewStudent_R.bd.Text = r("Birthday").ToString()
                My.Forms.ViewStudent_R.gl.Text = r("GradeLevel").ToString()
                My.Forms.ViewStudent_R.con.Text = r("Contact").ToString()
                My.Forms.ViewStudent_R.sy.Text = r("SchoolYear").ToString()
                pic = r("Photo").ToString()
                My.Forms.ViewStudent_R.ag.Text = r("Age").ToString()
                pic = r("Photo").ToString()

                My.Forms.ViewStudent_R.add.Enabled = True
                My.Forms.ViewStudent_R.bd.Enabled = True
                My.Forms.ViewStudent_R.gl.Enabled = True
                My.Forms.ViewStudent_R.con.Enabled = True
                My.Forms.ViewStudent_R.sy.Enabled = True

                My.Forms.ViewStudent_R.ag.Enabled = True
                My.Forms.ViewStudent_R.sn.Enabled = False
                My.Forms.ViewStudent_R.SearchStudent_btn.Enabled = False
                My.Forms.ViewStudent_R.PictureBox2.Image = base64toimage(pic)
                pic = ""

                NSO2 = r("NSO").ToString()
                If NSO2 = "No" Then
                    My.Forms.ViewStudent_R.nso_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent_R.nso_lbl.BackColor = Color.Green
                End If


                baptis = r("Baptismal").ToString()
                If baptis = "No" Then
                    My.Forms.ViewStudent_R.baptismal_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent_R.baptismal_lbl.BackColor = Color.Green
                End If

                card = r("UploadCard").ToString()
                If card = "No" Then
                    My.Forms.ViewStudent_R.card_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent_R.card_lbl.BackColor = Color.Green
                End If

                form137 = r("UploadForm137").ToString()
                If form137 = "No" Then
                    My.Forms.ViewStudent_R.form_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent_R.form_lbl.BackColor = Color.Green
                End If

                goodMoral = r("UploadGoodMoral").ToString()
                If goodMoral = "No" Then
                    My.Forms.ViewStudent_R.gm_lbl.BackColor = Color.Red
                Else
                    My.Forms.ViewStudent_R.gm_lbl.BackColor = Color.Green
                End If

                My.Forms.ViewStudent_R.GroupBox1.Enabled = True
                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.ViewStudent_R.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub SearchStudent_C_ViewStudent_btn()
        'not implemented
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.ViewStud_C.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.ViewStud_C.sn.Text = r("Student_ID_No").ToString()
                My.Forms.ViewStud_C.nam.Text = r("LastName").ToString() & ", " & r("GivenName").ToString() & " " & r("MiddleName").ToString() & "."
                My.Forms.ViewStud_C.add.Text = r("Address").ToString()
                My.Forms.ViewStud_C.bd.Text = r("Birthday").ToString()
                My.Forms.ViewStud_C.gl.Text = r("GradeLevel").ToString()
                My.Forms.ViewStud_C.con.Text = r("Contact").ToString()
                My.Forms.ViewStud_C.sy.Text = r("SchoolYear").ToString()
                pic = r("Photo").ToString()
                My.Forms.ViewStud_C.ag.Text = r("Age").ToString()
                My.Forms.ViewStud_C.PictureBox2.Image = base64toimage(pic)
                pic = ""
                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.ViewStud_C.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub sn_check()
        Dim conn As New MySqlConnection ' <--
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info_archive WHERE (Student_ID_No ='" & My.Forms.StudentCreate.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                StudentNo = r("Student_ID_No").ToString()

                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()


    End Sub

    'guys, kapag may question kayo, chat lang kayo dun sa chat box, pag hindi ako available, sasagot naman si tolits.
    'pag urgent, you can reach me at my mobile number. okay?
    'God bless us!
End Module