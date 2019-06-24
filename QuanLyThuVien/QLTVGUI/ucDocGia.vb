Public Class ucDocGia
    Private Sub btnThemDocGia_Click(sender As Object, e As EventArgs) Handles btnThemDocGia.Click
        Me.Controls.Clear()
        Dim ucLapTheDocGia As New ucLapTheDocGia
        Me.Controls.Add(ucLapTheDocGia)
        ucLapTheDocGia.BringToFront()
    End Sub

    Private Sub btnTimDocGia_Click(sender As Object, e As EventArgs) Handles btnTimDocGia.Click
        Me.Controls.Clear()
        Dim ucTimDocGia As New ucTimDocGia
        Me.Controls.Add(ucTimDocGia)
        ucTimDocGia.BringToFront()
    End Sub
End Class
