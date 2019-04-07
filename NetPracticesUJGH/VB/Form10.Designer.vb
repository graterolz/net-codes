<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnInversa = New System.Windows.Forms.Button()
        Me.TxtCadInversa = New System.Windows.Forms.TextBox()
        Me.LblCadInversa = New System.Windows.Forms.Label()
        Me.TxtCadena = New System.Windows.Forms.TextBox()
        Me.LblCadena = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInversa
        '
        Me.BtnInversa.Location = New System.Drawing.Point(239, 78)
        Me.BtnInversa.Name = "BtnInversa"
        Me.BtnInversa.Size = New System.Drawing.Size(115, 40)
        Me.BtnInversa.TabIndex = 9
        Me.BtnInversa.Text = "&Inversa de una Cadena"
        Me.BtnInversa.UseVisualStyleBackColor = True
        '
        'TxtCadInversa
        '
        Me.TxtCadInversa.Location = New System.Drawing.Point(172, 41)
        Me.TxtCadInversa.Name = "TxtCadInversa"
        Me.TxtCadInversa.Size = New System.Drawing.Size(182, 20)
        Me.TxtCadInversa.TabIndex = 8
        '
        'LblCadInversa
        '
        Me.LblCadInversa.AutoSize = True
        Me.LblCadInversa.Location = New System.Drawing.Point(12, 44)
        Me.LblCadInversa.Name = "LblCadInversa"
        Me.LblCadInversa.Size = New System.Drawing.Size(160, 13)
        Me.LblCadInversa.TabIndex = 7
        Me.LblCadInversa.Text = "Cadena de Caracteres Invertida:"
        '
        'TxtCadena
        '
        Me.TxtCadena.Location = New System.Drawing.Point(172, 9)
        Me.TxtCadena.Name = "TxtCadena"
        Me.TxtCadena.Size = New System.Drawing.Size(182, 20)
        Me.TxtCadena.TabIndex = 6
        '
        'LblCadena
        '
        Me.LblCadena.AutoSize = True
        Me.LblCadena.Location = New System.Drawing.Point(12, 9)
        Me.LblCadena.Name = "LblCadena"
        Me.LblCadena.Size = New System.Drawing.Size(154, 13)
        Me.LblCadena.TabIndex = 5
        Me.LblCadena.Text = "Ingrese Cadena de Caracteres:"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 141)
        Me.Controls.Add(Me.BtnInversa)
        Me.Controls.Add(Me.TxtCadInversa)
        Me.Controls.Add(Me.LblCadInversa)
        Me.Controls.Add(Me.TxtCadena)
        Me.Controls.Add(Me.LblCadena)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInversa As Button
    Friend WithEvents TxtCadInversa As TextBox
    Friend WithEvents LblCadInversa As Label
    Friend WithEvents TxtCadena As TextBox
    Friend WithEvents LblCadena As Label
End Class
