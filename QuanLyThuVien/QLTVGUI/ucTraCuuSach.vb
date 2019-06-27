Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ucTraCuuSach
    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click

    End Sub

    Private Sub ucTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnXuatKetQua_Click(sender As Object, e As EventArgs) Handles btnXuatKetQua.Click

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim parent As ucTraCuuSach
        parent = sender.Parent
        Dim parent2 As ucTraCuu
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim tracuu As New ucTraCuu
        parent3.Controls.Clear()
        parent3.Controls.Add(tracuu)
    End Sub
End Class
