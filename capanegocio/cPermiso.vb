Public Class cPermiso
    Public Property id As String

    Shared Function ComprobarPermisosUsuario(ByVal vUsuario As String, ByVal vNombrePermiso As String, ByVal vTipoPermiso As String) As Boolean

        Dim vTienePermiso As Boolean = False

        ' Ejemplo de NombrePermiso: Mercaderias
        ' Ejemplo de TipPermiso: alta, baja, modificacion, listado

        For Each vFilaPermiso As System.Data.DataRow In Negocio.cPermGrupos.CargarPermisosDeUsuario(vUsuario).Rows
            If vTienePermiso Then
                Exit For
            End If
            If vFilaPermiso("PermisoNombre") = vNombrePermiso Then
                vTienePermiso = vFilaPermiso(vTipoPermiso)
            End If
        Next

        Return vTienePermiso
    End Function
End Class
