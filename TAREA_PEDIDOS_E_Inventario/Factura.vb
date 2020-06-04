Imports System.ComponentModel

Public Class Factura




    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto1_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto2_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto3_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtProducto4_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub txtProducto5_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio1_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio2_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio3_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio4_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio5_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad1_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad2_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad3_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad4_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad5_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            chkISV.Enabled = False
        Else
            chkISV.Enabled = True
        End If
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            chkDescuento.Enabled = False
        Else
            chkDescuento.Enabled = True
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim subtotal, total, descuento, isv As Double
        Dim precio1, precio2, precio3, precio4, precio5 As Integer
        Dim cantidad1, cantidad2, cantidad3, cantidad4, cantidad5 As Double
        Dim producto1, producto2, producto3, producto4, producto5 As Integer


        precio1 = Val(txtPrecio1.Text)
            precio2 = Val(txtPrecio2.Text)
            precio3 = Val(txtPrecio3.Text)
            precio4 = Val(txtPrecio4.Text)
            precio5 = Val(txtPrecio5.Text)
            cantidad1 = Val(txtCantidad1.Text)
            cantidad2 = Val(txtCantidad2.Text)
            cantidad3 = Val(txtCantidad3.Text)
            cantidad4 = Val(txtCantidad4.Text)
            cantidad5 = Val(txtCantidad5.Text)

        If Not IsNumeric(txtPrecio1.Text) Then
            MsgBox("Ingrese un valor numerico en cantidad", vbInformation)
            txtPrecio1.Focus()
        ElseIf txtPrecio1.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtPrecio1.Focus()
        End If
        If txtFactura.Text = "" Or txtFecha.Text = "" Or txtNombre.Text = "" Or txtHora.Text = "" Then
            MsgBox("Debe ingresar todos los datos revise!!!")
        End If

        If txtCodigo1.Text = "" Then
            MsgBox("Debe ingresar todos el codigo del producto, revise!!!")
        End If

        descuento = 0
            producto1 = precio1 * cantidad1
            producto2 = precio2 * cantidad2
            producto3 = precio3 * cantidad3
            producto4 = precio4 * cantidad4
            producto5 = precio5 * cantidad5

            subtotal = producto1 + producto2 + producto3 + producto4 + producto5
            If chkDescuento.Checked = True Then
                descuento = subtotal * 0.1
            End If
            isv = 0
            If chkISV.Checked = True Then
                isv = subtotal * 0.15
            End If
            total = subtotal - descuento + isv
            txtSubtotal.Text = subtotal
            txtDescuento.Text = descuento
            txtISV.Text = isv
            txtTotal.Text = total

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        principal.Show()
        Me.Hide()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtFactura.Clear()
        txtNombre.Clear()
        txtFecha.Clear()
        txtHora.Clear()
        txtCodigo1.Clear()
        txtCodigo2.Clear()
        txtCodigo3.Clear()
        txtCodigo4.Clear()
        txtCodigo5.Clear()
        txtProducto1.Clear()
        txtProducto2.Clear()
        txtProducto3.Clear()
        txtProducto4.Clear()
        txtProducto5.Clear()
        txtPrecio1.Clear()
        txtPrecio2.Clear()
        txtPrecio3.Clear()
        txtPrecio4.Clear()
        txtPrecio5.Clear()
        txtCantidad1.Clear()
        txtCantidad2.Clear()
        txtCantidad3.Clear()
        txtCantidad4.Clear()
        txtCantidad5.Clear()
        txtSubtotal.Clear()
        txtTotal.Clear()
        txtISV.Clear()
        txtDescuento.Clear()
        If chkDescuento.Checked = True Then
            chkDescuento.Checked = False
        End If
        If chkISV.Checked = True Then
            chkISV.Checked = False
        End If





    End Sub
    Private Function validar(precio1 As Integer) As String
        If Not IsNumeric(txtPrecio1.Text) Then
            Return MsgBox("Ingrese un valor numerico en cantidad", vbInformation)
            txtPrecio1.Focus()
        ElseIf txtPrecio1.Text < 0 Then
            Return MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtPrecio1.Focus()
        End If
        Return 0
    End Function

    Private Sub txtFactura_MouseHover(sender As Object, e As EventArgs) Handles txtFactura.MouseHover
        ToolTip.SetToolTip(txtFactura, "Ingrese el no. de factura")
        ToolTip.ToolTipTitle = "No. Factura"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Sandra Jackelin Calderon Ramirez")
        ToolTip.ToolTipTitle = "Nombre del Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        ToolTip.SetToolTip(txtFecha, "Ingrese la fecha")
        ToolTip.ToolTipTitle = "Fecha"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtHora_MouseHover(sender As Object, e As EventArgs) Handles txtHora.MouseHover
        ToolTip.SetToolTip(txtHora, "Ingrese la hora")
        ToolTip.ToolTipTitle = "Hora"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo1_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo1.MouseHover
        ToolTip.SetToolTip(txtCodigo1, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo2_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo2.MouseHover
        ToolTip.SetToolTip(txtCodigo2, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo3_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo3.MouseHover
        ToolTip.SetToolTip(txtCodigo3, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo4_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo4.MouseHover
        ToolTip.SetToolTip(txtCodigo4, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo5_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo5.MouseHover
        ToolTip.SetToolTip(txtCodigo5, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto1_MouseHover(sender As Object, e As EventArgs) Handles txtProducto1.MouseHover
        ToolTip.SetToolTip(txtProducto1, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto2_MouseHover(sender As Object, e As EventArgs) Handles txtProducto2.MouseHover
        ToolTip.SetToolTip(txtProducto2, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto3_MouseHover(sender As Object, e As EventArgs) Handles txtProducto3.MouseHover
        ToolTip.SetToolTip(txtProducto3, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto4_MouseHover(sender As Object, e As EventArgs) Handles txtProducto4.MouseHover
        ToolTip.SetToolTip(txtProducto4, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto5_MouseHover(sender As Object, e As EventArgs) Handles txtProducto5.MouseHover
        ToolTip.SetToolTip(txtProducto5, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio1_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio1.MouseHover
        ToolTip.SetToolTip(txtPrecio1, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio2_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio2.MouseHover
        ToolTip.SetToolTip(txtPrecio2, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio3_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio3.MouseHover
        ToolTip.SetToolTip(txtPrecio3, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio4_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio4.MouseHover
        ToolTip.SetToolTip(txtPrecio4, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio5_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio5.MouseHover
        ToolTip.SetToolTip(txtPrecio5, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad1_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad1.MouseHover
        ToolTip.SetToolTip(txtCantidad1, "Ingrese la cantidad de productos")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad2_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad2.MouseHover
        ToolTip.SetToolTip(txtCantidad2, "Ingrese la cantidad de productos")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad3_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad3.MouseHover
        ToolTip.SetToolTip(txtCantidad3, "Ingrese la cantidad de productos")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad4_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad4.MouseHover
        ToolTip.SetToolTip(txtCantidad4, "Ingrese la cantidad de productos")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad5_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad5.MouseHover
        ToolTip.SetToolTip(txtCantidad5, "Ingrese la cantidad de productos")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkDescuento_MouseHover(sender As Object, e As EventArgs) Handles chkDescuento.MouseHover
        ToolTip.SetToolTip(chkDescuento, "Aplica un descuento del 10%")
        ToolTip.ToolTipTitle = "Descuento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkISV_MouseHover(sender As Object, e As EventArgs) Handles chkISV.MouseHover
        ToolTip.SetToolTip(chkISV, "Aplica un ISV del 15%")
        ToolTip.ToolTipTitle = "ISV"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btncalcular_MouseHover(sender As Object, e As EventArgs) Handles btncalcular.MouseHover
        ToolTip.SetToolTip(btncalcular, "Realiza los calculos")
        ToolTip.ToolTipTitle = "Calcular"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ToolTip.SetToolTip(btnNuevo, "Realiza una nueva factura")
        ToolTip.ToolTipTitle = "Nuevo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegresar_MouseHover(sender As Object, e As EventArgs) Handles btnRegresar.MouseHover
        ToolTip.SetToolTip(btnRegresar, "Regresa al menu principal")
        ToolTip.ToolTipTitle = "Regresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class