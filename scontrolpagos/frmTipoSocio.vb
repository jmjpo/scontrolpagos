Imports libforms.libforms

Public Class frmTipoSocio

    Dim tiposocio As Soc_tds_tipos_de_socios
    Dim editando As Boolean

    Private Sub frmTipoSocio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmTipoSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.tiposocios

        AddHandler txtNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtMonto.KeyDown, AddressOf libforms.libforms.TxtmontoKeyDown
        AddHandler txtMonto.KeyPress, AddressOf libforms.libforms.TxtmontoKeyPress
        AddHandler txtMonto.LostFocus, AddressOf libforms.libforms.TxtmontoLostFocus
        AddHandler txtInicial.KeyDown, AddressOf libforms.libforms.TxtKeyDown

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar        
        btnListar.Image = My.Resources.buscar
    End Sub

    Private Sub dgdatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatos.Click
        Dim codigo As Integer
        codigo = dgDatos.Rows(dgDatos.SelectedRows(0).Index).Cells(0).Value

        Dim query = From r In dbContext.Soc_tds_tipos_de_socios _
                   Where r.Tds_codigo = codigo
                   Select r

        tiposocio = query.FirstOrDefault

        lblDatoCodigo.Text = tiposocio.Tds_codigo
        txtNombre.Text = tiposocio.Tds_nombre
        txtMonto.Text = tiposocio.Tds_monto_pago
        txtInicial.Text = tiposocio.Tds_inicial

        editando = True

        btnGuardar.Text = "&Editar"
        btnGuardar.Image = My.Resources.modificar
        HabilitarInterfaz(True)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim query = From r In dbContext.Soc_tds_tipos_de_socios                    
                    Select New With {Key .Codigo = r.Tds_codigo, Key .Nombre = r.Tds_nombre, Key .Monto = r.Tds_monto_pago, Key .Inicial = r.Tds_inicial}

        dgDatos.DataSource = query.ToList
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Soc_tds_tipos_de_socios

            If editando Then
                tiposocio.Tds_nombre = txtNombre.Text
                tiposocio.Tds_inicial = txtInicial.Text
                tiposocio.Tds_monto_pago = txtMonto.Text
            Else
                objregistro.Tds_nombre = txtNombre.Text
                objregistro.Tds_inicial = txtInicial.Text
                objregistro.Tds_monto_pago = txtMonto.Text

                dbContext.Add(objregistro)
            End If

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                MessageBox.Show("Error al grabar el tipo de socio" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If Not editando Then
                lblDatoCodigo.Text = objregistro.Tds_codigo
            Else
                tiposocio = Nothing
            End If

            btnListar_Click(Nothing, Nothing)
            MessageBox.Show("Tipo de Socio grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarInterfaz()
            HabilitarInterfaz(False)
        Else
            MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function fvalidarinfo() As String
        Dim sresultado As String = ""

        If txtNombre.Text.Trim.Length = 0 Then
            sresultado &= "Error en Nombre" & vbNewLine
        End If

        If txtInicial.Text.Trim.Length = 0 Then
            sresultado &= "Error en Inicial" & vbNewLine
        End If

        If txtMonto.Text.Trim.Length = 0 Then
            sresultado &= "Error en monto" & vbNewLine
        End If

        If txtMonto.Text.Trim.Length = 0 Then
            sresultado &= "Error en monto" & vbNewLine
        End If

        If txtMonto.Text.Trim.Length > 0 Then
            If txtMonto.Text < 0 Then
                sresultado &= "Error en monto" & vbNewLine
            End If
        End If

        'revisa si ya existe el tipo de socio
        If txtNombre.Text.Length > 0 And txtMonto.Text.Length > 0 Then
            Dim querytiposocio = (From r In dbContext.Soc_tds_tipos_de_socios
                         Where r.Tds_nombre = txtNombre.Text.Trim And r.Tds_monto_pago = txtMonto.Text And r.Tds_inicial = txtInicial.Text
                         Select r.Tds_codigo).Count

            If querytiposocio > 0 Then
                sresultado &= "Tipo de socio ya Existente" & vbNewLine
            End If
        End If
        
        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        lblDatoCodigo.Enabled = bloqueo

        txtNombre.Enabled = bloqueo
        txtMonto.Enabled = bloqueo
        txtInicial.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo

        btnListar.Enabled = Not bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        lblDatoCodigo.Text = ""

        txtNombre.Clear()
        txtMonto.Clear()
        txtInicial.Clear()

        btnNuevo.Text = "&Nuevo"
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Text = "&Guardar"
        btnGuardar.Image = My.Resources.guardar
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "&Nuevo" Then
            btnNuevo.Text = "&Cancelar"
            LimpiarInterfaz()
            HabilitarInterfaz(True)

            editando = False
        Else
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        End If
    End Sub

End Class
