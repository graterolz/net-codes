<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.lblTotalN = New System.Windows.Forms.Label()
        Me.lblTotalP = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblNegativos = New System.Windows.Forms.Label()
        Me.lstNegativos = New System.Windows.Forms.ListBox()
        Me.lblPositivos = New System.Windows.Forms.Label()
        Me.lstPositivos = New System.Windows.Forms.ListBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotalN
        '
        Me.lblTotalN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalN.Location = New System.Drawing.Point(155, 262)
        Me.lblTotalN.Name = "lblTotalN"
        Me.lblTotalN.Size = New System.Drawing.Size(87, 34)
        Me.lblTotalN.TabIndex = 17
        '
        'lblTotalP
        '
        Me.lblTotalP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalP.Location = New System.Drawing.Point(15, 262)
        Me.lblTotalP.Name = "lblTotalP"
        Me.lblTotalP.Size = New System.Drawing.Size(87, 34)
        Me.lblTotalP.TabIndex = 16
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(268, 67)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(90, 69)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblNegativos
        '
        Me.lblNegativos.AutoSize = True
        Me.lblNegativos.Location = New System.Drawing.Point(134, 48)
        Me.lblNegativos.Name = "lblNegativos"
        Me.lblNegativos.Size = New System.Drawing.Size(113, 13)
        Me.lblNegativos.TabIndex = 14
        Me.lblNegativos.Text = "Elementos Negativos: "
        '
        'lstNegativos
        '
        Me.lstNegativos.FormattingEnabled = True
        Me.lstNegativos.Location = New System.Drawing.Point(137, 64)
        Me.lstNegativos.Name = "lstNegativos"
        Me.lstNegativos.Size = New System.Drawing.Size(105, 186)
        Me.lstNegativos.TabIndex = 13
        '
        'lblPositivos
        '
        Me.lblPositivos.AutoSize = True
        Me.lblPositivos.Location = New System.Drawing.Point(12, 48)
        Me.lblPositivos.Name = "lblPositivos"
        Me.lblPositivos.Size = New System.Drawing.Size(106, 13)
        Me.lblPositivos.TabIndex = 12
        Me.lblPositivos.Text = "Elementos positivos: "
        '
        'lstPositivos
        '
        Me.lstPositivos.FormattingEnabled = True
        Me.lstPositivos.Location = New System.Drawing.Point(15, 64)
        Me.lstPositivos.Name = "lstPositivos"
        Me.lstPositivos.Size = New System.Drawing.Size(105, 186)
        Me.lstPositivos.TabIndex = 11
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(113, 8)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(214, 20)
        Me.txtValor.TabIndex = 10
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(12, 9)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(94, 13)
        Me.lblValor.TabIndex = 9
        Me.lblValor.Text = "Ingrese elemento: "
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.lblTotalN)
        Me.Controls.Add(Me.lblTotalP)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblNegativos)
        Me.Controls.Add(Me.lstNegativos)
        Me.Controls.Add(Me.lblPositivos)
        Me.Controls.Add(Me.lstPositivos)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblValor)
        Me.Name = "Form16"
        Me.Text = "Form16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalN As Label
    Friend WithEvents lblTotalP As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblNegativos As Label
    Friend WithEvents lstNegativos As ListBox
    Friend WithEvents lblPositivos As Label
    Friend WithEvents lstPositivos As ListBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
End Class
