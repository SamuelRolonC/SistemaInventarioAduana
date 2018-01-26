<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Galpones
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
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEntrepiso = New System.Windows.Forms.Label()
        Me.lblPesoMaxEntrepiso = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPesoMaxEntrepiso = New System.Windows.Forms.TextBox()
        Me.cmbEntrepiso = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(144, 32)
        Me.btnMenuPrincipal.TabIndex = 0
        Me.btnMenuPrincipal.Text = "Volver al Menu Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(163, 131)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(32, 24)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(163, 191)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(115, 24)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblEntrepiso
        '
        Me.lblEntrepiso.AutoSize = True
        Me.lblEntrepiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrepiso.Location = New System.Drawing.Point(163, 248)
        Me.lblEntrepiso.Name = "lblEntrepiso"
        Me.lblEntrepiso.Size = New System.Drawing.Size(100, 24)
        Me.lblEntrepiso.TabIndex = 3
        Me.lblEntrepiso.Text = "Entrepiso: "
        '
        'lblPesoMaxEntrepiso
        '
        Me.lblPesoMaxEntrepiso.AutoSize = True
        Me.lblPesoMaxEntrepiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoMaxEntrepiso.Location = New System.Drawing.Point(162, 306)
        Me.lblPesoMaxEntrepiso.Name = "lblPesoMaxEntrepiso"
        Me.lblPesoMaxEntrepiso.Size = New System.Drawing.Size(189, 24)
        Me.lblPesoMaxEntrepiso.TabIndex = 4
        Me.lblPesoMaxEntrepiso.Text = "Peso Max. Entrepiso:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(430, 135)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(430, 195)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtPesoMaxEntrepiso
        '
        Me.txtPesoMaxEntrepiso.Location = New System.Drawing.Point(430, 310)
        Me.txtPesoMaxEntrepiso.Name = "txtPesoMaxEntrepiso"
        Me.txtPesoMaxEntrepiso.Size = New System.Drawing.Size(100, 20)
        Me.txtPesoMaxEntrepiso.TabIndex = 8
        '
        'cmbEntrepiso
        '
        Me.cmbEntrepiso.FormattingEnabled = True
        Me.cmbEntrepiso.Location = New System.Drawing.Point(430, 251)
        Me.cmbEntrepiso.Name = "cmbEntrepiso"
        Me.cmbEntrepiso.Size = New System.Drawing.Size(100, 21)
        Me.cmbEntrepiso.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(81, 409)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(103, 37)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Galpones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbEntrepiso)
        Me.Controls.Add(Me.txtPesoMaxEntrepiso)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPesoMaxEntrepiso)
        Me.Controls.Add(Me.lblEntrepiso)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnMenuPrincipal)
        Me.Name = "Galpones"
        Me.Text = "Galpones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblEntrepiso As System.Windows.Forms.Label
    Friend WithEvents lblPesoMaxEntrepiso As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoMaxEntrepiso As System.Windows.Forms.TextBox
    Friend WithEvents cmbEntrepiso As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
