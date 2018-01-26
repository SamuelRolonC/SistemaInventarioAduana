<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarioDetalle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUsuarioDetalle))
        Me.cblgrupos = New System.Windows.Forms.CheckedListBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.cbHabilitado = New System.Windows.Forms.CheckBox()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnListaUsuarios = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'cblgrupos
        '
        Me.cblgrupos.FormattingEnabled = True
        Me.cblgrupos.Location = New System.Drawing.Point(231, 318)
        Me.cblgrupos.Name = "cblgrupos"
        Me.cblgrupos.Size = New System.Drawing.Size(292, 109)
        Me.cblgrupos.TabIndex = 5
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(228, 302)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(41, 13)
        Me.lblGrupo.TabIndex = 38
        Me.lblGrupo.Text = "Grupos"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(228, 246)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(231, 262)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 27)
        Me.txtEmail.TabIndex = 4
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(448, 503)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(228, 134)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 13)
        Me.lblID.TabIndex = 30
        Me.lblID.Text = "Nombre de usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(228, 189)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(231, 150)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(292, 27)
        Me.txtID.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNombre.Location = New System.Drawing.Point(231, 205)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 27)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtApellido.Location = New System.Drawing.Point(380, 205)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(143, 27)
        Me.txtApellido.TabIndex = 3
        '
        'cbHabilitado
        '
        Me.cbHabilitado.AutoSize = True
        Me.cbHabilitado.Location = New System.Drawing.Point(231, 438)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(73, 17)
        Me.cbHabilitado.TabIndex = 6
        Me.cbHabilitado.Text = "Habilitado"
        Me.cbHabilitado.UseVisualStyleBackColor = True
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnListaUsuarios)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 1)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 42
        '
        'btnListaUsuarios
        '
        Me.btnListaUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaUsuarios.Location = New System.Drawing.Point(667, 0)
        Me.btnListaUsuarios.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnListaUsuarios.Name = "btnListaUsuarios"
        Me.btnListaUsuarios.Size = New System.Drawing.Size(117, 30)
        Me.btnListaUsuarios.TabIndex = 10
        Me.btnListaUsuarios.Text = "Lista de Usuarios"
        Me.btnListaUsuarios.UseVisualStyleBackColor = True
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 11
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(377, 189)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 43
        Me.lblApellido.Text = "Apellido"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(367, 503)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(448, 474)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 7
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'fUsuarioDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.cbHabilitado)
        Me.Controls.Add(Me.cblgrupos)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Name = "fUsuarioDetalle"
        Me.Text = "Detalle de usuario"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cblgrupos As CheckedListBox
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents cbHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents pnlSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnListaUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents lblApellido As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAplicar As Button
End Class
