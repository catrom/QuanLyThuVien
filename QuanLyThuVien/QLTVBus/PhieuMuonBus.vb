Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonBus
    Private pms As PhieuMuonDAL
    Public Sub New()
        pms = New PhieuMuonDAL()
    End Sub
    Public Sub New(connectionString As String)
        pms = New PhieuMuonDAL(connectionString)
    End Sub

    Public Function build_maphieumuon(ByRef nextMaPhieuMuon As String) As Result
        Return pms.build_maphieumuon(nextMaPhieuMuon)
    End Function

    Public Function insert(pms As PhieuMuonDTO) As Result
        Return pms.insert(pms)
    End Function

    Public Function selectALL(ByRef listPhieuMuon As List(Of PhieuMuonDTO)) As Result
        Return pms.selectALL(listPhieuMuon)
    End Function
End Class
