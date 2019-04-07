<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.btnVRepetidos = New System.Windows.Forms.Button()
        Me.btnVNulos = New System.Windows.Forms.Button()
        Me.btnVPares = New System.Windows.Forms.Button()
        Me.btnVImpares = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstNumeros = New System.Windows.Forms.ListBox()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.txtVRepetidos = New System.Windows.Forms.TextBox()
        Me.lblVRepetidos = New System.Windows.Forms.Label()
        Me.txtVNulos = New System.Windows.Forms.TextBox()
        Me.lblVNulos = New System.Windows.Forms.Label()
        Me.txtVPares = New System.Windows.Forms.TextBox()
        Me.lblVPares = New System.Windows.Forms.Label()
        Me.txtVImpares = New System.Windows.Forms.TextBox()
        Me.lblVImpares = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVRepetidos
        '
        Me.btnVRepetidos.Location = New System.Drawing.Point(392, 171)
        Me.btnVRepetidos.Name = "btnVRepetidos"
        Me.btnVRepetidos.Size = New System.Drawing.Size(87, 39)
        Me.btnVRepetidos.TabIndex = 46
        Me.btnVRepetidos.Text = "Valores Repetidos"
        Me.btnVRepetidos.UseVisualStyleBackColor = True
        '
        'btnVNulos
        '
        Me.btnVNulos.Location = New System.Drawing.Point(299, 171)
        Me.btnVNulos.Name = "btnVNulos"
        Me.btnVNulos.Size = New System.Drawing.Size(87, 39)
        Me.btnVNulos.TabIndex = 45
        Me.btnVNulos.Text = "Valores Nulos"
        Me.btnVNulos.UseVisualStyleBackColor = True
        '
        'btnVPares
        '
        Me.btnVPares.Location = New System.Drawing.Point(206, 171)
        Me.btnVPares.Name = "btnVPares"
        Me.btnVPares.Size = New System.Drawing.Size(87, 39)
        Me.btnVPares.TabIndex = 44
        Me.btnVPares.Text = "Valores Pares"
        Me.btnVPares.UseVisualStyleBackColor = True
        '
        'btnVImpares
        '
        Me.btnVImpares.Location = New System.Drawing.Point(113, 171)
        Me.btnVImpares.Name = "btnVImpares"
        Me.btnVImpares.Size = New System.Drawing.Size(87, 39)
        Me.btnVImpares.TabIndex = 43
        Me.btnVImpares.Text = "Valores Impares"
        Me.btnVImpares.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(15, 171)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 39)
        Me.btnAgregar.TabIndex = 42
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstNumeros
        '
        Me.lstNumeros.FormattingEnabled = True
        Me.lstNumeros.Location = New System.Drawing.Point(384, 31)
        Me.lstNumeros.Name = "lstNumeros"
        Me.lstNumeros.Size = New System.Drawing.Size(95, 134)
        Me.lstNumeros.TabIndex = 41
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Location = New System.Drawing.Point(382, 9)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(92, 13)
        Me.lblLista.TabIndex = 40
        Me.lblLista.Text = "Lista de Números:"
        '
        'txtVRepetidos
        '
        Me.txtVRepetidos.Location = New System.Drawing.Point(174, 110)
        Me.txtVRepetidos.Name = "txtVRepetidos"
        Me.txtVRepetidos.Size = New System.Drawing.Size(202, 20)
        Me.txtVRepetidos.TabIndex = 39
        '
        'lblVRepetidos
        '
        Me.lblVRepetidos.AutoSize = True
        Me.lblVRepetidos.Location = New System.Drawing.Point(12, 113)
        Me.lblVRepetidos.Name = "lblVRepetidos"
        Me.lblVRepetidos.Size = New System.Drawing.Size(156, 13)
        Me.lblVRepetidos.TabIndex = 38
        Me.lblVRepetidos.Text = "Cantidad de Valores Repetidos:"
        '
        'txtVNulos
        '
        Me.txtVNulos.Location = New System.Drawing.Point(174, 84)
        Me.txtVNulos.Name = "txtVNulos"
        Me.txtVNulos.Size = New System.Drawing.Size(202, 20)
        Me.txtVNulos.TabIndex = 37
        '
        'lblVNulos
        '
        Me.lblVNulos.AutoSize = True
        Me.lblVNulos.Location = New System.Drawing.Point(12, 87)
        Me.lblVNulos.Name = "lblVNulos"
        Me.lblVNulos.Size = New System.Drawing.Size(135, 13)
        Me.lblVNulos.TabIndex = 36
        Me.lblVNulos.Text = "Cantidad de Valores Nulos:"
        '
        'txtVPares
        '
        Me.txtVPares.Location = New System.Drawing.Point(174, 58)
        Me.txtVPares.Name = "txtVPares"
        Me.txtVPares.Size = New System.Drawing.Size(202, 20)
        Me.txtVPares.TabIndex = 35
        '
        'lblVPares
        '
        Me.lblVPares.AutoSize = True
        Me.lblVPares.Location = New System.Drawing.Point(12, 61)
        Me.lblVPares.Name = "lblVPares"
        Me.lblVPares.Size = New System.Drawing.Size(135, 13)
        Me.lblVPares.TabIndex = 34
        Me.lblVPares.Text = "Cantidad de Valores Pares:"
        '
        'txtVImpares
        '
        Me.txtVImpares.Location = New System.Drawing.Point(174, 32)
        Me.txtVImpares.Name = "txtVImpares"
        Me.txtVImpares.Size = New System.Drawing.Size(202, 20)
        Me.txtVImpares.TabIndex = 33
        '
        'lblVImpares
        '
        Me.lblVImpares.AutoSize = True
        Me.lblVImpares.Location = New System.Drawing.Point(12, 35)
        Me.lblVImpares.Name = "lblVImpares"
        Me.lblVImpares.Size = New System.Drawing.Size(145, 13)
        Me.lblVImpares.TabIndex = 32
        Me.lblVImpares.Text = "Cantidad de Valores Impares:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(174, 6)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(202, 20)
        Me.txtN.TabIndex = 31
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(12, 9)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(147, 13)
        Me.lblN.TabIndex = 30
        Me.lblN.Text = "Ingrese cantidad de números:"
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 231)
        Me.Controls.Add(Me.btnVRepetidos)
        Me.Controls.Add(Me.btnVNulos)
        Me.Controls.Add(Me.btnVPares)
        Me.Controls.Add(Me.btnVImpares)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lstNumeros)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.txtVRepetidos)
        Me.Controls.Add(Me.lblVRepetidos)
        Me.Controls.Add(Me.txtVNulos)
        Me.Controls.Add(Me.lblVNulos)
        Me.Controls.Add(Me.txtVPares)
        Me.Controls.Add(Me.lblVPares)
        Me.Controls.Add(Me.txtVImpares)
        Me.Controls.Add(Me.lblVImpares)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVRepetidos As Button
    Friend WithEvents btnVNulos As Button
    Friend WithEvents btnVPares As Button
    Friend WithEvents btnVImpares As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstNumeros As ListBox
    Friend WithEvents lblLista As Label
    Friend WithEvents txtVRepetidos As TextBox
    Friend WithEvents lblVRepetidos As Label
    Friend WithEvents txtVNulos As TextBox
    Friend WithEvents lblVNulos As Label
    Friend WithEvents txtVPares As TextBox
    Friend WithEvents lblVPares As Label
    Friend WithEvents txtVImpares As TextBox
    Friend WithEvents lblVImpares As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents lblN As Label
End Class
