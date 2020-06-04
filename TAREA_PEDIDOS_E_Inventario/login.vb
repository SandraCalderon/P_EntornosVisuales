Public Class login
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

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
End Class