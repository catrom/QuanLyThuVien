<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPhieuNhap
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbNhaCungCap = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbNguoiNhap = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbMaPhieuNhap = New System.Windows.Forms.Label()
        Me.lbTroVe = New System.Windows.Forms.Label()
        Me.btnThemDauSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaNguoiDung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(258, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PHIẾU NHẬP SÁCH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbNhaCungCap)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbNguoiNhap)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbNgayNhap)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbMaPhieuNhap)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 100)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(299, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Người nhập:"
        '
        'cbNhaCungCap
        '
        Me.cbNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNhaCungCap.DropDownHeight = 100
        Me.cbNhaCungCap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbNhaCungCap.FormattingEnabled = True
        Me.cbNhaCungCap.IntegralHeight = False
        Me.cbNhaCungCap.Location = New System.Drawing.Point(421, 18)
        Me.cbNhaCungCap.Name = "cbNhaCungCap"
        Me.cbNhaCungCap.Size = New System.Drawing.Size(216, 29)
        Me.cbNhaCungCap.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 21)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Mã phiếu nhập: "
        '
        'lbNguoiNhap
        '
        Me.lbNguoiNhap.AutoSize = True
        Me.lbNguoiNhap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNguoiNhap.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbNguoiNhap.Location = New System.Drawing.Point(422, 61)
        Me.lbNguoiNhap.Name = "lbNguoiNhap"
        Me.lbNguoiNhap.Size = New System.Drawing.Size(104, 21)
        Me.lbNguoiNhap.TabIndex = 37
        Me.lbNguoiNhap.Text = "lbNguoiNhap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(299, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nhà cung cấp *"
        '
        'lbNgayNhap
        '
        Me.lbNgayNhap.AutoSize = True
        Me.lbNgayNhap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayNhap.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbNgayNhap.Location = New System.Drawing.Point(142, 61)
        Me.lbNgayNhap.Name = "lbNgayNhap"
        Me.lbNgayNhap.Size = New System.Drawing.Size(98, 21)
        Me.lbNgayNhap.TabIndex = 38
        Me.lbNgayNhap.Text = "lbNgayNhap"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 21)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Ngày nhập: "
        '
        'lbMaPhieuNhap
        '
        Me.lbMaPhieuNhap.AutoSize = True
        Me.lbMaPhieuNhap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaPhieuNhap.ForeColor = System.Drawing.Color.Red
        Me.lbMaPhieuNhap.Location = New System.Drawing.Point(142, 21)
        Me.lbMaPhieuNhap.Name = "lbMaPhieuNhap"
        Me.lbMaPhieuNhap.Size = New System.Drawing.Size(122, 21)
        Me.lbMaPhieuNhap.TabIndex = 36
        Me.lbMaPhieuNhap.Text = "lbMaPhieuNhap"
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(3, 19)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(66, 17)
        Me.lbTroVe.TabIndex = 88
        Me.lbTroVe.Text = "<< Trở về"
        '
        'btnThemDauSach
        '
        Me.btnThemDauSach.Activecolor = System.Drawing.Color.Silver
        Me.btnThemDauSach.BackColor = System.Drawing.Color.LightGray
        Me.btnThemDauSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThemDauSach.BorderRadius = 7
        Me.btnThemDauSach.ButtonText = "Thêm đầu sách"
        Me.btnThemDauSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemDauSach.DisabledColor = System.Drawing.Color.Silver
        Me.btnThemDauSach.ForeColor = System.Drawing.Color.Black
        Me.btnThemDauSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThemDauSach.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Plus_64
        Me.btnThemDauSach.Iconimage_right = Nothing
        Me.btnThemDauSach.Iconimage_right_Selected = Nothing
        Me.btnThemDauSach.Iconimage_Selected = Nothing
        Me.btnThemDauSach.IconMarginLeft = 0
        Me.btnThemDauSach.IconMarginRight = 0
        Me.btnThemDauSach.IconRightVisible = True
        Me.btnThemDauSach.IconRightZoom = 0R
        Me.btnThemDauSach.IconVisible = True
        Me.btnThemDauSach.IconZoom = 60.0R
        Me.btnThemDauSach.IsTab = False
        Me.btnThemDauSach.Location = New System.Drawing.Point(22, 161)
        Me.btnThemDauSach.Name = "btnThemDauSach"
        Me.btnThemDauSach.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThemDauSach.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnThemDauSach.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThemDauSach.selected = False
        Me.btnThemDauSach.Size = New System.Drawing.Size(166, 41)
        Me.btnThemDauSach.TabIndex = 33
        Me.btnThemDauSach.Text = "Thêm đầu sách"
        Me.btnThemDauSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThemDauSach.Textcolor = System.Drawing.Color.Black
        Me.btnThemDauSach.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'dgDanhSach
        '
        Me.dgDanhSach.AllowUserToAddRows = False
        Me.dgDanhSach.AllowUserToDeleteRows = False
        Me.dgDanhSach.AllowUserToResizeColumns = False
        Me.dgDanhSach.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNguoiDung, Me.Ten, Me.DonGia, Me.SoLuong, Me.ThanhTien, Me.GhiChu})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSach.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDanhSach.DoubleBuffered = True
        Me.dgDanhSach.EnableHeadersVisualStyles = False
        Me.dgDanhSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.Location = New System.Drawing.Point(22, 208)
        Me.dgDanhSach.Name = "dgDanhSach"
        Me.dgDanhSach.ReadOnly = True
        Me.dgDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDanhSach.Size = New System.Drawing.Size(653, 245)
        Me.dgDanhSach.TabIndex = 89
        '
        'MaNguoiDung
        '
        Me.MaNguoiDung.HeaderText = "Mã"
        Me.MaNguoiDung.Name = "MaNguoiDung"
        Me.MaNguoiDung.ReadOnly = True
        Me.MaNguoiDung.Width = 80
        '
        'Ten
        '
        Me.Ten.HeaderText = "Tên đầu sách"
        Me.Ten.Name = "Ten"
        Me.Ten.ReadOnly = True
        Me.Ten.Width = 150
        '
        'DonGia
        '
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        '
        'SoLuong
        '
        Me.SoLuong.HeaderText = "Số lượng"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.ReadOnly = True
        Me.SoLuong.Width = 95
        '
        'ThanhTien
        '
        Me.ThanhTien.HeaderText = "Thành tiền"
        Me.ThanhTien.Name = "ThanhTien"
        Me.ThanhTien.ReadOnly = True
        '
        'GhiChu
        '
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        Me.GhiChu.Width = 90
        '
        'ucPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.lbTroVe)
        Me.Controls.Add(Me.btnThemDauSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucPhieuNhap"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbNhaCungCap As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbNguoiNhap As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbMaPhieuNhap As Label
    Friend WithEvents lbTroVe As Label
    Friend WithEvents btnThemDauSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MaNguoiDung As DataGridViewTextBoxColumn
    Friend WithEvents Ten As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
End Class
