Imports System.Data.OleDb

Public Class UC_History
    Dim CariTabel, kueri As String

    Private Sub UC_History_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.DesignMode Then
            If Me.Visible = True Then
                reset()
            End If
        End If
    End Sub

    Public Sub btn_Pengembalian_Click(sender As Object, e As EventArgs) Handles btn_Pengembalian.Click
        Panel1.Left = 312
        CariTabel = "Pengembalian"
        If tb_Search.TextLength > 0 Then
            tb_Search_TextChanged(tb_Search, New EventArgs)
            Exit Sub
        End If

        kueri = "Select kembali.Tgl_Kembali, Kembali.KD_Kembali, Kembali.Kd_Pinjam, Anggota.Nama_Anggota, Buku.Judul, Kembali.Tgl_Pinjam, Kembali.status, Kembali.denda from kembali, Anggota, Buku where kembali.KD_Anggota = Anggota.KD_Anggota and Kembali.KD_Buku = Buku.KD_Buku order by kembali.Tgl_Kembali desc"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True

        If DataGridView1.RowCount = 0 Then
            Btn_Hapus.Enabled = False
        ElseIf DataGridView1.RowCount > 0 Then
            Btn_Hapus.Enabled = True
        End If
    End Sub

    Public Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Panel1.Left = 534
        CariTabel = "Akun"
        If tb_Search.TextLength > 0 Then
            tb_Search_TextChanged(tb_Search, New EventArgs)
            Exit Sub
        End If

        kueri = "Select Username, Keterangan, Tgl_Sekarang, Kd_Histori from HistoriAkun order by tgl_sekarang desc"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True

        If DataGridView1.RowCount = 0 Then
            Btn_Hapus.Enabled = False
        ElseIf DataGridView1.RowCount > 0 Then
            Btn_Hapus.Enabled = True
        End If
    End Sub

    Public Sub btn_Peminjaman_Click(sender As Object, e As EventArgs) Handles btn_Peminjaman.Click
        Panel1.Left = 94
        CariTabel = "Peminjaman"
        If tb_Search.TextLength > 0 Then
            tb_Search_TextChanged(tb_Search, New EventArgs)
            Exit Sub
        End If

        kueri = "Select HistoriPinjam.Tgl_Pinjam, HistoriPinjam.KD_pinjam, Anggota.KD_Anggota, Anggota.Nama_Anggota,Buku.KD_Buku ,Buku.Judul, Buku.Pengarang from HistoriPinjam, Anggota, Buku where Buku.KD_Buku = HistoriPinjam.KD_Buku and Anggota.KD_Anggota = HistoriPinjam.KD_Anggota order by HistoriPinjam.Tgl_Pinjam desc"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True

        If DataGridView1.RowCount = 0 Then
            Btn_Hapus.Enabled = False
        ElseIf DataGridView1.RowCount > 0 Then
            Btn_Hapus.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        tb_Search.ResetText()
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If CariTabel = "Akun" Then
            kueri = "Tgl_Sekarang like '%" & tb_Search.Text & "%' or Username like '%" & tb_Search.Text & "%' or Keterangan like '%" & tb_Search.Text & "%'"
            kueri = "Select Tgl_Sekarang, Username, Keterangan, Kd_Histori from HistoriAkun where " + kueri + " order by Tgl_Sekarang desc"
        ElseIf CariTabel = "Peminjaman" Then
            kueri = "HistoriPinjam.KD_Pinjam like '%" & tb_Search.Text & "%' or Anggota.Nama_Anggota like '%" & tb_Search.Text & "%' or Buku.Judul like '%" & tb_Search.Text & "%' or HistoriPinjam.tgl_Pinjam like '%" & tb_Search.Text & "%'"
            kueri = "Select HistoriPinjam.Tgl_Pinjam, HistoriPinjam.KD_pinjam, Anggota.KD_Anggota, Anggota.Nama_Anggota,Buku.KD_Buku ,Buku.Judul, Buku.Pengarang from HistoriPinjam, Anggota, Buku where Buku.KD_Buku = HistoriPinjam.KD_Buku and Anggota.KD_Anggota = HistoriPinjam.KD_Anggota and (" + kueri + ") order by HistoriPinjam.Tgl_Pinjam desc"
        ElseIf CariTabel = "Pengembalian" Then
            kueri = "Kembali.tgl_Sekarang like '%" & tb_Search.Text & "%' or Anggota.Nama_Anggota like '%" & tb_Search.Text & "%' or Buku.Judul like '%" & tb_Search.Text & "'% Kembali.status like '%" & tb_Search.Text & "%' or kembali.denda like '%" & tb_Search.Text & "%'"
            kueri = "Select kembali.Tgl_Sekarang, Kembali.KD_Kembali, Kembali.Kd_Pinjam, Anggota.Nama_Anggota, Buku.Judul, Kembali.Tgl_Pinjam, Kembali.Tgl_Kembali, Kembali.status, Kembali.denda from kembali, Anggota, Buku where kembali.KD_Anggota = Anggota.KD_Anggota and Kembali.KD_Buku = Buku.KD_Buku and ( " + kueri + " ) order by tgl_sekarang desc"
        End If

        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Btn_Hapus_Click(sender As Object, e As EventArgs) Handles Btn_Hapus.Click

        If CariTabel = "Akun" Then
            kueri = "delete from HistoriAkun where KD_Histori = '" + DataGridView1.CurrentRow.Cells(3).Value + "'"
            Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            btn_Login_Click(btn_Login, New EventArgs)

        ElseIf CariTabel = "Peminjaman" Then
            kueri = "delete from HistoriPinjam where KD_Histori = '" + DataGridView1.CurrentRow.Cells(7).Value + "'"
            Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            btn_Peminjaman_Click(btn_Peminjaman, New EventArgs)

        ElseIf CariTabel = "Pengembalian" Then
            kueri = "delete from kembali where KD_Kembali = '" + DataGridView1.CurrentRow.Cells(1).Value + "'"
            Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            btn_Pengembalian_Click(btn_Pengembalian, New EventArgs)
        End If

        If DataGridView1.RowCount = 0 Then
            Btn_Hapus.Enabled = False
        ElseIf DataGridView1.RowCount > 0 Then
            Btn_Hapus.Enabled = True
        End If
    End Sub

    Private Sub reset()
        If DataGridView1.RowCount = 0 Then
            Btn_Hapus.Enabled = False
        ElseIf DataGridView1.RowCount > 0 Then
            Btn_Hapus.Enabled = True
        End If
        btn_Pengembalian_Click(btn_Pengembalian, New EventArgs)
        Button1_Click(Button1, New EventArgs)
    End Sub
    Private Sub tb_Search_Click(sender As Object, e As EventArgs) Handles tb_Search.Click
        Button1.Visible = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Btn_Hapus.Enabled = True
    End Sub
End Class
