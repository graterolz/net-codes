<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.BarraMenu = New System.Windows.Forms.MenuStrip
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoFamiliarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TablasBasicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PeriodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilesToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.TablasBasicasToolStripMenuItem})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(492, 24)
        Me.BarraMenu.TabIndex = 0
        Me.BarraMenu.Text = "MenuStrip1"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PerfilesToolStripMenuItem.Text = "Sistema"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrupoFamiliarToolStripMenuItem, Me.EstudiantesToolStripMenuItem, Me.DocentesToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.RegistrosToolStripMenuItem.Text = "Perfiles"
        '
        'GrupoFamiliarToolStripMenuItem
        '
        Me.GrupoFamiliarToolStripMenuItem.Name = "GrupoFamiliarToolStripMenuItem"
        Me.GrupoFamiliarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.GrupoFamiliarToolStripMenuItem.Text = "Representantes"
        '
        'EstudiantesToolStripMenuItem
        '
        Me.EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        Me.EstudiantesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EstudiantesToolStripMenuItem.Text = "Estudiantes"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'TablasBasicasToolStripMenuItem
        '
        Me.TablasBasicasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeriodosToolStripMenuItem, Me.AsignaturasToolStripMenuItem})
        Me.TablasBasicasToolStripMenuItem.Name = "TablasBasicasToolStripMenuItem"
        Me.TablasBasicasToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.TablasBasicasToolStripMenuItem.Text = "Tablas Basicas"
        '
        'PeriodosToolStripMenuItem
        '
        Me.PeriodosToolStripMenuItem.Name = "PeriodosToolStripMenuItem"
        Me.PeriodosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PeriodosToolStripMenuItem.Text = "Periodos"
        '
        'AsignaturasToolStripMenuItem
        '
        Me.AsignaturasToolStripMenuItem.Name = "AsignaturasToolStripMenuItem"
        Me.AsignaturasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AsignaturasToolStripMenuItem.Text = "Asignaturas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 466)
        Me.Controls.Add(Me.BarraMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents PerfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoFamiliarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasBasicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeriodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
