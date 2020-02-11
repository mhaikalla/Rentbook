Imports System.Data.OleDb
Public Class UC_Anggota
    Dim isUpdate As Boolean = False
    Dim kondisi, kueri, kode As String

    Private Sub UC_Anggota_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            SetHintText(TextBox1, "Cari nama, kode, dan lainnya")
            tampilkandata()
            IsiKodeOtomatis()
            ComboBox3.SelectedIndex = 0
        End If
    End Sub
    Private Sub UC_Anggota_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Not Me.DesignMode Then
                tampilkandata()
            End If
        End If
    End Sub
    Public Sub reset()
        Dim c As Control
        For Each c In Me.Panel2.Controls
            If TypeOf c Is TextBox Then
                c.ResetText()
            End If
        Next c
        IsiKodeOtomatis()
    End Sub
    Public Sub inputdata()
        kueri = "Insert into anggota values ('" & tb_Kode.Text & "', '" & tb_Nama.Text & "','" & IIf(rb_Laki.Checked = True, "Laki-Laki", "Perempuan") & "', '" & tb_Notelp.Text & "', '" & tb_Email.Text & "', '" & tb_Alamat.Text & "')"
        Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Data Anggota Baru sudah di input")
        tampilkandata()
    End Sub
    Private Sub updatedata()
        Dim kueri = "update anggota set kd_Anggota = '" & tb_Kode.Text & "', Nama_Anggota = '" & tb_Nama.Text & "', jns_kel = '" & IIf(rb_Laki.Checked = True, "Laki-Laki", "Perempuan") & "', Notelp ='" & tb_Notelp.Text & "', Email ='" & tb_Email.Text & "', Alamat = '" & tb_Alamat.Text & "' where Kd_Anggota = '" & tb_Kode.Text & "'"
        Console.WriteLine(vbCrLf & "Query Update : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Data telah diperbarui")
        tampilkandata()
    End Sub

    Public Sub hapusdata()

        Dim kueri
        kueri = "delete from anggota where kd_Anggota = '" + tb_Kode.Text + "'"
        Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("Data berhasil di Hapus")
        reset()
        tampilkandata()
    End Sub

    Public Sub tampilkandata(Optional ByVal keyworddata As String = Nothing)

        If keyworddata <> Nothing Then
            kueri = "select * from anggota where " & keyworddata & " "
        ElseIf keyworddata = Nothing Then
            kueri = "select * from anggota"
        End If
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))

        If (DataGridView1.RowCount() - 1) < 1 Then
            Label_Jumlah.Text = "Tidak Ada Anggota"
        Else
            Label_Jumlah.Text = "Tersimpan " & DataGridView1.RowCount() & " Anggota "
        End If
    End Sub
    Sub editdata()
        reset()
        isUpdate = True
        btn_Hapus.Visible = True
        Btn_Simpan.Text = "Perbarui Data"
        Panel2.Visible = True

        Label2.Visible = False

        Button1.Visible = False
        ComboBox3.Enabled = False
        btn_Tambah.Enabled = True
    End Sub
    Sub Databaru()
        reset()
        IsiKodeOtomatis()
        isUpdate = False
        btn_Hapus.Visible = False
        Btn_Simpan.Text = "Simpan"
        Panel2.Visible = True
        Label9.Text = "Input Data Baru"
        Label2.Visible = True
    End Sub
    Public Sub IsiKodeOtomatis()
        cmd = New OleDbCommand("select Kd_Anggota from anggota order by kd_anggota desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kode = "A" + "0001"
            tb_Kode.Text = kode
        Else
            kode = "A" + Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Anggota"), 4) + 1, "0000")
            tb_Kode.Text = kode
        End If
        tb_Kode.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If ComboBox3.SelectedItem = "Semua Pencarian" Then
            kondisi = "Kd_Anggota like '%" & TextBox1.Text & "%' or Nama_Anggota Like '%" & TextBox1.Text & "%' or Jns_kel Like '%" & TextBox1.Text & "%' or Notelp Like '%" & TextBox1.Text & "%' or Email Like '%" & TextBox1.Text & "%' or Alamat Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Kode Anggota" Then
            kondisi = "Kd_Anggota like  '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Nama" Then
            kondisi = "Nama_Anggota Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "No telepon" Then
            kondisi = "Notelp Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Jenis Kelamin" Then
            kondisi = "jns_kel = '" & TextBox1.Text & "'"

        ElseIf ComboBox3.SelectedItem = "Alamat" Then
            kondisi = "Alamat Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Email" Then
            kondisi = "Email Like '%" & TextBox1.Text & "%'"

        End If
        tampilkandata(kondisi)
    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox3.SelectionChangeCommitted

        If ComboBox3.SelectedItem = "Semua Pencarian" Then
            kondisi = "Kd_Anggota Like '%" & TextBox1.Text & "%' or Nama_Anggota Like '%" & TextBox1.Text & "%' or Jns_kel Like '%" & TextBox1.Text & "%' or Notelp Like '%" & TextBox1.Text & "%' or Email Like '%" & TextBox1.Text & "%' or Alamat Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Kode Anggota" Then
            kondisi = "Kd_Anggota Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Nama" Then
            kondisi = "Nama_Anggota Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "No telepon" Then
            kondisi = "Notelp Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Jenis Kelamin" Then
            kondisi = "jns_kel = '" & TextBox1.Text & "'"

        ElseIf ComboBox3.SelectedItem = "Alamat" Then
            kondisi = "Alamat Like '%" & TextBox1.Text & "%'"

        ElseIf ComboBox3.SelectedItem = "Email" Then
            kondisi = "Email Like '%" & TextBox1.Text & "%'"
        End If
        tampilkandata(kondisi)
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Panel2.Visible = False
        Button1.Visible = True
        ComboBox3.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = True
        Button1.Visible = False
        TextBox1.ResetText()
        ComboBox3.Visible = False
    End Sub

    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If tb_Nama.TextLength < 1 Or tb_Notelp.TextLength < 1 Or tb_Alamat.TextLength < 1 Or tb_Email.TextLength < 1 Or (rb_Laki.Checked = False And rb_Perempuan.Checked = False) Then
            setNotification("Data masih belum lengkap", My.Resources.Warning)
            Exit Sub
        End If
        If isUpdate = False Then
            inputdata()
            editdata()
        ElseIf isUpdate = True Then
            updatedata()
        End If
    End Sub
    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        Databaru()
    End Sub
    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        Dim c = MsgBox("Data yang telah dihapus tidak bisa dikembalikan", MsgBoxStyle.Critical + vbYesNo, "Hapus Data")
        If c = vbYes Then
            hapusdata()
            Databaru()
        ElseIf c = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub tb_Notelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Notelp.KeyPress
        Dim tombol As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
                OrElse tombol = Keys.Back) Then
            tombol = 0
        ElseIf (e.KeyChar Like "[A-Z, a-z]") Then
            e.Handled = CBool(tombol)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        editdata()
        tb_Kode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_Nama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Label9.Text = "Edit Data Anggota " + DataGridView1.Rows(e.RowIndex).Cells(1).Value
        If DataGridView1.Rows(e.RowIndex).Cells(2).Value Like "Laki-Laki" Then
            rb_Laki.Checked = True
        ElseIf DataGridView1.Rows(e.RowIndex).Cells(2).Value Like "Perempuan" Then
            rb_Perempuan.Checked = True
        End If
        tb_Notelp.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        tb_Email.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        tb_Alamat.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

End Class
