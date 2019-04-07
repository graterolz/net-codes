<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormaLogin
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BotonEntrar = New System.Windows.Forms.Button
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.TxtContrasena = New System.Windows.Forms.TextBox
        Me.BotonSalir = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'BotonEntrar
        '
        Me.BotonEntrar.Location = New System.Drawing.Point(12, 83)
        Me.BotonEntrar.Name = "BotonEntrar"
        Me.BotonEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BotonEntrar.TabIndex = 4
        Me.BotonEntrar.Text = "Entrar"
        Me.BotonEntrar.UseVisualStyleBackColor = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtUsuario.Location = New System.Drawing.Point(80, 6)
        Me.TxtUsuario.MaxLength = 25
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtContrasena
        '
        Me.TxtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtContrasena.Location = New System.Drawing.Point(80, 31)
        Me.TxtContrasena.MaxLength = 25
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.TxtContrasena.TabIndex = 3
        '
        'BotonSalir
        '
        Me.BotonSalir.Location = New System.Drawing.Point(105, 83)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(75, 23)
        Me.BotonSalir.TabIndex = 5
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 57)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Administrador"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(110, 57)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "Usuario"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.BotonEntrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormaLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BotonEntrar As System.Windows.Forms.Button
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents BotonSalir As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
