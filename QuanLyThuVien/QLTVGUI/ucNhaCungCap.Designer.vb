﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNhaCungCap
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
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbSoDienThoai = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSoFax = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbMaNhaCungCap = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaNguoiDung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTroVe = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(256, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 30)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NHÀ CUNG CẤP"
        '
        'tbTen
        '
        Me.tbTen.AutoSize = True
        Me.tbTen.BackColor = System.Drawing.Color.White
        Me.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbTen.ForeColor = System.Drawing.Color.Black
        Me.tbTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbTen.HintText = ""
        Me.tbTen.isPassword = False
        Me.tbTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTen.LineThickness = 2
        Me.tbTen.Location = New System.Drawing.Point(165, 68)
        Me.tbTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(250, 36)
        Me.tbTen.TabIndex = 32
        Me.tbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tên nhà cung cấp *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Địa chỉ *"
        '
        'tbDiaChi
        '
        Me.tbDiaChi.AutoSize = True
        Me.tbDiaChi.BackColor = System.Drawing.Color.White
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbDiaChi.ForeColor = System.Drawing.Color.Black
        Me.tbDiaChi.HintForeColor = System.Drawing.Color.Empty
        Me.tbDiaChi.HintText = ""
        Me.tbDiaChi.isPassword = False
        Me.tbDiaChi.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineIdleColor = System.Drawing.Color.Silver
        Me.tbDiaChi.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineThickness = 2
        Me.tbDiaChi.Location = New System.Drawing.Point(165, 114)
        Me.tbDiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(250, 36)
        Me.tbDiaChi.TabIndex = 32
        Me.tbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Số điện thoại *"
        '
        'tbSoDienThoai
        '
        Me.tbSoDienThoai.AutoSize = True
        Me.tbSoDienThoai.BackColor = System.Drawing.Color.White
        Me.tbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSoDienThoai.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbSoDienThoai.ForeColor = System.Drawing.Color.Black
        Me.tbSoDienThoai.HintForeColor = System.Drawing.Color.Empty
        Me.tbSoDienThoai.HintText = ""
        Me.tbSoDienThoai.isPassword = False
        Me.tbSoDienThoai.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbSoDienThoai.LineIdleColor = System.Drawing.Color.Silver
        Me.tbSoDienThoai.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbSoDienThoai.LineThickness = 2
        Me.tbSoDienThoai.Location = New System.Drawing.Point(165, 160)
        Me.tbSoDienThoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSoDienThoai.Name = "tbSoDienThoai"
        Me.tbSoDienThoai.Size = New System.Drawing.Size(250, 36)
        Me.tbSoDienThoai.TabIndex = 32
        Me.tbSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Số fax:"
        '
        'tbSoFax
        '
        Me.tbSoFax.AutoSize = True
        Me.tbSoFax.BackColor = System.Drawing.Color.White
        Me.tbSoFax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSoFax.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbSoFax.ForeColor = System.Drawing.Color.Black
        Me.tbSoFax.HintForeColor = System.Drawing.Color.Empty
        Me.tbSoFax.HintText = ""
        Me.tbSoFax.isPassword = False
        Me.tbSoFax.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbSoFax.LineIdleColor = System.Drawing.Color.Silver
        Me.tbSoFax.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbSoFax.LineThickness = 2
        Me.tbSoFax.Location = New System.Drawing.Point(165, 206)
        Me.tbSoFax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSoFax.Name = "tbSoFax"
        Me.tbSoFax.Size = New System.Drawing.Size(250, 36)
        Me.tbSoFax.TabIndex = 32
        Me.tbSoFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLuu)
        Me.GroupBox1.Controls.Add(Me.lbMaNhaCungCap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(455, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 174)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Thêm"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Plus_64
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
        Me.btnLuu.Location = New System.Drawing.Point(50, 118)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(117, 41)
        Me.btnLuu.TabIndex = 31
        Me.btnLuu.Text = "Thêm"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'lbMaNhaCungCap
        '
        Me.lbMaNhaCungCap.BackColor = System.Drawing.Color.Transparent
        Me.lbMaNhaCungCap.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaNhaCungCap.ForeColor = System.Drawing.Color.Red
        Me.lbMaNhaCungCap.Location = New System.Drawing.Point(6, 56)
        Me.lbMaNhaCungCap.Name = "lbMaNhaCungCap"
        Me.lbMaNhaCungCap.Size = New System.Drawing.Size(205, 25)
        Me.lbMaNhaCungCap.TabIndex = 30
        Me.lbMaNhaCungCap.Text = "lbMaNhaCungCap"
        Me.lbMaNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Mã nhà cung cấp:"
        '
        'dgDanhSach
        '
        Me.dgDanhSach.AllowUserToAddRows = False
        Me.dgDanhSach.AllowUserToDeleteRows = False
        Me.dgDanhSach.AllowUserToResizeColumns = False
        Me.dgDanhSach.AllowUserToResizeRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNguoiDung, Me.Ten, Me.DiaChi, Me.SoDienThoai, Me.SoFax})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSach.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgDanhSach.DoubleBuffered = True
        Me.dgDanhSach.EnableHeadersVisualStyles = False
        Me.dgDanhSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.Location = New System.Drawing.Point(23, 264)
        Me.dgDanhSach.Name = "dgDanhSach"
        Me.dgDanhSach.ReadOnly = True
        Me.dgDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgDanhSach.Size = New System.Drawing.Size(659, 245)
        Me.dgDanhSach.TabIndex = 74
        '
        'MaNguoiDung
        '
        Me.MaNguoiDung.HeaderText = "Mã"
        Me.MaNguoiDung.Name = "MaNguoiDung"
        Me.MaNguoiDung.ReadOnly = True
        Me.MaNguoiDung.Width = 75
        '
        'Ten
        '
        Me.Ten.HeaderText = "Tên"
        Me.Ten.Name = "Ten"
        Me.Ten.ReadOnly = True
        Me.Ten.Width = 150
        '
        'DiaChi
        '
        Me.DiaChi.HeaderText = "Địa chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        Me.DiaChi.Width = 150
        '
        'SoDienThoai
        '
        Me.SoDienThoai.HeaderText = "Số điện thoại"
        Me.SoDienThoai.Name = "SoDienThoai"
        Me.SoDienThoai.ReadOnly = True
        Me.SoDienThoai.Width = 120
        '
        'SoFax
        '
        Me.SoFax.HeaderText = "Số fax"
        Me.SoFax.Name = "SoFax"
        Me.SoFax.ReadOnly = True
        Me.SoFax.Width = 120
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(3, 12)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(66, 17)
        Me.lbTroVe.TabIndex = 28
        Me.lbTroVe.Text = "<< Trở về"
        '
        'ucNhaCungCap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbSoFax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSoDienThoai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbTroVe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucNhaCungCap"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbSoDienThoai As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSoFax As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbMaNhaCungCap As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MaNguoiDung As DataGridViewTextBoxColumn
    Friend WithEvents Ten As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoai As DataGridViewTextBoxColumn
    Friend WithEvents SoFax As DataGridViewTextBoxColumn
    Friend WithEvents lbTroVe As Label
End Class
