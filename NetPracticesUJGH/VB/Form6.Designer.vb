<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.salirButton = New System.Windows.Forms.Button()
        Me.calcularButton = New System.Windows.Forms.Button()
        Me.numero5TextBox = New System.Windows.Forms.TextBox()
        Me.numero4TextBox = New System.Windows.Forms.TextBox()
        Me.numero3TextBox = New System.Windows.Forms.TextBox()
        Me.numero2TextBox = New System.Windows.Forms.TextBox()
        Me.numero1TextBox = New System.Windows.Forms.TextBox()
        Me.Numero5Label = New System.Windows.Forms.Label()
        Me.Numero4Label = New System.Windows.Forms.Label()
        Me.Numero3Label = New System.Windows.Forms.Label()
        Me.Numero2Label = New System.Windows.Forms.Label()
        Me.Numero1Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'salirButton
        '
        Me.salirButton.Location = New System.Drawing.Point(170, 108)
        Me.salirButton.Name = "salirButton"
        Me.salirButton.Size = New System.Drawing.Size(75, 23)
        Me.salirButton.TabIndex = 23
        Me.salirButton.Text = "Salir!"
        Me.salirButton.UseVisualStyleBackColor = True
        '
        'calcularButton
        '
        Me.calcularButton.Location = New System.Drawing.Point(170, 9)
        Me.calcularButton.Name = "calcularButton"
        Me.calcularButton.Size = New System.Drawing.Size(75, 70)
        Me.calcularButton.TabIndex = 22
        Me.calcularButton.Text = "Calcular!"
        Me.calcularButton.UseVisualStyleBackColor = True
        '
        'numero5TextBox
        '
        Me.numero5TextBox.Location = New System.Drawing.Point(57, 110)
        Me.numero5TextBox.Name = "numero5TextBox"
        Me.numero5TextBox.Size = New System.Drawing.Size(100, 20)
        Me.numero5TextBox.TabIndex = 21
        '
        'numero4TextBox
        '
        Me.numero4TextBox.Location = New System.Drawing.Point(57, 84)
        Me.numero4TextBox.Name = "numero4TextBox"
        Me.numero4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.numero4TextBox.TabIndex = 20
        '
        'numero3TextBox
        '
        Me.numero3TextBox.Location = New System.Drawing.Point(57, 58)
        Me.numero3TextBox.Name = "numero3TextBox"
        Me.numero3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.numero3TextBox.TabIndex = 19
        '
        'numero2TextBox
        '
        Me.numero2TextBox.Location = New System.Drawing.Point(57, 32)
        Me.numero2TextBox.Name = "numero2TextBox"
        Me.numero2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.numero2TextBox.TabIndex = 18
        '
        'numero1TextBox
        '
        Me.numero1TextBox.Location = New System.Drawing.Point(57, 6)
        Me.numero1TextBox.Name = "numero1TextBox"
        Me.numero1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.numero1TextBox.TabIndex = 17
        '
        'Numero5Label
        '
        Me.Numero5Label.AutoSize = True
        Me.Numero5Label.Location = New System.Drawing.Point(12, 113)
        Me.Numero5Label.Name = "Numero5Label"
        Me.Numero5Label.Size = New System.Drawing.Size(23, 13)
        Me.Numero5Label.TabIndex = 16
        Me.Numero5Label.Text = "#5:"
        '
        'Numero4Label
        '
        Me.Numero4Label.AutoSize = True
        Me.Numero4Label.Location = New System.Drawing.Point(12, 87)
        Me.Numero4Label.Name = "Numero4Label"
        Me.Numero4Label.Size = New System.Drawing.Size(23, 13)
        Me.Numero4Label.TabIndex = 15
        Me.Numero4Label.Text = "#4:"
        '
        'Numero3Label
        '
        Me.Numero3Label.AutoSize = True
        Me.Numero3Label.Location = New System.Drawing.Point(12, 61)
        Me.Numero3Label.Name = "Numero3Label"
        Me.Numero3Label.Size = New System.Drawing.Size(23, 13)
        Me.Numero3Label.TabIndex = 14
        Me.Numero3Label.Text = "#3:"
        '
        'Numero2Label
        '
        Me.Numero2Label.AutoSize = True
        Me.Numero2Label.Location = New System.Drawing.Point(12, 35)
        Me.Numero2Label.Name = "Numero2Label"
        Me.Numero2Label.Size = New System.Drawing.Size(23, 13)
        Me.Numero2Label.TabIndex = 13
        Me.Numero2Label.Text = "#2:"
        '
        'Numero1Label
        '
        Me.Numero1Label.AutoSize = True
        Me.Numero1Label.Location = New System.Drawing.Point(12, 9)
        Me.Numero1Label.Name = "Numero1Label"
        Me.Numero1Label.Size = New System.Drawing.Size(23, 13)
        Me.Numero1Label.TabIndex = 12
        Me.Numero1Label.Text = "#1:"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 141)
        Me.Controls.Add(Me.salirButton)
        Me.Controls.Add(Me.calcularButton)
        Me.Controls.Add(Me.numero5TextBox)
        Me.Controls.Add(Me.numero4TextBox)
        Me.Controls.Add(Me.numero3TextBox)
        Me.Controls.Add(Me.numero2TextBox)
        Me.Controls.Add(Me.numero1TextBox)
        Me.Controls.Add(Me.Numero5Label)
        Me.Controls.Add(Me.Numero4Label)
        Me.Controls.Add(Me.Numero3Label)
        Me.Controls.Add(Me.Numero2Label)
        Me.Controls.Add(Me.Numero1Label)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salirButton As Button
    Friend WithEvents calcularButton As Button
    Friend WithEvents numero5TextBox As TextBox
    Friend WithEvents numero4TextBox As TextBox
    Friend WithEvents numero3TextBox As TextBox
    Friend WithEvents numero2TextBox As TextBox
    Friend WithEvents numero1TextBox As TextBox
    Friend WithEvents Numero5Label As Label
    Friend WithEvents Numero4Label As Label
    Friend WithEvents Numero3Label As Label
    Friend WithEvents Numero2Label As Label
    Friend WithEvents Numero1Label As Label
End Class
