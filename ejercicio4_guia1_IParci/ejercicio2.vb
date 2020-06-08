Public Class ejercicio2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaracion de las variabes
        Dim a, b, c, x1, x2 As Double
        Try



            If txtA.Text = "" Or txtB.Text = "" Or txtC.Text = "" Then
                MsgBox("llene todos los espacios(A,B,C)", "INGRESO DE DATOS", vbCritical)
            End If
            If txtA.Text = "0" Then
                MsgBox("A debe de ser distinto de O", "INGRESO DE DATOS", vbCritical)
            End If

            a = txtA.Text
            b = txtB.Text
            c = txtC.Text

            If b < (4 * (a * c)) Then
                MsgBox("No es posible realizar la operacion", "INGRESO DE DATOS",)
            Else
                x1 = ((b * (-1)) + (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a)
                x2 = ((b * (-1)) - (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a)

                txtX1.Text = x1
                txtX2.Text = x2
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un erro!!!")
        End Try
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