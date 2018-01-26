Public Class fLogin

    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim xGestorSesion As New Negocio.GestorSesion

            ' @note Iniciarlizar archivo de sesión
            xGestorSesion.InicializarArchivo()

            ' Obtener y guardar el nombre de la PC
            xGestorSesion.GuardarHostName(Environment.MachineName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de archivo", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInBtn.Click
        Try
            Negocio.GestorLogeo.ValidarLogeo(Me.txtBoxUser.Text, Me.txtBoxPass.Text)

            Dim vMenuPrincipal As New fMenuPrincipal
            vMenuPrincipal.Show()
            Me.Close()

            mFuncsYProcs.sLimpiarCadaTextBox(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de logeo", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub EnterLogin_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBoxPass.KeyDown, txtBoxUser.KeyDown
        Try
            If e.KeyData = Keys.Enter Then

                Negocio.GestorLogeo.ValidarLogeo(Me.txtBoxUser.Text, Me.txtBoxPass.Text)

                Dim vMenuPrincipal As New fMenuPrincipal
                vMenuPrincipal.Show()
                Me.Close()

                mFuncsYProcs.sLimpiarCadaTextBox(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de logeo", MessageBoxButtons.OK)
        End Try
    End Sub
End Class