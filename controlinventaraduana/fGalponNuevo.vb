Public Class fGalponNuevo

    Private Sub fGalpones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '@note Comprobar permisos del usuario
        Dim xGestorSesion As New Negocio.GestorSesion
        Dim xPermiso As New Negocio.cPermiso
        'Me.btnListaGalpones.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "listado")
        Me.btnAgregar.Visible = xPermiso.ComprobarPermisosUsuario(xGestorSesion.CargarUsuarioActual(), "Galpones", "alta")

        ' @note Establece la capacidad máxima de cada textbox
        txtNombreGalpon.MaxLength = 45
        txtDescripcionGalpon.MaxLength = 45
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim vDatosValidos As Boolean = True
        Dim xGalpon As New Negocio.cGalpon
        Dim xPosicion As New Negocio.cPosicion
        Dim xList As New List(Of Negocio.cPosicion)

        Try
            If Me.txtNombreGalpon.Text = "" Then
                Throw New Exception("Debe ingresar un nombre para el galpón")
            End If

            If Me.txtDescripcionGalpon.Text = "" Then
                Throw New Exception("Debe ingresar una descripcion para el galpón")
            End If

            If Not IsNumeric(Me.txtCantidadPosiciones.Text) Then
                Throw New Exception("El campo Cantidad de Posiciones debe ser numérico")
            End If

            xGalpon.nombre = Me.txtNombreGalpon.Text
            xGalpon.descripcion = Me.txtDescripcionGalpon.Text
            xGalpon.guardarDatos()

            For i = 1 To CInt(Me.txtCantidadPosiciones.Text)
                xPosicion.nombre = i
                xPosicion.GalponId = xGalpon.ObtenerId(xGalpon.nombre)
                xPosicion.ubicacion = "PlantaBaja"
                xPosicion.PesoMax = 0
                xPosicion.guardarDatos()
            Next

            MessageBox.Show("Agregado exitosamente", "Aviso")
            mFuncsYProcs.sLimpiarCadaTextBox(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal
        vMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class
