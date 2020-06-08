<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio01
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
        Me.txtHistorial = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtScreen = New System.Windows.Forms.TextBox()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnSigno = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDivi = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHistorial
        '
        Me.txtHistorial.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtHistorial.Enabled = False
        Me.txtHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistorial.Location = New System.Drawing.Point(392, 18)
        Me.txtHistorial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHistorial.Multiline = True
        Me.txtHistorial.Name = "txtHistorial"
        Me.txtHistorial.Size = New System.Drawing.Size(144, 336)
        Me.txtHistorial.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtScreen)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(376, 81)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtScreen
        '
        Me.txtScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreen.Location = New System.Drawing.Point(8, 17)
        Me.txtScreen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtScreen.Name = "txtScreen"
        Me.txtScreen.Size = New System.Drawing.Size(365, 50)
        Me.txtScreen.TabIndex = 0
        Me.txtScreen.Text = "0"
        Me.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPunto
        '
        Me.btnPunto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPunto.Location = New System.Drawing.Point(74, 304)
        Me.btnPunto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(51, 50)
        Me.btnPunto.TabIndex = 22
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn4.Location = New System.Drawing.Point(11, 167)
        Me.btn4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(51, 50)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn1.Location = New System.Drawing.Point(11, 235)
        Me.btn1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(51, 50)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn7.Location = New System.Drawing.Point(11, 98)
        Me.btn7.Margin = New System.Windows.Forms.Padding(2)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(51, 50)
        Me.btn7.TabIndex = 19
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSuma.Location = New System.Drawing.Point(218, 304)
        Me.btnSuma.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(51, 50)
        Me.btnSuma.TabIndex = 18
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnSigno
        '
        Me.btnSigno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSigno.Location = New System.Drawing.Point(143, 304)
        Me.btnSigno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSigno.Name = "btnSigno"
        Me.btnSigno.Size = New System.Drawing.Size(51, 50)
        Me.btnSigno.TabIndex = 17
        Me.btnSigno.Text = "- +"
        Me.btnSigno.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMulti.Location = New System.Drawing.Point(218, 167)
        Me.btnMulti.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(51, 50)
        Me.btnMulti.TabIndex = 16
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn0.Location = New System.Drawing.Point(11, 304)
        Me.btn0.Margin = New System.Windows.Forms.Padding(2)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(51, 50)
        Me.btn0.TabIndex = 6
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResta.Location = New System.Drawing.Point(218, 235)
        Me.btnResta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(51, 50)
        Me.btnResta.TabIndex = 14
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn6.Location = New System.Drawing.Point(143, 167)
        Me.btn6.Margin = New System.Windows.Forms.Padding(2)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(51, 50)
        Me.btn6.TabIndex = 13
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn3.Location = New System.Drawing.Point(143, 235)
        Me.btn3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(51, 50)
        Me.btn3.TabIndex = 12
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn5.Location = New System.Drawing.Point(74, 167)
        Me.btn5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(51, 50)
        Me.btn5.TabIndex = 11
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btnIgual
        '
        Me.btnIgual.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIgual.Location = New System.Drawing.Point(287, 235)
        Me.btnIgual.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(88, 119)
        Me.btnIgual.TabIndex = 10
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(287, 98)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(88, 119)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Clear"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnDivi
        '
        Me.btnDivi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDivi.Location = New System.Drawing.Point(218, 98)
        Me.btnDivi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(51, 50)
        Me.btnDivi.TabIndex = 8
        Me.btnDivi.Text = "/"
        Me.btnDivi.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn2.Location = New System.Drawing.Point(74, 235)
        Me.btn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(51, 50)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn9.Location = New System.Drawing.Point(143, 98)
        Me.btn9.Margin = New System.Windows.Forms.Padding(2)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(51, 50)
        Me.btn9.TabIndex = 23
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn8.Location = New System.Drawing.Point(74, 98)
        Me.btn8.Margin = New System.Windows.Forms.Padding(2)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(51, 50)
        Me.btn8.TabIndex = 15
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(461, 376)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 26
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'ejercicio01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(548, 411)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtHistorial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnSigno)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnDivi)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ejercicio01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora basica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHistorial As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtScreen As TextBox
    Friend WithEvents btnPunto As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnSigno As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDivi As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents ToolTip As ToolTip
End Class
