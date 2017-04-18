Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte3

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sreporte As String

    Private Sub frmReporte3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
    End Sub

    Private Sub frmReporte3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.reportes

        btnVerReporte.Image = My.Resources.reporte

        For i = 5 To 0 Step -1
            cmbaño.Items.Add(Now.Year + 2 - i)
        Next

        cmbaño.SelectedIndex = 0
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        com.Connection = con
        com.CommandText = "SELECT * FROM controlpagos WHERE anio_pago = " & cmbaño.SelectedItem
        sreporte = Application.StartupPath & "\reportes\rptPagosSocios.rpt"

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