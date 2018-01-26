<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListaDeMercaderia = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNuevoIngreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCrearCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListaCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCrearUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListaDeUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCrearGrupoDeUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListaDeGrupoDeUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.GalponesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNuevoGalpon = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnListaGalpon = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.GalponesToolStripMenuItem, Me.btnAyuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListaDeMercaderia, Me.btnNuevoIngreso})
        Me.AlmacenToolStripMenuItem.Image = CType(resources.GetObject("AlmacenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlmacenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(101, 36)
        Me.AlmacenToolStripMenuItem.Text = "Almacén "
        '
        'btnListaDeMercaderia
        '
        Me.btnListaDeMercaderia.Image = CType(resources.GetObject("btnListaDeMercaderia.Image"), System.Drawing.Image)
        Me.btnListaDeMercaderia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnListaDeMercaderia.Name = "btnListaDeMercaderia"
        Me.btnListaDeMercaderia.Size = New System.Drawing.Size(192, 38)
        Me.btnListaDeMercaderia.Text = "Lista de Mercaderia"
        '
        'btnNuevoIngreso
        '
        Me.btnNuevoIngreso.Image = CType(resources.GetObject("btnNuevoIngreso.Image"), System.Drawing.Image)
        Me.btnNuevoIngreso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevoIngreso.Name = "btnNuevoIngreso"
        Me.btnNuevoIngreso.Size = New System.Drawing.Size(192, 38)
        Me.btnNuevoIngreso.Text = "Nuevo Ingreso"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.GrupoDeUsuarioToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Image = CType(resources.GetObject("RegistroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(94, 36)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCrearCliente, Me.btnListaCliente})
        Me.ClienteToolStripMenuItem.Image = CType(resources.GetObject("ClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.ClienteToolStripMenuItem.Text = "Cliente "
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.Image = CType(resources.GetObject("btnCrearCliente.Image"), System.Drawing.Image)
        Me.btnCrearCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Size = New System.Drawing.Size(165, 38)
        Me.btnCrearCliente.Text = "Crear Cliente"
        '
        'btnListaCliente
        '
        Me.btnListaCliente.Image = CType(resources.GetObject("btnListaCliente.Image"), System.Drawing.Image)
        Me.btnListaCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnListaCliente.Name = "btnListaCliente"
        Me.btnListaCliente.Size = New System.Drawing.Size(165, 38)
        Me.btnListaCliente.Text = "Lista Cliente"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCrearUsuario, Me.btnListaDeUsuario})
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Image = CType(resources.GetObject("btnCrearUsuario.Image"), System.Drawing.Image)
        Me.btnCrearUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(173, 38)
        Me.btnCrearUsuario.Text = "Crear Usuario"
        '
        'btnListaDeUsuario
        '
        Me.btnListaDeUsuario.Image = CType(resources.GetObject("btnListaDeUsuario.Image"), System.Drawing.Image)
        Me.btnListaDeUsuario.Name = "btnListaDeUsuario"
        Me.btnListaDeUsuario.Size = New System.Drawing.Size(173, 38)
        Me.btnListaDeUsuario.Text = "Lista de Usuario"
        '
        'GrupoDeUsuarioToolStripMenuItem
        '
        Me.GrupoDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCrearGrupoDeUsuarios, Me.btnListaDeGrupoDeUsuarios})
        Me.GrupoDeUsuarioToolStripMenuItem.Image = CType(resources.GetObject("GrupoDeUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrupoDeUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GrupoDeUsuarioToolStripMenuItem.Name = "GrupoDeUsuarioToolStripMenuItem"
        Me.GrupoDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.GrupoDeUsuarioToolStripMenuItem.Text = "Grupo de Usuarios"
        '
        'btnCrearGrupoDeUsuarios
        '
        Me.btnCrearGrupoDeUsuarios.Name = "btnCrearGrupoDeUsuarios"
        Me.btnCrearGrupoDeUsuarios.Size = New System.Drawing.Size(214, 22)
        Me.btnCrearGrupoDeUsuarios.Text = "Crear Grupo de Usuarios"
        '
        'btnListaDeGrupoDeUsuarios
        '
        Me.btnListaDeGrupoDeUsuarios.Name = "btnListaDeGrupoDeUsuarios"
        Me.btnListaDeGrupoDeUsuarios.Size = New System.Drawing.Size(214, 22)
        Me.btnListaDeGrupoDeUsuarios.Text = "Lista de Grupo de Usuarios"
        '
        'GalponesToolStripMenuItem
        '
        Me.GalponesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoGalpon, Me.btnListaGalpon})
        Me.GalponesToolStripMenuItem.Image = CType(resources.GetObject("GalponesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GalponesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GalponesToolStripMenuItem.Name = "GalponesToolStripMenuItem"
        Me.GalponesToolStripMenuItem.Size = New System.Drawing.Size(103, 36)
        Me.GalponesToolStripMenuItem.Text = "Galpones "
        '
        'btnNuevoGalpon
        '
        Me.btnNuevoGalpon.Image = CType(resources.GetObject("btnNuevoGalpon.Image"), System.Drawing.Image)
        Me.btnNuevoGalpon.Name = "btnNuevoGalpon"
        Me.btnNuevoGalpon.Size = New System.Drawing.Size(166, 38)
        Me.btnNuevoGalpon.Text = "Nuevo Galpon"
        '
        'btnListaGalpon
        '
        Me.btnListaGalpon.Image = CType(resources.GetObject("btnListaGalpon.Image"), System.Drawing.Image)
        Me.btnListaGalpon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnListaGalpon.Name = "btnListaGalpon"
        Me.btnListaGalpon.Size = New System.Drawing.Size(166, 38)
        Me.btnListaGalpon.Text = "Lista"
        '
        'btnAyuda
        '
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(85, 36)
        Me.btnAyuda.Text = "Ayuda"
        '
        'fMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AlmacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListaDeMercaderia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNuevoIngreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCrearCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListaCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListaDeUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCrearGrupoDeUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListaDeGrupoDeUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GalponesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNuevoGalpon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnListaGalpon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAyuda As System.Windows.Forms.ToolStripMenuItem
End Class
