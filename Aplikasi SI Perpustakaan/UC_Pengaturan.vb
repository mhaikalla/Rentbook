Imports System.Data.OleDb
Public Class UC_Pengaturan
    Sub UpdateData()

        Dim kueri = "Update Pengaturan set Denda_Telat = " & denda_telat & ", Denda_rusak = " & denda_rusak & ", Denda_Hilang =" & denda_hilang & ", Maks_Buku=" & Maks_Buku & ", Batas_Waktu=" & Batas_Waktu & " where id_pengaturan = 1"
        Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Pengaturan telah Disimpan")
    End Sub

    Private Sub UC_Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_DendaTelat.Text = denda_telat
        tb_DendaHilang.Text = denda_hilang
        tb_DendaRusak.Text = denda_telat
        ud_BatasWaktu.Value = Batas_Waktu
        ud_MaksBuku.Value = Maks_Buku
    End Sub

    Private Sub UC_Pengaturan_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        UpdateData()
    End Sub

    Private Sub tb_DendaHilang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_DendaHilang.KeyPress
        Dim tombol As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse tombol = Keys.Back) Then
            tombol = 0
        ElseIf (e.KeyChar Like "[A-Z, a-z]") Then
            e.Handled = CBool(tombol)
        End If
    End Sub

    Private Sub tb_DendaRusak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_DendaRusak.KeyPress
        Dim tombol As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse tombol = Keys.Back) Then
            tombol = 0
        ElseIf (e.KeyChar Like "[A-Z, a-z]") Then
            e.Handled = CBool(tombol)
        End If
    End Sub

    Private Sub tb_DendaTelat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_DendaTelat.KeyPress
        Dim tombol As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse tombol = Keys.Back) Then
            tombol = 0
        ElseIf (e.KeyChar Like "[A-Z, a-z]") Then
            e.Handled = CBool(tombol)
        End If
    End Sub

    Private Sub tb_DendaHilang_LostFocus(sender As Object, e As EventArgs) Handles tb_DendaHilang.LostFocus
        If Val(tb_DendaHilang.Text) < 100 Then
            tb_DendaHilang.Text = denda_hilang
        End If
    End Sub

    Private Sub tb_DendaRusak_LostFocus(sender As Object, e As EventArgs) Handles tb_DendaRusak.LostFocus
        If Val(tb_DendaRusak.Text) < 100 Then
            tb_DendaRusak.Text = denda_rusak
        End If
    End Sub

    Private Sub tb_DendaTelat_LostFocus(sender As Object, e As EventArgs) Handles tb_DendaTelat.LostFocus
        If Val(tb_DendaTelat.Text) < 100 Then
            tb_DendaTelat.Text = denda_telat
        End If
    End Sub

    Private Sub ud_BatasWaktu_LostFocus(sender As Object, e As EventArgs) Handles ud_BatasWaktu.LostFocus
        If ud_BatasWaktu.Value < 1 Then
            ud_BatasWaktu.Value = Batas_Waktu
        End If
    End Sub

    Private Sub ud_MaksBuku_LostFocus(sender As Object, e As EventArgs) Handles ud_MaksBuku.LostFocus
        If ud_MaksBuku.Value < 1 Then
            ud_MaksBuku.Value = Maks_Buku
        End If
    End Sub


End Class
