Imports System.IO
Imports libforms.libforms
Imports MySql.Data.MySqlClient
Imports Telerik.OpenAccess
Imports System.Text
Imports System.Configuration

Public Class frmExportarTarjeta

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim nombrearchivo As String = AppDomain.CurrentDomain.BaseDirectory & ConfigurationManager.AppSettings("archivotarjeta")

    Private Sub frmExportar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.tarjeta

        btnExportarConfiguracion.Image = My.Resources.exportar_tarjeta
    End Sub

    Private Sub btnExportarConfiguracion_Click(sender As Object, e As EventArgs) Handles btnExportarConfiguracion.Click
        'Obtengo los datos de la base de datos
        com.Connection = con
        'com.CommandText = "SELECT soc_codigo_armado codigo, CONCAT(soc_uid_1, '-', soc_uid_2, '-', soc_uid_3, '-', soc_uid_4) soc_uid " & _
        '                  "FROM soc_soc_socios, pag_pag_pagos " & _
        '                  "WHERE soc_codigo = pag_codsoc " & _
        '                  "AND pag_año = YEAR(CURDATE()) " & _
        '                  "AND pag_mes = MONTH(CURDATE())"
        com.CommandText = "SELECT upper(tds_nombre) tipo_socio, soc_codigo_armado codigo, " & _
                          "CONCAT(soc_uid_1, '-', soc_uid_2, '-', soc_uid_3, '-', soc_uid_4) soc_uid " & _
                          "FROM soc_soc_socios, pag_pag_pagos, soc_tds_tipos_de_socios " & _
                          "WHERE soc_codigo = pag_codsoc " & _
                          "AND soc_codtds = tds_codigo " & _
                          "AND pag_año = YEAR(CURDATE()) " & _
                          "AND pag_mes = MONTH(CURDATE())"
        da.SelectCommand = com


        Try
            da.Fill(dstemp, "TEXTO")
        Catch ex As MySqlException
            MessageBox.Show("Error al exportar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End Try

        If dstemp.Tables.Count > 0 Then
            If dstemp.Tables(0).Rows.Count > 0 Then
                Dim lsttiposocio As List(Of String)
                Dim sb As New StringBuilder()

                'Obtengo el listado de tipos de socio a exportar
                Dim query = (From row In dstemp.Tables(0)
                            Order By row("TIPO_SOCIO") Ascending
                            Select CType(row("TIPO_SOCIO"), String)).Distinct()

                lsttiposocio = query.ToList

                'Exporto los archivos por tipos de socio
                For Each ele As String In lsttiposocio
                    Dim dt As DataTable
                    Dim snombrearchivotmp As String

                    dt = dstemp.Tables(0).Select("TIPO_SOCIO = '" & ele & "'").CopyToDataTable

                    snombrearchivotmp = nombrearchivo & ele & ".txt"

                    'Preparo los datos para el archivo de texto
                    For Each dr As DataRow In dt.Rows
                        sb.Append(dr("CODIGO").ToString)
                        sb.Append(",")
                        sb.AppendLine(dr("SOC_UID").ToString)
                    Next

                    Try
                        'Escribo el archivo de texto
                        If File.Exists(snombrearchivotmp) Then
                            File.Delete(snombrearchivotmp)
                        End If

                        Using archivosalida As New StreamWriter(snombrearchivotmp)
                            archivosalida.Write(sb.ToString())
                        End Using

                        MessageBox.Show("Datos exportados correctamente" & vbCrLf & snombrearchivotmp, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            Else
                MessageBox.Show("Error no existen datos para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class