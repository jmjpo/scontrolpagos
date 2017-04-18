<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarpagos
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
        Me.lblNombreSocio = New System.Windows.Forms.Label()
        Me.lblCodigoSocio = New System.Windows.Forms.Label()
        Me.lblNoRecibo = New System.Windows.Forms.Label()
        Me.txtNombreSocio = New System.Windows.Forms.TextBox()
        Me.txtNoRecibo = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbSocio = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgdatos = New System.Windows.Forms.DataGridView()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pEliminar = New System.Windows.Forms.Panel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblmotivo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pPrincipal.SuspendLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitulo.SuspendLayout()
        Me.pEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.lblNombreSocio)
        Me.pPrincipal.Controls.Add(Me.lblCodigoSocio)
        Me.pPrincipal.Controls.Add(Me.lblNoRecibo)
        Me.pPrincipal.Controls.Add(Me.txtNombreSocio)
        Me.pPrincipal.Controls.Add(Me.txtNoRecibo)
        Me.pPrincipal.Controls.Add(Me.btnLimpiar)
        Me.pPrincipal.Controls.Add(Me.cmbSocio)
        Me.pPrincipal.Controls.Add(Me.btnBuscar)
        Me.pPrincipal.Controls.Add(Me.dgdatos)
        Me.pPrincipal.Location = New System.Drawing.Point(5, 57)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(971, 530)
        Me.pPrincipal.TabIndex = 0
        '
        'lblNombreSocio
        '
        Me.lblNombreSocio.AutoSize = True
        Me.lblNombreSocio.Location = New System.Drawing.Point(17, 89)
        Me.lblNombreSocio.Name = "lblNombreSocio"
        Me.lblNombreSocio.Size = New System.Drawing.Size(113, 20)
        Me.lblNombreSocio.TabIndex = 6
        Me.lblNombreSocio.Text = "Nombre Socio:"
        '
        'lblCodigoSocio
        '
        Me.lblCodigoSocio.AutoSize = True
        Me.lblCodigoSocio.Location = New System.Drawing.Point(17, 53)
        Me.lblCodigoSocio.Name = "lblCodigoSocio"
        Me.lblCodigoSocio.Size = New System.Drawing.Size(107, 20)
        Me.lblCodigoSocio.TabIndex = 6
        Me.lblCodigoSocio.Text = "Codigo Socio:"
        '
        'lblNoRecibo
        '
        Me.lblNoRecibo.AutoSize = True
        Me.lblNoRecibo.Location = New System.Drawing.Point(17, 17)
        Me.lblNoRecibo.Name = "lblNoRecibo"
        Me.lblNoRecibo.Size = New System.Drawing.Size(76, 20)
        Me.lblNoRecibo.TabIndex = 6
        Me.lblNoRecibo.Text = "# Recibo:"
        '
        'txtNombreSocio
        '
        Me.txtNombreSocio.Location = New System.Drawing.Point(149, 90)
        Me.txtNombreSocio.Name = "txtNombreSocio"
        Me.txtNombreSocio.Size = New System.Drawing.Size(276, 26)
        Me.txtNombreSocio.TabIndex = 5
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.Location = New System.Drawing.Point(149, 14)
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.Size = New System.Drawing.Size(276, 26)
        Me.txtNoRecibo.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(806, 81)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(157, 35)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar Filtro"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbSocio
        '
        Me.cmbSocio.FormattingEnabled = True
        Me.cmbSocio.Location = New System.Drawing.Point(149, 51)
        Me.cmbSocio.Name = "cmbSocio"
        Me.cmbSocio.Size = New System.Drawing.Size(276, 28)
        Me.cmbSocio.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(806, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(157, 35)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgdatos
        '
        Me.dgdatos.AllowUserToAddRows = False
        Me.dgdatos.AllowUserToDeleteRows = False
        Me.dgdatos.AllowUserToResizeColumns = False
        Me.dgdatos.AllowUserToResizeRows = False
        Me.dgdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdatos.Location = New System.Drawing.Point(3, 125)
        Me.dgdatos.Name = "dgdatos"
        Me.dgdatos.RowHeadersVisible = False
        Me.dgdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdatos.Size = New System.Drawing.Size(960, 398)
        Me.dgdatos.TabIndex = 0
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(4, 8)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(972, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(362, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(247, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Eliminar Pagos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pEliminar
        '
        Me.pEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pEliminar.Controls.Add(Me.txtObservacion)
        Me.pEliminar.Controls.Add(Me.lblmotivo)
        Me.pEliminar.Controls.Add(Me.btnCancelar)
        Me.pEliminar.Controls.Add(Me.btnAceptar)
        Me.pEliminar.Location = New System.Drawing.Point(253, 192)
        Me.pEliminar.Name = "pEliminar"
        Me.pEliminar.Size = New System.Drawing.Size(475, 210)
        Me.pEliminar.TabIndex = 28
        Me.pEliminar.Visible = False
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(13, 40)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(447, 112)
        Me.txtObservacion.TabIndex = 3
        '
        'lblmotivo
        '
        Me.lblmotivo.Location = New System.Drawing.Point(11, 12)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(349, 25)
        Me.lblmotivo.TabIndex = 2
        Me.lblmotivo.Text = "Indique una Observacion para eliminar el pago:"
        '
        'btnCancelar
        '
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(264, 157)
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
        Me.btnAceptar.Location = New System.Drawing.Point(106, 157)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmEliminarpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 594)
        Me.Controls.Add(Me.pEliminar)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEliminarpagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        CType(Me.dgdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pEliminar.ResumeLayout(False)
        Me.pEliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgdatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmbSocio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNombreSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreSocio As System.Windows.Forms.Label
    Friend WithEvents lblCodigoSocio As System.Windows.Forms.Label
    Friend WithEvents lblNoRecibo As System.Windows.Forms.Label
    Friend WithEvents pEliminar As System.Windows.Forms.Panel
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblmotivo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

End Class
