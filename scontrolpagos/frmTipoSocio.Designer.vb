<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoSocio
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDatoCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtInicial = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pDatos.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblNombre)
        Me.pPrincipal.Controls.Add(Me.txtNombre)
        Me.pPrincipal.Controls.Add(Me.txtMonto)
        Me.pPrincipal.Controls.Add(Me.txtInicial)
        Me.pPrincipal.Controls.Add(Me.lblMonto)
        Me.pPrincipal.Controls.Add(Me.lblInicial)
        Me.pPrincipal.Location = New System.Drawing.Point(4, 56)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(454, 260)
        Me.pPrincipal.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 20)
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
        Me.lblDatoCodigo.Location = New System.Drawing.Point(104, 18)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 72)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(105, 66)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtNombre.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(105, 118)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(148, 26)
        Me.txtMonto.TabIndex = 12
        '
        'txtInicial
        '
        Me.txtInicial.Location = New System.Drawing.Point(105, 170)
        Me.txtInicial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(148, 26)
        Me.txtInicial.TabIndex = 12
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(12, 124)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(58, 20)
        Me.lblMonto.TabIndex = 7
        Me.lblMonto.Text = "Monto:"
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Location = New System.Drawing.Point(12, 176)
        Me.lblInicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(53, 20)
        Me.lblInicial.TabIndex = 7
        Me.lblInicial.Text = "Inicial:"
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(4, 7)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(876, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(200, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(475, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento Tipo de Socios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnListar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Controls.Add(Me.btnNuevo)
        Me.pnlBotones.Location = New System.Drawing.Point(4, 318)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(454, 51)
        Me.pnlBotones.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(323, 8)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 35)
        Me.btnListar.TabIndex = 7
        Me.btnListar.Text = "&Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(171, 8)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(19, 8)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'pDatos
        '
        Me.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDatos.Controls.Add(Me.dgDatos)
        Me.pDatos.Location = New System.Drawing.Point(463, 56)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(417, 313)
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
        Me.dgDatos.Location = New System.Drawing.Point(3, 5)
        Me.dgDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgDatos.MultiSelect = False
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersVisible = False
        Me.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatos.Size = New System.Drawing.Size(409, 300)
        Me.dgDatos.TabIndex = 3
        '
        'frmTipoSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 376)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTipoSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Socios"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
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
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtInicial As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button

End Class
