<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asignatura
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
        Me.CBPeriodos = New System.Windows.Forms.ComboBox
        Me.LVAsignaturas = New System.Windows.Forms.ListView
        Me.IDAsignatura = New System.Windows.Forms.ColumnHeader
        Me.DescripcionAsignatura = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BCerrar = New System.Windows.Forms.Button
        Me.BEliminar = New System.Windows.Forms.Button
        Me.BModificar = New System.Windows.Forms.Button
        Me.BIncluir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBPeriodos
        '
        Me.CBPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPeriodos.FormattingEnabled = True
        Me.CBPeriodos.Location = New System.Drawing.Point(114, 13)
        Me.CBPeriodos.Name = "CBPeriodos"
        Me.CBPeriodos.Size = New System.Drawing.Size(144, 21)
        Me.CBPeriodos.TabIndex = 0
        '
        'LVAsignaturas
        '
        Me.LVAsignaturas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDAsignatura, Me.DescripcionAsignatura})
        Me.LVAsignaturas.FullRowSelect = True
        Me.LVAsignaturas.Location = New System.Drawing.Point(8, 40)
        Me.LVAsignaturas.Name = "LVAsignaturas"
        Me.LVAsignaturas.Size = New System.Drawing.Size(250, 110)
        Me.LVAsignaturas.TabIndex = 1
        Me.LVAsignaturas.UseCompatibleStateImageBehavior = False
        Me.LVAsignaturas.View = System.Windows.Forms.View.Details
        '
        'IDAsignatura
        '
        Me.IDAsignatura.Text = "ID Asignatura"
        Me.IDAsignatura.Width = 80
        '
        'DescripcionAsignatura
        '
        Me.DescripcionAsignatura.Text = "Descripcion Asignatura"
        Me.DescripcionAsignatura.Width = 165
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BCerrar)
        Me.GroupBox1.Controls.Add(Me.BEliminar)
        Me.GroupBox1.Controls.Add(Me.BModificar)
        Me.GroupBox1.Controls.Add(Me.BIncluir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LVAsignaturas)
        Me.GroupBox1.Controls.Add(Me.CBPeriodos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 160)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignaturas"
        '
        'BCerrar
        '
        Me.BCerrar.Location = New System.Drawing.Point(264, 127)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BCerrar.TabIndex = 6
        Me.BCerrar.Text = "Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(264, 98)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 5
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Location = New System.Drawing.Point(264, 69)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(75, 23)
        Me.BModificar.TabIndex = 4
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BIncluir
        '
        Me.BIncluir.Location = New System.Drawing.Point(264, 40)
        Me.BIncluir.Name = "BIncluir"
        Me.BIncluir.Size = New System.Drawing.Size(75, 23)
        Me.BIncluir.TabIndex = 3
        Me.BIncluir.Text = "Incluir"
        Me.BIncluir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripcion Periodo"
        '
        'Asignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 179)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Asignatura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents LVAsignaturas As System.Windows.Forms.ListView
    Friend WithEvents IDAsignatura As System.Windows.Forms.ColumnHeader
    Friend WithEvents DescripcionAsignatura As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BCerrar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BModificar As System.Windows.Forms.Button
    Friend WithEvents BIncluir As System.Windows.Forms.Button
End Class
