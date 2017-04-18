<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.cmbrol = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblrol = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblConfirmar = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.pRol = New System.Windows.Forms.Panel()
        Me.cmbCobrador = New System.Windows.Forms.ComboBox()
        Me.lblTitulopRol = New System.Windows.Forms.Label()
        Me.lblcobrador = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDatos.SuspendLayout()
        Me.pRol.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblNombre)
        Me.pPrincipal.Controls.Add(Me.txtNombre)
        Me.pPrincipal.Controls.Add(Me.cmbrol)
        Me.pPrincipal.Controls.Add(Me.cmbEstado)
        Me.pPrincipal.Controls.Add(Me.lblUsuario)
        Me.pPrincipal.Controls.Add(Me.lblrol)
        Me.pPrincipal.Controls.Add(Me.lblestado)
        Me.pPrincipal.Controls.Add(Me.txtConfirmar)
        Me.pPrincipal.Controls.Add(Me.txtUsuario)
        Me.pPrincipal.Controls.Add(Me.lblConfirmar)
        Me.pPrincipal.Controls.Add(Me.txtPassword)
        Me.pPrincipal.Controls.Add(Me.lblPassword)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(770, 283)
        Me.pPrincipal.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(20, 22)
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
        Me.lblDatoCodigo.Location = New System.Drawing.Point(194, 20)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(20, 66)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(194, 60)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(269, 26)
        Me.txtNombre.TabIndex = 0
        '
        'cmbrol
        '
        Me.cmbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrol.FormattingEnabled = True
        Me.cmbrol.Location = New System.Drawing.Point(571, 234)
        Me.cmbrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbrol.Name = "cmbrol"
        Me.cmbrol.Size = New System.Drawing.Size(180, 28)
        Me.cmbrol.TabIndex = 5
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(194, 236)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(180, 28)
        Me.cmbEstado.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(20, 110)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(68, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Location = New System.Drawing.Point(480, 237)
        Me.lblrol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(37, 20)
        Me.lblrol.TabIndex = 6
        Me.lblrol.Text = "Rol:"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(20, 242)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(64, 20)
        Me.lblestado.TabIndex = 6
        Me.lblestado.Text = "Estado:"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(194, 192)
        Me.txtConfirmar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(180, 26)
        Me.txtConfirmar.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(194, 104)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(180, 26)
        Me.txtUsuario.TabIndex = 1
        '
        'lblConfirmar
        '
        Me.lblConfirmar.AutoSize = True
        Me.lblConfirmar.Location = New System.Drawing.Point(20, 198)
        Me.lblConfirmar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmar.Name = "lblConfirmar"
        Me.lblConfirmar.Size = New System.Drawing.Size(155, 20)
        Me.lblConfirmar.TabIndex = 7
        Me.lblConfirmar.Text = "Confirmar Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(194, 148)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 26)
        Me.txtPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 154)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 20)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
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
        Me.lblTitulo.Location = New System.Drawing.Point(193, 4)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(384, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento Usuarios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(21, 7)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(226, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pBotones
        '
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBotones.Controls.Add(Me.btnListar)
        Me.pBotones.Controls.Add(Me.btnEliminar)
        Me.pBotones.Controls.Add(Me.btnGuardar)
        Me.pBotones.Controls.Add(Me.btnNuevo)
        Me.pBotones.Location = New System.Drawing.Point(7, 346)
        Me.pBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(770, 51)
        Me.pBotones.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(636, 7)
        Me.btnListar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 35)
        Me.btnListar.TabIndex = 3
        Me.btnListar.Text = "&Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(431, 7)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
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
        Me.dgDatos.Size = New System.Drawing.Size(762, 250)
        Me.dgDatos.TabIndex = 3
        '
        'pDatos
        '
        Me.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDatos.Controls.Add(Me.dgDatos)
        Me.pDatos.Location = New System.Drawing.Point(7, 402)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(770, 260)
        Me.pDatos.TabIndex = 4
        '
        'pRol
        '
        Me.pRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pRol.Controls.Add(Me.cmbCobrador)
        Me.pRol.Controls.Add(Me.lblTitulopRol)
        Me.pRol.Controls.Add(Me.lblcobrador)
        Me.pRol.Controls.Add(Me.btnAceptar)
        Me.pRol.Location = New System.Drawing.Point(150, 234)
        Me.pRol.Name = "pRol"
        Me.pRol.Size = New System.Drawing.Size(485, 200)
        Me.pRol.TabIndex = 28
        Me.pRol.Visible = False
        '
        'cmbCobrador
        '
        Me.cmbCobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCobrador.FormattingEnabled = True
        Me.cmbCobrador.Location = New System.Drawing.Point(189, 78)
        Me.cmbCobrador.Name = "cmbCobrador"
        Me.cmbCobrador.Size = New System.Drawing.Size(288, 28)
        Me.cmbCobrador.TabIndex = 1
        '
        'lblTitulopRol
        '
        Me.lblTitulopRol.AutoSize = True
        Me.lblTitulopRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulopRol.Location = New System.Drawing.Point(166, 11)
        Me.lblTitulopRol.Name = "lblTitulopRol"
        Me.lblTitulopRol.Size = New System.Drawing.Size(151, 25)
        Me.lblTitulopRol.TabIndex = 2
        Me.lblTitulopRol.Text = "Rol Cobrador"
        '
        'lblcobrador
        '
        Me.lblcobrador.Location = New System.Drawing.Point(5, 68)
        Me.lblcobrador.Name = "lblcobrador"
        Me.lblcobrador.Size = New System.Drawing.Size(178, 48)
        Me.lblcobrador.TabIndex = 2
        Me.lblcobrador.Text = "Seleccione el cobrador para asignar al usuario:"
        '
        'btnAceptar
        '
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(190, 157)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 668)
        Me.Controls.Add(Me.pRol)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDatos.ResumeLayout(False)
        Me.pRol.ResumeLayout(False)
        Me.pRol.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents lblConfirmar As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents pBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents cmbrol As System.Windows.Forms.ComboBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents pRol As System.Windows.Forms.Panel
    Friend WithEvents cmbCobrador As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitulopRol As System.Windows.Forms.Label
    Friend WithEvents lblcobrador As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

End Class
