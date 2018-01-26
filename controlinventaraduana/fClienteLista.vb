Public Class fClienteLista
    Private Sub fListaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar y presentar el datagridview
        Dim xCliente As New Negocio.cCliente
        Me.dgvListaClientes.DataSource = xCliente.CargarTabla()
        Me.dgvListaClientes.Columns("id").HeaderText = "Id"
        Me.dgvListaClientes.Columns("nombre").HeaderText = "Nombre"
        Me.dgvListaClientes.Columns("telefono").HeaderText = "Telefono"
        Me.dgvListaClientes.Columns("mail").HeaderText = "Email"

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnNuevoCliente.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Clientes", "alta")
    End Sub

    Private Sub dgvListaClientes_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvListaClientes.CellDoubleClick
        Dim vConfigCliente As New fClienteDetalle

        vConfigCliente.ClienteID = Convert.ToString(Me.dgvListaClientes.CurrentRow.Cells(0).Value)
        vConfigCliente.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click_1(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoCliente_Click_1(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim vClientes As New fClienteNuevo
        vClientes.Show()
        Me.Close()
    End Sub
End Class