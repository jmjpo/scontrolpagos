<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpagos
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
        Me.lblTipoSocio = New System.Windows.Forms.Label()
        Me.lblNombreSocio = New System.Windows.Forms.Label()
        Me.LblMensualidad = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblfechaRecibo = New System.Windows.Forms.Label()
        Me.lblfechapago = New System.Windows.Forms.Label()
        Me.dtfecharecibo = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.cmbcobrador = New System.Windows.Forms.ComboBox()
        Me.cmbsocio = New System.Windows.Forms.ComboBox()
        Me.lblNoRecibo = New System.Windows.Forms.Label()
        Me.txtNoRecibo = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblCobrador = New System.Windows.Forms.Label()
        Me.lblSocio = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.lblTipoSocio)
        Me.pPrincipal.Controls.Add(Me.lblNombreSocio)
        Me.pPrincipal.Controls.Add(Me.LblMensualidad)
        Me.pPrincipal.Controls.Add(Me.lblObservaciones)
        Me.pPrincipal.Controls.Add(Me.lblfechaRecibo)
        Me.pPrincipal.Controls.Add(Me.lblfechapago)
        Me.pPrincipal.Controls.Add(Me.dtfecharecibo)
        Me.pPrincipal.Controls.Add(Me.dtFechaPago)
        Me.pPrincipal.Controls.Add(Me.cmbcobrador)
        Me.pPrincipal.Controls.Add(Me.cmbsocio)
        Me.pPrincipal.Controls.Add(Me.lblNoRecibo)
        Me.pPrincipal.Controls.Add(Me.txtNoRecibo)
        Me.pPrincipal.Controls.Add(Me.txtObservaciones)
        Me.pPrincipal.Controls.Add(Me.txtMonto)
        Me.pPrincipal.Controls.Add(Me.lblCobrador)
        Me.pPrincipal.Controls.Add(Me.lblSocio)
        Me.pPrincipal.Controls.Add(Me.lblMonto)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(770, 294)
        Me.pPrincipal.TabIndex = 0
        '
        'lblTipoSocio
        '
        Me.lblTipoSocio.AutoSize = True
        Me.lblTipoSocio.Location = New System.Drawing.Point(382, 91)
        Me.lblTipoSocio.Name = "lblTipoSocio"
        Me.lblTipoSocio.Size = New System.Drawing.Size(94, 20)
        Me.lblTipoSocio.TabIndex = 14
        Me.lblTipoSocio.Text = "lblTipoSocio"
        '
        'lblNombreSocio
        '
        Me.lblNombreSocio.AutoSize = True
        Me.lblNombreSocio.Location = New System.Drawing.Point(382, 61)
        Me.lblNombreSocio.Name = "lblNombreSocio"
        Me.lblNombreSocio.Size = New System.Drawing.Size(120, 20)
        Me.lblNombreSocio.TabIndex = 14
        Me.lblNombreSocio.Text = "lblNombreSocio"
        '
        'LblMensualidad
        '
        Me.LblMensualidad.AutoSize = True
        Me.LblMensualidad.Location = New System.Drawing.Point(382, 116)
        Me.LblMensualidad.Name = "LblMensualidad"
        Me.LblMensualidad.Size = New System.Drawing.Size(114, 20)
        Me.LblMensualidad.TabIndex = 14
        Me.LblMensualidad.Text = "lblMensualidad"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 203)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(118, 20)
        Me.lblObservaciones.TabIndex = 14
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblfechaRecibo
        '
        Me.lblfechaRecibo.AutoSize = True
        Me.lblfechaRecibo.Location = New System.Drawing.Point(382, 19)
        Me.lblfechaRecibo.Name = "lblfechaRecibo"
        Me.lblfechaRecibo.Size = New System.Drawing.Size(112, 20)
        Me.lblfechaRecibo.TabIndex = 14
        Me.lblfechaRecibo.Text = "Fecha Recibo:"
        '
        'lblfechapago
        '
        Me.lblfechapago.AutoSize = True
        Me.lblfechapago.Location = New System.Drawing.Point(378, 163)
        Me.lblfechapago.Name = "lblfechapago"
        Me.lblfechapago.Size = New System.Drawing.Size(185, 20)
        Me.lblfechapago.TabIndex = 14
        Me.lblfechapago.Text = "Pago Correspondiente a:"
        '
        'dtfecharecibo
        '
        Me.dtfecharecibo.CustomFormat = "dd/MM/yyyy"
        Me.dtfecharecibo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecharecibo.Location = New System.Drawing.Point(569, 16)
        Me.dtfecharecibo.Name = "dtfecharecibo"
        Me.dtfecharecibo.Size = New System.Drawing.Size(152, 26)
        Me.dtfecharecibo.TabIndex = 1
        Me.dtfecharecibo.Value = New Date(2014, 4, 30, 0, 0, 0, 0)
        '
        'dtFechaPago
        '
        Me.dtFechaPago.CustomFormat = "MM/yyyy"
        Me.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaPago.Location = New System.Drawing.Point(569, 160)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Size = New System.Drawing.Size(152, 26)
        Me.dtFechaPago.TabIndex = 5
        '
        'cmbcobrador
        '
        Me.cmbcobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcobrador.FormattingEnabled = True
        Me.cmbcobrador.Location = New System.Drawing.Point(150, 108)
        Me.cmbcobrador.Name = "cmbcobrador"
        Me.cmbcobrador.Size = New System.Drawing.Size(180, 28)
        Me.cmbcobrador.TabIndex = 3
        '
        'cmbsocio
        '
        Me.cmbsocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsocio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsocio.FormattingEnabled = True
        Me.cmbsocio.Location = New System.Drawing.Point(150, 61)
        Me.cmbsocio.Name = "cmbsocio"
        Me.cmbsocio.Size = New System.Drawing.Size(184, 28)
        Me.cmbsocio.TabIndex = 2
        '
        'lblNoRecibo
        '
        Me.lblNoRecibo.AutoSize = True
        Me.lblNoRecibo.Location = New System.Drawing.Point(12, 19)
        Me.lblNoRecibo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoRecibo.Name = "lblNoRecibo"
        Me.lblNoRecibo.Size = New System.Drawing.Size(76, 20)
        Me.lblNoRecibo.TabIndex = 3
        Me.lblNoRecibo.Text = "# Recibo:"
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.Location = New System.Drawing.Point(150, 16)
        Me.txtNoRecibo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.Size = New System.Drawing.Size(148, 26)
        Me.txtNoRecibo.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(150, 200)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(571, 78)
        Me.txtObservaciones.TabIndex = 6
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(150, 155)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(148, 26)
        Me.txtMonto.TabIndex = 4
        '
        'lblCobrador
        '
        Me.lblCobrador.AutoSize = True
        Me.lblCobrador.Location = New System.Drawing.Point(12, 112)
        Me.lblCobrador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCobrador.Name = "lblCobrador"
        Me.lblCobrador.Size = New System.Drawing.Size(79, 20)
        Me.lblCobrador.TabIndex = 7
        Me.lblCobrador.Text = "Cobrador:"
        '
        'lblSocio
        '
        Me.lblSocio.AutoSize = True
        Me.lblSocio.Location = New System.Drawing.Point(12, 65)
        Me.lblSocio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSocio.Name = "lblSocio"
        Me.lblSocio.Size = New System.Drawing.Size(107, 20)
        Me.lblSocio.TabIndex = 7
        Me.lblSocio.Text = "Codigo Socio:"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(12, 158)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(58, 20)
        Me.lblMonto.TabIndex = 7
        Me.lblMonto.Text = "Monto:"
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
        Me.lblTitulo.Location = New System.Drawing.Point(243, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(283, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Ingreso de Pagos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBotones
        '
        Me.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Controls.Add(Me.btnNuevo)
        Me.pnlBotones.Location = New System.Drawing.Point(7, 356)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(770, 51)
        Me.pnlBotones.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(491, 7)
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
        Me.btnNuevo.Location = New System.Drawing.Point(165, 7)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 414)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblNoRecibo As System.Windows.Forms.Label
    Friend WithEvents txtNoRecibo As System.Windows.Forms.TextBox
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbcobrador As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsocio As System.Windows.Forms.ComboBox
    Friend WithEvents dtfecharecibo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblMensualidad As System.Windows.Forms.Label
    Friend WithEvents lblfechaRecibo As System.Windows.Forms.Label
    Friend WithEvents lblfechapago As System.Windows.Forms.Label
    Friend WithEvents lblCobrador As System.Windows.Forms.Label
    Friend WithEvents lblSocio As System.Windows.Forms.Label
    Friend WithEvents lblNombreSocio As System.Windows.Forms.Label
    Friend WithEvents lblTipoSocio As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox

End Class
