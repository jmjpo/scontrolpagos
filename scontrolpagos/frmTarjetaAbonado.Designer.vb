<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarjetaAbonado
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
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.dtFechaFinVigencia = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaActivacion = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicioVigencia = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtUID4 = New System.Windows.Forms.TextBox()
        Me.txtUID3 = New System.Windows.Forms.TextBox()
        Me.txtUID2 = New System.Windows.Forms.TextBox()
        Me.txtUID1 = New System.Windows.Forms.TextBox()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.lblFechaActivacion = New System.Windows.Forms.Label()
        Me.lblFechaInicioVigencia = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDatoCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblFechaFinVigencia = New System.Windows.Forms.Label()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.pAgregar = New System.Windows.Forms.Panel()
        Me.lblTitulopAgregar = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtFechaIngresoAgregar = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblFechaIngresoAgregar = New System.Windows.Forms.Label()
        Me.lblObservacionesAgregar = New System.Windows.Forms.Label()
        Me.txtObservacionAgregar = New System.Windows.Forms.TextBox()
        Me.AdvancedDatePicker1 = New DatePicker.advancedDatePicker()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pDatos.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pAgregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.AdvancedDatePicker1)
        Me.pPrincipal.Controls.Add(Me.cmbEstado)
        Me.pPrincipal.Controls.Add(Me.dtFechaFinVigencia)
        Me.pPrincipal.Controls.Add(Me.dtFechaActivacion)
        Me.pPrincipal.Controls.Add(Me.dtFechaInicioVigencia)
        Me.pPrincipal.Controls.Add(Me.dtFechaIngreso)
        Me.pPrincipal.Controls.Add(Me.txtUID4)
        Me.pPrincipal.Controls.Add(Me.txtUID3)
        Me.pPrincipal.Controls.Add(Me.txtUID2)
        Me.pPrincipal.Controls.Add(Me.txtUID1)
        Me.pPrincipal.Controls.Add(Me.lblUID)
        Me.pPrincipal.Controls.Add(Me.lblEstado)
        Me.pPrincipal.Controls.Add(Me.lblObservaciones)
        Me.pPrincipal.Controls.Add(Me.txtObservaciones)
        Me.pPrincipal.Controls.Add(Me.txtTipo)
        Me.pPrincipal.Controls.Add(Me.lblTipo)
        Me.pPrincipal.Controls.Add(Me.lblFechaIngreso)
        Me.pPrincipal.Controls.Add(Me.lblFechaActivacion)
        Me.pPrincipal.Controls.Add(Me.lblFechaInicioVigencia)
        Me.pPrincipal.Controls.Add(Me.lblCodigo)
        Me.pPrincipal.Controls.Add(Me.lblDatoCodigo)
        Me.pPrincipal.Controls.Add(Me.lblNombre)
        Me.pPrincipal.Controls.Add(Me.txtNombre)
        Me.pPrincipal.Controls.Add(Me.txtNumero)
        Me.pPrincipal.Controls.Add(Me.lblNumero)
        Me.pPrincipal.Controls.Add(Me.lblFechaFinVigencia)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(966, 283)
        Me.pPrincipal.TabIndex = 0
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(555, 163)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(172, 28)
        Me.cmbEstado.TabIndex = 31
        '
        'dtFechaFinVigencia
        '
        Me.dtFechaFinVigencia.CustomFormat = " dd/MM/yyyy hh:mm"
        Me.dtFechaFinVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaFinVigencia.Location = New System.Drawing.Point(555, 121)
        Me.dtFechaFinVigencia.Name = "dtFechaFinVigencia"
        Me.dtFechaFinVigencia.Size = New System.Drawing.Size(172, 26)
        Me.dtFechaFinVigencia.TabIndex = 30
        '
        'dtFechaActivacion
        '
        Me.dtFechaActivacion.CustomFormat = " dd/MM/yyyy hh:mm"
        Me.dtFechaActivacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaActivacion.Location = New System.Drawing.Point(555, 85)
        Me.dtFechaActivacion.Name = "dtFechaActivacion"
        Me.dtFechaActivacion.Size = New System.Drawing.Size(172, 26)
        Me.dtFechaActivacion.TabIndex = 30
        '
        'dtFechaInicioVigencia
        '
        Me.dtFechaInicioVigencia.CustomFormat = " dd/MM/yyyy hh:mm"
        Me.dtFechaInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicioVigencia.Location = New System.Drawing.Point(173, 126)
        Me.dtFechaInicioVigencia.Name = "dtFechaInicioVigencia"
        Me.dtFechaInicioVigencia.Size = New System.Drawing.Size(172, 26)
        Me.dtFechaInicioVigencia.TabIndex = 30
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.CustomFormat = " dd/MM/yyyy hh:mm"
        Me.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaIngreso.Location = New System.Drawing.Point(173, 85)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(172, 26)
        Me.dtFechaIngreso.TabIndex = 30
        '
        'txtUID4
        '
        Me.txtUID4.Location = New System.Drawing.Point(669, 6)
        Me.txtUID4.Name = "txtUID4"
        Me.txtUID4.Size = New System.Drawing.Size(35, 26)
        Me.txtUID4.TabIndex = 29
        Me.txtUID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID3
        '
        Me.txtUID3.Location = New System.Drawing.Point(630, 6)
        Me.txtUID3.Name = "txtUID3"
        Me.txtUID3.Size = New System.Drawing.Size(35, 26)
        Me.txtUID3.TabIndex = 29
        Me.txtUID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID2
        '
        Me.txtUID2.Location = New System.Drawing.Point(591, 6)
        Me.txtUID2.Name = "txtUID2"
        Me.txtUID2.Size = New System.Drawing.Size(35, 26)
        Me.txtUID2.TabIndex = 29
        Me.txtUID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUID1
        '
        Me.txtUID1.Location = New System.Drawing.Point(552, 6)
        Me.txtUID1.Name = "txtUID1"
        Me.txtUID1.Size = New System.Drawing.Size(35, 26)
        Me.txtUID1.TabIndex = 29
        Me.txtUID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(398, 6)
        Me.lblUID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(42, 20)
        Me.lblUID.TabIndex = 28
        Me.lblUID.Text = "UID:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(398, 165)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 25
        Me.lblEstado.Text = "Estado:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 166)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(114, 20)
        Me.lblObservaciones.TabIndex = 19
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(173, 159)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(148, 26)
        Me.txtObservaciones.TabIndex = 6
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(173, 199)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTipo.Multiline = True
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(237, 69)
        Me.txtTipo.TabIndex = 8
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(13, 206)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(43, 20)
        Me.lblTipo.TabIndex = 20
        Me.lblTipo.Text = "Tipo:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(13, 86)
        Me.lblFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(116, 20)
        Me.lblFechaIngreso.TabIndex = 13
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblFechaActivacion
        '
        Me.lblFechaActivacion.AutoSize = True
        Me.lblFechaActivacion.Location = New System.Drawing.Point(398, 83)
        Me.lblFechaActivacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaActivacion.Name = "lblFechaActivacion"
        Me.lblFechaActivacion.Size = New System.Drawing.Size(134, 20)
        Me.lblFechaActivacion.TabIndex = 14
        Me.lblFechaActivacion.Text = "Fecha Activación:"
        '
        'lblFechaInicioVigencia
        '
        Me.lblFechaInicioVigencia.AutoSize = True
        Me.lblFechaInicioVigencia.Location = New System.Drawing.Point(13, 126)
        Me.lblFechaInicioVigencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaInicioVigencia.Name = "lblFechaInicioVigencia"
        Me.lblFechaInicioVigencia.Size = New System.Drawing.Size(164, 20)
        Me.lblFechaInicioVigencia.TabIndex = 15
        Me.lblFechaInicioVigencia.Text = "Fecha Inicio Vigencia:"
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
        Me.lblDatoCodigo.Location = New System.Drawing.Point(172, 6)
        Me.lblDatoCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatoCodigo.MinimumSize = New System.Drawing.Size(149, 2)
        Me.lblDatoCodigo.Name = "lblDatoCodigo"
        Me.lblDatoCodigo.Size = New System.Drawing.Size(149, 22)
        Me.lblDatoCodigo.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 46)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 42)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 26)
        Me.txtNombre.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(555, 40)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(148, 26)
        Me.txtNumero.TabIndex = 2
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(398, 42)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(69, 20)
        Me.lblNumero.TabIndex = 7
        Me.lblNumero.Text = "Numero:"
        '
        'lblFechaFinVigencia
        '
        Me.lblFechaFinVigencia.AutoSize = True
        Me.lblFechaFinVigencia.Location = New System.Drawing.Point(398, 124)
        Me.lblFechaFinVigencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFinVigencia.Name = "lblFechaFinVigencia"
        Me.lblFechaFinVigencia.Size = New System.Drawing.Size(149, 20)
        Me.lblFechaFinVigencia.TabIndex = 7
        Me.lblFechaFinVigencia.Text = "Fecha Fin Vigencia:"
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(6, 9)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(966, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(631, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Mantenimiento de Tarjetas de Abonados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnListar)
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnActivar)
        Me.pnlBotones.Controls.Add(Me.btnAgregar)
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
        'btnActivar
        '
        Me.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActivar.Location = New System.Drawing.Point(345, 6)
        Me.btnActivar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(112, 35)
        Me.btnActivar.TabIndex = 1
        Me.btnActivar.Text = "A&ctivar"
        Me.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(95, 6)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 35)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        'pAgregar
        '
        Me.pAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pAgregar.Controls.Add(Me.lblTitulopAgregar)
        Me.pAgregar.Controls.Add(Me.lblCantidad)
        Me.pAgregar.Controls.Add(Me.btnCancelar)
        Me.pAgregar.Controls.Add(Me.btnAceptar)
        Me.pAgregar.Controls.Add(Me.dtFechaIngresoAgregar)
        Me.pAgregar.Controls.Add(Me.txtCantidad)
        Me.pAgregar.Controls.Add(Me.lblFechaIngresoAgregar)
        Me.pAgregar.Controls.Add(Me.lblObservacionesAgregar)
        Me.pAgregar.Controls.Add(Me.txtObservacionAgregar)
        Me.pAgregar.Location = New System.Drawing.Point(289, 190)
        Me.pAgregar.Name = "pAgregar"
        Me.pAgregar.Size = New System.Drawing.Size(400, 288)
        Me.pAgregar.TabIndex = 29
        Me.pAgregar.Visible = False
        '
        'lblTitulopAgregar
        '
        Me.lblTitulopAgregar.AutoSize = True
        Me.lblTitulopAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulopAgregar.Location = New System.Drawing.Point(39, 11)
        Me.lblTitulopAgregar.Name = "lblTitulopAgregar"
        Me.lblTitulopAgregar.Size = New System.Drawing.Size(321, 25)
        Me.lblTitulopAgregar.TabIndex = 2
        Me.lblTitulopAgregar.Text = "Agregar Tarjetas de Abonado"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(3, 64)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(137, 20)
        Me.lblCantidad.TabIndex = 2
        Me.lblCantidad.Text = "Cantidad  a Crear:"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(227, 244)
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
        Me.btnAceptar.Location = New System.Drawing.Point(69, 244)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtFechaIngresoAgregar
        '
        Me.dtFechaIngresoAgregar.CustomFormat = " dd/MM/yyyy hh:mm"
        Me.dtFechaIngresoAgregar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaIngresoAgregar.Location = New System.Drawing.Point(211, 106)
        Me.dtFechaIngresoAgregar.Name = "dtFechaIngresoAgregar"
        Me.dtFechaIngresoAgregar.Size = New System.Drawing.Size(172, 26)
        Me.dtFechaIngresoAgregar.TabIndex = 30
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(211, 61)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(172, 26)
        Me.txtCantidad.TabIndex = 2
        '
        'lblFechaIngresoAgregar
        '
        Me.lblFechaIngresoAgregar.AutoSize = True
        Me.lblFechaIngresoAgregar.Location = New System.Drawing.Point(3, 111)
        Me.lblFechaIngresoAgregar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIngresoAgregar.Name = "lblFechaIngresoAgregar"
        Me.lblFechaIngresoAgregar.Size = New System.Drawing.Size(116, 20)
        Me.lblFechaIngresoAgregar.TabIndex = 13
        Me.lblFechaIngresoAgregar.Text = "Fecha Ingreso:"
        '
        'lblObservacionesAgregar
        '
        Me.lblObservacionesAgregar.AutoSize = True
        Me.lblObservacionesAgregar.Location = New System.Drawing.Point(3, 161)
        Me.lblObservacionesAgregar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservacionesAgregar.Name = "lblObservacionesAgregar"
        Me.lblObservacionesAgregar.Size = New System.Drawing.Size(114, 20)
        Me.lblObservacionesAgregar.TabIndex = 19
        Me.lblObservacionesAgregar.Text = "Observaciones"
        '
        'txtObservacionAgregar
        '
        Me.txtObservacionAgregar.Location = New System.Drawing.Point(146, 158)
        Me.txtObservacionAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtObservacionAgregar.Multiline = True
        Me.txtObservacionAgregar.Name = "txtObservacionAgregar"
        Me.txtObservacionAgregar.Size = New System.Drawing.Size(237, 69)
        Me.txtObservacionAgregar.TabIndex = 6
        '
        'AdvancedDatePicker1
        '
        Me.AdvancedDatePicker1.HeaderColor = System.Drawing.Color.Empty
        Me.AdvancedDatePicker1.Location = New System.Drawing.Point(596, 11)
        Me.AdvancedDatePicker1.Name = "AdvancedDatePicker1"
        Me.AdvancedDatePicker1.Size = New System.Drawing.Size(200, 26)
        Me.AdvancedDatePicker1.TabIndex = 32
        '
        'frmTarjetaAbonado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 668)
        Me.Controls.Add(Me.pAgregar)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTarjetaAbonado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarjeta Abonados"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pDatos.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pAgregar.ResumeLayout(False)
        Me.pAgregar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinVigencia As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents dgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblFechaActivacion As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicioVigencia As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnActivar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblUID As System.Windows.Forms.Label
    Friend WithEvents txtUID4 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID3 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUID1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDatoCodigo As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaActivacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicioVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents pAgregar As System.Windows.Forms.Panel
    Friend WithEvents lblTitulopAgregar As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dtFechaIngresoAgregar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaIngresoAgregar As System.Windows.Forms.Label
    Friend WithEvents lblObservacionesAgregar As System.Windows.Forms.Label
    Friend WithEvents txtObservacionAgregar As System.Windows.Forms.TextBox
    Friend WithEvents AdvancedDatePicker1 As DatePicker.advancedDatePicker

End Class
