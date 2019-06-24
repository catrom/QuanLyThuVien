<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCapNhatThongTin
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
        Me.lbCapNhatThongTin = New System.Windows.Forms.Label()
        Me.lbMaDocGia = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbLoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.tbEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbHoVaTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLuuVaThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCapNhatThongTin
        '
        Me.lbCapNhatThongTin.AutoSize = True
        Me.lbCapNhatThongTin.BackColor = System.Drawing.Color.Transparent
        Me.lbCapNhatThongTin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCapNhatThongTin.ForeColor = System.Drawing.Color.Black
        Me.lbCapNhatThongTin.Location = New System.Drawing.Point(226, 19)
        Me.lbCapNhatThongTin.Name = "lbCapNhatThongTin"
        Me.lbCapNhatThongTin.Size = New System.Drawing.Size(231, 30)
        Me.lbCapNhatThongTin.TabIndex = 2
        Me.lbCapNhatThongTin.Text = "CẬP NHẬT THÔNG TIN"
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.BackColor = System.Drawing.Color.Gainsboro
        Me.lbMaDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaDocGia.ForeColor = System.Drawing.Color.Red
        Me.lbMaDocGia.Location = New System.Drawing.Point(156, 27)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(82, 21)
        Me.lbMaDocGia.TabIndex = 35
        Me.lbMaDocGia.Text = "MaDocGia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(46, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 21)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Ngày lập thẻ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(96, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 21)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Email:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(64, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Ngày sinh:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(87, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 21)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Địa chỉ:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(51, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Loại độc giả:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(68, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Họ và tên:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(129, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Mã độc giả:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpNgayLapThe)
        Me.GroupBox2.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox2.Controls.Add(Me.cbLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.tbEmail)
        Me.GroupBox2.Controls.Add(Me.lbMaDocGia)
        Me.GroupBox2.Controls.Add(Me.tbDiaChi)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbHoVaTen)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(71, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 340)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'cbLoaiDocGia
        '
        Me.cbLoaiDocGia.BackColor = System.Drawing.Color.White
        Me.cbLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbLoaiDocGia.FormattingEnabled = True
        Me.cbLoaiDocGia.Location = New System.Drawing.Point(160, 256)
        Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
        Me.cbLoaiDocGia.Size = New System.Drawing.Size(178, 29)
        Me.cbLoaiDocGia.TabIndex = 73
        '
        'tbEmail
        '
        Me.tbEmail.AutoSize = True
        Me.tbEmail.BackColor = System.Drawing.Color.White
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbEmail.ForeColor = System.Drawing.Color.Silver
        Me.tbEmail.HintForeColor = System.Drawing.Color.Empty
        Me.tbEmail.HintText = ""
        Me.tbEmail.isPassword = False
        Me.tbEmail.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbEmail.LineIdleColor = System.Drawing.Color.Silver
        Me.tbEmail.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbEmail.LineThickness = 2
        Me.tbEmail.Location = New System.Drawing.Point(160, 203)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(326, 36)
        Me.tbEmail.TabIndex = 72
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbDiaChi
        '
        Me.tbDiaChi.AutoSize = True
        Me.tbDiaChi.BackColor = System.Drawing.Color.White
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbDiaChi.ForeColor = System.Drawing.Color.Silver
        Me.tbDiaChi.HintForeColor = System.Drawing.Color.Empty
        Me.tbDiaChi.HintText = ""
        Me.tbDiaChi.isPassword = False
        Me.tbDiaChi.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineIdleColor = System.Drawing.Color.Silver
        Me.tbDiaChi.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineThickness = 2
        Me.tbDiaChi.Location = New System.Drawing.Point(160, 157)
        Me.tbDiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(326, 36)
        Me.tbDiaChi.TabIndex = 71
        Me.tbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbHoVaTen
        '
        Me.tbHoVaTen.AutoSize = True
        Me.tbHoVaTen.BackColor = System.Drawing.Color.White
        Me.tbHoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbHoVaTen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbHoVaTen.ForeColor = System.Drawing.Color.Silver
        Me.tbHoVaTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbHoVaTen.HintText = ""
        Me.tbHoVaTen.isPassword = False
        Me.tbHoVaTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbHoVaTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbHoVaTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbHoVaTen.LineThickness = 2
        Me.tbHoVaTen.Location = New System.Drawing.Point(160, 56)
        Me.tbHoVaTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHoVaTen.Name = "tbHoVaTen"
        Me.tbHoVaTen.Size = New System.Drawing.Size(326, 36)
        Me.tbHoVaTen.TabIndex = 70
        Me.tbHoVaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLuuVaThoat
        '
        Me.btnLuuVaThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuVaThoat.BorderRadius = 7
        Me.btnLuuVaThoat.ButtonText = "Lưu và Thoát"
        Me.btnLuuVaThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuVaThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.ForeColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuVaThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Ok_64
        Me.btnLuuVaThoat.Iconimage_right = Nothing
        Me.btnLuuVaThoat.Iconimage_right_Selected = Nothing
        Me.btnLuuVaThoat.Iconimage_Selected = Nothing
        Me.btnLuuVaThoat.IconMarginLeft = 0
        Me.btnLuuVaThoat.IconMarginRight = 0
        Me.btnLuuVaThoat.IconRightVisible = True
        Me.btnLuuVaThoat.IconRightZoom = 0R
        Me.btnLuuVaThoat.IconVisible = True
        Me.btnLuuVaThoat.IconZoom = 60.0R
        Me.btnLuuVaThoat.IsTab = False
        Me.btnLuuVaThoat.Location = New System.Drawing.Point(279, 442)
        Me.btnLuuVaThoat.Name = "btnLuuVaThoat"
        Me.btnLuuVaThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.selected = False
        Me.btnLuuVaThoat.Size = New System.Drawing.Size(141, 41)
        Me.btnLuuVaThoat.TabIndex = 38
        Me.btnLuuVaThoat.Text = "Lưu và Thoát"
        Me.btnLuuVaThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuVaThoat.Textcolor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnThoat
        '
        Me.btnThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoat.BorderRadius = 7
        Me.btnThoat.ButtonText = "Thoát"
        Me.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Enter_64
        Me.btnThoat.Iconimage_right = Nothing
        Me.btnThoat.Iconimage_right_Selected = Nothing
        Me.btnThoat.Iconimage_Selected = Nothing
        Me.btnThoat.IconMarginLeft = 0
        Me.btnThoat.IconMarginRight = 0
        Me.btnThoat.IconRightVisible = True
        Me.btnThoat.IconRightZoom = 0R
        Me.btnThoat.IconVisible = True
        Me.btnThoat.IconZoom = 60.0R
        Me.btnThoat.IsTab = False
        Me.btnThoat.Location = New System.Drawing.Point(490, 442)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(90, 41)
        Me.btnThoat.TabIndex = 39
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
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
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
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
        Me.btnLuu.Location = New System.Drawing.Point(119, 442)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(90, 41)
        Me.btnLuu.TabIndex = 37
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(160, 114)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(128, 29)
        Me.dtpNgaySinh.TabIndex = 74
        Me.dtpNgaySinh.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayLapThe.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayLapThe.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayLapThe.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLapThe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(160, 301)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(128, 29)
        Me.dtpNgayLapThe.TabIndex = 75
        Me.dtpNgayLapThe.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'ucCapNhatThongTin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLuuVaThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbCapNhatThongTin)
        Me.Name = "ucCapNhatThongTin"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCapNhatThongTin As Label
    Friend WithEvents lbMaDocGia As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLuuVaThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tbEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbHoVaTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbLoaiDocGia As ComboBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents dtpNgayLapThe As DateTimePicker
End Class
