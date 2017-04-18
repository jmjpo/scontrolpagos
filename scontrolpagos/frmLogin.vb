Imports MySql.Data.MySqlClient
Imports libforms.libforms
Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.login

        pPrincipal.BackColor = Color.FromArgb(mdPrincipal.Colorpanelprincipal(0), mdPrincipal.Colorpanelprincipal(1), mdPrincipal.Colorpanelprincipal(2))

        btnAceptar.Image = My.Resources.aceptar
        btnCancelar.Image = My.Resources.cancelars

        AddHandler txtusuario.KeyDown, AddressOf libforms.libforms.TxtKeyDown
        AddHandler txtpassword.KeyDown, AddressOf libforms.libforms.TxtKeyDown
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim bandera As Boolean
        Dim con As String

        If txtusuario.Text.Trim.Length > 0 And txtpassword.Text.Trim.Length > 0 Then

            con = ConfigurationManager.ConnectionStrings("cn").ConnectionString
            con = con.Replace("{username}", txtusuario.Text)
            con = con.Replace("{pwd}", txtpassword.Text)

            Dim conexion As New MySqlConnection
            Dim comando As New MySqlCommand

            conexion.ConnectionString = con
            comando.Connection = conexion
            comando.CommandText = "SELECT usu_codigo FROM seg_usu_usuarios WHERE usu_usuario = '" & txtusuario.Text & "' AND usu_password  = '" & txtpassword.Text & "' AND usu_estado = 'A'"

            Try
                conexion.Open()
                icodusu = comando.ExecuteScalar()             
                conexion.Close()

                If icodusu <> 0 Then
                    bandera = True
                Else
                    bandera = False
                End If

            Catch ex As MySqlException
                conexion.Close()
            End Try

            If bandera Then
                'Configuro credenciales usuario
                sUsuario = txtusuario.Text
                sPassword = txtpassword.Text
                sConexion = con

                Me.Visible = False

                'Preparo el dbContext con la conectionstring dinamica
                dbContext = CreateContext()
                frmPrincipal.Show()                
            Else
                MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Indique el usuario y la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmSalir.Show()
    End Sub

End Class