Public Class cUsGrupos
    Public Property usuarioId As String
    Public Property grupoId As String

    Shared Function CargarTabla(Optional ByVal vIdUsuario As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vIdUsuario <> "" Then
            vCondicion = " where usuarios_id = '" & vIdUsuario & "'"
        End If

        Return xConexionBD.consultaDatos("select * from us_grupos" & vCondicion)
    End Function

    Public Sub GuardarRegistro(ByVal Modificacion As Boolean)
        Dim ConsultaSimple As String = "insert into us_grupos values('" & Me.usuarioId & "','" & Me.grupoId & "')"
        Dim ConsultaConCondicional As String = "if not exists(select * from us_grupos where usuarios_id = '" & Me.usuarioId & "' and grupos_id = '" & Me.grupoId & "') begin " & ConsultaSimple & " end"

        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        If Modificacion Then
            xConexionBD.escrituraDatos(ConsultaConCondicional)
        Else
            xConexionBD.escrituraDatos(ConsultaSimple)
        End If
    End Sub

    Shared Sub BorrarRegistrosSegun(ByVal CampoId As String, ByVal ValorId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Select Case CampoId
            Case "Usuario"
                CampoId = "usuarios_id"
            Case "Grupo"
                CampoId = "grupos_id"
            Case Else
                Exit Sub
        End Select

        xConexionBD.escrituraDatos("delete from us_grupos where " & CampoId & " = '" & ValorId & "'")
    End Sub

    Shared Sub BorrarRegistro(ByVal UsuarioId As String, ByVal GrupoId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from us_grupos where usuarios_id = '" & UsuarioId & "' and grupos_id = '" & GrupoId & "'")
    End Sub

    Shared Function ExisteUsGrupo(ByVal UsuarioId As String, ByVal GrupoId As String) As Boolean
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable

        xDT = xConexionBD.consultaDatos("select * from grupos where usuarios_id = '" & UsuarioId & "' and grupos_id = '" & GrupoId & "'")
        Return Not IsNothing(xDT.Rows(0))
    End Function
End Class
