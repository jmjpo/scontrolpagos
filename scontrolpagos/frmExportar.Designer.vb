<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Me.btnExportarPagos = New System.Windows.Forms.Button()
        Me.btnExportarConfiguracion = New System.Windows.Forms.Button()
        Me.btnExportarSocios = New System.Windows.Forms.Button()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.btnExportarPagos)
        Me.pPrincipal.Controls.Add(Me.btnExportarConfiguracion)
        Me.pPrincipal.Controls.Add(Me.btnExportarSocios)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(770, 115)
        Me.pPrincipal.TabIndex = 0
        '
        'btnExportarPagos
        '
        Me.btnExportarPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPagos.Location = New System.Drawing.Point(304, 3)
        Me.btnExportarPagos.Name = "btnExportarPagos"
        Me.btnExportarPagos.Size = New System.Drawing.Size(161, 55)
        Me.btnExportarPagos.TabIndex = 0
        Me.btnExportarPagos.Text = "Pagos"
        Me.btnExportarPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarPagos.UseVisualStyleBackColor = True
        Me.btnExportarPagos.Visible = False
        '
        'btnExportarConfiguracion
        '
        Me.btnExportarConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarConfiguracion.Location = New System.Drawing.Point(71, 29)
        Me.btnExportarConfiguracion.Name = "btnExportarConfiguracion"
        Me.btnExportarConfiguracion.Size = New System.Drawing.Size(161, 55)
        Me.btnExportarConfiguracion.TabIndex = 0
        Me.btnExportarConfiguracion.Text = "Configuracion"
        Me.btnExportarConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarConfiguracion.UseVisualStyleBackColor = True
        '
        'btnExportarSocios
        '
        Me.btnExportarSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarSocios.Location = New System.Drawing.Point(556, 29)
        Me.btnExportarSocios.Name = "btnExportarSocios"
        Me.btnExportarSocios.Size = New System.Drawing.Size(161, 55)
        Me.btnExportarSocios.TabIndex = 1
        Me.btnExportarSocios.Text = "Socios"
        Me.btnExportarSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarSocios.UseVisualStyleBackColor = True
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
        Me.lblTitulo.Location = New System.Drawing.Point(217, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(335, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Exportar Información"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 181)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Información"
        Me.pPrincipal.ResumeLayout(False)
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnExportarConfiguracion As System.Windows.Forms.Button
    Friend WithEvents btnExportarSocios As System.Windows.Forms.Button
    Friend WithEvents btnExportarPagos As System.Windows.Forms.Button

End Class
