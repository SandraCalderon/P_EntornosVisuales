Public Class ejercicio2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaracion de las variabes
        Dim A, B, C, D, X1, X2, raiz, multiplicacion, division, potencia As Double

        Try

            If txtA.Text = "" Or txtB.Text = "" Or txtC.Text = "" Then
                MessageBox.Show("Debe llenar todas las casillas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



            A = Val(txtA.Text)
            B = Val(txtB.Text)
            C = Val(txtC.Text)
            D = (B ^ 2) - (4 * A * C)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If D < 0 Then
            MessageBox.Show("No existe una Solucion Real para esta ecuación", "Formula Cuadratica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            txtX1.Clear()
            txtX2.Clear()
            Exit Sub
        End If

        'X1 = -B + ((D) ^ 1 / 2) / 2 * A 
        X1 = ((-1 + B) + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A)
        X2 = -B - ((D) ^ 1 / 2) / 2 * A

        txtX1.Text = X1
        txtX2.Text = X2
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Opcionesvb.Show()
        Me.Hide()
    End Sub







    Private Sub txtA_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtA, "Ingrese El valor de X^2")
        ToolTip.ToolTipTitle = "X^2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtB, "Ingrese El valor de X")
        ToolTip.ToolTipTitle = "X^2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtC_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtC, "Ingrese El valor de x^2")
        ToolTip.ToolTipTitle = "Constante"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub btnCalcular_MouseHover(sender As Object, e As EventArgs) Handles btnCalcular.MouseHover
        ToolTip.SetToolTip(btnCalcular, "Realiza los calculos")
        ToolTip.ToolTipTitle = "Calcular"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Permite crear una nueva ecuacion")
        ToolTip.ToolTipTitle = "Limpiar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip.SetToolTip(btnSalir, "Regresa al menu principal")
        ToolTip.ToolTipTitle = "Envio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtA_MouseHover_1(sender As Object, e As EventArgs) Handles txtA.MouseHover
        ToolTip.SetToolTip(txtA, "Ingrese un numero")
        ToolTip.ToolTipTitle = "Valor A"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_MouseHover_1(sender As Object, e As EventArgs) Handles txtB.MouseHover
        ToolTip.SetToolTip(txtB, "Ingrese un numero")
        ToolTip.ToolTipTitle = "Valor B"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtC_MouseHover_1(sender As Object, e As EventArgs) Handles txtC.MouseHover
        ToolTip.SetToolTip(txtC, "Ingrese un numero")
        ToolTip.ToolTipTitle = "Valor C"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtX1_MouseHover(sender As Object, e As EventArgs) Handles txtX1.MouseHover
        ToolTip.SetToolTip(txtX1, "Muestra el valor de X1")
        ToolTip.ToolTipTitle = "X1"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtX2_MouseHover(sender As Object, e As EventArgs) Handles txtX2.MouseHover
        ToolTip.SetToolTip(txtX2, "Muestra el valor de X2")
        ToolTip.ToolTipTitle = "X2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class