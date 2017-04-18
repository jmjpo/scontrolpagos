Imports libforms.libforms

Public Class frmEliminarpagos

    Dim pagos As Pag_pag_pagos
    Dim pagosHist As Pag_pag_pagos_hist

    Dim codpago As Integer

    Private Sub frmEliminarPagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.pagos

        btnBuscar.Image = My.Resources.buscar
        btnLimpiar.Image = My.Resources.limpiarf

        btnAceptar.Image = My.Resources.aceptar
        btnCancelar.Image = My.Resources.cancelars

        AddHandler txtNoRecibo.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtNombreSocio.KeyDown, AddressOf libforms.libforms.TxtKeyDown

        'Lleno el combobox de Socios
        Dim querysocios = From s In dbContext.Soc_soc_socios
                          Where s.Soc_estado = "A"
                          Select New With {Key .Codigo = s.Soc_codigo, Key .Nombre = s.Soc_codigo_armado}

        For Each elemento In querysocios.ToList
            cmbsocio.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query = From pag In dbContext.Pag_pag_pagos
                    Join soc In dbContext.Soc_soc_socios On soc.Soc_codigo Equals pag.Pag_codsoc
                   Join tds In dbContext.Soc_tds_tipos_de_socios On soc.Soc_codtds Equals tds.Tds_codigo
                   Join per In dbContext.Grl_per_personas On soc.Soc_codper Equals per.Per_codigo
                   Select New With {Key .Codigo = pag.Pag_codigo, Key .Recibo = pag.Pag_numero_recibo, Key .Fecha_Recibo = pag.Pag_fecha_recibido, _
                                    Key .Codigo_Socio = soc.Soc_codigo_armado, Key .Tipo_Socio = tds.Tds_nombre, Key .Nombre = per.Per_nombre_completo,
                                    Key .Monto = pag.Pag_monto, Key .Correspondiente_a = String.Format("{0:00}", pag.Pag_mes) & "/" & pag.Pag_año}

        If txtNoRecibo.Text.Length > 0 Then
            query = query.Where(Function(d) d.Recibo.ToString.Contains(txtNoRecibo.Text))
        End If

        If txtNombreSocio.Text.Length > 0 Then
            query = query.Where(Function(d) d.Nombre.ToString.Contains(txtNombreSocio.Text.ToUpper))
        End If

        If cmbSocio.SelectedText.Length > 0 Then
            query = query.Where(Function(d) d.Codigo_Socio.ToString.Contains(cmbSocio.SelectedText.ToUpper))
        End If

        dgdatos.DataSource = query.ToList

        If dgdatos.Rows.Count > 0 Then
            dgdatos.Columns(0).Visible = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombreSocio.Clear()
        txtNoRecibo.Clear()
        cmbSocio.SelectedIndex = -1
    End Sub

    Private Sub cmbsocio_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles cmbSocio.Validating
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

    Private Sub dgdatos_Click(sender As Object, e As EventArgs) Handles dgdatos.Click
        codpago = dgdatos.Rows(dgdatos.SelectedRows(0).Index).Cells(0).Value

        pEliminar.Visible = True
        pPrincipal.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pEliminar.Visible = False
        pPrincipal.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Copio los datos a la tabla pag_pag_pagos_hist
        Dim objregistro As New Pag_pag_pagos_hist
        Dim pago As New Pag_pag_pagos

        Dim query = From p In dbContext.Pag_pag_pagos
                  Where p.Pag_codigo = codpago

        pago = query.FirstOrDefault
        
        objregistro.Pag_codigo = pago.Pag_codigo
        objregistro.Pag_codsoc = pago.Pag_codsoc
        objregistro.Pag_codcob = pago.Pag_codcob
        objregistro.Pag_monto = pago.Pag_monto
        objregistro.Pag_mes = pago.Pag_mes
        objregistro.Pag_año = pago.Pag_año
        objregistro.Pag_numero_recibo = pago.Pag_numero_recibo
        objregistro.Pag_fecha_recibido = pago.Pag_fecha_recibido
        objregistro.Pag_observaciones = pago.Pag_observaciones
        objregistro.Pag_usuario_grabacion = pago.Pag_usuario_grabacion
        objregistro.Pag_fecha_grabacion = pago.Pag_fecha_grabacion
        objregistro.Pag_usuario_modificacion = pago.Pag_usuario_modificacion
        objregistro.Pag_fecha_modificacion = pago.Pag_fecha_modificacion
        objregistro.Pag_descripcion = txtObservacion.Text.Trim

        Try
            dbContext.Add(objregistro)
            dbContext.SaveChanges()

            'Elimino el dato de la tabla pag_pag_pagos
            dbContext.Delete(pago)
            dbContext.SaveChanges()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Pago" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        btnBuscar_Click(Nothing, Nothing)
        MessageBox.Show("Pago Eliminado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtObservacion.Clear()
        pEliminar.Visible = False
        pPrincipal.Enabled = True
    End Sub

End Class
