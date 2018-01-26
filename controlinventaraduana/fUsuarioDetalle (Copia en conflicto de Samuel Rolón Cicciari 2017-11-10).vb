Public Class fUsuarioDetalle
    Property usuarioID As String
    Public Property UsuarioIdLog As String

    Private Sub fUsuarioNuevo2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Dim xDTUsuarios As New DataTable
        Dim xUsuario As New AlmacenAduana.Negocio.cUsuario
        Dim xUsGrupos As New AlmacenAduana.Negocio.cUs_Grupos
        Dim xDes As New AlmacenAduana.Negocio.encr3Des

        xDTUsuarios = xUsuario.cargarDatosxId(" id = '" & usuarioID & "'")

        Dim vUsuarios As DataRow = xDTUsuarios.Rows(0)

        Dim xGrupo As New AlmacenAduana.Negocio.cGrupo
        Dim x As New DataTable
        Dim i As Integer = 0


        Me.txtNombre.Text = CStr(vUsuarios("nombre"))
        Me.txtApellido.Text = CStr(vUsuarios("apellido"))
        Me.txtID.Text = CStr(vUsuarios("id"))
        Me.txtMail.Text = CStr(xDes.DesencriptarDato(vUsuarios("email")))
        Me.cbHabilitado.Checked = vUsuarios("habilitado")

        For Each item In xGrupo.CargarTabla().Rows
            cblgrupos.Items.Add(item(1))
        Next

        For Each vFila As DataRow In xUsGrupos.cargarDatos(usuarioID).Rows
            xGrupo.ObtenerGrupo(vFila("grupos_id"))
            For i = 0 To (cblgrupos.Items.Count - 1)
                If cblgrupos.Items(i).ToString = xGrupo.nombre Then
                    cblgrupos.SetItemChecked(i, True)
                End If
            Next
        Next

    End Sub


    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        Dim vDatosValidos As Boolean = True
        Dim xUsuarios As New AlmacenAduana.Negocio.cUsuario()
        Dim xUsGrupos As New AlmacenAduana.Negocio.cUs_Grupos()

        If Me.txtNombre.Text <> "" Then
            xUsuarios.establecerValores("nombre", Me.txtNombre.Text)
        Else
            vDatosValidos = False
        End If

        If Me.txtApellido.Text <> "" Then
            xUsuarios.establecerValores("apellido", Me.txtApellido.Text)
        Else
            vDatosValidos = False
        End If

        If Me.txtID.Text <> "" Then
            xUsuarios.establecerValores("id", Me.txtID.Text)
        Else
            vDatosValidos = False
        End If

        If Me.txtMail.Text <> "" Then
            xUsuarios.establecerValores("mail", Me.txtNombre.Text)
        Else
            vDatosValidos = False
        End If

        If Me.txtContraseña1.Text <> "" Then

            xUsuarios.establecerValores("pass", Me.txtContraseña1.Text)
        End If

        If vDatosValidos Then
            xUsuarios.ModificarRegistro()

            If cblgrupos.CheckedItems.Count <> 0 Then

                Dim xGrupos As New AlmacenAduana.Negocio.cGrupo

                Dim i As Integer

                For i = 0 To cblgrupos.Items.Count - 1
                    If cblgrupos.GetItemChecked(i) Then

                        xUsGrupos.grupoId = xGrupos.ObtenerId(cblgrupos.Items(i))
                        xUsGrupos.usuarioId = xUsuarios.id
                        'xUsGrupos.guardarDatos(xUsGrupos)
                        xUsGrupos.ModificarRegistro()
                    End If
                Next
            End If

            mFuncsYProcs.ReestablecerCadaLabel(Me)
            MessageBox.Show("Modificado exitosamente", "Aviso")
        Else
            MessageBox.Show("Campos obligatorios vacíos o datos inválidos", "Atención")
        End If


    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal

        vMenuPrincipal.UsuarioIdLog = Me.UsuarioIdLog
        vMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class