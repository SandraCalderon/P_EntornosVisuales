Public Class REGISTRO_PEDIDOS
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub chkdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkdescuento.CheckedChanged
        If chkdescuento.Checked = True Then
            cmbDescuento.Enabled = True
        Else
            cmbDescuento.Enabled = False
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim subtotal, total As Double
        Dim precio, cantidad As Integer
        Dim aplicarDescuento As Boolean
        Dim descuento As Double
        Dim envio As Integer
        precio = Val(txtPrecio.Text)
        cantidad = Val(txtCantidad.Text)
        If Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor numerico en precio", vbInformation)
            txtPrecio.Focus()
        ElseIf txtPrecio.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtPrecio.Focus()
        End If

        If chkdescuento.Checked = True And cmbDescuento.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar el valor del descuento a aplicar", 64, "ATENCION")
            cmbDescuento.Focus()
            Exit Sub
        End If
        If txtPedido.Text = "" Or txtFecha.Text = "" Or txtNombre.Text = "" Or txtProducto.Text = "" Then
            MsgBox("Debe ingresar todos los datos revise!!!")
        End If
        aplicarDescuento = chkdescuento.Checked


        subtotal = precio * cantidad
        If aplicarDescuento = True Then
            Select Case cmbDescuento.SelectedIndex
                Case 0
                    descuento = subtotal * 0.05
                Case 1
                    descuento = subtotal * 0.1
                Case 2
                    descuento = subtotal * 0.2
            End Select
        Else
            descuento = subtotal * 0.0
        End If

        If chkEnvio.Checked = True Then
            envio = subtotal + 80
            txtEnvio.Text = 80
        Else
            envio = subtotal + 0
            txtEnvio.Text = 0
        End If

        total = envio - descuento
        txtSubtotal.Text = subtotal
        txtdescuento.Text = descuento
        txtTotal.Text = total


    End Sub

    Private Sub btncalcular_MouseHover(sender As Object, e As EventArgs) Handles btncalcular.MouseHover
        ToolTip.SetToolTip(btncalcular, "Realiza los calculos")
        ToolTip.ToolTipTitle = "Calcular"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Permite crear un nuevo pedido")
        ToolTip.ToolTipTitle = "Nuevo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegresar_MouseHover(sender As Object, e As EventArgs) Handles btnRegresar.MouseHover
        ToolTip.SetToolTip(btnRegresar, "Regresa al menu principal")
        ToolTip.ToolTipTitle = "Regresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPedido.Clear()
        txtFecha.Clear()
        txtNombre.Clear()
        txtProducto.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtdescripcion.Clear()
        txtSubtotal.Clear()
        txtdescuento.Clear()
        txtEnvio.Clear()
        txtTotal.Clear()
        If chkdescuento.Checked = True Then
            chkdescuento.Checked = False
        End If
        If chkEnvio.Checked = True Then
            chkEnvio.Checked = False
        End If
    End Sub

    Private Sub txtPedido_MouseHover(sender As Object, e As EventArgs) Handles txtPedido.MouseHover
        ToolTip.SetToolTip(txtPedido, "Ingrese el no. de pedido")
        ToolTip.ToolTipTitle = "No. Pedido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        ToolTip.SetToolTip(txtFecha, "Ingrese la fecha de entrega del pedido")
        ToolTip.ToolTipTitle = "Fecha entrega"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Sandra Jackelin Calderón Ramirez")
        ToolTip.ToolTipTitle = "Nombre del Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        ToolTip.SetToolTip(txtProducto, "Ejemplo: Azucar")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Ingrese un numero entero")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        ToolTip.SetToolTip(txtdescripcion, "Ingrese una descripcion del producto o del envio")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkdescuento_MouseHover(sender As Object, e As EventArgs) Handles chkdescuento.MouseHover
        ToolTip.SetToolTip(chkdescuento, "Aplica un descuento")
        ToolTip.ToolTipTitle = "Descuento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkEnvio_MouseHover(sender As Object, e As EventArgs) Handles chkEnvio.MouseHover
        ToolTip.SetToolTip(chkEnvio, "Aplica un costo por envio")
        ToolTip.ToolTipTitle = "Envio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class