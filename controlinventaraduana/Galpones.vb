Public Class Galpones

    Private Sub fGalpones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mFuncsYProcs.EstablecerCmbEntrepiso(cmbEntrepiso)
        txtID.MaxLength = 15
        txtDescripcion.MaxLength = 30
        txtPesoMaxEntrepiso.MaxLength = 6
    End Sub

    Private Sub btnVolveralMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        fMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim vDatosValidos As Boolean = True
        Dim xGalpones As New AlmacenAduana.Negocio.cGalpon
        If Me.txtID.Text <> "" Then
            xGalpones.ID = Me.txtID.Text
        Else
            vDatosValidos = False
            Me.lblID.ForeColor = Color.Red
        End If
        If Me.txtDescripcion.Text <> "" Then
            xGalpones.descripcion = Me.txtDescripcion.Text
        Else
            vDatosValidos = False
            Me.lblDescripcion.ForeColor = Color.Red
        End If
        If Me.txtPesoMaxEntrepiso.Text <> "" Then
            xGalpones.pesoMaxEntrepiso = Me.txtPesoMaxEntrepiso.Text
        Else
            vDatosValidos = False
            Me.lblPesoMaxEntrepiso.ForeColor = Color.Red
        End If
    End Sub
End Class