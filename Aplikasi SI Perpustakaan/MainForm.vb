Imports System.Data.OleDb
Public Class MainForm
    Dim Loc As Point
    Dim FormMove As Boolean = False,
        i As Integer = 1,
        kode As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Label_Nama.Text = Nama_Akun
            Label_HakAkses.Text = Hakakses
            Label_Username.Text = Username
            btn_Akun.Text = Nama_Akun
        End If
    End Sub
    Sub TipeLoginHakakses()
        If Hakakses Like "Admin" Then
            Button9.Visible = True
            UC_Petugas.Panel1.Visible = True
            UC_Petugas.Panel2.Visible = False
            UC_Petugas.Panel3.Visible = True
            UC_Petugas.Cb_Hakakses.Enabled = True

        ElseIf Hakakses Like "Petugas" Then
            Button9.Visible = False
            UC_Petugas.Panel1.Visible = False
            UC_Petugas.Panel2.Visible = True
            UC_Petugas.Panel3.Visible = False
            UC_Petugas.Cb_Hakakses.Enabled = False
        End If
    End Sub
    Sub resetUC()
        UC_Anggota.Hide()
        UC_Buku.Hide()
        UC_Peminjaman.Hide()
        UC_Pengembalian.Hide()
        UC_Pengaturan.Hide()
        UC_Dashboard.Hide()
        UC_Petugas.Hide()
        UC_History.Hide()
    End Sub

    Sub resetSubMenu()
        panel_Dashboard.Visible = False
        Panel_History.Visible = False
        panel_Master.Visible = False
        Panel_Transaction.Visible = False
        Panel_Pengaturan.Visible = False
    End Sub
    Sub resetform()
        resetSubMenu()
        resetUC()
        panel_Dashboard.Visible = True
        UC_Dashboard.Visible = True
        Label_Judul.Text = "Dashboard"
        TipeLoginHakakses()
    End Sub
    Public Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        resetUC()
        UC_Anggota.Visible = True
        Label_Judul.Text = "Anggota"
    End Sub

    Public Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        resetUC()
        UC_Buku.Visible = True
        Label_Judul.Text = "Buku"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        resetUC()
        UC_Peminjaman.Visible = True
        Label_Judul.Text = "Peminjaman"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        resetUC()
        UC_Pengembalian.Visible = True
        Label_Judul.Text = "Pengembalian"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resetUC()
        UC_Dashboard.Visible = True
        resetSubMenu()
        panel_Dashboard.Visible = True
        Label_Judul.Text = "Dashboard"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resetSubMenu()
        panel_Master.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetSubMenu()
        Panel_Transaction.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        resetUC()
        UC_Petugas.Visible = True
        Label_Judul.Text = "Petugas"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label_Judul.Text = "History"
        resetSubMenu()
        resetUC()
        Panel_History.Visible = True
        UC_History.Show()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        UC_History.btn_Peminjaman_Click(UC_History.btn_Peminjaman, New EventArgs)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        UC_History.btn_Pengembalian_Click(UC_History.btn_Pengembalian, New EventArgs)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        UC_History.btn_Login_Click(UC_History.btn_Login, New EventArgs)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If panel_Menu.Size.Width = panel_Menu.MaximumSize.Width Then
            panel_Menu.Width = panel_Menu.MinimumSize.Width
        ElseIf panel_Menu.Size.Width = panel_Menu.MinimumSize.Width Then
            panel_Menu.Width = panel_Menu.MaximumSize.Width
        End If
    End Sub

    Private Sub btn_Akun_Click(sender As Object, e As EventArgs) Handles btn_Akun.Click
        If Panel_Akun.Visible = True Then
            Panel_Akun.Visible = False
        Else
            Panel_Akun.Visible = True
        End If
    End Sub
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Dim c = MsgBox("Logout akun membuat semua proses yang belum disimpan akan hilang", vbQuestion + vbYesNo, "Konfirmasi Logout Akun")
        If c = DialogResult.Yes Then
            cmd = New OleDbCommand("select KD_Histori from HistoriAkun order by KD_Histori desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                kode = "H" + "00001"
            Else
                kode = "H" + Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Histori"), 4) + 1, "00000")
            End If

            Dim kueri = "Insert into HistoriAKun values ('" & Format(Now, "dd MMMM yyyy, HH:mm") & "', '" & Username & "','Sudah Logout Akun','" & kode & "')"
            Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            LoginForm.Show()
            Me.Close()
        Else
            Panel_Akun.Hide()
            btn_Akun.BackColor = System.Drawing.Color.White
            btn_Akun.ForeColor = System.Drawing.Color.Black
            Exit Sub
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Dim c = MsgBox("Akun akan di logout secara otomatis, ingin keluar?", vbQuestion + vbYesNo, "Keluar dari Aplikasi")
        If c = DialogResult.Yes Then
            cmd = New OleDbCommand("select KD_Histori from HistoriAkun order by KD_Histori desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                kode = "H" + "00001"
            Else
                kode = "H" + Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Histori"), 4) + 1, "00000")
            End If

            Dim kueri = "Insert into HistoriAkun values ('" & Format(Now, "dd MMMM yyyy, HH:mm") & "', '" & Username & "','Sudah Logout Akun','" & kode & "')"
            Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            End
        Else
            Panel_Akun.Hide()
            btn_Akun.BackColor = System.Drawing.Color.White
            btn_Akun.ForeColor = System.Drawing.Color.Black
            Exit Sub
        End If
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        If FormMove Then
            Me.Location = Me.Location + (e.Location - Loc)
        End If
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseUp
        If FormMove = True Then
            FormMove = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Btn_Pengaturan_Click(sender As Object, e As EventArgs) Handles Btn_Pengaturan.Click
        resetUC()
        resetSubMenu()
        UC_Pengaturan.Visible = True
        Panel_Pengaturan.Visible = True
        Label_Judul.Text = "Pengaturan"
    End Sub

    Private Sub btn_EditAkun_Click(sender As Object, e As EventArgs) Handles btn_EditAkun.Click
        UC_Petugas.Button4_Click(UC_Petugas.Button4, New EventArgs)
        Button9_Click(Button9, New EventArgs)
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        If e.Button = MouseButtons.Left Then
            Panel_Akun.Visible = False
            FormMove = True
            Loc = e.Location
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i > 3 Then
            Panel_Notif.Visible = False
            i = 1
            Timer1.Stop()
            Exit Sub
        End If
        Console.WriteLine(i & vbCrLf)
        i = i + 1
    End Sub

End Class