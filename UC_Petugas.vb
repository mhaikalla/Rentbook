Imports System.Data.OleDb
Public Class UC_Petugas
    Dim kueri As String,
    kondisi As String,
    kode As String,
    isUpdate As Boolean = False,
    c As Control

    Private Sub UC_Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            tampilkandata()
            SetHintText(TextBox1, "Cari informasi petugas")
            ComboBox3.SelectedIndex = 0
        End If
    End Sub

    Private Sub UC_Petugas_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Not Me.DesignMode Then
                tampilkandata()
            End If
        End If
    End Sub

    Sub inputdata()
        kueri = "Insert into admin values ('" & tb_Username.Text & "', '" & tb_Password.Text & "','" & tb_Nama.Text & "', '" & IIf(rb_Laki.Checked, "Laki-Laki", "Perempuan") & "', '" & Cb_Hakakses.Text & "')"
        Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        tampilkandata()
        If Cb_Hakakses.Text = "Petugas" Then
            setNotification("ID Akun : " & tb_Username.Text & " terdaftar sebagai Petugas Baru", My.Resources.Checklist)
        ElseIf Cb_Hakakses.Text = "Admin" Then
            setNotification("ID Akun : " & tb_Username.Text & " terdaftar sebagai Admin baru", My.Resources.Checklist)
        End If
    End Sub

    Sub tampilkandata(Optional ByVal condition As String = Nothing)

        kueri = "select Nama, Username ,Hak_Akses, Jns_Kel, Password from Admin "
        If condition <> Nothing Then
            kueri = kueri + " where " + kondisi
        End If
        Console.WriteLine(vbCrLf & "Query Select: " & kueri & vbCrLf)
        da = New OleDb.OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = (ds.Tables(0))
        If (DataGridView1.RowCount() - 1) < 1 Then
            Label_Jumlah.Text = "Tidak Ada Akun Yang terdaftar"
        Else
            Label_Jumlah.Text = "Tersimpan " & DataGridView1.RowCount() & " akun "
        End If
    End Sub
    Public Sub hapusdata()
        kueri = "delete from admin where Username = '" + tb_Username.Text + "'"
        Console.WriteLine(vbCrLf & "Query Delete : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()

        If Not dr.HasRows Then
            kode = "H" + "00001"
        Else
            kode = "H" + Format(Microsoft.VisualBasic.Right(dr.Item("Kd_Histori"), 4) + 1, "00000")
        End If
        If Username = tb_Username.Text Then
            kueri = "Insert into HistoriAkun values ('" & Format(Now, "dd MMMM yyyy,  HH:mm") & "', '" & Username & "','Menghapus nama akun nya sendiri', '" & kode & "')"
        Else
            kueri = "Insert into HistoriAkun values ('" & Format(Now, "dd MMMM yyyy,  HH:mm") & "', '" & Username & "','Menghapus nama akun " & tb_Nama.Text & " dengan ID " & tb_Username.Text & "', '" & kode & "')"
        End If
        Console.WriteLine(vbCrLf & "Query Input : " & kueri & vbCrLf)
            cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("ID Akun " & tb_Username.Text & " dengan nama " & tb_Nama.Text & " sekarang sudah terhapus", My.Resources.Checklist)
        tampilkandata()
        reset()
    End Sub
    Public Sub updatedata()
        kueri = "UPDATE `Admin` SET `Username` ='" & tb_Username.Text & "',`Password`='" & tb_Password.Text & "',Nama='" & tb_Nama.Text & "',Jns_Kel='" & IIf(rb_Laki.Checked = True, "Laki-Laki", "Perempuan") & "',Hak_Akses='" & Cb_Hakakses.Text & "' WHERE Username = '" & tb_Username.Text & "';"
        Console.WriteLine(vbCrLf & "Query Update : " & kueri & vbCrLf)
        cmd = New OleDbCommand(kueri, conn)
        cmd.ExecuteNonQuery()
        setNotification("ID Akun " & tb_Username.Text & " data nya telah diperbarui", My.Resources.Checklist)
        tampilkandata()
    End Sub
    Sub reset()
        Dim c As Control
        For Each c In Me.Panel2.Controls
            If TypeOf c Is TextBox Then
                c.ResetText()
                c.Enabled = True
            ElseIf TypeOf c Is ComboBox Or TypeOf c Is RadioButton Then
                c.Enabled = True
            End If
        Next c
        rb_Laki.Checked = False
        rb_Perempuan.Checked = False
        Cb_Hakakses.SelectedIndex = 0
        Button2.Visible = True
        Btn_Simpan.Visible = True
        btn_Hapus.Visible = True
        tb_Password.Enabled = False
    End Sub
    Sub databaru()
        reset()
        tb_Password.Enabled = True
        Panel2.Visible = True
        btn_Hapus.Visible = False
        Btn_Simpan.Text = "Simpan"
        Label9.Text = "Akun Baru"
        isUpdate = False
    End Sub

    Sub editdata()
        reset()
        tb_Password.Enabled = True
        Panel2.Visible = True
        Btn_Simpan.Visible = True
        btn_Hapus.Visible = True
        Button2.Visible = True
        Btn_Simpan.Text = "Update Data"
        Label9.Text = "Edit Akun"
        isUpdate = True
    End Sub

    '=============================================================================================================================================================================='
    Private Sub Btn_Simpan_Click(sender As Object, e As EventArgs) Handles Btn_Simpan.Click
        If tb_Nama.Text = Nothing Or tb_Password.Text = Nothing Or (rb_Laki.Checked = False And rb_Perempuan.Checked = False) Then
            setNotification("Data masih Belum Lengkap", My.Resources.Warning)
            Exit Sub
        End If
        If isUpdate = False Then
            inputdata()
        ElseIf isUpdate = True Then
            updatedata()
        End If
        Label15.Visible = False
    End Sub
    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        databaru()
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        Dim c = MsgBox("Jika Akun Terhapus maka akun ini tidak bisa dikembalikan", vbYesNo + vbExclamation + vbCritical, "Hapus Akun Ini?")
        If c = vbYes Then
            hapusdata()
        End If
    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        Button2.Image = My.Resources.Visible
        tb_Password.PasswordChar = "*"
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Button2.Image = My.Resources.Invisible
        tb_Password.PasswordChar = ""
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Semua Pencarian" Then
            kondisi = "Username Like '%" & TextBox1.Text & "%' or Nama Like '%" & TextBox1.Text & "%' or Jns_kel Like '%" & TextBox1.Text & "%' or Hak_Akses Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Username" Then
            kondisi = "Username Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Nama" Then
            kondisi = "Nama Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Hak Akses" Then
            kondisi = "Hak_Akses Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Jenis Kelamin" Then
            kondisi = "jns_kel Like '%" & TextBox1.Text & "%'"
        End If
        tampilkandata(kondisi)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If ComboBox3.SelectedItem = "Semua Pencarian" Then
            kondisi = "Username Like '%" & TextBox1.Text & "%' or Nama Like '%" & TextBox1.Text & "%' or Jns_kel Like '%" & TextBox1.Text & "%' or Hak_Akses Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Username" Then
            kondisi = "Username Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Nama" Then
            kondisi = "Nama Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Hak Akses" Then
            kondisi = "Hak_Akses Like '%" & TextBox1.Text & "%'"
        ElseIf ComboBox3.SelectedItem = "Jenis Kelamin" Then
            kondisi = "jns_kel Like '%" & TextBox1.Text & "%'"
        End If
        tampilkandata(kondisi)
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        editdata()
        For Each c In Me.Panel2.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            ElseIf TypeOf c Is ComboBox Then
                c.Enabled = True
            ElseIf TypeOf c Is RadioButton Then
                c.Enabled = True
            End If
        Next
        tb_Nama.Text = Nama_Akun
        tb_Username.Text = Username
        tb_Password.Text = password

        If jns_kel Like "Laki-Laki" Then
            rb_Laki.Checked = True
        ElseIf jns_kel Like "Perempuan" Then
            rb_Perempuan.Checked = True
        End If
        Cb_Hakakses.Text = Hakakses

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        editdata()
        If Hakakses = "Petugas" Or (Hakakses = "Admin" And DataGridView1.Rows(e.RowIndex).Cells(2).Value = "Admin") Then
            If Username <> DataGridView1.Rows(e.RowIndex).Cells(1).Value Then

                For Each c In Me.Panel2.Controls
                    If TypeOf c Is TextBox Then
                        c.Enabled = False
                    ElseIf TypeOf c Is ComboBox Then
                        c.Enabled = False
                    ElseIf TypeOf c Is RadioButton Then
                        c.Enabled = False
                    End If
                Next
                Btn_Simpan.Visible = False
                btn_Hapus.Visible = False
                Button2.Visible = False
            End If
        End If
        tb_Nama.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_Username.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Cb_Hakakses.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        If DataGridView1.Rows(e.RowIndex).Cells(3).Value Like "Laki-Laki" Then
            rb_Laki.Checked = True
        ElseIf DataGridView1.Rows(e.RowIndex).Cells(3).Value Like "Perempuan" Then
            rb_Perempuan.Checked = True
        End If
        tb_Password.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If (e.ColumnIndex <> -1 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "Password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Panel2.Visible = False
        btn_Tambah.Visible = False
        ComboBox3.Visible = True
        Button1.Visible = True
        Button4.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = True
        btn_Tambah.Visible = True
        ComboBox3.Visible = False
        TextBox1.ResetText()
        Button1.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub tb_Username_LostFocus(sender As Object, e As EventArgs) Handles tb_Username.LostFocus
        cmd = New OleDbCommand("select * from Admin where Username='" & tb_Username.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Label15.Text = "Username ini sudah terdaftar"
            Label15.Visible = True
            Label15.BackColor = System.Drawing.Color.FromArgb("52, 168, 83")
            Btn_Simpan.Enabled = False
        Else
            Label15.Text = "Username ini bisa dipakai"
            Label15.BackColor = System.Drawing.Color.FromArgb("234; 67; 53 ")
            Btn_Simpan.Enabled = True
        End If

    End Sub
End Class
