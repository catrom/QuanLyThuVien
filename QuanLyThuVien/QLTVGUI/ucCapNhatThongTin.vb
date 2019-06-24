Imports Utility
Imports QLTVBus
Imports QLTVDTO
Imports System.Drawing
Imports System.IO

Public Class ucCapNhatThongTin
    Dim loaidgBus As New LoaiDocGiaBus
    Dim dsloaidg As New List(Of LoaiDocGiaDTO)
    Dim result As New Result
    Dim dgBus As New DocGiaBus
    Private Sub ucCapNhatThongTin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbCapNhatThongTin.ForeColor = Color.FromArgb(89, 94, 241)

        'lay danh sach loai doc gia
        result = loaidgBus.selectAll(dsloaidg)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách loại độc giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        Dim ucThongTinDocGia As ucThongTinDocGia
        ucThongTinDocGia = sender.Parent

        Dim loaidg As String = ucThongTinDocGia.lbLoaiDocGia.Text

        'For i As Integer = dsloaidg.Count - 1 To 0 Step -1
        '    If dsloaidg.ElementAt(i).TenLoaiDocGia = loaidg Then
        '        dsloaidg.RemoveAt(i)
        '    End If
        'Next
        dsloaidg.ElementAt(0).TenLoaiDocGia = ucThongTinDocGia.lbLoaiDocGia.Text
        cbLoaiDocGia.DataSource = New BindingSource(dsloaidg, String.Empty)
        cbLoaiDocGia.DisplayMember = "tenloaidocgia"
        cbLoaiDocGia.ValueMember = "maloaidocgia"
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = lbMaDocGia.Text
        docgia.HoTen = tbHoVaTen.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.DiaChi = tbDiaChi.Text
        docgia.Email = tbEmail.Text
        docgia.MaLoaiDocGia = cbLoaiDocGia.SelectedValue.ToString()
        docgia.NgayLapThe = dtpNgayLapThe.Value

        '2. Bussiness
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không hợp lệ!")
            tbHoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia) = False) Then
            MessageBox.Show("Tuổi không hợp lệ!")
            dtpNgaySinh.Focus()
            Return
        End If

        If (dgBus.isValidAddress(docgia) = False) Then
            MessageBox.Show("Địa chỉ không được trống!")
            tbDiaChi.Focus()
            Return
        End If

        If (dgBus.isValidEmail(docgia) = False) Then
            MessageBox.Show("Email không hợp lệ!")
            tbEmail.Focus()
            Return
        End If

        '3. Update to Database
        result = dgBus.update(docgia)
        If result.FlagResult = False Then
            MessageBox.Show("Cập nhật thông tin của loại độc giả " + docgia.MaDocGia + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Cập nhật thông tin của loại độc giả " + docgia.MaDocGia + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLuuVaThoat_Click(sender As Object, e As EventArgs) Handles btnLuuVaThoat.Click

        '' Luu
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.MaDocGia = lbMaDocGia.Text
        docgia.HoTen = tbHoVaTen.Text
        docgia.NgaySinh = dtpNgaySinh.Value
        docgia.DiaChi = tbDiaChi.Text
        docgia.Email = tbEmail.Text
        docgia.MaLoaiDocGia = cbLoaiDocGia.SelectedValue.ToString()
        docgia.NgayLapThe = dtpNgayLapThe.Value

        '2. Bussiness
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không hợp lệ!")
            tbHoVaTen.Focus()
            Return
        End If

        If (dgBus.isValidAge(docgia) = False) Then
            MessageBox.Show("Tuổi không hợp lệ!")
            dtpNgaySinh.Focus()
            Return
        End If

        If (dgBus.isValidAddress(docgia) = False) Then
            MessageBox.Show("Địa chỉ không được trống!")
            tbDiaChi.Focus()
            Return
        End If

        If (dgBus.isValidEmail(docgia) = False) Then
            MessageBox.Show("Email không hợp lệ!")
            tbEmail.Focus()
            Return
        End If

        '3. Update to Database
        result = dgBus.update(docgia)
        If result.FlagResult = False Then
            MessageBox.Show("Cập nhật thông tin của loại độc giả " + docgia.MaDocGia + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Cập nhật thông tin của loại độc giả " + docgia.MaDocGia + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '' Thoat
        Dim son As ucCapNhatThongTin
        son = sender.Parent
        Dim this As ucThongTinDocGia
        this = son.Parent
        Dim parent As ucTimDocGia
        parent = this.Parent
        Dim graParent As ucDocGia
        graParent = parent.Parent
        Dim grandpar = New FlowLayoutPanel
        grandpar = graParent.Parent
        grandpar.Controls.Clear()
        Dim grgrpar = New frmHome
        grgrpar = grandpar.Parent
        grgrpar.btnLapTheDocGia.selected = False
        Dim ucThuVien As New ucThuVien
        grandpar.Controls.Add(ucThuVien)

        grgrpar.btnLapTheDocGia.selected = False
        grgrpar.btnTiepNhanSachMoi.selected = False
        grgrpar.btnTraCuuSach.selected = False
        grgrpar.btnChoMuonSach.selected = False
        grgrpar.btnNhanTraSach.selected = False
        grgrpar.btnLapBaoCao.selected = False
        grgrpar.btnThayDoiQuyDinh.selected = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim son As ucCapNhatThongTin
        son = sender.Parent
        Dim this As ucThongTinDocGia
        this = son.Parent
        Dim parent As ucTimDocGia
        parent = this.Parent
        Dim graParent As ucDocGia
        graParent = parent.Parent
        Dim grandpar = New FlowLayoutPanel
        grandpar = graParent.Parent
        grandpar.Controls.Clear()
        Dim grgrpar = New frmHome
        grgrpar = grandpar.Parent
        grgrpar.btnLapTheDocGia.selected = False
        Dim ucThuVien As New ucThuVien
        grandpar.Controls.Add(ucThuVien)

        grgrpar.btnLapTheDocGia.selected = False
        grgrpar.btnTiepNhanSachMoi.selected = False
        grgrpar.btnTraCuuSach.selected = False
        grgrpar.btnChoMuonSach.selected = False
        grgrpar.btnNhanTraSach.selected = False
        grgrpar.btnLapBaoCao.selected = False
        grgrpar.btnThayDoiQuyDinh.selected = False
    End Sub
End Class
