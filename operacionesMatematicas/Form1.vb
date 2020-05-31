Public Class Form1
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'inicio
        'declaracion de variables
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim divide As Double
        Dim multi As Integer


        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'proceso
        suma = valor1 + valor2
        resta = valor1 - valor2
        multi = valor1 * valor2
        divide = valor1 / valor2
        If valor2 = 0 Then
            MsgBox("No se puede dividir entre 0")
        ElseIf valor2 <> 0 Then
            txtDivide.Text = divide
        End If
        'salida
        txtSuma.Text = suma
        txtResta.Text = resta
        txtMulti.Text = multi



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'se puede limpiar de dos formas
        'ejemplo
        'txtSuma.Clear()
        'txtSuma.Text = " "
        txtSuma.Clear()
        txtResta.Clear()
        txtMulti.Text = " "
        txtDivide.Text = "  "
        txtValor1.Text = " "
        txtValor2.Text = " "
        txtValor1.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

