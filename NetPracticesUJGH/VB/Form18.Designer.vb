<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Me.btnCalcular3 = New System.Windows.Forms.Button()
        Me.LstTotales = New System.Windows.Forms.ListBox()
        Me.LblTotales = New System.Windows.Forms.Label()
        Me.btnCalcular2 = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.LstIntereses = New System.Windows.Forms.ListBox()
        Me.LstAnios = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAnios = New System.Windows.Forms.Label()
        Me.TxtInteres = New System.Windows.Forms.TextBox()
        Me.TxtCapital = New System.Windows.Forms.TextBox()
        Me.LblInteres = New System.Windows.Forms.Label()
        Me.LblCapital = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular3
        '
        Me.btnCalcular3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular3.Location = New System.Drawing.Point(249, 86)
        Me.btnCalcular3.Name = "btnCalcular3"
        Me.btnCalcular3.Size = New System.Drawing.Size(70, 30)
        Me.btnCalcular3.TabIndex = 29
        Me.btnCalcular3.Text = "Do ... While"
        Me.btnCalcular3.UseVisualStyleBackColor = True
        '
        'LstTotales
        '
        Me.LstTotales.FormattingEnabled = True
        Me.LstTotales.Location = New System.Drawing.Point(197, 142)
        Me.LstTotales.Name = "LstTotales"
        Me.LstTotales.Size = New System.Drawing.Size(78, 108)
        Me.LstTotales.TabIndex = 28
        '
        'LblTotales
        '
        Me.LblTotales.AutoSize = True
        Me.LblTotales.Location = New System.Drawing.Point(194, 117)
        Me.LblTotales.Name = "LblTotales"
        Me.LblTotales.Size = New System.Drawing.Size(45, 13)
        Me.LblTotales.TabIndex = 27
        Me.LblTotales.Text = "Totales:"
        '
        'btnCalcular2
        '
        Me.btnCalcular2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular2.Location = New System.Drawing.Point(249, 46)
        Me.btnCalcular2.Name = "btnCalcular2"
        Me.btnCalcular2.Size = New System.Drawing.Size(70, 30)
        Me.btnCalcular2.TabIndex = 26
        Me.btnCalcular2.Text = "Do ... Until"
        Me.btnCalcular2.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(115, 73)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(98, 20)
        Me.TxtTotal.TabIndex = 25
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(12, 80)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(97, 13)
        Me.LblTotal.TabIndex = 24
        Me.LblTotal.Text = "Capital + Intereses:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(249, 6)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(70, 30)
        Me.btnCalcular.TabIndex = 23
        Me.btnCalcular.Text = "While"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'LstIntereses
        '
        Me.LstIntereses.FormattingEnabled = True
        Me.LstIntereses.Location = New System.Drawing.Point(101, 142)
        Me.LstIntereses.Name = "LstIntereses"
        Me.LstIntereses.Size = New System.Drawing.Size(78, 108)
        Me.LstIntereses.TabIndex = 22
        '
        'LstAnios
        '
        Me.LstAnios.FormattingEnabled = True
        Me.LstAnios.Location = New System.Drawing.Point(15, 142)
        Me.LstAnios.Name = "LstAnios"
        Me.LstAnios.Size = New System.Drawing.Size(59, 108)
        Me.LstAnios.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Intereses:"
        '
        'LblAnios
        '
        Me.LblAnios.AutoSize = True
        Me.LblAnios.Location = New System.Drawing.Point(12, 117)
        Me.LblAnios.Name = "LblAnios"
        Me.LblAnios.Size = New System.Drawing.Size(34, 13)
        Me.LblAnios.TabIndex = 19
        Me.LblAnios.Text = "Años:"
        '
        'TxtInteres
        '
        Me.TxtInteres.Location = New System.Drawing.Point(115, 40)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(98, 20)
        Me.TxtInteres.TabIndex = 18
        '
        'TxtCapital
        '
        Me.TxtCapital.Location = New System.Drawing.Point(115, 6)
        Me.TxtCapital.Name = "TxtCapital"
        Me.TxtCapital.Size = New System.Drawing.Size(98, 20)
        Me.TxtCapital.TabIndex = 17
        '
        'LblInteres
        '
        Me.LblInteres.AutoSize = True
        Me.LblInteres.Location = New System.Drawing.Point(12, 47)
        Me.LblInteres.Name = "LblInteres"
        Me.LblInteres.Size = New System.Drawing.Size(42, 13)
        Me.LblInteres.TabIndex = 16
        Me.LblInteres.Text = "Interés:"
        '
        'LblCapital
        '
        Me.LblCapital.AutoSize = True
        Me.LblCapital.Location = New System.Drawing.Point(12, 9)
        Me.LblCapital.Name = "LblCapital"
        Me.LblCapital.Size = New System.Drawing.Size(42, 13)
        Me.LblCapital.TabIndex = 15
        Me.LblCapital.Text = "Capital:"
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 261)
        Me.Controls.Add(Me.btnCalcular3)
        Me.Controls.Add(Me.LstTotales)
        Me.Controls.Add(Me.LblTotales)
        Me.Controls.Add(Me.btnCalcular2)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.LstIntereses)
        Me.Controls.Add(Me.LstAnios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAnios)
        Me.Controls.Add(Me.TxtInteres)
        Me.Controls.Add(Me.TxtCapital)
        Me.Controls.Add(Me.LblInteres)
        Me.Controls.Add(Me.LblCapital)
        Me.Name = "Form18"
        Me.Text = "Form18"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular3 As Button
    Friend WithEvents LstTotales As ListBox
    Friend WithEvents LblTotales As Label
    Friend WithEvents btnCalcular2 As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents LstIntereses As ListBox
    Friend WithEvents LstAnios As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAnios As Label
    Friend WithEvents TxtInteres As TextBox
    Friend WithEvents TxtCapital As TextBox
    Friend WithEvents LblInteres As Label
    Friend WithEvents LblCapital As Label
End Class
