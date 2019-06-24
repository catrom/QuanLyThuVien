Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class TinhTrangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectAll(ByRef listTT As List(Of TinhTrangDTO)) As Result

        Dim query As String = String.Empty
        query &= " select [matinhtrang], [tentinhtrang]"
        query &= " from [tblTrangThai]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listTT.Clear()
                        While reader.Read()
                            listTT.Add(New TinhTrangDTO(reader("matinhtrang"), reader("tentinhtrang")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả trạng thái không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(value As TinhTrangDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblTinhTrang]"
        query &= " VALUES (@matinhtrang, @tentinhtrang)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", value.MaTinhTrang)
                    .Parameters.AddWithValue("@tentinhtrang", value.TenTinhTrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(value As TinhTrangDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblTinhTrang] SET"
        query &= " [tentinhtrang] = @tentinhtrang "
        query &= " WHERE "
        query &= " [matinhtrang] = @matinhtrang"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tentinhtrang", value.TenTinhTrang)
                    .Parameters.AddWithValue("@matinhtrang", value.MaTinhTrang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
