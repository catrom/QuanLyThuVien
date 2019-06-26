<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucChoMuonSach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuuVaxuat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbNgayMuon = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbMaPhieuMuon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbThuThu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbHoTenDocGia = New System.Windows.Forms.Label()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaCuonSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenCuonSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTong = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbThemMaSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btAddTheLoai = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgDSCanMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTroVe = New System.Windows.Forms.Label()
        Me.lbXoaDanhSach = New System.Windows.Forms.Label()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDSCanMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(249, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PHIẾU MƯỢN SÁCH"
        '
        'tbMaDocGia
        '
        Me.tbMaDocGia.AutoSize = True
        Me.tbMaDocGia.BackColor = System.Drawing.Color.White
        Me.tbMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaDocGia.ForeColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaDocGia.HintText = ""
        Me.tbMaDocGia.isPassword = False
        Me.tbMaDocGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineThickness = 2
        Me.tbMaDocGia.Location = New System.Drawing.Point(539, 119)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.Size = New System.Drawing.Size(132, 36)
        Me.tbMaDocGia.TabIndex = 1
        Me.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(442, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Mã độc giả:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(61, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 21)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Ngày mượn:"
        '
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Lưu"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Ok_64
        Me.btnLuu.Iconimage_right = Nothing
        Me.btnLuu.Iconimage_right_Selected = Nothing
        Me.btnLuu.Iconimage_Selected = Nothing
        Me.btnLuu.IconMarginLeft = 0
        Me.btnLuu.IconMarginRight = 0
        Me.btnLuu.IconRightVisible = True
        Me.btnLuu.IconRightZoom = 0R
        Me.btnLuu.IconVisible = True
        Me.btnLuu.IconZoom = 60.0R
        Me.btnLuu.IsTab = False
        Me.btnLuu.Location = New System.Drawing.Point(428, 625)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(103, 41)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnLuuVaxuat
        '
        Me.btnLuuVaxuat.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuVaxuat.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuVaxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuVaxuat.BorderRadius = 7
        Me.btnLuuVaxuat.ButtonText = "Lưu và Xuất "
        Me.btnLuuVaxuat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuVaxuat.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuVaxuat.ForeColor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuVaxuat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnLuuVaxuat.Iconimage_right = Nothing
        Me.btnLuuVaxuat.Iconimage_right_Selected = Nothing
        Me.btnLuuVaxuat.Iconimage_Selected = Nothing
        Me.btnLuuVaxuat.IconMarginLeft = 0
        Me.btnLuuVaxuat.IconMarginRight = 0
        Me.btnLuuVaxuat.IconRightVisible = True
        Me.btnLuuVaxuat.IconRightZoom = 0R
        Me.btnLuuVaxuat.IconVisible = True
        Me.btnLuuVaxuat.IconZoom = 60.0R
        Me.btnLuuVaxuat.IsTab = False
        Me.btnLuuVaxuat.Location = New System.Drawing.Point(167, 625)
        Me.btnLuuVaxuat.Name = "btnLuuVaxuat"
        Me.btnLuuVaxuat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaxuat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaxuat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.selected = False
        Me.btnLuuVaxuat.Size = New System.Drawing.Size(171, 41)
        Me.btnLuuVaxuat.TabIndex = 4
        Me.btnLuuVaxuat.Text = "Lưu và Xuất "
        Me.btnLuuVaxuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuVaxuat.Textcolor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'lbNgayMuon
        '
        Me.lbNgayMuon.AutoSize = True
        Me.lbNgayMuon.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayMuon.ForeColor = System.Drawing.Color.Blue
        Me.lbNgayMuon.Location = New System.Drawing.Point(163, 98)
        Me.lbNgayMuon.Name = "lbNgayMuon"
        Me.lbNgayMuon.Size = New System.Drawing.Size(101, 21)
        Me.lbNgayMuon.TabIndex = 86
        Me.lbNgayMuon.Text = "lbNgayMuon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Mã phiếu mượn:"
        '
        'lbMaPhieuMuon
        '
        Me.lbMaPhieuMuon.AutoSize = True
        Me.lbMaPhieuMuon.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaPhieuMuon.ForeColor = System.Drawing.Color.Red
        Me.lbMaPhieuMuon.Location = New System.Drawing.Point(163, 66)
        Me.lbMaPhieuMuon.Name = "lbMaPhieuMuon"
        Me.lbMaPhieuMuon.Size = New System.Drawing.Size(125, 21)
        Me.lbMaPhieuMuon.TabIndex = 86
        Me.lbMaPhieuMuon.Text = "lbMaPhieuMuon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Người lập phiếu:"
        '
        'lbThuThu
        '
        Me.lbThuThu.AutoSize = True
        Me.lbThuThu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbThuThu.ForeColor = System.Drawing.Color.Blue
        Me.lbThuThu.Location = New System.Drawing.Point(163, 128)
        Me.lbThuThu.Name = "lbThuThu"
        Me.lbThuThu.Size = New System.Drawing.Size(75, 21)
        Me.lbThuThu.TabIndex = 86
        Me.lbThuThu.Text = "lbThuThu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 21)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "-THÔNG TIN MƯỢN SÁCH-"
        '
        'lbHoTenDocGia
        '
        Me.lbHoTenDocGia.AutoSize = True
        Me.lbHoTenDocGia.BackColor = System.Drawing.Color.Transparent
        Me.lbHoTenDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoTenDocGia.ForeColor = System.Drawing.Color.Black
        Me.lbHoTenDocGia.Location = New System.Drawing.Point(240, 177)
        Me.lbHoTenDocGia.Name = "lbHoTenDocGia"
        Me.lbHoTenDocGia.Size = New System.Drawing.Size(116, 21)
        Me.lbHoTenDocGia.TabIndex = 74
        Me.lbHoTenDocGia.Text = "lbHoTenDocGia"
        '
        'dgDanhSach
        '
        Me.dgDanhSach.AllowUserToAddRows = False
        Me.dgDanhSach.AllowUserToDeleteRows = False
        Me.dgDanhSach.AllowUserToResizeColumns = False
        Me.dgDanhSach.AllowUserToResizeRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaCuonSach, Me.TenCuonSach, Me.NgayMuon})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSach.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgDanhSach.DoubleBuffered = True
        Me.dgDanhSach.EnableHeadersVisualStyles = False
        Me.dgDanhSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.Location = New System.Drawing.Point(65, 211)
        Me.dgDanhSach.Name = "dgDanhSach"
        Me.dgDanhSach.ReadOnly = True
        Me.dgDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgDanhSach.Size = New System.Drawing.Size(583, 109)
        Me.dgDanhSach.TabIndex = 90
        '
        'MaCuonSach
        '
        Me.MaCuonSach.HeaderText = "Mã cuốn sách"
        Me.MaCuonSach.Name = "MaCuonSach"
        Me.MaCuonSach.ReadOnly = True
        Me.MaCuonSach.Width = 120
        '
        'TenCuonSach
        '
        Me.TenCuonSach.HeaderText = "Tên cuốn sách"
        Me.TenCuonSach.Name = "TenCuonSach"
        Me.TenCuonSach.ReadOnly = True
        Me.TenCuonSach.Width = 270
        '
        'NgayMuon
        '
        Me.NgayMuon.HeaderText = "Ngày mượn"
        Me.NgayMuon.Name = "NgayMuon"
        Me.NgayMuon.ReadOnly = True
        Me.NgayMuon.Width = 150
        '
        'lbThongBao
        '
        Me.lbThongBao.BackColor = System.Drawing.Color.Transparent
        Me.lbThongBao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongBao.ForeColor = System.Drawing.Color.Red
        Me.lbThongBao.Location = New System.Drawing.Point(68, 329)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(463, 21)
        Me.lbThongBao.TabIndex = 74
        Me.lbThongBao.Text = "lbThongBao"
        Me.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(536, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Tổng số:"
        '
        'lbTong
        '
        Me.lbTong.AutoSize = True
        Me.lbTong.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTong.ForeColor = System.Drawing.Color.Blue
        Me.lbTong.Location = New System.Drawing.Point(601, 332)
        Me.lbTong.Name = "lbTong"
        Me.lbTong.Size = New System.Drawing.Size(48, 17)
        Me.lbTong.TabIndex = 86
        Me.lbTong.Text = "lbTong"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 21)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "-CHI TIẾT PHIẾU MƯỢN SÁCH-"
        '
        'tbThemMaSach
        '
        Me.tbThemMaSach.AutoSize = True
        Me.tbThemMaSach.BackColor = System.Drawing.Color.White
        Me.tbThemMaSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbThemMaSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbThemMaSach.ForeColor = System.Drawing.Color.Silver
        Me.tbThemMaSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbThemMaSach.HintText = ""
        Me.tbThemMaSach.isPassword = False
        Me.tbThemMaSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbThemMaSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbThemMaSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbThemMaSach.LineThickness = 2
        Me.tbThemMaSach.Location = New System.Drawing.Point(185, 396)
        Me.tbThemMaSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbThemMaSach.Name = "tbThemMaSach"
        Me.tbThemMaSach.Size = New System.Drawing.Size(132, 36)
        Me.tbThemMaSach.TabIndex = 1
        Me.tbThemMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(61, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Mã cuốn sách:"
        '
        'btAddTheLoai
        '
        Me.btAddTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.btAddTheLoai.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btAddTheLoai.ImageActive = Nothing
        Me.btAddTheLoai.Location = New System.Drawing.Point(329, 398)
        Me.btAddTheLoai.Name = "btAddTheLoai"
        Me.btAddTheLoai.Size = New System.Drawing.Size(30, 33)
        Me.btAddTheLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btAddTheLoai.TabIndex = 91
        Me.btAddTheLoai.TabStop = False
        Me.btAddTheLoai.Zoom = 10
        '
        'dgDSCanMuon
        '
        Me.dgDSCanMuon.AllowUserToAddRows = False
        Me.dgDSCanMuon.AllowUserToResizeColumns = False
        Me.dgDSCanMuon.AllowUserToResizeRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgDSCanMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDSCanMuon.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDSCanMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDSCanMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSCanMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgDSCanMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSCanMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.NhaXuatBan, Me.TacGia, Me.TheLoai, Me.TriGia})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDSCanMuon.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgDSCanMuon.DoubleBuffered = True
        Me.dgDSCanMuon.EnableHeadersVisualStyles = False
        Me.dgDSCanMuon.GridColor = System.Drawing.Color.Gray
        Me.dgDSCanMuon.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDSCanMuon.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.Location = New System.Drawing.Point(65, 449)
        Me.dgDSCanMuon.Name = "dgDSCanMuon"
        Me.dgDSCanMuon.ReadOnly = True
        Me.dgDSCanMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSCanMuon.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgDSCanMuon.Size = New System.Drawing.Size(583, 145)
        Me.dgDSCanMuon.TabIndex = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'NhaXuatBan
        '
        Me.NhaXuatBan.HeaderText = "NXB"
        Me.NhaXuatBan.Name = "NhaXuatBan"
        Me.NhaXuatBan.ReadOnly = True
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác giả"
        Me.TacGia.Name = "TacGia"
        Me.TacGia.ReadOnly = True
        '
        'TheLoai
        '
        Me.TheLoai.HeaderText = "Thể loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.ReadOnly = True
        '
        'TriGia
        '
        Me.TriGia.HeaderText = "Trị giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(11, 21)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(66, 17)
        Me.lbTroVe.TabIndex = 92
        Me.lbTroVe.Text = "<< Trở về"
        '
        'lbXoaDanhSach
        '
        Me.lbXoaDanhSach.AutoSize = True
        Me.lbXoaDanhSach.BackColor = System.Drawing.Color.Transparent
        Me.lbXoaDanhSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbXoaDanhSach.ForeColor = System.Drawing.Color.Blue
        Me.lbXoaDanhSach.Location = New System.Drawing.Point(539, 407)
        Me.lbXoaDanhSach.Name = "lbXoaDanhSach"
        Me.lbXoaDanhSach.Size = New System.Drawing.Size(110, 21)
        Me.lbXoaDanhSach.TabIndex = 92
        Me.lbXoaDanhSach.Text = "Xoá danh sách"
        '
        'ucChoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbXoaDanhSach)
        Me.Controls.Add(Me.lbTroVe)
        Me.Controls.Add(Me.btAddTheLoai)
        Me.Controls.Add(Me.dgDSCanMuon)
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.lbMaPhieuMuon)
        Me.Controls.Add(Me.lbTong)
        Me.Controls.Add(Me.lbThuThu)
        Me.Controls.Add(Me.lbNgayMuon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbThongBao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbHoTenDocGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbThemMaSach)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbMaDocGia)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnLuuVaxuat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucChoMuonSach"
        Me.Size = New System.Drawing.Size(700, 683)
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDSCanMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuuVaxuat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMaDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbNgayMuon As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbMaPhieuMuon As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbThuThu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbHoTenDocGia As Label
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbThongBao As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTong As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbThemMaSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents btAddTheLoai As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgDSCanMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NhaXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents lbTroVe As Label
    Friend WithEvents MaCuonSach As DataGridViewTextBoxColumn
    Friend WithEvents TenCuonSach As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuon As DataGridViewTextBoxColumn
    Friend WithEvents lbXoaDanhSach As Label
End Class
