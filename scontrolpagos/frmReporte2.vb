Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte2

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sreporte As String

    Private Sub frmReporte2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.reportes

        btnVerReporte.Image = My.Resources.reporte
    End Sub

    Private Sub frmReporte2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()        
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        com.Connection = con
        com.CommandText = "SELECT * FROM sociosmorosos where pag_fecha <= '" & String.Format("{0:yyyy/MM/dd}", Now.Date.AddMonths(-3)) & "' or pag_fecha is null"
        sreporte = Application.StartupPath & "\reportes\rptPagosAtrasados.rpt"

        'carga los datos
        Try
            dstemp = New DataSet
            da.SelectCommand = com
            da.Fill(dstemp)
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar los datos del reporte " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If dstemp.Tables(0).Rows.Count > 0 Then
            'carga el reporte
            Dim rpt As New ReportDocument
            Try
                rpt.Load(sreporte)
                rpt.SetDataSource(dstemp.Tables(0))

                CrystalReportViewer1.ReportSource = rpt
            Catch x As Exception
                MessageBox.Show("Error al cargar el reporte " & x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No existen datos para el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class