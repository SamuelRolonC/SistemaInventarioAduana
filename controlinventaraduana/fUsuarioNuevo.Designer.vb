<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarioNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUsuarioNuevo))
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfirmarPass = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.lblConfirmarPass = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.cblgrupos = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnListaUsuarios = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.cbHabilitado = New System.Windows.Forms.CheckBox()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtApellido
        '
        Me.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtApellido.Location = New System.Drawing.Point(380, 205)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(143, 27)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombre.Location = New System.Drawing.Point(231, 205)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 27)
        Me.txtNombre.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(231, 150)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(292, 27)
        Me.txtID.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(231, 262)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(292, 27)
        Me.txtPass.TabIndex = 4
        '
        'txtConfirmarPass
        '
        Me.txtConfirmarPass.Location = New System.Drawing.Point(231, 318)
        Me.txtConfirmarPass.Multiline = True
        Me.txtConfirmarPass.Name = "txtConfirmarPass"
        Me.txtConfirmarPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarPass.Size = New System.Drawing.Size(292, 27)
        Me.txtConfirmarPass.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(228, 189)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(228, 134)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 13)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "Nombre de usuario"
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Location = New System.Drawing.Point(228, 246)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(61, 13)
        Me.lbPass.TabIndex = 11
        Me.lbPass.Text = "Contraseña"
        '
        'lblConfirmarPass
        '
        Me.lblConfirmarPass.AutoSize = True
        Me.lblConfirmarPass.Location = New System.Drawing.Point(228, 302)
        Me.lblConfirmarPass.Name = "lblConfirmarPass"
        Me.lblConfirmarPass.Size = New System.Drawing.Size(107, 13)
        Me.lblConfirmarPass.TabIndex = 12
        Me.lblConfirmarPass.Text = "Confirmar contraseña"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(448, 509)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(228, 357)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(231, 374)
        Me.txtMail.Multiline = True
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(292, 27)
        Me.txtMail.TabIndex = 6
        '
        'cblgrupos
        '
        Me.cblgrupos.FormattingEnabled = True
        Me.cblgrupos.Location = New System.Drawing.Point(231, 427)
        Me.cblgrupos.Name = "cblgrupos"
        Me.cblgrupos.Size = New System.Drawing.Size(292, 49)
        Me.cblgrupos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Grupos"
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnListaUsuarios)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 24
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
        Me.lblApellido.TabIndex = 25
        Me.lblApellido.Text = "Apellido"
        '
        'cbHabilitado
        '
        Me.cbHabilitado.AutoSize = True
        Me.cbHabilitado.Location = New System.Drawing.Point(231, 482)
        Me.cbHabilitado.Name = "cbHabilitado"
        Me.cbHabilitado.Size = New System.Drawing.Size(73, 17)
        Me.cbHabilitado.TabIndex = 8
        Me.cbHabilitado.Text = "Habilitado"
        Me.cbHabilitado.UseVisualStyleBackColor = True
        '
        'fUsuarioNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cbHabilitado)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cblgrupos)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblConfirmarPass)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtConfirmarPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido)
        Me.Name = "fUsuarioNuevo"
        Me.Text = "Nuevo Usuario"
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtConfirmarPass As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lbPass As Label
    Friend WithEvents lblConfirmarPass As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents cblgrupos As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnListaUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents lblApellido As Label
    Friend WithEvents cbHabilitado As CheckBox
End Class
