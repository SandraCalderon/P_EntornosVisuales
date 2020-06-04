Public Class Registro_producto
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        principal.Show()
        Me.Hide()
    End Sub
    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        ToolTip.SetToolTip(btnNuevo, "Realiza el registro deun nuevo producto")
        ToolTip.ToolTipTitle = "Nuevo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegresar_MouseHover(sender As Object, e As EventArgs) Handles btnRegresar.MouseHover
        ToolTip.SetToolTip(btnRegresar, "Regresa al menu principal")
        ToolTip.ToolTipTitle = "Regresar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        ToolTip.SetToolTip(btnGuardar, "Guarda los datos ingresados")
        ToolTip.ToolTipTitle = "Guardar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtProducto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub txtCompra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCompra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtFecha.Clear()
        txtDescripcion.Clear()
        txtCompra.Clear()
        txtVenta.Clear()
        txtProducto.Clear()
        txtExistencia.Clear()
        cmbCategoria.SelectedIndex = -1
    End Sub

    Private Sub txtExistencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtExistencia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtanadir_Click(sender As Object, e As EventArgs) Handles txtanadir.Click
        'For, DoWhile
        Dim Almacenes As Integer
        Dim nombreAlmacen As String
        Almacenes = Val(txtAlmacen.Text)
        For i = 1 To Almacenes Step 1

            nombreAlmacen = InputBox("Ingrese el nombre del almacen" & i, ", Ingresar")
            cmbAlmacen.Items.Add(nombreAlmacen)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not IsNumeric(txtExistencia.Text) Then
            MsgBox("Ingrese un valor numerico en existencia", vbInformation)
            txtExistencia.Focus()
        ElseIf txtExistencia.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtExistencia.Focus()
        End If
        If Not IsNumeric(txtAlmacen.Text) Then
            MsgBox("Ingrese un valor numerico en cantidad almacen", vbInformation)
            txtAlmacen.Focus()
        ElseIf txtAlmacen.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtAlmacen.Focus()
        End If
        If Not IsNumeric(txtCompra.Text) Then
            MsgBox("Ingrese un valor numerico en Valor de Compra", vbInformation)
            txtCompra.Focus()
        ElseIf txtAlmacen.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtCompra.Focus()
        End If
        If Not IsNumeric(txtVenta.Text) Then
            MsgBox("Ingrese un valor numerico en Valor de Venta", vbInformation)
            txtVenta.Focus()
        ElseIf txtVenta.Text < 0 Then
            MsgBox("No se aceptan numeros negativos!!!", vbInformation)
            txtVenta.Focus()
        End If

        If txtCodigo.Text = "" Or txtProducto.Text = "" Or txtDescripcion.Text = "" Or txtExistencia.Text = "" Or txtAlmacen.Text = "" Or txtCompra.Text = "" Or txtVenta.Text = "" Or txtFecha.Text = "" Then
            MsgBox("Debe ingresar todos los datos revise!!!")
        End If



    End Sub

    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo.MouseHover
        ToolTip.SetToolTip(txtCodigo, "Ingrese el Codigo del producto")
        ToolTip.ToolTipTitle = "No. Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        ToolTip.SetToolTip(txtProducto, "Ingrese el nombre del producto")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese la descripcion del producto")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtExistencia_MouseHover(sender As Object, e As EventArgs) Handles txtExistencia.MouseHover
        ToolTip.SetToolTip(txtExistencia, "Ingrese la existencia del producto")
        ToolTip.ToolTipTitle = "Existencia"
        ToolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtAlmacen_MouseHover(sender As Object, e As EventArgs) Handles txtAlmacen.MouseHover
        ToolTip.SetToolTip(txtAlmacen, "Ingrese la cantidad de almacenes a los que sera distribuido el producto")
        ToolTip.ToolTipTitle = "Cantidad Almacen"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCompra_MouseHover(sender As Object, e As EventArgs) Handles txtCompra.MouseHover
        ToolTip.SetToolTip(txtCompra, "Ingrese precio de compra  del producto")
        ToolTip.ToolTipTitle = "Compra"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtVenta_MouseHover(sender As Object, e As EventArgs) Handles txtVenta.MouseHover
        ToolTip.SetToolTip(txtVenta, "Ingrese precio de venta del producto")
        ToolTip.ToolTipTitle = "Venta"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtFecha_MouseHover(sender As Object, e As EventArgs) Handles txtFecha.MouseHover
        ToolTip.SetToolTip(txtFecha, "Ingrese la fecha de vencimiento  del producto")
        ToolTip.ToolTipTitle = "Fecha:"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtanadir_MouseHover(sender As Object, e As EventArgs) Handles txtanadir.MouseHover
        ToolTip.SetToolTip(txtCompra, "Ingrese el nombre de los almacenes a los que sera distribuido el producto de manera equitativa")
        ToolTip.ToolTipTitle = "Añadir"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class