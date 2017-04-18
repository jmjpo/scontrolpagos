Imports libforms.libforms

Public Class frmRoles

    Dim rol As Seg_rol_roles
    Dim editando As Boolean

    Private Sub frmRoles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.roles

        AddHandler txtNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar
        btnListar.Image = My.Resources.buscar

        Dim query = From opc In dbContext.Seg_opc_opciones
                     Join axo In dbContext.Seg_axo_acciones_x_opcions
                    On axo.Axo_codopc Equals opc.Opc_codigo
                    Join acc In dbContext.Seg_acc_acciones
                    On acc.Acc_codigo Equals axo.Axo_codacc
                  Select New With {Key .opc_codigo = opc.Opc_codigo, Key .Opcion = opc.Opc_descripcion, Key .axo_codaxo = axo.Axo_codacc _
                                  , Key .Accion = acc.Acc_descripcion}

        dgpermisos.DataSource = query.ToList

        'agrego columna con checkbox al grid
        Dim chkSelect As New DataGridViewCheckBoxColumn()
        If True Then
            chkSelect.HeaderText = "Autorizar"
            chkSelect.Name = "chkSelect"
            chkSelect.Selected = False
        End If
        dgpermisos.Columns.Insert(4, chkSelect)
        dgpermisos.Columns(0).Visible = False
        dgpermisos.Columns(2).Visible = False
    End Sub

    Private Sub dgdatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatos.Click
        Dim codigo As Integer
        codigo = dgDatos.Rows(dgDatos.SelectedRows(0).Index).Cells(0).Value

        Dim query = From r In dbContext.Seg_rol_roles _
                   Where r.Rol_codigo = codigo
                   Select r

        rol = query.FirstOrDefault

        lblDatoCodigo.Text = rol.Rol_codigo
        txtNombre.Text = rol.Rol_descripcion

        'obtengo las autorizaciones del rol
        Dim queryautorizacion = From r In dbContext.Seg_aro_autorizaciones_roles
                                Where r.Aro_codrol = codigo
                                Select New With {Key .aro_codopc = r.Aro_codopc}

        'marco los checkbox segun la autorizacion indicada en la base de datos
        For Each dr As DataGridViewRow In dgpermisos.Rows
            'limpio los checkbox
            dr.Cells(4).Value = False

            For Each elemento In queryautorizacion.ToList
                If dr.Cells(0).Value = elemento.aro_codopc Then
                    dr.Cells(4).Value = True
                    Exit For
                End If
            Next
        Next

        editando = True

        btnGuardar.Text = "&Editar"
        btnGuardar.Image = My.Resources.modificar
        HabilitarInterfaz(True)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim query = From r In dbContext.Seg_rol_roles                     
                    Select New With {Key .Codigo = r.Rol_codigo, Key .Descripcion = r.Rol_descripcion}

        dgDatos.DataSource = query.ToList
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Seg_rol_roles

            If editando Then
                rol.Rol_descripcion = txtNombre.Text
            Else
                objregistro.Rol_descripcion = txtNombre.Text

                dbContext.Add(objregistro)
            End If

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                dbContext.ClearChanges()
                MessageBox.Show("Error al grabar el rol " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If Not editando Then
                lblDatoCodigo.Text = objregistro.Rol_codigo
            Else
                'limpia los permisos del rol
                For Each auto In dbContext.Seg_aro_autorizaciones_roles.ToList
                    If auto.Aro_codrol = rol.Rol_codigo Then
                        dbContext.Delete(auto)
                    End If
                Next
                dbContext.SaveChanges()
            End If

            'a ingresar los permisos del rol
            For Each dr As DataGridViewRow In dgpermisos.Rows
                If dr.Cells(4).Value = True Then
                    Dim objautorizacion As New Seg_aro_autorizaciones_role

                    objautorizacion.Aro_codopc = dr.Cells(0).Value
                    objautorizacion.Aro_codrol = lblDatoCodigo.Text
                    'Control total
                    objautorizacion.Aro_codaxo = 5

                    dbContext.Add(objautorizacion)
                End If
            Next

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                dbContext.ClearChanges()
                MessageBox.Show("Error al grabar la autorizacion del rol " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            MessageBox.Show("Rol grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInterfaz()
            HabilitarInterfaz(False)
        Else
            MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function fvalidarinfo() As String
        Dim sresultado As String = ""

        If txtNombre.Text.Trim.Length = 0 Then
            sresultado &= "Error en Nombre de Rol" & vbNewLine
        End If

        'revisa si ya existe el rol
        If txtNombre.Text.Length > 0 And editando = False Then
            Dim queryrol = (From r In dbContext.Seg_rol_roles
                         Where r.Rol_descripcion.ToUpper = txtNombre.Text.Trim.ToUpper
                         Select r.Rol_codigo).Count

            If queryrol > 0 Then
                sresultado &= "Rol ya Existente" & vbNewLine
            End If
        End If

        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        lblDatoCodigo.Enabled = bloqueo

        txtNombre.Enabled = bloqueo

        dgpermisos.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo

        btnListar.Enabled = Not bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        lblDatoCodigo.Text = ""

        txtNombre.Clear()

        For Each dr As DataGridViewRow In dgpermisos.Rows
            dr.Cells(4).Value = False
        Next

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
