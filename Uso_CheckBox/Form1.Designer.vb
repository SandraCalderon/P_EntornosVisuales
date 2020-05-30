<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPotencia = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.chkDivi = New System.Windows.Forms.CheckBox()
        Me.chkMulti = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(256, 258)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Abandona el formulario")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(143, 258)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 28
        Me.btnLimpiar.Text = "Limpiar"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Limpia los datos ")
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(21, 258)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.Text = "Calcular"
        Me.ToolTip1.SetToolTip(Me.btnCalcular, "Calcula la operacion Aritmetica selecionada")
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Enabled = False
        Me.txtRespuesta.Location = New System.Drawing.Point(94, 165)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtRespuesta.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Respuesta:"
        '
        'chkPotencia
        '
        Me.chkPotencia.AutoSize = True
        Me.chkPotencia.Location = New System.Drawing.Point(251, 210)
        Me.chkPotencia.Name = "chkPotencia"
        Me.chkPotencia.Size = New System.Drawing.Size(68, 17)
        Me.chkPotencia.TabIndex = 24
        Me.chkPotencia.Text = "Potencia"
        Me.chkPotencia.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Location = New System.Drawing.Point(251, 176)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(47, 17)
        Me.chkRaiz.TabIndex = 23
        Me.chkRaiz.Text = "Raiz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'chkDivi
        '
        Me.chkDivi.AutoSize = True
        Me.chkDivi.Location = New System.Drawing.Point(251, 141)
        Me.chkDivi.Name = "chkDivi"
        Me.chkDivi.Size = New System.Drawing.Size(63, 17)
        Me.chkDivi.TabIndex = 22
        Me.chkDivi.Text = "División"
        Me.chkDivi.UseVisualStyleBackColor = True
        '
        'chkMulti
        '
        Me.chkMulti.AutoSize = True
        Me.chkMulti.Location = New System.Drawing.Point(251, 104)
        Me.chkMulti.Name = "chkMulti"
        Me.chkMulti.Size = New System.Drawing.Size(90, 17)
        Me.chkMulti.TabIndex = 21
        Me.chkMulti.Text = "Multiplicación"
        Me.chkMulti.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Location = New System.Drawing.Point(251, 69)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(54, 17)
        Me.chkResta.TabIndex = 20
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Location = New System.Drawing.Point(251, 32)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(53, 17)
        Me.chkSuma.TabIndex = 15
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(83, 68)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Valor 2:"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(83, 32)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Valor 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(391, 321)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkPotencia)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkDivi)
        Me.Controls.Add(Me.chkMulti)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uso Check Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkPotencia As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents chkDivi As CheckBox
    Friend WithEvents chkMulti As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label1 As Label
End Class
