<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fGrupoLista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnNuevoGrupo = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.MarcarDespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmstripAlmacen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dgvListaGrupos = New System.Windows.Forms.DataGridView()
        Me.pnlSuperior.SuspendLayout()
        Me.cmstripAlmacen.SuspendLayout()
        CType(Me.dgvListaGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.Menu
        Me.pnlSuperior.Controls.Add(Me.btnNuevoGrupo)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Controls.Add(Me.txtBuscador)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 18
        '
        'btnNuevoGrupo
        '
        Me.btnNuevoGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoGrupo.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNuevoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoGrupo.Location = New System.Drawing.Point(550, 0)
        Me.btnNuevoGrupo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
        Me.btnNuevoGrupo.Size = New System.Drawing.Size(110, 30)
        Me.btnNuevoGrupo.TabIndex = 10
        Me.btnNuevoGrupo.Text = "Nuevo Grupo"
        Me.btnNuevoGrupo.UseVisualStyleBackColor = True
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 7
        Me.btnMenuPrincipal.Text = "Menu Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(662, 2)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(120, 26)
        Me.txtBuscador.TabIndex = 4
        Me.txtBuscador.Text = "Buscador"
        '
        'MarcarDespachoToolStripMenuItem
        '
        Me.MarcarDespachoToolStripMenuItem.Name = "MarcarDespachoToolStripMenuItem"
        Me.MarcarDespachoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MarcarDespachoToolStripMenuItem.Text = "Marcar despacho"
        '
        'cmstripAlmacen
        '
        Me.cmstripAlmacen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarDespachoToolStripMenuItem})
        Me.cmstripAlmacen.Name = "conMenAlmacen"
        Me.cmstripAlmacen.Size = New System.Drawing.Size(166, 26)
        '
        'dgvListaGrupos
        '
        Me.dgvListaGrupos.AllowUserToAddRows = False
        Me.dgvListaGrupos.AllowUserToDeleteRows = False
        Me.dgvListaGrupos.AllowUserToOrderColumns = True
        Me.dgvListaGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvListaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaGrupos.Location = New System.Drawing.Point(12, 36)
        Me.dgvListaGrupos.Name = "dgvListaGrupos"
        Me.dgvListaGrupos.ReadOnly = True
        Me.dgvListaGrupos.Size = New System.Drawing.Size(760, 513)
        Me.dgvListaGrupos.TabIndex = 19
        '
        'fGrupoLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.dgvListaGrupos)
        Me.Name = "fGrupoLista"
        Me.Text = "Lista de Grupos"
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.cmstripAlmacen.ResumeLayout(False)
        CType(Me.dgvListaGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents MarcarDespachoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmstripAlmacen As ContextMenuStrip
    Friend WithEvents dgvListaGrupos As DataGridView
    Friend WithEvents btnNuevoGrupo As Button
End Class
