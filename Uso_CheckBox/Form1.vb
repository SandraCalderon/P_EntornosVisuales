Public Class Form1
    Private Sub chkSuma_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSuma.CheckedChanged
        txtValor1.Focus()

        If chkSuma.Checked = True Then
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkSuma.Checked = False Then
            chkResta.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtValor2.Enabled = True
    End Sub

    Private Sub chkResta_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResta.CheckedChanged
        txtValor1.Focus()

        If chkResta.Checked = True Then
            chkSuma.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkResta.Checked = False Then
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtValor2.Enabled = True
    End Sub

    Private Sub chkMulti_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMulti.CheckedChanged
        txtValor1.Focus()

        If chkMulti.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkDivi.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkMulti.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkDivi.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtValor2.Enabled = True
    End Sub

    Private Sub chkDivi_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDivi.CheckedChanged
        txtValor1.Focus()

        If chkDivi.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkRaiz.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkDivi.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkRaiz.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtValor2.Enabled = True
    End Sub

    Private Sub chkRaiz_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRaiz.CheckedChanged
        txtValor1.Focus()
        If chkRaiz.Checked = True Then
            chkSuma.Enabled = False
            chkMulti.Enabled = False
            chkDivi.Enabled = False
            chkResta.Enabled = False
            chkPotencia.Enabled = False
        End If
        If chkRaiz.Checked = False Then
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkDivi.Enabled = True
            chkResta.Enabled = True
            chkPotencia.Enabled = True
        End If
        txtValor2.Enabled = False
    End Sub

    Private Sub chkPotencia_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPotencia.CheckedChanged
        txtValor1.Focus()

        If chkPotencia.Checked = True Then
            chkSuma.Enabled = False
            chkResta.Enabled = False
            chkMulti.Enabled = False
            chkRaiz.Enabled = False
            chkDivi.Enabled = False
        End If
        If chkPotencia.Checked = False Then
            chkResta.Enabled = True
            chkSuma.Enabled = True
            chkMulti.Enabled = True
            chkRaiz.Enabled = True
            chkDivi.Enabled = True
        End If
        txtValor2.Enabled = True
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'declaracion de variables
        Dim valor1, valor2 As Integer
        Dim respuesta As Double = 0
        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)


        If txtValor1.Text = "" Then
            MsgBox("Debe ingresar el valor 1", vbInformation)
            txtValor1.Focus()
            Exit Sub
        End If
        If txtValor2.Text = "" And chkRaiz.Checked = False Then
            MsgBox("Debe ingresar el valor 2", vbInformation)
            txtValor2.Focus()
            Exit Sub
        End If
        If chkSuma.Checked = False And chkResta.Checked = False And chkMulti.Checked = False And chkDivi.Checked = False And chkRaiz.Checked = False And chkPotencia.Checked = False Then
            MsgBox("Debe seleccionar una operacion a calcular", 64, "ATENCION")
            btnLimpiar.Focus()
            Exit Sub
        End If


        'Calculos
        If chkSuma.Checked = True Then
            respuesta = valor1 + valor2
            txtRespuesta.Text = respuesta
        ElseIf chkResta.Checked = True Then
            respuesta = valor1 - valor2
            txtRespuesta.Text = respuesta
        ElseIf chkMulti.Checked = True Then
            respuesta = valor1 * valor2
            txtRespuesta.Text = respuesta
        ElseIf chkDivi.Checked = True Then
            respuesta = valor1 / valor2
            txtRespuesta.Text = respuesta
        ElseIf chkPotencia.Checked = True Then
            respuesta = valor1 ^ valor2
            txtRespuesta.Text = respuesta
        ElseIf chkRaiz.Checked = True Then
            respuesta = valor1 ^ (1 / 2)
            txtRespuesta.Text = respuesta
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        'limpia los valores
        txtValor1.Clear()
        txtValor2.Clear()
        txtRespuesta.Clear()

        chkSuma.Checked = False
        chkResta.Checked = False
        chkMulti.Checked = False
        chkDivi.Checked = False
        chkPotencia.Checked = False
        chkRaiz.Checked = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            btnLimpiar.Focus()
        Else
            End
        End If
    End Sub
End Class




