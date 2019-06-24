<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTimDocGia
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbTimDocGia = New System.Windows.Forms.Label()
        Me.gbTimDocGia = New System.Windows.Forms.GroupBox()
        Me.tbEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbTenDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbLoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.dgDanhSachDG = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaDocGia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TenDocGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiDocGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLapThe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTraCuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.gbTimDocGia.SuspendLayout()
        CType(Me.dgDanhSachDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTimDocGia
        '
        Me.lbTimDocGia.AutoSize = True
        Me.lbTimDocGia.BackColor = System.Drawing.Color.Transparent
        Me.lbTimDocGia.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTimDocGia.ForeColor = System.Drawing.Color.Black
        Me.lbTimDocGia.Location = New System.Drawing.Point(262, 12)
        Me.lbTimDocGia.Name = "lbTimDocGia"
        Me.lbTimDocGia.Size = New System.Drawing.Size(139, 30)
        Me.lbTimDocGia.TabIndex = 27
        Me.lbTimDocGia.Text = "TÌM ĐỘC GIẢ"
        '
        'gbTimDocGia
        '
        Me.gbTimDocGia.Controls.Add(Me.tbEmail)
        Me.gbTimDocGia.Controls.Add(Me.tbTenDocGia)
        Me.gbTimDocGia.Controls.Add(Me.Label1)
        Me.gbTimDocGia.Controls.Add(Me.tbMaDocGia)
        Me.gbTimDocGia.Controls.Add(Me.label)
        Me.gbTimDocGia.Controls.Add(Me.Label6)
        Me.gbTimDocGia.Controls.Add(Me.Label10)
        Me.gbTimDocGia.Controls.Add(Me.cbLoaiDocGia)
        Me.gbTimDocGia.Location = New System.Drawing.Point(21, 45)
        Me.gbTimDocGia.Name = "gbTimDocGia"
        Me.gbTimDocGia.Size = New System.Drawing.Size(659, 141)
        Me.gbTimDocGia.TabIndex = 70
        Me.gbTimDocGia.TabStop = False
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
        Me.tbEmail.Location = New System.Drawing.Point(405, 26)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(226, 36)
        Me.tbEmail.TabIndex = 73
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbTenDocGia
        '
        Me.tbTenDocGia.AutoSize = True
        Me.tbTenDocGia.BackColor = System.Drawing.Color.White
        Me.tbTenDocGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTenDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbTenDocGia.ForeColor = System.Drawing.Color.Silver
        Me.tbTenDocGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbTenDocGia.HintText = ""
        Me.tbTenDocGia.isPassword = False
        Me.tbTenDocGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTenDocGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTenDocGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTenDocGia.LineThickness = 2
        Me.tbTenDocGia.Location = New System.Drawing.Point(123, 76)
        Me.tbTenDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTenDocGia.Name = "tbTenDocGia"
        Me.tbTenDocGia.Size = New System.Drawing.Size(139, 36)
        Me.tbTenDocGia.TabIndex = 71
        Me.tbTenDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Tên độc giả:"
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
        Me.tbMaDocGia.Location = New System.Drawing.Point(123, 26)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.Size = New System.Drawing.Size(139, 36)
        Me.tbMaDocGia.TabIndex = 69
        Me.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Black
        Me.label.Location = New System.Drawing.Point(28, 35)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(89, 21)
        Me.label.TabIndex = 68
        Me.label.Text = "Mã độc giả:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(347, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(347, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 21)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Loại độc giả: "
        '
        'cbLoaiDocGia
        '
        Me.cbLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoaiDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbLoaiDocGia.FormattingEnabled = True
        Me.cbLoaiDocGia.Location = New System.Drawing.Point(453, 78)
        Me.cbLoaiDocGia.Name = "cbLoaiDocGia"
        Me.cbLoaiDocGia.Size = New System.Drawing.Size(178, 29)
        Me.cbLoaiDocGia.TabIndex = 64
        '
        'dgDanhSachDG
        '
        Me.dgDanhSachDG.AllowUserToAddRows = False
        Me.dgDanhSachDG.AllowUserToDeleteRows = False
        Me.dgDanhSachDG.AllowUserToResizeColumns = False
        Me.dgDanhSachDG.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSachDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDanhSachDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSachDG.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSachDG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSachDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDanhSachDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSachDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDocGia, Me.TenDocGia, Me.NgaySinh, Me.DiaChi, Me.Email, Me.LoaiDocGia, Me.NgayLapThe})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSachDG.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgDanhSachDG.DoubleBuffered = True
        Me.dgDanhSachDG.EnableHeadersVisualStyles = False
        Me.dgDanhSachDG.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSachDG.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSachDG.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSachDG.Location = New System.Drawing.Point(21, 277)
        Me.dgDanhSachDG.Name = "dgDanhSachDG"
        Me.dgDanhSachDG.ReadOnly = True
        Me.dgDanhSachDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachDG.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSachDG.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgDanhSachDG.Size = New System.Drawing.Size(659, 177)
        Me.dgDanhSachDG.TabIndex = 73
        '
        'MaDocGia
        '
        Me.MaDocGia.FillWeight = 68.438!
        Me.MaDocGia.HeaderText = "Mã Độc Giả"
        Me.MaDocGia.Name = "MaDocGia"
        Me.MaDocGia.ReadOnly = True
        Me.MaDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MaDocGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MaDocGia.Width = 85
        '
        'TenDocGia
        '
        Me.TenDocGia.HeaderText = "Tên Độc Giả"
        Me.TenDocGia.Name = "TenDocGia"
        Me.TenDocGia.ReadOnly = True
        Me.TenDocGia.Width = 150
        '
        'NgaySinh
        '
        Me.NgaySinh.FillWeight = 90.76328!
        Me.NgaySinh.HeaderText = "Ngày Sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        Me.NgaySinh.Width = 95
        '
        'DiaChi
        '
        Me.DiaChi.FillWeight = 93.9663!
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        Me.DiaChi.Width = 200
        '
        'Email
        '
        Me.Email.FillWeight = 74.59055!
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 150
        '
        'LoaiDocGia
        '
        Me.LoaiDocGia.HeaderText = "Loại Độc Giả"
        Me.LoaiDocGia.Name = "LoaiDocGia"
        Me.LoaiDocGia.ReadOnly = True
        Me.LoaiDocGia.Width = 85
        '
        'NgayLapThe
        '
        Me.NgayLapThe.HeaderText = "Ngày Lập Thẻ"
        Me.NgayLapThe.Name = "NgayLapThe"
        Me.NgayLapThe.ReadOnly = True
        Me.NgayLapThe.Width = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 21)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Kết quả tra cứu:"
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
        Me.btnThoat.Location = New System.Drawing.Point(279, 479)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(140, 41)
        Me.btnThoat.TabIndex = 74
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Activecolor = System.Drawing.Color.Silver
        Me.btnTraCuu.BackColor = System.Drawing.Color.LightGray
        Me.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTraCuu.BorderRadius = 7
        Me.btnTraCuu.ButtonText = "Tra cứu"
        Me.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTraCuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnTraCuu.ForeColor = System.Drawing.Color.Black
        Me.btnTraCuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTraCuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Search1_64
        Me.btnTraCuu.Iconimage_right = Nothing
        Me.btnTraCuu.Iconimage_right_Selected = Nothing
        Me.btnTraCuu.Iconimage_Selected = Nothing
        Me.btnTraCuu.IconMarginLeft = 0
        Me.btnTraCuu.IconMarginRight = 0
        Me.btnTraCuu.IconRightVisible = True
        Me.btnTraCuu.IconRightZoom = 0R
        Me.btnTraCuu.IconVisible = True
        Me.btnTraCuu.IconZoom = 60.0R
        Me.btnTraCuu.IsTab = False
        Me.btnTraCuu.Location = New System.Drawing.Point(285, 207)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTraCuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnTraCuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnTraCuu.selected = False
        Me.btnTraCuu.Size = New System.Drawing.Size(116, 41)
        Me.btnTraCuu.TabIndex = 71
        Me.btnTraCuu.Text = "Tra cứu"
        Me.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTraCuu.Textcolor = System.Drawing.Color.Black
        Me.btnTraCuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucTimDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.dgDanhSachDG)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnTraCuu)
        Me.Controls.Add(Me.gbTimDocGia)
        Me.Controls.Add(Me.lbTimDocGia)
        Me.Name = "ucTimDocGia"
        Me.Size = New System.Drawing.Size(700, 545)
        Me.gbTimDocGia.ResumeLayout(False)
        Me.gbTimDocGia.PerformLayout()
        CType(Me.dgDanhSachDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTimDocGia As Label
    Friend WithEvents gbTimDocGia As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbLoaiDocGia As ComboBox
    Friend WithEvents label As Label
    Friend WithEvents tbTenDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnTraCuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgDanhSachDG As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label11 As Label
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tbMaDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MaDocGia As DataGridViewButtonColumn
    Friend WithEvents TenDocGia As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents LoaiDocGia As DataGridViewTextBoxColumn
    Friend WithEvents NgayLapThe As DataGridViewTextBoxColumn
End Class
