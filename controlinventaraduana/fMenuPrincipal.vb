Public Class fMenuPrincipal

    Private Sub fMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso

        Me.btnCrearCliente.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Clientes", "alta")
        Me.btnCrearGrupoDeUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "alta")
        Me.btnCrearUsuario.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "alta")
        Me.btnListaGalpon.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "GalponesPosiciones", "lectura")
        Me.btnListaCliente.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Clientes", "lectura")
        Me.btnListaDeGrupoDeUsuarios.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Grupos", "lectura")
        Me.btnListaDeMercaderia.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Mercaderias", "lectura")
        Me.btnListaDeUsuario.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Usuarios", "lectura")
        Me.btnNuevoGalpon.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "GalponesPosiciones", "alta")
        Me.btnNuevoIngreso.Visible = Negocio.cPermiso.ComprobarPermisosUsuario(Negocio.GestorSesion.CargarUsuarioActual(), "Mercaderias", "alta")
    End Sub

    Private Sub ListaDeMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaDeMercaderia.Click
        Dim vMercaderiaLista As New fMercaderiaLista
        vMercaderiaLista.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoIngreso.Click
        Dim vMercaderiaNueva As New fMercaderiaNueva
        vMercaderiaNueva.Show()
        Me.Close()
    End Sub

    Private Sub btnCrearCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearCliente.Click
        Dim vClientes As New fClienteNuevo
        vClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnCrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearUsuario.Click
        Dim vNuevoUsuario As New fUsuarioNuevo
        vNuevoUsuario.Show()
        Me.Close()
    End Sub

    Private Sub btnCrearGrupoDeUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearGrupoDeUsuarios.Click
        Dim vGrupoNuevo As New fGrupoNuevo
        vGrupoNuevo.Show()
        Me.Close()
    End Sub

    Private Sub btnListaGrupoDeUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaDeGrupoDeUsuarios.Click
        Dim vGrupoLista As New fGrupoLista
        vGrupoLista.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoGalpon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoGalpon.Click
        Dim vGalpones As New fGalponNuevo
        vGalpones.Show()
        Me.Close()
    End Sub

    Private Sub btnListaDeUsuario_Click(sender As Object, e As EventArgs) Handles btnListaDeUsuario.Click
        Dim vListaUsuarios As New fUsuarioLista
        vListaUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub btnListaCliente_Click(sender As Object, e As EventArgs) Handles btnListaCliente.Click
        Dim vListaClientes As New fClienteLista
        vListaClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaGalpon.Click
        Dim vListaGalpones As New fGalponLista
        vListaGalpones.Show()
        Me.Close()
    End Sub
End Class