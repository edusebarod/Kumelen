<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeudaAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeudaAlumno))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscaDNI = New System.Windows.Forms.Button()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(481, 199)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(586, 199)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = CType(resources.GetObject("btnBuscaDNI.Image"), System.Drawing.Image)
        Me.btnBuscaDNI.Location = New System.Drawing.Point(281, 67)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaDNI.TabIndex = 69
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(95, 137)
        Me.txtSala.MaxLength = 12
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(206, 20)
        Me.txtSala.TabIndex = 4
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(624, 13)
        Me.btnBuscaApell.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 70
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(17, 137)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 68
        Me.lblSala.Text = "Sala"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(412, 31)
        Me.txtApellido.MaxLength = 12
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(206, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(95, 85)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(180, 20)
        Me.txtDNI.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(95, 28)
        Me.txtNombre.MaxLength = 12
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(17, 86)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 66
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(334, 35)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 65
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 67
        Me.lblNombre.Text = "Nombre"
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(412, 133)
        Me.txtTurno.MaxLength = 12
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(206, 20)
        Me.txtTurno.TabIndex = 5
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(334, 133)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 72
        Me.lblTurno.Text = "Turno"
        '
        'frmDeudaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 234)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnBuscaDNI)
        Me.Controls.Add(Me.txtSala)
        Me.Controls.Add(Me.btnBuscaApell)
        Me.Controls.Add(Me.lblSala)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmDeudaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buscador Alumno con Deuda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents txtSala As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
End Class
