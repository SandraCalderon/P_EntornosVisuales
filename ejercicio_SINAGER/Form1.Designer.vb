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
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Location = New System.Drawing.Point(135, 29)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartamentos.TabIndex = 2
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(172, 35)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(79, 21)
        Me.cmbDepartamento.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por Departamento"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(75, 73)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 3
        Me.btnSolicitar.Text = "Solicitar"
        Me.ToolTip1.SetToolTip(Me.btnSolicitar, "Solicita el valor de mascarillas para cada departamento")
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cant. Departamentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cant. por Departamentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.txtMunicipios)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 266)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribución"
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(126, 133)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntregar.TabIndex = 3
        Me.btnEntregar.Text = "Entregar"
        Me.ToolTip1.SetToolTip(Me.btnEntregar, "Realiza la entrega a cada uno de los municipios")
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Enabled = False
        Me.txtMunicipios.Location = New System.Drawing.Point(172, 78)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(100, 20)
        Me.txtMunicipios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cant. Municipios"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(21, 319)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 29)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Abandona Entrega de Mascarillas")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(480, 319)
        Me.txtStock.Multiline = True
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 29)
        Me.txtStock.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(640, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtStock)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrega de Mascarillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDepartamentos As TextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
