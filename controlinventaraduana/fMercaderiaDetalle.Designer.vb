<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMercaderiaDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnListaMercaderias = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtRotulo = New System.Windows.Forms.TextBox()
        Me.lblRotulo = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmbGalpon = New System.Windows.Forms.ComboBox()
        Me.cmbPosicion = New System.Windows.Forms.ComboBox()
        Me.cmbCondicion = New System.Windows.Forms.ComboBox()
        Me.cmbTipoComercio = New System.Windows.Forms.ComboBox()
        Me.lblTipoComercio = New System.Windows.Forms.Label()
        Me.cmbTipoMercaderia = New System.Windows.Forms.ComboBox()
        Me.txtPesoBruto = New System.Windows.Forms.TextBox()
        Me.lblPesoBruto = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.lblTipoMercaderia = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtTamanoTotal = New System.Windows.Forms.TextBox()
        Me.txtPesoNeto = New System.Windows.Forms.TextBox()
        Me.txtCantBultos = New System.Windows.Forms.TextBox()
        Me.txtConocimientoOrigen = New System.Windows.Forms.TextBox()
        Me.txtConocimiento = New System.Windows.Forms.TextBox()
        Me.lblConocimientoOrigen = New System.Windows.Forms.Label()
        Me.lblConocimiento = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.lblGalpon = New System.Windows.Forms.Label()
        Me.lblTamanoTotal = New System.Windows.Forms.Label()
        Me.lblPesoNeto = New System.Windows.Forms.Label()
        Me.lblCantBultos = New System.Windows.Forms.Label()
        Me.lblFechaDespacho = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDespacho = New System.Windows.Forms.DateTimePicker()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(616, 526)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 74
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnListaMercaderias)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 54
        '
        'btnListaMercaderias
        '
        Me.btnListaMercaderias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaMercaderias.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnListaMercaderias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaMercaderias.Location = New System.Drawing.Point(667, 0)
        Me.btnListaMercaderias.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnListaMercaderias.Name = "btnListaMercaderias"
        Me.btnListaMercaderias.Size = New System.Drawing.Size(117, 30)
        Me.btnListaMercaderias.TabIndex = 21
        Me.btnListaMercaderias.Text = "Lista de Mercaderías"
        Me.btnListaMercaderias.UseVisualStyleBackColor = True
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 20
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(697, 526)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 88
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(697, 497)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 19
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'txtRotulo
        '
        Me.txtRotulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRotulo.Location = New System.Drawing.Point(202, 136)
        Me.txtRotulo.Name = "txtRotulo"
        Me.txtRotulo.Size = New System.Drawing.Size(100, 22)
        Me.txtRotulo.TabIndex = 3
        '
        'lblRotulo
        '
        Me.lblRotulo.AutoSize = True
        Me.lblRotulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotulo.Location = New System.Drawing.Point(58, 137)
        Me.lblRotulo.Name = "lblRotulo"
        Me.lblRotulo.Size = New System.Drawing.Size(53, 16)
        Me.lblRotulo.TabIndex = 122
        Me.lblRotulo.Text = "Rotulo :"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(649, 272)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCliente.TabIndex = 120
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(528, 274)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(100, 21)
        Me.cmbCliente.TabIndex = 14
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(369, 277)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(55, 16)
        Me.lblCliente.TabIndex = 118
        Me.lblCliente.Text = "Cliente :"
        '
        'cmbGalpon
        '
        Me.cmbGalpon.FormattingEnabled = True
        Me.cmbGalpon.Location = New System.Drawing.Point(202, 247)
        Me.cmbGalpon.Name = "cmbGalpon"
        Me.cmbGalpon.Size = New System.Drawing.Size(100, 21)
        Me.cmbGalpon.TabIndex = 7
        '
        'cmbPosicion
        '
        Me.cmbPosicion.FormattingEnabled = True
        Me.cmbPosicion.Location = New System.Drawing.Point(202, 275)
        Me.cmbPosicion.Name = "cmbPosicion"
        Me.cmbPosicion.Size = New System.Drawing.Size(100, 21)
        Me.cmbPosicion.TabIndex = 8
        '
        'cmbCondicion
        '
        Me.cmbCondicion.FormattingEnabled = True
        Me.cmbCondicion.Location = New System.Drawing.Point(528, 136)
        Me.cmbCondicion.Name = "cmbCondicion"
        Me.cmbCondicion.Size = New System.Drawing.Size(100, 21)
        Me.cmbCondicion.TabIndex = 9
        '
        'cmbTipoComercio
        '
        Me.cmbTipoComercio.FormattingEnabled = True
        Me.cmbTipoComercio.Location = New System.Drawing.Point(202, 164)
        Me.cmbTipoComercio.Name = "cmbTipoComercio"
        Me.cmbTipoComercio.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoComercio.TabIndex = 4
        '
        'lblTipoComercio
        '
        Me.lblTipoComercio.AutoSize = True
        Me.lblTipoComercio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoComercio.Location = New System.Drawing.Point(58, 164)
        Me.lblTipoComercio.Name = "lblTipoComercio"
        Me.lblTipoComercio.Size = New System.Drawing.Size(117, 16)
        Me.lblTipoComercio.TabIndex = 114
        Me.lblTipoComercio.Text = "Tipo de comercio:"
        '
        'cmbTipoMercaderia
        '
        Me.cmbTipoMercaderia.FormattingEnabled = True
        Me.cmbTipoMercaderia.Location = New System.Drawing.Point(528, 191)
        Me.cmbTipoMercaderia.Name = "cmbTipoMercaderia"
        Me.cmbTipoMercaderia.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoMercaderia.TabIndex = 11
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoBruto.Location = New System.Drawing.Point(528, 218)
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.Size = New System.Drawing.Size(100, 22)
        Me.txtPesoBruto.TabIndex = 12
        '
        'lblPesoBruto
        '
        Me.lblPesoBruto.AutoSize = True
        Me.lblPesoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoBruto.Location = New System.Drawing.Point(369, 221)
        Me.lblPesoBruto.Name = "lblPesoBruto"
        Me.lblPesoBruto.Size = New System.Drawing.Size(79, 16)
        Me.lblPesoBruto.TabIndex = 113
        Me.lblPesoBruto.Text = "Peso bruto :"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondicion.Location = New System.Drawing.Point(369, 137)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(74, 16)
        Me.lblCondicion.TabIndex = 112
        Me.lblCondicion.Text = "Condicion :"
        '
        'lblTipoMercaderia
        '
        Me.lblTipoMercaderia.AutoSize = True
        Me.lblTipoMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMercaderia.Location = New System.Drawing.Point(369, 192)
        Me.lblTipoMercaderia.Name = "lblTipoMercaderia"
        Me.lblTipoMercaderia.Size = New System.Drawing.Size(130, 16)
        Me.lblTipoMercaderia.TabIndex = 111
        Me.lblTipoMercaderia.Text = "Tipo de Mercaderia:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Location = New System.Drawing.Point(202, 389)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(426, 87)
        Me.txtComentarios.TabIndex = 18
        '
        'txtOrigen
        '
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.Location = New System.Drawing.Point(528, 246)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(100, 22)
        Me.txtOrigen.TabIndex = 13
        '
        'txtTamanoTotal
        '
        Me.txtTamanoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTamanoTotal.Location = New System.Drawing.Point(528, 163)
        Me.txtTamanoTotal.Name = "txtTamanoTotal"
        Me.txtTamanoTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTamanoTotal.TabIndex = 10
        '
        'txtPesoNeto
        '
        Me.txtPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoNeto.Location = New System.Drawing.Point(202, 219)
        Me.txtPesoNeto.Name = "txtPesoNeto"
        Me.txtPesoNeto.Size = New System.Drawing.Size(100, 22)
        Me.txtPesoNeto.TabIndex = 6
        '
        'txtCantBultos
        '
        Me.txtCantBultos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantBultos.Location = New System.Drawing.Point(202, 191)
        Me.txtCantBultos.Name = "txtCantBultos"
        Me.txtCantBultos.Size = New System.Drawing.Size(100, 22)
        Me.txtCantBultos.TabIndex = 5
        '
        'txtConocimientoOrigen
        '
        Me.txtConocimientoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConocimientoOrigen.Location = New System.Drawing.Point(528, 81)
        Me.txtConocimientoOrigen.Name = "txtConocimientoOrigen"
        Me.txtConocimientoOrigen.Size = New System.Drawing.Size(100, 22)
        Me.txtConocimientoOrigen.TabIndex = 2
        '
        'txtConocimiento
        '
        Me.txtConocimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConocimiento.Location = New System.Drawing.Point(202, 81)
        Me.txtConocimiento.Name = "txtConocimiento"
        Me.txtConocimiento.Size = New System.Drawing.Size(100, 22)
        Me.txtConocimiento.TabIndex = 1
        '
        'lblConocimientoOrigen
        '
        Me.lblConocimientoOrigen.AutoSize = True
        Me.lblConocimientoOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConocimientoOrigen.Location = New System.Drawing.Point(369, 84)
        Me.lblConocimientoOrigen.Name = "lblConocimientoOrigen"
        Me.lblConocimientoOrigen.Size = New System.Drawing.Size(153, 16)
        Me.lblConocimientoOrigen.TabIndex = 110
        Me.lblConocimientoOrigen.Text = "Conocimiento de origen:"
        '
        'lblConocimiento
        '
        Me.lblConocimiento.AutoSize = True
        Me.lblConocimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConocimiento.Location = New System.Drawing.Point(58, 84)
        Me.lblConocimiento.Name = "lblConocimiento"
        Me.lblConocimiento.Size = New System.Drawing.Size(93, 16)
        Me.lblConocimiento.TabIndex = 109
        Me.lblConocimiento.Text = "Conocimiento:"
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.Location = New System.Drawing.Point(369, 249)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(51, 16)
        Me.lblOrigen.TabIndex = 106
        Me.lblOrigen.Text = "Origen:"
        '
        'lblComentarios
        '
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentarios.Location = New System.Drawing.Point(58, 390)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(87, 16)
        Me.lblComentarios.TabIndex = 105
        Me.lblComentarios.Text = "Comentarios:"
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosicion.Location = New System.Drawing.Point(58, 276)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(63, 16)
        Me.lblPosicion.TabIndex = 104
        Me.lblPosicion.Text = "Posición:"
        '
        'lblGalpon
        '
        Me.lblGalpon.AutoSize = True
        Me.lblGalpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalpon.Location = New System.Drawing.Point(58, 248)
        Me.lblGalpon.Name = "lblGalpon"
        Me.lblGalpon.Size = New System.Drawing.Size(55, 16)
        Me.lblGalpon.TabIndex = 103
        Me.lblGalpon.Text = "Galpón:"
        '
        'lblTamanoTotal
        '
        Me.lblTamanoTotal.AutoSize = True
        Me.lblTamanoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamanoTotal.Location = New System.Drawing.Point(369, 166)
        Me.lblTamanoTotal.Name = "lblTamanoTotal"
        Me.lblTamanoTotal.Size = New System.Drawing.Size(90, 16)
        Me.lblTamanoTotal.TabIndex = 102
        Me.lblTamanoTotal.Text = "Tamaño total:"
        '
        'lblPesoNeto
        '
        Me.lblPesoNeto.AutoSize = True
        Me.lblPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoNeto.Location = New System.Drawing.Point(58, 220)
        Me.lblPesoNeto.Name = "lblPesoNeto"
        Me.lblPesoNeto.Size = New System.Drawing.Size(75, 16)
        Me.lblPesoNeto.TabIndex = 100
        Me.lblPesoNeto.Text = "Peso neto :"
        '
        'lblCantBultos
        '
        Me.lblCantBultos.AutoSize = True
        Me.lblCantBultos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantBultos.Location = New System.Drawing.Point(58, 192)
        Me.lblCantBultos.Name = "lblCantBultos"
        Me.lblCantBultos.Size = New System.Drawing.Size(123, 16)
        Me.lblCantBultos.TabIndex = 98
        Me.lblCantBultos.Text = "Cantidad de bultos:"
        '
        'lblFechaDespacho
        '
        Me.lblFechaDespacho.AutoSize = True
        Me.lblFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDespacho.Location = New System.Drawing.Point(369, 333)
        Me.lblFechaDespacho.Name = "lblFechaDespacho"
        Me.lblFechaDespacho.Size = New System.Drawing.Size(132, 16)
        Me.lblFechaDespacho.TabIndex = 124
        Me.lblFechaDespacho.Text = "Fecha de despacho:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(369, 305)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(116, 16)
        Me.lblFechaIngreso.TabIndex = 107
        Me.lblFechaIngreso.Text = "Fecha de ingreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(528, 301)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIngreso.TabIndex = 125
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(528, 329)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaDespacho.TabIndex = 126
        '
        'fMercaderiaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.dtpFechaDespacho)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.lblFechaDespacho)
        Me.Controls.Add(Me.txtRotulo)
        Me.Controls.Add(Me.lblRotulo)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.cmbGalpon)
        Me.Controls.Add(Me.cmbPosicion)
        Me.Controls.Add(Me.cmbCondicion)
        Me.Controls.Add(Me.cmbTipoComercio)
        Me.Controls.Add(Me.lblTipoComercio)
        Me.Controls.Add(Me.cmbTipoMercaderia)
        Me.Controls.Add(Me.txtPesoBruto)
        Me.Controls.Add(Me.lblPesoBruto)
        Me.Controls.Add(Me.lblCondicion)
        Me.Controls.Add(Me.lblTipoMercaderia)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtTamanoTotal)
        Me.Controls.Add(Me.txtPesoNeto)
        Me.Controls.Add(Me.txtCantBultos)
        Me.Controls.Add(Me.txtConocimientoOrigen)
        Me.Controls.Add(Me.txtConocimiento)
        Me.Controls.Add(Me.lblConocimientoOrigen)
        Me.Controls.Add(Me.lblConocimiento)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.lblComentarios)
        Me.Controls.Add(Me.lblPosicion)
        Me.Controls.Add(Me.lblGalpon)
        Me.Controls.Add(Me.lblTamanoTotal)
        Me.Controls.Add(Me.lblPesoNeto)
        Me.Controls.Add(Me.lblCantBultos)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Name = "fMercaderiaDetalle"
        Me.Text = "Mercadería"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents pnlSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAplicar As Button
    Friend WithEvents txtRotulo As TextBox
    Friend WithEvents lblRotulo As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbGalpon As ComboBox
    Friend WithEvents cmbPosicion As ComboBox
    Friend WithEvents cmbCondicion As ComboBox
    Friend WithEvents cmbTipoComercio As ComboBox
    Friend WithEvents lblTipoComercio As Label
    Friend WithEvents cmbTipoMercaderia As ComboBox
    Friend WithEvents txtPesoBruto As TextBox
    Friend WithEvents lblPesoBruto As Label
    Friend WithEvents lblCondicion As Label
    Friend WithEvents lblTipoMercaderia As Label
    Friend WithEvents txtComentarios As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtTamanoTotal As TextBox
    Friend WithEvents txtPesoNeto As TextBox
    Friend WithEvents txtCantBultos As TextBox
    Friend WithEvents txtConocimientoOrigen As TextBox
    Friend WithEvents txtConocimiento As TextBox
    Friend WithEvents lblConocimientoOrigen As Label
    Friend WithEvents lblConocimiento As Label
    Friend WithEvents lblOrigen As Label
    Friend WithEvents lblComentarios As Label
    Friend WithEvents lblPosicion As Label
    Friend WithEvents lblGalpon As Label
    Friend WithEvents lblTamanoTotal As Label
    Friend WithEvents lblPesoNeto As Label
    Friend WithEvents lblCantBultos As Label
    Friend WithEvents btnListaMercaderias As Button
    Friend WithEvents lblFechaDespacho As Label
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents dtpFechaDespacho As DateTimePicker
End Class
