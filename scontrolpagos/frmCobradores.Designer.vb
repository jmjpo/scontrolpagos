<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobradores
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
        Me.lblcomision = New System.Windows.Forms.Label()
        Me.txtcomision = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDatoCodigo = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
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
        Me.pPrincipal.Controls.Add(Me.lblcomision)
        Me.pPrincipal.Controls.Add(Me.txtcomision)
        Me.pPrincipal.Controls.Add(Me.lblCelular)
        Me.pPrincipal.Controls.Add(Me.txtCelular)
        Me.pPrincipal.Controls.Add(Me.lblTelefono)
        Me.pPrincipal.Controls.Add(Me.txtTelefono)
        Me.pPrincipal.Controls.Add(Me.lblSegundoNombre)
        Me.pPrincipal.Controls.Add(Me.txtSegundoNombre)
        Me.pPrincipal.Controls.Add(Me.txtSegundoApellido)
        Me.pPrincipal.Controls.Add(Me.lblSegundoApellido)
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblPrimerNombre)
        Me.pPrincipal.Controls.Add(Me.txtPrimerNombre)
        Me.pPrincipal.Controls.Add(Me.txtPrimerApellido)
        Me.pPrincipal.Controls.Add(Me.lblPrimerApellido)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(770, 212)
        Me.pPrincipal.TabIndex = 0
        '
        'lblcomision
        '
        Me.lblcomision.AutoSize = True
        Me.lblcomision.Location = New System.Drawing.Point(25, 174)
        Me.lblcomision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomision.Name = "lblcomision"
        Me.lblcomision.Size = New System.Drawing.Size(78, 20)
        Me.lblcomision.TabIndex = 30
        Me.lblcomision.Text = "Comision:"
        '
        'txtcomision
        '
        Me.txtcomision.Location = New System.Drawing.Point(182, 171)
        Me.txtcomision.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcomision.Name = "txtcomision"
        Me.txtcomision.Size = New System.Drawing.Size(148, 26)
        Me.txtcomision.TabIndex = 6
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(402, 132)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(62, 20)
        Me.lblCelular.TabIndex = 25
        Me.lblCelular.Text = "Celular:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(561, 132)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(148, 26)
        Me.txtCelular.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(25, 132)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 19
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(182, 129)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 26)
        Me.txtTelefono.TabIndex = 4
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Location = New System.Drawing.Point(25, 90)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(138, 20)
        Me.lblSegundoNombre.TabIndex = 13
        Me.lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(182, 87)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtSegundoNombre.TabIndex = 1
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(562, 90)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(148, 26)
        Me.txtSegundoApellido.TabIndex = 3
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Location = New System.Drawing.Point(402, 90)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(138, 20)
        Me.lblSegundoApellido.TabIndex = 14
        Me.lblSegundoApellido.Text = "Segundo Apellido:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(25, 6)
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
        Me.lblDatoCodigo.Location = New System.Drawing.Point(181, 5)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Location = New System.Drawing.Point(25, 48)
        Me.lblPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(118, 20)
        Me.lblPrimerNombre.TabIndex = 3
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(182, 45)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtPrimerNombre.TabIndex = 0
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(561, 45)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(148, 26)
        Me.txtPrimerApellido.TabIndex = 2
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Location = New System.Drawing.Point(402, 48)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(118, 20)
        Me.lblPrimerApellido.TabIndex = 7
        Me.lblPrimerApellido.Text = "Primer Apellido:"
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(7, 9)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(770, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(147, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(474, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Cobradores"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnListar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Controls.Add(Me.btnNuevo)
        Me.pnlBotones.Location = New System.Drawing.Point(7, 280)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(770, 51)
        Me.pnlBotones.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(562, 7)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 35)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "&Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(328, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(94, 7)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'pDatos
        '
        Me.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDatos.Controls.Add(Me.dgDatos)
        Me.pDatos.Location = New System.Drawing.Point(7, 339)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(770, 242)
        Me.pDatos.TabIndex = 5
        '
        'dgDatos
        '
        Me.dgDatos.AllowUserToAddRows = False
        Me.dgDatos.AllowUserToDeleteRows = False
        Me.dgDatos.AllowUserToResizeColumns = False
        Me.dgDatos.AllowUserToResizeRows = False
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(3, 5)
        Me.dgDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgDatos.MultiSelect = False
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersVisible = False
        Me.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatos.Size = New System.Drawing.Size(762, 230)
        Me.dgDatos.TabIndex = 3
        '
        'frmCobradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 582)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobradores"
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
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents lblcomision As System.Windows.Forms.Label
    Friend WithEvents txtcomision As System.Windows.Forms.TextBox

End Class
