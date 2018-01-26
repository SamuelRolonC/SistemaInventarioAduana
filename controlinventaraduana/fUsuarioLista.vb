Public Class fUsuarioLista
    Public Property UsuarioIdLog As String
    Property modificarusuario As String

    Private Sub fListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '@note Cargar y presentar el datagridview
        Dim xDT As New DataTable
        xDT = Negocio.cUsuario.CargarTabla

        Dim TripleDes As New Negocio.Cripto3DES
        For Each FilaUsuario As DataRow In xDT.Rows
            FilaUsuario("email") = TripleDes.DesencriptarDato(FilaUsuario("email"))
        Next

        UsuarioList.DataSource = xDT

        Me.UsuarioList.Columns("id").DisplayIndex = 0
        Me.UsuarioList.Columns("nombre").DisplayIndex = 1
        Me.UsuarioList.Columns("apellido").DisplayIndex = 2
        Me.UsuarioList.Columns("email").DisplayIndex = 3
        Me.UsuarioList.Columns("habilitado").DisplayIndex = 4

        Me.UsuarioList.Columns("id").HeaderText = "Usuario"
        Me.UsuarioList.Columns("nombre").HeaderText = "Nombre"
        Me.UsuarioList.Columns("apellido").HeaderText = "Apellido"
        Me.UsuarioList.Columns("email").HeaderText = "Email"
        Me.UsuarioList.Columns("habilitado").HeaderText = "Habilitado"

        '@note Comprobar permisos del usuario
        Me.btnNuevoUsuario.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "alta")
    End Sub

    Private Sub UsuarioList_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles UsuarioList.CellDoubleClick
        Dim UsuarioDetalle As New fUsuarioDetalle
        UsuarioDetalle.usuarioID = Convert.ToString(Me.UsuarioList.CurrentRow.Cells(0).Value)
        UsuarioDetalle.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoUsuario.Click
        Dim UsuarioNuevo As New fUsuarioNuevo
        UsuarioNuevo.Show()
        Me.Close()
    End Sub
End Class