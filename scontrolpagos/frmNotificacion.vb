Imports libforms.libforms
Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Public Class frmNotificacion

    Dim sarchivo As String

    Private Sub frmNotificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.notificacion

        btnEnviar.Image = My.Resources.enviar
        btnAdjunto.Image = My.Resources.adjunto

        'Carga el listado de socios
        Dim query = From s In dbContext.Soc_soc_socios
                    Join p In dbContext.Grl_per_personas On p.Per_codigo Equals s.Soc_codper
                    Where s.Soc_estado = "A"
                    Select New With {Key .Codigo = s.Soc_codigo_armado, Key .Nombre = p.Per_nombre_completo, Key .Correo = p.Per_correo_electronico}

        dgSocios.DataSource = query.ToList

        'agrego columna con checkbox al grid
        Dim chkSelect As New DataGridViewCheckBoxColumn()
        chkSelect.HeaderText = "Notificar"
        chkSelect.Name = "chkSelect"
        chkSelect.Selected = False
        dgSocios.Columns.Insert(3, chkSelect)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Mail As New MailMessage
        Dim SMTP As New SmtpClient(ConfigurationManager.AppSettings("correoserver"))        
        Dim slogin As String
        Dim totdestinatarios As Integer

        slogin = ConfigurationManager.AppSettings("correoremitente").Remove(ConfigurationManager.AppSettings("correoremitente").IndexOf("@"))
        Mail.From = New MailAddress(ConfigurationManager.AppSettings("correoremitente"))
        SMTP.Credentials = New System.Net.NetworkCredential(slogin, ConfigurationManager.AppSettings("correopassword"))

        For Each dr As DataGridViewRow In dgSocios.Rows
            If dr.Cells(3).Value = True Then
                If Not IsDBNull(dr.Cells("Correo").Value) Then
                    If dr.Cells("Correo").Value.ToString.Length > 0 Then
                        Mail.Bcc.Add(dr.Cells("Correo").Value)
                        totdestinatarios += 1
                    End If
                End If
            End If
        Next

        If totdestinatarios > 0 Then
            If txtAsunto.Text.Trim.Length > 0 Then
                Mail.Subject = txtAsunto.Text
                Mail.Body = txtMensaje.Text

                SMTP.EnableSsl = True
                SMTP.Port = ConfigurationManager.AppSettings("correopuerto")

                If txtadjunto.Text.Length > 0 Then
                    Dim farchivo As New IO.FileInfo(txtadjunto.Text)

                    If farchivo.Exists Then
                        Mail.Attachments.Add(New System.Net.Mail.Attachment(txtadjunto.Text))
                    End If
                End If

                Try
                    ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf customCertValidation)
                    SMTP.Send(Mail)

                    MessageBox.Show("Mensaje enviado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error al enviar la notificacion" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Indique el asunto del correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Indique por lo menos un destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        For Each dr As DataGridViewRow In dgSocios.Rows
            dr.Cells(3).Value = chktodos.Checked
        Next
    End Sub

    Private Sub btnAdjunto_Click(sender As Object, e As EventArgs) Handles btnAdjunto.Click
        Dim ofdAbrir As New OpenFileDialog()

        ofdAbrir.Filter = "Todos los Archivos|*.*"
        ofdAbrir.RestoreDirectory = True

        If ofdAbrir.ShowDialog(Me) = DialogResult.OK Then
            Dim fileInfo As New FileInfo(ofdAbrir.FileName)

            If fileInfo.Length <= 1048576 Then
                sarchivo = ofdAbrir.FileName
                txtadjunto.Text = sarchivo
            Else
                MessageBox.Show("El tamaño del archivo adjunto debe ser menor a 1MB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'validacion de certificado
    Private Shared Function customCertValidation(ByVal sender As Object, _
                                                ByVal cert As X509Certificate, _
                                                ByVal chain As X509Chain, _
                                                ByVal errors As SslPolicyErrors) As Boolean

        Return True
    End Function

End Class