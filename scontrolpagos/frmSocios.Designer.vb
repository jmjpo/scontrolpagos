<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocios
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
        Me.lblUID = New System.Windows.Forms.Label()
        Me.txtRegistroCedula = New System.Windows.Forms.TextBox()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblRegistroCedula = New System.Windows.Forms.Label()
        Me.lblfotosocio = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.txtOrdenCedula = New System.Windows.Forms.TextBox()
        Me.cmbTipoSocio = New System.Windows.Forms.ComboBox()
        Me.lblOrdenCedula = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblDPI = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreoElectronico = New System.Windows.Forms.Label()
        Me.lblTipoSocio = New System.Windows.Forms.Label()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDatoCodigo = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtApellidoCasada = New System.Windows.Forms.TextBox()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblApellidoCasada = New System.Windows.Forms.Label()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.pEliminar = New System.Windows.Forms.Panel()
        Me.cmbMotivo = New System.Windows.Forms.ComboBox()
        Me.lblTitulopEliminar = New System.Windows.Forms.Label()
        Me.lblmotivo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtUID1 = New System.Windows.Forms.TextBox()
        Me.txtUID2 = New System.Windows.Forms.TextBox()
        Me.txtUID3 = New System.Windows.Forms.TextBox()
        Me.txtUID4 = New System.Windows.Forms.TextBox()
        Me.pPrincipal.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pDatos.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.txtUID4)
        Me.pPrincipal.Controls.Add(Me.txtUID3)
        Me.pPrincipal.Controls.Add(Me.txtUID2)
        Me.pPrincipal.Controls.Add(Me.txtUID1)
        Me.pPrincipal.Controls.Add(Me.lblUID)
        Me.pPrincipal.Controls.Add(Me.txtRegistroCedula)
        Me.pPrincipal.Controls.Add(Me.dtFechaNacimiento)
        Me.pPrincipal.Controls.Add(Me.lblRegistroCedula)
        Me.pPrincipal.Controls.Add(Me.lblfotosocio)
        Me.pPrincipal.Controls.Add(Me.lblFechaNacimiento)
        Me.pPrincipal.Controls.Add(Me.pbFoto)
        Me.pPrincipal.Controls.Add(Me.txtOrdenCedula)
        Me.pPrincipal.Controls.Add(Me.cmbTipoSocio)
        Me.pPrincipal.Controls.Add(Me.lblOrdenCedula)
        Me.pPrincipal.Controls.Add(Me.lblCelular)
        Me.pPrincipal.Controls.Add(Me.txtDPI)
        Me.pPrincipal.Controls.Add(Me.txtCelular)
        Me.pPrincipal.Controls.Add(Me.lblDPI)
        Me.pPrincipal.Controls.Add(Me.lblTelefono)
        Me.pPrincipal.Controls.Add(Me.txtTelefono)
        Me.pPrincipal.Controls.Add(Me.txtCorreo)
        Me.pPrincipal.Controls.Add(Me.lblCorreoElectronico)
        Me.pPrincipal.Controls.Add(Me.lblTipoSocio)
        Me.pPrincipal.Controls.Add(Me.lblSegundoNombre)
        Me.pPrincipal.Controls.Add(Me.txtSegundoNombre)
        Me.pPrincipal.Controls.Add(Me.txtSegundoApellido)
        Me.pPrincipal.Controls.Add(Me.txtDireccion)
        Me.pPrincipal.Controls.Add(Me.lblSegundoApellido)
        Me.pPrincipal.Controls.Add(Me.lblDireccion)
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblPrimerNombre)
        Me.pPrincipal.Controls.Add(Me.txtPrimerNombre)
        Me.pPrincipal.Controls.Add(Me.txtPrimerApellido)
        Me.pPrincipal.Controls.Add(Me.txtApellidoCasada)
        Me.pPrincipal.Controls.Add(Me.lblPrimerApellido)
        Me.pPrincipal.Controls.Add(Me.lblApellidoCasada)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(966, 283)
        Me.pPrincipal.TabIndex = 0
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(359, 6)
        Me.lblUID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(42, 20)
        Me.lblUID.TabIndex = 28
        Me.lblUID.Text = "UID:"
        '
        'txtRegistroCedula
        '
        Me.txtRegistroCedula.Location = New System.Drawing.Point(820, 240)
        Me.txtRegistroCedula.Name = "txtRegistroCedula"
        Me.txtRegistroCedula.Size = New System.Drawing.Size(138, 26)
        Me.txtRegistroCedula.TabIndex = 13
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(825, 202)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(133, 26)
        Me.dtFechaNacimiento.TabIndex = 12
        '
        'lblRegistroCedula
        '
        Me.lblRegistroCedula.AutoSize = True
        Me.lblRegistroCedula.Location = New System.Drawing.Point(679, 246)
        Me.lblRegistroCedula.Name = "lblRegistroCedula"
        Me.lblRegistroCedula.Size = New System.Drawing.Size(127, 20)
        Me.lblRegistroCedula.TabIndex = 4
        Me.lblRegistroCedula.Text = "Registro Cedula:"
        '
        'lblfotosocio
        '
        Me.lblfotosocio.AutoSize = True
        Me.lblfotosocio.Location = New System.Drawing.Point(679, 40)
        Me.lblfotosocio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfotosocio.Name = "lblfotosocio"
        Me.lblfotosocio.Size = New System.Drawing.Size(90, 20)
        Me.lblfotosocio.TabIndex = 26
        Me.lblfotosocio.Text = "Foto Socio:"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(679, 203)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(141, 20)
        Me.lblFechaNacimiento.TabIndex = 26
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'pbFoto
        '
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Location = New System.Drawing.Point(775, 33)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(182, 155)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 6
        Me.pbFoto.TabStop = False
        '
        'txtOrdenCedula
        '
        Me.txtOrdenCedula.Location = New System.Drawing.Point(516, 240)
        Me.txtOrdenCedula.Name = "txtOrdenCedula"
        Me.txtOrdenCedula.Size = New System.Drawing.Size(148, 26)
        Me.txtOrdenCedula.TabIndex = 11
        '
        'cmbTipoSocio
        '
        Me.cmbTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoSocio.FormattingEnabled = True
        Me.cmbTipoSocio.Location = New System.Drawing.Point(164, 242)
        Me.cmbTipoSocio.Name = "cmbTipoSocio"
        Me.cmbTipoSocio.Size = New System.Drawing.Size(149, 28)
        Me.cmbTipoSocio.TabIndex = 10
        '
        'lblOrdenCedula
        '
        Me.lblOrdenCedula.AutoSize = True
        Me.lblOrdenCedula.Location = New System.Drawing.Point(359, 247)
        Me.lblOrdenCedula.Name = "lblOrdenCedula"
        Me.lblOrdenCedula.Size = New System.Drawing.Size(111, 20)
        Me.lblOrdenCedula.TabIndex = 2
        Me.lblOrdenCedula.Text = "Orden Cedula:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(359, 165)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(62, 20)
        Me.lblCelular.TabIndex = 25
        Me.lblCelular.Text = "Celular:"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(516, 200)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(148, 26)
        Me.txtDPI.TabIndex = 9
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(516, 160)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(148, 26)
        Me.txtCelular.TabIndex = 7
        '
        'lblDPI
        '
        Me.lblDPI.AutoSize = True
        Me.lblDPI.Location = New System.Drawing.Point(359, 206)
        Me.lblDPI.Name = "lblDPI"
        Me.lblDPI.Size = New System.Drawing.Size(40, 20)
        Me.lblDPI.TabIndex = 0
        Me.lblDPI.Text = "DPI:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(13, 166)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 19
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(165, 162)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 26)
        Me.txtTelefono.TabIndex = 6
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(165, 202)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(148, 26)
        Me.txtCorreo.TabIndex = 8
        '
        'lblCorreoElectronico
        '
        Me.lblCorreoElectronico.AutoSize = True
        Me.lblCorreoElectronico.Location = New System.Drawing.Point(13, 206)
        Me.lblCorreoElectronico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorreoElectronico.Name = "lblCorreoElectronico"
        Me.lblCorreoElectronico.Size = New System.Drawing.Size(144, 20)
        Me.lblCorreoElectronico.TabIndex = 20
        Me.lblCorreoElectronico.Text = "Correo Electronico:"
        '
        'lblTipoSocio
        '
        Me.lblTipoSocio.AutoSize = True
        Me.lblTipoSocio.Location = New System.Drawing.Point(13, 246)
        Me.lblTipoSocio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoSocio.Name = "lblTipoSocio"
        Me.lblTipoSocio.Size = New System.Drawing.Size(109, 20)
        Me.lblTipoSocio.TabIndex = 21
        Me.lblTipoSocio.Text = "Tipo de Socio:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Location = New System.Drawing.Point(13, 86)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(138, 20)
        Me.lblSegundoNombre.TabIndex = 13
        Me.lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(165, 82)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtSegundoNombre.TabIndex = 1
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(516, 80)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(148, 26)
        Me.txtSegundoApellido.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(164, 122)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(148, 26)
        Me.txtDireccion.TabIndex = 5
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Location = New System.Drawing.Point(359, 83)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(138, 20)
        Me.lblSegundoApellido.TabIndex = 14
        Me.lblSegundoApellido.Text = "Segundo Apellido:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(13, 126)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(126, 20)
        Me.lblDireccion.TabIndex = 15
        Me.lblDireccion.Text = "Direccion Cobro:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 6)
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
        Me.lblDatoCodigo.Location = New System.Drawing.Point(164, 6)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Location = New System.Drawing.Point(13, 46)
        Me.lblPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(118, 20)
        Me.lblPrimerNombre.TabIndex = 3
        Me.lblPrimerNombre.Text = "Primer Nombre:"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(165, 42)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtPrimerNombre.TabIndex = 0
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(516, 40)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(148, 26)
        Me.txtPrimerApellido.TabIndex = 2
        '
        'txtApellidoCasada
        '
        Me.txtApellidoCasada.Location = New System.Drawing.Point(516, 120)
        Me.txtApellidoCasada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellidoCasada.Name = "txtApellidoCasada"
        Me.txtApellidoCasada.Size = New System.Drawing.Size(148, 26)
        Me.txtApellidoCasada.TabIndex = 4
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Location = New System.Drawing.Point(359, 42)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(118, 20)
        Me.lblPrimerApellido.TabIndex = 7
        Me.lblPrimerApellido.Text = "Primer Apellido:"
        '
        'lblApellidoCasada
        '
        Me.lblApellidoCasada.AutoSize = True
        Me.lblApellidoCasada.Location = New System.Drawing.Point(359, 124)
        Me.lblApellidoCasada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoCasada.Name = "lblApellidoCasada"
        Me.lblApellidoCasada.Size = New System.Drawing.Size(128, 20)
        Me.lblApellidoCasada.TabIndex = 7
        Me.lblApellidoCasada.Text = "Apellido Casada:"
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(7, 9)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(966, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(303, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(398, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Socios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnListar)
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Controls.Add(Me.btnNuevo)
        Me.pnlBotones.Location = New System.Drawing.Point(7, 346)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(966, 51)
        Me.pnlBotones.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(845, 7)
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
        Me.btnEliminar.Location = New System.Drawing.Point(595, 6)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 35)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(345, 6)
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
        Me.btnNuevo.Location = New System.Drawing.Point(95, 6)
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
        Me.pDatos.Location = New System.Drawing.Point(7, 402)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(966, 260)
        Me.pDatos.TabIndex = 5
        '
        'dgDatos
        '
        Me.dgDatos.AllowUserToAddRows = False
        Me.dgDatos.AllowUserToDeleteRows = False
        Me.dgDatos.AllowUserToResizeColumns = False
        Me.dgDatos.AllowUserToResizeRows = False
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(5, 6)
        Me.dgDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgDatos.MultiSelect = False
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersVisible = False
        Me.dgDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatos.Size = New System.Drawing.Size(954, 246)
        Me.dgDatos.TabIndex = 3
        '
        'pEliminar
        '
        Me.pEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pEliminar.Controls.Add(Me.cmbMotivo)
        Me.pEliminar.Controls.Add(Me.lblTitulopEliminar)
        Me.pEliminar.Controls.Add(Me.lblmotivo)
        Me.pEliminar.Controls.Add(Me.btnCancelar)
        Me.pEliminar.Controls.Add(Me.btnAceptar)
        Me.pEliminar.Location = New System.Drawing.Point(289, 234)
        Me.pEliminar.Name = "pEliminar"
        Me.pEliminar.Size = New System.Drawing.Size(400, 200)
        Me.pEliminar.TabIndex = 27
        Me.pEliminar.Visible = False
        '
        'cmbMotivo
        '
        Me.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Location = New System.Drawing.Point(163, 75)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(234, 28)
        Me.cmbMotivo.TabIndex = 1
        '
        'lblTitulopEliminar
        '
        Me.lblTitulopEliminar.AutoSize = True
        Me.lblTitulopEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulopEliminar.Location = New System.Drawing.Point(118, 11)
        Me.lblTitulopEliminar.Name = "lblTitulopEliminar"
        Me.lblTitulopEliminar.Size = New System.Drawing.Size(163, 25)
        Me.lblTitulopEliminar.TabIndex = 2
        Me.lblTitulopEliminar.Text = "Eliminar Socio"
        '
        'lblmotivo
        '
        Me.lblmotivo.Location = New System.Drawing.Point(1, 70)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(178, 48)
        Me.lblmotivo.TabIndex = 2
        Me.lblmotivo.Text = "Seleccione el motivo para Eliminar al Socio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(231, 157)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 30)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(73, 157)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtUID1
        '
        Me.txtUID1.Location = New System.Drawing.Point(513, 6)
        Me.txtUID1.Name = "txtUID1"
        Me.txtUID1.Size = New System.Drawing.Size(35, 26)
        Me.txtUID1.TabIndex = 29
        Me.txtUID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID2
        '
        Me.txtUID2.Location = New System.Drawing.Point(552, 6)
        Me.txtUID2.Name = "txtUID2"
        Me.txtUID2.Size = New System.Drawing.Size(35, 26)
        Me.txtUID2.TabIndex = 29
        Me.txtUID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID3
        '
        Me.txtUID3.Location = New System.Drawing.Point(591, 6)
        Me.txtUID3.Name = "txtUID3"
        Me.txtUID3.Size = New System.Drawing.Size(35, 26)
        Me.txtUID3.TabIndex = 29
        Me.txtUID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID4
        '
        Me.txtUID4.Location = New System.Drawing.Point(630, 6)
        Me.txtUID4.Name = "txtUID4"
        Me.txtUID4.Size = New System.Drawing.Size(35, 26)
        Me.txtUID4.TabIndex = 29
        Me.txtUID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 668)
        Me.Controls.Add(Me.pEliminar)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSocios"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pDatos.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pEliminar.ResumeLayout(False)
        Me.pEliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidoCasada As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoCasada As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents lblTipoSocio As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents dtFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTipoSocio As System.Windows.Forms.ComboBox
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtRegistroCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblRegistroCedula As System.Windows.Forms.Label
    Friend WithEvents txtOrdenCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblOrdenCedula As System.Windows.Forms.Label
    Friend WithEvents txtDPI As System.Windows.Forms.TextBox
    Friend WithEvents lblDPI As System.Windows.Forms.Label
    Friend WithEvents lblfotosocio As System.Windows.Forms.Label
    Friend WithEvents pEliminar As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblmotivo As System.Windows.Forms.Label
    Friend WithEvents cmbMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitulopEliminar As System.Windows.Forms.Label
    Friend WithEvents lblUID As System.Windows.Forms.Label
    Friend WithEvents txtUID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID1 As System.Windows.Forms.TextBox

End Class
