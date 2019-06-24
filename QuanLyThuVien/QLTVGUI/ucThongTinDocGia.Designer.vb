<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThongTinDocGia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbMaDocGia = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbNgayLapThe = New System.Windows.Forms.Label()
        Me.lbLoaiDocGia = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbHoVaTen = New System.Windows.Forms.Label()
        Me.btnTroVe = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSua = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(243, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "THÔNG TIN ĐỘC GIẢ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMaDocGia)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 340)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.BackColor = System.Drawing.Color.Gainsboro
        Me.lbMaDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaDocGia.ForeColor = System.Drawing.Color.Red
        Me.lbMaDocGia.Location = New System.Drawing.Point(167, 28)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(82, 21)
        Me.lbMaDocGia.TabIndex = 23
        Me.lbMaDocGia.Text = "MaDocGia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(46, 291)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Ngày lập thẻ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(96, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 21)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Email:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(64, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Ngày sinh:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(87, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Địa chỉ:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(51, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 21)
        Me.Label11.TabIndex = 18
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
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Họ và tên:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(58, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Mã độc giả:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbNgayLapThe)
        Me.GroupBox2.Controls.Add(Me.lbLoaiDocGia)
        Me.GroupBox2.Controls.Add(Me.lbEmail)
        Me.GroupBox2.Controls.Add(Me.lbDiaChi)
        Me.GroupBox2.Controls.Add(Me.lbNgaySinh)
        Me.GroupBox2.Controls.Add(Me.lbHoVaTen)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 340)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'lbNgayLapThe
        '
        Me.lbNgayLapThe.AutoSize = True
        Me.lbNgayLapThe.BackColor = System.Drawing.Color.Transparent
        Me.lbNgayLapThe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayLapThe.ForeColor = System.Drawing.Color.Black
        Me.lbNgayLapThe.Location = New System.Drawing.Point(167, 291)
        Me.lbNgayLapThe.Name = "lbNgayLapThe"
        Me.lbNgayLapThe.Size = New System.Drawing.Size(98, 21)
        Me.lbNgayLapThe.TabIndex = 25
        Me.lbNgayLapThe.Text = "Ngày lập thẻ"
        '
        'lbLoaiDocGia
        '
        Me.lbLoaiDocGia.AutoSize = True
        Me.lbLoaiDocGia.BackColor = System.Drawing.Color.Transparent
        Me.lbLoaiDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoaiDocGia.ForeColor = System.Drawing.Color.Black
        Me.lbLoaiDocGia.Location = New System.Drawing.Point(165, 247)
        Me.lbLoaiDocGia.Name = "lbLoaiDocGia"
        Me.lbLoaiDocGia.Size = New System.Drawing.Size(93, 21)
        Me.lbLoaiDocGia.TabIndex = 24
        Me.lbLoaiDocGia.Text = "Loại độc giả"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.BackColor = System.Drawing.Color.Transparent
        Me.lbEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.ForeColor = System.Drawing.Color.Black
        Me.lbEmail.Location = New System.Drawing.Point(170, 203)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(48, 21)
        Me.lbEmail.TabIndex = 23
        Me.lbEmail.Text = "Email"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.BackColor = System.Drawing.Color.Transparent
        Me.lbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiaChi.ForeColor = System.Drawing.Color.Black
        Me.lbDiaChi.Location = New System.Drawing.Point(170, 159)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(57, 21)
        Me.lbDiaChi.TabIndex = 22
        Me.lbDiaChi.Text = "Địa chỉ"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.BackColor = System.Drawing.Color.Transparent
        Me.lbNgaySinh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgaySinh.ForeColor = System.Drawing.Color.Black
        Me.lbNgaySinh.Location = New System.Drawing.Point(170, 115)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(80, 21)
        Me.lbNgaySinh.TabIndex = 21
        Me.lbNgaySinh.Text = "Ngày sinh"
        '
        'lbHoVaTen
        '
        Me.lbHoVaTen.AutoSize = True
        Me.lbHoVaTen.BackColor = System.Drawing.Color.Transparent
        Me.lbHoVaTen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoVaTen.ForeColor = System.Drawing.Color.Black
        Me.lbHoVaTen.Location = New System.Drawing.Point(170, 71)
        Me.lbHoVaTen.Name = "lbHoVaTen"
        Me.lbHoVaTen.Size = New System.Drawing.Size(76, 21)
        Me.lbHoVaTen.TabIndex = 20
        Me.lbHoVaTen.Text = "Họ và tên"
        '
        'btnTroVe
        '
        Me.btnTroVe.Activecolor = System.Drawing.Color.Silver
        Me.btnTroVe.BackColor = System.Drawing.Color.LightGray
        Me.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTroVe.BorderRadius = 7
        Me.btnTroVe.ButtonText = "Thoát"
        Me.btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTroVe.DisabledColor = System.Drawing.Color.Silver
        Me.btnTroVe.ForeColor = System.Drawing.Color.Black
        Me.btnTroVe.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTroVe.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Enter_64
        Me.btnTroVe.Iconimage_right = Nothing
        Me.btnTroVe.Iconimage_right_Selected = Nothing
        Me.btnTroVe.Iconimage_Selected = Nothing
        Me.btnTroVe.IconMarginLeft = 0
        Me.btnTroVe.IconMarginRight = 0
        Me.btnTroVe.IconRightVisible = True
        Me.btnTroVe.IconRightZoom = 0R
        Me.btnTroVe.IconVisible = True
        Me.btnTroVe.IconZoom = 60.0R
        Me.btnTroVe.IsTab = False
        Me.btnTroVe.Location = New System.Drawing.Point(487, 447)
        Me.btnTroVe.Name = "btnTroVe"
        Me.btnTroVe.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTroVe.OnHovercolor = System.Drawing.Color.Gray
        Me.btnTroVe.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnTroVe.selected = False
        Me.btnTroVe.Size = New System.Drawing.Size(108, 41)
        Me.btnTroVe.TabIndex = 15
        Me.btnTroVe.Text = "Thoát"
        Me.btnTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTroVe.Textcolor = System.Drawing.Color.Black
        Me.btnTroVe.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnSua
        '
        Me.btnSua.Activecolor = System.Drawing.Color.Silver
        Me.btnSua.BackColor = System.Drawing.Color.LightGray
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.BorderRadius = 7
        Me.btnSua.ButtonText = "Sửa"
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.DisabledColor = System.Drawing.Color.Silver
        Me.btnSua.ForeColor = System.Drawing.Color.Black
        Me.btnSua.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSua.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_update_48
        Me.btnSua.Iconimage_right = Nothing
        Me.btnSua.Iconimage_right_Selected = Nothing
        Me.btnSua.Iconimage_Selected = Nothing
        Me.btnSua.IconMarginLeft = 0
        Me.btnSua.IconMarginRight = 0
        Me.btnSua.IconRightVisible = True
        Me.btnSua.IconRightZoom = 0R
        Me.btnSua.IconVisible = True
        Me.btnSua.IconZoom = 60.0R
        Me.btnSua.IsTab = False
        Me.btnSua.Location = New System.Drawing.Point(120, 447)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Normalcolor = System.Drawing.Color.LightGray
        Me.btnSua.OnHovercolor = System.Drawing.Color.Gray
        Me.btnSua.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnSua.selected = False
        Me.btnSua.Size = New System.Drawing.Size(90, 41)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSua.Textcolor = System.Drawing.Color.Black
        Me.btnSua.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnXoa
        '
        Me.btnXoa.Activecolor = System.Drawing.Color.Silver
        Me.btnXoa.BackColor = System.Drawing.Color.LightGray
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.BorderRadius = 7
        Me.btnXoa.ButtonText = "Xoá"
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.DisabledColor = System.Drawing.Color.Silver
        Me.btnXoa.ForeColor = System.Drawing.Color.Black
        Me.btnXoa.Iconcolor = System.Drawing.Color.Transparent
        Me.btnXoa.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Close_Window_64
        Me.btnXoa.Iconimage_right = Nothing
        Me.btnXoa.Iconimage_right_Selected = Nothing
        Me.btnXoa.Iconimage_Selected = Nothing
        Me.btnXoa.IconMarginLeft = 0
        Me.btnXoa.IconMarginRight = 0
        Me.btnXoa.IconRightVisible = True
        Me.btnXoa.IconRightZoom = 0R
        Me.btnXoa.IconVisible = True
        Me.btnXoa.IconZoom = 60.0R
        Me.btnXoa.IsTab = False
        Me.btnXoa.Location = New System.Drawing.Point(308, 447)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Normalcolor = System.Drawing.Color.LightGray
        Me.btnXoa.OnHovercolor = System.Drawing.Color.Gray
        Me.btnXoa.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnXoa.selected = False
        Me.btnXoa.Size = New System.Drawing.Size(90, 41)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnXoa.Textcolor = System.Drawing.Color.Black
        Me.btnXoa.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucThongTinDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTroVe)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucThongTinDocGia"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbMaDocGia As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbNgayLapThe As Label
    Friend WithEvents lbLoaiDocGia As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbHoVaTen As Label
    Friend WithEvents btnSua As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTroVe As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuFlatButton
End Class
