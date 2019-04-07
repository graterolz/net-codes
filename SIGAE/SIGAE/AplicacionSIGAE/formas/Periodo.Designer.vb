<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Periodo
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
        Me.BCerrar = New System.Windows.Forms.Button
        Me.LVPeriodos = New System.Windows.Forms.ListView
        Me.IDPeriodo = New System.Windows.Forms.ColumnHeader
        Me.DescripcionPeriodo = New System.Windows.Forms.ColumnHeader
        Me.BEliminar = New System.Windows.Forms.Button
        Me.BIncluir = New System.Windows.Forms.Button
        Me.BModificar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BCerrar)
        Me.GroupBox1.Controls.Add(Me.LVPeriodos)
        Me.GroupBox1.Controls.Add(Me.BEliminar)
        Me.GroupBox1.Controls.Add(Me.BIncluir)
        Me.GroupBox1.Controls.Add(Me.BModificar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 142)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodos"
        '
        'BCerrar
        '
        Me.BCerrar.Location = New System.Drawing.Point(262, 106)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BCerrar.TabIndex = 14
        Me.BCerrar.Text = "Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = True
        '
        'LVPeriodos
        '
        Me.LVPeriodos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDPeriodo, Me.DescripcionPeriodo})
        Me.LVPeriodos.FullRowSelect = True
        Me.LVPeriodos.Location = New System.Drawing.Point(6, 19)
        Me.LVPeriodos.Name = "LVPeriodos"
        Me.LVPeriodos.Size = New System.Drawing.Size(250, 110)
        Me.LVPeriodos.TabIndex = 10
        Me.LVPeriodos.UseCompatibleStateImageBehavior = False
        Me.LVPeriodos.View = System.Windows.Forms.View.Details
        '
        'IDPeriodo
        '
        Me.IDPeriodo.Text = "ID Periodo"
        Me.IDPeriodo.Width = 65
        '
        'DescripcionPeriodo
        '
        Me.DescripcionPeriodo.Text = "Descripcion Periodo"
        Me.DescripcionPeriodo.Width = 180
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(262, 77)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 13
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BIncluir
        '
        Me.BIncluir.Location = New System.Drawing.Point(262, 19)
        Me.BIncluir.Name = "BIncluir"
        Me.BIncluir.Size = New System.Drawing.Size(75, 23)
        Me.BIncluir.TabIndex = 11
        Me.BIncluir.Text = "Incluir"
        Me.BIncluir.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Location = New System.Drawing.Point(262, 48)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(75, 23)
        Me.BModificar.TabIndex = 12
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'Periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 166)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Periodo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BCerrar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BModificar As System.Windows.Forms.Button
    Friend WithEvents BIncluir As System.Windows.Forms.Button
    Friend WithEvents LVPeriodos As System.Windows.Forms.ListView
    Friend WithEvents IDPeriodo As System.Windows.Forms.ColumnHeader
    Friend WithEvents DescripcionPeriodo As System.Windows.Forms.ColumnHeader
End Class
