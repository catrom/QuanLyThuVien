Imports System.Windows.Forms
Imports QLTVDTO
Imports QLTVBus

Public Class frmHome
    Public dangnhap As DangNhapDTO
    Public dangnhapBus As New DangNhapBus
    Public vaitro As New VaiTroDTO

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fpnZone.Controls.Clear()
        Dim ucThuVien As New ucThuVien
        fpnZone.Controls.Add(ucThuVien)

        If dangnhap Is Nothing Then
            Me.lbTrangThai.Text = "Vai trò: KHÁCH"
        Else
            dangnhapBus.getVaiTro(dangnhap, vaitro)
            Me.lbTrangThai.Text = "Vai trò: " + vaitro.TenVaiTro
        End If
    End Sub

    Private Sub ibtnExit_Click(sender As Object, e As EventArgs) Handles ibtnExit.Click
        Dim result As Integer = MessageBox.Show("Bạn có muốn tắt ứng dụng quản lý thư viện?", "Thông báo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ibtnMinimize_Click(sender As Object, e As EventArgs) Handles ibtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs)
        fpnZone.Controls.Clear()
        Dim ucThuVien As New ucThuVien
        fpnZone.Controls.Add(ucThuVien)
        UnSelectedAll()
    End Sub

    Private Sub UnSelectedAll()
        btnNguoiDung.selected = False
        btnTraCuu.selected = False
        btnQuanLyDocGia.selected = False
        btnBaoCao.selected = False
    End Sub

    Private Sub lbThayDoi_MouseHover(sender As Object, e As EventArgs) Handles lbThayDoi.MouseHover
        lbThayDoi.ForeColor = Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
    End Sub

    Private Sub lbThayDoi_MouseLeave(sender As Object, e As EventArgs) Handles lbThayDoi.MouseLeave
        lbThayDoi.ForeColor = Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    Private Sub lbThayDoi_Click(sender As Object, e As EventArgs) Handles lbThayDoi.Click
        Me.Hide()

        Dim splash As New splashScreen
        splash.Show()
    End Sub

    Private Sub btnQuanLyDocGia_Click(sender As Object, e As EventArgs) Handles btnQuanLyDocGia.Click
        fpnZone.Controls.Clear()
        Dim ucDocGia As New ucDocGia
        fpnZone.Controls.Add(ucDocGia)
    End Sub

    Private Sub btnNguoiDung_Click(sender As Object, e As EventArgs) Handles btnNguoiDung.Click
        fpnZone.Controls.Clear()
        Dim ucThongTinNguoiDung As New ucThongTinNguoiDung With {
            .dangnhap = Me.dangnhap
        }

        fpnZone.Controls.Add(ucThongTinNguoiDung)
    End Sub
End Class