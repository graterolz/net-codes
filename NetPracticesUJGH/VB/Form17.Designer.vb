<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.btnCalcular4 = New System.Windows.Forms.Button()
        Me.bntCalcular3 = New System.Windows.Forms.Button()
        Me.btnCalcular2 = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lstIteraciones = New System.Windows.Forms.ListBox()
        Me.LblIteraciones = New System.Windows.Forms.Label()
        Me.TxtN = New System.Windows.Forms.TextBox()
        Me.LblN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular4
        '
        Me.btnCalcular4.Location = New System.Drawing.Point(204, 196)
        Me.btnCalcular4.Name = "btnCalcular4"
        Me.btnCalcular4.Size = New System.Drawing.Size(68, 36)
        Me.btnCalcular4.TabIndex = 15
        Me.btnCalcular4.Text = "&Do ... While"
        Me.btnCalcular4.UseVisualStyleBackColor = True
        '
        'bntCalcular3
        '
        Me.bntCalcular3.Location = New System.Drawing.Point(204, 147)
        Me.bntCalcular3.Name = "bntCalcular3"
        Me.bntCalcular3.Size = New System.Drawing.Size(68, 36)
        Me.bntCalcular3.TabIndex = 14
        Me.bntCalcular3.Text = "&Repetir"
        Me.bntCalcular3.UseVisualStyleBackColor = True
        '
        'btnCalcular2
        '
        Me.btnCalcular2.Location = New System.Drawing.Point(204, 96)
        Me.btnCalcular2.Name = "btnCalcular2"
        Me.btnCalcular2.Size = New System.Drawing.Size(68, 36)
        Me.btnCalcular2.TabIndex = 13
        Me.btnCalcular2.Text = "&Mientras"
        Me.btnCalcular2.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(204, 45)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(68, 36)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "&For"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lstIteraciones
        '
        Me.lstIteraciones.FormattingEnabled = True
        Me.lstIteraciones.Location = New System.Drawing.Point(15, 61)
        Me.lstIteraciones.Name = "lstIteraciones"
        Me.lstIteraciones.Size = New System.Drawing.Size(183, 173)
        Me.lstIteraciones.TabIndex = 11
        '
        'LblIteraciones
        '
        Me.LblIteraciones.AutoSize = True
        Me.LblIteraciones.Location = New System.Drawing.Point(14, 45)
        Me.LblIteraciones.Name = "LblIteraciones"
        Me.LblIteraciones.Size = New System.Drawing.Size(62, 13)
        Me.LblIteraciones.TabIndex = 10
        Me.LblIteraciones.Text = "Iteraciones:"
        '
        'TxtN
        '
        Me.TxtN.Location = New System.Drawing.Point(78, 10)
        Me.TxtN.Name = "TxtN"
        Me.TxtN.Size = New System.Drawing.Size(143, 20)
        Me.TxtN.TabIndex = 9
        '
        'LblN
        '
        Me.LblN.AutoSize = True
        Me.LblN.Location = New System.Drawing.Point(12, 13)
        Me.LblN.Name = "LblN"
        Me.LblN.Size = New System.Drawing.Size(60, 13)
        Me.LblN.TabIndex = 8
        Me.LblN.Text = "Valor de N:"
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalcular4)
        Me.Controls.Add(Me.bntCalcular3)
        Me.Controls.Add(Me.btnCalcular2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lstIteraciones)
        Me.Controls.Add(Me.LblIteraciones)
        Me.Controls.Add(Me.TxtN)
        Me.Controls.Add(Me.LblN)
        Me.Name = "Form17"
        Me.Text = "Form17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular4 As Button
    Friend WithEvents bntCalcular3 As Button
    Friend WithEvents btnCalcular2 As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lstIteraciones As ListBox
    Friend WithEvents LblIteraciones As Label
    Friend WithEvents TxtN As TextBox
    Friend WithEvents LblN As Label
End Class
