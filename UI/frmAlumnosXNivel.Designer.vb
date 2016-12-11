<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosXNivel
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.cbxNivel = New System.Windows.Forms.ComboBox()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(170, 126)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 126)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 53
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(12, 21)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(146, 16)
        Me.Titulo.TabIndex = 52
        Me.Titulo.Text = "Seleccione un Nivel"
        '
        'cbxNivel
        '
        Me.cbxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNivel.FormattingEnabled = True
        Me.cbxNivel.Location = New System.Drawing.Point(84, 56)
        Me.cbxNivel.Name = "cbxNivel"
        Me.cbxNivel.Size = New System.Drawing.Size(161, 21)
        Me.cbxNivel.TabIndex = 50
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.Location = New System.Drawing.Point(12, 57)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(40, 16)
        Me.lblNivel.TabIndex = 51
        Me.lblNivel.Text = "Nivel"
        '
        'frmAlumnosXNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 163)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.cbxNivel)
        Me.Controls.Add(Me.lblNivel)
        Me.Name = "frmAlumnosXNivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmAlumnosXNivel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents cbxNivel As System.Windows.Forms.ComboBox
    Friend WithEvents lblNivel As System.Windows.Forms.Label
End Class
