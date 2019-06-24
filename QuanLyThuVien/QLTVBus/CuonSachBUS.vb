Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class CuonSachBUS
    Private cs As CuonSachDAL

    Public Sub New()
        cs = New CuonSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        cs = New CuonSachDAL(connectionString)
    End Sub

    Public Function buildMaCuonSach(ByRef value As String) As Result
        Return cs.buildMaCuonSach(value)
    End Function

    Public Function selectALL(ByRef list As List(Of CuonSachDTO)) As Result
        Return cs.selectALL(list)
    End Function

    Public Function insert(ctpm As CuonSachDTO) As Result
        Return cs.insert(ctpm)
    End Function
End Class

