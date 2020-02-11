Imports System.Data.OleDb

Public Class UC_Buku
    Dim KDBuku, judul, tahun, penerbit, pengarang, kategori, stok, harga, gambar As String
    Dim tglmasuk As String = Today
    Dim kondisi, kueri As String
    Dim isUpdate As Boolean

    Private Sub UC_Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            tampilkandata()
            SetHintText(tb_Cari, "Cari Judul, Pengarang, Penerbit dan lainnya")
        End If
    End Sub

    Private Sub UC_Buku_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Not Me.DesignMode Then
                tampilkandata()
            End If
        End If
    End Sub
    Sub editdata()
        isUpdate = True
        btn_Hapus.Visible = True
        Btn_Simpan.Text = "Perbarui Data"
        Panel2.Visible = True
        Label9.Text = "Edit Data Buku " + tb_Judul.Text
        Label11.Visible = False
        Btn_Simpan.Enabled = True
        Button4.Visible = False
        ComboBox3.Enabled = False
    End Sub
    Sub Databaru()
        reset()
        IsiKodeOtomatis()
        RadioButton1.Checked = True
        isUpdate = False
        btn_Hapus.Visible = False
        Btn_Simpan.Text = "Simpan"
        Panel2.Visible = True
        Label9.Text = "Input Data Baru"
        Label11.Visible = True
    End Sub
    Public Sub reset()
        Dim c As Control
        For Each c In Me.Panel2.Controls
            If TypeOf c Is TextBox Then
                c.ResetText()
            End If
        Next c
        up_Stok.Value = 0
        tb_Kategori.SelectedIndex = 0

        tb_gambar.Text() = Nothing
        PictureBox1.Image = My.Resources.Image
        Label15.Visible = True
        Label15.Text = "Gambar belum diinput"
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Public Sub resetall()
        reset()
        ds.Clear()
        DataGridView1.Enabled = False
        tampilkandata()
    End Sub
    Private Sub isicomboboxKategori()
        Dim kueri = "select Nama_Kategori from Kategori order by Nama_Kategori asc"
        Console.WriteLine(kueri)
        cmd = New OleDbCommand(kueri, conn)
        dr = cmd.ExecuteReader
        tb_Kategori.Items.Clear()
        tb_Kategori.Items.Add("Pilih Kategori")
        While dr.Read
            tb_Kategori.Items.Add(dr("Nama_Kategori"))
        End While
    End Sub
    Public Sub IsiKodeOtomatis()
        cmd = New OleDbCommand("select kd_buku from buku", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            tb_Kode.Text = "B" + "0001"
        Else
            tb_Kode.Text = "B" + Format(Microsoft.VisualBasic.Right(dr.Item("kd_buku"), 4) + 1, "0000")
        End If
        tb_Kode.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Visible = True
        Btn_Tambah.Visible = True
        ComboBox3.Visible = False
        tb_Cari.ResetText()
        Button4.Visible = False
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles tb_Cari.GotFocus
        Panel2.Visible = False
        Btn_Tambah.Visible = False
        ComboBox3.Visible = True
        Button4.Visible = True
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_Cari.TextChanged
        If ComboBox3.SelectedItem Like "Semua Pencarian" Then
            kondisi = "Kd_Buku Like '%" & tb_Cari.Text & "%' or Judul Like '%" & tb_Cari.Text & "%' or Pengarang Like '%" & tb_Cari.Text & "%' or Penerbit Like '%" & tb_Cari.Text & "%' or Tahun Like '%" & tb_Cari.Text & "%' or Kategori Like '%" & tb_Cari.Text & "%' or Stok Like '%" & tb_Cari.Text & "%' or Tgl_Masuk Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Kode Anggota" Then
            kondisi = "Kd_Buku Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Judul" Then
            kondisi = "Judul Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Pengarang" Then
            kondisi = "Pengarang Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Penerbit" Then
            kondisi = "Penerbit Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Tahun" Then
            kondisi = "Tahun Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Kategori" Then
            kondisi = "Kategori Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Harga" Then
            kondisi = "Harga Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Stok" Then
            kondisi = "Stok Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "tanggal Masuk" Then
            kondisi = "Stok Like '%" & tb_Cari.Text & "%'"
        End If
        tampilkandata(kondisi)
    End Sub
    Private Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox3.SelectionChangeCommitted
        If ComboBox3.SelectedItem Like "Semua Pencarian" Then
            kondisi = "Kd_Buku Like '%" & tb_Cari.Text & "%' or Judul Like '%" & tb_Cari.Text & "%' or Pengarang Like '%" & tb_Cari.Text & "%' or Penerbit Like '%" & tb_Cari.Text & "%' or Tahun Like '%" & tb_Cari.Text & "%' or Kategori Like '%" & tb_Cari.Text & "%' or Harga Like '%" & tb_Cari.Text & "%' or Stok Like '%" & tb_Cari.Text & "%' or tgl_masuk Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Kode Anggota" Then
            kondisi = "Kd_Buku Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Judul" Then
            kondisi = "Judul Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Pengarang" Then
            kondisi = "Pengarang Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Penerbit" Then
            kondisi = "Penerbit Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Tahun" Then
            kondisi = "Tahun Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Kategori" Then
            kondisi = "Kategori Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Harga" Then
            kondisi = "Harga Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "Stok" Then
            kondisi = "Stok Like '%" & tb_Cari.Text & "%'"

        ElseIf ComboBox3.SelectedItem Like "tanggal Masuk" Then
            kondisi = "tgl_masuk Like '%" & tb_Cari.Text & "%'"
        End If
        tampilkandata(kondisi)
    End Sub

    Private Sub tb_Kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_Kategori.SelectedIndexChanged
        If tb_Kategori.SelectedIndex = 0 Then
            kategori = "Tidak Diketahui"
        Else
            kategori = tb_Kategori.Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Label15.Visible = False
            tb_gambar.Text = OpenFileDialog1.FileName
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c = MsgBox("Informasi Buku menjadi kurang lengkap tanpa Foto", vbQuestion + vbYesNo, "Hapus Foto")
        If c = vbYes Then
            tb_gambar.Text() = Nothing
            PictureBox1.Image = My.Resources.Image
            Label15.Visible = True
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Btn_Tambah_Click(sender As Object, e As EventArgs) Handles Btn_Tambah.Click
        Databaru()
    End Sub

    Public Sub inputdata()

        Dim kueri = "Insert into Buku values ('" & tb_Kode.Text & "', '" & tb_Judul.Text & "','" & tb_Pengarang.Text & "', '" & tb_Tahun.Text & "', '" & tb_Penerbit.Text & "', '" & tb_Harga.Text & "', '" & kategori & "', '" & tglmasuk & "', '" & up_Stok.Value & "', '" & gambar & "')"
        Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Data sudah tersimpan", My.Resources.Checklist)
        tampilkandata()
    End Sub

    Private Sub updatedata()

        kueri = "update Buku set Kd_buku = '" & tb_Kode.Text & "', Judul = '" & tb_Judul.Text & "', Pengarang = '" & tb_Pengarang.Text & "', Tahun ='" & tb_Tahun.Text & "', Penerbit ='" & tb_Penerbit.Text & "', harga = '" & tb_Harga.Text & "', Kategori = '" & tb_Kategori.Text & "', Tgl_Masuk = '" & tglmasuk & "' , Stok = '" & up_Stok.Text & "', Gambar = '" & tb_gambar.Text & "' where Kd_Buku = '" & tb_Kode.Text & "'"
        Console.WriteLine(vbCrLf & "Query Update : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Informasi buku diperbaharui", My.Resources.Checklist)
        tampilkandata()
    End Sub

    Public Sub hapusdata()

        kueri = "delete * from Buku where kd_Buku = '" + tb_Kode.Text + "'"
        Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Data Buku sudah dihapus", My.Resources.Checklist)
        reset()
        tampilkandata()
    End Sub

    Public Sub tampilkandata(Optional ByVal keyworddata As String = Nothing)
        If keyworddata <> Nothing Then
            kueri = "select * from Buku where " & keyworddata & " "
        ElseIf keyworddata = Nothing Then
            kueri = "select * from Buku "
        End If

        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        DataGridView1.ReadOnly = True

        If (DataGridView1.RowCount() - 1) < 1 Then
            Label_Jumlah.Text = "Tidak Ada data Buku "
        Else
            Label_Jumlah.Text = "Jumlah : " & DataGridView1.RowCount() - 1 & " Buku "
        End If

    End Sub

    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If isUpdate = False Then
            If PictureBox1.Image Is My.Resources.Image Then
                gambar = "C:\Users\M Haikal Anatama\source\repos\Aplikasi SI Perpustakaan\Aplikasi SI Perpustakaan\Pic\" + OpenFileDialog1.SafeFileName
                If System.IO.File.Exists(gambar) = False Then
                    System.IO.File.Copy(OpenFileDialog1.FileName, gambar)
                End If
            ElseIf PictureBox1.Image IsNot My.Resources.Image Then
                inputdata()
                editdata()
            End If
        ElseIf isUpdate = True Then
            updatedata()
        End If
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        Dim c = MsgBox("Data Akan hilang setelah dihapus", MsgBoxStyle.Critical + vbYesNo, "Hapus Data Buku dari Database")
        If c = MsgBoxResult.Yes Then
            hapusdata()
            Databaru()
        ElseIf c = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        editdata()
        tb_Kode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_Judul.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_Pengarang.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_Tahun.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        tb_Penerbit.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        tb_Harga.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        tb_Kategori.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        DateTimePicker1.Value = Format(DataGridView1.Rows(e.RowIndex).Cells(7).Value, "dd MMM yyyy")

        If Format(DataGridView1.Rows(e.RowIndex).Cells(7).Value, "dd/MMM/yyyy") = Today Then
            RadioButton1_Click(RadioButton1, New System.EventArgs)
        ElseIf Format(DataGridView1.Rows(e.RowIndex).Cells(7).Value, "dd/MMM/yyyy") <> Today Then
            RadioButton2_Click(RadioButton2, New System.EventArgs)

            DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        End If

        up_Stok.Value = DataGridView1.Rows(e.RowIndex).Cells(8).Value

        If DataGridView1.Rows(e.RowIndex).Cells(9).Value = Nothing Then
            tb_gambar.Text() = Nothing
            PictureBox1.Image = My.Resources.Image
            Label15.Visible = True
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

        Else
            tb_gambar.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
            gambar = DataGridView1.Rows(e.RowIndex).Cells(9).Value
            PictureBox1.Load(gambar)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            If tb_gambar.Text <> Nothing And PictureBox1.Image Is My.Resources.Image Then
                Label15.Text = "File Gambar Ini tidak ditemukan"
                Label15.Visible = True
            Else
                Label15.Visible = False
            End If
        End If
        Label9.Text = "Edit Data Buku " + DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        DateTimePicker1.Enabled = False
        tglmasuk = Format(Today, "yyyy-MM-dd")
        Console.WriteLine("Today " & Today)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click

        DateTimePicker1.Enabled = True
        tglmasuk = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Console.WriteLine("Tanggal" & Format(DateTimePicker1.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        tglmasuk = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Console.WriteLine("Tanggal " & Format(DateTimePicker1.Value, "yyyy-MM-dd"))

    End Sub

    Private Sub tb_Harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Harga.KeyPress
        Dim tombol As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse tombol = Keys.Back) Then
            tombol = 0
        ElseIf (e.KeyChar Like "[A-Z, a-z]") Then
            e.Handled = CBool(tombol)
        End If
        tb_Harga.Text = Format(Val(tb_Harga.Text), "###.###")
    End Sub


End Class
