Module mFuncsYProcs

    Sub sLimpiarCadaTextBox(ByVal vForm As Form)
        ' recorrer todos los controles del formulario indicado  
        For Each vControl As Control In vForm.Controls
            If TypeOf vControl Is TextBox Then
                vControl.Text = "" ' eliminar el texto  
            End If
        Next
    End Sub

    Sub sLimpiarGroupBox(ByVal vGroupBox As Windows.Forms.GroupBox)
        Dim vControl As Object
        For Each vControl In vGroupBox.Controls
            If vControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                vControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    Sub HabilitarTByCB(ByVal vForm As Form, ByVal vHabilitar As Boolean)
        For Each vControl As Control In vForm.Controls
            If (TypeOf vControl Is TextBox) Or (TypeOf vControl Is ComboBox) Then
                vControl.Enabled = vHabilitar
            End If
        Next
    End Sub

    Sub HabilitarGroupBox(ByVal vGroupBox As Windows.Forms.GroupBox, ByVal vHabilitar As Boolean)
        Dim vControl As Object
        For Each vControl In vGroupBox.Controls
            If vControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                vControl.Enabled = vHabilitar
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

    Sub CargarComboBox(ByVal vComboBox As Windows.Forms.ComboBox, ByVal vListDescripciones As List(Of String))
        Dim xListComboBox As New List(Of Negocio.cComboBox)
        Dim xComboBox As New Negocio.cComboBox
        Dim vId As Integer = 0

        For Each vDescripcion As String In vListDescripciones
            xComboBox = New Negocio.cComboBox
            vId = vId + 1

            xComboBox.descripcion = vDescripcion
            xComboBox.id = vId
            xListComboBox.Add(xComboBox)
        Next

        vComboBox.ValueMember = "id"
        vComboBox.DisplayMember = "descripcion"
        vComboBox.DataSource = xListComboBox
    End Sub

    Sub EstablecerCmbTipoMercaderia(ByVal vCmbTipoMercaderia As Windows.Forms.ComboBox)
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xListOpciones.Add("General")
        xListOpciones.Add("Quimico")
        xListOpciones.Add("Mala Condicion")

        mFuncsYProcs.CargarComboBox(vCmbTipoMercaderia, xListOpciones)
    End Sub

    Sub EstablecerCmbTipoComercio(ByVal vCmbTipoComercio As Windows.Forms.ComboBox)
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xListOpciones.Add("Seleccionar")
        xListOpciones.Add("Importacion")
        xListOpciones.Add("Exportacion")

        mFuncsYProcs.CargarComboBox(vCmbTipoComercio, xListOpciones)
    End Sub

    Sub EstablecerCmbCondicion(ByVal vCmbCondicion As Windows.Forms.ComboBox)
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xListOpciones.Add("Seleccionar")
        xListOpciones.Add("Buena")
        xListOpciones.Add("Mala")

        mFuncsYProcs.CargarComboBox(vCmbCondicion, xListOpciones)
    End Sub

    Sub EstablecerCmbPosicion(ByVal vCmbPosicion As Windows.Forms.ComboBox, ByVal vGalpon As Integer)
        Dim xPosicion As New Negocio.cPosicion
        Dim xDT As New DataTable
        Dim xIndice As Integer = 1
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xDT = xPosicion.cargarDatos(vGalpon)

        xListOpciones.Add("Seleccionar") ' Primera opcion para el Combo Box

        For Each vFila As System.Data.DataRow In xDT.Rows
            xListOpciones.Add(CStr(vFila("id")))
        Next

        mFuncsYProcs.CargarComboBox(vCmbPosicion, xListOpciones)
    End Sub

    Sub EstablecerCmbGalpon(ByVal vCmbGalpon As Windows.Forms.ComboBox)
        Dim xGalpon As New Negocio.cGalpon
        Dim xDT As New DataTable
        Dim xIndice As Integer = 1
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xDT = xGalpon.Cargartabla()

        xListOpciones.Add("Seleccionar") ' Primera opcion para el Combo Box

        For Each vFila As System.Data.DataRow In xDT.Rows
            xListOpciones.Add(CStr(vFila("id")))
        Next

        mFuncsYProcs.CargarComboBox(vCmbGalpon, xListOpciones)
    End Sub

    Sub EstablecerCmbCliente(ByVal vCmbCliente As Windows.Forms.ComboBox)
        Dim xCliente As New Negocio.cCliente
        Dim xDT As New DataTable
        Dim xIndice As Integer = 1
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xDT = xCliente.CargarTabla()

        xListOpciones.Add("Seleccionar") ' Primera opcion para el Combo Box

        For Each vFila As System.Data.DataRow In xDT.Rows
            xListOpciones.Add(CStr(vFila("id")))
        Next

        mFuncsYProcs.CargarComboBox(vCmbCliente, xListOpciones)
    End Sub

    Sub ReestablecerCadaLabel(ByVal vForm As Form)
        For Each vControl As Control In vForm.Controls
            If TypeOf vControl Is Label Then
                vControl.ForeColor = Color.Black
            End If
        Next
    End Sub

    Sub LimpiarTreeView(ByVal vTreeView As Windows.Forms.TreeView)

        For Each vNodoPadre As TreeNode In vTreeView.Nodes
            vNodoPadre.Checked = False
            For Each vNodoHijo As TreeNode In vNodoPadre.Nodes
                vNodoHijo.Checked = False
            Next
        Next
    End Sub

    Sub EstablecerCmbEntrepiso(ByVal vCmbEntrepiso As Windows.Forms.ComboBox)
        Dim xComboBox As New Negocio.cComboBox
        Dim xListOpciones As New List(Of String)

        xListOpciones.Add("Seleccionar")
        xListOpciones.Add("SI")
        xListOpciones.Add("NO")
        mFuncsYProcs.CargarComboBox(vCmbEntrepiso, xListOpciones)
    End Sub
End Module