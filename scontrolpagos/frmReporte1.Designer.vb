<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.lblfechafin = New System.Windows.Forms.Label()
        Me.btnVerReporte = New System.Windows.Forms.Button()
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.lblfechaini = New System.Windows.Forms.Label()
        Me.dtfechaini = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1060, 614)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(16, 16)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(130, 20)
        Me.lblFiltro.TabIndex = 12
        Me.lblFiltro.Text = "Filtro a Aplicar:"
        '
        'lblfechafin
        '
        Me.lblfechafin.AutoSize = True
        Me.lblfechafin.Location = New System.Drawing.Point(452, 16)
        Me.lblfechafin.Name = "lblfechafin"
        Me.lblfechafin.Size = New System.Drawing.Size(96, 20)
        Me.lblfechafin.TabIndex = 11
        Me.lblfechafin.Text = "Fecha Final:"
        '
        'btnVerReporte
        '
        Me.btnVerReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerReporte.Location = New System.Drawing.Point(722, 9)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(145, 35)
        Me.btnVerReporte.TabIndex = 9
        Me.btnVerReporte.Text = "Ver Reporte"
        Me.btnVerReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'dtfechafin
        '
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechafin.Location = New System.Drawing.Point(554, 16)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.Size = New System.Drawing.Size(121, 26)
        Me.dtfechafin.TabIndex = 13
        '
        'lblfechaini
        '
        Me.lblfechaini.AutoSize = True
        Me.lblfechaini.Location = New System.Drawing.Point(183, 16)
        Me.lblfechaini.Name = "lblfechaini"
        Me.lblfechaini.Size = New System.Drawing.Size(102, 20)
        Me.lblfechaini.TabIndex = 11
        Me.lblfechaini.Text = "Fecha Inicial:"
        '
        'dtfechaini
        '
        Me.dtfechaini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaini.Location = New System.Drawing.Point(287, 16)
        Me.dtfechaini.Name = "dtfechaini"
        Me.dtfechaini.Size = New System.Drawing.Size(111, 26)
        Me.dtfechaini.TabIndex = 13
        '
        'frmReporte1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 668)
        Me.Controls.Add(Me.dtfechaini)
        Me.Controls.Add(Me.dtfechafin)
        Me.Controls.Add(Me.lblfechaini)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblfechafin)
        Me.Controls.Add(Me.btnVerReporte)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReporte1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Comision por Cobrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents lblfechafin As System.Windows.Forms.Label
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfechaini As System.Windows.Forms.Label
    Friend WithEvents dtfechaini As System.Windows.Forms.DateTimePicker
End Class
