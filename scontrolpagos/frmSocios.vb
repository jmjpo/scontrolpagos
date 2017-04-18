Imports System.Text.RegularExpressions
Imports System.IO
Imports libforms.libforms

Public Class frmSocios

    Dim socio As Soc_soc_socios
    Dim persona As Grl_per_personas
    Dim editando As Boolean
    'Dim rutaimg As String

    Private Sub frmSocio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.socio

        AddHandler txtPrimerNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtSegundoNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtPrimerApellido.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtSegundoApellido.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtApellidoCasada.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtDireccion.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtTelefono.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtCelular.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtCorreo.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler dtFechaNacimiento.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtDPI.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtOrdenCedula.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtRegistroCedula.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUID1.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUID1.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtUID2.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUID2.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtUID3.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUID3.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtUID4.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUID4.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar
        btnEliminar.Image = My.Resources.eliminar
        btnListar.Image = My.Resources.buscar
        btnAceptar.Image = My.Resources.aceptar
        btnCancelar.Image = My.Resources.cancelars

        Dim query = From r In dbContext.Soc_tds_tipos_de_socios _
                      Select New With {Key .Codigo = r.Tds_codigo, Key .Nombre = r.Tds_nombre}

        For Each elemento In query
            cmbTipoSocio.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next

        cmbMotivo.Items.Add(New libforms.cmbKeyPair("Cambio de Tipo de Socio", "Cambio de Tipo de Socio"))
        cmbMotivo.Items.Add(New libforms.cmbKeyPair("Costo Membresia", "Costo Membresia"))
        cmbMotivo.Items.Add(New libforms.cmbKeyPair("No Especifico", "No Especifico"))
        cmbMotivo.Items.Add(New libforms.cmbKeyPair("Error de Ingreso", "Error de Ingreso"))
        cmbMotivo.Items.Add(New libforms.cmbKeyPair("Otro", "Otro"))
    End Sub

    Private Sub dgdatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatos.Click
        Dim codigo As Integer
        Dim stempcedula As String()

        codigo = dgDatos.Rows(dgDatos.SelectedRows(0).Index).Cells(0).Value

        Dim query = From s In dbContext.Soc_soc_socios
                   Where s.Soc_codigo = codigo

        socio = query.FirstOrDefault

        Dim querypersona = From p In dbContext.Grl_per_personas
                           Where p.Per_codigo = socio.Soc_codper

        persona = querypersona.FirstOrDefault

        txtOrdenCedula.Text = ""
        txtRegistroCedula.Text = ""
        txtDPI.Text = ""

        lblDatoCodigo.Text = socio.Soc_codigo_armado
        txtPrimerNombre.Text = persona.Per_primer_nombre
        txtSegundoNombre.Text = persona.Per_segundo_nombre
        txtPrimerApellido.Text = persona.Per_primer_apellido
        txtSegundoApellido.Text = persona.Per_segundo_apellido
        txtApellidoCasada.Text = persona.Per_apellido_casada
        txtDireccion.Text = persona.Per_direccion_cobro
        txtTelefono.Text = persona.Per_telefonos
        txtCelular.Text = persona.Per_celulares
        txtCorreo.Text = persona.Per_correo_electronico
        dtFechaNacimiento.Value = persona.Per_fecha_nacimiento
        txtDPI.Text = persona.Per_DPI
        txtUID1.Text = socio.Soc_UID_1.ToString
        txtUID2.Text = socio.Soc_UID_2.ToString
        txtUID3.Text = socio.Soc_UID_3.ToString
        txtUID4.Text = socio.Soc_UID_4.ToString

        If persona.Per_cedula.Trim.Length > 0 Then
            stempcedula = persona.Per_cedula.Split(" ")

            txtOrdenCedula.Text = stempcedula(0)
            txtRegistroCedula.Text = stempcedula(1)
        End If

        pbFoto.Image = Nothing
        If persona.Per_foto Is Nothing Then
            pbFoto.Image = Nothing
        Else
            Dim tmpimage As Image
            tmpimage = byteArrayToImage(persona.Per_foto)

            If tmpimage Is Nothing Then

            Else
                pbFoto.Image = tmpimage
            End If

        End If

        For Each elemento In cmbTipoSocio.Items
            If CType(elemento, libforms.cmbKeyPair).Valor = socio.Soc_codtds Then
                cmbTipoSocio.SelectedItem = elemento
            End If
        Next

        editando = True

        btnGuardar.Text = "&Editar"
        btnGuardar.Image = My.Resources.modificar
        HabilitarInterfaz(True)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim query = From soc In dbContext.Soc_soc_socios
                    Join tds In dbContext.Soc_tds_tipos_de_socios On soc.Soc_codtds Equals tds.Tds_codigo
                    Join per In dbContext.Grl_per_personas On soc.Soc_codper Equals per.Per_codigo
                    Where soc.Soc_estado = "A"
                    Select New With {Key .CodigoSocio = soc.Soc_codigo, Key .Codigo = soc.Soc_codigo_armado, Key .Nombre = per.Per_nombre_completo, _
                                     Key .DireccionCobro = per.Per_direccion_cobro, Key .Telefono = per.Per_telefonos, Key .Celulares = per.Per_celulares, _
                                     Key .CorreoElectronico = per.Per_correo_electronico, Key .CodigoTDS = tds.Tds_codigo, Key .TipodeSocio = tds.Tds_nombre, _
                                     Key .Foto = per.Per_foto}

        dgDatos.DataSource = query.ToList
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Soc_soc_socios
            Dim objregistropersona As New Grl_per_personas

            If editando Then                
                persona.Per_primer_nombre = txtPrimerNombre.Text.ToUpper
                persona.Per_segundo_nombre = txtSegundoNombre.Text.ToUpper
                persona.Per_primer_apellido = txtPrimerApellido.Text.ToUpper
                persona.Per_segundo_apellido = txtSegundoApellido.Text.ToUpper
                persona.Per_apellido_casada = txtApellidoCasada.Text.ToUpper
                persona.Per_nombre_completo = Trim(txtPrimerNombre.Text.ToUpper & " " & txtSegundoNombre.Text.ToUpper & " " & txtPrimerApellido.Text.ToUpper & " " & txtSegundoApellido.Text.ToUpper & " " & txtApellidoCasada.Text.ToUpper)
                persona.Per_direccion_cobro = txtDireccion.Text
                persona.Per_telefonos = txtTelefono.Text
                persona.Per_celulares = txtCelular.Text
                persona.Per_correo_electronico = txtCorreo.Text
                persona.Per_fecha_nacimiento = dtFechaNacimiento.Value
                persona.Per_DPI = txtDPI.Text
                persona.Per_cedula = txtOrdenCedula.Text.Trim.ToUpper & " " & txtRegistroCedula.Text.Trim
                persona.Per_foto = ImageFiletoBytes("")
            Else
                objregistropersona.Per_primer_nombre = txtPrimerNombre.Text.ToUpper
                objregistropersona.Per_segundo_nombre = txtSegundoNombre.Text.ToUpper
                objregistropersona.Per_primer_apellido = txtPrimerApellido.Text.ToUpper
                objregistropersona.Per_segundo_apellido = txtSegundoApellido.Text.ToUpper
                objregistropersona.Per_apellido_casada = txtApellidoCasada.Text.ToUpper
                objregistropersona.Per_nombre_completo = Trim(txtPrimerNombre.Text.ToUpper & " " & txtSegundoNombre.Text.ToUpper & " " & txtPrimerApellido.Text.ToUpper & " " & txtSegundoApellido.Text.ToUpper & " " & txtApellidoCasada.Text.ToUpper)
                objregistropersona.Per_direccion_cobro = txtDireccion.Text
                objregistropersona.Per_telefonos = txtTelefono.Text
                objregistropersona.Per_celulares = txtCelular.Text
                objregistropersona.Per_correo_electronico = txtCorreo.Text
                objregistropersona.Per_fecha_nacimiento = dtFechaNacimiento.Value
                objregistropersona.Per_DPI = txtDPI.Text
                objregistropersona.Per_cedula = txtOrdenCedula.Text.Trim.ToUpper & " " & txtRegistroCedula.Text.Trim                
                objregistropersona.Per_foto = ImageFiletoBytes("")
                objregistropersona.Per_estado = "A"
                dbContext.Add(objregistropersona)
            End If

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                MessageBox.Show("Error al grabar el socio" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If Not editando Then
                objregistro.Soc_codper = objregistropersona.Per_codigo
                objregistro.Soc_codtds = CType(cmbTipoSocio.SelectedItem, libforms.cmbKeyPair).Valor
                objregistro.Soc_estado = "A"

                Dim max_correlativo As Integer = (From r In dbContext.Soc_soc_socios
                                                  Where r.Soc_codtds = CType(cmbTipoSocio.SelectedItem, libforms.cmbKeyPair).Valor
                                                  Select r.Soc_correlativo).Max

                Dim inicial_tipo_socio = (From r In dbContext.Soc_tds_tipos_de_socios
                                          Where r.Tds_codigo = CType(cmbTipoSocio.SelectedItem, libforms.cmbKeyPair).Valor
                                          Select r.Tds_inicial).FirstOrDefault

                objregistro.Soc_correlativo = max_correlativo + 1
                objregistro.Soc_codigo_armado = inicial_tipo_socio.ToString & "-" & (max_correlativo + 1)
                objregistro.Soc_fecha_inicio_socio = Now.Date

                objregistro.Soc_UID_1 = If(txtUID1.Text.Trim.Length > 0, txtUID1.Text.Trim, Nothing)
                objregistro.Soc_UID_2 = If(txtUID2.Text.Trim.Length > 0, txtUID2.Text.Trim, Nothing)
                objregistro.Soc_UID_3 = If(txtUID3.Text.Trim.Length > 0, txtUID3.Text.Trim, Nothing)
                objregistro.Soc_UID_4 = If(txtUID4.Text.Trim.Length > 0, txtUID4.Text.Trim, Nothing)

                dbContext.Add(objregistro)
            Else
                socio.Soc_UID_1 = If(txtUID1.Text.Trim.Length > 0, txtUID1.Text.Trim, Nothing)
                socio.Soc_UID_2 = If(txtUID2.Text.Trim.Length > 0, txtUID2.Text.Trim, Nothing)
                socio.Soc_UID_3 = If(txtUID3.Text.Trim.Length > 0, txtUID3.Text.Trim, Nothing)
                socio.Soc_UID_4 = If(txtUID4.Text.Trim.Length > 0, txtUID4.Text.Trim, Nothing)
            End If

            Try
                dbContext.SaveChanges()
                socio = Nothing
            Catch ex As Exception
                MessageBox.Show("Error al grabar el socio" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            MessageBox.Show("Socio grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarInterfaz()
            HabilitarInterfaz(False)
            btnListar_Click(Nothing, Nothing)
        Else
            MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function fvalidarinfo() As String
        Dim sresultado As String = ""

        If txtPrimerNombre.Text.Trim.Length = 0 Then
            sresultado &= "Error en Primer Nombre" & vbNewLine
        End If

        If txtPrimerApellido.Text.Trim.Length = 0 Then
            sresultado &= "Error en Primer Apellido" & vbNewLine
        End If

        If txtCorreo.Text.Trim.Length > 0 Then
            Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
            If emailExpression.IsMatch(txtCorreo.Text.Trim) Then
                'no realizo nada
            Else
                sresultado &= "Error en Correo Electronico" & vbNewLine
            End If
        End If

        'If dtFechaNacimiento.Value = Now.Date Then
        '    sresultado &= "Error en Fecha de Nacimiento" & vbNewLine
        'End If

        If cmbTipoSocio.SelectedIndex = -1 Then
            sresultado &= "Error en Tipo de Socio" & vbNewLine
        End If

        If txtDireccion.Text.Trim.Length = 0 Then
            sresultado &= "Error en Direccion de Cobro" & vbNewLine
        End If

        'If txtTelefono.Text.Trim.Length = 0 And txtCelular.Text.Trim.Length = 0 Then
        '    sresultado &= "Error en numero Telefonico" & vbNewLine
        'End If

        'If txtDPI.Text.Trim.Length = 0 And (txtRegistroCedula.Text.Trim.Length = 0 And txtOrdenCedula.Text.Trim.Length = 0) Then
        '    sresultado &= "Error en Documento de Identificacion" & vbNewLine
        'End If

        If Not editando Then
            'revisa si el documento de identificacion ya esta registrado
            If txtDPI.Text.Trim.Length > 0 Or (txtRegistroCedula.Text.Trim.Length > 0 And txtOrdenCedula.Text.Trim.Length > 0) Then
                Dim querydide = (From r In dbContext.Grl_per_personas
                              Where (r.Per_DPI = txtDPI.Text And r.Per_DPI <> "") Or (r.Per_cedula = txtOrdenCedula.Text.Trim.ToUpper & " " & txtRegistroCedula.Text.Trim And r.Per_cedula <> "")
                              Select r.Per_codigo).Count

                If querydide > 0 Then
                    sresultado &= "Documento de Identificacion ya Existente" & vbNewLine
                End If
            End If

            'revisa si la persona ya esta registrada por nombre
            'If txtPrimerNombre.Text.Trim.Length > 0 And txtPrimerApellido.Text.Trim.Length > 0 Then
            '    Dim querynombre = (From r In dbContext.Grl_per_personas
            '                       Where r.Per_primer_nombre & " " & r.Per_segundo_nombre & " " & r.Per_primer_apellido & " " & r.Per_segundo_apellido & " " & r.Per_apellido_casada = Trim(txtPrimerNombre.Text.ToUpper & " " & txtSegundoNombre.Text.ToUpper & " " & txtPrimerApellido.Text.ToUpper & " " & txtSegundoApellido.Text.ToUpper & " " & txtApellidoCasada.Text.ToUpper)
            '                       Select r.Per_codigo).Count

            '    If querynombre > 0 Then
            '        sresultado &= "Persona ya Existente" & vbNewLine
            '    End If
            'End If
        End If

        If txtUID1.Text.Trim.Length = 0 And txtUID2.Text.Length = 0 And txtUID3.Text.Trim.Length = 0 And txtUID4.Text.Trim.Length = 0 Then
            'no hace nada todo el UID es nulo
        Else
            If txtUID1.Text.Trim.Length > 0 And txtUID2.Text.Trim.Length > 0 And txtUID3.Text.Trim.Length > 0 And txtUID4.Text.Trim.Length > 0 Then
                If CInt(txtUID1.Text) > 255 Or CInt(txtUID2.Text) > 255 Or CInt(txtUID3.Text) > 255 Or CInt(txtUID4.Text) > 255 Then
                    sresultado &= "Error en el UID" & vbNewLine
                End If
            Else
                sresultado &= "Error en el UID" & vbNewLine
            End If
        End If

        If txtTelefono.Text.Length > 10 Then
            sresultado &= "Error en el numero telefonico" & vbNewLine
        End If

        If txtCelular.Text.Length > 10 Then
            sresultado &= "Error en el numero de celular" & vbNewLine
        End If

        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        txtPrimerNombre.Enabled = bloqueo
        txtSegundoNombre.Enabled = bloqueo
        txtPrimerApellido.Enabled = bloqueo
        txtSegundoApellido.Enabled = bloqueo
        txtApellidoCasada.Enabled = bloqueo
        txtDireccion.Enabled = bloqueo
        txtTelefono.Enabled = bloqueo
        txtCelular.Enabled = bloqueo
        txtCorreo.Enabled = bloqueo
        txtDPI.Enabled = bloqueo
        txtRegistroCedula.Enabled = bloqueo
        txtOrdenCedula.Enabled = bloqueo
        txtUID1.Enabled = bloqueo
        txtUID2.Enabled = bloqueo
        txtUID3.Enabled = bloqueo
        txtUID4.Enabled = bloqueo

        pbFoto.Enabled = bloqueo

        dtFechaNacimiento.Enabled = bloqueo

        cmbTipoSocio.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo
        btnEliminar.Enabled = bloqueo

        btnListar.Enabled = Not bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        lblDatoCodigo.Text = ""

        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtApellidoCasada.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        txtDPI.Clear()
        txtOrdenCedula.Clear()
        txtRegistroCedula.Clear()
        txtUID1.Clear()
        txtUID2.Clear()
        txtUID3.Clear()
        txtUID4.Clear()

        dtFechaNacimiento.Value = Now

        cmbTipoSocio.SelectedIndex = -1

        btnNuevo.Text = "&Nuevo"
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Text = "&Guardar"
        btnGuardar.Image = My.Resources.guardar
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "&Nuevo" Then
            btnNuevo.Text = "&Cancelar"
            btnNuevo.Image = My.Resources.cancelar
            LimpiarInterfaz()
            HabilitarInterfaz(True)

            btnEliminar.Enabled = False
            editando = False
        Else
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        pPrincipal.Enabled = False
        pnlBotones.Enabled = False
        dgDatos.Enabled = False
        pEliminar.Visible = True
    End Sub

    'Lee un archivo de imagen y lo carga en memoria
    Public Function ImageFiletoBytes(ByVal Imagen As String) As Byte()
        Dim tempByte() As Byte = Nothing

        Try
            'Dim fileInfo As New IO.FileInfo(Imagen)
            'Dim NumBytes As Long = fileInfo.Length
            'Dim FStream As New IO.FileStream(Imagen, IO.FileMode.Open, IO.FileAccess.Read)
            'Dim BinaryReader As New IO.BinaryReader(FStream)

            'tempByte = BinaryReader.ReadBytes(Convert.ToInt32(NumBytes))
            'fileInfo = Nothing
            'NumBytes = 0
            'FStream.Close()
            'FStream.Dispose()
            'BinaryReader.Close()

            Dim picStream As New MemoryStream

            pbFoto.Image.Save(picStream, System.Drawing.Imaging.ImageFormat.Gif)

            tempByte = picStream.ToArray

            Return tempByte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Convierte una imagen en memoria al tipo Image
    Public Function byteArrayToImage(byteArray As Byte()) As Image
        Dim imagen As Image = Nothing

        Try
            Dim stream As New System.IO.MemoryStream(byteArray)
            imagen = Image.FromStream(stream, True, True)
        Catch ex As Exception
            MessageBox.Show("Error al leer los datos del socio" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return imagen
    End Function

    Private Sub pbFoto_Click(sender As Object, e As EventArgs) Handles pbFoto.Click
        Dim ofdAbrir As New OpenFileDialog()

        ofdAbrir.Filter = "Bitmap|*.bmp|JPG|*.jpg|GIF|*.gif|PNG|*.png|Todos los Archivos|*.*"
        ofdAbrir.FilterIndex = 2
        ofdAbrir.RestoreDirectory = True

        'rutaimg = ""
        If ofdAbrir.ShowDialog(Me) = DialogResult.OK Then

            Dim fileInfo As New FileInfo(ofdAbrir.FileName)

            If fileInfo.Length <= 1048576 Then
                'rutaimg = ofdAbrir.FileName

                pbFoto.Image = System.Drawing.Bitmap.FromFile(ofdAbrir.FileName)
            Else
                MessageBox.Show("El tamaño de la foto del socio debe ser menor a 1MB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub BtnAceptar_click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        socio.Soc_estado = "E"
        socio.Soc_fecha_fin_socio = Now.Date
        socio.Soc_motivo_fin_socio = CType(cmbMotivo.SelectedItem, libforms.cmbKeyPair).Texto

        Try
            dbContext.SaveChanges()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el socio" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        pPrincipal.Enabled = True
        pnlBotones.Enabled = True
        dgDatos.Enabled = True
        pEliminar.Visible = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pPrincipal.Enabled = True
        pnlBotones.Enabled = True
        dgDatos.Enabled = True
        pEliminar.Visible = False
    End Sub

    Private Sub dgDatos_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgDatos.DataError
        Dim x As Integer
        x = x
    End Sub

End Class
