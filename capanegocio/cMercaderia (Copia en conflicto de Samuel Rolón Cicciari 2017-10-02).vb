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

    Sub New(Optional ByVal vConocimiento As String = "desconocido", Optional ByVal vConocimientoOrigen As String = "desconocido", Optional ByVal vTipoComercio As String = "desconocido", Optional ByVal vCantidadBultos As Integer = 0, Optional ByVal vPesoNeto As Integer = 0, Optional ByVal vPesoBruto As Integer = 0, Optional ByVal vTamanoTotal As String = "desconocido", Optional ByVal vTipoMercaderia As String = "desconocido", Optional ByVal vOrigen As String = "desconocido", Optional ByVal vFechaIngreso As String = "", Optional ByVal vFechaDespacho As String = "", Optional ByVal vCondicion As String = "desconocido", Optional ByVal vComentarios As String = "desconocido", Optional ByVal vClienteId As String = "desconocido", Optional ByVal vPosicionId As Integer = 0)
        Me.conocimiento = vConocimiento
        Me.conocimientoOrigen = vConocimientoOrigen
        Me.tipoComercio = vTipoComercio
        Me.cantidadBultos = vCantidadBultos
        Me.pesoNeto = vPesoNeto
        Me.pesoBruto = vPesoBruto
        Me.tamanoTotal = vTamanoTotal
        Me.tipoMercaderia = vTipoMercaderia
        Me.origen = vOrigen
        Me.fechaIngreso = vFechaIngreso
        Me.fechaDespacho = vFechaDespacho
        Me.condicion = vCondicion
        Me.comentarios = vComentarios
        Me.clienteId = vClienteId
        Me.posicionId = vPosicionId
    End Sub

    Public Sub establecerValores(ByVal vAtributo As String, ByVal vValor As String)
        Select Case vAtributo
            Case "conocimiento"
                Me.conocimiento = vValor
            Case "conocimientoOrigen"
                Me.conocimientoOrigen = vValor
            Case "tipoComercio"
                Me.tipoComercio = vValor
            Case "cantidadBultos"
                Me.cantidadBultos = vValor
            Case "pesoNeto"
                Me.pesoNeto = vValor
            Case "pesoBruto"
                Me.pesoBruto = vValor
            Case "tamanoTotal"
                Me.tamanoTotal = vValor
            Case "tipoMercaderia"
                Me.tipoMercaderia = vValor
            Case "origen"
                Me.origen = vValor
            Case "fechaIngreso"
                Me.fechaIngreso = vValor
            Case "fechaDespacho"
                Me.fechaDespacho = vValor
            Case "condicion"
                Me.condicion = vValor
            Case "comentarios"
                Me.comentarios = vValor
            Case "clienteId"
                Me.clienteId = vValor
            Case "posicionId"
                Me.posicionId = vValor
        End Select
    End Sub

    Public Function obtenerValor(ByVal vAtributo As String) As String
        Dim vValor As String

        Select Case vAtributo
            Case "conocimiento"
                vValor = Me.conocimiento
            Case "conocimientoOrigen"
                vValor = Me.conocimientoOrigen
            Case "tipoComercio"
                vValor = Me.tipoComercio
            Case "cantidadBultos"
                vValor = Me.cantidadBultos
            Case "pesoNeto"
                vValor = Me.pesoNeto
            Case "pesoBruto"
                vValor = Me.pesoBruto
            Case "tamanoTotal"
                vValor = Me.tamanoTotal
            Case "tipoMercaderia"
                vValor = Me.tipoMercaderia
            Case "origen"
                vValor = Me.origen
            Case "fechaIngreso"
                vValor = Me.fechaIngreso
            Case "fechaDespacho"
                vValor = Me.fechaDespacho
            Case "condicion"
                vValor = Me.condicion
            Case "comentarios"
                vValor = Me.comentarios
            Case "clienteId"
                vValor = Me.clienteId
            Case "posicionId"
                vValor = Me.posicionId
            Case Else
                vValor = ""
        End Select
        Return vValor
    End Function

    Public Function cargarDatos(Optional ByVal vConocimiento As String = "", Optional ByVal vConocimientoOrigen As String = "")
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD
        Dim vCondicion As String = ""

        If vConocimiento <> "" Then
            vCondicion = " where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'"
        End If

        Return xConexionBD.consultaDatos("select * from mercaderias" & vCondicion)
    End Function

    Public Sub guardarDatos(ByVal vMercaderia As cMercaderia)
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

        xConexionBD.escrituraDatos("insert into mercaderias values('" & vMercaderia.obtenerValor("conocimiento") & "','" & vMercaderia.obtenerValor("conocimientoOrigen") &
                                   "','" & vMercaderia.obtenerValor("tipoComercio") & "'," & Conversion.Int(vMercaderia.obtenerValor("cantidadBultos")) & "," &
                                   Conversion.Int(vMercaderia.obtenerValor("pesoNeto")) & "," & Conversion.Int(vMercaderia.obtenerValor("pesoBruto")) & ",'" &
                                   vMercaderia.obtenerValor("tamanoTotal") & "','" & vMercaderia.obtenerValor("tipoMercaderia") & "','" & vMercaderia.obtenerValor("origen") &
                                  "'," & vFechaIngreso & "," & vFechaDespacho & ",'" & vMercaderia.obtenerValor("condicion") & "','" & vMercaderia.obtenerValor("comentarios") &
                                  "','" & vMercaderia.obtenerValor("clienteId") & "', " & Conversion.Int(vMercaderia.obtenerValor("posicionId")) & ",'" & vMercaderia.rotulo & "')")
    End Sub

    Public Sub modificarDatos(ByVal vConocimiento As String, ByVal vConocimientoOrigen As String, ByVal vAtributo As String, ByVal vValor As String)
        Dim xConexionBD As New AlmacenAduana.Datos.conexionBD

        xConexionBD.escrituraDatos("update mercaderias set " & vAtributo & " = '" & vValor & "' where conocimiento = '" & vConocimiento & "' and conocimientoOrigen = '" & vConocimientoOrigen & "'")

    End Sub
End Class
