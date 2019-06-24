Imports QLTVBus
Imports Utility

Public Class ucThongTinDocGia
    Dim dgBUS As New DocGiaBus
    Dim result As New Result
    Dim sBUS As New SachBUS
    Dim ptsBUS As New PhieuTraBUS
    Dim pmsBUS As New PhieuMuonBus
    Dim ctptsBUS As New ChiTietPhieuTraBus
    Dim ctpmsBUS As New ChiTietPhieuMuonBus

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Me.Controls.Clear()
        Dim ucCapNhatThongTin As New ucCapNhatThongTin

        ucCapNhatThongTin.lbMaDocGia.Text = lbMaDocGia.Text
        ucCapNhatThongTin.tbHoVaTen.Text = lbHoVaTen.Text
        ucCapNhatThongTin.tbDiaChi.Text = lbDiaChi.Text
        ucCapNhatThongTin.tbEmail.Text = lbEmail.Text
        ucCapNhatThongTin.dtpNgaySinh.Value = lbNgaySinh.Text
        ucCapNhatThongTin.dtpNgayLapThe.Value = lbNgayLapThe.Text

        Me.Controls.Add(ucCapNhatThongTin)
        ucCapNhatThongTin.BringToFront()
    End Sub

    Private Sub btnTroVe_Click(sender As Object, e As EventArgs) Handles btnTroVe.Click
        Dim this As ucThongTinDocGia
        this = sender.Parent
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

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim isSuccess As Boolean = True

        If (MessageBox.Show("Bạn có chắc muốn xoá độc giả " + lbMaDocGia.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) = DialogResult.Cancel Then
            Return
        End If

        'Update madocgiamuon trong sách
        result = sBUS.deleteDocGiaMuon(lbMaDocGia.Text)

        If result.FlagResult = False Then
            MessageBox.Show("Update mã độc giả mượn sách " + lbMaDocGia.Text + " trong table SÁCH  không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If

        'Xoa độc chi tiet tra sach 
        result = ctptsBUS.delete_byMaPhieuTraSachAndMaDocGia(lbMaDocGia.Text)

        If result.FlagResult = False Then
            MessageBox.Show("Xóa chi tiết trả sách của độc giả " + lbMaDocGia.Text + " trong table CHI TIẾT PHIẾU TRẢ SÁCH không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If

        'Xoa độc chi tiet muon sach 
        result = ctpmsBUS.delete_byMaPhieuMuonSachAndMaDocGia(lbMaDocGia.Text)

        If result.FlagResult = False Then
            MessageBox.Show("Xóa chi tiết mượn sách của độc giả " + lbMaDocGia.Text + " trong table CHI TIẾT PHIẾU MƯỢN SÁCH không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If


        'Xoa độc giả trong phiếu trả sách
        result = ptsBUS.delete_byMaDG(lbMaDocGia.Text)

        If result.FlagResult = False Then
            MessageBox.Show("Xóa độc giả " + lbMaDocGia.Text + " trong table PHIẾU TRẢ SÁCH không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If
        'Xoa độc giả trong phiếu mượn sách
        result = pmsBUS.delete_byMaDG(lbMaDocGia.Text)

        If result.FlagResult = False Then
            MessageBox.Show("Xóa độc giả " + lbMaDocGia.Text + " trong table PHIẾU MƯỢC SÁCH không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If
        'Xóa độc giả trong độc giả
        result = dgBUS.deleteDG_ByMaDG(lbMaDocGia.Text)
        If result.FlagResult = False Then
            MessageBox.Show("Xóa độc giả trong table Độc Giả " + lbMaDocGia.Text + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isSuccess = False
        End If

        ' check if delete success
        If isSuccess = True Then
            MessageBox.Show("Xoá độc giả " + lbMaDocGia.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Xoá độc giả " + lbMaDocGia.Text + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'thoat sau khi xoa 
        Dim this As ucThongTinDocGia
        this = sender.Parent
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
