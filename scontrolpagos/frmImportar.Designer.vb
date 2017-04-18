<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportar
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
        Me.btnImportarSocios = New System.Windows.Forms.Button()
        Me.btnImportarPagos = New System.Windows.Forms.Button()
        Me.btnImportarConfiguracion = New System.Windows.Forms.Button()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.btnImportarSocios)
        Me.pPrincipal.Controls.Add(Me.btnImportarPagos)
        Me.pPrincipal.Controls.Add(Me.btnImportarConfiguracion)
        Me.pPrincipal.Location = New System.Drawing.Point(7, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(770, 115)
        Me.pPrincipal.TabIndex = 0
        '
        'btnImportarSocios
        '
        Me.btnImportarSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarSocios.Location = New System.Drawing.Point(556, 29)
        Me.btnImportarSocios.Name = "btnImportarSocios"
        Me.btnImportarSocios.Size = New System.Drawing.Size(161, 55)
        Me.btnImportarSocios.TabIndex = 0
        Me.btnImportarSocios.Text = "Socios"
        Me.btnImportarSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarSocios.UseVisualStyleBackColor = True
        '
        'btnImportarPagos
        '
        Me.btnImportarPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarPagos.Location = New System.Drawing.Point(304, 3)
        Me.btnImportarPagos.Name = "btnImportarPagos"
        Me.btnImportarPagos.Size = New System.Drawing.Size(161, 55)
        Me.btnImportarPagos.TabIndex = 0
        Me.btnImportarPagos.Text = "Pagos"
        Me.btnImportarPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarPagos.UseVisualStyleBackColor = True
        Me.btnImportarPagos.Visible = False
        '
        'btnImportarConfiguracion
        '
        Me.btnImportarConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportarConfiguracion.Location = New System.Drawing.Point(71, 29)
        Me.btnImportarConfiguracion.Name = "btnImportarConfiguracion"
        Me.btnImportarConfiguracion.Size = New System.Drawing.Size(161, 55)
        Me.btnImportarConfiguracion.TabIndex = 0
        Me.btnImportarConfiguracion.Text = "Configuracion"
        Me.btnImportarConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarConfiguracion.UseVisualStyleBackColor = True
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
        Me.lblTitulo.Size = New System.Drawing.Size(334, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Importar Información"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmImportar
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
        Me.Name = "frmImportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Información"
        Me.pPrincipal.ResumeLayout(False)
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnImportarConfiguracion As System.Windows.Forms.Button
    Friend WithEvents btnImportarSocios As System.Windows.Forms.Button
    Friend WithEvents btnImportarPagos As System.Windows.Forms.Button

End Class
