Public Class fModificarGrupoUsuarios
    Public Property GrupoId As Integer

    Private Sub fModificarGrupoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xGrupo As New AlmacenAduana.Negocio.cGrupo
        Dim xPermiso As New AlmacenAduana.Negocio.cPermiso
        Dim xPermGrupos As New AlmacenAduana.Negocio.cPermGrupos
        Dim vNumFila As Integer

        xGrupo.ObtenerGrupo(GrupoId)

        ' Deshabilitar edicion de datos
        mFuncsYProcs.HabilitarTByCB(Me, False)
        Me.btnAplicar.Enabled = False

        Me.txtNombre.Text = xGrupo.nombre
        If xGrupo.habilitado Then
            cbHabilitar.Checked = True
        Else
            cbHabilitar.Checked = False
        End If

        For Each vFilaPermiso As System.Data.DataRow In xPermiso.CargarDatos().Rows
            ' Cargar nodos en TreeView
            Me.TreeView1.Nodes.Add(vFilaPermiso("nombre"))
            Me.TreeView1.Nodes(vNumFila).Nodes.Add("Alta")
            Me.TreeView1.Nodes(vNumFila).Nodes.Add("Baja")
            Me.TreeView1.Nodes(vNumFila).Nodes.Add("Modificación")
            Me.TreeView1.Nodes(vNumFila).Nodes.Add("Listado")

            Me.TreeView1.CheckBoxes = True

            ' Cargar permisos otorgados
            For Each vPermGrupos As System.Data.DataRow In xPermGrupos.CargarDatos(GrupoId).Rows
                If vFilaPermiso("id") = vPermGrupos("permisos_id") Then
                    If vPermGrupos("Alta") = 1 Then
                        Me.TreeView1.Nodes(vNumFila).Nodes(0).Checked = True
                    Else
                        Me.TreeView1.Nodes(vNumFila).Nodes(0).Checked = False
                    End If

                    If vPermGrupos("Baja") = 1 Then
                        Me.TreeView1.Nodes(vNumFila).Nodes(1).Checked = True
                    Else
                        Me.TreeView1.Nodes(vNumFila).Nodes(1).Checked = False
                    End If

                    If vPermGrupos("Modificacion") = 1 Then
                        Me.TreeView1.Nodes(vNumFila).Nodes(2).Checked = True
                    Else
                        Me.TreeView1.Nodes(vNumFila).Nodes(2).Checked = False
                    End If

                    If vPermGrupos("Lectura") = 1 Then
                        Me.TreeView1.Nodes(vNumFila).Nodes(3).Checked = True
                    Else
                        Me.TreeView1.Nodes(vNumFila).Nodes(3).Checked = False
                    End If
                End If
            Next

            vNumFila += 1
        Next
    End Sub

    Private Sub btnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnMenuPrincipal.Click
        Dim vMenuPrincipal As New fMenuPrincipal

        vMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim xGrupo As New AlmacenAduana.Negocio.cGrupo
        Dim xPermGrupo As New AlmacenAduana.Negocio.cPermGrupos
        Dim vListaGrupoUsuarios As New fListaGrupos

        xGrupo.BorrarGrupo(GrupoId)
        MessageBox.Show("Borrado exitosamente", "Aviso")
        vListaGrupoUsuarios.Show()
        Me.Close()
    End Sub
End Class