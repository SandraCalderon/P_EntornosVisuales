Public Class Ejercici3



    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim almacen1, almacen2, almacen3, almacen4, almacen5, almacen6, almacen7, almacen8, almacen9, almacen10 As Integer
        Dim media As Integer
        Try

            If Not IsNumeric(txtAlmacen1.Text) Or txtAlmacen1.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen1.Focus()
            ElseIf txtAlmacen1.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen1.Focus()
            ElseIf Not IsNumeric(txtAlmacen2.Text) Or txtAlmacen2.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen2.Focus()
            ElseIf txtAlmacen2.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen1.Focus()
            ElseIf Not IsNumeric(txtAlmacen3.Text) Or txtAlmacen3.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen3.Focus()
            ElseIf txtAlmacen3.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen3.Focus()

            ElseIf Not IsNumeric(txtAlmacen4.Text) Or txtAlmacen4.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen4.Focus()
            ElseIf txtAlmacen4.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen4.Focus()

            ElseIf Not IsNumeric(txtAlmacen5.Text) Or txtAlmacen5.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen5.Focus()
            ElseIf txtAlmacen5.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen5.Focus()

            ElseIf Not IsNumeric(txtAlmacen6.Text) Or txtAlmacen6.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen6.Focus()
            ElseIf txtAlmacen6.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen6.Focus()

            ElseIf Not IsNumeric(txtAlmacen7.Text) Or txtAlmacen7.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen7.Focus()
            ElseIf txtAlmacen7.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen7.Focus()

            ElseIf Not IsNumeric(txtAlmacen8.Text) Or txtAlmacen8.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen8.Focus()
            ElseIf txtAlmacen8.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen8.Focus()
            ElseIf Not IsNumeric(txtAlmacen9.Text) Or txtAlmacen9.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen9.Focus()
            ElseIf txtAlmacen9.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen9.Focus()

            ElseIf Not IsNumeric(txtAlmacen10.Text) Or txtAlmacen10.Text = "" Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtAlmacen10.Focus()
            ElseIf txtAlmacen10.Text < 0 Then
                MsgBox("No se aceptan numeros negativos!!!", vbInformation)
                txtAlmacen10.Focus()
            Else
                almacen1 = Val(txtAlmacen1.Text)
                almacen2 = Val(txtAlmacen2.Text)
                almacen3 = Val(txtAlmacen3.Text)
                almacen4 = Val(txtAlmacen4.Text)
                almacen5 = Val(txtAlmacen5.Text)
                almacen6 = Val(txtAlmacen6.Text)
                almacen7 = Val(txtAlmacen7.Text)
                almacen8 = Val(txtAlmacen8.Text)
                almacen9 = Val(txtAlmacen9.Text)
                almacen10 = Val(txtAlmacen10.Text)


                media = (almacen1 + almacen2 + almacen3 + almacen4 + almacen5 + almacen6 + almacen7 + almacen8 + almacen9 + almacen10) / 10

                txtMedia.Text = media


                If (almacen1 >= media) Then
                    cmbMedia.Items.Add("Almacen 1 =" & almacen1)
                End If
                If (almacen2 >= media) Then
                    cmbMedia.Items.Add("Almacen 2 =" & almacen2)
                End If
                If (almacen3 >= media) Then
                    cmbMedia.Items.Add("Almacen 3 =" & almacen3)
                End If
                If (almacen4 >= media) Then
                    cmbMedia.Items.Add("Almacen 4 =" & almacen4)
                End If
                If (almacen5 >= media) Then
                    cmbMedia.Items.Add("Almacen 5 =" & almacen5)
                End If
                If (almacen6 >= media) Then
                    cmbMedia.Items.Add("Almacen 6 =" & almacen6)
                End If
                If (almacen7 >= media) Then
                    cmbMedia.Items.Add("Almacen 7 =" & almacen7)
                End If
                If (almacen8 >= media) Then
                    cmbMedia.Items.Add("Almacen 8 =" & almacen8)
                End If
                If (almacen9 >= media) Then
                    cmbMedia.Items.Add("Almacen 9 =" & almacen9)
                End If
                If (almacen10 >= media) Then
                    cmbMedia.Items.Add("Almacen 10 =" & almacen10)
                End If
            End If
        Catch ex As Exception

        End Try





    End Sub

    Private Sub Ejercici3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Opcionesvb.Show()
        Me.Hide()
    End Sub
    Private Sub Validar()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtAlmacen1.Clear()
        txtAlmacen2.Clear()
        txtAlmacen3.Clear()
        txtAlmacen4.Clear()
        txtAlmacen5.Clear()
        txtAlmacen6.Clear()
        txtAlmacen7.Clear()
        txtAlmacen8.Clear()
        txtAlmacen9.Clear()
        txtAlmacen10.Clear()
        txtMedia.Clear()
        cmbMedia.Items.Clear()

    End Sub

    Private Sub txtAlmacen1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen6_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen6.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen7_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen7.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen8_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen8.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen9_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen9.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtAlmacen10_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAlmacen10.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnCalcular_MouseHover(sender As Object, e As EventArgs) Handles btnCalcular.MouseHover
        ToolTip.SetToolTip(btnCalcular, "Realiza los calculos")
        ToolTip.ToolTipTitle = "Calcular"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip.SetToolTip(btnSalir, "Abandona Control de Almacenes")
        ToolTip.ToolTipTitle = "Salir"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ToolTip.SetToolTip(btnNuevo, "Crea un nuevo control de almacenes")
        ToolTip.ToolTipTitle = "Nuevo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen1_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen1.MouseHover
        ToolTip.SetToolTip(txtAlmacen1, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 1"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen2_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen2.MouseHover
        ToolTip.SetToolTip(txtAlmacen2, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 2"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen3_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen3.MouseHover
        ToolTip.SetToolTip(txtAlmacen3, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 3"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen4_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen4.MouseHover
        ToolTip.SetToolTip(txtAlmacen4, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 4"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen5_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen5.MouseHover
        ToolTip.SetToolTip(txtAlmacen5, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 5"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen6_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen6.MouseHover
        ToolTip.SetToolTip(txtAlmacen6, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 6"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen7_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen7.MouseHover
        ToolTip.SetToolTip(txtAlmacen7, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 7"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen8_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen8.MouseHover
        ToolTip.SetToolTip(txtAlmacen8, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 8"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen9_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen9.MouseHover
        ToolTip.SetToolTip(txtAlmacen9, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 9"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAlmacen10_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen10.MouseHover
        ToolTip.SetToolTip(txtAlmacen10, "Debe ingresar un numero entero")
        ToolTip.ToolTipTitle = "Almacen 10"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMedia_MouseHover(sender As Object, e As EventArgs) Handles txtMedia.MouseHover
        ToolTip.SetToolTip(txtMedia, "Muestra la media de ventas")
        ToolTip.ToolTipTitle = "Media"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbMedia_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtAlmacen1, "Muestra los almacenes que estan arriba de la media")
        ToolTip.ToolTipTitle = "Almacenes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class