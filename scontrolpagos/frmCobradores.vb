Imports libforms.libforms

Public Class frmCobradores

    Dim cobrador As Pag_cob_cobradores
    Dim persona As Grl_per_personas
    Dim editando As Boolean

    Private Sub frmCobradores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmCobradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.cobrador

        AddHandler txtPrimerNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtSegundoNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtPrimerApellido.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtSegundoApellido.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtTelefono.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtTelefono.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtTelefono.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtCelular.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtcomision.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtcomision.KeyPress, AddressOf libforms.libforms.TxtmontoKeyPress

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar
        btnListar.Image = My.Resources.buscar
    End Sub

    Private Sub dgdatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatos.Click
        Dim codigo As Integer
        codigo = dgDatos.Rows(dgDatos.SelectedRows(0).Index).Cells(0).Value

        Dim query = From c In dbContext.Pag_cob_cobradores
                   Where c.Cob_codigo = codigo

        cobrador = query.FirstOrDefault

        Dim querypersona = From p In dbContext.Grl_per_personas
                           Where p.Per_codigo = cobrador.Cob_codper

        persona = querypersona.FirstOrDefault

        lblDatoCodigo.Text = cobrador.Cob_codigo
        txtPrimerNombre.Text = persona.Per_primer_nombre
        txtSegundoNombre.Text = persona.Per_segundo_nombre
        txtPrimerApellido.Text = persona.Per_primer_apellido
        txtSegundoApellido.Text = persona.Per_segundo_apellido
        txtTelefono.Text = persona.Per_telefonos
        txtCelular.Text = persona.Per_celulares
        txtcomision.Text = cobrador.Cob_porcentaje_comision
        
        editando = True

        btnGuardar.Text = "&Editar"
        btnGuardar.Image = My.Resources.modificar
        HabilitarInterfaz(True)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim query = From r In dbContext.Pag_cob_cobradores
                    Join p In dbContext.Grl_per_personas
                    On r.Cob_codper Equals p.Per_codigo
                    Select New With {Key .Codigo = r.Cob_codigo, Key .Nombre = p.Per_nombre_completo}

        dgDatos.DataSource = query.ToList
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Pag_cob_cobradores
            Dim objregistropersona As New Grl_per_personas

            If editando Then
                persona.Per_primer_nombre = txtPrimerNombre.Text.ToUpper
                persona.Per_segundo_nombre = txtSegundoNombre.Text.ToUpper
                persona.Per_primer_apellido = txtPrimerApellido.Text.ToUpper
                persona.Per_segundo_apellido = txtSegundoApellido.Text.ToUpper
                persona.Per_nombre_completo = Trim(txtPrimerNombre.Text.ToUpper & " " & txtSegundoNombre.Text.ToUpper & " " & txtPrimerApellido.Text.ToUpper & " " & txtSegundoApellido.Text.ToUpper)
                persona.Per_telefonos = txtTelefono.Text
                persona.Per_celulares = txtCelular.Text
            Else
                objregistropersona.Per_primer_nombre = txtPrimerNombre.Text.ToUpper
                objregistropersona.Per_segundo_nombre = txtSegundoNombre.Text.ToUpper
                objregistropersona.Per_primer_apellido = txtPrimerApellido.Text.ToUpper
                objregistropersona.Per_segundo_apellido = txtSegundoApellido.Text.ToUpper
                objregistropersona.Per_nombre_completo = Trim(txtPrimerNombre.Text.ToUpper & " " & txtSegundoNombre.Text.ToUpper & " " & txtPrimerApellido.Text.ToUpper & " " & txtSegundoApellido.Text.ToUpper)
                objregistropersona.Per_telefonos = txtTelefono.Text
                objregistropersona.Per_celulares = txtCelular.Text
                objregistropersona.Per_estado = "A"
                dbContext.Add(objregistropersona)
            End If

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                MessageBox.Show("Error al grabar el Cobrador" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If Not editando Then
                objregistro.Cob_codper = objregistropersona.Per_codigo

                If txtcomision.Text.Trim.Length > 0 Then
                    objregistro.Cob_porcentaje_comision = txtcomision.Text
                End If

                dbContext.Add(objregistro)

                Try
                    dbContext.SaveChanges()
                Catch ex As Exception
                    MessageBox.Show("Error al grabar el Cobrador" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Else
                cobrador.Cob_porcentaje_comision = txtcomision.Text
                dbContext.SaveChanges()

                cobrador = Nothing
            End If

            MessageBox.Show("Cobrador grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInterfaz()
            HabilitarInterfaz(False)
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

        If Not editando Then
            'revisa si la persona ya esta registrada por nombre
            If txtPrimerNombre.Text.Trim.Length > 0 And txtPrimerApellido.Text.Trim.Length > 0 Then
                Dim querynombre = (From c In dbContext.Pag_cob_cobradores
                                   Join p In dbContext.Grl_per_personas On c.Cob_codper Equals p.Per_codigo
                                   Where p.Per_primer_nombre = txtPrimerNombre.Text.Trim.ToUpper And p.Per_primer_apellido = txtPrimerApellido.Text.Trim.ToUpper
                                   Select p.Per_codigo).Count

                If querynombre > 0 Then
                    sresultado &= "Cobrador ya Existente" & vbNewLine
                End If
            End If
        End If

        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        txtPrimerNombre.Enabled = bloqueo
        txtSegundoNombre.Enabled = bloqueo
        txtPrimerApellido.Enabled = bloqueo
        txtSegundoApellido.Enabled = bloqueo
        txtTelefono.Enabled = bloqueo
        txtCelular.Enabled = bloqueo
        txtcomision.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo

        btnListar.Enabled = Not bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        lblDatoCodigo.Text = ""

        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtcomision.Clear()

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

            editando = False
        Else
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

End Class
