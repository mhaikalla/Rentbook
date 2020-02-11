<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_Submenu = New System.Windows.Forms.Panel()
        Me.panel_Dashboard = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_Pengaturan = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panel_Master = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Transaction = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Panel_Akun = New System.Windows.Forms.Panel()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.btn_EditAkun = New System.Windows.Forms.Button()
        Me.Label_HakAkses = New System.Windows.Forms.Label()
        Me.Label_Nama = New System.Windows.Forms.Label()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_Content = New System.Windows.Forms.Panel()
        Me.UC_Dashboard = New Aplikasi_SI_Perpustakaan__PI_.UC_Dashboard()
        Me.UC_Buku = New Aplikasi_SI_Perpustakaan__PI_.UC_Buku()
        Me.UC_Anggota = New Aplikasi_SI_Perpustakaan__PI_.UC_Anggota()
        Me.UC_Petugas = New Aplikasi_SI_Perpustakaan__PI_.UC_Petugas()
        Me.UC_Pengembalian = New Aplikasi_SI_Perpustakaan__PI_.UC_Pengembalian()
        Me.UC_Pengaturan = New Aplikasi_SI_Perpustakaan__PI_.UC_Pengaturan()
        Me.UC_Peminjaman = New Aplikasi_SI_Perpustakaan__PI_.UC_Peminjaman()
        Me.UC_History = New Aplikasi_SI_Perpustakaan__PI_.UC_History()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.btn_Akun = New System.Windows.Forms.Button()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label_Judul = New System.Windows.Forms.Label()
        Me.panel_Title = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Pengaturan = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NotifText = New System.Windows.Forms.Label()
        Me.Panel_Notif = New System.Windows.Forms.TableLayoutPanel()
        Me.Ikon_Notif = New System.Windows.Forms.PictureBox()
        Me.panel_Submenu.SuspendLayout()
        Me.panel_Dashboard.SuspendLayout()
        Me.Panel_Pengaturan.SuspendLayout()
        Me.panel_Master.SuspendLayout()
        Me.Panel_History.SuspendLayout()
        Me.Panel_Transaction.SuspendLayout()
        Me.Panel_Akun.SuspendLayout()
        Me.panel_Content.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        Me.panel_Title.SuspendLayout()
        Me.panel_Menu.SuspendLayout()
        Me.Panel_Notif.SuspendLayout()
        CType(Me.Ikon_Notif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-3, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "  Master"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_Submenu
        '
        Me.panel_Submenu.Controls.Add(Me.panel_Dashboard)
        Me.panel_Submenu.Controls.Add(Me.Panel_Pengaturan)
        Me.panel_Submenu.Controls.Add(Me.panel_Master)
        Me.panel_Submenu.Controls.Add(Me.Panel_History)
        Me.panel_Submenu.Controls.Add(Me.Panel_Transaction)
        Me.panel_Submenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_Submenu.Location = New System.Drawing.Point(38, 0)
        Me.panel_Submenu.Name = "panel_Submenu"
        Me.panel_Submenu.Size = New System.Drawing.Size(141, 561)
        Me.panel_Submenu.TabIndex = 81
        '
        'panel_Dashboard
        '
        Me.panel_Dashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.panel_Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panel_Dashboard.Controls.Add(Me.Label6)
        Me.panel_Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.panel_Dashboard.Name = "panel_Dashboard"
        Me.panel_Dashboard.Size = New System.Drawing.Size(141, 561)
        Me.panel_Dashboard.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 115)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Dashboard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Berisi data singkat dari data peminjaman, pengembalian, data anggota" &
    ", buku, petugas dan lainnya"
        '
        'Panel_Pengaturan
        '
        Me.Panel_Pengaturan.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel_Pengaturan.Controls.Add(Me.Label9)
        Me.Panel_Pengaturan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Pengaturan.Name = "Panel_Pengaturan"
        Me.Panel_Pengaturan.Size = New System.Drawing.Size(141, 561)
        Me.Panel_Pengaturan.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 78)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Pengaturan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Berisi pengaturan dalam penggunaan aplikasi "
        '
        'panel_Master
        '
        Me.panel_Master.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panel_Master.Controls.Add(Me.Button9)
        Me.panel_Master.Controls.Add(Me.Button6)
        Me.panel_Master.Controls.Add(Me.Label3)
        Me.panel_Master.Controls.Add(Me.Button7)
        Me.panel_Master.Location = New System.Drawing.Point(0, 0)
        Me.panel_Master.Name = "panel_Master"
        Me.panel_Master.Size = New System.Drawing.Size(141, 561)
        Me.panel_Master.TabIndex = 34
        Me.panel_Master.Visible = False
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Petugas
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button9.Location = New System.Drawing.Point(0, 151)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(141, 41)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "Petugas"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Anggota
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(0, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 43)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Anggota"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Buku
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 108)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 43)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Buku"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel_History
        '
        Me.Panel_History.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel_History.Controls.Add(Me.Button20)
        Me.Panel_History.Controls.Add(Me.Button19)
        Me.Panel_History.Controls.Add(Me.Button18)
        Me.Panel_History.Controls.Add(Me.Label4)
        Me.Panel_History.Location = New System.Drawing.Point(0, 0)
        Me.Panel_History.Name = "Panel_History"
        Me.Panel_History.Size = New System.Drawing.Size(141, 561)
        Me.Panel_History.TabIndex = 35
        Me.Panel_History.Visible = False
        '
        'Button20
        '
        Me.Button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.White
        Me.Button20.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Petugas
        Me.Button20.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button20.Location = New System.Drawing.Point(0, 149)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(140, 43)
        Me.Button20.TabIndex = 31
        Me.Button20.Text = "Petugas"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.White
        Me.Button19.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Pengembalian
        Me.Button19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button19.Location = New System.Drawing.Point(0, 106)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(141, 43)
        Me.Button19.TabIndex = 30
        Me.Button19.Text = "Kembali"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.White
        Me.Button18.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Peminjaman
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button18.Location = New System.Drawing.Point(0, 63)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(141, 43)
        Me.Button18.TabIndex = 29
        Me.Button18.Text = "Pinjam"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "History"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Transaction
        '
        Me.Panel_Transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel_Transaction.Controls.Add(Me.Label1)
        Me.Panel_Transaction.Controls.Add(Me.Button14)
        Me.Panel_Transaction.Controls.Add(Me.Button15)
        Me.Panel_Transaction.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Transaction.Name = "Panel_Transaction"
        Me.Panel_Transaction.Size = New System.Drawing.Size(141, 561)
        Me.Panel_Transaction.TabIndex = 36
        Me.Panel_Transaction.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "  Transaksi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button14
        '
        Me.Button14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Pengembalian
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(0, 105)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(141, 40)
        Me.Button14.TabIndex = 22
        Me.Button14.Text = "Pengembalian"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Peminjaman
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button15.Location = New System.Drawing.Point(0, 65)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(141, 40)
        Me.Button15.TabIndex = 21
        Me.Button15.Text = "Peminjaman"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Panel_Akun
        '
        Me.Panel_Akun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Akun.BackColor = System.Drawing.Color.White
        Me.Panel_Akun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Akun.Controls.Add(Me.Label_Username)
        Me.Panel_Akun.Controls.Add(Me.btn_EditAkun)
        Me.Panel_Akun.Controls.Add(Me.Label_HakAkses)
        Me.Panel_Akun.Controls.Add(Me.Label_Nama)
        Me.Panel_Akun.Controls.Add(Me.btn_Logout)
        Me.Panel_Akun.Location = New System.Drawing.Point(855, 105)
        Me.Panel_Akun.Name = "Panel_Akun"
        Me.Panel_Akun.Size = New System.Drawing.Size(274, 110)
        Me.Panel_Akun.TabIndex = 28
        Me.Panel_Akun.Visible = False
        '
        'Label_Username
        '
        Me.Label_Username.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(1, 29)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(272, 17)
        Me.Label_Username.TabIndex = 32
        Me.Label_Username.Text = "Username"
        '
        'btn_EditAkun
        '
        Me.btn_EditAkun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_EditAkun.AutoSize = True
        Me.btn_EditAkun.BackColor = System.Drawing.Color.Transparent
        Me.btn_EditAkun.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_EditAkun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_EditAkun.FlatAppearance.BorderSize = 0
        Me.btn_EditAkun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_EditAkun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btn_EditAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EditAkun.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EditAkun.Location = New System.Drawing.Point(0, 77)
        Me.btn_EditAkun.Name = "btn_EditAkun"
        Me.btn_EditAkun.Size = New System.Drawing.Size(88, 31)
        Me.btn_EditAkun.TabIndex = 31
        Me.btn_EditAkun.Text = "Edit Akun"
        Me.btn_EditAkun.UseVisualStyleBackColor = False
        '
        'Label_HakAkses
        '
        Me.Label_HakAkses.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_HakAkses.Location = New System.Drawing.Point(1, 47)
        Me.Label_HakAkses.Name = "Label_HakAkses"
        Me.Label_HakAkses.Size = New System.Drawing.Size(271, 20)
        Me.Label_HakAkses.TabIndex = 30
        Me.Label_HakAkses.Text = "Hak Akses"
        '
        'Label_Nama
        '
        Me.Label_Nama.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Nama.Font = New System.Drawing.Font("Google Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nama.Location = New System.Drawing.Point(0, 0)
        Me.Label_Nama.Name = "Label_Nama"
        Me.Label_Nama.Size = New System.Drawing.Size(272, 30)
        Me.Label_Nama.TabIndex = 29
        Me.Label_Nama.Text = "Nama Akun"
        Me.Label_Nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Logout
        '
        Me.btn_Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Logout.AutoSize = True
        Me.btn_Logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Logout.FlatAppearance.BorderSize = 0
        Me.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(194, 77)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(78, 31)
        Me.btn_Logout.TabIndex = 28
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'panel_Content
        '
        Me.panel_Content.Controls.Add(Me.UC_Dashboard)
        Me.panel_Content.Controls.Add(Me.UC_Buku)
        Me.panel_Content.Controls.Add(Me.UC_Anggota)
        Me.panel_Content.Controls.Add(Me.UC_Petugas)
        Me.panel_Content.Controls.Add(Me.UC_Pengembalian)
        Me.panel_Content.Controls.Add(Me.UC_Pengaturan)
        Me.panel_Content.Controls.Add(Me.UC_Peminjaman)
        Me.panel_Content.Controls.Add(Me.UC_History)
        Me.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Content.Location = New System.Drawing.Point(179, 99)
        Me.panel_Content.Name = "panel_Content"
        Me.panel_Content.Size = New System.Drawing.Size(956, 412)
        Me.panel_Content.TabIndex = 82
        '
        'UC_Dashboard
        '
        Me.UC_Dashboard.AutoScroll = True
        Me.UC_Dashboard.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Dashboard.Location = New System.Drawing.Point(0, 0)
        Me.UC_Dashboard.MinimumSize = New System.Drawing.Size(848, 531)
        Me.UC_Dashboard.Name = "UC_Dashboard"
        Me.UC_Dashboard.Size = New System.Drawing.Size(956, 531)
        Me.UC_Dashboard.TabIndex = 2
        '
        'UC_Buku
        '
        Me.UC_Buku.AutoScroll = True
        Me.UC_Buku.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.UC_Buku.AutoSize = True
        Me.UC_Buku.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Buku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Buku.Location = New System.Drawing.Point(0, 0)
        Me.UC_Buku.MinimumSize = New System.Drawing.Size(820, 0)
        Me.UC_Buku.Name = "UC_Buku"
        Me.UC_Buku.Size = New System.Drawing.Size(956, 412)
        Me.UC_Buku.TabIndex = 1
        '
        'UC_Anggota
        '
        Me.UC_Anggota.AutoScroll = True
        Me.UC_Anggota.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Anggota.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Anggota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Anggota.Location = New System.Drawing.Point(0, 0)
        Me.UC_Anggota.MinimumSize = New System.Drawing.Size(800, 0)
        Me.UC_Anggota.Name = "UC_Anggota"
        Me.UC_Anggota.Size = New System.Drawing.Size(956, 412)
        Me.UC_Anggota.TabIndex = 0
        '
        'UC_Petugas
        '
        Me.UC_Petugas.AutoScroll = True
        Me.UC_Petugas.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Petugas.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Petugas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Petugas.Location = New System.Drawing.Point(0, 0)
        Me.UC_Petugas.MinimumSize = New System.Drawing.Size(830, 0)
        Me.UC_Petugas.Name = "UC_Petugas"
        Me.UC_Petugas.Size = New System.Drawing.Size(956, 412)
        Me.UC_Petugas.TabIndex = 7
        '
        'UC_Pengembalian
        '
        Me.UC_Pengembalian.AutoScroll = True
        Me.UC_Pengembalian.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Pengembalian.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Pengembalian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Pengembalian.Location = New System.Drawing.Point(0, 0)
        Me.UC_Pengembalian.MinimumSize = New System.Drawing.Size(829, 400)
        Me.UC_Pengembalian.Name = "UC_Pengembalian"
        Me.UC_Pengembalian.Size = New System.Drawing.Size(956, 412)
        Me.UC_Pengembalian.TabIndex = 6
        '
        'UC_Pengaturan
        '
        Me.UC_Pengaturan.AutoScroll = True
        Me.UC_Pengaturan.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Pengaturan.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Pengaturan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Pengaturan.Location = New System.Drawing.Point(0, 0)
        Me.UC_Pengaturan.MinimumSize = New System.Drawing.Size(636, 365)
        Me.UC_Pengaturan.Name = "UC_Pengaturan"
        Me.UC_Pengaturan.Size = New System.Drawing.Size(956, 412)
        Me.UC_Pengaturan.TabIndex = 5
        '
        'UC_Peminjaman
        '
        Me.UC_Peminjaman.AutoScroll = True
        Me.UC_Peminjaman.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.UC_Peminjaman.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_Peminjaman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Peminjaman.Location = New System.Drawing.Point(0, 0)
        Me.UC_Peminjaman.MinimumSize = New System.Drawing.Size(783, 659)
        Me.UC_Peminjaman.Name = "UC_Peminjaman"
        Me.UC_Peminjaman.Size = New System.Drawing.Size(956, 659)
        Me.UC_Peminjaman.TabIndex = 4
        '
        'UC_History
        '
        Me.UC_History.AutoScroll = True
        Me.UC_History.AutoScrollMargin = New System.Drawing.Size(30, 0)
        Me.UC_History.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.UC_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_History.Location = New System.Drawing.Point(0, 0)
        Me.UC_History.MinimumSize = New System.Drawing.Size(771, 370)
        Me.UC_History.Name = "UC_History"
        Me.UC_History.Size = New System.Drawing.Size(956, 412)
        Me.UC_History.TabIndex = 3
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.White
        Me.TitleBar.Controls.Add(Me.btn_Akun)
        Me.TitleBar.Controls.Add(Me.btn_Minimize)
        Me.TitleBar.Controls.Add(Me.btn_Close)
        Me.TitleBar.Controls.Add(Me.Label_Judul)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(179, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(956, 99)
        Me.TitleBar.TabIndex = 78
        '
        'btn_Akun
        '
        Me.btn_Akun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Akun.AutoSize = True
        Me.btn_Akun.BackColor = System.Drawing.Color.Transparent
        Me.btn_Akun.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Akun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Akun.FlatAppearance.BorderSize = 0
        Me.btn_Akun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_Akun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_Akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Akun.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Akun.Location = New System.Drawing.Point(796, 1)
        Me.btn_Akun.Name = "btn_Akun"
        Me.btn_Akun.Size = New System.Drawing.Size(78, 31)
        Me.btn_Akun.TabIndex = 27
        Me.btn_Akun.Text = "Nama Akun"
        Me.btn_Akun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Akun.UseVisualStyleBackColor = False
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Minimize.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Minimize
        Me.btn_Minimize.Location = New System.Drawing.Point(874, 1)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(41, 31)
        Me.btn_Minimize.TabIndex = 26
        Me.btn_Minimize.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Close_Dark
        Me.btn_Close.Location = New System.Drawing.Point(915, 1)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(41, 31)
        Me.btn_Close.TabIndex = 24
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'Label_Judul
        '
        Me.Label_Judul.Font = New System.Drawing.Font("Google Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Judul.Location = New System.Drawing.Point(38, 37)
        Me.Label_Judul.Name = "Label_Judul"
        Me.Label_Judul.Size = New System.Drawing.Size(159, 26)
        Me.Label_Judul.TabIndex = 0
        Me.Label_Judul.Text = "Dashboard"
        Me.Label_Judul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_Title
        '
        Me.panel_Title.BackColor = System.Drawing.Color.DarkTurquoise
        Me.panel_Title.Controls.Add(Me.Label5)
        Me.panel_Title.Controls.Add(Me.Label2)
        Me.panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.panel_Title.MaximumSize = New System.Drawing.Size(328, 42)
        Me.panel_Title.MinimumSize = New System.Drawing.Size(186, 42)
        Me.panel_Title.Name = "panel_Title"
        Me.panel_Title.Size = New System.Drawing.Size(321, 42)
        Me.panel_Title.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(181, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 42)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Versi 1.0.2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Library_33px
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 42)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Aplikasi Perpustakaan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panel_Menu
        '
        Me.panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panel_Menu.Controls.Add(Me.Btn_Pengaturan)
        Me.panel_Menu.Controls.Add(Me.Button16)
        Me.panel_Menu.Controls.Add(Me.Button13)
        Me.panel_Menu.Controls.Add(Me.Button2)
        Me.panel_Menu.Controls.Add(Me.Button1)
        Me.panel_Menu.Controls.Add(Me.Button4)
        Me.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_Menu.MaximumSize = New System.Drawing.Size(180, 0)
        Me.panel_Menu.MinimumSize = New System.Drawing.Size(38, 0)
        Me.panel_Menu.Name = "panel_Menu"
        Me.panel_Menu.Size = New System.Drawing.Size(38, 561)
        Me.panel_Menu.TabIndex = 79
        '
        'Btn_Pengaturan
        '
        Me.Btn_Pengaturan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Btn_Pengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pengaturan.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pengaturan.ForeColor = System.Drawing.Color.White
        Me.Btn_Pengaturan.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Pengaturan
        Me.Btn_Pengaturan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Pengaturan.Location = New System.Drawing.Point(-1, 522)
        Me.Btn_Pengaturan.Name = "Btn_Pengaturan"
        Me.Btn_Pengaturan.Size = New System.Drawing.Size(181, 40)
        Me.Btn_Pengaturan.TabIndex = 24
        Me.Btn_Pengaturan.Text = "Pengaturan"
        Me.Btn_Pengaturan.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.History
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button16.Location = New System.Drawing.Point(0, 202)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(181, 40)
        Me.Button16.TabIndex = 23
        Me.Button16.Text = "History"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button13.Location = New System.Drawing.Point(0, 42)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(180, 40)
        Me.Button13.TabIndex = 20
        Me.Button13.Text = "M E N U"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Transaction
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(0, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 40)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Transaksi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.database
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(0, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Master"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Home
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(0, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 40)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Dashboard"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NotifText
        '
        Me.NotifText.AutoSize = True
        Me.NotifText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotifText.Font = New System.Drawing.Font("Google Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifText.ForeColor = System.Drawing.Color.White
        Me.NotifText.Location = New System.Drawing.Point(54, 0)
        Me.NotifText.Name = "NotifText"
        Me.NotifText.Size = New System.Drawing.Size(899, 53)
        Me.NotifText.TabIndex = 1
        Me.NotifText.Text = "Notification"
        Me.NotifText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Notif
        '
        Me.Panel_Notif.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_Notif.ColumnCount = 3
        Me.Panel_Notif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel_Notif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel_Notif.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel_Notif.Controls.Add(Me.NotifText, 1, 0)
        Me.Panel_Notif.Controls.Add(Me.Ikon_Notif, 0, 0)
        Me.Panel_Notif.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Notif.Location = New System.Drawing.Point(179, 511)
        Me.Panel_Notif.Name = "Panel_Notif"
        Me.Panel_Notif.RowCount = 1
        Me.Panel_Notif.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Panel_Notif.Size = New System.Drawing.Size(956, 50)
        Me.Panel_Notif.TabIndex = 83
        Me.Panel_Notif.Visible = False
        '
        'Ikon_Notif
        '
        Me.Ikon_Notif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ikon_Notif.Image = Global.Aplikasi_SI_Perpustakaan__PI_.My.Resources.Resources.Checklist
        Me.Ikon_Notif.Location = New System.Drawing.Point(3, 3)
        Me.Ikon_Notif.Name = "Ikon_Notif"
        Me.Ikon_Notif.Size = New System.Drawing.Size(45, 47)
        Me.Ikon_Notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Ikon_Notif.TabIndex = 30
        Me.Ikon_Notif.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1135, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Akun)
        Me.Controls.Add(Me.panel_Content)
        Me.Controls.Add(Me.Panel_Notif)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.panel_Title)
        Me.Controls.Add(Me.panel_Submenu)
        Me.Controls.Add(Me.panel_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1135, 547)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Perpustakaan"
        Me.panel_Submenu.ResumeLayout(False)
        Me.panel_Dashboard.ResumeLayout(False)
        Me.Panel_Pengaturan.ResumeLayout(False)
        Me.panel_Master.ResumeLayout(False)
        Me.Panel_History.ResumeLayout(False)
        Me.Panel_Transaction.ResumeLayout(False)
        Me.Panel_Akun.ResumeLayout(False)
        Me.Panel_Akun.PerformLayout()
        Me.panel_Content.ResumeLayout(False)
        Me.panel_Content.PerformLayout()
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.panel_Title.ResumeLayout(False)
        Me.panel_Menu.ResumeLayout(False)
        Me.Panel_Notif.ResumeLayout(False)
        Me.Panel_Notif.PerformLayout()
        CType(Me.Ikon_Notif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button9 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents panel_Submenu As Panel
    Friend WithEvents panel_Dashboard As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel_Pengaturan As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents panel_Master As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel_History As Panel
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_Transaction As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Panel_Akun As Panel
    Friend WithEvents Label_Username As Label
    Friend WithEvents btn_EditAkun As Button
    Friend WithEvents Label_HakAkses As Label
    Friend WithEvents Label_Nama As Label
    Friend WithEvents btn_Logout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panel_Content As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TitleBar As Panel
    Friend WithEvents btn_Akun As Button
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label_Judul As Label
    Friend WithEvents panel_Title As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents panel_Menu As Panel
    Friend WithEvents Btn_Pengaturan As Button
    Friend WithEvents Ikon_Notif As PictureBox
    Friend WithEvents NotifText As Label
    Friend WithEvents Panel_Notif As TableLayoutPanel
    Friend WithEvents UC_Petugas As UC_Petugas
    Friend WithEvents UC_Pengembalian As UC_Pengembalian
    Friend WithEvents UC_Pengaturan As UC_Pengaturan
    Friend WithEvents UC_Peminjaman As UC_Peminjaman
    Friend WithEvents UC_History As UC_History
    Friend WithEvents UC_Dashboard As UC_Dashboard
    Friend WithEvents UC_Buku As UC_Buku
    Friend WithEvents UC_Anggota As UC_Anggota
End Class
