<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGalponDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGalponDetalle))
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEntrepiso = New System.Windows.Forms.Label()
        Me.lblPesoMaxEntrepiso = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPesoMaxEntrepiso = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnListaGalpones = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmbEntrepiso = New System.Windows.Forms.ComboBox()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(238, 160)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(32, 24)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(238, 224)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(115, 24)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblEntrepiso
        '
        Me.lblEntrepiso.AutoSize = True
        Me.lblEntrepiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrepiso.Location = New System.Drawing.Point(238, 288)
        Me.lblEntrepiso.Name = "lblEntrepiso"
        Me.lblEntrepiso.Size = New System.Drawing.Size(95, 24)
        Me.lblEntrepiso.TabIndex = 2
        Me.lblEntrepiso.Text = "Entrepiso:"
        '
        'lblPesoMaxEntrepiso
        '
        Me.lblPesoMaxEntrepiso.AutoSize = True
        Me.lblPesoMaxEntrepiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoMaxEntrepiso.Location = New System.Drawing.Point(238, 343)
        Me.lblPesoMaxEntrepiso.Name = "lblPesoMaxEntrepiso"
        Me.lblPesoMaxEntrepiso.Size = New System.Drawing.Size(102, 24)
        Me.lblPesoMaxEntrepiso.TabIndex = 3
        Me.lblPesoMaxEntrepiso.Text = "Peso M. E."
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(359, 164)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(156, 20)
        Me.txtID.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(359, 228)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(156, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtPesoMaxEntrepiso
        '
        Me.txtPesoMaxEntrepiso.Location = New System.Drawing.Point(359, 347)
        Me.txtPesoMaxEntrepiso.Name = "txtPesoMaxEntrepiso"
        Me.txtPesoMaxEntrepiso.Size = New System.Drawing.Size(156, 20)
        Me.txtPesoMaxEntrepiso.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(265, 499)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(346, 499)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(427, 499)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 11
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnListaGalpones)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 12
        '
        'btnListaGalpones
        '
        Me.btnListaGalpones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaGalpones.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnListaGalpones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaGalpones.Location = New System.Drawing.Point(667, 0)
        Me.btnListaGalpones.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnListaGalpones.Name = "btnListaGalpones"
        Me.btnListaGalpones.Size = New System.Drawing.Size(117, 30)
        Me.btnListaGalpones.TabIndex = 20
        Me.btnListaGalpones.Text = "Lista de Galpones"
        Me.btnListaGalpones.UseVisualStyleBackColor = True
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 19
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(359, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(359, 228)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 20)
        Me.TextBox2.TabIndex = 5
        '
        'cmbEntrepiso
        '
        Me.cmbEntrepiso.FormattingEnabled = True
        Me.cmbEntrepiso.Location = New System.Drawing.Point(359, 288)
        Me.cmbEntrepiso.Name = "cmbEntrepiso"
        Me.cmbEntrepiso.Size = New System.Drawing.Size(156, 21)
        Me.cmbEntrepiso.TabIndex = 13
        '
        'fConfigGalpones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cmbEntrepiso)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtPesoMaxEntrepiso)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPesoMaxEntrepiso)
        Me.Controls.Add(Me.lblEntrepiso)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblID)
        Me.Name = "fConfigGalpones2"
        Me.Text = "fConfigGalpones"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblEntrepiso As System.Windows.Forms.Label
    Friend WithEvents lblPesoMaxEntrepiso As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoMaxEntrepiso As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnListaGalpones As Button
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbEntrepiso As System.Windows.Forms.ComboBox
End Class
