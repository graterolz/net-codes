<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lstNotas = New System.Windows.Forms.ListBox()
        Me.lblNotas = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(151, 78)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 77)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(149, 32)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(127, 20)
        Me.txtPromedio.TabIndex = 20
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Location = New System.Drawing.Point(12, 35)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(79, 13)
        Me.lblPromedio.TabIndex = 19
        Me.lblPromedio.Text = "El promedio es:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(151, 161)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 77)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lstNotas
        '
        Me.lstNotas.FormattingEnabled = True
        Me.lstNotas.Location = New System.Drawing.Point(13, 78)
        Me.lstNotas.Name = "lstNotas"
        Me.lstNotas.Size = New System.Drawing.Size(95, 160)
        Me.lstNotas.TabIndex = 17
        '
        'lblNotas
        '
        Me.lblNotas.AutoSize = True
        Me.lblNotas.Location = New System.Drawing.Point(12, 58)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(87, 13)
        Me.lblNotas.TabIndex = 16
        Me.lblNotas.Text = "Listado de Notas"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(149, 6)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(127, 20)
        Me.txtN.TabIndex = 15
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(12, 9)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(133, 13)
        Me.lblN.TabIndex = 14
        Me.lblN.Text = "Ingrese cantidad de notas:"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lstNotas)
        Me.Controls.Add(Me.lblNotas)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Form14"
        Me.Text = "Form14"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents lblPromedio As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lstNotas As ListBox
    Friend WithEvents lblNotas As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents lblN As Label
End Class
