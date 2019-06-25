Imports QLTVBus
Imports QLTVDTO

Public Class ucQuanLySach
    Public dangnhap As DangNhapDTO

    Private Sub btnThemNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnThemNhaCungCap.Click
        Me.Controls.Clear()
        Dim nhacungcap As New ucNhaCungCap
        Me.Controls.Add(nhacungcap)
        nhacungcap.BringToFront()
    End Sub

    Private Sub btnThemNhaThanhLy_Click(sender As Object, e As EventArgs) Handles btnThemNhaThanhLy.Click, btnThemTheLoai.Click, btnThemTacGia.Click, btnThemNhaXuatBan.Click, btnThemNgonNgu.Click

    End Sub

    Private Sub btnNhapSach_Click(sender As Object, e As EventArgs) Handles btnNhapSach.Click

    End Sub

    Private Sub btnXuatSach_Click(sender As Object, e As EventArgs) Handles btnXuatSach.Click

    End Sub

    Private Sub btnMuonSach_Click(sender As Object, e As EventArgs) Handles btnMuonSach.Click

    End Sub

    Private Sub btnTraSach_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click

    End Sub
End Class
