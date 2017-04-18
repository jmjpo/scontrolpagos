Public Class frmPrincipal

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Frmsalir.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(mdPrincipal.Colorformulario(0), mdPrincipal.Colorformulario(1), mdPrincipal.Colorformulario(2))
        Me.Icon = My.Resources.menu

        llenarmenu()
    End Sub

    Private Sub nMenu_Click(sender As Object, e As EventArgs)
        Dim f As New Form

        f = GetFormByName(sender.name)
        f.ShowDialog(Me)
    End Sub

    Private Function GetFormByName(ByVal FormName As String) As Form
        Dim Fullname As String = Application.ProductName & "." & FormName
        Return Activator.CreateInstance(Type.GetType(Fullname, True, True))
    End Function

    Private Sub llenarmenu()
        Dim query = From opc In dbContext.Seg_opc_opciones
                        Join oxm In dbContext.Seg_oxm_opciones_x_menus
                        On oxm.Oxm_codopc Equals opc.Opc_codigo
                        Join men In dbContext.Seg_men_menus
                        On oxm.Oxm_codmen Equals men.Men_codigo
                        Join aro In dbContext.Seg_aro_autorizaciones_roles
                        On aro.Aro_codopc Equals opc.Opc_codigo
                        Join uxr In dbContext.Seg_uxr_usuarios_x_roles
                        On uxr.Uxr_codrol Equals aro.Aro_codrol
                        Order By men.Men_codmen_padre, men.Men_orden, oxm.Oxm_orden
                        Where uxr.Uxr_codusu = icodusu
                        Select men.Men_codigo, men.Men_descripcion, men.Men_codmen_padre, _
                               men.Men_orden, opc.Opc_codigo, opc.Opc_descripcion, opc.Opc_formulario, _
                               oxm.Oxm_orden

        For Each elemento In query.Distinct.ToList
            Dim ban As Boolean
            Dim smenu As New ToolStripMenuItem(elemento.Men_descripcion)

            For Each itm As ToolStripMenuItem In nMenu.Items
                If itm.Text = elemento.Men_descripcion Then
                    smenu = itm
                    Exit For
                End If
            Next

            If Not ban Then
                nMenu.Items.Add(smenu)

                Dim selemento As New ToolStripMenuItem
                selemento.Text = elemento.Opc_descripcion
                selemento.Name = elemento.Opc_formulario
                AddHandler selemento.Click, AddressOf nMenu_Click

                smenu.DropDownItems.Add(selemento)
            Else
                Dim selemento As New ToolStripMenuItem
                selemento.Text = elemento.Opc_descripcion
                AddHandler selemento.Click, AddressOf nMenu_Click

                smenu.DropDownItems.Add(elemento.Opc_descripcion)
            End If
        Next

        Dim selementoSalir As New ToolStripMenuItem
        selementoSalir.Text = "Salir"
        selementoSalir.Name = "frmSalir"
        AddHandler selementoSalir.Click, AddressOf nMenu_Click

        nMenu.Items.Add(selementoSalir)       
    End Sub

End Class