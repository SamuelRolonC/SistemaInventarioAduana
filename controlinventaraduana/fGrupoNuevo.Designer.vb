<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fGrupoNuevo
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
        Me.btnAgregarGrupo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnListaGruposUsuarios = New System.Windows.Forms.Button()
        Me.cbHabilitar = New System.Windows.Forms.CheckBox()
        Me.tvPermisos = New System.Windows.Forms.TreeView()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarGrupo
        '
        Me.btnAgregarGrupo.Location = New System.Drawing.Point(437, 526)
        Me.btnAgregarGrupo.Name = "btnAgregarGrupo"
        Me.btnAgregarGrupo.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarGrupo.TabIndex = 86
        Me.btnAgregarGrupo.Text = "Agregar"
        Me.btnAgregarGrupo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(274, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(238, 22)
        Me.txtNombre.TabIndex = 58
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(208, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 16)
        Me.lblNombre.TabIndex = 87
        Me.lblNombre.Text = "Nombre:"
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
        Me.btnMenuPrincipal.Text = "Menu Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnListaGruposUsuarios)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 66
        '
        'btnListaGruposUsuarios
        '
        Me.btnListaGruposUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaGruposUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnListaGruposUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaGruposUsuarios.Location = New System.Drawing.Point(674, 0)
        Me.btnListaGruposUsuarios.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnListaGruposUsuarios.Name = "btnListaGruposUsuarios"
        Me.btnListaGruposUsuarios.Size = New System.Drawing.Size(110, 30)
        Me.btnListaGruposUsuarios.TabIndex = 22
        Me.btnListaGruposUsuarios.Text = "Lista de Grupos"
        Me.btnListaGruposUsuarios.UseVisualStyleBackColor = True
        '
        'cbHabilitar
        '
        Me.cbHabilitar.AutoSize = True
        Me.cbHabilitar.Location = New System.Drawing.Point(448, 461)
        Me.cbHabilitar.Name = "cbHabilitar"
        Me.cbHabilitar.Size = New System.Drawing.Size(64, 17)
        Me.cbHabilitar.TabIndex = 88
        Me.cbHabilitar.Text = "Habilitar"
        Me.cbHabilitar.UseVisualStyleBackColor = True
        '
        'tvPermisos
        '
        Me.tvPermisos.Location = New System.Drawing.Point(274, 116)
        Me.tvPermisos.Name = "tvPermisos"
        Me.tvPermisos.Size = New System.Drawing.Size(238, 339)
        Me.tvPermisos.TabIndex = 90
        '
        'fGrupoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.tvPermisos)
        Me.Controls.Add(Me.cbHabilitar)
        Me.Controls.Add(Me.btnAgregarGrupo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Name = "fGrupoNuevo"
        Me.Text = "Nuevo Grupo"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarGrupo As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents cbHabilitar As CheckBox
    Friend WithEvents tvPermisos As TreeView
    Friend WithEvents btnListaGruposUsuarios As Button
End Class
