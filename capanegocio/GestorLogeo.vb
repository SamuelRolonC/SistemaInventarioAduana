Public Class GestorLogeo
    Shared Sub ValidarLogeo(ByVal UsuarioIngresado As String, ByVal PassIngresada As String)
        Dim xUsuario As New Negocio.cUsuario()

        Dim enc As New Negocio.CriptoSha256()
        If Not xUsuario.BuscarDatosLogeo(UsuarioIngresado, enc.EncryptSHA256Managed(PassIngresada)) Then
            Throw New Exception("Usuario y/o contraseña incorrecta")
        End If

        ' @note Registrar el usuario de la sesion
        Dim xGestorSesion As New Negocio.GestorSesion
        xGestorSesion.GuardarUsuarioActual(UsuarioIngresado)
    End Sub
End Class
