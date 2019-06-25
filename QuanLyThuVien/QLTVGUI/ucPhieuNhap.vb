Imports QLTVBus
Imports QLTVDTO

Public Class ucPhieuNhap
    Public dangnhap As DangNhapDTO
    Dim phieunhapBus As New PhieuNhapBUS
    Dim nhacungcapBus As New NhaCungCapBUS
    Dim listNhaCungCap As New List(Of NhaCungCapDTO)

    Private Sub ucPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieunhapBus.build_maphieunhap(lbMaPhieuNhap.Text)
        lbNgayNhap.Text = Today.ToString("dd/MM/yyyy")
        lbNguoiNhap.Text = dangnhap.NguoiDung

        nhacungcapBus.selectALL(listNhaCungCap)
        cbNhaCungCap.DataSource = New BindingSource(listNhaCungCap, String.Empty)
        cbNhaCungCap.DisplayMember = "tennhacungcap"
        cbNhaCungCap.ValueMember = "manhacungcap"
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucPhieuNhap
        parent = sender.Parent
        Dim parent2 As ucQuanLySach
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim quanlysach As New ucQuanLySach With {
            .dangnhap = parent4.dangnhap
        }
        parent3.Controls.Clear()
        parent3.Controls.Add(quanlysach)
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Back(sender)
    End Sub

    Private Sub lbTroVe_MouseHover(sender As Object, e As EventArgs) Handles lbTroVe.MouseHover
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
    End Sub

    Private Sub lbTroVe_MouseLeave(sender As Object, e As EventArgs) Handles lbTroVe.MouseLeave
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    Private Sub btnThemDauSach_Click(sender As Object, e As EventArgs) Handles btnThemDauSach.Click
        'Me.Controls.Clear()
        Dim tiepnhansach As New ucTiepNhanSachMoi With {
            .maphieunhap = lbMaPhieuNhap.Text
        }
        Me.Controls.Add(tiepnhansach)
        tiepnhansach.BringToFront()
    End Sub
End Class
