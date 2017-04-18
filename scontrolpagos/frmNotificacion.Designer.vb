<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificacion
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.btnAdjunto = New System.Windows.Forms.Button()
        Me.txtadjunto = New System.Windows.Forms.TextBox()
        Me.lblAdjunto = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.pTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pDatos = New System.Windows.Forms.Panel()
        Me.dgSocios = New System.Windows.Forms.DataGridView()
        Me.pPrincipal.SuspendLayout()
        Me.pTitulo.SuspendLayout()
        Me.pDatos.SuspendLayout()
        CType(Me.dgSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pPrincipal
        '
        Me.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pPrincipal.Controls.Add(Me.btnEnviar)
        Me.pPrincipal.Controls.Add(Me.chktodos)
        Me.pPrincipal.Controls.Add(Me.btnAdjunto)
        Me.pPrincipal.Controls.Add(Me.txtadjunto)
        Me.pPrincipal.Controls.Add(Me.lblAdjunto)
        Me.pPrincipal.Controls.Add(Me.lblMensaje)
        Me.pPrincipal.Controls.Add(Me.txtMensaje)
        Me.pPrincipal.Controls.Add(Me.lblAsunto)
        Me.pPrincipal.Controls.Add(Me.txtAsunto)
        Me.pPrincipal.Location = New System.Drawing.Point(5, 58)
        Me.pPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pPrincipal.Name = "pPrincipal"
        Me.pPrincipal.Size = New System.Drawing.Size(994, 197)
        Me.pPrincipal.TabIndex = 0
        '
        'btnEnviar
        '
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(854, 105)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(128, 35)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "&Enviar"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.Location = New System.Drawing.Point(854, 17)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(133, 24)
        Me.chktodos.TabIndex = 3
        Me.chktodos.Text = "Enviar a Todos"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'btnAdjunto
        '
        Me.btnAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdjunto.Location = New System.Drawing.Point(854, 150)
        Me.btnAdjunto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdjunto.Name = "btnAdjunto"
        Me.btnAdjunto.Size = New System.Drawing.Size(128, 35)
        Me.btnAdjunto.TabIndex = 0
        Me.btnAdjunto.Text = "&Adjunto"
        Me.btnAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdjunto.UseVisualStyleBackColor = True
        '
        'txtadjunto
        '
        Me.txtadjunto.Location = New System.Drawing.Point(140, 162)
        Me.txtadjunto.Name = "txtadjunto"
        Me.txtadjunto.ReadOnly = True
        Me.txtadjunto.Size = New System.Drawing.Size(687, 26)
        Me.txtadjunto.TabIndex = 3
        '
        'lblAdjunto
        '
        Me.lblAdjunto.AutoSize = True
        Me.lblAdjunto.Location = New System.Drawing.Point(10, 165)
        Me.lblAdjunto.Name = "lblAdjunto"
        Me.lblAdjunto.Size = New System.Drawing.Size(124, 20)
        Me.lblAdjunto.TabIndex = 2
        Me.lblAdjunto.Text = "Archivo Adjunto:"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(10, 53)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(73, 20)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Mensaje:"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(140, 50)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(687, 106)
        Me.txtMensaje.TabIndex = 0
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Location = New System.Drawing.Point(10, 21)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(64, 20)
        Me.lblAsunto.TabIndex = 1
        Me.lblAsunto.Text = "Asunto:"
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(140, 18)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(687, 26)
        Me.txtAsunto.TabIndex = 0
        '
        'pTitulo
        '
        Me.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitulo.Controls.Add(Me.lblTitulo)
        Me.pTitulo.Location = New System.Drawing.Point(5, 9)
        Me.pTitulo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTitulo.Name = "pTitulo"
        Me.pTitulo.Size = New System.Drawing.Size(994, 45)
        Me.pTitulo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(319, 3)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(355, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Notificacion de Socios"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pDatos
        '
        Me.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pDatos.Controls.Add(Me.dgSocios)
        Me.pDatos.Location = New System.Drawing.Point(5, 260)
        Me.pDatos.Name = "pDatos"
        Me.pDatos.Size = New System.Drawing.Size(994, 400)
        Me.pDatos.TabIndex = 5
        '
        'dgSocios
        '
        Me.dgSocios.AllowUserToAddRows = False
        Me.dgSocios.AllowUserToDeleteRows = False
        Me.dgSocios.AllowUserToResizeColumns = False
        Me.dgSocios.AllowUserToResizeRows = False
        Me.dgSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSocios.Location = New System.Drawing.Point(3, 5)
        Me.dgSocios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgSocios.MultiSelect = False
        Me.dgSocios.Name = "dgSocios"
        Me.dgSocios.RowHeadersVisible = False
        Me.dgSocios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSocios.Size = New System.Drawing.Size(985, 388)
        Me.dgSocios.TabIndex = 3
        '
        'frmNotificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 668)
        Me.Controls.Add(Me.pDatos)
        Me.Controls.Add(Me.pTitulo)
        Me.Controls.Add(Me.pPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificacion"
        Me.pPrincipal.ResumeLayout(False)
        Me.pPrincipal.PerformLayout()
        Me.pTitulo.ResumeLayout(False)
        Me.pTitulo.PerformLayout()
        Me.pDatos.ResumeLayout(False)
        CType(Me.dgSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDatos As System.Windows.Forms.Panel
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdjunto As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents dgSocios As System.Windows.Forms.DataGridView
    Friend WithEvents txtadjunto As System.Windows.Forms.TextBox
    Friend WithEvents lblAdjunto As System.Windows.Forms.Label

End Class
