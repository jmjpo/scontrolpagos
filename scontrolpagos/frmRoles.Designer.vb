<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Me.pPrincipal = New System.Windows.Forms.Panel()
        Me.lblPermisos = New System.Windows.Forms.Label()
        Me.dgpermisos = New System.Windows.Forms.DataGridView()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDatoCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.pPrincipal.SuspendLayout()
        CType(Me.dgpermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pDatos.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.lblPermisos)
        Me.pPrincipal.Controls.Add(Me.dgpermisos)
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblNombre)
        Me.pPrincipal.Controls.Add(Me.txtNombre)
        Me.pPrincipal.Location = New System.Drawing.Point(6, 59)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(675, 254)
        Me.pPrincipal.TabIndex = 0
        '
        'lblPermisos
        '
        Me.lblPermisos.AutoSize = True
        Me.lblPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermisos.Location = New System.Drawing.Point(241, 9)
        Me.lblPermisos.Name = "lblPermisos"
        Me.lblPermisos.Size = New System.Drawing.Size(148, 20)
        Me.lblPermisos.TabIndex = 11
        Me.lblPermisos.Text = "Permisos del Rol:"
        '
        'dgpermisos
        '
        Me.dgpermisos.AllowUserToAddRows = False
        Me.dgpermisos.AllowUserToDeleteRows = False
        Me.dgpermisos.AllowUserToResizeColumns = False
        Me.dgpermisos.AllowUserToResizeRows = False
        Me.dgpermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgpermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpermisos.Location = New System.Drawing.Point(245, 32)
        Me.dgpermisos.Name = "dgpermisos"
        Me.dgpermisos.RowHeadersVisible = False
        Me.dgpermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpermisos.Size = New System.Drawing.Size(424, 207)
        Me.dgpermisos.TabIndex = 10
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(2, 33)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Codigo:"
        '
        'lblDatoCodigo
        '
        Me.lblDatoCodigo.AutoSize = True
        Me.lblDatoCodigo.BackColor = System.Drawing.Color.White
        Me.lblDatoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDatoCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblDatoCodigo.Location = New System.Drawing.Point(85, 33)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(2, 85)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 82)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 26)
        Me.txtNombre.TabIndex = 9
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(6, 10)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(968, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(244, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(479, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento Roles Usuarios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnListar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Controls.Add(Me.btnNuevo)
        Me.pnlBotones.Location = New System.Drawing.Point(7, 315)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(674, 51)
        Me.pnlBotones.TabIndex = 2
        '
        'pDatos
        '
        Me.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDatos.Controls.Add(Me.dgDatos)
        Me.pDatos.Location = New System.Drawing.Point(684, 58)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(290, 309)
        Me.pDatos.TabIndex = 5
        '
        'dgDatos
        '
        Me.dgDatos.AllowUserToAddRows = False
        Me.dgDatos.AllowUserToDeleteRows = False
        Me.dgDatos.AllowUserToResizeColumns = False
        Me.dgDatos.AllowUserToResizeRows = False
        Me.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(4, 5)
        Me.dgDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgDatos.MultiSelect = False
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersVisible = False
        Me.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatos.Size = New System.Drawing.Size(279, 297)
        Me.dgDatos.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(6, 7)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(283, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(560, 5)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 35)
        Me.btnListar.TabIndex = 7
        Me.btnListar.Text = "&Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 376)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(7, 9)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles de Usuario"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        CType(Me.dgpermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pDatos.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents dgpermisos As System.Windows.Forms.DataGridView
    Friend WithEvents lblPermisos As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button

End Class
