<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormaPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InquilinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CondominioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CondominioToolStripMenuItem
        '
        Me.CondominioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApartamentosToolStripMenuItem, Me.InquilinosToolStripMenuItem, Me.PagosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.CondominioToolStripMenuItem.Name = "CondominioToolStripMenuItem"
        Me.CondominioToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.CondominioToolStripMenuItem.Text = "Condominio"
        '
        'ApartamentosToolStripMenuItem
        '
        Me.ApartamentosToolStripMenuItem.Name = "ApartamentosToolStripMenuItem"
        Me.ApartamentosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ApartamentosToolStripMenuItem.Text = "Apartamentos"
        '
        'InquilinosToolStripMenuItem
        '
        Me.InquilinosToolStripMenuItem.Name = "InquilinosToolStripMenuItem"
        Me.InquilinosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.InquilinosToolStripMenuItem.Text = "Inquilinos"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FormaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormaPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CondominioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InquilinosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
