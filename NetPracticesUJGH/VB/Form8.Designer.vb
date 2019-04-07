<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.cajaImagen = New System.Windows.Forms.PictureBox()
        Me.botonNoVisible = New System.Windows.Forms.Button()
        Me.botonVisible = New System.Windows.Forms.Button()
        CType(Me.cajaImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cajaImagen
        '
        Me.cajaImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cajaImagen.Image = CType(resources.GetObject("cajaImagen.Image"), System.Drawing.Image)
        Me.cajaImagen.InitialImage = CType(resources.GetObject("cajaImagen.InitialImage"), System.Drawing.Image)
        Me.cajaImagen.Location = New System.Drawing.Point(14, 53)
        Me.cajaImagen.Name = "cajaImagen"
        Me.cajaImagen.Size = New System.Drawing.Size(257, 194)
        Me.cajaImagen.TabIndex = 5
        Me.cajaImagen.TabStop = False
        '
        'botonNoVisible
        '
        Me.botonNoVisible.Location = New System.Drawing.Point(180, 14)
        Me.botonNoVisible.Name = "botonNoVisible"
        Me.botonNoVisible.Size = New System.Drawing.Size(75, 23)
        Me.botonNoVisible.TabIndex = 4
        Me.botonNoVisible.Text = "&No Visible"
        Me.botonNoVisible.UseVisualStyleBackColor = True
        '
        'botonVisible
        '
        Me.botonVisible.Location = New System.Drawing.Point(23, 14)
        Me.botonVisible.Name = "botonVisible"
        Me.botonVisible.Size = New System.Drawing.Size(75, 23)
        Me.botonVisible.TabIndex = 3
        Me.botonVisible.Text = "&Visible"
        Me.botonVisible.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cajaImagen)
        Me.Controls.Add(Me.botonNoVisible)
        Me.Controls.Add(Me.botonVisible)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.cajaImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cajaImagen As PictureBox
    Friend WithEvents botonNoVisible As Button
    Friend WithEvents botonVisible As Button
End Class
