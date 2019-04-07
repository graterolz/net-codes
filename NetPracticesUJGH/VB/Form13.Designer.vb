<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.LblTPositivos = New System.Windows.Forms.Label()
        Me.LblTNulos = New System.Windows.Forms.Label()
        Me.LblTNegativos = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.lstPositivos = New System.Windows.Forms.ListBox()
        Me.lstNulos = New System.Windows.Forms.ListBox()
        Me.lstNegativos = New System.Windows.Forms.ListBox()
        Me.lblPositivos = New System.Windows.Forms.Label()
        Me.lblNulos = New System.Windows.Forms.Label()
        Me.lblNegativos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTPositivos
        '
        Me.LblTPositivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTPositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPositivos.Location = New System.Drawing.Point(250, 271)
        Me.LblTPositivos.Name = "LblTPositivos"
        Me.LblTPositivos.Size = New System.Drawing.Size(96, 18)
        Me.LblTPositivos.TabIndex = 23
        Me.LblTPositivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTNulos
        '
        Me.LblTNulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTNulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTNulos.Location = New System.Drawing.Point(133, 271)
        Me.LblTNulos.Name = "LblTNulos"
        Me.LblTNulos.Size = New System.Drawing.Size(96, 18)
        Me.LblTNulos.TabIndex = 22
        Me.LblTNulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTNegativos
        '
        Me.LblTNegativos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTNegativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTNegativos.Location = New System.Drawing.Point(12, 271)
        Me.LblTNegativos.Name = "LblTNegativos"
        Me.LblTNegativos.Size = New System.Drawing.Size(96, 18)
        Me.LblTNegativos.TabIndex = 21
        Me.LblTNegativos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(375, 44)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 40)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Ingresar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(375, 90)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(93, 40)
        Me.btnComprobar.TabIndex = 19
        Me.btnComprobar.Text = "&Comprobar"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'lstPositivos
        '
        Me.lstPositivos.FormattingEnabled = True
        Me.lstPositivos.Location = New System.Drawing.Point(250, 40)
        Me.lstPositivos.Name = "lstPositivos"
        Me.lstPositivos.Size = New System.Drawing.Size(95, 212)
        Me.lstPositivos.TabIndex = 18
        '
        'lstNulos
        '
        Me.lstNulos.FormattingEnabled = True
        Me.lstNulos.Location = New System.Drawing.Point(133, 38)
        Me.lstNulos.Name = "lstNulos"
        Me.lstNulos.Size = New System.Drawing.Size(95, 212)
        Me.lstNulos.TabIndex = 17
        '
        'lstNegativos
        '
        Me.lstNegativos.FormattingEnabled = True
        Me.lstNegativos.Location = New System.Drawing.Point(15, 38)
        Me.lstNegativos.Name = "lstNegativos"
        Me.lstNegativos.Size = New System.Drawing.Size(95, 212)
        Me.lstNegativos.TabIndex = 16
        '
        'lblPositivos
        '
        Me.lblPositivos.AutoSize = True
        Me.lblPositivos.Location = New System.Drawing.Point(247, 9)
        Me.lblPositivos.Name = "lblPositivos"
        Me.lblPositivos.Size = New System.Drawing.Size(90, 13)
        Me.lblPositivos.TabIndex = 15
        Me.lblPositivos.Text = "Valores Positivos:"
        '
        'lblNulos
        '
        Me.lblNulos.AutoSize = True
        Me.lblNulos.Location = New System.Drawing.Point(130, 9)
        Me.lblNulos.Name = "lblNulos"
        Me.lblNulos.Size = New System.Drawing.Size(72, 13)
        Me.lblNulos.TabIndex = 14
        Me.lblNulos.Text = "Valores Nulos"
        '
        'lblNegativos
        '
        Me.lblNegativos.AutoSize = True
        Me.lblNegativos.Location = New System.Drawing.Point(12, 9)
        Me.lblNegativos.Name = "lblNegativos"
        Me.lblNegativos.Size = New System.Drawing.Size(96, 13)
        Me.lblNegativos.TabIndex = 13
        Me.lblNegativos.Text = "Valores Negativos:"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.LblTPositivos)
        Me.Controls.Add(Me.LblTNulos)
        Me.Controls.Add(Me.LblTNegativos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.lstPositivos)
        Me.Controls.Add(Me.lstNulos)
        Me.Controls.Add(Me.lstNegativos)
        Me.Controls.Add(Me.lblPositivos)
        Me.Controls.Add(Me.lblNulos)
        Me.Controls.Add(Me.lblNegativos)
        Me.Name = "Form13"
        Me.Text = "Form13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTPositivos As Label
    Friend WithEvents LblTNulos As Label
    Friend WithEvents LblTNegativos As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnComprobar As Button
    Friend WithEvents lstPositivos As ListBox
    Friend WithEvents lstNulos As ListBox
    Friend WithEvents lstNegativos As ListBox
    Friend WithEvents lblPositivos As Label
    Friend WithEvents lblNulos As Label
    Friend WithEvents lblNegativos As Label
End Class
