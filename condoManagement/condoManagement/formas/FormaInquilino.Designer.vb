<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormaInquilino
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BotonEliminar = New System.Windows.Forms.Button
        Me.BotonModificar = New System.Windows.Forms.Button
        Me.BotonIncluir = New System.Windows.Forms.Button
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 174)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inquilinos"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(468, 149)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Inquilino"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cedula"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Apellido"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID Apartamento"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 96
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipo Contrato"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 105
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BotonEliminar)
        Me.GroupBox1.Controls.Add(Me.BotonModificar)
        Me.GroupBox1.Controls.Add(Me.BotonIncluir)
        Me.GroupBox1.Controls.Add(Me.ButtonCerrar)
        Me.GroupBox1.Location = New System.Drawing.Point(498, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 174)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BotonEliminar
        '
        Me.BotonEliminar.Location = New System.Drawing.Point(6, 95)
        Me.BotonEliminar.Name = "BotonEliminar"
        Me.BotonEliminar.Size = New System.Drawing.Size(75, 32)
        Me.BotonEliminar.TabIndex = 10
        Me.BotonEliminar.Text = "Eliminar"
        Me.BotonEliminar.UseVisualStyleBackColor = True
        '
        'BotonModificar
        '
        Me.BotonModificar.Location = New System.Drawing.Point(6, 57)
        Me.BotonModificar.Name = "BotonModificar"
        Me.BotonModificar.Size = New System.Drawing.Size(75, 32)
        Me.BotonModificar.TabIndex = 9
        Me.BotonModificar.Text = "Modificar"
        Me.BotonModificar.UseVisualStyleBackColor = True
        '
        'BotonIncluir
        '
        Me.BotonIncluir.Location = New System.Drawing.Point(6, 19)
        Me.BotonIncluir.Name = "BotonIncluir"
        Me.BotonIncluir.Size = New System.Drawing.Size(75, 32)
        Me.BotonIncluir.TabIndex = 8
        Me.BotonIncluir.Text = "Incluir"
        Me.BotonIncluir.UseVisualStyleBackColor = True
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(6, 133)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 32)
        Me.ButtonCerrar.TabIndex = 7
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        '
        'FormaInquilino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormaInquilino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inquilinos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BotonEliminar As System.Windows.Forms.Button
    Friend WithEvents BotonModificar As System.Windows.Forms.Button
    Friend WithEvents BotonIncluir As System.Windows.Forms.Button
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
End Class
