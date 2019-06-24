Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports System.IO

Public Class ucTimDocGia
    'Dim dgBus As New DocGiaBUS
    'Dim loaidgBus As New LoaiDocGiaBUS
    'Dim dsloaidg As New List(Of LoaiDocGiaDTO)
    'Dim result As New Result

    'Private Sub ucTimDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    lbTimDocGia.ForeColor = Color.FromArgb(89, 94, 241)

    '    'lay danh sach loai doc gia
    '    result = loaidgBus.selectAll(dsloaidg)
    '    If result.FlagResult = False Then
    '        MessageBox.Show("Lấy danh sách loại độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        System.Console.WriteLine(result.SystemMessage)
    '        Return
    '    End If
    '    dsloaidg.ElementAt(0).TenLoaiDocGia = "(Tất cả)"
    '    cbLoaiDocGia.DataSource = New BindingSource(dsloaidg, String.Empty)
    '    cbLoaiDocGia.DisplayMember = "tenloaidocgia"
    '    cbLoaiDocGia.ValueMember = "maloaidocgia"
    'End Sub

    'Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
    '    dgDanhSachDG.Rows.Clear()

    '    Dim ketqua As New List(Of String)
    '    Dim timkiem As New List(Of String)

    '    'lay tat ca ma dg
    '    result = dgBus.selectALL_MaDG("%", ketqua)
    '    If result.FlagResult = False Then
    '        MessageBox.Show("Lấy danh sách độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    '    'tim kiem theo ma dg
    '    If tbMaDocGia.Text.Length > 0 Then
    '        result = dgBus.selectALL_MaDG("%" + tbMaDocGia.Text + "%", timkiem)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm theo mã độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            findCommon(ketqua, timkiem) ' giao 2 list
    '        End If
    '    End If

    '    'tim kiem theo ten dg
    '    If tbTenDocGia.Text.Length > 0 Then
    '        result = dgBus.selectALL_TenDG("%" + tbTenDocGia.Text + "%", timkiem)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm theo tên độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            findCommon(ketqua, timkiem) ' giao 2 list
    '        End If
    '    End If

    '    'tim kiem theo email
    '    If tbEmail.Text.Length > 0 Then
    '        result = dgBus.select_EMAIL("%" + tbEmail.Text + "%", timkiem)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm theo email không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            findCommon(ketqua, timkiem) ' giao 2 list
    '        End If
    '    End If

    '    'tim kiem theo loai dg
    '    If cbLoaiDocGia.SelectedIndex > 0 Then
    '        result = dgBus.selectALL_MaLoaiDG("%" + cbLoaiDocGia.SelectedValue.ToString() + "%", timkiem)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm theo mã loại độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            findCommon(ketqua, timkiem) ' giao 2 list
    '        End If
    '    End If

    '    If (ketqua.Count > 0) Then
    '        If ketqua.ElementAt(0) = "DG000000" Then
    '            ketqua.RemoveAt(0)
    '        End If
    '        If ketqua.Count > 0 Then
    '            showResult(ketqua)
    '        End If
    '    Else
    '        MessageBox.Show("Không tìm thấy kết quả nào thoả mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub findCommon(ketqua As List(Of String), timkiem As List(Of String))
    '    For i As Integer = ketqua.Count - 1 To 0 Step -1
    '        If timkiem.Contains(ketqua(i)) = False Then
    '            ketqua.RemoveAt(i)
    '        End If
    '    Next
    'End Sub

    'Private Sub showResult(ketqua As List(Of String))
    '    For i As Integer = 0 To ketqua.Count - 1
    '        Dim madg = ketqua.ElementAt(i)

    '        Dim tendg = ""
    '        Dim ngaysinh As New DateTime
    '        Dim ns = ""
    '        Dim diachi = ""
    '        Dim email = ""
    '        Dim maloaidg = ""
    '        Dim loaidg = ""
    '        Dim ngaylapthe As New DateTime
    '        Dim nlt = ""

    '        result = dgBus.getDetailFromMaDG(madg, tendg, ngaysinh, diachi, email, maloaidg, ngaylapthe)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm thông tin tên của mã sách " + madg + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '        result = loaidgBus.get_LoaiDG_ByMaLoaiDG(maloaidg, loaidg)
    '        If result.FlagResult = False Then
    '            MessageBox.Show("Tìm kiếm thông tin tên của loại độc giả " + maloaidg + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '        ns = ngaysinh.Day.ToString() + "/ " + ngaysinh.Month.ToString() + "/ " + ngaysinh.Year.ToString()
    '        nlt = ngaylapthe.Day.ToString() + "/ " + ngaylapthe.Month.ToString() + "/ " + ngaylapthe.Year.ToString()

    '        Dim s As String()
    '        s = New String() {madg, tendg, ngaysinh.ToShortDateString(), diachi, email, loaidg, ngaylapthe.ToShortDateString()}
    '        dgDanhSachDG.Rows.Add(s)
    '    Next
    'End Sub

    'Private Sub dgDanhSachDG_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDanhSachDG.RowPostPaint
    '    Using b As SolidBrush = New SolidBrush(dgDanhSachDG.RowHeadersDefaultCellStyle.ForeColor)
    '        e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDanhSachDG.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 2)
    '    End Using
    'End Sub


    'Private Sub dgDanhSachDG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDanhSachDG.CellDoubleClick
    '    If e.ColumnIndex = 0 Then
    '        'Me.Controls.Clear()
    '        Dim ucThongTinDocGia As New ucThongTinDocGia
    '        Me.Controls.Add(ucThongTinDocGia)
    '        Dim rowClick = e.RowIndex
    '        ucThongTinDocGia.lbMaDocGia.Text = dgDanhSachDG.Rows(rowClick).Cells(0).Value.ToString()
    '        ucThongTinDocGia.lbHoVaTen.Text = dgDanhSachDG.Rows(rowClick).Cells(1).Value.ToString()
    '        ucThongTinDocGia.lbNgaySinh.Text = dgDanhSachDG.Rows(rowClick).Cells(2).Value.ToString()
    '        ucThongTinDocGia.lbDiaChi.Text = dgDanhSachDG.Rows(rowClick).Cells(3).Value.ToString()
    '        ucThongTinDocGia.lbEmail.Text = dgDanhSachDG.Rows(rowClick).Cells(4).Value.ToString()
    '        ucThongTinDocGia.lbLoaiDocGia.Text = dgDanhSachDG.Rows(rowClick).Cells(5).Value.ToString()
    '        ucThongTinDocGia.lbNgayLapThe.Text = dgDanhSachDG.Rows(rowClick).Cells(6).Value.ToString()

    '        ucThongTinDocGia.BringToFront()
    '    End If
    'End Sub

    'Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
    '    Dim parent As ucTimDocGia
    '    parent = sender.Parent
    '    Dim graParent As ucDocGia
    '    graParent = parent.Parent
    '    Dim grandpar = New FlowLayoutPanel
    '    grandpar = graParent.Parent
    '    grandpar.Controls.Clear()
    '    Dim grgrpar = New frmHome
    '    grgrpar = grandpar.Parent
    '    grgrpar.btnLapTheDocGia.selected = False
    '    Dim ucThuVien As New ucThuVien
    '    grandpar.Controls.Add(ucThuVien)

    '    grgrpar.btnLapTheDocGia.selected = False
    '    grgrpar.btnTiepNhanSachMoi.selected = False
    '    grgrpar.btnTraCuuSach.selected = False
    '    grgrpar.btnChoMuonSach.selected = False
    '    grgrpar.btnNhanTraSach.selected = False
    '    grgrpar.btnLapBaoCao.selected = False
    '    grgrpar.btnThayDoiQuyDinh.selected = False
    'End Sub
End Class
