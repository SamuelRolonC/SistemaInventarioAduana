Public Class cPosicion
    Public Property Id As Integer
    Public Property nombre As String
    Public Property ubicacion As String
    Public Property PesoMax As Integer
    Public Property GalponId As Integer

    Public Sub guardarDatos()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("insert into posiciones values('" & Me.nombre & "'," & Me.GalponId & ",'" & Me.ubicacion & "'," & Me.PesoMax & ")")
    End Sub

    Public Function cargarDatos(Optional ByVal vGalponId As Integer = 0, Optional ByVal vId As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vGalponId <> 0 Then
            vCondicion = " where galpones_id = " & vGalponId
            If vId <> "" Then
                vCondicion = " and  id = " & vId
            End If
        End If

        If vGalponId = 0 And vId <> "" Then
            vCondicion = " where  id = " & vId
        End If

        Return xConexionBD.consultaDatos("select * from posiciones" & vCondicion)
    End Function

End Class
