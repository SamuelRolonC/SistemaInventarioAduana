Public Class cMercaderia
    Public Property conocimiento As String
    Public Property conocimientoOrigen As String
    Public Property rotulo As String
    Public Property tipoComercio As String
    Public Property cantidadBultos As Integer
    Public Property pesoNeto As Integer
    Public Property pesoBruto As Integer
    Public Property tamanoTotal As String
    Public Property tipoMercaderia As String
    Public Property origen As String
    Public Property fechaIngreso As String
    Public Property fechaDespacho As String
    Public Property condicion As String
    Public Property comentarios As String
    Public Property clienteId As String
    Public Property posicionId As Integer

    Public Function CargarTabla(Optional ByVal vConocimiento As String = "", Optional ByVal vConocimientoOrigen As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vConocimiento <> "" Then
            vCondicion = " where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'"
        End If

        Return xConexionBD.consultaDatos("select * from mercaderias" & vCondicion)
    End Function

    Public Sub GuardarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vFechaIngreso As String
        Dim vFechaDespacho As String

        If Me.fechaIngreso = "" Then
            vFechaIngreso = "getdate()"
        Else
            vFechaIngreso = "'" & Me.fechaIngreso & "'"
        End If

        If Me.fechaDespacho = "" Then
            vFechaDespacho = "getdate()"
        Else
            vFechaDespacho = Me.fechaDespacho
        End If

        xConexionBD.escrituraDatos("insert into mercaderias values('" & Me.conocimiento & "','" & Me.conocimientoOrigen &
                                   "','" & Me.tipoComercio & "'," & Conversion.Int(Me.cantidadBultos) & "," &
                                   Conversion.Int(Me.pesoNeto) & ", " & Conversion.Int(Me.pesoBruto) & ",'" &
                                   Me.tamanoTotal & "','" & Me.tipoMercaderia & "','" & Me.origen &
                                  "'," & vFechaIngreso & "," & vFechaDespacho & ",'" & Me.condicion & "','" & Me.comentarios &
                                  "','" & Me.clienteId & "', " & Conversion.Int(Me.posicionId) & ",'" & Me.rotulo & "')")
    End Sub

    Public Sub ModificarRegistro()
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("update mercaderias set rotulo = '" & Me.rotulo & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set tipoComercio = '" & Me.tipoComercio & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set cantidadBultos = " & Me.cantidadBultos & " where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set pesoNeto = " & Me.pesoNeto & " where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set pesoBruto = " & Me.pesoBruto & " where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set tamanoTotal = '" & Me.tamanoTotal & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set tipoMercaderia = '" & Me.tipoMercaderia & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set origen = '" & Me.origen & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set fechaIngreso = '" & Me.fechaIngreso & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set fechaDespacho = '" & Me.fechaDespacho & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set condicion = '" & Me.condicion & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set comentarios = '" & Me.comentarios & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set clientes_id = '" & Me.clienteId & "' where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")
        xConexionBD.escrituraDatos("update mercaderias set posiciones_id = " & Me.posicionId & " where conocimiento = '" & Me.conocimiento & "' and conocimientoOrigen = '" & Me.conocimientoOrigen & "'")

    End Sub

    Public Sub BorrarRegistro(ByVal vConocimiento As String, ByVal vConocimientoOrigen As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("delete from mercaderias where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'")
    End Sub

    Public Function ModificarDespachoRegistro(ByVal vConocimiento As String, ByVal vConocimientoOrigen As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vMercaderia As DataRow

        xConexionBD.escrituraDatos("update mercaderias set fechaDespacho = getdate() where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'")

        vMercaderia = xConexionBD.consultaDatos("select fechaDespacho from mercaderias where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'").Rows(0)
        Return vMercaderia("fechaDespacho")
    End Function

    Public Sub ObtenerMercaderia(ByVal Conocimiento As String, ByVal ConocimientoOrigen As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim xDT As New DataTable
        Dim vMercaderia As DataRow

        xDT = xConexionBD.consultaDatos("select * from mercaderias where conocimiento = '" & Conocimiento & "' and conocimientoOrigen = '" & ConocimientoOrigen & "'")
        vMercaderia = xDT.Rows(0)

        Me.conocimiento = vMercaderia("conocimiento")
        Me.conocimientoOrigen = vMercaderia("conocimientoOrigen")
        Me.rotulo = vMercaderia("rotulo")
        Me.tipoComercio = vMercaderia("tipoComercio")
        Me.cantidadBultos = vMercaderia("cantidadBultos")
        Me.pesoNeto = vMercaderia("pesoNeto")
        Me.pesoBruto = vMercaderia("pesoBruto")
        Me.tamanoTotal = vMercaderia("tamanoTotal")
        Me.tipoMercaderia = vMercaderia("tipoMercaderia")
        Me.origen = vMercaderia("origen")
        Me.fechaIngreso = vMercaderia("fechaIngreso")
        Me.fechaDespacho = vMercaderia("fechaDespacho")
        Me.condicion = vMercaderia("condicion")
        Me.comentarios = vMercaderia("comentarios")
        Me.clienteId = vMercaderia("clientes_id")
        Me.posicionId = vMercaderia("posiciones_Id")
    End Sub
End Class
