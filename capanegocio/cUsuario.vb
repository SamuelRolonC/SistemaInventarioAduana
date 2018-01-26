Public Class cUsuario
    Public Property id As String
    Public Property pass As String
    Public Property nombre As String
    Public Property apellido As String
    Public Property email As String
    Public Property habilitado As Boolean

    Shared Function CargarTabla() As DataTable
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Return xConexionBD.consultaDatos("select id, nombre, apellido, email, habilitado from usuarios")
    End Function

    Public Function BuscarDatosLogeo(ByVal Usuario As String, ByVal Pass As String) As Boolean
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        Return xConexionBD.consultaDatos("select * from usuarios where id = '" & Usuario & "' and pass = '" & Pass & "' and habilitado = 1").Rows.Count <> 0
    End Function

    Public Sub GuardarDatos()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vHabilitado As String
        Dim mailWrapper As New Cripto3DES()
        Dim passWrapper As New CriptoSha256()

        If habilitado Then
            vHabilitado = "1"
        Else
            vHabilitado = "0"
        End If

        xConexionBD.escrituraDatos("insert into usuarios values( '" & Me.id & "','" & Me.nombre & "','" & Me.apellido & "','" & mailWrapper.EncritparDato(Me.email) & "','" & passWrapper.EncryptSHA256Managed(Me.pass) & "'," & vHabilitado & ")")
    End Sub

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim passWrapper As New CriptoSha256()
        Dim mailWrapper As New Cripto3DES()
        Dim vHabilitado As Integer

        If Me.habilitado Then
            vHabilitado = 1
        Else
            vHabilitado = 0
        End If

        xConexionBD.escrituraDatos("update usuarios set nombre = '" & Me.nombre & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update usuarios set apellido = '" & Me.apellido & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update usuarios set email = '" & mailWrapper.EncritparDato(Me.email) & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update usuarios set habilitado = " & vHabilitado & " where id = '" & Me.id & "'")
    End Sub

    Public Sub ObtenerUsuario(ByVal Id As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vUsuario As DataRow

        xDT = xConexionBD.consultaDatos("select * from usuarios where id = '" & Id & "'")
        vUsuario = xDT.Rows(0)

        Me.id = vUsuario("id")
        Me.pass = vUsuario("pass")
        Me.nombre = vUsuario("nombre")
        Me.apellido = vUsuario("apellido")
        Me.email = vUsuario("email")
        Me.habilitado = vUsuario("habilitado")
    End Sub

    Public Sub ValidarUsuario()
        If Me.id = "" Then
            Throw New Exception("Debe ingresar un nombre de usuario")
        End If

        If Me.id.Length < 3 Then
            Throw New Exception("El nombre de usuario debe tener al menos 3 caracteres")
        End If

        If IsNumeric(Me.id) Then
            Throw New Exception("El nombre de usuario no puede contener solo caracteres numéricos")
        End If

        If Me.nombre = "" Then
            Throw New Exception("Debe ingresar un nombre")
        End If

        If Me.apellido = "" Then
            Throw New Exception("Debe ingresar un apellido")
        End If

        If Me.email = "" Then
            Throw New Exception("Debe ingresar un mail")
        End If
    End Sub

    Public Sub ValidarPass(ByVal ConfirmacionPass As String)
        If Me.pass = "" Then
            Throw New Exception("Debe ingresar una contraseña de usuario")
        End If

        If Me.pass.Length < 6 Then
            Throw New Exception("La contraseña de usuario debe tener al menos 6 caracteres")
        End If

        If ConfirmacionPass = "" Then
            Throw New Exception("Debe confirmar la contraseña")
        End If

        If Me.pass <> ConfirmacionPass Then
            Throw New Exception("Las contraseñas deben coincidir")
        End If
    End Sub
End Class
