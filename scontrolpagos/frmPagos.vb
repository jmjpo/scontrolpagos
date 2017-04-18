Imports libforms.libforms

Public Class frmpagos

    Dim pagos As Pag_pag_pagos
    Dim bancobrador As Boolean

    Private Sub frmPagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.pagos

        AddHandler txtNoRecibo.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtNoRecibo.KeyPress, AddressOf libforms.libforms.TxtnumeroKeyPress
        AddHandler txtMonto.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtMonto.KeyPress, AddressOf libforms.libforms.TxtmontoKeyPress

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar

        'Lleno el combobox de cobradores
        Dim query = From c In dbContext.Pag_cob_cobradores
                    Join p In dbContext.Grl_per_personas On c.Cob_codper Equals p.Per_codigo
                  Select New With {Key .Codigo = c.Cob_codigo, Key .Nombre = p.Per_nombre_completo}

        For Each elemento In query.ToList
            cmbcobrador.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next

        'verifico si el usuario logueado es cobrador para seleccionarlo en el combobox
        Dim querycobrador = From c In dbContext.Pag_cob_cobradores
                            Join u In dbContext.Seg_usu_usuarios On c.Cob_codper Equals u.Usu_codper
                            Where u.Usu_codigo = icodusu
                            Select New With {Key .codigo = c.Cob_codigo}
       
        Dim cobradorlogueado As Integer
        For Each s In querycobrador
            cobradorlogueado = s.codigo
        Next

        If cobradorlogueado <> 0 Then
            For Each elemento In cmbcobrador.Items
                If CType(elemento, libforms.cmbKeyPair).Valor = cobradorlogueado Then
                    cmbcobrador.SelectedItem = elemento
                    bancobrador = True
                    cmbcobrador.Enabled = False
                    Exit For
                End If
            Next
        End If

        'Lleno el combobox de Socios
        Dim querysocios = From s In dbContext.Soc_soc_socios
                          Where s.Soc_estado = "A"
                          Select New With {Key .Codigo = s.Soc_codigo, Key .Nombre = s.Soc_codigo_armado}

        For Each elemento In querysocios.ToList
            cmbsocio.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next

        'limpio las label que muestran los datos del socio
        lblNombreSocio.Text = ""
        lblTipoSocio.Text = ""
        LblMensualidad.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Pag_pag_pagos

            objregistro.Pag_codcob = CType(cmbcobrador.SelectedItem, libforms.cmbKeyPair).Valor
            objregistro.Pag_codsoc = CType(cmbsocio.SelectedItem, libforms.cmbKeyPair).Valor
            objregistro.Pag_numero_recibo = txtNoRecibo.Text.Trim
            objregistro.Pag_monto = txtMonto.Text.Trim
            objregistro.Pag_mes = dtFechaPago.Value.Month
            objregistro.Pag_año = dtFechaPago.Value.Year
            objregistro.Pag_fecha_recibido = dtfecharecibo.Value.Date
            objregistro.Pag_observaciones = txtObservaciones.text

            dbContext.Add(objregistro)

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                MessageBox.Show("Error al grabar el Pago" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            MessageBox.Show("Pago grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        Else
            MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function fvalidarinfo() As String
        Dim sresultado As String = ""

        If txtNoRecibo.Text.Trim.Length = 0 Then
            sresultado &= "Error en Numero de recibo" & vbNewLine
        End If

        If txtMonto.Text.Trim.Length = 0 Then
            sresultado &= "Error en Monto" & vbNewLine
        End If

        If cmbcobrador.SelectedIndex = -1 Then
            sresultado &= "Error elija un Cobrador" & vbNewLine
        End If

        If cmbsocio.SelectedIndex = -1 Then
            sresultado &= "Error elija un Socio" & vbNewLine
        End If

        If dtfecharecibo.Value > Now.Date Then
            sresultado &= "Error en la fecha del recibo" & vbNewLine
        End If

        'revisa si el pago ya esta registrado para el socio
        If txtNoRecibo.Text.Trim.Length > 0 And txtMonto.Text.Trim.Length > 0 Then
            Dim querypago = (From r In dbContext.Pag_pag_pagos
                               Where r.Pag_año = dtFechaPago.Value.Year And r.Pag_mes = dtFechaPago.Value.Month And r.Pag_codsoc = CType(cmbsocio.SelectedItem, libforms.cmbKeyPair).Valor
                               Select r.Pag_codigo).Count

            If querypago > 0 Then
                sresultado &= "Pago ya Existente para el Socio, Mes y Año indicado" & vbNewLine
            End If
        End If

        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        txtNoRecibo.Enabled = bloqueo
        txtMonto.Enabled = bloqueo
        txtObservaciones.Enabled = bloqueo

        If Not bancobrador Then
            cmbcobrador.Enabled = bloqueo
        End If

        cmbsocio.Enabled = bloqueo

        dtFechaPago.Enabled = bloqueo
        dtfecharecibo.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        txtMonto.Clear()
        txtNoRecibo.Clear()
        txtObservaciones.Clear()

        cmbsocio.SelectedIndex = -1

        dtFechaPago.Value = Now.Date
        dtfecharecibo.Value = Now.Date

        lblNombreSocio.Text = ""
        lblTipoSocio.Text = ""
        LblMensualidad.Text = ""

        btnNuevo.Text = "&Nuevo"
        btnNuevo.Image = My.Resources.nuevo
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "&Nuevo" Then
            btnNuevo.Text = "&Cancelar"
            btnNuevo.Image = My.Resources.cancelar
            HabilitarInterfaz(True)
        Else
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        End If
    End Sub

    Private Sub cmbsocio_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles cmbsocio.Validating
        Dim bandera As Boolean

        For Each s As libforms.cmbKeyPair In cmbsocio.Items
            If s.Texto = cmbsocio.Text Then
                bandera = True
                Exit For
            End If
        Next

        If Not bandera Then
            MessageBox.Show("Error, Elija un socio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbsocio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsocio.SelectedIndexChanged
        If Not IsNothing(cmbsocio.SelectedItem) Then
            Dim query = From s In dbContext.Soc_soc_socios
                        Join p In dbContext.Grl_per_personas On p.Per_codigo Equals s.Soc_codper
                        Join t In dbContext.Soc_tds_tipos_de_socios On s.Soc_codtds Equals t.Tds_codigo
                        Where s.Soc_codigo = CType(cmbsocio.SelectedItem, libforms.cmbKeyPair).Valor
                        Select New With {Key .nombre = p.Per_nombre_completo, Key .tipo = t.Tds_nombre, Key .monto = t.Tds_monto_pago}

            Dim socio = query.FirstOrDefault

            lblNombreSocio.Text = socio.nombre
            lblTipoSocio.Text = socio.tipo
            LblMensualidad.Text = socio.monto
        End If
    End Sub

End Class
