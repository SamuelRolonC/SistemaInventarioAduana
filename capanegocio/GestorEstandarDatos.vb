Public Class GestorEstandarDatos

    Shared Function CargarTabla(ByVal NombreTabla As String) As DataTable
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Return xConexionBD.consultaDatos("select * from " & NombreTabla)
    End Function

    Shared Sub BorrarRegistro(ByVal NombreTabla As String, ByVal Id As Integer)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from " & NombreTabla & " where id = " & Id)
    End Sub

    Shared Function ObtenerId(ByVal NombreTabla As String, ByVal vAtributo As String)
        '@note Para toda clase/entidad que requiera usar este metodo reconsiderar cambiar la tabla haciendo del campo que se usa 
        'como parametro en este metodo la clave primaria y unica de la tabla
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vRegistro As DataRow

        xDT = xConexionBD.consultaDatos("select * from " & NombreTabla & " where nombre = '" & vAtributo & "'")
        vRegistro = xDT.Rows(0)

        Return vRegistro("id")
    End Function

    Shared Sub BorrarRegistro(ByVal NombreTabla As String, ByVal TipoDato As String, ByVal Id As String)

        If TipoDato = "String" Then
            Id = "'" & Id & "'"
        End If

        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        xConexionBD.escrituraDatos("delete from " & NombreTabla & " where id = " & Id)
    End Sub
End Class
