Imports System.IO
Imports libforms.libforms
Imports MySql.Data.MySqlClient
Imports Telerik.OpenAccess
Imports System.Configuration

Public Class frmImportar

    Dim dstemp As New DataSet

    Dim con As New MySqlConnection(sConexion)
    Dim com As New MySqlCommand
    Dim tran As MySqlTransaction

    Private Sub frmImportar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmImportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.importar

        btnImportarConfiguracion.Image = My.Resources.configuracion
        btnImportarSocios.Image = My.Resources.sociosB
        btnImportarPagos.Image = My.Resources.pagosB
    End Sub

    Private Sub btnImportarConfiguracion_Click(sender As Object, e As EventArgs) Handles btnImportarConfiguracion.Click
        Dim ofdAbrir As New OpenFileDialog()
        Dim dstemp As New DataSet
        Dim val As Boolean

        Dim sarchivoencriptado As String
        Dim sarchivo As String

        com.Connection = con

        ofdAbrir.Filter = "Datos|*.dat"
        ofdAbrir.RestoreDirectory = True

        If ofdAbrir.ShowDialog(Me) = DialogResult.OK Then
            If ofdAbrir.FileName.Trim.Length > 0 Then
                sarchivoencriptado = ofdAbrir.FileName
                sarchivo = sarchivoencriptado.Replace(".dat", ".xml")

                'Desencripto el archivo dat
                CryptFile("8069", sarchivoencriptado, sarchivo, False)

                'Leo el archivo xml
                dstemp.ReadXml(sarchivo)

                'reviso que el dataset contenga todas las tablas a importar
                If dstemp.Tables.Contains("SEG_OPC_OPCIONES") And dstemp.Tables.Contains("SEG_AXO_ACCIONES_X_OPCION") And dstemp.Tables.Contains("SEG_MEN_MENUS") _
                    And dstemp.Tables.Contains("SEG_OXM_OPCIONES_X_MENU") And dstemp.Tables.Contains("SEG_ROL_ROLES") And dstemp.Tables.Contains("SEG_UXR_USUARIOS_X_ROLE") _
                    And dstemp.Tables.Contains("SEG_ARO_AUTORIZACIONES_ROLE") And dstemp.Tables.Contains("SEG_ACC_ACCIONES") And dstemp.Tables.Contains("SEG_USU_USUARIOS") Then
                    val = True
                Else
                    val = False
                End If

                If val Then
                    'Limpio las tablas segun los datos del dataset
                    Try
                        con.Open()
                        tran = con.BeginTransaction
                        com.Transaction = tran

                        For i = dstemp.Tables.Count - 1 To 0 Step -1
                            Dim dt As DataTable = dstemp.Tables(i)

                            com.CommandText = "DELETE FROM " & dt.TableName
                            com.ExecuteNonQuery()
                        Next
                        tran.Commit()

                    Catch ex As MySqlException
                        tran.Rollback()

                        MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub
                    Finally
                        con.Close()
                    End Try

                    'Ingreso los datos de las tablas en la base de datos
                    Try
                        con.Open()
                        tran = con.BeginTransaction
                        com.Transaction = tran
                        For Each dt As DataTable In dstemp.Tables
                            For Each dr As DataRow In dt.Rows
                                Dim sql As String
                                Dim valores As String = ""

                                'Inserto los datos
                                sql = "INSERT INTO " & dt.TableName & " SET "
                                For i = 0 To dt.Columns.Count - 1
                                    If dr(i).ToString.Length > 0 Then
                                        valores &= dt.Columns(i).ColumnName & " = '" & dr(i) & "', "
                                    Else
                                        valores &= dt.Columns(i).ColumnName.Replace("Ã±", "ñ") & " = NULL, "
                                    End If
                                Next
                                sql &= valores.Remove(valores.LastIndexOf(","))

                                com.CommandText = sql
                                com.ExecuteNonQuery()
                            Next
                        Next
                        tran.Commit()

                        'Genero los usuarios del sistema
                        For Each dr As DataRow In dstemp.Tables("SEG_USU_USUARIOS").Rows
                            If dr("usu_usuario").ToString <> "root" Then
                                Dim comando2 As New MySqlCommand

                                comando2.Connection = con
                                comando2.CommandText = "DROP USER " & dr("usu_usuario")

                                Try
                                    comando2.ExecuteNonQuery()
                                Catch ex As Exception

                                End Try

                                CreaUsuarioBD(dr("usu_usuario"), dr("usu_password"))
                            End If
                        Next
                    Catch ex As MySqlException
                        tran.Rollback()

                        MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub
                    Finally
                        con.Close()
                    End Try

                    'Elimino el archivo xml
                    File.Delete(sarchivo)

                    MessageBox.Show("Datos de Configuracion importados correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnImportarSocios_Click(sender As Object, e As EventArgs) Handles btnImportarSocios.Click
        Dim ofdAbrir As New OpenFileDialog()
        Dim dstemp As New DataSet
        Dim val As Boolean

        Dim sarchivoencriptado As String
        Dim sarchivo As String

        com.Connection = con

        ofdAbrir.Filter = "Datos|*.dat"
        ofdAbrir.RestoreDirectory = True

        If ofdAbrir.ShowDialog(Me) = DialogResult.OK Then
            If ofdAbrir.FileName.Trim.Length > 0 Then
                sarchivoencriptado = ofdAbrir.FileName
                sarchivo = sarchivoencriptado.Replace(".dat", ".xml")

                'Desencripto el archivo dat
                CryptFile("8069", sarchivoencriptado, sarchivo, False)

                'Leo el archivo xml
                dstemp.ReadXml(sarchivo)

                'reviso que el dataset contenga todas las tablas a importar
                If dstemp.Tables.Contains("GRL_PER_PERSONAS") And dstemp.Tables.Contains("SOC_TDS_TIPOS_DE_SOCIOS") And dstemp.Tables.Contains("SOC_SOC_SOCIOS") _
                    And dstemp.Tables.Contains("PAG_COB_COBRADORES") And dstemp.Tables.Contains("PAG_PAG_PAGOS") And dstemp.Tables.Contains("PAG_PAG_PAGOS_HIST") Then
                    val = True
                Else
                    val = False
                End If

                If val Then
                    'JMPEREZ 15-04-2016
                    'Se agrega la logica para sacar un backup de la informacion de pagos antes de cargar la data 
                    'del archivo a importar
                    Dim sarchivobk As String = AppDomain.CurrentDomain.BaseDirectory & ConfigurationManager.AppSettings("archivo")
                    Dim da As New MySqlDataAdapter
                    Dim dsbk As New DataSet

                    If Not Directory.Exists(sarchivobk) Then
                        Directory.CreateDirectory(sarchivo)
                    End If

                    sarchivobk &= String.Format("{0:dd-MM-yyyy HHmmss}", Now) & ".bk"

                    com.CommandText = "SELECT pag_codigo, pag_codsoc, pag_codcob, pag_monto, pag_mes, pag_año, pag_numero_recibo, " & _
                             "pag_fecha_recibido, pag_observaciones " & _
                             ", pag_usuario_grabacion, pag_fecha_grabacion, pag_usuario_modificacion, pag_fecha_modificacion " & _
                             "FROM PAG_PAG_PAGOS"
                    da.SelectCommand = com
                    da.Fill(dsbk, "PAG_PAG_PAGOS")
                    dsbk.WriteXml(sarchivobk)

                    'JMPEREZ 21-01-2016
                    'Cambio la logica de importar informacion debido a que se necesitan actualizar los datos
                    'existentes, se toma la logica de eliminar toda la info
                    'Limpio las tablas segun los datos del dataset
                    Try
                        con.Open()
                        tran = con.BeginTransaction
                        com.Transaction = tran

                        For i = dstemp.Tables.Count - 1 To 0 Step -1
                            Dim dt As DataTable = dstemp.Tables(i)

                            com.CommandText = "DELETE FROM " & dt.TableName
                            com.ExecuteNonQuery()
                        Next
                        tran.Commit()

                    Catch ex As MySqlException
                        tran.Rollback()

                        MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub
                    Finally
                        con.Close()
                    End Try

                    'Ingreso los datos de las tablas en la base de datos
                    Try
                        con.Open()
                        tran = con.BeginTransaction
                        com.Transaction = tran
                        For Each dt As DataTable In dstemp.Tables
                            For Each dr As DataRow In dt.Rows
                                Dim sql As String
                                Dim valores As String = ""

                                Dim content As Byte()

                                com.Parameters.Clear()

                                'Inserto los datos
                                sql = "INSERT INTO " & dt.TableName & " SET "
                                For i = 0 To dt.Columns.Count - 1
                                    If dr(i).ToString.Length > 0 Then
                                        If dt.Columns(i).ColumnName = "per_foto" Then
                                            valores &= dt.Columns(i).ColumnName.Replace("Ã±", "ñ") & " = @img , "
                                            content = Convert.FromBase64String(dr(i))
                                        Else
                                            valores &= dt.Columns(i).ColumnName.Replace("Ã±", "ñ") & " = '" & dr(i) & "', "
                                        End If
                                    Else
                                        valores &= dt.Columns(i).ColumnName.Replace("Ã±", "ñ") & " = NULL, "
                                    End If
                                Next
                                sql &= valores.Remove(valores.LastIndexOf(","))

                                com.CommandText = sql

                                If content Is Nothing Then

                                Else
                                    com.Parameters.AddWithValue("@img", content)
                                End If
                                com.ExecuteNonQuery()
                            Next
                        Next
                        tran.Commit()
                    Catch ex As MySqlException
                        tran.Rollback()

                        MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub
                    Finally
                        con.Close()
                    End Try

                    'JMPEREZ 21-01-16
                    'Se comenta la logica anterior
                    'Ingreso los datos de las tablas en la base de datos
                    'Try
                    '    con.Open()
                    '    tran = con.BeginTransaction
                    '    com.Transaction = tran
                    '    For Each dt As DataTable In dstemp.Tables
                    '        For Each dr As DataRow In dt.Rows
                    '            Dim sql As String
                    '            Dim valores As String = ""
                    '            Dim res As Integer

                    '            'Reviso si no existe el registro segun la llave primaria
                    '            com.CommandText = "SELECT COUNT(*) tot FROM " & dt.TableName & " WHERE " & dt.Columns(0).ColumnName & " = " & dr(0)
                    '            res = com.ExecuteScalar

                    '            If res = 0 Then
                    '                'Inserto los datos
                    '                sql = "INSERT INTO " & dt.TableName & " SET "
                    '                For i = 0 To dt.Columns.Count - 1
                    '                    valores &= dt.Columns(i).ColumnName & " = '" & dr(i) & "', "
                    '                Next
                    '                sql &= valores.Remove(valores.LastIndexOf(","))

                    '                com.CommandText = sql
                    '                com.ExecuteNonQuery()
                    '            End If
                    '        Next
                    '    Next
                    '    tran.Commit()
                    'Catch ex As MySqlException
                    '    tran.Rollback()

                    '    MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    '    Exit Sub
                    'Finally
                    '    con.Close()
                    'End Try

                    'Elimino el archivo xml
                    File.Delete(sarchivo)

                    MessageBox.Show("Datos de Socios importados correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CreaUsuarioBD(ByVal sUsuario As String, ByVal sPassword As String)
        Dim parameters As IList(Of SqlParameter) = New List(Of SqlParameter)() From { _
           New SqlParameter("_Usuario", OpenAccessType.Varchar), _
            New SqlParameter("_Pass", OpenAccessType.Varchar) _
        }

        dbContext.ExecuteStoredProcedure(Of Object)("CrearUsuario", parameters, sUsuario, sPassword)
    End Sub

    'Se comenta esta parte ya que la logica se paso al boton Importar Socios
    'Private Sub btnImportarPagos_Click(sender As Object, e As EventArgs) Handles btnImportarPagos.Click
    '    Dim ofdAbrir As New OpenFileDialog()
    '    Dim dstemp As New DataSet
    '    Dim val As Boolean

    '    Dim sarchivoencriptado As String
    '    Dim sarchivo As String

    '    com.Connection = con

    '    ofdAbrir.Filter = "Datos|*.dat"
    '    ofdAbrir.RestoreDirectory = True

    '    If ofdAbrir.ShowDialog(Me) = DialogResult.OK Then
    '        If ofdAbrir.FileName.Trim.Length > 0 Then
    '            sarchivoencriptado = ofdAbrir.FileName
    '            sarchivo = sarchivoencriptado.Replace(".dat", ".xml")

    '            'Desencripto el archivo dat
    '            CryptFile("8069", sarchivoencriptado, sarchivo, False)

    '            'Leo el archivo xml
    '            dstemp.ReadXml(sarchivo)

    '            If dstemp.Tables.Contains("PAG_PAG_PAGOS") Then
    '                val = True
    '            Else
    '                val = False
    '            End If

    '            If val Then
    '                'JMPEREZ 21-01-2016
    '                'Cambio la logica de importar informacion debido a que se necesitan actualizar los datos
    '                'existentes, se toma la logica de eliminar toda la info
    '                'Limpio las tablas segun los datos del dataset
    '                Try
    '                    con.Open()
    '                    tran = con.BeginTransaction
    '                    com.Transaction = tran

    '                    For i = dstemp.Tables.Count - 1 To 0 Step -1
    '                        Dim dt As DataTable = dstemp.Tables(i)

    '                        com.CommandText = "DELETE FROM " & dt.TableName
    '                        com.ExecuteNonQuery()
    '                    Next
    '                    tran.Commit()

    '                Catch ex As MySqlException
    '                    tran.Rollback()

    '                    MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '                    Exit Sub
    '                Finally
    '                    con.Close()
    '                End Try

    '                'Ingreso los datos de las tablas en la base de datos
    '                Try
    '                    con.Open()
    '                    tran = con.BeginTransaction
    '                    com.Transaction = tran
    '                    For Each dt As DataTable In dstemp.Tables
    '                        For Each dr As DataRow In dt.Rows
    '                            Dim sql As String
    '                            Dim valores As String = ""

    '                            'Inserto los datos
    '                            sql = "INSERT INTO " & dt.TableName & " SET "
    '                            For i = 0 To dt.Columns.Count - 1
    '                                valores &= dt.Columns(i).ColumnName & " = '" & dr(i) & "', "
    '                            Next
    '                            sql &= valores.Remove(valores.LastIndexOf(","))

    '                            com.CommandText = sql
    '                            com.CommandText = sql.Replace("Ã±", "ñ")
    '                            com.ExecuteNonQuery()
    '                        Next
    '                    Next
    '                    tran.Commit()
    '                Catch ex As MySqlException
    '                    tran.Rollback()

    '                    MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '                    Exit Sub
    '                Finally
    '                    con.Close()
    '                End Try

    '                'JMPEREZ 21-01-16
    '                'Se comenta la logica anterior
    '                'Ingreso los datos de las tablas en la base de datos
    '                'Ingreso los datos de las tablas en la base de datos
    '                'Try
    '                '    con.Open()
    '                '    tran = con.BeginTransaction
    '                '    com.Transaction = tran
    '                '    For Each dt As DataTable In dstemp.Tables
    '                '        For Each dr As DataRow In dt.Rows
    '                '            Dim sql As String
    '                '            Dim valores As String = ""
    '                '            Dim res As Integer

    '                '            'Reviso si no existe el registro segun la llave primaria
    '                '            com.CommandText = "SELECT COUNT(*) tot FROM " & dt.TableName & " WHERE " & dt.Columns(0).ColumnName & " = " & dr(0)
    '                '            res = com.ExecuteScalar

    '                '            If res = 0 Then
    '                '                'Inserto los datos
    '                '                sql = "INSERT INTO " & dt.TableName & " SET "
    '                '                For i = 0 To dt.Columns.Count - 1
    '                '                    valores &= dt.Columns(i).ColumnName & " = '" & dr(i) & "', "
    '                '                Next
    '                '                sql &= valores.Remove(valores.LastIndexOf(","))

    '                '                'JMPEREZ 21-01-16
    '                '                'Se comenta el replace anterior debido a que hora se controla la exportacion
    '                '                'del dato de fecha desde la opcion exportar
    '                '                'com.CommandText = sql.Replace("Ã±", "ñ").Replace("T00:00:00-06:00", "")
    '                '                com.CommandText = sql.Replace("Ã±", "ñ")
    '                '                com.ExecuteNonQuery()
    '                '            End If
    '                '        Next
    '                '    Next
    '                '    tran.Commit()
    '                'Catch ex As MySqlException
    '                '    tran.Rollback()

    '                '    MessageBox.Show("Error al importar datos " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '                '    Exit Sub
    '                'Finally
    '                '    con.Close()
    '                'End Try

    '                'Elimino el archivo xml
    '                File.Delete(sarchivo)

    '                MessageBox.Show("Datos de Pagos importados correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Else
    '        MessageBox.Show("Elija un archivo para importar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

End Class