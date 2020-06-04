<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.txtPrecio5 = New System.Windows.Forms.TextBox()
        Me.txtPrecio4 = New System.Windows.Forms.TextBox()
        Me.txtPrecio3 = New System.Windows.Forms.TextBox()
        Me.txtPrecio2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProducto5 = New System.Windows.Forms.TextBox()
        Me.txtProducto4 = New System.Windows.Forms.TextBox()
        Me.txtProducto3 = New System.Windows.Forms.TextBox()
        Me.txtProducto2 = New System.Windows.Forms.TextBox()
        Me.txtProducto1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo5 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.chkISV = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantidad2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantidad3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantidad4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCantidad5 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales:"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(373, 53)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 5
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(373, 16)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(119, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(147, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(92, 19)
        Me.txtFactura.Mask = "9999"
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Completo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox2.Controls.Add(Me.txtCantidad5)
        Me.GroupBox2.Controls.Add(Me.txtCantidad4)
        Me.GroupBox2.Controls.Add(Me.txtCantidad3)
        Me.GroupBox2.Controls.Add(Me.txtCantidad2)
        Me.GroupBox2.Controls.Add(Me.txtCantidad1)
        Me.GroupBox2.Controls.Add(Me.txtPrecio1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.txtPrecio5)
        Me.GroupBox2.Controls.Add(Me.txtPrecio4)
        Me.GroupBox2.Controls.Add(Me.txtPrecio3)
        Me.GroupBox2.Controls.Add(Me.txtPrecio2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtProducto5)
        Me.GroupBox2.Controls.Add(Me.txtProducto4)
        Me.GroupBox2.Controls.Add(Me.txtProducto3)
        Me.GroupBox2.Controls.Add(Me.txtProducto2)
        Me.GroupBox2.Controls.Add(Me.txtProducto1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCodigo5)
        Me.GroupBox2.Controls.Add(Me.txtCodigo4)
        Me.GroupBox2.Controls.Add(Me.txtCodigo3)
        Me.GroupBox2.Controls.Add(Me.txtCodigo2)
        Me.GroupBox2.Controls.Add(Me.txtCodigo1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 197)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra de Productos:"
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Location = New System.Drawing.Point(373, 55)
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Size = New System.Drawing.Size(89, 20)
        Me.txtPrecio1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(487, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(488, 218)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(89, 20)
        Me.TextBox15.TabIndex = 19
        '
        'txtPrecio5
        '
        Me.txtPrecio5.Location = New System.Drawing.Point(373, 159)
        Me.txtPrecio5.Name = "txtPrecio5"
        Me.txtPrecio5.Size = New System.Drawing.Size(89, 20)
        Me.txtPrecio5.TabIndex = 17
        '
        'txtPrecio4
        '
        Me.txtPrecio4.Location = New System.Drawing.Point(373, 133)
        Me.txtPrecio4.Name = "txtPrecio4"
        Me.txtPrecio4.Size = New System.Drawing.Size(89, 20)
        Me.txtPrecio4.TabIndex = 16
        '
        'txtPrecio3
        '
        Me.txtPrecio3.Location = New System.Drawing.Point(373, 107)
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Size = New System.Drawing.Size(89, 20)
        Me.txtPrecio3.TabIndex = 15
        '
        'txtPrecio2
        '
        Me.txtPrecio2.Location = New System.Drawing.Point(373, 81)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Size = New System.Drawing.Size(89, 20)
        Me.txtPrecio2.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Precio:"
        '
        'txtProducto5
        '
        Me.txtProducto5.Location = New System.Drawing.Point(151, 159)
        Me.txtProducto5.Name = "txtProducto5"
        Me.txtProducto5.Size = New System.Drawing.Size(202, 20)
        Me.txtProducto5.TabIndex = 11
        '
        'txtProducto4
        '
        Me.txtProducto4.Location = New System.Drawing.Point(151, 133)
        Me.txtProducto4.Name = "txtProducto4"
        Me.txtProducto4.Size = New System.Drawing.Size(202, 20)
        Me.txtProducto4.TabIndex = 10
        '
        'txtProducto3
        '
        Me.txtProducto3.Location = New System.Drawing.Point(151, 107)
        Me.txtProducto3.Name = "txtProducto3"
        Me.txtProducto3.Size = New System.Drawing.Size(202, 20)
        Me.txtProducto3.TabIndex = 9
        '
        'txtProducto2
        '
        Me.txtProducto2.Location = New System.Drawing.Point(151, 81)
        Me.txtProducto2.Name = "txtProducto2"
        Me.txtProducto2.Size = New System.Drawing.Size(202, 20)
        Me.txtProducto2.TabIndex = 8
        '
        'txtProducto1
        '
        Me.txtProducto1.Location = New System.Drawing.Point(151, 55)
        Me.txtProducto1.Name = "txtProducto1"
        Me.txtProducto1.Size = New System.Drawing.Size(202, 20)
        Me.txtProducto1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción:"
        '
        'txtCodigo5
        '
        Me.txtCodigo5.Location = New System.Drawing.Point(24, 159)
        Me.txtCodigo5.Mask = "99999"
        Me.txtCodigo5.Name = "txtCodigo5"
        Me.txtCodigo5.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo5.TabIndex = 5
        '
        'txtCodigo4
        '
        Me.txtCodigo4.Location = New System.Drawing.Point(24, 133)
        Me.txtCodigo4.Mask = "99999"
        Me.txtCodigo4.Name = "txtCodigo4"
        Me.txtCodigo4.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo4.TabIndex = 4
        '
        'txtCodigo3
        '
        Me.txtCodigo3.Location = New System.Drawing.Point(24, 107)
        Me.txtCodigo3.Mask = "99999"
        Me.txtCodigo3.Name = "txtCodigo3"
        Me.txtCodigo3.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo3.TabIndex = 3
        '
        'txtCodigo2
        '
        Me.txtCodigo2.Location = New System.Drawing.Point(24, 81)
        Me.txtCodigo2.Mask = "99999"
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo2.TabIndex = 2
        '
        'txtCodigo1
        '
        Me.txtCodigo1.Location = New System.Drawing.Point(24, 55)
        Me.txtCodigo1.Mask = "99999"
        Me.txtCodigo1.Name = "txtCodigo1"
        Me.txtCodigo1.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Codigo"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Controls.Add(Me.txtISV)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(341, 392)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(105, 101)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 7
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(106, 75)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 6
        '
        'txtISV
        '
        Me.txtISV.Enabled = False
        Me.txtISV.Location = New System.Drawing.Point(106, 49)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 5
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(106, 21)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Total a Pagar:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Descuento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ISV:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Subtotal:"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(20, 491)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 3
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Location = New System.Drawing.Point(112, 491)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(205, 491)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Snap ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(257, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 35)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Factura"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkDescuento.Location = New System.Drawing.Point(18, 19)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(78, 17)
        Me.chkDescuento.TabIndex = 7
        Me.chkDescuento.Text = "Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'chkISV
        '
        Me.chkISV.AutoSize = True
        Me.chkISV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkISV.Location = New System.Drawing.Point(107, 19)
        Me.chkISV.Name = "chkISV"
        Me.chkISV.Size = New System.Drawing.Size(43, 17)
        Me.chkISV.TabIndex = 8
        Me.chkISV.Text = "ISV"
        Me.chkISV.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox4.Controls.Add(Me.chkISV)
        Me.GroupBox4.Controls.Add(Me.chkDescuento)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(139, 392)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(182, 48)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aplicar"
        '
        'txtCantidad1
        '
        Me.txtCantidad1.Location = New System.Drawing.Point(477, 55)
        Me.txtCantidad1.Mask = "99999"
        Me.txtCantidad1.Name = "txtCantidad1"
        Me.txtCantidad1.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad1.TabIndex = 25
        '
        'txtCantidad2
        '
        Me.txtCantidad2.Location = New System.Drawing.Point(477, 81)
        Me.txtCantidad2.Mask = "99999"
        Me.txtCantidad2.Name = "txtCantidad2"
        Me.txtCantidad2.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad2.TabIndex = 26
        '
        'txtCantidad3
        '
        Me.txtCantidad3.Location = New System.Drawing.Point(477, 107)
        Me.txtCantidad3.Mask = "99999"
        Me.txtCantidad3.Name = "txtCantidad3"
        Me.txtCantidad3.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad3.TabIndex = 27
        '
        'txtCantidad4
        '
        Me.txtCantidad4.Location = New System.Drawing.Point(477, 133)
        Me.txtCantidad4.Mask = "99999"
        Me.txtCantidad4.Name = "txtCantidad4"
        Me.txtCantidad4.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad4.TabIndex = 28
        '
        'txtCantidad5
        '
        Me.txtCantidad5.Location = New System.Drawing.Point(477, 159)
        Me.txtCantidad5.Mask = "99999"
        Me.txtCantidad5.Name = "txtCantidad5"
        Me.txtCantidad5.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad5.TabIndex = 29
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(635, 543)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtHora As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtFactura As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents txtPrecio5 As TextBox
    Friend WithEvents txtPrecio4 As TextBox
    Friend WithEvents txtPrecio3 As TextBox
    Friend WithEvents txtPrecio2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProducto5 As TextBox
    Friend WithEvents txtProducto4 As TextBox
    Friend WithEvents txtProducto3 As TextBox
    Friend WithEvents txtProducto2 As TextBox
    Friend WithEvents txtProducto1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo5 As MaskedTextBox
    Friend WithEvents txtCodigo4 As MaskedTextBox
    Friend WithEvents txtCodigo3 As MaskedTextBox
    Friend WithEvents txtCodigo2 As MaskedTextBox
    Friend WithEvents txtCodigo1 As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkISV As CheckBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents txtCantidad5 As MaskedTextBox
    Friend WithEvents txtCantidad4 As MaskedTextBox
    Friend WithEvents txtCantidad3 As MaskedTextBox
    Friend WithEvents txtCantidad2 As MaskedTextBox
    Friend WithEvents txtCantidad1 As MaskedTextBox
End Class
