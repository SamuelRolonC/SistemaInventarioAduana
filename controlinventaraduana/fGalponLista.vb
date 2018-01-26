Public Class fGalponLista

    Private Sub fListaGalpones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar y presentar el datagridview
        Dim xGalpon As New Negocio.cGalpon
        dgvGalpones.DataSource = xGalpon.Cargartabla()
        Me.dgvGalpones.Columns("nombre").HeaderText = "Nombre"
        Me.dgvGalpones.Columns("descripcion").HeaderText = "Descripcion"

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnNuevoGalpon.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "alta")
    End Sub
    Private Sub dgvgalpones_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvGalpones.CellDoubleClick
        Dim vConfigCliente As New fClienteDetalle

        vConfigCliente.ClienteID = Convert.ToString(Me.dgvGalpones.CurrentRow.Cells(0).Value)
        vConfigCliente.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click_1(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoGalpon_Click_1(sender As Object, e As EventArgs) Handles btnNuevoGalpon.Click
        Dim vGalpones As New fGalponNuevo
        vGalpones.Show()
        Me.Close()
    End Sub
End Class