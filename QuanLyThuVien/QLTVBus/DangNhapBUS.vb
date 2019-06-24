Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DangNhapBus
    Private dn As DangNhapDAL
    Public Sub New()
        dn = New DangNhapDAL()
    End Sub
    Public Sub New(connectionString As String)
        dn = New DangNhapDAL(connectionString)
    End Sub

    Public Function update(value As DangNhapDTO) As Result
        Return dn.update(value)
    End Function

    Public Function kiemTra(tendangnhap As String, matkhau As String, ByRef value As DangNhapDTO) As Result
        Return dn.kiemTra(tendangnhap, matkhau, value)
    End Function

End Class
