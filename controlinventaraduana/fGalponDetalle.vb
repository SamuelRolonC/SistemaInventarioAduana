Public Class fGalponDetalle
    Property GalponId As Integer

    Private Sub fGalponDetalle_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '@note Obtiene todos los datos del galpon para el formulario
        Dim xGalpon As New Negocio.cGalpon
        xGalpon.ObtenerGalpon(GalponId)

        '@note Carga los datos en los controles del formulario
        Me.txtID.Text = xGalpon.id
        Me.txtDescripcion.Text = xGalpon.descripcion

        '@note Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        btnAplicar.Enabled = False
        txtID.Enabled = False
        txtDescripcion.Enabled = False
        txtPesoMaxEntrepiso.Enabled = False
        cmbEntrepiso.Enabled = False

        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        Me.btnEditar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "modificacion")
        Me.btnAplicar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "modificacion")
        Me.btnBorrar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "baja")
        Me.btnListaGalpones.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "lectura")
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As EventArgs)
        mFuncsYProcs.HabilitarTByCB(Me, True)
        txtID.Enabled = False
        btnAplicar.Enabled = True
        txtDescripcion.Enabled = True
        txtPesoMaxEntrepiso.Enabled = True
        cmbEntrepiso.Enabled = True
    End Sub
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xGalpones As New Negocio.cGalpon
        Dim vGalpones As New fGalponLista
        Dim hola As Byte
        hola = MsgBox("¿Estas seguro que quieres eliminar este galpon?", vbYesNo, "eliminar")
        If hola = 1 Then
            xGalpones.BorrarRegistro(GalponId)
            MessageBox.Show("Borrado exitosamente", "Aviso")
            vGalpones.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vDatosValidos As Boolean = True
        Dim xGalpones As New Negocio.cGalpon()

        xGalpones.id = Me.txtID.Text

        If Me.txtDescripcion.Text <> "" Then
            xGalpones.descripcion = Me.txtDescripcion.Text
        Else
            vDatosValidos = False
            Me.lblDescripcion.ForeColor = Color.Red
        End If

        xGalpones.descripcion = Me.txtDescripcion.Text


        ' @param If Agrega la mercaderia al almacen y reestablece el formulario
        If vDatosValidos Then
            xGalpones.ModificarRegistro()
            mFuncsYProcs.ReestablecerCadaLabel(Me)
            MessageBox.Show("Modificado exitosamente", "Aviso")
        Else
            MessageBox.Show("Campos obligatorios vacíos o datos inválidos", "Atención")
        End If
    End Sub

    Private Sub btnListaGalpones_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnListaGalpones.Click

        Dim vListaGalpones As New fGalponLista
        vListaGalpones.Show()
        Me.Close()

    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnAplicar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.Click

    End Sub
End Class