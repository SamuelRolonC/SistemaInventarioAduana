Public Class cGalpon
    Public Property id As Integer
    Public Property nombre As String
    Public Property descripcion As String

    Public Sub guardarDatos()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("insert into Galpones values('" & Me.nombre & "','" & Me.descripcion & "')")
    End Sub

    Public Function Cargartabla(Optional ByVal vId As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vId <> "" Then
            vCondicion = " where conocimiento = " & vId
        End If

        Return xConexionBD.consultaDatos("select * from galpones" & vCondicion)
    End Function

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("update galpones set descripcion = '" & Me.descripcion & "' where id = '" & Me.id & "'")
        xConexionBD.escrituraDatos("update galpones set id = '" & Me.id & "' where id = '" & Me.id & "'")
    End Sub
    Public Sub BorrarRegistro(ByVal vid As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from mercaderias where id = '" & vid & "'")
    End Sub

    Public Function ObtenerId(ByVal vNombre As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vGalpon As DataRow

        xDT = xConexionBD.consultaDatos("select * from galpones where nombre = '" & vNombre & "'")
        vGalpon = xDT.Rows(0)

        Return vGalpon("id")
    End Function

    Public Sub ObtenerGalpon(ByVal vId As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vGalpon As DataRow

        xDT = xConexionBD.consultaDatos("select * from galpones where id = '" & vId & "'")
        vGalpon = xDT.Rows(0)

        Me.id = vGalpon("id")
        Me.nombre = vGalpon("nombre")
        Me.descripcion = vGalpon("descripcion")
    End Sub
End Class
