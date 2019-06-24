Imports QLTVDAL
Imports QLTVDTO
Imports Utility
Imports System.Text.RegularExpressions

Public Class DocGiaBus
    Private dgDAL As NguoiDungDAL
    Private tsBus As ThamSoBus

    Public Sub New()
        dgDAL = New NguoiDungDAL()
        tsBus = New ThamSoBus()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New NguoiDungDAL(connectionString)
    End Sub

    Public Function isValidName(dg As DocGiaDTO) As Boolean

        If (dg.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function isValidAge(dg As DocGiaDTO) As Boolean

        'tinh toan tuoi
        Dim age As Integer
        age = Today.Year - dg.NgaySinh.Year
        If (dg.NgaySinh > Today.AddYears(-age)) Then age -= 1

        'kiem tra quy dinh
        Dim result As Result
        Dim thamso = New ThamSoDTO()
        result = tsBus.selectALL(thamso)

        If (result.FlagResult = False) Then
            Return False
        End If

        If (age < thamso.TuoiToiThieu Or age > thamso.TuoiToiDa) Then
            Return False
        End If

        Return True
    End Function

    Public Function isValidAddress(dg As DocGiaDTO) As Boolean

        If (dg.DiaChi.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function isValidEmail(dg As DocGiaDTO) As Boolean

        If (dg.Email.Length < 1) Then
            Return False
        End If

        Return Regex.IsMatch(dg.Email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Public Function isValidDateAdded(dg As DocGiaDTO) As Boolean

        Dim ngaylapthe = New DateTime(dg.NgayLapThe.Year, dg.NgayLapThe.Month, dg.NgayLapThe.Day)

        If (ngaylapthe > Today) Then
            Return False
        End If

        Return True
    End Function

    Public Function buildMaDocGia(ByRef nextMaDG As String) As Result
        Return dgDAL.build_madocgia(nextMaDG)
    End Function

    Public Function insert(dg As DocGiaDTO) As Result
        Return dgDAL.insert(dg)
    End Function

    Public Function selectAll(listDocGia As List(Of DocGiaDTO)) As Result
        Return dgDAL.selectALL(listDocGia)
    End Function

    Public Function selectALL_MaDG(madocgia As String, ByRef listDocGia As List(Of String)) As Result
        Return dgDAL.selectALL_MaDG(madocgia, listDocGia)
    End Function

    Public Function selectALL_TenDG(tendocgia As String, ByRef listDocGia As List(Of String)) As Result
        Return dgDAL.selectAll_TenDG(tendocgia, listDocGia)
    End Function

    Public Function select_EMAIL(email As String, ByRef listDocGia As List(Of String)) As Result
        Return dgDAL.selectALL_EMAIL(email, listDocGia)
    End Function

    Public Function selectALL_MaLoaiDG(maloaidocgia As String, listDocGia As List(Of String)) As Result
        Return dgDAL.selectALL_MaLoaiDG(maloaidocgia, listDocGia)
    End Function

    Public Function getDetailFromMaDG(ByRef madg As String, ByRef tendg As String, ByRef ngaysinh As DateTime, ByRef diachi As String,
                                      ByRef email As String, ByRef maloaidg As String, ByRef ngaylapthe As DateTime) As Result
        Return dgDAL.getDetailFromMaDG(madg, tendg, ngaysinh, diachi, email, maloaidg, ngaylapthe)
    End Function

    Public Function update(dg As DocGiaDTO) As Result
        Return dgDAL.update(dg)
    End Function

    Public Function findWithMaDG(ByRef maDocGia As String, ByRef tenDocGia As String, ByRef ngayLapThe As DateTime) As Result
        Return dgDAL.findWithMaDG(maDocGia, tenDocGia, ngayLapThe)
    End Function

    Public Function get_NgayLapThe_ByMaDG(ByRef madg As String, ByRef ngaylapthe As DateTime) As Result
        Return dgDAL.get_NgayLapThe_ByMaDG(madg, ngaylapthe)
    End Function

    Public Function deleteDG_ByMaDG(ByRef madg As String) As Result
        Return dgDAL.deleteDG_ByMaDG(madg)
    End Function
End Class
