Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReporte4

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sreporte As String

    Private Sub frmReporte4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
    End Sub

    Private Sub frmReporte4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.reportes

        btnVerReporte.Image = My.Resources.reporte

        Dim query = From r In dbContext.Soc_tds_tipos_de_socios _
                     Select New With {Key .Codigo = r.Tds_codigo, Key .Nombre = r.Tds_nombre}

        cmbTipoSocio.Items.Add(New libforms.cmbKeyPair("Todos", "Todos"))
        For Each elemento In query
            cmbTipoSocio.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next
        cmbTipoSocio.SelectedIndex = 0
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        com.Connection = con
        If cmbTipoSocio.SelectedIndex = "0" Then
            com.CommandText = "SELECT soc_codigo_armado Codigo, tds_nombre Tipo_socio, per_nombre_completo Nombre_completo, per_dpi DPI, " & _
                              "per_cedula Cedula " & _
                              "FROM Grl_per_personas " & _
                              "JOIN soc_soc_socios ON soc_codper = per_codigo " & _
                              "JOIN soc_tds_tipos_de_socios ON soc_codtds = tds_codigo " & _
                              "WHERE soc_estado <> 'E'"
        Else
            com.CommandText = "SELECT soc_codigo_armado Codigo, tds_nombre Tipo_socio, per_nombre_completo Nombre_completo, per_dpi DPI, " & _
                              "per_cedula Cedula " & _
                              "FROM Grl_per_personas " & _
                              "JOIN soc_soc_socios ON soc_codper = per_codigo " & _
                              "JOIN soc_tds_tipos_de_socios ON soc_codtds = tds_codigo " & _
                              "WHERE soc_estado <> 'E' AND tds_codigo = " & CType(cmbTipoSocio.SelectedItem, libforms.cmbKeyPair).Valor
        End If

        sreporte = Application.StartupPath & "\reportes\rptSocios.rpt"

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