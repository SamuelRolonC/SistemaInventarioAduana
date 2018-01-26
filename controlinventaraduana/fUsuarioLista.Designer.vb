<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUsuarioLista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsuarioList = New System.Windows.Forms.DataGridView()
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnMenuPrincipal = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        CType(Me.UsuarioList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuarioList
        '
        Me.UsuarioList.AllowUserToAddRows = False
        Me.UsuarioList.AllowUserToDeleteRows = False
        Me.UsuarioList.AllowUserToOrderColumns = True
        Me.UsuarioList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.UsuarioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioList.Location = New System.Drawing.Point(11, 38)
        Me.UsuarioList.Name = "UsuarioList"
        Me.UsuarioList.ReadOnly = True
        Me.UsuarioList.Size = New System.Drawing.Size(760, 511)
        Me.UsuarioList.TabIndex = 24
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.SystemColors.Menu
        Me.pnlSuperior.Controls.Add(Me.btnNuevoUsuario)
        Me.pnlSuperior.Controls.Add(Me.btnMenuPrincipal)
        Me.pnlSuperior.Controls.Add(Me.txtBuscador)
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 2)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(784, 30)
        Me.pnlSuperior.TabIndex = 23
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(550, 0)
        Me.btnNuevoUsuario.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(110, 30)
        Me.btnNuevoUsuario.TabIndex = 10
        Me.btnNuevoUsuario.Text = "Nuevo Usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
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
        'fUsuarioLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.UsuarioList)
        Me.Controls.Add(Me.pnlSuperior)
        Me.Name = "fUsuarioLista"
        Me.Text = "Lista de Usuarios"
        CType(Me.UsuarioList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSuperior.ResumeLayout(False)
        Me.pnlSuperior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UsuarioList As DataGridView
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents btnMenuPrincipal As Button
    Friend WithEvents txtBuscador As TextBox
End Class
