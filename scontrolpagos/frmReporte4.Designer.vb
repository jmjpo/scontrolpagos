﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte4
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
        Me.btnVerReporte = New System.Windows.Forms.Button()
        Me.cmbTipoSocio = New System.Windows.Forms.ComboBox()
        Me.lblTipoSocio = New System.Windows.Forms.Label()
        Me.lblFiltro = New System.Windows.Forms.Label()
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
        'btnVerReporte
        '
        Me.btnVerReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerReporte.Location = New System.Drawing.Point(532, 9)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(145, 35)
        Me.btnVerReporte.TabIndex = 1
        Me.btnVerReporte.Text = "Ver Reporte"
        Me.btnVerReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'cmbTipoSocio
        '
        Me.cmbTipoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoSocio.FormattingEnabled = True
        Me.cmbTipoSocio.Location = New System.Drawing.Point(298, 13)
        Me.cmbTipoSocio.Name = "cmbTipoSocio"
        Me.cmbTipoSocio.Size = New System.Drawing.Size(206, 28)
        Me.cmbTipoSocio.TabIndex = 2
        '
        'lblTipoSocio
        '
        Me.lblTipoSocio.AutoSize = True
        Me.lblTipoSocio.Location = New System.Drawing.Point(183, 16)
        Me.lblTipoSocio.Name = "lblTipoSocio"
        Me.lblTipoSocio.Size = New System.Drawing.Size(109, 20)
        Me.lblTipoSocio.TabIndex = 3
        Me.lblTipoSocio.Text = "Tipo de Socio:"
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(16, 16)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(130, 20)
        Me.lblFiltro.TabIndex = 4
        Me.lblFiltro.Text = "Filtro a Aplicar:"
        '
        'frmReporte4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 668)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.lblTipoSocio)
        Me.Controls.Add(Me.cmbTipoSocio)
        Me.Controls.Add(Me.btnVerReporte)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReporte4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Socios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents cmbTipoSocio As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoSocio As System.Windows.Forms.Label
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
End Class
