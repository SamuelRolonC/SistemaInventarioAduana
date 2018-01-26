<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fGalponNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDescripcionGalpon = New System.Windows.Forms.TextBox()
        Me.lblNombreGalpon = New System.Windows.Forms.Label()
        Me.lblDescripcionGalpon = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.txtNombreGalpon = New System.Windows.Forms.TextBox()
        Me.txtCantidadPosiciones = New System.Windows.Forms.TextBox()
        Me.lblCantidadPosiciones = New System.Windows.Forms.Label()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcionGalpon
        '
        Me.txtDescripcionGalpon.Location = New System.Drawing.Point(246, 221)
        Me.txtDescripcionGalpon.Name = "txtDescripcionGalpon"
        Me.txtDescripcionGalpon.Size = New System.Drawing.Size(280, 20)
        Me.txtDescripcionGalpon.TabIndex = 1
        '
        'lblNombreGalpon
        '
        Me.lblNombreGalpon.AutoSize = True
        Me.lblNombreGalpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreGalpon.Location = New System.Drawing.Point(243, 140)
        Me.lblNombreGalpon.Name = "lblNombreGalpon"
        Me.lblNombreGalpon.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreGalpon.TabIndex = 4
        Me.lblNombreGalpon.Text = "Nombre"
        '
        'lblDescripcionGalpon
        '
        Me.lblDescripcionGalpon.AutoSize = True
        Me.lblDescripcionGalpon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionGalpon.Location = New System.Drawing.Point(243, 205)
        Me.lblDescripcionGalpon.Name = "lblDescripcionGalpon"
        Me.lblDescripcionGalpon.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionGalpon.TabIndex = 5
        Me.lblDescripcionGalpon.Text = "Descripción"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(460, 312)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(66, 24)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 11
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
        'txtNombreGalpon
        '
        Me.txtNombreGalpon.Location = New System.Drawing.Point(246, 156)
        Me.txtNombreGalpon.Name = "txtNombreGalpon"
        Me.txtNombreGalpon.Size = New System.Drawing.Size(280, 20)
        Me.txtNombreGalpon.TabIndex = 6
        '
        'txtCantidadPosiciones
        '
        Me.txtCantidadPosiciones.Location = New System.Drawing.Point(246, 286)
        Me.txtCantidadPosiciones.Name = "txtCantidadPosiciones"
        Me.txtCantidadPosiciones.Size = New System.Drawing.Size(280, 20)
        Me.txtCantidadPosiciones.TabIndex = 14
        '
        'lblCantidadPosiciones
        '
        Me.lblCantidadPosiciones.AutoSize = True
        Me.lblCantidadPosiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPosiciones.Location = New System.Drawing.Point(243, 270)
        Me.lblCantidadPosiciones.Name = "lblCantidadPosiciones"
        Me.lblCantidadPosiciones.Size = New System.Drawing.Size(118, 13)
        Me.lblCantidadPosiciones.TabIndex = 13
        Me.lblCantidadPosiciones.Text = "Cantidad de Posiciones"
        '
        'fGalponNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.txtCantidadPosiciones)
        Me.Controls.Add(Me.lblCantidadPosiciones)
        Me.Controls.Add(Me.txtNombreGalpon)
        Me.Controls.Add(Me.lblNombreGalpon)
        Me.Controls.Add(Me.txtDescripcionGalpon)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.lblDescripcionGalpon)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "fGalponNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fGalpones"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescripcionGalpon As System.Windows.Forms.TextBox
    Friend WithEvents txtEntrepiso As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreGalpon As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionGalpon As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents txtNombreGalpon As TextBox
    Friend WithEvents txtCantidadPosiciones As TextBox
    Friend WithEvents lblCantidadPosiciones As Label
End Class
