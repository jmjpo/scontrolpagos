Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte5

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sreporte As String

    Private Sub frmReporte5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
    End Sub

    Private Sub frmReporte5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.reportes

        btnVerReporte.Image = My.Resources.reporte

        cmbMes.Items.Add(New libforms.cmbKeyPair("Enero", "01"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Febrero", "02"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Marzo", "03"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Abril", "04"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Mayo", "05"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Junio", "06"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Julio", "07"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Agosto", "08"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Septiembre", "09"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Octubre", "10"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Noviembre", "11"))
        cmbMes.Items.Add(New libforms.cmbKeyPair("Diciembre", "12"))
        cmbMes.SelectedIndex = 0
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        com.Connection = con

        com.CommandText = "SELECT soc_codigo_armado codigo, tds_nombre tipo_socio, per_nombre_completo nombre_completo, per_fecha_nacimiento fecha_nacimiento " & _
                          "FROM Soc_soc_socios " & _
                          "JOIN grl_per_personas ON per_codigo = soc_codper " & _
                          "JOIN soc_tds_tipos_de_socios ON soc_codtds = tds_codigo " & _
                          "WHERE soc_estado <> 'E' " & _
                          "AND month(per_fecha_nacimiento) = '" & CType(cmbMes.SelectedItem, libforms.cmbKeyPair).Valor & "'"

        sreporte = Application.StartupPath & "\reportes\rptSociosMes.rpt"

        'carga los datos
        Try
            dstemp.Clear()
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