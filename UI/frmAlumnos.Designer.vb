<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.ComboBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.btnBuscaDNI = New System.Windows.Forms.Button()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtMedicacion = New System.Windows.Forms.TextBox()
        Me.lblMedicacion = New System.Windows.Forms.Label()
        Me.txtAlergias = New System.Windows.Forms.TextBox()
        Me.lblAlergias = New System.Windows.Forms.Label()
        Me.txtEstadoSalud = New System.Windows.Forms.ComboBox()
        Me.lblEstadoSalud = New System.Windows.Forms.Label()
        Me.txtEnfermedades = New System.Windows.Forms.TextBox()
        Me.lblEnfermedades = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.ComboBox()
        Me.txtObraSocial = New System.Windows.Forms.TextBox()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.l_dom = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblObraSocial = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.datos_sala = New System.Windows.Forms.GroupBox()
        Me.txtHorario = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.ComboBox()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJuegos = New System.Windows.Forms.TextBox()
        Me.lblJuegos = New System.Windows.Forms.Label()
        Me.cbxRelacionPlantas = New System.Windows.Forms.CheckBox()
        Me.cbxPlantas = New System.Windows.Forms.CheckBox()
        Me.cbxAnimales = New System.Windows.Forms.CheckBox()
        Me.cbxEspaciosVerdes = New System.Windows.Forms.CheckBox()
        Me.cbxPatio = New System.Windows.Forms.CheckBox()
        Me.txtVivienda = New System.Windows.Forms.ComboBox()
        Me.lblVivienda = New System.Windows.Forms.Label()
        Me.cmdMadre = New System.Windows.Forms.Button()
        Me.cmdPadre = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.cmdNuevo2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscaLeg = New System.Windows.Forms.Button()
        Me.cbxActivo = New System.Windows.Forms.CheckBox()
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.txtAnoLectivo = New System.Windows.Forms.TextBox()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.lblAnoLectivo = New System.Windows.Forms.Label()
        Me.datos_alumno.SuspendLayout()
        Me.datos_sala.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLegajo
        '
        Me.lblLegajo.AutoSize = True
        Me.lblLegajo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegajo.Location = New System.Drawing.Point(12, 18)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(52, 16)
        Me.lblLegajo.TabIndex = 37
        Me.lblLegajo.Text = "Legajo"
        '
        'txtLegajo
        '
        Me.txtLegajo.Location = New System.Drawing.Point(76, 14)
        Me.txtLegajo.MaxLength = 12
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(180, 20)
        Me.txtLegajo.TabIndex = 38
        '
        'datos_alumno
        '
        Me.datos_alumno.Controls.Add(Me.txtLocalidad)
        Me.datos_alumno.Controls.Add(Me.lblLocalidad)
        Me.datos_alumno.Controls.Add(Me.btnBuscaDNI)
        Me.datos_alumno.Controls.Add(Me.btnBuscaApell)
        Me.datos_alumno.Controls.Add(Me.txtObservaciones)
        Me.datos_alumno.Controls.Add(Me.lblObservaciones)
        Me.datos_alumno.Controls.Add(Me.txtMedicacion)
        Me.datos_alumno.Controls.Add(Me.lblMedicacion)
        Me.datos_alumno.Controls.Add(Me.txtAlergias)
        Me.datos_alumno.Controls.Add(Me.lblAlergias)
        Me.datos_alumno.Controls.Add(Me.txtEstadoSalud)
        Me.datos_alumno.Controls.Add(Me.lblEstadoSalud)
        Me.datos_alumno.Controls.Add(Me.txtEnfermedades)
        Me.datos_alumno.Controls.Add(Me.lblEnfermedades)
        Me.datos_alumno.Controls.Add(Me.txtSexo)
        Me.datos_alumno.Controls.Add(Me.txtObraSocial)
        Me.datos_alumno.Controls.Add(Me.txtFechaNacimiento)
        Me.datos_alumno.Controls.Add(Me.txtApellido)
        Me.datos_alumno.Controls.Add(Me.txtDomicilio)
        Me.datos_alumno.Controls.Add(Me.txtEdad)
        Me.datos_alumno.Controls.Add(Me.txtDNI)
        Me.datos_alumno.Controls.Add(Me.txtNombre)
        Me.datos_alumno.Controls.Add(Me.l_dom)
        Me.datos_alumno.Controls.Add(Me.lblSexo)
        Me.datos_alumno.Controls.Add(Me.lblEdad)
        Me.datos_alumno.Controls.Add(Me.lblObraSocial)
        Me.datos_alumno.Controls.Add(Me.lblNacimiento)
        Me.datos_alumno.Controls.Add(Me.lblDNI)
        Me.datos_alumno.Controls.Add(Me.lblApellido)
        Me.datos_alumno.Controls.Add(Me.lblNombre)
        Me.datos_alumno.Controls.Add(Me.ShapeContainer1)
        Me.datos_alumno.Location = New System.Drawing.Point(18, 154)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(921, 340)
        Me.datos_alumno.TabIndex = 50
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.FormattingEnabled = True
        Me.txtLocalidad.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.txtLocalidad.Location = New System.Drawing.Point(697, 103)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(180, 21)
        Me.txtLocalidad.TabIndex = 62
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(613, 105)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(71, 16)
        Me.lblLocalidad.TabIndex = 61
        Me.lblLocalidad.Text = "Localidad"
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscaDNI.Location = New System.Drawing.Point(883, 23)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaDNI.TabIndex = 59
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscaApell.Location = New System.Drawing.Point(573, 21)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaApell.TabIndex = 60
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(93, 296)
        Me.txtObservaciones.MaxLength = 2000
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(784, 34)
        Me.txtObservaciones.TabIndex = 41
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(22, 277)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 39
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtMedicacion
        '
        Me.txtMedicacion.Location = New System.Drawing.Point(697, 216)
        Me.txtMedicacion.MaxLength = 250
        Me.txtMedicacion.Multiline = True
        Me.txtMedicacion.Name = "txtMedicacion"
        Me.txtMedicacion.Size = New System.Drawing.Size(180, 63)
        Me.txtMedicacion.TabIndex = 41
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicacion.Location = New System.Drawing.Point(613, 217)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(81, 16)
        Me.lblMedicacion.TabIndex = 39
        Me.lblMedicacion.Text = "Medicación"
        '
        'txtAlergias
        '
        Me.txtAlergias.Location = New System.Drawing.Point(384, 217)
        Me.txtAlergias.MaxLength = 250
        Me.txtAlergias.Multiline = True
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(180, 63)
        Me.txtAlergias.TabIndex = 41
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlergias.Location = New System.Drawing.Point(298, 217)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.Size = New System.Drawing.Size(60, 16)
        Me.lblAlergias.TabIndex = 39
        Me.lblAlergias.Text = "Alergias"
        '
        'txtEstadoSalud
        '
        Me.txtEstadoSalud.FormattingEnabled = True
        Me.txtEstadoSalud.Items.AddRange(New Object() {"Excelente", "Muy bueno", "Bueno", "Regular"})
        Me.txtEstadoSalud.Location = New System.Drawing.Point(95, 228)
        Me.txtEstadoSalud.Name = "txtEstadoSalud"
        Me.txtEstadoSalud.Size = New System.Drawing.Size(180, 21)
        Me.txtEstadoSalud.TabIndex = 45
        '
        'lblEstadoSalud
        '
        Me.lblEstadoSalud.AutoSize = True
        Me.lblEstadoSalud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoSalud.Location = New System.Drawing.Point(22, 217)
        Me.lblEstadoSalud.Name = "lblEstadoSalud"
        Me.lblEstadoSalud.Size = New System.Drawing.Size(65, 32)
        Me.lblEstadoSalud.TabIndex = 39
        Me.lblEstadoSalud.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salud"
        '
        'txtEnfermedades
        '
        Me.txtEnfermedades.Location = New System.Drawing.Point(384, 168)
        Me.txtEnfermedades.MaxLength = 250
        Me.txtEnfermedades.Multiline = True
        Me.txtEnfermedades.Name = "txtEnfermedades"
        Me.txtEnfermedades.Size = New System.Drawing.Size(493, 33)
        Me.txtEnfermedades.TabIndex = 41
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.AutoSize = True
        Me.lblEnfermedades.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.Location = New System.Drawing.Point(298, 169)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(87, 32)
        Me.lblEnfermedades.TabIndex = 39
        Me.lblEnfermedades.Text = "Enferedades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "padecidas"
        '
        'txtSexo
        '
        Me.txtSexo.FormattingEnabled = True
        Me.txtSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.txtSexo.Location = New System.Drawing.Point(697, 59)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(180, 21)
        Me.txtSexo.TabIndex = 43
        '
        'txtObraSocial
        '
        Me.txtObraSocial.Location = New System.Drawing.Point(95, 181)
        Me.txtObraSocial.MaxLength = 12
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.Size = New System.Drawing.Size(180, 20)
        Me.txtObraSocial.TabIndex = 41
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(95, 59)
        Me.txtFechaNacimiento.MaxLength = 12
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(180, 20)
        Me.txtFechaNacimiento.TabIndex = 41
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(387, 19)
        Me.txtApellido.MaxLength = 12
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(180, 20)
        Me.txtApellido.TabIndex = 41
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(95, 102)
        Me.txtDomicilio.MaxLength = 250
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(472, 33)
        Me.txtDomicilio.TabIndex = 42
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(387, 60)
        Me.txtEdad.MaxLength = 12
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(180, 20)
        Me.txtEdad.TabIndex = 42
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(697, 19)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(180, 20)
        Me.txtDNI.TabIndex = 42
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(95, 19)
        Me.txtNombre.MaxLength = 12
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 42
        '
        'l_dom
        '
        Me.l_dom.AutoSize = True
        Me.l_dom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_dom.Location = New System.Drawing.Point(17, 103)
        Me.l_dom.Name = "l_dom"
        Me.l_dom.Size = New System.Drawing.Size(68, 16)
        Me.l_dom.TabIndex = 40
        Me.l_dom.Text = "Domicilio"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(613, 61)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(41, 16)
        Me.lblSexo.TabIndex = 39
        Me.lblSexo.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(298, 64)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(40, 16)
        Me.lblEdad.TabIndex = 40
        Me.lblEdad.Text = "Edad"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObraSocial.Location = New System.Drawing.Point(22, 169)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(48, 32)
        Me.lblObraSocial.TabIndex = 39
        Me.lblObraSocial.Text = "Obra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Social"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(17, 52)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(80, 32)
        Me.lblNacimiento.TabIndex = 39
        Me.lblNacimiento.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(613, 23)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(298, 23)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(915, 321)
        Me.ShapeContainer1.TabIndex = 44
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 843
        Me.LineShape1.Y1 = 135
        Me.LineShape1.Y2 = 136
        '
        'datos_sala
        '
        Me.datos_sala.Controls.Add(Me.txtHorario)
        Me.datos_sala.Controls.Add(Me.txtTurno)
        Me.datos_sala.Controls.Add(Me.txtSala)
        Me.datos_sala.Controls.Add(Me.lblHorario)
        Me.datos_sala.Controls.Add(Me.lblSala)
        Me.datos_sala.Controls.Add(Me.lblTurno)
        Me.datos_sala.Location = New System.Drawing.Point(15, 87)
        Me.datos_sala.Name = "datos_sala"
        Me.datos_sala.Size = New System.Drawing.Size(924, 61)
        Me.datos_sala.TabIndex = 51
        Me.datos_sala.TabStop = False
        Me.datos_sala.Text = "Datos de la Sala"
        '
        'txtHorario
        '
        Me.txtHorario.Location = New System.Drawing.Point(700, 24)
        Me.txtHorario.MaxLength = 12
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(180, 20)
        Me.txtHorario.TabIndex = 48
        '
        'txtTurno
        '
        Me.txtTurno.FormattingEnabled = True
        Me.txtTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.txtTurno.Location = New System.Drawing.Point(96, 23)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(125, 21)
        Me.txtTurno.TabIndex = 47
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(390, 27)
        Me.txtSala.MaxLength = 12
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(180, 20)
        Me.txtSala.TabIndex = 46
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorario.Location = New System.Drawing.Point(616, 23)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(55, 16)
        Me.lblHorario.TabIndex = 43
        Me.lblHorario.Text = "Horario"
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(301, 25)
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
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(348, 15)
        Me.txtFecha.MaxLength = 12
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(121, 20)
        Me.txtFecha.TabIndex = 46
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(295, 15)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 16)
        Me.lblFecha.TabIndex = 44
        Me.lblFecha.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJuegos)
        Me.GroupBox1.Controls.Add(Me.lblJuegos)
        Me.GroupBox1.Controls.Add(Me.cbxRelacionPlantas)
        Me.GroupBox1.Controls.Add(Me.cbxPlantas)
        Me.GroupBox1.Controls.Add(Me.cbxAnimales)
        Me.GroupBox1.Controls.Add(Me.cbxEspaciosVerdes)
        Me.GroupBox1.Controls.Add(Me.cbxPatio)
        Me.GroupBox1.Controls.Add(Me.txtVivienda)
        Me.GroupBox1.Controls.Add(Me.lblVivienda)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 500)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 100)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maternal"
        '
        'txtJuegos
        '
        Me.txtJuegos.Location = New System.Drawing.Point(92, 60)
        Me.txtJuegos.MaxLength = 2000
        Me.txtJuegos.Multiline = True
        Me.txtJuegos.Name = "txtJuegos"
        Me.txtJuegos.Size = New System.Drawing.Size(782, 34)
        Me.txtJuegos.TabIndex = 49
        '
        'lblJuegos
        '
        Me.lblJuegos.AutoSize = True
        Me.lblJuegos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuegos.Location = New System.Drawing.Point(19, 60)
        Me.lblJuegos.Name = "lblJuegos"
        Me.lblJuegos.Size = New System.Drawing.Size(72, 32)
        Me.lblJuegos.TabIndex = 48
        Me.lblJuegos.Text = "Juegos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "preferidos"
        '
        'cbxRelacionPlantas
        '
        Me.cbxRelacionPlantas.AutoSize = True
        Me.cbxRelacionPlantas.Location = New System.Drawing.Point(604, 17)
        Me.cbxRelacionPlantas.Name = "cbxRelacionPlantas"
        Me.cbxRelacionPlantas.Size = New System.Drawing.Size(142, 17)
        Me.cbxRelacionPlantas.TabIndex = 47
        Me.cbxRelacionPlantas.Text = "¿Se relaciona con ellas?"
        Me.cbxRelacionPlantas.UseVisualStyleBackColor = True
        '
        'cbxPlantas
        '
        Me.cbxPlantas.AutoSize = True
        Me.cbxPlantas.Location = New System.Drawing.Point(542, 17)
        Me.cbxPlantas.Name = "cbxPlantas"
        Me.cbxPlantas.Size = New System.Drawing.Size(61, 17)
        Me.cbxPlantas.TabIndex = 47
        Me.cbxPlantas.Text = "Plantas"
        Me.cbxPlantas.UseVisualStyleBackColor = True
        '
        'cbxAnimales
        '
        Me.cbxAnimales.AutoSize = True
        Me.cbxAnimales.Location = New System.Drawing.Point(468, 17)
        Me.cbxAnimales.Name = "cbxAnimales"
        Me.cbxAnimales.Size = New System.Drawing.Size(68, 17)
        Me.cbxAnimales.TabIndex = 47
        Me.cbxAnimales.Text = "Animales"
        Me.cbxAnimales.UseVisualStyleBackColor = True
        '
        'cbxEspaciosVerdes
        '
        Me.cbxEspaciosVerdes.AutoSize = True
        Me.cbxEspaciosVerdes.Location = New System.Drawing.Point(357, 17)
        Me.cbxEspaciosVerdes.Name = "cbxEspaciosVerdes"
        Me.cbxEspaciosVerdes.Size = New System.Drawing.Size(105, 17)
        Me.cbxEspaciosVerdes.TabIndex = 47
        Me.cbxEspaciosVerdes.Text = "Espacios Verdes"
        Me.cbxEspaciosVerdes.UseVisualStyleBackColor = True
        '
        'cbxPatio
        '
        Me.cbxPatio.AutoSize = True
        Me.cbxPatio.Location = New System.Drawing.Point(301, 17)
        Me.cbxPatio.Name = "cbxPatio"
        Me.cbxPatio.Size = New System.Drawing.Size(50, 17)
        Me.cbxPatio.TabIndex = 47
        Me.cbxPatio.Text = "Patio"
        Me.cbxPatio.UseVisualStyleBackColor = True
        '
        'txtVivienda
        '
        Me.txtVivienda.FormattingEnabled = True
        Me.txtVivienda.Items.AddRange(New Object() {"Casa", "Departamento"})
        Me.txtVivienda.Location = New System.Drawing.Point(89, 15)
        Me.txtVivienda.Name = "txtVivienda"
        Me.txtVivienda.Size = New System.Drawing.Size(180, 21)
        Me.txtVivienda.TabIndex = 46
        '
        'lblVivienda
        '
        Me.lblVivienda.AutoSize = True
        Me.lblVivienda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVivienda.Location = New System.Drawing.Point(19, 20)
        Me.lblVivienda.Name = "lblVivienda"
        Me.lblVivienda.Size = New System.Drawing.Size(64, 16)
        Me.lblVivienda.TabIndex = 42
        Me.lblVivienda.Text = "Vivienda"
        '
        'cmdMadre
        '
        Me.cmdMadre.Location = New System.Drawing.Point(679, 615)
        Me.cmdMadre.Name = "cmdMadre"
        Me.cmdMadre.Size = New System.Drawing.Size(98, 35)
        Me.cmdMadre.TabIndex = 53
        Me.cmdMadre.Text = "&Madre"
        Me.cmdMadre.UseVisualStyleBackColor = True
        '
        'cmdPadre
        '
        Me.cmdPadre.Location = New System.Drawing.Point(797, 615)
        Me.cmdPadre.Name = "cmdPadre"
        Me.cmdPadre.Size = New System.Drawing.Size(98, 35)
        Me.cmdPadre.TabIndex = 53
        Me.cmdPadre.Text = "&Padre"
        Me.cmdPadre.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(797, 665)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 56
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGrabar.Location = New System.Drawing.Point(679, 665)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(100, 29)
        Me.cmdGrabar.TabIndex = 55
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(839, 34)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(100, 29)
        Me.cmdNuevo.TabIndex = 54
        Me.cmdNuevo.Text = "&NUEVO"
        Me.ToolTip1.SetToolTip(Me.cmdNuevo, "Crear un nuevo alumno")
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(508, 16)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(47, 16)
        Me.lblActivo.TabIndex = 44
        Me.lblActivo.Text = "Activo"
        '
        'cmdNuevo2
        '
        Me.cmdNuevo2.Location = New System.Drawing.Point(561, 665)
        Me.cmdNuevo2.Name = "cmdNuevo2"
        Me.cmdNuevo2.Size = New System.Drawing.Size(100, 29)
        Me.cmdNuevo2.TabIndex = 54
        Me.cmdNuevo2.Text = "&NUEVO"
        Me.cmdNuevo2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'btnBuscaLeg
        '
        Me.btnBuscaLeg.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscaLeg.Location = New System.Drawing.Point(263, 15)
        Me.btnBuscaLeg.Name = "btnBuscaLeg"
        Me.btnBuscaLeg.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaLeg.TabIndex = 58
        Me.btnBuscaLeg.UseVisualStyleBackColor = True
        '
        'cbxActivo
        '
        Me.cbxActivo.AutoSize = True
        Me.cbxActivo.Location = New System.Drawing.Point(563, 18)
        Me.cbxActivo.Name = "cbxActivo"
        Me.cbxActivo.Size = New System.Drawing.Size(15, 14)
        Me.cbxActivo.TabIndex = 50
        Me.cbxActivo.UseVisualStyleBackColor = True
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(76, 51)
        Me.txtCiclo.MaxLength = 12
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Size = New System.Drawing.Size(180, 20)
        Me.txtCiclo.TabIndex = 60
        '
        'txtAnoLectivo
        '
        Me.txtAnoLectivo.Location = New System.Drawing.Point(348, 52)
        Me.txtAnoLectivo.MaxLength = 12
        Me.txtAnoLectivo.Name = "txtAnoLectivo"
        Me.txtAnoLectivo.Size = New System.Drawing.Size(121, 20)
        Me.txtAnoLectivo.TabIndex = 62
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiclo.Location = New System.Drawing.Point(12, 55)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(40, 16)
        Me.lblCiclo.TabIndex = 59
        Me.lblCiclo.Text = "Ciclo"
        '
        'lblAnoLectivo
        '
        Me.lblAnoLectivo.AutoSize = True
        Me.lblAnoLectivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoLectivo.Location = New System.Drawing.Point(295, 40)
        Me.lblAnoLectivo.Name = "lblAnoLectivo"
        Me.lblAnoLectivo.Size = New System.Drawing.Size(54, 32)
        Me.lblAnoLectivo.TabIndex = 61
        Me.lblAnoLectivo.Text = "Año" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lectivo"
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 706)
        Me.Controls.Add(Me.txtCiclo)
        Me.Controls.Add(Me.txtAnoLectivo)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblAnoLectivo)
        Me.Controls.Add(Me.cbxActivo)
        Me.Controls.Add(Me.btnBuscaLeg)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo2)
        Me.Controls.Add(Me.cmdPadre)
        Me.Controls.Add(Me.cmdMadre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_sala)
        Me.Controls.Add(Me.datos_alumno)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblActivo)
        Me.Controls.Add(Me.lblLegajo)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "frmAlumnos"
        Me.Text = "<<Alumnos>>"
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.datos_sala.ResumeLayout(False)
        Me.datos_sala.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLegajo As System.Windows.Forms.Label
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents l_dom As System.Windows.Forms.Label
    Friend WithEvents datos_sala As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.ComboBox
    Friend WithEvents txtSala As System.Windows.Forms.TextBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents txtHorario As System.Windows.Forms.TextBox
    Friend WithEvents txtObraSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtEnfermedades As System.Windows.Forms.TextBox
    Friend WithEvents lblEnfermedades As System.Windows.Forms.Label
    Friend WithEvents lblEstadoSalud As System.Windows.Forms.Label
    Friend WithEvents txtAlergias As System.Windows.Forms.TextBox
    Friend WithEvents lblAlergias As System.Windows.Forms.Label
    Friend WithEvents txtEstadoSalud As System.Windows.Forms.ComboBox
    Friend WithEvents txtMedicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVivienda As System.Windows.Forms.Label
    Friend WithEvents txtVivienda As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPatio As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAnimales As System.Windows.Forms.CheckBox
    Friend WithEvents cbxEspaciosVerdes As System.Windows.Forms.CheckBox
    Friend WithEvents txtJuegos As System.Windows.Forms.TextBox
    Friend WithEvents lblJuegos As System.Windows.Forms.Label
    Friend WithEvents cbxRelacionPlantas As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPlantas As System.Windows.Forms.CheckBox
    Friend WithEvents cmdMadre As System.Windows.Forms.Button
    Friend WithEvents cmdPadre As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblActivo As System.Windows.Forms.Label
    Friend WithEvents cmdNuevo2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBuscaLeg As System.Windows.Forms.Button
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents txtLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents cbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCiclo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnoLectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblCiclo As System.Windows.Forms.Label
    Friend WithEvents lblAnoLectivo As System.Windows.Forms.Label
End Class
