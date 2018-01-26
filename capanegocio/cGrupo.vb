Public Class cGrupo
    Public Property id As String
    Public Property habilitado As Boolean

    Public Sub GuardarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vHabilitado As String

        If habilitado Then
            vHabilitado = "1"
        Else
            vHabilitado = "0"
        End If

        xConexionBD.escrituraDatos("insert into grupos values('" & Me.id & "'," & vHabilitado & ")")
    End Sub

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vHabilitado As String

        If habilitado Then
            vHabilitado = "1"
        Else
            vHabilitado = "0"
        End If

        xConexionBD.escrituraDatos("update grupos set habilitado = " & vHabilitado & " where id = '" & Me.id & "'")
    End Sub

    Public Sub ObtenerGrupo(ByVal vId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vGrupo As DataRow

        xDT = xConexionBD.consultaDatos("select * from grupos where id = '" & vId & "'")
        vGrupo = xDT.Rows(0)

        Me.id = vGrupo("id")
        Me.habilitado = vGrupo("habilitado")
    End Sub

    Shared Function CargarGruposHabilitados() As DataTable
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Return xConexionBD.consultaDatos("SELECT * FROM grupos where HABILITADO = 1")
    End Function

    '@param ValidarGrupo Para validar la modificación de un grupo se debe dar un argumento para NombreAnterior
    Public Sub ValidarGrupo(Optional ByVal NombreAnterior As String = "")

        If Me.id = "" Then
            Throw New Exception("El grupo debe tener un nombre")
        End If

        If NombreAnterior <> "" Then
            '@note Si cambia el nombre que no sea igual a otro existente
            If Me.id <> NombreAnterior Then
                If Negocio.cGrupo.ExisteGrupo(Me.id) Then
                    Throw New Exception("Ya existe un grupo con ese nombre")
                End If
            End If
        End If
    End Sub

    Shared Function ExisteGrupo(ByVal Nombre As String) As Boolean
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable

        xDT = xConexionBD.consultaDatos("select * from grupos where id = '" & Nombre & "'")
        Return Not IsNothing(xDT.Rows(0))
    End Function
End Class