Public Class Form1
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'DECLARACION DE VARIABLES
        Dim pUnitario, cantidad As Integer
        Dim descuento, subTotal, total, ISV As Double
        Dim aplicarDescuento, aplicarISV As Double

        'VALIDAR VARIABLES
        pUnitario = Val(txtPrecio.Text)
        cantidad = Val(txtCantidad.Text)

        'VALIDACIONES

        If txtPrecio.Text = "" Then
            MsgBox("Debe ingresar el P. Unitario", vbInformation)
            txtPrecio.Focus()
            Exit Sub
        End If
        If txtCantidad.Text = "" Then
            MsgBox("Debe ingresar la cantidad", vbInformation)
            txtCantidad.Focus()
            Exit Sub
        End If
        If chkDescuento.Checked = True And cmbDescuento.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar el valor del descuento a aplicar", 64, "ATENCION")
            cmbDescuento.Focus()
            Exit Sub
        End If
        If chkISV.Checked = True And cmbISV.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar el valor del ISV a aplicar", 64, "ATENCION")
            chkISV.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico en cantidad", vbInformation)
            txtCantidad.Focus()
        ElseIf txtCantidad.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtCantidad.Focus()
        End If
        If Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor numerico en P. Unitario", vbInformation)
            txtPrecio.Focus()
        ElseIf txtPrecio.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtPrecio.Focus()
        End If


        'PROCEDIMIENTO
        aplicarDescuento = chkDescuento.Checked
        descuento = 0

        subTotal = pUnitario * cantidad
        If aplicarDescuento = True Then
            Select Case cmbDescuento.SelectedIndex
                Case 0
                    descuento = subTotal * 0.05
                Case 1
                    descuento = subTotal * 0.1
                Case 2
                    descuento = subTotal * 0.15
                Case 3
                    descuento = subTotal * 0.2
                Case 4
                    descuento = subTotal * 0.3
                Case 5
                    descuento = subTotal * 0.4
            End Select

        End If


        aplicarISV = chkISV.Checked
        ISV = 0

        If aplicarISV = True Then
            Select Case cmbISV.SelectedIndex
                Case 0
                    ISV = subTotal * 0.15
                Case 1
                    ISV = subTotal * 0.17
            End Select

        End If



        'SALIDA
        total = subTotal - descuento + ISV

        txtsubtotal.Text = subTotal
        txtDescuento.Text = descuento
        txtISV.Text = ISV
        txtTotal.Text = total

        btnNuevo.Enabled = True

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            txtPrecio.Focus()
        Else
            End
        End If
    End Sub

    Private Sub chkDescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDescuento.CheckedChanged

        If chkDescuento.Checked = True Then
            cmbDescuento.Enabled = True
            chkISV.Enabled = False
        Else
            cmbDescuento.Enabled = False
            chkISV.Enabled = True
            cmbDescuento.SelectedIndex = -1
        End If




    End Sub

    Private Sub cmbISV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbISV.SelectedIndexChanged

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtDescuento.Clear()
        txtsubtotal.Clear()
        txtISV.Clear()
        txtTotal.Clear()
        chkDescuento.Checked = False
        chkISV.Checked = False
        cmbDescuento.SelectedIndex = -1
        cmbISV.SelectedIndex = -1
        txtPrecio.Focus()
        btnNuevo.Enabled = False
    End Sub

    Private Sub chkISV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            cmbISV.Enabled = True
            chkDescuento.Enabled = False
        Else
            cmbISV.Enabled = False
            chkDescuento.Enabled = True
            cmbISV.SelectedIndex = -1
        End If
    End Sub
End Class
