Imports System.Data.OleDb
Public Class LoginForm
    Dim loc As Point _
        , FormMove As Boolean = False _
        , Title_text As String _
        , kueri As String _
    , kode As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            SetHintText(UsernameTextBox, "Username")
            SetHintText(PasswordTextBox, "Password")
            connectnow()
        End If
    End Sub
    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            connectnow()
        End If
    End Sub
    Sub resetall()
        Me.Controls.Clear()
        Me.InitializeComponent()
        SetHintText(UsernameTextBox, "Username")
        SetHintText(PasswordTextBox, "Password")
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If UsernameTextBox.Text.Length <= 5 And UsernameTextBox.Text.Length <= 0 Then
            Label5.Visible = True
            Label5.Text = "Input username setidaknya ada 5 karakter"
            Exit Sub
        ElseIf UsernameTextBox.Text.Length <= 0 Then
            Label5.Visible = True
            Label5.Text = "Masukan username akun anda"
            Exit Sub
        Else
            Label5.Visible = False
        End If

        connectnow()
        cmd = New OleDbCommand("select * from Admin where Username='" & UsernameTextBox.Text & "'", conn)
        Console.WriteLine("select * from Admin where Username='" & UsernameTextBox.Text & "'")
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Nama_Akun = dr.Item("Nama")
            hakakses = dr.Item("Hak_Akses")

            Label_Nama.Text = Nama_Akun
            Label_Hakakses.Text = hakakses

            Label5.Visible = False
            PasswordTextBox.ResetText()
            PasswordTextBox.Select()
            Panel3.BringToFront()
        Else
            Label5.Visible = True
            Label5.Text = "Username ini tidak terdaftar di database"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PasswordTextBox.Text.Length <= 5 And PasswordTextBox.Text.Length <= 0 Then
            Label1.Visible = True
            Label1.Text = "Input password minimal 8 karakter"
            Exit Sub

        ElseIf PasswordTextBox.Text.Length <= 0 Then
            Label1.Visible = True
            Label1.Text = "Masukan password dari username akun anda"
            Exit Sub
        Else
            Label1.Visible = False
        End If
        connectnow()
        cmd = New OleDbCommand("select * from Admin where Username='" & UsernameTextBox.Text & "' and Password='" & PasswordTextBox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Username = dr.Item("Username")
            password = dr.Item("Password")
            jns_kel = dr.Item("jns_kel")

            cmd = New OleDbCommand("select KD_Histori from HistoriAkun order by KD_Histori desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                kode = "H" + "00001"
            Else
                kode = "H" + Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Histori"), 4) + 1, "00000")
            End If

            kueri = "Insert into HistoriAkun values ('" & Format(Now, "dd MMMM yyyy, HH:mm") & "','" & Username & "','Telah Login', '" & kode & "')"
            Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()

            Label1.Visible = False
            Me.Hide()
            resetall()
            MainForm.Show()
        Else
            Label1.Visible = True
            Label1.Text = "Password Akun ini Tidak Benar"
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.BringToFront()
        Label1.Visible = False
    End Sub

    Private Sub LabelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelTitle.MouseDown
        Title_text = LabelTitle.Text
        LabelTitle.Text = "Klik tahan untuk drag dan drop halaman ini"
        LabelTitle.Font = New Font(LabelTitle.Font.Name, 9)
        If e.Button = MouseButtons.Left Then
            FormMove = True
            loc = e.Location
        End If
    End Sub

    Private Sub LabelTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelTitle.MouseUp
        LabelTitle.Text = Title_text
        LabelTitle.Font = New Font(LabelTitle.Font.Name, 12,
                LabelTitle.Font.Style)
        If FormMove = True Then
            FormMove = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LabelTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles LabelTitle.MouseMove
        If FormMove Then
            Me.Location = Me.Location + (e.Location - loc)
        End If
    End Sub


    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = Keys.Enter Then
            ButtonNext_Click(ButtonNext, New System.EventArgs)
            e.Handled = CBool(KeyAscii)
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = Keys.Enter Then
            Button3_Click(Button3, New System.EventArgs)
            e.Handled = CBool(KeyAscii)
        End If
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = Windows.Forms.FormWindowState.Minimized
    End Sub


End Class
