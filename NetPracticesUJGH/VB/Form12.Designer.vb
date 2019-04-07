<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.btnPeek = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.lstElementos = New System.Windows.Forms.ListBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPeek
        '
        Me.btnPeek.Location = New System.Drawing.Point(168, 206)
        Me.btnPeek.Name = "btnPeek"
        Me.btnPeek.Size = New System.Drawing.Size(92, 34)
        Me.btnPeek.TabIndex = 23
        Me.btnPeek.Text = "Peek"
        Me.btnPeek.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(168, 166)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(92, 34)
        Me.btnCount.TabIndex = 22
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(168, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 34)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(168, 86)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(92, 34)
        Me.btnPop.TabIndex = 20
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(168, 46)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(92, 34)
        Me.btnPush.TabIndex = 19
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'lstElementos
        '
        Me.lstElementos.FormattingEnabled = True
        Me.lstElementos.Location = New System.Drawing.Point(12, 46)
        Me.lstElementos.Name = "lstElementos"
        Me.lstElementos.Size = New System.Drawing.Size(137, 199)
        Me.lstElementos.TabIndex = 18
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(123, 11)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(137, 20)
        Me.txtN.TabIndex = 17
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(12, 14)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(96, 13)
        Me.lblN.TabIndex = 16
        Me.lblN.Text = "Valor de Elemento:"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnPeek)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.lstElementos)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Form12"
        Me.Text = "Form12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPeek As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnPush As Button
    Friend WithEvents lstElementos As ListBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents lblN As Label
End Class
