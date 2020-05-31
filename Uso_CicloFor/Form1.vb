Imports System.ComponentModel

Public Class Form1




    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        Dim num As Integer
        Dim x As Integer
        num = Val(txtNumero.Text)
        txtTabla.Text = ""

        If num < 10 And num > 0 Then
            For x = 1 To 10
                txtTabla.Text = txtTabla.Text & num & " * " & x & " = " & num * x & vbCrLf
            Next
        Else
            If Not IsNumeric(txtNumero.Text) Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtNumero.Focus()
            ElseIf txtNumero.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtNumero.Focus()
            ElseIf txtNumero.Text = "" Then
                MsgBox("Debe ingresar un numero entero!!!", vbInformation)
                txtNumero.Focus()
            ElseIf txtNumero.Text = 0 Or txtNumero.Text > 9 Then
                MsgBox("Debe ingresar un numero entre 1-9!!!", vbInformation)
                txtNumero.Focus()
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTabla.Clear()
        txtNumero.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String



        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            txtNumero.Focus()
        Else
            End
        End If
    End Sub



    Private Sub txtNumero_Validating(sender As Object, e As CancelEventArgs) Handles txtNumero.Validating
        If Val(txtNumero.Text) - Int(Val(txtNumero.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub btnGenerar_MouseHover(sender As Object, e As EventArgs) Handles btnGenerar.MouseHover
        ToolTip1.SetToolTip(btnGenerar, "Genera la tabla de multiplicación")
        ToolTip1.ToolTipTitle = "Generar"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip1.SetToolTip(btnLimpiar, "Limpia las cajas de texto")
        ToolTip1.ToolTipTitle = "Limpiar"

        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip1.SetToolTip(btnSalir, "Abandona Uso de ciclo for")
        ToolTip1.ToolTipTitle = "Generar"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtNumero_MouseHover(sender As Object, e As EventArgs) Handles txtNumero.MouseHover
        ToolTip1.SetToolTip(txtNumero, "Numero entero")

        ToolTip1.ToolTipTitle = "Ejemplo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
