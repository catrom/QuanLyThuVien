<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThongTinNguoiDung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucThongTinNguoiDung))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbMaNguoiDung = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbCMND = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbSoDienThoai = New System.Windows.Forms.Label()
        Me.lbVaiTro = New System.Windows.Forms.Label()
        Me.lbNgayTao = New System.Windows.Forms.Label()
        Me.dot1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnThemNguoiDung = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnTimKiemNguoiDung = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnChinhSuaThongTin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnLichSuMuonTra = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(100, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "THÔNG TIN NGƯỜI DÙNG"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(36, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Mã người dùng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Họ tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày sinh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(37, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Giới tính:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(36, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Địa chỉ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(37, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Số CMND:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(36, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(36, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Số điện thoại:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(36, 398)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 21)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Vai trò:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(36, 438)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Ngày tạo:"
        '
        'lbMaNguoiDung
        '
        Me.lbMaNguoiDung.AutoSize = True
        Me.lbMaNguoiDung.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaNguoiDung.Location = New System.Drawing.Point(162, 78)
        Me.lbMaNguoiDung.Name = "lbMaNguoiDung"
        Me.lbMaNguoiDung.Size = New System.Drawing.Size(126, 21)
        Me.lbMaNguoiDung.TabIndex = 3
        Me.lbMaNguoiDung.Text = "lbMaNguoiDung"
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbHoTen.Location = New System.Drawing.Point(101, 117)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(66, 21)
        Me.lbHoTen.TabIndex = 3
        Me.lbHoTen.Text = "lbHoTen"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbGioiTinh.Location = New System.Drawing.Point(116, 198)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(81, 21)
        Me.lbGioiTinh.TabIndex = 3
        Me.lbGioiTinh.Text = "lbGioiTinh"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgaySinh.Location = New System.Drawing.Point(126, 158)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(91, 21)
        Me.lbNgaySinh.TabIndex = 3
        Me.lbNgaySinh.Text = "lbNgaySinh"
        '
        'lbCMND
        '
        Me.lbCMND.AutoSize = True
        Me.lbCMND.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbCMND.Location = New System.Drawing.Point(125, 238)
        Me.lbCMND.Name = "lbCMND"
        Me.lbCMND.Size = New System.Drawing.Size(70, 21)
        Me.lbCMND.TabIndex = 3
        Me.lbCMND.Text = "lbCMND"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbDiaChi.Location = New System.Drawing.Point(101, 278)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(69, 21)
        Me.lbDiaChi.TabIndex = 3
        Me.lbDiaChi.Text = "lbDiaChi"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbEmail.Location = New System.Drawing.Point(93, 318)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(61, 21)
        Me.lbEmail.TabIndex = 3
        Me.lbEmail.Text = "lbEmail"
        '
        'lbSoDienThoai
        '
        Me.lbSoDienThoai.AutoSize = True
        Me.lbSoDienThoai.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbSoDienThoai.Location = New System.Drawing.Point(146, 358)
        Me.lbSoDienThoai.Name = "lbSoDienThoai"
        Me.lbSoDienThoai.Size = New System.Drawing.Size(111, 21)
        Me.lbSoDienThoai.TabIndex = 3
        Me.lbSoDienThoai.Text = "lbSoDienThoai"
        '
        'lbVaiTro
        '
        Me.lbVaiTro.AutoSize = True
        Me.lbVaiTro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbVaiTro.Location = New System.Drawing.Point(100, 398)
        Me.lbVaiTro.Name = "lbVaiTro"
        Me.lbVaiTro.Size = New System.Drawing.Size(66, 21)
        Me.lbVaiTro.TabIndex = 3
        Me.lbVaiTro.Text = "lbVaiTro"
        '
        'lbNgayTao
        '
        Me.lbNgayTao.AutoSize = True
        Me.lbNgayTao.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayTao.Location = New System.Drawing.Point(118, 438)
        Me.lbNgayTao.Name = "lbNgayTao"
        Me.lbNgayTao.Size = New System.Drawing.Size(83, 21)
        Me.lbNgayTao.TabIndex = 3
        Me.lbNgayTao.Text = "lbNgayTao"
        '
        'dot1
        '
        Me.dot1.BackgroundImage = CType(resources.GetObject("dot1.BackgroundImage"), System.Drawing.Image)
        Me.dot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dot1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.dot1.GradientBottomRight = System.Drawing.Color.Silver
        Me.dot1.GradientTopLeft = System.Drawing.Color.Silver
        Me.dot1.GradientTopRight = System.Drawing.Color.Silver
        Me.dot1.Location = New System.Drawing.Point(460, 78)
        Me.dot1.Name = "dot1"
        Me.dot1.Quality = 10
        Me.dot1.Size = New System.Drawing.Size(5, 387)
        Me.dot1.TabIndex = 13
        '
        'btnThemNguoiDung
        '
        Me.btnThemNguoiDung.BackColor = System.Drawing.Color.LightGray
        Me.btnThemNguoiDung.color = System.Drawing.Color.LightGray
        Me.btnThemNguoiDung.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnThemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemNguoiDung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNguoiDung.ForeColor = System.Drawing.Color.Black
        Me.btnThemNguoiDung.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Add_User_Male_64
        Me.btnThemNguoiDung.ImagePosition = 5
        Me.btnThemNguoiDung.ImageZoom = 20
        Me.btnThemNguoiDung.LabelPosition = 34
        Me.btnThemNguoiDung.LabelText = "Thêm người dùng"
        Me.btnThemNguoiDung.Location = New System.Drawing.Point(472, 87)
        Me.btnThemNguoiDung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThemNguoiDung.Name = "btnThemNguoiDung"
        Me.btnThemNguoiDung.Size = New System.Drawing.Size(203, 85)
        Me.btnThemNguoiDung.TabIndex = 14
        '
        'btnTimKiemNguoiDung
        '
        Me.btnTimKiemNguoiDung.BackColor = System.Drawing.Color.LightGray
        Me.btnTimKiemNguoiDung.color = System.Drawing.Color.LightGray
        Me.btnTimKiemNguoiDung.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnTimKiemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimKiemNguoiDung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiemNguoiDung.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiemNguoiDung.Image = Global.QLTVGUI.My.Resources.Resources.icons8_find_user_male_48
        Me.btnTimKiemNguoiDung.ImagePosition = 5
        Me.btnTimKiemNguoiDung.ImageZoom = 20
        Me.btnTimKiemNguoiDung.LabelPosition = 34
        Me.btnTimKiemNguoiDung.LabelText = "Tìm kiếm người dùng"
        Me.btnTimKiemNguoiDung.Location = New System.Drawing.Point(472, 182)
        Me.btnTimKiemNguoiDung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimKiemNguoiDung.Name = "btnTimKiemNguoiDung"
        Me.btnTimKiemNguoiDung.Size = New System.Drawing.Size(203, 85)
        Me.btnTimKiemNguoiDung.TabIndex = 14
        '
        'btnChinhSuaThongTin
        '
        Me.btnChinhSuaThongTin.BackColor = System.Drawing.Color.LightGray
        Me.btnChinhSuaThongTin.color = System.Drawing.Color.LightGray
        Me.btnChinhSuaThongTin.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnChinhSuaThongTin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChinhSuaThongTin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChinhSuaThongTin.ForeColor = System.Drawing.Color.Black
        Me.btnChinhSuaThongTin.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Term_64
        Me.btnChinhSuaThongTin.ImagePosition = 5
        Me.btnChinhSuaThongTin.ImageZoom = 20
        Me.btnChinhSuaThongTin.LabelPosition = 34
        Me.btnChinhSuaThongTin.LabelText = "Chỉnh sửa thông tin"
        Me.btnChinhSuaThongTin.Location = New System.Drawing.Point(472, 277)
        Me.btnChinhSuaThongTin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChinhSuaThongTin.Name = "btnChinhSuaThongTin"
        Me.btnChinhSuaThongTin.Size = New System.Drawing.Size(203, 85)
        Me.btnChinhSuaThongTin.TabIndex = 14
        '
        'btnLichSuMuonTra
        '
        Me.btnLichSuMuonTra.BackColor = System.Drawing.Color.LightGray
        Me.btnLichSuMuonTra.color = System.Drawing.Color.LightGray
        Me.btnLichSuMuonTra.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnLichSuMuonTra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLichSuMuonTra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLichSuMuonTra.ForeColor = System.Drawing.Color.Black
        Me.btnLichSuMuonTra.Image = Global.QLTVGUI.My.Resources.Resources.icons8_update_48
        Me.btnLichSuMuonTra.ImagePosition = 5
        Me.btnLichSuMuonTra.ImageZoom = 20
        Me.btnLichSuMuonTra.LabelPosition = 34
        Me.btnLichSuMuonTra.LabelText = "Lịch sử mượn trả sách"
        Me.btnLichSuMuonTra.Location = New System.Drawing.Point(472, 372)
        Me.btnLichSuMuonTra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLichSuMuonTra.Name = "btnLichSuMuonTra"
        Me.btnLichSuMuonTra.Size = New System.Drawing.Size(203, 85)
        Me.btnLichSuMuonTra.TabIndex = 14
        '
        'ucThongTinNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLichSuMuonTra)
        Me.Controls.Add(Me.btnChinhSuaThongTin)
        Me.Controls.Add(Me.btnTimKiemNguoiDung)
        Me.Controls.Add(Me.btnThemNguoiDung)
        Me.Controls.Add(Me.dot1)
        Me.Controls.Add(Me.lbNgayTao)
        Me.Controls.Add(Me.lbVaiTro)
        Me.Controls.Add(Me.lbSoDienThoai)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbCMND)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbHoTen)
        Me.Controls.Add(Me.lbMaNguoiDung)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucThongTinNguoiDung"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbMaNguoiDung As Label
    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbCMND As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbSoDienThoai As Label
    Friend WithEvents lbVaiTro As Label
    Friend WithEvents lbNgayTao As Label
    Friend WithEvents dot1 As Bunifu.Framework.UI.BunifuGradientPanel
    Public WithEvents btnThemNguoiDung As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnTimKiemNguoiDung As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnChinhSuaThongTin As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnLichSuMuonTra As Bunifu.Framework.UI.BunifuTileButton
End Class
