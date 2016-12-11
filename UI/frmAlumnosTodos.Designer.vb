<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosTodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnosTodos))
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.txtAnoLectivo = New System.Windows.Forms.TextBox()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.lblAnoLectivo = New System.Windows.Forms.Label()
        Me.chbxActivo = New System.Windows.Forms.CheckBox()
        Me.btnBuscaLeg = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdPadre = New System.Windows.Forms.Button()
        Me.cmdMadre = New System.Windows.Forms.Button()
        Me.datos_sala = New System.Windows.Forms.GroupBox()
        Me.cbxFacturacion = New System.Windows.Forms.ComboBox()
        Me.lblFacturacion = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtHorario = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.ComboBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.txtFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtLNacimiento = New System.Windows.Forms.TextBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.chbxExperiencia = New System.Windows.Forms.CheckBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblExperiencia = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLNacimiento = New System.Windows.Forms.Label()
        Me.cbxLocalidad = New System.Windows.Forms.ComboBox()
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
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.lblActivo = New System.Windows.Forms.Label()
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtFIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtNivel = New System.Windows.Forms.ComboBox()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.cmdNuevo2 = New System.Windows.Forms.Button()
        Me.datos_sala.SuspendLayout()
        Me.datos_alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(437, 15)
        Me.txtCiclo.MaxLength = 12
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Size = New System.Drawing.Size(94, 20)
        Me.txtCiclo.TabIndex = 3
        '
        'txtAnoLectivo
        '
        Me.txtAnoLectivo.Location = New System.Drawing.Point(590, 15)
        Me.txtAnoLectivo.MaxLength = 12
        Me.txtAnoLectivo.Name = "txtAnoLectivo"
        Me.txtAnoLectivo.Size = New System.Drawing.Size(68, 20)
        Me.txtAnoLectivo.TabIndex = 4
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiclo.Location = New System.Drawing.Point(391, 15)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(40, 16)
        Me.lblCiclo.TabIndex = 78
        Me.lblCiclo.Text = "Ciclo"
        '
        'lblAnoLectivo
        '
        Me.lblAnoLectivo.AutoSize = True
        Me.lblAnoLectivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoLectivo.Location = New System.Drawing.Point(539, 16)
        Me.lblAnoLectivo.Name = "lblAnoLectivo"
        Me.lblAnoLectivo.Size = New System.Drawing.Size(54, 32)
        Me.lblAnoLectivo.TabIndex = 79
        Me.lblAnoLectivo.Text = "Año" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lectivo"
        '
        'chbxActivo
        '
        Me.chbxActivo.AutoSize = True
        Me.chbxActivo.Location = New System.Drawing.Point(862, 18)
        Me.chbxActivo.Name = "chbxActivo"
        Me.chbxActivo.Size = New System.Drawing.Size(15, 14)
        Me.chbxActivo.TabIndex = 5
        Me.chbxActivo.UseVisualStyleBackColor = True
        '
        'btnBuscaLeg
        '
        Me.btnBuscaLeg.Image = CType(resources.GetObject("btnBuscaLeg.Image"), System.Drawing.Image)
        Me.btnBuscaLeg.Location = New System.Drawing.Point(172, 9)
        Me.btnBuscaLeg.Name = "btnBuscaLeg"
        Me.btnBuscaLeg.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaLeg.TabIndex = 63
        Me.btnBuscaLeg.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(778, 587)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 37
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGrabar.Location = New System.Drawing.Point(660, 587)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(100, 29)
        Me.cmdGrabar.TabIndex = 36
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdPadre
        '
        Me.cmdPadre.Location = New System.Drawing.Point(778, 537)
        Me.cmdPadre.Name = "cmdPadre"
        Me.cmdPadre.Size = New System.Drawing.Size(98, 35)
        Me.cmdPadre.TabIndex = 34
        Me.cmdPadre.Text = "&Padre"
        Me.cmdPadre.UseVisualStyleBackColor = True
        '
        'cmdMadre
        '
        Me.cmdMadre.Location = New System.Drawing.Point(660, 537)
        Me.cmdMadre.Name = "cmdMadre"
        Me.cmdMadre.Size = New System.Drawing.Size(98, 35)
        Me.cmdMadre.TabIndex = 33
        Me.cmdMadre.Text = "&Madre"
        Me.cmdMadre.UseVisualStyleBackColor = True
        '
        'datos_sala
        '
        Me.datos_sala.Controls.Add(Me.cbxFacturacion)
        Me.datos_sala.Controls.Add(Me.lblFacturacion)
        Me.datos_sala.Controls.Add(Me.txtDescuento)
        Me.datos_sala.Controls.Add(Me.Label2)
        Me.datos_sala.Controls.Add(Me.cbxCurso)
        Me.datos_sala.Controls.Add(Me.lblDescuento)
        Me.datos_sala.Controls.Add(Me.txtHorario)
        Me.datos_sala.Controls.Add(Me.txtTurno)
        Me.datos_sala.Controls.Add(Me.lblHorario)
        Me.datos_sala.Controls.Add(Me.lblSala)
        Me.datos_sala.Controls.Add(Me.lblTurno)
        Me.datos_sala.Location = New System.Drawing.Point(20, 432)
        Me.datos_sala.Name = "datos_sala"
        Me.datos_sala.Size = New System.Drawing.Size(857, 99)
        Me.datos_sala.TabIndex = 28
        Me.datos_sala.TabStop = False
        Me.datos_sala.Text = "Datos de la Sala"
        '
        'cbxFacturacion
        '
        Me.cbxFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFacturacion.FormattingEnabled = True
        Me.cbxFacturacion.Items.AddRange(New Object() {"Madre", "Padre"})
        Me.cbxFacturacion.Location = New System.Drawing.Point(368, 67)
        Me.cbxFacturacion.Name = "cbxFacturacion"
        Me.cbxFacturacion.Size = New System.Drawing.Size(81, 21)
        Me.cbxFacturacion.TabIndex = 32
        '
        'lblFacturacion
        '
        Me.lblFacturacion.AutoSize = True
        Me.lblFacturacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturacion.Location = New System.Drawing.Point(279, 68)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(83, 16)
        Me.lblFacturacion.TabIndex = 94
        Me.lblFacturacion.Text = "Facturación"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(96, 64)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(56, 20)
        Me.txtDescuento.TabIndex = 31
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
        'txtHorario
        '
        Me.txtHorario.Location = New System.Drawing.Point(668, 24)
        Me.txtHorario.MaxLength = 50
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(180, 20)
        Me.txtHorario.TabIndex = 30
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
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorario.Location = New System.Drawing.Point(597, 23)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(55, 16)
        Me.lblHorario.TabIndex = 43
        Me.lblHorario.Text = "Horario"
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
        'datos_alumno
        '
        Me.datos_alumno.Controls.Add(Me.txtFNacimiento)
        Me.datos_alumno.Controls.Add(Me.txtLNacimiento)
        Me.datos_alumno.Controls.Add(Me.cmdNuevo)
        Me.datos_alumno.Controls.Add(Me.lblLugar)
        Me.datos_alumno.Controls.Add(Me.txtLugar)
        Me.datos_alumno.Controls.Add(Me.chbxExperiencia)
        Me.datos_alumno.Controls.Add(Me.lblTiempo)
        Me.datos_alumno.Controls.Add(Me.txtTiempo)
        Me.datos_alumno.Controls.Add(Me.lblExperiencia)
        Me.datos_alumno.Controls.Add(Me.txtNacionalidad)
        Me.datos_alumno.Controls.Add(Me.Label1)
        Me.datos_alumno.Controls.Add(Me.lblLNacimiento)
        Me.datos_alumno.Controls.Add(Me.cbxLocalidad)
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
        Me.datos_alumno.Location = New System.Drawing.Point(20, 53)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(860, 363)
        Me.datos_alumno.TabIndex = 6
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'txtFNacimiento
        '
        Me.txtFNacimiento.Checked = False
        Me.txtFNacimiento.CustomFormat = "yyyy/MM/dd"
        Me.txtFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFNacimiento.Location = New System.Drawing.Point(96, 65)
        Me.txtFNacimiento.Name = "txtFNacimiento"
        Me.txtFNacimiento.ShowCheckBox = True
        Me.txtFNacimiento.Size = New System.Drawing.Size(94, 20)
        Me.txtFNacimiento.TabIndex = 12
        Me.txtFNacimiento.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'txtLNacimiento
        '
        Me.txtLNacimiento.Location = New System.Drawing.Point(380, 65)
        Me.txtLNacimiento.MaxLength = 12
        Me.txtLNacimiento.Name = "txtLNacimiento"
        Me.txtLNacimiento.Size = New System.Drawing.Size(78, 20)
        Me.txtLNacimiento.TabIndex = 13
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(745, 120)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(100, 29)
        Me.cmdNuevo.TabIndex = 21
        Me.cmdNuevo.Text = "&NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(401, 148)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(45, 16)
        Me.lblLugar.TabIndex = 77
        Me.lblLugar.Text = "Lugar"
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(467, 146)
        Me.txtLugar.MaxLength = 50
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(185, 20)
        Me.txtLugar.TabIndex = 20
        '
        'chbxExperiencia
        '
        Me.chbxExperiencia.AutoSize = True
        Me.chbxExperiencia.Location = New System.Drawing.Point(137, 153)
        Me.chbxExperiencia.Name = "chbxExperiencia"
        Me.chbxExperiencia.Size = New System.Drawing.Size(15, 14)
        Me.chbxExperiencia.TabIndex = 18
        Me.chbxExperiencia.UseVisualStyleBackColor = True
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(177, 147)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(56, 16)
        Me.lblTiempo.TabIndex = 75
        Me.lblTiempo.Text = "Tiempo"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(239, 147)
        Me.txtTiempo.MaxLength = 50
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(132, 20)
        Me.txtTiempo.TabIndex = 19
        '
        'lblExperiencia
        '
        Me.lblExperiencia.AutoSize = True
        Me.lblExperiencia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExperiencia.Location = New System.Drawing.Point(12, 135)
        Me.lblExperiencia.Name = "lblExperiencia"
        Me.lblExperiencia.Size = New System.Drawing.Size(119, 32)
        Me.lblExperiencia.TabIndex = 73
        Me.lblExperiencia.Text = "Experiencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previa en el nivel"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(566, 66)
        Me.txtNacionalidad.MaxLength = 50
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(126, 20)
        Me.txtNacionalidad.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(468, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nacionalidad"
        '
        'lblLNacimiento
        '
        Me.lblLNacimiento.AutoSize = True
        Me.lblLNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLNacimiento.Location = New System.Drawing.Point(291, 54)
        Me.lblLNacimiento.Name = "lblLNacimiento"
        Me.lblLNacimiento.Size = New System.Drawing.Size(80, 32)
        Me.lblLNacimiento.TabIndex = 64
        Me.lblLNacimiento.Text = "Lugar de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'cbxLocalidad
        '
        Me.cbxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLocalidad.FormattingEnabled = True
        Me.cbxLocalidad.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbxLocalidad.Location = New System.Drawing.Point(485, 102)
        Me.cbxLocalidad.Name = "cbxLocalidad"
        Me.cbxLocalidad.Size = New System.Drawing.Size(118, 21)
        Me.cbxLocalidad.TabIndex = 17
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(401, 104)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(71, 16)
        Me.lblLocalidad.TabIndex = 61
        Me.lblLocalidad.Text = "Localidad"
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = CType(resources.GetObject("btnBuscaDNI.Image"), System.Drawing.Image)
        Me.btnBuscaDNI.Location = New System.Drawing.Point(811, 16)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaDNI.TabIndex = 11
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(566, 16)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 9
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(126, 314)
        Me.txtObservaciones.MaxLength = 2000
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(724, 34)
        Me.txtObservaciones.TabIndex = 27
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 314)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 39
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtMedicacion
        '
        Me.txtMedicacion.Location = New System.Drawing.Point(670, 253)
        Me.txtMedicacion.MaxLength = 250
        Me.txtMedicacion.Multiline = True
        Me.txtMedicacion.Name = "txtMedicacion"
        Me.txtMedicacion.Size = New System.Drawing.Size(180, 43)
        Me.txtMedicacion.TabIndex = 26
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicacion.Location = New System.Drawing.Point(572, 259)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(81, 16)
        Me.lblMedicacion.TabIndex = 39
        Me.lblMedicacion.Text = "Medicación"
        '
        'txtAlergias
        '
        Me.txtAlergias.Location = New System.Drawing.Point(382, 253)
        Me.txtAlergias.MaxLength = 250
        Me.txtAlergias.Multiline = True
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(180, 43)
        Me.txtAlergias.TabIndex = 25
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlergias.Location = New System.Drawing.Point(293, 259)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.Size = New System.Drawing.Size(60, 16)
        Me.lblAlergias.TabIndex = 39
        Me.lblAlergias.Text = "Alergias"
        '
        'txtEstadoSalud
        '
        Me.txtEstadoSalud.AutoCompleteCustomSource.AddRange(New String() {"Excelente", "Muy bueno", "Bueno", "Regular"})
        Me.txtEstadoSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEstadoSalud.FormattingEnabled = True
        Me.txtEstadoSalud.Items.AddRange(New Object() {"Excelente", "Muy bueno", "Bueno", "Regular"})
        Me.txtEstadoSalud.Location = New System.Drawing.Point(90, 259)
        Me.txtEstadoSalud.Name = "txtEstadoSalud"
        Me.txtEstadoSalud.Size = New System.Drawing.Size(180, 21)
        Me.txtEstadoSalud.TabIndex = 24
        '
        'lblEstadoSalud
        '
        Me.lblEstadoSalud.AutoSize = True
        Me.lblEstadoSalud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoSalud.Location = New System.Drawing.Point(17, 248)
        Me.lblEstadoSalud.Name = "lblEstadoSalud"
        Me.lblEstadoSalud.Size = New System.Drawing.Size(65, 32)
        Me.lblEstadoSalud.TabIndex = 39
        Me.lblEstadoSalud.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salud"
        '
        'txtEnfermedades
        '
        Me.txtEnfermedades.Location = New System.Drawing.Point(382, 201)
        Me.txtEnfermedades.MaxLength = 250
        Me.txtEnfermedades.Multiline = True
        Me.txtEnfermedades.Name = "txtEnfermedades"
        Me.txtEnfermedades.Size = New System.Drawing.Size(468, 33)
        Me.txtEnfermedades.TabIndex = 23
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.AutoSize = True
        Me.lblEnfermedades.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.Location = New System.Drawing.Point(293, 201)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(87, 32)
        Me.lblEnfermedades.TabIndex = 39
        Me.lblEnfermedades.Text = "Enferedades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "padecidas"
        '
        'txtSexo
        '
        Me.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSexo.FormattingEnabled = True
        Me.txtSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.txtSexo.Location = New System.Drawing.Point(753, 64)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(92, 21)
        Me.txtSexo.TabIndex = 15
        '
        'txtObraSocial
        '
        Me.txtObraSocial.Location = New System.Drawing.Point(88, 213)
        Me.txtObraSocial.MaxLength = 50
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.Size = New System.Drawing.Size(182, 20)
        Me.txtObraSocial.TabIndex = 22
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(380, 20)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(180, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(96, 103)
        Me.txtDomicilio.MaxLength = 250
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(275, 20)
        Me.txtDomicilio.TabIndex = 16
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(239, 65)
        Me.txtEdad.MaxLength = 12
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(37, 20)
        Me.txtEdad.TabIndex = 100
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(668, 20)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(137, 20)
        Me.txtDNI.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 19)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 7
        '
        'l_dom
        '
        Me.l_dom.AutoSize = True
        Me.l_dom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_dom.Location = New System.Drawing.Point(12, 104)
        Me.l_dom.Name = "l_dom"
        Me.l_dom.Size = New System.Drawing.Size(68, 16)
        Me.l_dom.TabIndex = 40
        Me.l_dom.Text = "Domicilio"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(706, 68)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(41, 16)
        Me.lblSexo.TabIndex = 39
        Me.lblSexo.Text = "Sexo"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(193, 66)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(40, 16)
        Me.lblEdad.TabIndex = 40
        Me.lblEdad.Text = "Edad"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObraSocial.Location = New System.Drawing.Point(17, 201)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(48, 32)
        Me.lblObraSocial.TabIndex = 39
        Me.lblObraSocial.Text = "Obra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Social"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(10, 54)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(80, 32)
        Me.lblNacimiento.TabIndex = 39
        Me.lblNacimiento.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(622, 20)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(39, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI *"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(291, 23)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(70, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido *"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(10, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre *"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(854, 344)
        Me.ShapeContainer1.TabIndex = 44
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 841
        Me.LineShape1.Y1 = 168
        Me.LineShape1.Y2 = 167
        '
        'txtLegajo
        '
        Me.txtLegajo.Location = New System.Drawing.Point(72, 15)
        Me.txtLegajo.MaxLength = 12
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(94, 20)
        Me.txtLegajo.TabIndex = 1
        '
        'lblActivo
        '
        Me.lblActivo.AutoSize = True
        Me.lblActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivo.Location = New System.Drawing.Point(809, 16)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(47, 16)
        Me.lblActivo.TabIndex = 74
        Me.lblActivo.Text = "Activo"
        '
        'lblLegajo
        '
        Me.lblLegajo.AutoSize = True
        Me.lblLegajo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegajo.Location = New System.Drawing.Point(14, 15)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(61, 16)
        Me.lblLegajo.TabIndex = 73
        Me.lblLegajo.Text = "Legajo *"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(216, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(67, 32)
        Me.lblFecha.TabIndex = 75
        Me.lblFecha.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingreso"
        '
        'txtFIngreso
        '
        Me.txtFIngreso.Checked = False
        Me.txtFIngreso.CustomFormat = "yyyy/MM/dd"
        Me.txtFIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFIngreso.Location = New System.Drawing.Point(289, 15)
        Me.txtFIngreso.Name = "txtFIngreso"
        Me.txtFIngreso.ShowCheckBox = True
        Me.txtFIngreso.Size = New System.Drawing.Size(94, 20)
        Me.txtFIngreso.TabIndex = 3
        Me.txtFIngreso.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'txtNivel
        '
        Me.txtNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtNivel.FormattingEnabled = True
        Me.txtNivel.Items.AddRange(New Object() {"Inicial", "Maternal", "Primario"})
        Me.txtNivel.Location = New System.Drawing.Point(711, 15)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(92, 21)
        Me.txtNivel.TabIndex = 80
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.Location = New System.Drawing.Point(664, 17)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(40, 16)
        Me.lblNivel.TabIndex = 81
        Me.lblNivel.Text = "Nivel"
        '
        'cmdNuevo2
        '
        Me.cmdNuevo2.Location = New System.Drawing.Point(542, 587)
        Me.cmdNuevo2.Name = "cmdNuevo2"
        Me.cmdNuevo2.Size = New System.Drawing.Size(100, 29)
        Me.cmdNuevo2.TabIndex = 35
        Me.cmdNuevo2.Text = "&NUEVO"
        Me.cmdNuevo2.UseVisualStyleBackColor = True
        '
        'frmAlumnosTodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 625)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.txtFIngreso)
        Me.Controls.Add(Me.txtCiclo)
        Me.Controls.Add(Me.txtAnoLectivo)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblAnoLectivo)
        Me.Controls.Add(Me.chbxActivo)
        Me.Controls.Add(Me.btnBuscaLeg)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo2)
        Me.Controls.Add(Me.cmdPadre)
        Me.Controls.Add(Me.cmdMadre)
        Me.Controls.Add(Me.datos_sala)
        Me.Controls.Add(Me.datos_alumno)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.lblActivo)
        Me.Controls.Add(Me.lblLegajo)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "frmAlumnosTodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alumnos de Todos los Niveles"
        Me.datos_sala.ResumeLayout(False)
        Me.datos_sala.PerformLayout()
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCiclo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnoLectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblCiclo As System.Windows.Forms.Label
    Friend WithEvents lblAnoLectivo As System.Windows.Forms.Label
    Friend WithEvents chbxActivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscaLeg As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdPadre As System.Windows.Forms.Button
    Friend WithEvents cmdMadre As System.Windows.Forms.Button
    Friend WithEvents datos_sala As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents txtHorario As System.Windows.Forms.TextBox
    Friend WithEvents txtTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtLNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents chbxExperiencia As System.Windows.Forms.CheckBox
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents txtTiempo As System.Windows.Forms.TextBox
    Friend WithEvents lblExperiencia As System.Windows.Forms.Label
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLNacimiento As System.Windows.Forms.Label
    Friend WithEvents cbxLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtMedicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents txtAlergias As System.Windows.Forms.TextBox
    Friend WithEvents lblAlergias As System.Windows.Forms.Label
    Friend WithEvents txtEstadoSalud As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstadoSalud As System.Windows.Forms.Label
    Friend WithEvents txtEnfermedades As System.Windows.Forms.TextBox
    Friend WithEvents lblEnfermedades As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtObraSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents l_dom As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents lblActivo As System.Windows.Forms.Label
    Friend WithEvents lblLegajo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtFNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNivel As System.Windows.Forms.ComboBox
    Friend WithEvents lblNivel As System.Windows.Forms.Label
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo2 As System.Windows.Forms.Button
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents cbxFacturacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblFacturacion As System.Windows.Forms.Label
End Class
