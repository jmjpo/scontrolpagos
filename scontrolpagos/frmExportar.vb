Imports System.IO
Imports libforms.libforms
Imports MySql.Data.MySqlClient
Imports Telerik.OpenAccess
Imports System.Configuration

Public Class frmExportar

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Private Sub frmExportar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.exportar

        btnExportarConfiguracion.Image = My.Resources.configuracion
        btnExportarSocios.Image = My.Resources.sociosB
        btnExportarPagos.Image = My.Resources.pagosB
    End Sub

    Private Sub btnExportarConfiguracion_Click(sender As Object, e As EventArgs) Handles btnExportarConfiguracion.Click
        Dim sarchivoencriptado As String
        Dim sarchivo As String = AppDomain.CurrentDomain.BaseDirectory & ConfigurationManager.AppSettings("archivo")

        Dim dstemp As New DataSet

        If Not Directory.Exists(sarchivo) Then
            Directory.CreateDirectory(sarchivo)
        End If

        sarchivo &= String.Format("{0:dd-MM-yyyy HHmmss}", Now) & "Configuracion"
        sarchivoencriptado = sarchivo & ".dat"
        sarchivo &= ".xml"

        'Obtengo los datos de la base de datos
        com.Connection = con
        com.CommandText = "SELECT opc_codigo, opc_descripcion, opc_titulo, opc_formulario " & _
                          ", opc_usuario_grabacion, opc_fecha_grabacion, opc_usuario_modificacion, opc_fecha_modificacion " & _
                          "FROM SEG_OPC_OPCIONES"
        da.SelectCommand = com

        Try
            da.Fill(dstemp, "SEG_OPC_OPCIONES")

            'JMPEREZ 21-01-16
            'Agregada la logica para exportar la tabla seg_acc_acciones
            com.CommandText = "SELECT acc_codigo, acc_descripcion, acc_usuario_grabacion, " & _
                              "acc_fecha_grabacion, acc_usuario_modificacion, acc_fecha_modificacion " & _
                              "FROM SEG_ACC_ACCIONES"
            da.Fill(dstemp, "SEG_ACC_ACCIONES")

            com.CommandText = "SELECT axo_codopc, axo_codacc " & _
                              ", axo_usuario_grabacion, axo_fecha_grabacion, axo_usuario_modificacion, axo_fecha_modificacion " & _
                              "FROM SEG_AXO_ACCIONES_X_OPCION"
            da.Fill(dstemp, "SEG_AXO_ACCIONES_X_OPCION")

            com.CommandText = "SELECT men_codigo, men_codmen_padre, men_descripcion, men_titulo, men_orden " & _
                              ", men_usuario_grabacion, men_fecha_grabacion, men_usuario_modificacion, men_fecha_modificacion " & _
                              "FROM SEG_MEN_MENUS"
            da.Fill(dstemp, "SEG_MEN_MENUS")

            com.CommandText = "SELECT oxm_codmen, oxm_codopc, oxm_orden " & _
                              ", oxm_usuario_grabacion, oxm_fecha_grabacion, oxm_usuario_modificacion, oxm_fecha_modificacion " & _
                              "FROM SEG_OXM_OPCIONES_X_MENU"
            da.Fill(dstemp, "SEG_OXM_OPCIONES_X_MENU")

            com.CommandText = "SELECT rol_codigo, rol_descripcion " & _
                              ", rol_usuario_grabacion, rol_fecha_grabacion, rol_usuario_modificacion, rol_fecha_modificacion " & _
                              "FROM SEG_ROL_ROLES"
            da.Fill(dstemp, "SEG_ROL_ROLES")

            'JMPEREZ 21-01-16
            'Agregada la logica para exportar la tabla seg_usu_usuarios
            com.CommandText = "SELECT usu_codigo, usu_nombre, usu_usuario, usu_password, usu_estado," & _
                              "usu_usuario_grabacion, usu_fecha_grabacion, usu_usuario_modificacion, usu_fecha_modificacion, " & _
                              "usu_codper " & _
                              "FROM SEG_USU_USUARIOS"
            da.Fill(dstemp, "SEG_USU_USUARIOS")

            com.CommandText = "SELECT uxr_codrol, uxr_codusu " & _
                              ", uxr_usuario_grabacion, uxr_fecha_grabacion, uxr_usuario_modificacion, uxr_fecha_modificacion " & _
                              "FROM SEG_UXR_USUARIOS_X_ROLE"
            da.Fill(dstemp, "SEG_UXR_USUARIOS_X_ROLE")

            com.CommandText = "SELECT aro_codrol, aro_codopc, aro_codaxo " & _
                              ", aro_usuario_grabacion, aro_fecha_grabacion, aro_usuario_modificacion, aro_fecha_modificacion " & _
                              "FROM SEG_ARO_AUTORIZACIONES_ROLE"
            da.Fill(dstemp, "SEG_ARO_AUTORIZACIONES_ROLE")

            'JMPEREZ 21-01-16
            'Elimina el formato de fecha al exportar a xml debido a un error que no se presentaba antes
            QuitarTimezone(dstemp)

            'Escribo el archivo xml a disco
            dstemp.WriteXml(sarchivo)

            'Encripto el archivo xml
            CryptFile("8069", sarchivo, sarchivoencriptado, True)

            'Elimino el archivo xml
            File.Delete(sarchivo)

            MessageBox.Show("Datos de Configuracion exportados correctamente" & vbNewLine & "Archivo exportado: " & sarchivoencriptado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportarSocios_Click(sender As Object, e As EventArgs) Handles btnExportarSocios.Click
        Dim sarchivoencriptado As String
        Dim sarchivo As String = AppDomain.CurrentDomain.BaseDirectory & ConfigurationManager.AppSettings("archivo")

        Dim dstemp As New DataSet

        If Not Directory.Exists(sarchivo) Then
            Directory.CreateDirectory(sarchivo)
        End If

        sarchivo &= String.Format("{0:dd-MM-yyyy HHmmss}", Now) & "Socios"
        sarchivoencriptado = sarchivo & ".dat"
        sarchivo &= ".xml"

        'Obtengo los datos de la base de datos
        com.Connection = con
        com.CommandText = "SELECT per_codigo, per_primer_nombre, per_segundo_nombre, per_primer_apellido, " & _
                          "per_apellido_casada, per_nombre_completo, per_dpi, per_cedula," & _
                          "per_departamento_extendida, per_municipio_extendida, per_direccion_cobro, per_telefonos," & _
                          "per_celulares, per_correo_electronico, per_fecha_nacimiento, per_foto, per_estado " & _
                          ", per_usuario_grabacion, per_fecha_grabacion, per_usuario_modificacion, per_fecha_modificacion " & _
                          "FROM GRL_PER_PERSONAS"
        da.SelectCommand = com

        Try
            da.Fill(dstemp, "GRL_PER_PERSONAS")           

            com.CommandText = "SELECT tds_codigo, tds_inicial, tds_nombre, tds_monto_pago " & _
                              ", tds_usuario_grabacion, tds_fecha_grabacion, tds_usuario_modificacion, tds_fecha_modificacion " & _
                              "FROM SOC_TDS_TIPOS_DE_SOCIOS"
            da.Fill(dstemp, "SOC_TDS_TIPOS_DE_SOCIOS")

            com.CommandText = "SELECT soc_codigo, soc_codper, soc_codtds, soc_correlativo, soc_codigo_armado, soc_estado," & _
                              "soc_fecha_inicio_socio, soc_fecha_fin_socio, soc_motivo_fin_socio " & _
                              ", soc_usuario_grabacion, soc_fecha_grabacion, soc_usuario_modificacion, soc_fecha_modificacion " & _
                              ", soc_UID_1, soc_UID_2, soc_UID_3, soc_UID_4 " & _
                              "FROM SOC_SOC_SOCIOS"
            da.Fill(dstemp, "SOC_SOC_SOCIOS")

            com.CommandText = "SELECT cob_codigo, cob_codper, cob_porcentaje_comision " & _
                              ", cob_usuario_grabacion, cob_fecha_grabacion, cob_usuario_modificacion, cob_fecha_modificacion " & _
                              "FROM PAG_COB_COBRADORES"
            da.Fill(dstemp, "PAG_COB_COBRADORES")

            'JMPEREZ 21-01-16
            'Se agrega la logica para sacar los pagos en la seccion de exportar socios
            com.CommandText = "SELECT pag_codigo, pag_codsoc, pag_codcob, pag_monto, pag_mes, pag_año, pag_numero_recibo, " & _
                              "pag_fecha_recibido, pag_observaciones " & _
                              ", pag_usuario_grabacion, pag_fecha_grabacion, pag_usuario_modificacion, pag_fecha_modificacion " & _
                              "FROM PAG_PAG_PAGOS"
            da.Fill(dstemp, "PAG_PAG_PAGOS")

            'JMPEREZ 21-01-16
            'Se agrega la logica para sacar los pagos historicos en la seccion de exportar socios
            com.CommandText = "SELECT pag_correlativo, pag_codigo, pag_codsoc, pag_codcob, pag_monto, pag_mes, pag_año, pag_numero_recibo, " & _
                              "pag_fecha_recibido, pag_observaciones, pag_usuario_grabacion, pag_fecha_grabacion, pag_usuario_modificacion, " & _
                              "pag_fecha_modificacion, pag_descripcion " & _
                              "FROM PAG_PAG_PAGOS_HIST"
            da.Fill(dstemp, "PAG_PAG_PAGOS_HIST")

            'JMPEREZ 21-01-16
            'Elimina el formato de fecha al exportar a xml debido a un error que no se presentaba antes
            QuitarTimezone(dstemp)

            'Escribo el archivo xml a disco
            dstemp.WriteXml(sarchivo, XmlWriteMode.IgnoreSchema)

            'Encripto el archivo xml
            CryptFile("8069", sarchivo, sarchivoencriptado, True)

            'Elimino el archivo xml
            File.Delete(sarchivo)

            MessageBox.Show("Datos de Socios exportados correctamente" & vbNewLine & "Archivo exportado: " & sarchivoencriptado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Se comenta esta parte ya que la logica se paso al boton Exportar Socios
    'Private Sub btnExportarPagos_Click(sender As Object, e As EventArgs) Handles btnExportarPagos.Click
    '    Dim sarchivoencriptado As String
    '    Dim sarchivo As String = AppDomain.CurrentDomain.BaseDirectory & ConfigurationManager.AppSettings("archivo")

    '    Dim dstemp As New DataSet

    '    If Not Directory.Exists(sarchivo) Then
    '        Directory.CreateDirectory(sarchivo)
    '    End If

    '    sarchivo &= String.Format("{0:dd-MM-yyyy HHmmss}", Now) & "Pagos"
    '    sarchivoencriptado = sarchivo & ".dat"
    '    sarchivo &= ".xml"

    '    'Obtengo los datos de la base de datos
    '    com.Connection = con
    '    com.CommandText = "SELECT pag_codigo, pag_codsoc, pag_codcob, pag_monto, pag_mes, pag_año, pag_numero_recibo, " & _
    '                      "pag_fecha_recibido, pag_observaciones " & _
    '                      ", pag_usuario_grabacion, pag_fecha_grabacion, pag_usuario_modificacion, pag_fecha_modificacion " & _
    '                      "FROM PAG_PAG_PAGOS"
    '    da.SelectCommand = com

    '    Try
    '        da.Fill(dstemp, "PAG_PAG_PAGOS")

    '        'JMPEREZ 21-01-16
    '        'Elimina el formato de fecha al exportar a xml debido a un error que no se presentaba antes
    '        QuitarTimezone(dstemp)

    '        'Escribo el archivo xml a disco
    '        dstemp.WriteXml(sarchivo)

    '        'Encripto el archivo xml
    '        CryptFile("8069", sarchivo, sarchivoencriptado, True)

    '        'Elimino el archivo xml
    '        File.Delete(sarchivo)

    '        MessageBox.Show("Datos de Pagos exportados correctamente" & vbNewLine & "Archivo exportado: " & sarchivoencriptado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Catch ex As Exception
    '        MessageBox.Show("Error al exportar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Public Sub QuitarTimezone(ByRef ds As DataSet)
        For Each dt As DataTable In ds.Tables
            For Each dc As DataColumn In dt.Columns
                If dc.DataType = GetType(DateTime) Then
                    dc.DateTimeMode = DataSetDateTime.Unspecified
                End If
            Next
        Next
    End Sub

End Class