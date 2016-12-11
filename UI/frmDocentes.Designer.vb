<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocentes))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.datos_Docente = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFIngreso = New System.Windows.Forms.Label()
        Me.btnBuscaDNI = New System.Windows.Forms.Button()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbxActivo = New System.Windows.Forms.CheckBox()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.lblCUIL = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.ComboBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblLlocalidad = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblNivelEscolar = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.datos_Docente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(839, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 29)
        Me.btnSalir.TabIndex = 68
        Me.btnSalir.Text = "&SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGrabar.Location = New System.Drawing.Point(721, 350)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(100, 29)
        Me.btnGrabar.TabIndex = 67
        Me.btnGrabar.Text = "&GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'datos_Docente
        '
        Me.datos_Docente.Controls.Add(Me.txtLocalidad)
        Me.datos_Docente.Controls.Add(Me.txtFechaIngreso)
        Me.datos_Docente.Controls.Add(Me.txtFNacimiento)
        Me.datos_Docente.Controls.Add(Me.lblFIngreso)
        Me.datos_Docente.Controls.Add(Me.btnBuscaDNI)
        Me.datos_Docente.Controls.Add(Me.btnBuscaApell)
        Me.datos_Docente.Controls.Add(Me.txtEdad)
        Me.datos_Docente.Controls.Add(Me.GroupBox1)
        Me.datos_Docente.Controls.Add(Me.lblHoras)
        Me.datos_Docente.Controls.Add(Me.lblCargo)
        Me.datos_Docente.Controls.Add(Me.txtHoras)
        Me.datos_Docente.Controls.Add(Me.txtCargo)
        Me.datos_Docente.Controls.Add(Me.txtEstadoCivil)
        Me.datos_Docente.Controls.Add(Me.txtCUIL)
        Me.datos_Docente.Controls.Add(Me.lblCUIL)
        Me.datos_Docente.Controls.Add(Me.lblEstadoCivil)
        Me.datos_Docente.Controls.Add(Me.txtCP)
        Me.datos_Docente.Controls.Add(Me.lblCP)
        Me.datos_Docente.Controls.Add(Me.txtNacionalidad)
        Me.datos_Docente.Controls.Add(Me.lblNacionalidad)
        Me.datos_Docente.Controls.Add(Me.txtObservaciones)
        Me.datos_Docente.Controls.Add(Me.lblObservaciones)
        Me.datos_Docente.Controls.Add(Me.lblCelular)
        Me.datos_Docente.Controls.Add(Me.lblTelefono)
        Me.datos_Docente.Controls.Add(Me.lblEmail)
        Me.datos_Docente.Controls.Add(Me.txtSexo)
        Me.datos_Docente.Controls.Add(Me.txtCelular)
        Me.datos_Docente.Controls.Add(Me.txtTelefono)
        Me.datos_Docente.Controls.Add(Me.txtEmail)
        Me.datos_Docente.Controls.Add(Me.txtApellido)
        Me.datos_Docente.Controls.Add(Me.txtDomicilio)
        Me.datos_Docente.Controls.Add(Me.txtDNI)
        Me.datos_Docente.Controls.Add(Me.lblLlocalidad)
        Me.datos_Docente.Controls.Add(Me.txtNombre)
        Me.datos_Docente.Controls.Add(Me.lblDomicilio)
        Me.datos_Docente.Controls.Add(Me.lblNivelEscolar)
        Me.datos_Docente.Controls.Add(Me.lblEdad)
        Me.datos_Docente.Controls.Add(Me.lblNacimiento)
        Me.datos_Docente.Controls.Add(Me.lblDNI)
        Me.datos_Docente.Controls.Add(Me.lblApellido)
        Me.datos_Docente.Controls.Add(Me.lblNombre)
        Me.datos_Docente.Location = New System.Drawing.Point(12, 27)
        Me.datos_Docente.Name = "datos_Docente"
        Me.datos_Docente.Size = New System.Drawing.Size(927, 317)
        Me.datos_Docente.TabIndex = 65
        Me.datos_Docente.TabStop = False
        Me.datos_Docente.Text = "Datos Personales"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(507, 119)
        Me.txtLocalidad.MaxLength = 12
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(175, 20)
        Me.txtLocalidad.TabIndex = 72
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Checked = False
        Me.txtFechaIngreso.CustomFormat = "yyyy/MM/dd"
        Me.txtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaIngreso.Location = New System.Drawing.Point(685, 211)
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.ShowCheckBox = True
        Me.txtFechaIngreso.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaIngreso.TabIndex = 70
        Me.txtFechaIngreso.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'txtFNacimiento
        '
        Me.txtFNacimiento.Checked = False
        Me.txtFNacimiento.CustomFormat = "dd/MM/yyyy"
        Me.txtFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFNacimiento.Location = New System.Drawing.Point(104, 71)
        Me.txtFNacimiento.Name = "txtFNacimiento"
        Me.txtFNacimiento.ShowCheckBox = True
        Me.txtFNacimiento.Size = New System.Drawing.Size(94, 20)
        Me.txtFNacimiento.TabIndex = 5
        '
        'lblFIngreso
        '
        Me.lblFIngreso.AutoSize = True
        Me.lblFIngreso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblFIngreso.Location = New System.Drawing.Point(564, 211)
        Me.lblFIngreso.Name = "lblFIngreso"
        Me.lblFIngreso.Size = New System.Drawing.Size(118, 16)
        Me.lblFIngreso.TabIndex = 71
        Me.lblFIngreso.Text = "Fecha de Ingreso"
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = CType(resources.GetObject("btnBuscaDNI.Image"), System.Drawing.Image)
        Me.btnBuscaDNI.Location = New System.Drawing.Point(688, 9)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaDNI.TabIndex = 70
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(475, 9)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 69
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(290, 74)
        Me.txtEdad.MaxLength = 12
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(37, 20)
        Me.txtEdad.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.chbxActivo)
        Me.GroupBox1.Controls.Add(Me.lblActivo)
        Me.GroupBox1.Location = New System.Drawing.Point(695, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 49)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'chbxActivo
        '
        Me.chbxActivo.AutoSize = True
        Me.chbxActivo.Location = New System.Drawing.Point(69, 21)
        Me.chbxActivo.Name = "chbxActivo"
        Me.chbxActivo.Size = New System.Drawing.Size(15, 14)
        Me.chbxActivo.TabIndex = 22
        Me.chbxActivo.UseVisualStyleBackColor = True
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(16, 19)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(47, 16)
        Me.lblActivo.TabIndex = 64
        Me.lblActivo.Text = "Activo"
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoras.Location = New System.Drawing.Point(797, 210)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(44, 16)
        Me.lblHoras.TabIndex = 58
        Me.lblHoras.Text = "Horas"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.Location = New System.Drawing.Point(259, 212)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(46, 16)
        Me.lblCargo.TabIndex = 59
        Me.lblCargo.Text = "Cargo"
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(857, 209)
        Me.txtHoras.MaxLength = 12
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(53, 20)
        Me.txtHoras.TabIndex = 20
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(312, 211)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(240, 20)
        Me.txtCargo.TabIndex = 19
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.FormattingEnabled = True
        Me.txtEstadoCivil.Items.AddRange(New Object() {"Casado/a", "Soltero/a", "Viudo/a", "Divorciado/a", "Concuvino/a"})
        Me.txtEstadoCivil.Location = New System.Drawing.Point(96, 206)
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(138, 21)
        Me.txtEstadoCivil.TabIndex = 15
        '
        'txtCUIL
        '
        Me.txtCUIL.Location = New System.Drawing.Point(781, 27)
        Me.txtCUIL.MaxLength = 12
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.Size = New System.Drawing.Size(129, 20)
        Me.txtCUIL.TabIndex = 4
        '
        'lblCUIL
        '
        Me.lblCUIL.AutoSize = True
        Me.lblCUIL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUIL.Location = New System.Drawing.Point(737, 31)
        Me.lblCUIL.Name = "lblCUIL"
        Me.lblCUIL.Size = New System.Drawing.Size(38, 16)
        Me.lblCUIL.TabIndex = 56
        Me.lblCUIL.Text = "CUIL"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCivil.Location = New System.Drawing.Point(18, 196)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(50, 32)
        Me.lblEstadoCivil.TabIndex = 51
        Me.lblEstadoCivil.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Civil"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(364, 118)
        Me.txtCP.MaxLength = 12
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(53, 20)
        Me.txtCP.TabIndex = 10
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(332, 118)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(26, 16)
        Me.lblCP.TabIndex = 47
        Me.lblCP.Text = "CP"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(702, 76)
        Me.txtNacionalidad.MaxLength = 12
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(124, 20)
        Me.txtNacionalidad.TabIndex = 8
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(604, 76)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(92, 16)
        Me.lblNacionalidad.TabIndex = 46
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(125, 251)
        Me.txtObservaciones.MaxLength = 2000
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(785, 51)
        Me.txtObservaciones.TabIndex = 21
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(18, 252)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 39
        Me.lblObservaciones.Text = "Observaciones"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(323, 167)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(54, 16)
        Me.lblCelular.TabIndex = 39
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(18, 167)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(63, 16)
        Me.lblTelefono.TabIndex = 39
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(602, 168)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "E-mail"
        '
        'txtSexo
        '
        Me.txtSexo.FormattingEnabled = True
        Me.txtSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.txtSexo.Location = New System.Drawing.Point(434, 74)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(100, 21)
        Me.txtSexo.TabIndex = 7
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(383, 166)
        Me.txtCelular.MaxLength = 12
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(199, 20)
        Me.txtCelular.TabIndex = 13
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(96, 166)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(209, 20)
        Me.txtTelefono.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(656, 167)
        Me.txtEmail.MaxLength = 75
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 20)
        Me.txtEmail.TabIndex = 14
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(300, 27)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(169, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(94, 117)
        Me.txtDomicilio.MaxLength = 250
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(211, 33)
        Me.txtDomicilio.TabIndex = 9
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(558, 27)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(124, 20)
        Me.txtDNI.TabIndex = 3
        '
        'lblLlocalidad
        '
        Me.lblLlocalidad.AutoSize = True
        Me.lblLlocalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLlocalidad.Location = New System.Drawing.Point(430, 119)
        Me.lblLlocalidad.Name = "lblLlocalidad"
        Me.lblLlocalidad.Size = New System.Drawing.Size(71, 16)
        Me.lblLlocalidad.TabIndex = 40
        Me.lblLlocalidad.Text = "Localidad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 27)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(138, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(16, 118)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(68, 16)
        Me.lblDomicilio.TabIndex = 40
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblNivelEscolar
        '
        Me.lblNivelEscolar.AutoSize = True
        Me.lblNivelEscolar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelEscolar.Location = New System.Drawing.Point(380, 75)
        Me.lblNivelEscolar.Name = "lblNivelEscolar"
        Me.lblNivelEscolar.Size = New System.Drawing.Size(41, 16)
        Me.lblNivelEscolar.TabIndex = 39
        Me.lblNivelEscolar.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(229, 74)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(40, 16)
        Me.lblEdad.TabIndex = 40
        Me.lblEdad.Text = "Edad"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(18, 64)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(80, 32)
        Me.lblNacimiento.TabIndex = 39
        Me.lblNacimiento.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(522, 31)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(233, 31)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(18, 31)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(603, 350)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 29)
        Me.btnNuevo.TabIndex = 69
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Kumelen.My.Resources.Resources.imprimir
        Me.Button1.Location = New System.Drawing.Point(880, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 52)
        Me.Button1.TabIndex = 70
        Me.Button1.Tag = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 395)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.datos_Docente)
        Me.Name = "frmDocentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Docentes"
        Me.datos_Docente.ResumeLayout(False)
        Me.datos_Docente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents datos_Docente As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblLlocalidad As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblNivelEscolar As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents txtCUIL As System.Windows.Forms.TextBox
    Friend WithEvents lblCUIL As System.Windows.Forms.Label
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents chbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblActivo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents lblFIngreso As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtFNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
End Class
