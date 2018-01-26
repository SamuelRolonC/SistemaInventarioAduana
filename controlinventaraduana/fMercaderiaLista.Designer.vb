<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMercaderiaLista
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnNuevaMercaderia = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.dgvAlmacen = New System.Windows.Forms.DataGridView()
        Me.cmstripAlmacen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarcarDespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrpBoxDetalles = New System.Windows.Forms.GroupBox()
        Me.txtFechaDespacho = New System.Windows.Forms.TextBox()
        Me.txtFechaIngreso = New System.Windows.Forms.TextBox()
        Me.FechaDespacho = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.txtPesoBruto = New System.Windows.Forms.TextBox()
        Me.txtTamanoTotal = New System.Windows.Forms.TextBox()
        Me.txtCondicion = New System.Windows.Forms.TextBox()
        Me.txtPesoNeto = New System.Windows.Forms.TextBox()
        Me.lblTamanoTotal = New System.Windows.Forms.Label()
        Me.lblPesoBruto = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.lblPesoNeto = New System.Windows.Forms.Label()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmstripAlmacen.SuspendLayout()
        Me.GrpBoxDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnNuevaMercaderia)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Controls.Add(Me.txtBuscador)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 13
        '
        'btnNuevaMercaderia
        '
        Me.btnNuevaMercaderia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaMercaderia.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNuevaMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaMercaderia.Location = New System.Drawing.Point(550, 0)
        Me.btnNuevaMercaderia.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNuevaMercaderia.Name = "btnNuevaMercaderia"
        Me.btnNuevaMercaderia.Size = New System.Drawing.Size(110, 30)
        Me.btnNuevaMercaderia.TabIndex = 9
        Me.btnNuevaMercaderia.Text = "Nueva Mercadería"
        Me.btnNuevaMercaderia.UseVisualStyleBackColor = True
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 7
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(662, 2)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(120, 26)
        Me.txtBuscador.TabIndex = 4
        Me.txtBuscador.Text = "Buscador"
        '
        'dgvAlmacen
        '
        Me.dgvAlmacen.AllowUserToAddRows = False
        Me.dgvAlmacen.AllowUserToDeleteRows = False
        Me.dgvAlmacen.AllowUserToOrderColumns = True
        Me.dgvAlmacen.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlmacen.Location = New System.Drawing.Point(12, 36)
        Me.dgvAlmacen.Name = "dgvAlmacen"
        Me.dgvAlmacen.ReadOnly = True
        Me.dgvAlmacen.Size = New System.Drawing.Size(760, 429)
        Me.dgvAlmacen.TabIndex = 14
        '
        'cmstripAlmacen
        '
        Me.cmstripAlmacen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarDespachoToolStripMenuItem})
        Me.cmstripAlmacen.Name = "conMenAlmacen"
        Me.cmstripAlmacen.Size = New System.Drawing.Size(166, 26)
        '
        'MarcarDespachoToolStripMenuItem
        '
        Me.MarcarDespachoToolStripMenuItem.Name = "MarcarDespachoToolStripMenuItem"
        Me.MarcarDespachoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MarcarDespachoToolStripMenuItem.Text = "Marcar despacho"
        '
        'GrpBoxDetalles
        '
        Me.GrpBoxDetalles.Controls.Add(Me.txtFechaDespacho)
        Me.GrpBoxDetalles.Controls.Add(Me.txtFechaIngreso)
        Me.GrpBoxDetalles.Controls.Add(Me.FechaDespacho)
        Me.GrpBoxDetalles.Controls.Add(Me.lblFechaIngreso)
        Me.GrpBoxDetalles.Controls.Add(Me.txtPesoBruto)
        Me.GrpBoxDetalles.Controls.Add(Me.txtTamanoTotal)
        Me.GrpBoxDetalles.Controls.Add(Me.txtCondicion)
        Me.GrpBoxDetalles.Controls.Add(Me.txtPesoNeto)
        Me.GrpBoxDetalles.Controls.Add(Me.lblTamanoTotal)
        Me.GrpBoxDetalles.Controls.Add(Me.lblPesoBruto)
        Me.GrpBoxDetalles.Controls.Add(Me.lblCondicion)
        Me.GrpBoxDetalles.Controls.Add(Me.lblPesoNeto)
        Me.GrpBoxDetalles.Location = New System.Drawing.Point(12, 471)
        Me.GrpBoxDetalles.Name = "GrpBoxDetalles"
        Me.GrpBoxDetalles.Size = New System.Drawing.Size(760, 78)
        Me.GrpBoxDetalles.TabIndex = 15
        Me.GrpBoxDetalles.TabStop = False
        Me.GrpBoxDetalles.Text = "Detalles: "
        '
        'txtFechaDespacho
        '
        Me.txtFechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDespacho.Location = New System.Drawing.Point(654, 48)
        Me.txtFechaDespacho.Name = "txtFechaDespacho"
        Me.txtFechaDespacho.ReadOnly = True
        Me.txtFechaDespacho.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaDespacho.TabIndex = 63
        Me.txtFechaDespacho.Text = "Sin datos"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIngreso.Location = New System.Drawing.Point(654, 20)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.ReadOnly = True
        Me.txtFechaIngreso.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaIngreso.TabIndex = 62
        Me.txtFechaIngreso.Text = "Sin datos"
        '
        'FechaDespacho
        '
        Me.FechaDespacho.AutoSize = True
        Me.FechaDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDespacho.Location = New System.Drawing.Point(503, 49)
        Me.FechaDespacho.Name = "FechaDespacho"
        Me.FechaDespacho.Size = New System.Drawing.Size(145, 18)
        Me.FechaDespacho.TabIndex = 60
        Me.FechaDespacho.Text = "Fecha de Despacho:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(503, 21)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(126, 18)
        Me.lblFechaIngreso.TabIndex = 61
        Me.lblFechaIngreso.Text = "Fecha de Ingreso:"
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoBruto.Location = New System.Drawing.Point(100, 47)
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.ReadOnly = True
        Me.txtPesoBruto.Size = New System.Drawing.Size(100, 22)
        Me.txtPesoBruto.TabIndex = 58
        Me.txtPesoBruto.Text = "Sin datos"
        '
        'txtTamanoTotal
        '
        Me.txtTamanoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTamanoTotal.Location = New System.Drawing.Point(363, 47)
        Me.txtTamanoTotal.Name = "txtTamanoTotal"
        Me.txtTamanoTotal.ReadOnly = True
        Me.txtTamanoTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTamanoTotal.TabIndex = 57
        Me.txtTamanoTotal.Text = "Sin datos"
        '
        'txtCondicion
        '
        Me.txtCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondicion.Location = New System.Drawing.Point(363, 19)
        Me.txtCondicion.Name = "txtCondicion"
        Me.txtCondicion.ReadOnly = True
        Me.txtCondicion.Size = New System.Drawing.Size(100, 22)
        Me.txtCondicion.TabIndex = 56
        Me.txtCondicion.Text = "Sin datos"
        '
        'txtPesoNeto
        '
        Me.txtPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoNeto.Location = New System.Drawing.Point(100, 19)
        Me.txtPesoNeto.Name = "txtPesoNeto"
        Me.txtPesoNeto.ReadOnly = True
        Me.txtPesoNeto.Size = New System.Drawing.Size(100, 22)
        Me.txtPesoNeto.TabIndex = 55
        Me.txtPesoNeto.Text = "Sin datos"
        '
        'lblTamanoTotal
        '
        Me.lblTamanoTotal.AutoSize = True
        Me.lblTamanoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamanoTotal.Location = New System.Drawing.Point(258, 48)
        Me.lblTamanoTotal.Name = "lblTamanoTotal"
        Me.lblTamanoTotal.Size = New System.Drawing.Size(99, 18)
        Me.lblTamanoTotal.TabIndex = 16
        Me.lblTamanoTotal.Text = "Tamaño total:"
        '
        'lblPesoBruto
        '
        Me.lblPesoBruto.AutoSize = True
        Me.lblPesoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoBruto.Location = New System.Drawing.Point(7, 48)
        Me.lblPesoBruto.Name = "lblPesoBruto"
        Me.lblPesoBruto.Size = New System.Drawing.Size(87, 18)
        Me.lblPesoBruto.TabIndex = 42
        Me.lblPesoBruto.Text = "Peso Bruto:"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondicion.Location = New System.Drawing.Point(258, 20)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(83, 18)
        Me.lblCondicion.TabIndex = 40
        Me.lblCondicion.Text = "Condicion :"
        '
        'lblPesoNeto
        '
        Me.lblPesoNeto.AutoSize = True
        Me.lblPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoNeto.Location = New System.Drawing.Point(7, 20)
        Me.lblPesoNeto.Name = "lblPesoNeto"
        Me.lblPesoNeto.Size = New System.Drawing.Size(83, 18)
        Me.lblPesoNeto.TabIndex = 38
        Me.lblPesoNeto.Text = "Peso Neto:"
        '
        'fMercaderiaLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.GrpBoxDetalles)
        Me.Controls.Add(Me.dgvAlmacen)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Name = "fMercaderiaLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Mercaderías"
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        CType(Me.dgvAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmstripAlmacen.ResumeLayout(False)
        Me.GrpBoxDetalles.ResumeLayout(False)
        Me.GrpBoxDetalles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents dgvAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevaMercaderia As System.Windows.Forms.Button
    Friend WithEvents GrpBoxDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents lblPesoNeto As System.Windows.Forms.Label
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents lblPesoBruto As System.Windows.Forms.Label
    Friend WithEvents lblTamanoTotal As System.Windows.Forms.Label
    Friend WithEvents cmstripAlmacen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtPesoBruto As System.Windows.Forms.TextBox
    Friend WithEvents txtTamanoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCondicion As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents MarcarDespachoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtFechaDespacho As TextBox
    Friend WithEvents txtFechaIngreso As TextBox
    Friend WithEvents FechaDespacho As Label
    Friend WithEvents lblFechaIngreso As Label
End Class
