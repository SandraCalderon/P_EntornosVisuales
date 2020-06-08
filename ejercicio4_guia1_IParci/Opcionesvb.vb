Public Class Opcionesvb
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then

            End
        End If
    End Sub

    Private Sub CalculadoraBasicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraBasicaToolStripMenuItem.Click
        ejercicio01.Show()
        Me.Hide()
    End Sub

    Private Sub FormulaGeneralCuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaGeneralCuadraticaToolStripMenuItem.Click
        ejercicio2.Show()
        Me.Hide()
    End Sub

    Private Sub CalculoDeLaMediaDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeLaMediaDeVentasToolStripMenuItem.Click
        Ejercici3.Show()
        Me.Hide()
    End Sub

    Private Sub IngresoDeNumerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeNumerosToolStripMenuItem.Click
        Ejercici04.Show()
        Me.Hide()
    End Sub
End Class