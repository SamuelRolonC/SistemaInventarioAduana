<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGalponLista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvGalpones = New System.Windows.Forms.DataGridView()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.btnNuevoGalpon = New System.Windows.Forms.Button()
        CType(Me.dgvGalpones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGalpones
        '
        Me.dgvGalpones.AllowUserToAddRows = False
        Me.dgvGalpones.AllowUserToDeleteRows = False
        Me.dgvGalpones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGalpones.Location = New System.Drawing.Point(12, 36)
        Me.dgvGalpones.Name = "dgvGalpones"
        Me.dgvGalpones.Size = New System.Drawing.Size(760, 513)
        Me.dgvGalpones.TabIndex = 0
        '
        'pnlSuperior
        '
        Me.pnlSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSuperior.Controls.Add(Me.btnNuevoGalpon)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 12
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(110, 30)
        Me.btnMenuPrincipal.TabIndex = 19
        Me.btnMenuPrincipal.Text = "Menú Principal"
        Me.btnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'btnNuevoGalpon
        '
        Me.btnNuevoGalpon.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNuevoGalpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoGalpon.Location = New System.Drawing.Point(674, 0)
        Me.btnNuevoGalpon.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.btnNuevoGalpon.Name = "btnNuevoGalpon"
        Me.btnNuevoGalpon.Size = New System.Drawing.Size(110, 30)
        Me.btnNuevoGalpon.TabIndex = 20
        Me.btnNuevoGalpon.Text = "Nuevo Galpón"
        Me.btnNuevoGalpon.UseVisualStyleBackColor = True
        '
        'fGalponLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Controls.Add(Me.dgvGalpones)
        Me.Name = "fGalponLista"
        Me.Text = "Lista de Galpones"
        CType(Me.dgvGalpones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvGalpones As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents btnNuevoGalpon As Button
End Class
