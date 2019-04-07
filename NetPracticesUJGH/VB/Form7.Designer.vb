<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grupoBotones = New System.Windows.Forms.GroupBox()
        Me.esRadioButton = New System.Windows.Forms.RadioButton()
        Me.esCheckBox = New System.Windows.Forms.CheckBox()
        Me.botonPrueba = New System.Windows.Forms.Button()
        Me.cuadroTexto = New System.Windows.Forms.TextBox()
        Me.etiquetaEjemplo = New System.Windows.Forms.Label()
        Me.SalirAplicacion = New System.Windows.Forms.Button()
        Me.grupoBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoBotones
        '
        Me.grupoBotones.Controls.Add(Me.esRadioButton)
        Me.grupoBotones.Controls.Add(Me.esCheckBox)
        Me.grupoBotones.Location = New System.Drawing.Point(12, 63)
        Me.grupoBotones.Name = "grupoBotones"
        Me.grupoBotones.Size = New System.Drawing.Size(151, 86)
        Me.grupoBotones.TabIndex = 9
        Me.grupoBotones.TabStop = False
        Me.grupoBotones.Text = "Grupo de Botones"
        '
        'esRadioButton
        '
        Me.esRadioButton.AutoSize = True
        Me.esRadioButton.Location = New System.Drawing.Point(18, 48)
        Me.esRadioButton.Name = "esRadioButton"
        Me.esRadioButton.Size = New System.Drawing.Size(114, 17)
        Me.esRadioButton.TabIndex = 1
        Me.esRadioButton.TabStop = True
        Me.esRadioButton.Text = "Es un RadioButton"
        Me.esRadioButton.UseVisualStyleBackColor = True
        '
        'esCheckBox
        '
        Me.esCheckBox.AutoSize = True
        Me.esCheckBox.Location = New System.Drawing.Point(19, 21)
        Me.esCheckBox.Name = "esCheckBox"
        Me.esCheckBox.Size = New System.Drawing.Size(105, 17)
        Me.esCheckBox.TabIndex = 0
        Me.esCheckBox.Text = "Es un CheckBox"
        Me.esCheckBox.UseVisualStyleBackColor = True
        '
        'botonPrueba
        '
        Me.botonPrueba.Location = New System.Drawing.Point(169, 59)
        Me.botonPrueba.Name = "botonPrueba"
        Me.botonPrueba.Size = New System.Drawing.Size(53, 42)
        Me.botonPrueba.TabIndex = 8
        Me.botonPrueba.Text = "Prueba"
        Me.botonPrueba.UseVisualStyleBackColor = True
        '
        'cuadroTexto
        '
        Me.cuadroTexto.Location = New System.Drawing.Point(133, 16)
        Me.cuadroTexto.Name = "cuadroTexto"
        Me.cuadroTexto.Size = New System.Drawing.Size(89, 20)
        Me.cuadroTexto.TabIndex = 7
        '
        'etiquetaEjemplo
        '
        Me.etiquetaEjemplo.AutoSize = True
        Me.etiquetaEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.etiquetaEjemplo.Location = New System.Drawing.Point(12, 19)
        Me.etiquetaEjemplo.Name = "etiquetaEjemplo"
        Me.etiquetaEjemplo.Size = New System.Drawing.Size(53, 15)
        Me.etiquetaEjemplo.TabIndex = 6
        Me.etiquetaEjemplo.Text = "Visualizar"
        '
        'SalirAplicacion
        '
        Me.SalirAplicacion.Location = New System.Drawing.Point(169, 111)
        Me.SalirAplicacion.Name = "SalirAplicacion"
        Me.SalirAplicacion.Size = New System.Drawing.Size(53, 38)
        Me.SalirAplicacion.TabIndex = 5
        Me.SalirAplicacion.Text = "Salir"
        Me.SalirAplicacion.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 161)
        Me.Controls.Add(Me.grupoBotones)
        Me.Controls.Add(Me.botonPrueba)
        Me.Controls.Add(Me.cuadroTexto)
        Me.Controls.Add(Me.etiquetaEjemplo)
        Me.Controls.Add(Me.SalirAplicacion)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.grupoBotones.ResumeLayout(False)
        Me.grupoBotones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grupoBotones As GroupBox
    Friend WithEvents esRadioButton As RadioButton
    Friend WithEvents esCheckBox As CheckBox
    Friend WithEvents botonPrueba As Button
    Friend WithEvents cuadroTexto As TextBox
    Friend WithEvents etiquetaEjemplo As Label
    Friend WithEvents SalirAplicacion As Button
End Class
