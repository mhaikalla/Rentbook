Imports System.Data.OleDb
Public Class UC_Peminjaman
    Dim kueri, nama, KDAnggota, KDpinjam, KDBuku, kondisi, JumlahBuku As String
    Public tgl_pinjam, tgl_kembali As Date
    Private Sub UC_Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            resetall()
        End If
    End Sub

    Sub resetall()
        Me.Controls.Clear()
        Me.InitializeComponent()
        TampilkanAnggota()
        SetHintText(tb_Search, "Cari Data Anggota")
        ComboBox1.SelectedIndex = 0
        Label1.Text = Nothing

        UC_Peminjaman_Resize(Me, New EventArgs)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.Visible = True
        Panel5.Visible = True
        tb_Cari.Visible = False
        Label2.ForeColor = System.Drawing.Color.Black
        Label3.ForeColor = System.Drawing.Color.DodgerBlue
        tampilkanBuku()

        IsiKodeOtomatis()

        Label18.Text = nama
        Label17.Text = "Kode Anggota : " + KDAnggota
        Label13.Text = "Tanggal Pinjam : " + Format(Today, "dd MMMM yyyy")
        Label16.Text = "Batas Waktu Pinjam : " & Format(DateAdd(DateInterval.Day, Batas_Waktu, Today), "dd MMMM yyyy") + " (" & Batas_Waktu & " Hari)"
        tgl_pinjam = Format(Today, "dd MMMM yyyy")
        tgl_kembali = Format(DateAdd(DateInterval.Day, Batas_Waktu, Today), "dd MMMM yyyy")

        With DataGridView4
            .Columns.Add("Kode_Buku", "Kode Buku")
            .Columns.Add("Judul", "Judul")
            .Columns.Add("Pengarang", "Pengarang")
        End With
        tampilkanPeminjaman()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView4.RowCount() >= 1 Then
            Dim c = MsgBox("Transaksi peminjaman sedang berlangsung ingin dibatalkan?", vbQuestion + vbYesNo, "Transaksi Peminjaman")
            If c = DialogResult.No Then
                Exit Sub
            End If
        End If
        Button6.Visible = False
        Panel5.Visible = False
        tb_Cari.Visible = True
        Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Label3.ForeColor = System.Drawing.Color.Black
        DataGridView4.Rows.Clear()
        DataGridView4.Columns.Clear()
        PictureBox1.Image = My.Resources.Image
        Label22.Visible = False
    End Sub

    Private Sub UC_Peminjaman_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel4.Left = (Me.ClientRectangle.Width / 2) - (Panel4.Width / 2)
        Panel5.Left = (Me.ClientRectangle.Width / 2) - (Panel5.Width / 2)
        tb_Cari.Left = (Me.ClientRectangle.Width / 2) - (tb_Cari.Width / 2)
    End Sub

    Public Sub tampilkanPeminjaman()

        kueri = "Select Pinjam.KD_Pinjam, Pinjam.KD_Buku, Buku.Judul, Buku.Pengarang, pinjam.Tgl_Pinjam, pinjam.Tgl_Kembali from Pinjam, buku where pinjam.KD_Buku = Buku.KD_Buku and kd_anggota='" & KDAnggota & "'"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView2.DataSource = (ds.Tables(0))
        DataGridView2.ReadOnly = True

        If DataGridView2.RowCount() <= 0 Then
            Label15.Text = "Belum ada buku yang dipinjam (Maksimal pinjam " & Maks_Buku & " buku )"
            Label1.Text = "Tidak ada buku yang dipinjam"
        Else
            JumlahBuku = DataGridView2.RowCount()
            Label15.Text = "Sedang Meminjam " & JumlahBuku & " buku (Maksimal pinjam " & Maks_Buku & " buku )"
            Label1.Text = "Sedang meminjam " & JumlahBuku & " buku"
        End If
    End Sub

    Public Sub TampilkanAnggota(Optional ByRef condition As String = Nothing)
        If condition <> Nothing Then
            kueri = "select * from anggota where " & condition & " "
        ElseIf condition = Nothing Then
            kueri = "select * from anggota"
        End If

        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True
    End Sub
    Public Sub SimpanPeminjaman()

        Console.WriteLine(vbCrLf & "================================")
        For i As Integer = 0 To DataGridView4.RowCount - 1
            kueri = "Insert into pinjam values ('" & KDpinjam & "', '" & KDAnggota & "','" & DataGridView4.Rows(i).Cells(0).Value & "', '" & tgl_pinjam & "', '" & tgl_kembali & "')"
            Console.WriteLine(vbCrLf & "Input Pinjam : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()

            kueri = "Insert into HistoriPinjam values ('" & Format(Now, "dd MMMM yyyy") & "', '" & Format(TimeOfDay, "HH:mm") & "','" & Username & "','" & KDpinjam & "', '" & KDAnggota & "','" & KDBuku & "','" & tgl_kembali & "')"
            Console.WriteLine(vbCrLf & "Input Pinjam : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
        Next
        Label3.ForeColor = System.Drawing.Color.Black
        Label4.ForeColor = System.Drawing.Color.DodgerBlue
        tampilkanPeminjaman()
    End Sub

    Public Sub tampilkanBuku()

        kueri = "Select * from Buku order by Judul asc"
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView3.DataSource = (ds.Tables(0))
        DataGridView3.ReadOnly = True
    End Sub
    Public Sub IsiKodeOtomatis()

        cmd = New OleDbCommand("select KD_pinjam from pinjam order by KD_pinjam desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            KDpinjam = "PJ" + Format(Today, "yyMMdd") + "001"
            Label14.Text = "ID Pinjam : " + KDpinjam
        Else
            If Microsoft.VisualBasic.Mid(dr.Item("KD_pinjam"), 3, 6) = Format(Today, "yyMMdd") Then
                KDpinjam = "PJ" + Format(Microsoft.VisualBasic.Right(dr.Item("KD_pinjam"), 9) + 1, "000")
                Label14.Text = "ID Pinjam : " + KDpinjam
            Else
                KDpinjam = "PJ" + Format(Today, "yyMMdd") + "001"
                Label14.Text = "ID Pinjam : " + KDpinjam
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView4.RowCount <= 1 Then
            Button2.Enabled = False
            Button1.Enabled = False
        End If
        DataGridView4.Rows.Remove(DataGridView4.CurrentRow)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For a As Integer = 0 To DataGridView4.RowCount - 1
            If DataGridView3.CurrentRow.Cells(0).Value = DataGridView4.Rows(a).Cells(0).Value Then
                MsgBox("Buku sudah masuk ke list peminjaman")
                Exit Sub
            End If
        Next
        For a As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView3.CurrentRow.Cells(0).Value = DataGridView2.Rows(a).Cells(2).Value Then
                MsgBox("Buku ini sedang dipinjam oleh anggota ini", vbCritical, "Peminjaman")
                Exit Sub
            End If
        Next

        If (DataGridView4.RowCount + DataGridView2.RowCount) >= Maks_Buku Then
            MsgBox("Batas maksimal pinjaman buku per anggota cuman " & Maks_Buku, MsgBoxStyle.Critical, "Peminjaman")
            Exit Sub
        End If
        KDBuku = DataGridView3.CurrentRow.Cells(0).Value
        DataGridView4.Rows.Add(DataGridView3.CurrentRow.Cells(0).Value, DataGridView3.CurrentRow.Cells(1).Value, DataGridView3.CurrentRow.Cells(2).Value)
        Button2.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        resetall()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Semua" Then
            kondisi = "Kd_Anggota like '%" & tb_Search.Text & "%' or Nama_Anggota like '%" & tb_Search.Text & "%' or Notelp like '%" & tb_Search.Text & "%' or Email like '%" & tb_Search.Text & "%' or Alamat like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Kode Anggota" Then
            kondisi = "Kd_Anggota like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Nama Anggota" Then
            kondisi = "Nama_Anggota like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Email" Then
            kondisi = "Email like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Alamat" Then
            kondisi = "Alamat like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "No Telepon" Then
            kondisi = "Email like '%" & tb_Search.Text & "%'"
        End If
        TampilkanAnggota(kondisi)
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If ComboBox1.SelectedItem = "Semua" Then
            kondisi = "Kd_Anggota like '%" & tb_Search.Text & "%' or Nama_Anggota like '%" & tb_Search.Text & "%' or Notelp like '%" & tb_Search.Text & "%' or Email like '%" & tb_Search.Text & "%' or Alamat like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Kode Anggota" Then
            kondisi = "Kd_Anggota like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Nama Anggota" Then
            kondisi = "Nama_Anggota like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Email" Then
            kondisi = "Email like '%" & tb_Search.Text & "%'"

        ElseIf ComboBox1.SelectedItem = "Alamat" Then
            kondisi = "Alamat like '%" & tb_Search.Text & "%'"
        ElseIf ComboBox1.SelectedItem = "No Telepon" Then
            kondisi = "Email like '%" & tb_Search.Text & "%'"
        End If
        TampilkanAnggota(kondisi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = False
        Button1.Enabled = False
        DataGridView4.Rows.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SimpanPeminjaman()
        Label25.Text = nama
        Label6.Text = "Kode Anggota : " & KDAnggota
        Label10.Text = "Kode Pinjam : " & KDpinjam
        Label5.Text = "Tanggal Pinjam : " & tgl_pinjam
        Label8.Text = "Tanggal Kembali : " & tgl_kembali
        Label7.Text = "Meminjam " & DataGridView2.RowCount() & " Buku"
        Panel1.Visible = True
        Panel5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        KDAnggota = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Lbl_Kode.Text = "Kode Anggota : " + KDAnggota

        nama = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Lbl_Nama.Text = nama

        Lbl_Jk.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Lbl_Notelp.Text = "No Telepon  : " + DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Lbl_Email.Text = "Email             : " + DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Lbl_Alamat.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        tampilkanPeminjaman()
        Button7.Visible = True
    End Sub

    Private Sub UC_Peminjaman_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.DesignMode Then
            If Me.Visible = True Then
                tampilkanBuku()
                TampilkanAnggota()
            End If
        End If
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        If DataGridView3.Rows(e.RowIndex).Cells(9).Value = Nothing Then
            PictureBox1.Image = My.Resources.Image
            Label22.Visible = True
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        Else
            PictureBox1.Load(DataGridView3.Rows(e.RowIndex).Cells(9).Value)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Label22.Visible = False
        End If

    End Sub
End Class
