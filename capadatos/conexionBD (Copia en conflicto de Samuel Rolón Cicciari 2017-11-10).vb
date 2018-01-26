Imports System.Data
Imports System.Data.SqlClient

Public Class conexionBD
    Public con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim con_string_samuel1 = "Data Source=DESKTOP-701F29C\SQLEXPRESS; Initial Catalog=AlmacenAduanaBD; Integrated Security=True;"
    Dim con_string_samuel2 = "Data Source=W-PC\SQLEXPRESS; Initial Catalog=AlmacenAduanaBD; Integrated Security=True;"
    Dim con_string_samuel3 = "Data Source=W-BlackHawk\SQLEXPRESS; Initial Catalog=AlmacenAduanaBD; Integrated Security=True;"
    Dim con_string_emmanuel = "Data Source=DESKTOP-Q6PEBRK\SQLEXPRESS; Initial Catalog=AlmacenAduanaBD; Integrated Security=True;"
    Dim con_string = con_string_samuel2

    Public Sub escrituraDatos(ByVal data_string As String) 
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd = con.CreateCommand
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = data_string
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            con.Close()
            cmd.Dispose()
            con.Dispose()
        End Try
    End Sub

    Public Function consultaDatos(ByVal data_string As String) As DataTable
        Try
            con.ConnectionString = con_string
            con.Open()
            cmd = con.CreateCommand
            cmd.Connection = con
            Using DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
                Using DS As DataSet = New DataSet
                    cmd.CommandText = data_string
                    cmd.ExecuteNonQuery()
                    DA.Fill(DS)
                    Return DS.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
            cmd.Dispose()
            con.Dispose()
        End Try
    End Function

End Class
