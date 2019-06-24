﻿Imports QLTVDTO
Imports QLTVBus

Public Class ucThemNguoiDung
    Private vaitroBus As New VaiTroBUS
    Private nguoidungBus As New NguoiDungBUS
    Public themDocGia As New Boolean

    Private Sub ucThemNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbVaiTro
        Dim listVaiTro = New List(Of VaiTroDTO)

        vaitroBus.selectAll(listVaiTro)
        cbVaiTro.DataSource = New BindingSource(listVaiTro, String.Empty)
        cbVaiTro.DisplayMember = "tenvaitro"
        cbVaiTro.ValueMember = "mavaitro"

        If themDocGia = True Then
            cbVaiTro.SelectedValue = "VT000006"
        End If

        'lbMaNguoiDung
        nguoidungBus.buildMaNguoiDung(lbMaNguoiDung.Text)

        'lbNgayTao
        lbNgayTao.Text = Today.ToString("dd/MM/yyyy")

        'dtpNgaySinh
        dtpNgaySinh.Value = New Date(2000, 1, 1)

        'cbGioiTinh
        cbGioiTinh.Items.Insert(0, "Nam")
        cbGioiTinh.Items.Insert(1, "Nữ")
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim nguoidung As New NguoiDungDTO
        nguoidung.MaNguoiDung = lbMaNguoiDung.Text
        nguoidung.HoTen = tbHoTen.Text
        nguoidung.CMND = tbCMND.Text
        nguoidung.GioiTinh = cbGioiTinh.SelectedIndex
        nguoidung.NgaySinh = dtpNgaySinh.Value
        nguoidung.DiaChi = tbDiaChi.Text
        nguoidung.Email = tbEmail.Text
        nguoidung.SoDienThoai = tbSoDienThoai.Text
        nguoidung.VaiTro = cbVaiTro.SelectedValue.ToString()
        nguoidung.NgayTao = Today

        nguoidungBus.insert(nguoidung)
        Back(sender)

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Back(sender)
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucThemNguoiDung
        parent = sender.Parent
        Dim parent2 As ucThongTinNguoiDung
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim thongtin As New ucThongTinNguoiDung With {
            .dangnhap = parent4.dangnhap
        }
        parent3.Controls.Clear()
        parent3.Controls.Add(thongtin)
    End Sub
End Class
