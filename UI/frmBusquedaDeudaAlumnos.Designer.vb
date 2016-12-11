<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaDeudaAlumnos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaDeudaAlumnos))
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.btnBuscaLeg = New System.Windows.Forms.Button()
        Me.btnBuscaDNI = New System.Windows.Forms.Button()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.datos_sala = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.txtDescuento = New System.Windows.Forms.MaskedTextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtTurno = New System.Windows.Forms.ComboBox()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdVer = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.datos_alumno.SuspendLayout()
        Me.datos_sala.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLegajo
        '
        Me.lblLegajo.AutoSize = True
        Me.lblLegajo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegajo.Location = New System.Drawing.Point(14, 38)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(52, 16)
        Me.lblLegajo.TabIndex = 37
        Me.lblLegajo.Text = "Legajo"
        '
        'txtLegajo
        '
        Me.txtLegajo.Location = New System.Drawing.Point(96, 38)
        Me.txtLegajo.MaxLength = 12
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(137, 20)
        Me.txtLegajo.TabIndex = 1
        '
        'datos_alumno
        '
        Me.datos_alumno.Controls.Add(Me.btnBuscaLeg)
        Me.datos_alumno.Controls.Add(Me.btnBuscaDNI)
        Me.datos_alumno.Controls.Add(Me.btnBuscaApell)
        Me.datos_alumno.Controls.Add(Me.txtApellido)
        Me.datos_alumno.Controls.Add(Me.txtDNI)
        Me.datos_alumno.Controls.Add(Me.txtNombre)
        Me.datos_alumno.Controls.Add(Me.lblDNI)
        Me.datos_alumno.Controls.Add(Me.lblApellido)
        Me.datos_alumno.Controls.Add(Me.txtLegajo)
        Me.datos_alumno.Controls.Add(Me.lblNombre)
        Me.datos_alumno.Controls.Add(Me.lblLegajo)
        Me.datos_alumno.Location = New System.Drawing.Point(18, 22)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(622, 123)
        Me.datos_alumno.TabIndex = 7
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'btnBuscaLeg
        '
        Me.btnBuscaLeg.Image = CType(resources.GetObject("btnBuscaLeg.Image"), System.Drawing.Image)
        Me.btnBuscaLeg.Location = New System.Drawing.Point(243, 20)
        Me.btnBuscaLeg.Name = "btnBuscaLeg"
        Me.btnBuscaLeg.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaLeg.TabIndex = 2
        Me.btnBuscaLeg.UseVisualStyleBackColor = True
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = CType(resources.GetObject("btnBuscaDNI.Image"), System.Drawing.Image)
        Me.btnBuscaDNI.Location = New System.Drawing.Point(570, 19)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaDNI.TabIndex = 11
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(570, 70)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 9
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(384, 74)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(180, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(384, 37)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(180, 20)
        Me.txtDNI.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 73)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 7
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(326, 31)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(295, 77)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(14, 77)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'datos_sala
        '
        Me.datos_sala.Controls.Add(Me.Label2)
        Me.datos_sala.Controls.Add(Me.cbxCurso)
        Me.datos_sala.Controls.Add(Me.txtDescuento)
        Me.datos_sala.Controls.Add(Me.lblDescuento)
        Me.datos_sala.Controls.Add(Me.txtTurno)
        Me.datos_sala.Controls.Add(Me.lblSala)
        Me.datos_sala.Controls.Add(Me.lblTurno)
        Me.datos_sala.Location = New System.Drawing.Point(18, 151)
        Me.datos_sala.Name = "datos_sala"
        Me.datos_sala.Size = New System.Drawing.Size(622, 99)
        Me.datos_sala.TabIndex = 28
        Me.datos_sala.TabStop = False
        Me.datos_sala.Text = "Datos de la Sala"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "%"
        '
        'cbxCurso
        '
        Me.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(370, 24)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(161, 21)
        Me.cbxCurso.TabIndex = 29
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(100, 65)
        Me.txtDescuento.Mask = "99999"
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(46, 20)
        Me.txtDescuento.TabIndex = 31
        Me.txtDescuento.ValidatingType = GetType(Integer)
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(20, 66)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(74, 16)
        Me.lblDescuento.TabIndex = 46
        Me.lblDescuento.Text = "Descuento"
        '
        'txtTurno
        '
        Me.txtTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTurno.FormattingEnabled = True
        Me.txtTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.txtTurno.Location = New System.Drawing.Point(96, 23)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(137, 21)
        Me.txtTurno.TabIndex = 28
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(298, 25)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 44
        Me.lblSala.Text = "Sala"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(20, 27)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 43
        Me.lblTurno.Text = "Turno"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(540, 256)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 36
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdVer
        '
        Me.cmdVer.Location = New System.Drawing.Point(434, 256)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(100, 29)
        Me.cmdVer.TabIndex = 34
        Me.cmdVer.Text = "&VER"
        Me.cmdVer.UseVisualStyleBackColor = True
        '
        'frmBusquedaDeudaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 293)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdVer)
        Me.Controls.Add(Me.datos_sala)
        Me.Controls.Add(Me.datos_alumno)
        Me.Name = "frmBusquedaDeudaAlumnos"
        Me.Text = "Deuda de un Alumno"
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.datos_sala.ResumeLayout(False)
        Me.datos_sala.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLegajo As System.Windows.Forms.Label
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents datos_sala As System.Windows.Forms.GroupBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdVer As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBuscaLeg As System.Windows.Forms.Button
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents txtDescuento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
