Public Class cCliente
    Public Property nombre As String
    Public Property id As String
    Public Property telefono As String
    Public Property mail As String

    Public Sub guardarDatos()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("insert into clientes values(" & Me.id & ",'" & Me.nombre & "','" & Me.telefono & "','" & Me.mail & "')")
    End Sub

    Public Function CargarTabla(Optional ByVal vId As Integer = 0)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vId <> 0 Then
            vCondicion = " where id = " & vId
        End If

        Return xConexionBD.consultaDatos("select * from clientes" & vCondicion)
    End Function

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("update clientes set nombre = '" & Me.nombre & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update clientes set id = '" & Me.id & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update clientes set telefono = '" & Me.telefono & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update clientes set mail = '" & Me.mail & "' where id = '" & Me.id & "'")
    End Sub

    Public Sub BorrarRegistro(ByVal vid As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from clientes where id = '" & vid & "'")
    End Sub

    Public Sub ObtenerCliente(ByVal vId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vCliente As DataRow

        xDT = xConexionBD.consultaDatos("select * from clientes where id = '" & vId & "'")
        vCliente = xDT.Rows(0)

        Me.id = vCliente("id")
        Me.nombre = vCliente("nombre")
        Me.telefono = vCliente("telefono")
        Me.mail = vCliente("mail")
    End Sub
End Class
