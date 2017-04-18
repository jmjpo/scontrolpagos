Imports MySql.Data.MySqlClient
Imports libforms.libforms
Imports Telerik.OpenAccess

Public Class frmUsuarios

    Dim usuario As Seg_usu_usuarios
    Dim permiso As Seg_uxr_usuarios_x_role

    Dim editando As Boolean

    Dim codpersona As Integer

    Private Sub frmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.usuarios

        AddHandler txtNombre.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtUsuario.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtPassword.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtConfirmar.KeyDown, AddressOf libforms.libforms.TxtKeyDown

        HabilitarInterfaz(False)
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Image = My.Resources.guardar
        btnEliminar.Image = My.Resources.eliminar
        btnListar.Image = My.Resources.buscar

        cmbEstado.Items.Add(New libforms.cmbKeyPair("Activo", "A"))
        cmbEstado.Items.Add(New libforms.cmbKeyPair("Inactivo", "I"))

        Dim query = From r In dbContext.Seg_rol_roles _
                  Select New With {Key .Codigo = r.Rol_codigo, Key .Nombre = r.Rol_descripcion}

        For Each elemento In query
            cmbrol.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
        Next
    End Sub

    Private Sub dgdatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatos.Click
        Dim codigo As Integer
        codigo = dgDatos.Rows(dgDatos.SelectedRows(0).Index).Cells(0).Value

        Dim query = From r In dbContext.Seg_usu_usuarios
                   Where r.Usu_codigo = codigo
                   Select r

        usuario = query.FirstOrDefault

        lblDatoCodigo.Text = usuario.Usu_codigo
        txtNombre.Text = usuario.Usu_nombre
        txtUsuario.Text = usuario.Usu_usuario
        txtPassword.Text = usuario.Usu_password
        txtConfirmar.Text = usuario.Usu_password

        For Each elemento In cmbEstado.Items
            If CType(elemento, libforms.cmbKeyPair).Valor = usuario.Usu_estado Then
                cmbEstado.SelectedItem = elemento
            End If
        Next

        editando = True

        Dim querypermiso = From r In dbContext.Seg_uxr_usuarios_x_roles
                   Where r.Uxr_codusu = codigo
                   Select r

        permiso = querypermiso.FirstOrDefault
        For Each elemento In cmbrol.Items
            If CType(elemento, libforms.cmbKeyPair).Valor = permiso.Uxr_codrol Then
                cmbrol.SelectedItem = elemento
            End If
        Next

        btnGuardar.Text = "&Editar"
        btnGuardar.Image = My.Resources.modificar
        HabilitarInterfaz(True)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim query = From r In dbContext.Seg_usu_usuarios
                    Where r.Usu_estado <> "E"
                    Select New With {Key .Codigo = r.Usu_codigo, Key .Nombre = r.Usu_nombre, Key .Usuario = r.Usu_usuario, Key .Estado = r.Usu_estado}

        dgDatos.DataSource = query.ToList
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim res As String

        res = fvalidarinfo()

        If res.Length = 0 Then
            Dim objregistro As New Seg_usu_usuarios
            Dim objpermiso As New Seg_uxr_usuarios_x_role

            If editando Then
                usuario.Usu_nombre = txtNombre.Text
                usuario.Usu_usuario = txtUsuario.Text
                usuario.Usu_password = txtPassword.Text
                usuario.Usu_estado = CType(cmbEstado.SelectedItem, libforms.cmbKeyPair).Valor                

                permiso.Uxr_codrol = CType(CType(cmbrol.SelectedItem, libforms.cmbKeyPair).Valor, Integer)
                ActualizaPasswordBD()
            Else
                objregistro.Usu_nombre = txtNombre.Text
                objregistro.Usu_usuario = txtUsuario.Text
                objregistro.Usu_password = txtPassword.Text
                objregistro.Usu_estado = CType(cmbEstado.SelectedItem, libforms.cmbKeyPair).Valor
                objregistro.Usu_codper = codpersona

                CreaUsuarioBD()
                dbContext.Add(objregistro)
            End If

            Try
                dbContext.SaveChanges()
            Catch ex As Exception
                dbContext.ClearChanges()
                MessageBox.Show("Error al grabar el usuario " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If Not editando Then
                lblDatoCodigo.Text = objregistro.Usu_codigo

                'Indica el rol del usuario
                objpermiso.Uxr_codusu = objregistro.Usu_codigo
                objpermiso.Uxr_codrol = CType(cmbrol.SelectedItem, libforms.cmbKeyPair).Valor
                dbContext.Add(objpermiso)

                Try
                    dbContext.SaveChanges()
                Catch ex As Exception
                    dbContext.ClearChanges()
                    MessageBox.Show("Error al grabar el rol del usuario " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Else
                usuario = Nothing
            End If

            MessageBox.Show("Usuario grabado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        If txtUsuario.Text.Trim.Length = 0 Then
            sresultado &= "Error en Usuario" & vbNewLine
        End If

        If txtPassword.Text.Trim.Length = 0 Then
            sresultado &= "Error en Password" & vbNewLine
        End If

        If txtPassword.Text.Length > 0 And txtPassword.Text.Trim <> txtConfirmar.Text.Trim Then
            sresultado &= "Error en confirmación de Password" & vbNewLine
        End If

        If cmbEstado.SelectedIndex = -1 Then
            sresultado &= "Error en estado Usuario" & vbNewLine
        End If

        If cmbrol.SelectedIndex = -1 Then
            sresultado &= "Error en rol de Usuario" & vbNewLine
        End If

        If cmbrol.SelectedIndex <> -1 Then
            If CType(CType(cmbrol.SelectedItem, libforms.cmbKeyPair).Valor, Integer) = 2 Then
                If codpersona = 0 Then
                    sresultado &= "Error Indique la persona para el usuario" & vbNewLine
                End If
            End If
        End If

        If Not editando Then
            'Revisa si existe el usuario en la base de datos
            If txtUsuario.Text.Trim.Length > 0 Then
                Dim queryusuario = (From r In dbContext.Seg_usu_usuarios
                                   Where r.Usu_usuario = txtUsuario.Text
                                   Select r.Usu_codigo).Count

                If queryusuario > 0 Then
                    sresultado &= "Usuario ya Existente" & vbNewLine
                End If
            End If
        End If

        Return sresultado
    End Function

    Private Sub HabilitarInterfaz(bloqueo As Boolean)
        lblDatoCodigo.Enabled = bloqueo

        txtUsuario.Enabled = bloqueo
        txtNombre.Enabled = bloqueo
        txtPassword.Enabled = bloqueo
        txtConfirmar.Enabled = bloqueo

        cmbEstado.Enabled = bloqueo
        cmbrol.Enabled = bloqueo

        btnGuardar.Enabled = bloqueo
        btnEliminar.Enabled = bloqueo

        btnListar.Enabled = Not bloqueo
    End Sub

    Private Sub LimpiarInterfaz()
        lblDatoCodigo.Text = ""

        txtUsuario.Clear()
        txtNombre.Clear()
        txtPassword.Clear()
        txtConfirmar.Clear()

        cmbEstado.SelectedIndex = -1
        cmbrol.SelectedIndex = -1

        btnNuevo.Text = "&Nuevo"
        btnNuevo.Image = My.Resources.nuevo
        btnGuardar.Text = "&Guardar"
        btnGuardar.Image = My.Resources.guardar

        codpersona = 0
    End Sub

    Private Sub CreaUsuarioBD()
        Dim parameters As IList(Of SqlParameter) = New List(Of SqlParameter)() From { _
           New SqlParameter("_Usuario", OpenAccessType.Varchar), _
            New SqlParameter("_Pass", OpenAccessType.Varchar) _
        }

        dbContext.ExecuteStoredProcedure(Of Object)("CrearUsuario", parameters, txtUsuario.Text, txtPassword.Text)
    End Sub

    Private Sub ActualizaPasswordBD()
        Dim parameters As IList(Of SqlParameter) = New List(Of SqlParameter)() From { _
           New SqlParameter("_Usuario", OpenAccessType.Varchar), _
            New SqlParameter("_Pass", OpenAccessType.Varchar) _
        }

        dbContext.ExecuteStoredProcedure(Of Object)("ActualizaPassword", parameters, txtUsuario.Text, txtPassword.Text)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        usuario.Usu_estado = "E"

        Try
            dbContext.SaveChanges()
        Catch ex As Exception
            dbContext.ClearChanges()
            MessageBox.Show("Error al eliminar a el usuario " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MessageBox.Show("Usuario eliminado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbCobrador.SelectedIndex <> -1 Then
            codpersona = CType(CType(cmbCobrador.SelectedItem, libforms.cmbKeyPair).Valor, Integer)
            pRol.Visible = False
        Else
            MessageBox.Show("Error indique un cobrador para asignar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbrol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbrol.SelectedIndexChanged
        If cmbrol.SelectedIndex <> -1 Then
            If CType(CType(cmbrol.SelectedItem, libforms.cmbKeyPair).Valor, Integer) = 2 And editando = False Then
                'lleno el combobox de cobradores
                Dim query = From p In dbContext.Grl_per_personas
                            Join c In dbContext.Pag_cob_cobradores On p.Per_codigo Equals c.Cob_codper
                            Where Not (From u In dbContext.Seg_usu_usuarios Where u.Usu_estado = "A" Select u.Usu_codper).Contains(p.Per_codigo)
                            Select New With {Key .Codigo = p.Per_codigo, Key .Nombre = p.Per_nombre_completo}

                cmbCobrador.Items.Clear()
                For Each elemento In query
                    cmbCobrador.Items.Add(New libforms.cmbKeyPair(elemento.Nombre, elemento.Codigo))
                Next

                pRol.Visible = True
            End If
        End If
    End Sub

End Class
