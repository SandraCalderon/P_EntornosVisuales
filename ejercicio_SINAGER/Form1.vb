Public Class Form1
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer

        departamentos = Val(txtDepartamentos.Text)

        If departamentos > 18 Or departamentos < 0 Then
            MessageBox.Show("El numero de departamentos no puede ser un numero entre 1 - 18", "Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDepartamentos.Clear()
            txtDepartamentos.Focus()
            Exit Sub
        End If

        For i = 1 To departamentos Step 1
            Do
                Try
                    mascarillas = InputBox("Ingrese la cantidad de mascarillas(Entre 1 - 10,000)" & i, ", Ingresar")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    mascarillas = -1
                End Try

            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbDepartamento.Items.Add(mascarillas)


        Next
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim cantidadDepartamento, cantidadEntregada As Integer
        Dim idDepartamento As Integer

        cantidadDepartamento = cmbDepartamento.SelectedItem
        idDepartamento = cmbDepartamento.SelectedIndex

        'MsgBox("Numero de municipios: " & numeroMunicipios & "Cantidad asignada a departamentos: " & cantidadDepartamento & "ID departamento: " & idDepartamento)

        Select Case idDepartamento
            Case 0
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 8)
            Case 1
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 10)
            Case 2
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 21)
            Case 3
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 23)
            Case 4
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 12)
            Case 5
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 16)
            Case 6
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 19)
            Case 7
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 28)
            Case 8
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 6)
            Case 9
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 17)
            Case 10
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 4)
            Case 11
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 19)
            Case 12
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 28)
            Case 13
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 16)
            Case 14
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 23)
            Case 15
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 28)
            Case 16
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 9)
            Case 17
                cantidadEntregada = entregaMascarillas(cantidadDepartamento, 11)
            Case Else
                MessageBox.Show("Error, consulte con el encargado", "Entrega de Municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        txtStock.Text = cantidadEntregada
    End Sub

    Private Sub EntregaMascarilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
        txtDepartamentos.Focus()
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        Dim idDepartamento As Integer
        idDepartamento = cmbDepartamento.SelectedIndex
        txtStock.Text = cmbDepartamento.SelectedItem
        Select Case idDepartamento
            Case 0
                txtMunicipios.Text = 8
            Case 1
                txtMunicipios.Text = 10
            Case 2
                txtMunicipios.Text = 21
            Case 3
                txtMunicipios.Text = 23
            Case 4
                txtMunicipios.Text = 12
            Case 5
                txtMunicipios.Text = 16
            Case 6
                txtMunicipios.Text = 19
            Case 7
                txtMunicipios.Text = 28
            Case 8
                txtMunicipios.Text = 6
            Case 9
                txtMunicipios.Text = 17
            Case 10
                txtMunicipios.Text = 4
            Case 11
                txtMunicipios.Text = 19
            Case 12
                txtMunicipios.Text = 28
            Case 13
                txtMunicipios.Text = 16
            Case 14
                txtMunicipios.Text = 23
            Case 15
                txtMunicipios.Text = 28
            Case 16
                txtMunicipios.Text = 9
            Case 17
                txtMunicipios.Text = 11
            Case Else
                MessageBox.Show("Error, consulte con el encargado", "Entrega de Municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Function entregaMascarillas(stock As Integer, cantidadMunicipios As Integer) As Integer
        Dim entregadas As Integer
        For i = 1 To cantidadMunicipios Step 1
            If (stock <= 0) Then
                MessageBox.Show("No quedan mascarillas en inventario. ", "Entrega de Mascarillas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return 0
            End If
            entregadas = InputBox("Ingrese la cantidad de mascarillas para este Municipio " & i, "Asignacion por Municipios")
            stock -= entregadas
            txtStock.Text = stock
        Next
        Return stock
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            End
        End If
    End Sub
End Class
