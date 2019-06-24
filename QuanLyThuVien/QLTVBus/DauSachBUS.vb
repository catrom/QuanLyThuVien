Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DauSachBus
    Private s As DauSachDAL
    Public Sub New()
        s = New DauSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        s = New DauSachDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSachDTO)) As Result
        Return s.selectALL(list)
    End Function

    Public Function buildMaDauSach(ByRef value As String) As Result
        Return s.buildMaDauSach(value)
    End Function

    Public Function update(value As DauSachDTO) As Result
        Return s.update(value)
    End Function

    Public Function insert(value As DauSachDTO) As Result
        Return s.insert(value)
    End Function

End Class

