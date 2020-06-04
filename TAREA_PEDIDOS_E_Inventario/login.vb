Public Class login
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtUsuario.Text = "" Or txtContrasena.Text = "" Then
            MsgBox("Debe ingresar el usuario y la contraseña, Revise!!!")
        End If
        If txtUsuario.Text = "Jackelin" And txtContrasena.Text = "Ca1d3r0n" Then
            principal.Show()
            Me.Hide()
        Else
            MsgBox("El usuario o la contraseña son incorrectos, Revise!!!")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            End
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtUsuario, "Ingrese La contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip.SetToolTip(txtContrasena, "Ingrese La contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEntrar_MouseHover(sender As Object, e As EventArgs) Handles btnEntrar.MouseHover
        ToolTip.SetToolTip(btnEntrar, "Ingrese al menu Principal")
        ToolTip.ToolTipTitle = "Entrar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip.SetToolTip(btnSalir, "Abandona login")
        ToolTip.ToolTipTitle = "Salir"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub
End Class