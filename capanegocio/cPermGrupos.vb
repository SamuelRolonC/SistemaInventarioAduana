Public Class cPermGrupos

    Public Property permisosId As String
    Public Property gruposId As String
    Public Property alta As Boolean
    Public Property baja As Boolean
    Public Property modificacion As Boolean
    Public Property lectura As Boolean

    Public Function CargarTabla(Optional ByVal vGrupoId As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vGrupoId <> "" Then
            vCondicion = " where grupos_id = '" & vGrupoId & "'"
        End If

        Return xConexionBD.consultaDatos("select * from perm_grupos" & vCondicion)
    End Function

    Public Sub GuardarDatos()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vAlta As String
        Dim vBaja As String
        Dim vModificacion As String
        Dim vLectura As String

        If Me.alta Then
            vAlta = "1"
        Else
            vAlta = "0"
        End If

        If Me.baja Then
            vBaja = "1"
        Else
            vBaja = "0"
        End If

        If Me.modificacion Then
            vModificacion = "1"
        Else
            vModificacion = "0"
        End If

        If Me.lectura Then
            vLectura = "1"
        Else
            vLectura = "0"
        End If

        xConexionBD.escrituraDatos("insert into perm_grupos values('" & Me.gruposId & "','" & Me.permisosId & "'," & vAlta & "," & vBaja & "," & vModificacion & "," & vLectura & ")")
    End Sub

    Shared Sub BorrarRegistro(ByVal vGrupoId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from perm_grupos where grupos_id = '" & vGrupoId & "'")
    End Sub

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vAlta As String
        Dim vBaja As String
        Dim vModificacion As String
        Dim vLectura As String

        If Me.alta Then
            vAlta = "1"
        Else
            vAlta = "0"
        End If

        If Me.baja Then
            vBaja = "1"
        Else
            vBaja = "0"
        End If

        If Me.modificacion Then
            vModificacion = "1"
        Else
            vModificacion = "0"
        End If

        If Me.lectura Then
            vLectura = "1"
        Else
            vLectura = "0"
        End If

        xConexionBD.escrituraDatos("update perm_grupos set alta = " & vAlta & " where permisos_id = '" & Me.permisosId & "' and grupos_id = '" & Me.gruposId & "'")
        xConexionBD.escrituraDatos("update perm_grupos set baja = " & vBaja & " where permisos_id = '" & Me.permisosId & "' and grupos_id = '" & Me.gruposId & "'")
        xConexionBD.escrituraDatos("update perm_grupos set modificacion = " & vModificacion & " where permisos_id = '" & Me.permisosId & "' and grupos_id = '" & Me.gruposId & "'")
        xConexionBD.escrituraDatos("update perm_grupos set lectura = " & vLectura & " where permisos_id = '" & Me.permisosId & "' and grupos_id = '" & Me.gruposId & "'")
    End Sub

    Shared Function CargarPermisosDeUsuario(ByVal vUsuarioId As String) As DataTable
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Return xConexionBD.consultaDatos("select g.id as GrupoNombre, p.id as PermisoNombre, alta,baja,modificacion,lectura from perm_grupos pg inner join permisos p on p.id = pg.permisos_id inner join grupos g on g.id = pg.grupos_id where grupos_id in (select grupos_id from us_grupos where usuarios_id = '" & vUsuarioId & "') and g.habilitado = 1")
    End Function
End Class