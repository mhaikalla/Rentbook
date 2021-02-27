Imports System.Data.OleDb
Public Class UC_Pengembalian
    Dim kueri As String _
    , i As Integer = 0 _
    , denda(Maks_Buku - 1) As Integer _
    , total As Integer = 0 _
    , kembali As Integer = 0 _
    , selisihhari As String _
    , dendaCas As Integer = 0 _
    , kode As String
    Private Sub UC_Pengembalian_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            resetall()
        End If
    End Sub
    Private Sub UC_Pengembalian_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Not Me.DesignMode Then
                tampilkanpeminjaman()
            End If
        End If
    End Sub
    Sub resetall()
        tampilkanpeminjaman()

        SetHintText(tb_Cari, "Cari Data Peminjaman")
        Label3.Text = "Kode Pengembalian : " & IsiKodeOtomatis()
        Label2.Text = "Kode Peminjaman : -"
        Label1.Text = "Tanggal Peminjaman : -"
        Label8.Text = "Tanggal Pengembalian : -"
        Label5.Text = "Kode Anggota : -"
        Label7.Text = "Nama : -"
        ComboBox1.SelectedIndex = 0
        Panel1.Left = (Me.ClientRectangle.Width / 2) - (Panel1.Width / 2)

        DataGridView1.Enabled = True
        tb_Cari.Text = Nothing
        Button4.Enabled = False
        Button5.Enabled = False
        rb_Aman.Checked = True
        If DataGridView2.RowCount < 0 Then
            DataGridView2.Rows.Clear()
        End If
        GroupBox2.Enabled = False
        GroupBox1.Enabled = False
        Label10.Text = "Rp. 0"
        tb_Bayar.Text = "0"
        Label12.Text = "Kembali : Rp."
        Label13.Text = "Denda Telat belum diketahui"
    End Sub


    Private Sub UC_Pengembalian_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.ClientRectangle.Width / 2) - (Panel1.Width / 2)
    End Sub

    Public Sub tampilkanpeminjaman()

        kueri = "select distinct pinjam.KD_Pinjam ,pinjam.kd_anggota, anggota.Nama_anggota, pinjam.tgl_pinjam, pinjam.Tgl_Kembali from pinjam, anggota where pinjam.KD_Anggota = anggota.KD_Anggota"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
    End Sub
    Sub simpanPengembalian()

        Dim status As String
        For i As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView2.CurrentRow.Cells(3).Value Like "Ya" And DataGridView2.CurrentRow.Cells(4).Value Like "Tidak" Then
                status = "Rusak"
            ElseIf DataGridView2.CurrentRow.Cells(3).Value Like "Tidak" And DataGridView2.CurrentRow.Cells(4).Value Like "Ya" Then
                status = "Hilang"
            Else
                status = "Aman"
            End If
            kueri = "Insert into kembali values ('" & IsiKodeOtomatis() & "','" & DataGridView1.CurrentRow.Cells(0).Value & "', '" & DataGridView1.CurrentRow.Cells(1).Value & "','" & DataGridView2.Rows(i).Cells(0).Value & "', '" & DataGridView1.CurrentRow.Cells(4).Value & "', '" & DataGridView1.CurrentRow.Cells(4).Value & "','" & status & "','" & total & "')"
            Console.WriteLine(vbCrLf & "Input Pinjam : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()

        Next

        kueri = "delete from pinjam where KD_pinjam = '" + DataGridView1.CurrentRow.Cells(0).Value + "'"
        Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()

        setNotification("Buku yang dikembalikan sudah disimpan", My.Resources.Checklist)
    End Sub
    Sub tampilkanGambarBuku()

        kueri = "select buku.Gambar from buku where KD_Buku = '" & DataGridView2.CurrentRow.Cells(0).Value & "'"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If dr.HasRows Then
                PictureBox1.Load(dr.Item("Gambar"))
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Label22.Visible = False
            ElseIf Not dr.HasRows Then
                PictureBox1.Image = My.Resources.Image
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                Label22.Visible = True
            End If
        Catch ex As Exception
            PictureBox1.Image = My.Resources.Image
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Label22.Visible = True
        End Try
    End Sub
    Sub tampilkanBuku()
        i = 0

        With DataGridView2
            kueri = "select distinct Buku.Kd_Buku, Buku.Judul, Buku.Pengarang from pinjam, buku where pinjam.KD_buku = Buku.KD_buku and (Pinjam.Kd_Anggota = '" & DataGridView1.CurrentRow.Cells(1).Value & "')"
            Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
            .Columns.Clear()
            da = New OleDb.OleDbDataAdapter(kueri, conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds)
            .DataSource = (ds.Tables(0))
            .Columns.Add("Column3", "Telat")
            .Columns.Add("Column3", "Rusak")
            .Columns.Add("Column3", "Hilang")
            While i < .RowCount()
                .Rows(i).Cells(3).Value = "Tidak"
                .Rows(i).Cells(4).Value = "Tidak"
                .Rows(i).Cells(5).Value = "Tidak"
                i += 1
            End While
        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        Label3.Text = "Kode Pengembalian : " & IsiKodeOtomatis()
        Label2.Text = "Kode Peminjaman : " & DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Label5.Text = "Kode Anggota : " & DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Label7.Text = "Nama : " & DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Label1.Text = "Tanggal Peminjaman : " & DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Label8.Text = "Tanggal Pengembalian : " & DataGridView1.Rows(e.RowIndex).Cells(4).Value
        tampilkanBuku()

        selisihhari = DateDiff(DateInterval.Day, DataGridView1.Rows(e.RowIndex).Cells(4).Value, Today())
        If selisihhari <= 0 Then
            Label13.Text = "Buku ini tidak dikenakan denda telat"
        ElseIf selisihhari > 0 Then
            Label13.Text = "Telat Mengembalikan " & selisihhari & " Hari"
        End If
        While i <= DataGridView2.RowCount
            denda(i) = 0
            i += 1
        End While
    End Sub

    Public Function IsiKodeOtomatis()

        cmd = New OleDbCommand("select Kd_Kembali from Kembali order by kd_kembali desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Return "K" & "00001"
        Else
            Return "K" & Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Kembali"), 4) + 1, "0000")

        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kembali = Val(tb_Bayar.Text) - total
        If kembali < 0 Then
            Label12.Text = "Uang nya masih kurang " & kembali
            Exit Sub
        ElseIf kembali > 0 Then
            Label12.Text = "Kembali : Rp. " & kembali
        ElseIf kembali = 0 Then
            Label12.Text = "Uang dibayar dengan pas"
        End If
        Button5.Enabled = True
        Button4.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim c = MsgBox("Proses pengembalian akan dibatalkan", vbYesNo + vbExclamation, "Ulang dari awal?")
        If c = vbYes Then
            resetall()
        End If
    End Sub

    Private Sub tb_Cari_TextChanged(sender As Object, e As EventArgs) Handles tb_Cari.TextChanged

        If ComboBox1.SelectedItem = "Nama Anggota" Then
            kueri = "Anggota.Nama_Anggota like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Kode Anggota" Then
            kueri = "pinjam.KD_Anggota like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Kode Pinjam" Then
            kueri = "pinjam.KD_pinjam like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Semua" Then
            kueri = "pinjam.KD_pinjam like '%" & tb_Cari.Text & "%' or pinjam.KD_Anggota like '%" & tb_Cari.Text & "%' or Anggota.Nama_Anggota like '%" & tb_Cari.Text & "%'"
        Else
        End If
        da = New OleDb.OleDbDataAdapter("select distinct pinjam.KD_Pinjam ,pinjam.kd_anggota, anggota.Nama_anggota, pinjam.tgl_pinjam, pinjam.Tgl_Kembali from pinjam, anggota where pinjam.KD_Anggota = anggota.KD_Anggota and (" & kueri & ")", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        tb_Cari_TextChanged(tb_Cari, New EventArgs)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        simpanPengembalian()
        tampilkanBuku()
        resetall()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = 0
        total = 0
        GroupBox2.Enabled = True
        DataGridView1.Enabled = False
        While i <= DataGridView2.RowCount() - 1
            If selisihhari > 0 Then
                dendaCas = (selisihhari * denda_telat)
                total = total + denda(i) + dendaCas
            Else
                total = total + denda(i)
            End If
            i = i + 1
        End While

        If total <= 0 Then
            Label10.Text = "Rp 0 "
            Button5.Enabled = True
            Button4.Enabled = True
        Else
            Label10.Text = "Rp " + Format(Val(total), "###,###")
        End If
    End Sub
    Private Sub rb_Hilang_Click(sender As Object, e As EventArgs) Handles rb_Hilang.Click
        denda(DataGridView2.CurrentCellAddress.Y) = 0
        DataGridView2.CurrentRow.Cells(4).Value = "Tidak"
        DataGridView2.CurrentRow.Cells(5).Value = "Iya"
        denda(DataGridView2.CurrentCellAddress.Y) = denda_hilang
    End Sub
    Private Sub rb_Rusak_Click(sender As Object, e As EventArgs) Handles rb_Rusak.Click
        denda(DataGridView2.CurrentCellAddress.Y) = 0
        DataGridView2.CurrentRow.Cells(4).Value = "Iya"
        DataGridView2.CurrentRow.Cells(5).Value = "Tidak"
        denda(DataGridView2.CurrentCellAddress.Y) = denda_rusak

    End Sub
    Private Sub rb_Aman_Click(sender As Object, e As EventArgs) Handles rb_Aman.Click
        denda(DataGridView2.CurrentCellAddress.Y) = 0
        DataGridView2.CurrentRow.Cells(4).Value = "Tidak"
        DataGridView2.CurrentRow.Cells(5).Value = "Tidak"

    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        tampilkanGambarBuku()
        GroupBox1.Enabled = True
        Label15.Text = "Buku ke-" & DataGridView2.CurrentCellAddress.Y
        If DataGridView2.CurrentRow.Cells(4).Value = "Iya" Then
            rb_Rusak.Checked = True
        ElseIf DataGridView2.CurrentRow.Cells(5).Value = "Iya" Then
            rb_Hilang.Checked = True
        Else
            rb_Aman.Checked = True
        End If
    End Sub


End Class
