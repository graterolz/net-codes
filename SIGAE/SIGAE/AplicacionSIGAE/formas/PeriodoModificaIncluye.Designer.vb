<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriodoModificaIncluye
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BCancelar = New System.Windows.Forms.Button
        Me.BMultiAccion = New System.Windows.Forms.Button
        Me.TDescripcionPeriodo = New System.Windows.Forms.TextBox
        Me.TIDPeriodo = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BCancelar)
        Me.GroupBox1.Controls.Add(Me.BMultiAccion)
        Me.GroupBox1.Controls.Add(Me.TDescripcionPeriodo)
        Me.GroupBox1.Controls.Add(Me.TIDPeriodo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 107)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Descripcion Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID Periodo"
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(189, 71)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 6
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BMultiAccion
        '
        Me.BMultiAccion.Location = New System.Drawing.Point(9, 71)
        Me.BMultiAccion.Name = "BMultiAccion"
        Me.BMultiAccion.Size = New System.Drawing.Size(75, 23)
        Me.BMultiAccion.TabIndex = 5
        Me.BMultiAccion.UseVisualStyleBackColor = True
        '
        'TDescripcionPeriodo
        '
        Me.TDescripcionPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDescripcionPeriodo.Location = New System.Drawing.Point(114, 42)
        Me.TDescripcionPeriodo.Name = "TDescripcionPeriodo"
        Me.TDescripcionPeriodo.Size = New System.Drawing.Size(150, 20)
        Me.TDescripcionPeriodo.TabIndex = 4
        '
        'TIDPeriodo
        '
        Me.TIDPeriodo.Enabled = False
        Me.TIDPeriodo.Location = New System.Drawing.Point(114, 13)
        Me.TIDPeriodo.Name = "TIDPeriodo"
        Me.TIDPeriodo.Size = New System.Drawing.Size(50, 20)
        Me.TIDPeriodo.TabIndex = 3
        '
        'PeriodoModificaIncluye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 126)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PeriodoModificaIncluye"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BMultiAccion As System.Windows.Forms.Button
    Friend WithEvents TDescripcionPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents TIDPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
