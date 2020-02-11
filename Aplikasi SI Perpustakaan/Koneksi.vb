Imports System.Data.OleDb
Module Koneksi
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader

    Public ekstensi

    ''Ini untuk menyimpan data sementara dari setting tadi agar form lain bisa mengakses 
    Public Maks_Buku, Batas_Waktu, denda_telat, denda_rusak, denda_hilang As Integer
    Public Nama_Akun As String = " Nama Tidak Diketahui",
            Hakakses As String = "Hak Akses tidak diketahui",
            Username As String = "",
            jns_kel = "",
            password = ""

    Public Sub tampilkanPengaturan()
        cmd = New OleDbCommand("select * from pengaturan", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            denda_telat = dr.Item("Denda_Telat")
            denda_rusak = dr.Item("Denda_Rusak")
            denda_hilang = dr.Item("Denda_Hilang")
            Maks_Buku = dr.Item("Maks_Buku")
            Batas_Waktu = dr.Item("Batas_Waktu")
        End If
    End Sub

    Private namadb As String = "SiPeminjamanBuku",
       user As String = "root",
       pass As String = "",
       provider As String,
       DbConnection As String = "provider=" + getprovider() + ";data source=" + getnamadb()

    Public Function getnamadb()
        Return namadb + ".mdb"
    End Function

    Public Function getuser()
        Return user
    End Function

    Public Function getpass()
        Return pass
    End Function
    Public Function getprovider()
        provider = "microsoft.jet.oledb.4.0"
        Return provider
    End Function
    Public Function getDbConn()
        Return DbConnection
    End Function
    Public Sub connectnow()
        Try
            conn = New OleDbConnection(getDbConn)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                LoginForm.Enabled = True
            End If

        Catch ex As OleDbException
            Console.WriteLine("Connection DB : " & DbConnection & vbCrLf)
            Console.WriteLine("Error: " & ex.Message)
            LoginForm.Enabled = False

            Dim c = MsgBox("Silahkan Periksa file database di bin/debug dan Coba lagi?", vbCritical + vbYesNo, "Koneksi Ke database gagal")
            If c = vbYes Then
                connectnow()
            Else
                End
            End If
            Exit Sub
        End Try
        tampilkanPengaturan()
    End Sub

End Module