﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports QLTVBus
Imports Utility

Public Class splashScreen

    Public SqlConn As New SqlConnection With {.ConnectionString = ConfigurationManager.AppSettings("ConnectionString")}
    Dim dangnhap As New DangNhapBus
    Dim result As New Result

    Public Function checkConnection() As Boolean
        Try
            SqlConn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnDangNhap.Width = 0
        btnDangNhap.Focus()

        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressBar.Value < 100 Then
            progressBar.Value += 1
        Else
            Timer1.Stop()

            If checkConnection() = True Then
                pnDangNhap.Width = 307
                pnLogo.Location = New Drawing.Point(155, 138)
                lbStatus.Text = "Kết nối thành công!"
                progressBar.Visible = False

            Else
                MessageBox.Show("Kết nối thất bại! Vui lòng kiểm tra lại cài đặt cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End If
        End If
    End Sub

    Private Sub btnDocGia_Click(sender As Object, e As EventArgs) Handles btnDocGia.Click
        Me.Hide()
        Dim home As New frmHome
        home.Show()
    End Sub

    Private Sub tbMaDangNhap_MouseClick(sender As Object, e As MouseEventArgs) Handles tbMaDangNhap.MouseClick
        lbStatus.Visible = False
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If tbMaDangNhap.Text.Length = 0 Then
            lbTrangThaiMK.Text = "Mã đăng nhập không hợp lệ!"
            Return
        End If

        If tbMatKhau.Text.Length = 0 Then
            lbTrangThaiMK.Text = "Nhập mật khẩu!"
            Return
        End If

        Dim userLogin As New DangNhapDTO

        result = dangnhap.kiemTra(tbMaDangNhap.Text, tbMatKhau.Text, userLogin)
        If result.FlagResult = False Then
            MessageBox.Show("Lỗi truy xuất dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbMaDangNhap.Focus()
            Return
        ElseIf result.FlagResult = True And result.ApplicationMessage = "invalid" Then
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbMaDangNhap.Focus()
            Return
        End If

        If result.FlagResult = True Then
            Me.Hide()
            Dim home As New frmHome With {
                .dangnhap = userLogin
            }
            home.Show()
        End If
    End Sub



    Private Sub tbMatKhau_MouseHover(sender As Object, e As EventArgs) Handles tbMatKhau.MouseHover
        Dim ToolTip1 As ToolTip = New ToolTip()
        ToolTip1.SetToolTip(Me.tbMatKhau, "Nhập mật khẩu")
    End Sub

    Private Sub lbThoat_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbThoat_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbThoat_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbTroVe_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbTroVe_MouseHover(sender As Object, e As EventArgs)

    End Sub
End Class
