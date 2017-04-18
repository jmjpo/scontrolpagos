Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte1

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sreporte As String

    Private Sub frmReporte1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.reportes

        btnVerReporte.Image = My.Resources.reporte

        dtfechaini.Value = Now.Date
        dtfechafin.Value = Now.Date
    End Sub

    Private Sub frmReporte1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        com.Connection = con
        com.CommandText = "SELECT * FROM comisionxcobrador WHERE fecha_recibo BETWEEN '" & String.Format("{0:yyyy-MM-dd}", dtfechaini.Value) & "' AND '" & String.Format("{0:yyyy-MM-dd}", dtfechafin.Value) & "'"
        sreporte = Application.StartupPath & "\reportes\rptComisionPorCobrador.rpt"

        'carga los datos
        Try
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