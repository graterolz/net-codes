Public Class FormaTruco4
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnJugar As System.Windows.Forms.Button
    Friend WithEvents lblletras As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnintermedio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnListo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormaTruco4))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnListo = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblletras = New System.Windows.Forms.Label
        Me.btnJugar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbnintermedio = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnListo)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblletras)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Ingresa:"
        '
        'btnListo
        '
        Me.btnListo.Location = New System.Drawing.Point(300, 43)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(50, 50)
        Me.btnListo.TabIndex = 11
        Me.btnListo.Text = "Listo"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(230, 43)
        Me.TextBox5.MaxLength = 1
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(50, 50)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(174, 43)
        Me.TextBox4.MaxLength = 1
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(50, 50)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(118, 43)
        Me.TextBox3.MaxLength = 1
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(50, 50)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(62, 43)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(50, 50)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 43)
        Me.TextBox1.MaxLength = 1
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(50, 50)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblletras
        '
        Me.lblletras.AutoSize = True
        Me.lblletras.Location = New System.Drawing.Point(81, 16)
        Me.lblletras.Name = "lblletras"
        Me.lblletras.Size = New System.Drawing.Size(31, 13)
        Me.lblletras.TabIndex = 0
        Me.lblletras.Text = "????"
        '
        'btnJugar
        '
        Me.btnJugar.Enabled = False
        Me.btnJugar.Location = New System.Drawing.Point(96, 117)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(140, 48)
        Me.btnJugar.TabIndex = 1
        Me.btnJugar.Text = "Jugar"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnintermedio)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(78, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nivel"
        '
        'rbnintermedio
        '
        Me.rbnintermedio.Location = New System.Drawing.Point(6, 19)
        Me.rbnintermedio.Name = "rbnintermedio"
        Me.rbnintermedio.Size = New System.Drawing.Size(62, 20)
        Me.rbnintermedio.TabIndex = 2
        Me.rbnintermedio.Text = "Normal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 99)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3.- Ingresa rapidamente los digitos."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2.- Memoriza los digitos mostrados."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1.- Selecciona el nivel a Jugar y Presiona el boton."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(269, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormaTruco4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(374, 282)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(382, 316)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(382, 316)
        Me.Name = "FormaTruco4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memoria del Teclado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim a, b As Short
    Dim cont As Short
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnintermedio.CheckedChanged
        cont = 5
        fin()
        lblletras.Text = ""
        btnJugar.Enabled = True
        TextBox4.Visible = True
        TextBox5.Visible = True
    End Sub
    Private Sub btnJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJugar.Click
        Dim i, y As Short
        Dim x As System.Random
        x = New System.Random
        For i = 1 To cont
            y = x.Next(65, 91)
            lblletras.Text = lblletras.Text & Chr(y)
        Next
        TextBox1.Text = "" : TextBox1.ReadOnly = False
        TextBox2.Text = "" : TextBox2.ReadOnly = False
        TextBox3.Text = "" : TextBox3.ReadOnly = False
        TextBox4.Text = "" : TextBox4.ReadOnly = False
        TextBox5.Text = "" : TextBox5.ReadOnly = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        lblletras.Visible = True
        btnJugar.Enabled = False
        btnListo.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub FormaTruco4_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormaPrincipal.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 0
        b = 0
        cont = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        a = a + 10
        If rbnintermedio.Checked = True Then
            If a = 1000 Then
                MessageBox.Show("Te demorastes mucho, intenta de nuevo")
                fin()
                Timer1.Enabled = False
                a = 0
                b = 0
                cont = 0
                btnJugar.Enabled = False
            End If
        End If
    End Sub
    Private Sub fin()

        'btnJugar.Enabled = False
        TextBox1.Text = "" : TextBox1.ReadOnly = True
        TextBox2.Text = "" : TextBox2.ReadOnly = True
        TextBox3.Text = "" : TextBox3.ReadOnly = True
        TextBox4.Text = "" : TextBox4.ReadOnly = True
        TextBox5.Text = "" : TextBox5.ReadOnly = True
        '        lblletras.Text = ""

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = TextBox1.Text.ToUpper
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = TextBox2.Text.ToUpper
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.Text = TextBox3.Text.ToUpper
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        If cont = 5 Or cont = 7 Then
            TextBox4.Text = TextBox4.Text.ToUpper
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If cont = 5 Or cont = 7 Then
            TextBox5.Text = TextBox5.Text.ToUpper
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        b = b + 10
        If rbnintermedio.Checked = True Then
            If b = 400 Then
                lblletras.Visible = False
            End If
        End If
    End Sub

    Private Sub btnListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListo.Click
        Dim z As String
        z = Trim(TextBox1.Text.ToUpper) & Trim(TextBox2.Text.ToUpper) & Trim(TextBox3.Text.ToUpper) & Trim(TextBox4.Text.ToUpper) & Trim(TextBox5.Text.ToUpper)
        If Trim(lblletras.Text.ToUpper) = z Then
            lblletras.Visible = True

            MsgBox("Ganastes!!!")
        Else
            MsgBox("Perdiste!!! D:")
            lblletras.Visible = True
            lblletras.Text = ""

        End If
        Timer1.Enabled = False
        Timer2.Enabled = False
        btnJugar.Enabled = False
        btnListo.Enabled = False
        rbnintermedio.Checked = False
        a = 0
        b = 0
        cont = 0
    End Sub
End Class
