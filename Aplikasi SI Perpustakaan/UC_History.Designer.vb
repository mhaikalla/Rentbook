<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_History
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Hapus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btn_Pengembalian = New System.Windows.Forms.Button()
        Me.btn_Peminjaman = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(282, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 81
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'tb_Search
        '
        Me.tb_Search.BackColor = System.Drawing.Color.White
        Me.tb_Search.Font = New System.Drawing.Font("Google Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Search.ForeColor = System.Drawing.Color.Black
        Me.tb_Search.Location = New System.Drawing.Point(27, 22)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(252, 26)
        Me.tb_Search.TabIndex = 80
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Btn_Hapus)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btn_Login)
        Me.Panel3.Controls.Add(Me.btn_Pengembalian)
        Me.Panel3.Controls.Add(Me.btn_Peminjaman)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(27, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(717, 293)
        Me.Panel3.TabIndex = 79
        '
        'Btn_Hapus
        '
        Me.Btn_Hapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Hapus.AutoSize = True
        Me.Btn_Hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Btn_Hapus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Btn_Hapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Btn_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Hapus.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Hapus.ForeColor = System.Drawing.Color.White
        Me.Btn_Hapus.Location = New System.Drawing.Point(620, 256)
        Me.Btn_Hapus.Name = "Btn_Hapus"
        Me.Btn_Hapus.Size = New System.Drawing.Size(91, 32)
        Me.Btn_Hapus.TabIndex = 52
        Me.Btn_Hapus.Text = "Hapus"
        Me.Btn_Hapus.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(94, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 5)
        Me.Panel1.TabIndex = 51
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.White
        Me.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.Black
        Me.btn_Login.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Login.Location = New System.Drawing.Point(464, 3)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(219, 37)
        Me.btn_Login.TabIndex = 49
        Me.btn_Login.Text = "Akun"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'btn_Pengembalian
        '
        Me.btn_Pengembalian.BackColor = System.Drawing.Color.White
        Me.btn_Pengembalian.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Pengembalian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Pengembalian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Pengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pengembalian.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pengembalian.ForeColor = System.Drawing.Color.Black
        Me.btn_Pengembalian.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Pengembalian.Location = New System.Drawing.Point(245, 3)
        Me.btn_Pengembalian.Name = "btn_Pengembalian"
        Me.btn_Pengembalian.Size = New System.Drawing.Size(219, 37)
        Me.btn_Pengembalian.TabIndex = 48
        Me.btn_Pengembalian.Text = "Pengembalian"
        Me.btn_Pengembalian.UseVisualStyleBackColor = False
        '
        'btn_Peminjaman
        '
        Me.btn_Peminjaman.BackColor = System.Drawing.Color.White
        Me.btn_Peminjaman.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Peminjaman.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Peminjaman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_Peminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Peminjaman.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Peminjaman.ForeColor = System.Drawing.Color.Black
        Me.btn_Peminjaman.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Peminjaman.Location = New System.Drawing.Point(26, 3)
        Me.btn_Peminjaman.Name = "btn_Peminjaman"
        Me.btn_Peminjaman.Size = New System.Drawing.Size(219, 37)
        Me.btn_Peminjaman.TabIndex = 47
        Me.btn_Peminjaman.Text = "Peminjaman"
        Me.btn_Peminjaman.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Google Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(6, 52)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Google Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(705, 200)
        Me.DataGridView1.TabIndex = 46
        '
        'UC_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(30, 0)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_Search)
        Me.Controls.Add(Me.Panel3)
        Me.MinimumSize = New System.Drawing.Size(771, 370)
        Me.Name = "UC_History"
        Me.Size = New System.Drawing.Size(771, 380)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Hapus As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_Pengembalian As Button
    Friend WithEvents btn_Peminjaman As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
