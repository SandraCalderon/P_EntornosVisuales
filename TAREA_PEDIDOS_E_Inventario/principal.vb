Public Class principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            End
        End If

    End Sub

    Private Sub GenerarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarFacturaToolStripMenuItem.Click
        Factura.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProductosToolStripMenuItem.Click
        Registro_producto.Show()
        Me.Hide()
    End Sub

    Private Sub RegistroDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDePedidosToolStripMenuItem.Click
        REGISTRO_PEDIDOS.Show()
        Me.Hide()

    End Sub
End Class
