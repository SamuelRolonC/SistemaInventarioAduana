Public Class fGrupoLista

    Private Sub fAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '@note Cargar y presentar el datagridview
        dgvListaGrupos.DataSource = Negocio.GestorEstandarDatos.CargarTabla("grupos")
        Me.dgvListaGrupos.Columns("id").HeaderText = "Nombre"
        Me.dgvListaGrupos.Columns("habilitado").HeaderText = "Habilitado"

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Me.btnNuevoGrupo.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "alta")
    End Sub

    Private Sub dgvListaGrupos_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvListaGrupos.CellDoubleClick
        Dim vGrupoDetalle As New fGrupoDetalle
        vGrupoDetalle.GrupoDetalleId = Convert.ToString(Me.dgvListaGrupos.CurrentRow.Cells(0).Value)
        vGrupoDetalle.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoGrupo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevoGrupo.Click
        Dim vGrupoNuevo As New fGrupoNuevo
        vGrupoNuevo.Show()
        Me.Close()
    End Sub
End Class