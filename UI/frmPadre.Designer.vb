<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadre))
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.datos_padre = New System.Windows.Forms.GroupBox()
        Me.txtNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.cbxEscolaridad = New System.Windows.Forms.ComboBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.txtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblLlocalidad = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblNivelEscolar = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.datos_padre.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(664, 292)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 15
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGrabar.Location = New System.Drawing.Point(546, 292)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(100, 29)
        Me.btnGrabar.TabIndex = 14
        Me.btnGrabar.Text = "&GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'datos_padre
        '
        Me.datos_padre.Controls.Add(Me.txtNacimiento)
        Me.datos_padre.Controls.Add(Me.btnBuscaApell)
        Me.datos_padre.Controls.Add(Me.lblCelular)
        Me.datos_padre.Controls.Add(Me.lblTelefono)
        Me.datos_padre.Controls.Add(Me.lblEmail)
        Me.datos_padre.Controls.Add(Me.lblEmpresa)
        Me.datos_padre.Controls.Add(Me.lblOcupacion)
        Me.datos_padre.Controls.Add(Me.cbxEscolaridad)
        Me.datos_padre.Controls.Add(Me.txtCelular)
        Me.datos_padre.Controls.Add(Me.txtTelefono)
        Me.datos_padre.Controls.Add(Me.txtEmail)
        Me.datos_padre.Controls.Add(Me.txtEmpresa)
        Me.datos_padre.Controls.Add(Me.txtOcupacion)
        Me.datos_padre.Controls.Add(Me.txtEstadoCivil)
        Me.datos_padre.Controls.Add(Me.txtApellido)
        Me.datos_padre.Controls.Add(Me.txtDomicilio)
        Me.datos_padre.Controls.Add(Me.txtLocalidad)
        Me.datos_padre.Controls.Add(Me.txtEdad)
        Me.datos_padre.Controls.Add(Me.txtDNI)
        Me.datos_padre.Controls.Add(Me.lblLlocalidad)
        Me.datos_padre.Controls.Add(Me.txtNombre)
        Me.datos_padre.Controls.Add(Me.lblDomicilio)
        Me.datos_padre.Controls.Add(Me.lblNivelEscolar)
        Me.datos_padre.Controls.Add(Me.lblEdad)
        Me.datos_padre.Controls.Add(Me.lblEstadoCivil)
        Me.datos_padre.Controls.Add(Me.lblNacimiento)
        Me.datos_padre.Controls.Add(Me.lblDNI)
        Me.datos_padre.Controls.Add(Me.lblApellido)
        Me.datos_padre.Controls.Add(Me.lblNombre)
        Me.datos_padre.Location = New System.Drawing.Point(16, 17)
        Me.datos_padre.Name = "datos_padre"
        Me.datos_padre.Size = New System.Drawing.Size(748, 250)
        Me.datos_padre.TabIndex = 65
        Me.datos_padre.TabStop = False
        Me.datos_padre.Text = "Datos del Padre"
        '
        'txtNacimiento
        '
        Me.txtNacimiento.Checked = False
        Me.txtNacimiento.CustomFormat = "dd/MM/yyyy"
        Me.txtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtNacimiento.Location = New System.Drawing.Point(87, 63)
        Me.txtNacimiento.Name = "txtNacimiento"
        Me.txtNacimiento.ShowCheckBox = True
        Me.txtNacimiento.Size = New System.Drawing.Size(94, 20)
        Me.txtNacimiento.TabIndex = 4
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(510, 13)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 70
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(238, 211)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(54, 16)
        Me.lblCelular.TabIndex = 39
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(9, 211)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(63, 16)
        Me.lblTelefono.TabIndex = 39
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(488, 211)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "E-mail"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(484, 166)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(63, 16)
        Me.lblEmpresa.TabIndex = 39
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblOcupacion
        '
        Me.lblOcupacion.AutoSize = True
        Me.lblOcupacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.Location = New System.Drawing.Point(238, 166)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(76, 16)
        Me.lblOcupacion.TabIndex = 39
        Me.lblOcupacion.Text = "Ocupación"
        '
        'cbxEscolaridad
        '
        Me.cbxEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEscolaridad.FormattingEnabled = True
        Me.cbxEscolaridad.Items.AddRange(New Object() {"Ninguno", "Primario", "Secundario", "Terciario", "Universitario"})
        Me.cbxEscolaridad.Location = New System.Drawing.Point(412, 66)
        Me.cbxEscolaridad.Name = "cbxEscolaridad"
        Me.cbxEscolaridad.Size = New System.Drawing.Size(180, 21)
        Me.cbxEscolaridad.TabIndex = 5
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(307, 210)
        Me.txtCelular.MaxLength = 100
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(157, 20)
        Me.txtCelular.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(87, 210)
        Me.txtTelefono.MaxLength = 100
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(128, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(553, 210)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(553, 167)
        Me.txtEmpresa.MaxLength = 100
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(173, 20)
        Me.txtEmpresa.TabIndex = 10
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Location = New System.Drawing.Point(317, 165)
        Me.txtOcupacion.MaxLength = 100
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(157, 20)
        Me.txtOcupacion.TabIndex = 9
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Location = New System.Drawing.Point(87, 167)
        Me.txtEstadoCivil.MaxLength = 100
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(128, 20)
        Me.txtEstadoCivil.TabIndex = 8
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(324, 19)
        Me.txtApellido.MaxLength = 100
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(180, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(87, 109)
        Me.txtDomicilio.MaxLength = 250
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(323, 33)
        Me.txtDomicilio.TabIndex = 6
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(546, 109)
        Me.txtLocalidad.MaxLength = 100
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(180, 20)
        Me.txtLocalidad.TabIndex = 7
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(241, 66)
        Me.txtEdad.MaxLength = 12
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(40, 20)
        Me.txtEdad.TabIndex = 42
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(598, 19)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(128, 20)
        Me.txtDNI.TabIndex = 3
        '
        'lblLlocalidad
        '
        Me.lblLlocalidad.AutoSize = True
        Me.lblLlocalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlocalidad.Location = New System.Drawing.Point(465, 110)
        Me.lblLlocalidad.Name = "lblLlocalidad"
        Me.lblLlocalidad.Size = New System.Drawing.Size(71, 16)
        Me.lblLlocalidad.TabIndex = 40
        Me.lblLlocalidad.Text = "Localidad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 19)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(9, 110)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(68, 16)
        Me.lblDomicilio.TabIndex = 40
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblNivelEscolar
        '
        Me.lblNivelEscolar.AutoSize = True
        Me.lblNivelEscolar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelEscolar.Location = New System.Drawing.Point(314, 55)
        Me.lblNivelEscolar.Name = "lblNivelEscolar"
        Me.lblNivelEscolar.Size = New System.Drawing.Size(82, 32)
        Me.lblNivelEscolar.TabIndex = 39
        Me.lblNivelEscolar.Text = "Nivel de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "escolaridad"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(185, 66)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(40, 16)
        Me.lblEdad.TabIndex = 40
        Me.lblEdad.Text = "Edad"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(9, 155)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(50, 32)
        Me.lblEstadoCivil.TabIndex = 39
        Me.lblEstadoCivil.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Civil"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(9, 59)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(80, 32)
        Me.lblNacimiento.TabIndex = 39
        Me.lblNacimiento.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(562, 20)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(257, 20)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'btnNuevo
        '
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Location = New System.Drawing.Point(428, 292)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 29)
        Me.btnNuevo.TabIndex = 66
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 333)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.datos_padre)
        Me.Name = "frmPadre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "<< Datos del Padre >>"
        Me.datos_padre.ResumeLayout(False)
        Me.datos_padre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents datos_padre As System.Windows.Forms.GroupBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblOcupacion As System.Windows.Forms.Label
    Friend WithEvents cbxEscolaridad As System.Windows.Forms.ComboBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtOcupacion As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblLlocalidad As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblNivelEscolar As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents txtNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
