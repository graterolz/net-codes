<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdCalcular = New System.Windows.Forms.Button()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(33, 119)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(51, 13)
        Me.lblP.TabIndex = 21
        Me.lblP.Text = "Perimetro"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Location = New System.Drawing.Point(34, 88)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(54, 13)
        Me.lblS.TabIndex = 20
        Me.lblS.Text = "Superficie"
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Location = New System.Drawing.Point(33, 60)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(34, 13)
        Me.lblH.TabIndex = 19
        Me.lblH.Text = "Altura"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(34, 35)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(31, 13)
        Me.lblB.TabIndex = 18
        Me.lblB.Text = "Base"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(126, 151)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 17
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdCalcular
        '
        Me.cmdCalcular.Location = New System.Drawing.Point(34, 151)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalcular.TabIndex = 16
        Me.cmdCalcular.Text = "Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = True
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(95, 116)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(100, 20)
        Me.txtP.TabIndex = 15
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(96, 85)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(100, 20)
        Me.txtS.TabIndex = 14
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(95, 57)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(100, 20)
        Me.txtH.TabIndex = 13
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(96, 31)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 181)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdCalcular)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblP As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblH As Label
    Friend WithEvents lblB As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdCalcular As Button
    Friend WithEvents txtP As TextBox
    Friend WithEvents txtS As TextBox
    Friend WithEvents txtH As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label1 As Label
End Class
