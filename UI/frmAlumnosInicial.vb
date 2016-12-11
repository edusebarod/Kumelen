Public Class frmAlumnosInicial
    Dim Editar As Boolean = False
    Public repoAlu As New RepoAlumno
    Public Alu As New Alumno
    Public DS As DataSet
    Public sucursal As String
    Private sala As String = ""

    Private Sub frmAlumnosInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtLegajo)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, cmdGrabar)
        EnableCmd(False, cmdPadre)
        EnableCmd(False, cmdMadre)
        EnableCmd(False, btnAutorizacionImagenes)
        EnableCmd(False, btnAutorizacionSalidas)
        EnableCmd(False, btnReglamento)
        EnableCmd(False, btnHorario)
        EnableCmd(False, btn_imprimir)
        CargarCursos(cbxCurso)
        CargarServicios(cbxServicios, True)
        'Seleccionos el servicios Todos
        cbxServicios.SelectedValue = 100
        'CargarLocalidades()
    End Sub

    'Private Sub frmAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '   If e.KeyCode = Keys.F1 Then
    '       frmAyuda.Dispose()
    '       Ayuda.LeerAyuda("frmAlumnos")
    '       frmAyuda.Show()
    '   End If
    'End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            LimpiarControles(Me)
            ColorearBusqueda(True, txtLegajo)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)

            EnableCmd(False, cmdGrabar)
            EnableCmd(False, cmdPadre)
            EnableCmd(False, cmdMadre)
            EnableCmd(False, btn_imprimir)
            EnableCmd(True, btnBuscaApell)
            EnableCmd(True, btnBuscaDNI)
            EnableCmd(True, btnBuscaLeg)
            EnableCmd(True, cmdNuevo)
            EnableCmd(True, cmdNuevo2)

            cmdSalir.Text = "&SALIR"
            Alu = New Alumno
            sala = ""
            Editar = False
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        LimpiarControles(Me)
        'txtFIngreso.Text = "00000000"
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, btnBuscaApell)
        EnableCmd(False, btnBuscaDNI)
        EnableCmd(False, btnBuscaLeg)
        EnableCmd(False, cmdNuevo)
        EnableCmd(False, cmdNuevo2)
        EnableCmd(False, btnAutorizacionImagenes)
        EnableCmd(False, btnAutorizacionSalidas)
        EnableCmd(False, btnReglamento)
        EnableCmd(False, btnHorario)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, btn_imprimir)
        cmdSalir.Text = "&CANCELAR"
        txtNivel.SelectedItem() = "Inicial"
        chbxActivo.Checked = True
        chbxBaja.Checked = False
        txtLegajo.Select()
        Alu = New Alumno
        sala = ""
        txtDescuento.Text = "0000"
        Editar = False
    End Sub

    Private Sub cmdNuevo2_Click(sender As Object, e As EventArgs) Handles cmdNuevo2.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, btnBuscaApell)
        EnableCmd(False, btnBuscaDNI)
        EnableCmd(False, btnBuscaLeg)
        EnableCmd(False, cmdNuevo)
        EnableCmd(False, cmdNuevo2)
        EnableCmd(False, btnAutorizacionImagenes)
        EnableCmd(False, btnAutorizacionSalidas)
        EnableCmd(False, btnReglamento)
        EnableCmd(False, btnHorario)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, btn_imprimir)
        cmdSalir.Text = "&CANCELAR"
        txtNivel.SelectedItem() = "Inicial"
        chbxActivo.Checked = True
        chbxBaja.Checked = False
        txtLegajo.Select()
        Alu = New Alumno
        sala = ""
        txtDescuento.Text = "0000"
        Editar = False
    End Sub

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Inicial' AND  alumnos.per_id = personas.per_id AND per_apellido", Trim(txtApellido.Text), True, "per_id", "nombre", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID(Alu.id, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If cmdNuevo.Enabled And txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBuscaLeg_Click(sender As Object, e As EventArgs) Handles btnBuscaLeg.Click
        If txtLegajo.Text <> "" Then
            Alu.legajo = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Inicial' AND  alumnos.per_id = personas.per_id AND alu_legajo", Trim(txtLegajo.Text), True, "alu_legajo", "per_apellido", Alu.legajo)
            frmBusqueda.ShowDialog()
            Alu.legajo = frmBusqueda.Codigo
            If Alu.legajo <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_Legajo(Alu.legajo, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtLegajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLegajo.KeyPress
        If cmdNuevo.Enabled And txtLegajo.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                btnBuscaLeg.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        If txtDNI.Text <> "" Then
            Alu.dni = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Inicial' AND  alumnos.per_id = personas.per_id AND per_dni", Trim(txtDNI.Text), True, "alu_legajo", "per_apellido", Alu.dni)
            frmBusqueda.ShowDialog()
            Alu.dni = frmBusqueda.Codigo
            If Alu.dni <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_DNI(Alu.dni, Alu) Then
                    AcomodoAlumno()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If cmdNuevo.Enabled And txtDNI.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                btnBuscaLeg.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub AcomodoAlumno()
        Dim edad As Integer
        Dim elem As Integer
        txtLegajo.Text = Alu.legajo
        If Alu.fechaalta = "00/00/0000" Then
            txtFIngreso.Checked = False
        Else
            txtFIngreso.Text = Alu.fechaalta
            txtFIngreso.Checked = True
        End If
        txtCiclo.Text = Alu.ciclo
        txtAnoLectivo.Text = Alu.anolectivo
        txtNivel.Text = Alu.tipo
        If Alu.activo = 1 Then
            chbxActivo.Checked = True
        Else
            chbxActivo.Checked = False
        End If
        If Alu.baja = 0 Then
            chbxBaja.Checked = False
        Else
            chbxBaja.Checked = True
        End If
        txtNombre.Text = Alu.nombre
        txtApellido.Text = Alu.apellido
        txtDNI.Text = Alu.dni
        If Alu.fechanacimiento = "00/00/0000" Then
            txtFNacimiento.Checked = False
        Else
            txtFNacimiento.Text = Alu.fechanacimiento
            txtFNacimiento.Checked = True
        End If
        edad = Calcular_Edad(Alu.fechanacimiento)
        txtEdad.Text = edad.ToString
        txtLNacimiento.Text = Alu.lugarnacimiento
        txtNacionalidad.Text = Alu.nacionalidad
        txtSexo.Text = Alu.sexo
        txtDomicilio.Text = Alu.domicilio
        cbxLocalidad.Text = Alu.localidad
        If Alu.experiencia Then
            chbxExperiencia.Checked = True
        End If
        txtTiempo.Text = Alu.tiempo
        txtLugar.Text = Alu.lugarexperiencia
        txtPersonasRetiran.Text = Alu.personasretiro
        txtObraSocial.Text = Alu.obrasocial
        txtEnfermedades.Text = Alu.enfermedades
        txtEstadoSalud.Text = Alu.salud
        txtAlergias.Text = Alu.alergias
        txtMedicacion.Text = Alu.medicacion
        txtObservaciones.Text = Alu.observaciones
        txtTurno.Text = Alu.turno

        CargarCursos(cbxCurso)
        elem = buscaElemento(Alu.curso, cbxCurso)
        If elem <> -1 Then
            cbxCurso.SelectedItem = cbxCurso.Items()
        End If
        txtHorario.Text = Alu.horario

        txtDescuento.Text = Alu.descuento
        If Not IsDBNull(Alu.servdescuento) And Alu.servdescuento <> "" Then
            cbxServicios.SelectedValue = Alu.servdescuento
        End If

        If Alu.fotocopiaDNI Then
            chbxFotocopiaDNI.Checked = True
        End If
        If Alu.fotocopiaIPE Then
            chboFotocopiaIPE.Checked = True
        End If
        If Alu.entrevistaDOE Then
            chbxEntrevista.Checked = True
        End If
        If Alu.fotocarnet Then
            chbxFCarnet.Checked = True
        End If
        If Alu.fichaMedica Then
            chbxFichaMedica.Checked = True
        End If
        If Alu.audiometria Then
            chbxAudiometria.Checked = True
        End If
        If Alu.certificadoBD Then
            chbxCertifBD.Checked = True
        End If
        sala = repoAlu.Sala(Alu.curso, False)
        If Not IsDBNull(Alu.tutor) Then
            cbxFacturacion.Text = Alu.tutor
        End If
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, cmdNuevo)
        EnableCmd(False, cmdNuevo2)
        EnableCmd(True, cmdGrabar)
        EnableCmd(True, cmdPadre)
        EnableCmd(True, cmdMadre)
        EnableCmd(True, btnAutorizacionImagenes)
        EnableCmd(True, btnAutorizacionSalidas)
        EnableCmd(True, btnReglamento)
        EnableCmd(True, btnHorario)
        EnableCmd(True, btn_imprimir)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoAlumno
            Alu.legajo = Trim(txtLegajo.Text)
            Alu.fechaalta = txtFIngreso.Value.ToString("yyyy-MM-dd")
            Alu.ciclo = Trim(txtCiclo.Text)
            Alu.tipo = txtNivel.Text
            Alu.anolectivo = Trim(txtAnoLectivo.Text)
            If chbxActivo.Checked Then
                Alu.activo = Cts.Activo
            Else
                Alu.activo = Cts.Inactivo
            End If
            If chbxBaja.Checked Then
                Alu.baja = Cts.Baja
            Else
                Alu.baja = Cts.Alta
            End If
            Alu.nombre = Trim(txtNombre.Text)
            Alu.apellido = Trim(txtApellido.Text)
            Alu.dni = Trim(txtDNI.Text)
            Alu.fechanacimiento = txtFNacimiento.Value.ToString("yyyy-MM-dd")
            Alu.lugarnacimiento = Trim(txtLNacimiento.Text)
            Alu.nacionalidad = Trim(txtNacionalidad.Text)
            Alu.sexo = Trim(txtSexo.Text)
            Alu.domicilio = Trim(txtDomicilio.Text)
            Alu.localidad = Trim(cbxLocalidad.Text)
            If chbxExperiencia.Checked Then
                Alu.experiencia = Cts.Activo
            Else
                Alu.experiencia = Cts.Inactivo
            End If
            If Trim(txtTiempo.Text) = "" Then
                Alu.tiempo = 0
            Else
                Alu.tiempo = Trim(txtTiempo.Text)
            End If

            Alu.lugarexperiencia = Trim(txtLugar.Text)
            Alu.personasretiro = Trim(txtPersonasRetiran.Text)
            Alu.obrasocial = Trim(txtObraSocial.Text)
            Alu.enfermedades = Trim(txtEnfermedades.Text)
            Alu.salud = Trim(txtEstadoSalud.Text)
            Alu.alergias = Trim(txtAlergias.Text)
            Alu.medicacion = Trim(txtMedicacion.Text)
            Alu.observaciones = Trim(txtObservaciones.Text)
            Alu.turno = Trim(txtTurno.Text)
            If Not IsNothing(cbxCurso.SelectedItem) Then
                Alu.curso = Trim(cbxCurso.SelectedItem(0))
            End If
            Alu.horario = Trim(txtHorario.Text)

            If Trim(txtDescuento.Text) = "" Or Trim(txtDescuento.Text) = "0 ." Or Trim(txtDescuento.Text) = "0  ." Or Trim(txtDescuento.Text) = "00.00" Or Trim(txtDescuento.Text) = "00.00" Or Trim(txtDescuento.Text) = "0 ," Or Trim(txtDescuento.Text) = "  ." Then
                Alu.descuento = 0
            Else
                'Se quitan guiones bajos
                Dim descc = txtDescuento.Text
                descc = descc.Replace("_", "")
                descc = descc.Replace(" ", "")
                'Se convierte la cadena a decimal
                Dim desc As Decimal = Decimal.Parse(Trim(descc), System.Globalization.CultureInfo.InvariantCulture)
                Alu.descuento = desc
                'Alu.descuento = System.Convert.ToDecimal(Trim(txtDescuento.Text))
            End If
            If Not IsNothing(cbxServicios.SelectedItem) Then
                Alu.servdescuento = Trim(cbxServicios.SelectedValue)
            End If

            If chbxFCarnet.Checked Then
                Alu.fotocarnet = Cts.Activo
            Else
                Alu.fotocarnet = Cts.Inactivo
            End If
            If chbxFotocopiaDNI.Checked Then
                Alu.fotocopiaDNI = Cts.Activo
            Else
                Alu.fotocopiaDNI = Cts.Inactivo
            End If
            If chboFotocopiaIPE.Checked Then
                Alu.fotocopiaIPE = Cts.Activo
            Else
                Alu.fotocopiaIPE = Cts.Inactivo
            End If
            If chbxEntrevista.Checked Then
                Alu.entrevistaDOE = Cts.Activo
            Else
                Alu.entrevistaDOE = Cts.Inactivo
            End If
            If chbxFichaMedica.Checked Then
                Alu.fichaMedica = Cts.Activo
            Else
                Alu.fichaMedica = Cts.Inactivo
            End If
            If chbxAudiometria.Checked Then
                Alu.audiometria = Cts.Activo
            Else
                Alu.audiometria = Cts.Inactivo
            End If
            If chbxCertifBD.Checked Then
                Alu.certificadoBD = Cts.Activo
            Else
                Alu.certificadoBD = Cts.Inactivo
            End If
            If Not IsNothing(cbxFacturacion.SelectedItem) Then
                Alu.tutor = Trim(cbxFacturacion.SelectedItem)
            End If
            If Editar Then
                repo.Editar(Alu)
                Editar = False
            Else
                repo.Agregar(Alu)
            End If

            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            LimpiarControles(Me)
            ColorearBusqueda(True, txtLegajo)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)
            EnableCmd(True, cmdNuevo)
            EnableCmd(True, cmdNuevo2)
            EnableCmd(True, cmdGrabar)
            EnableCmd(True, btnAutorizacionImagenes)
            EnableCmd(True, btnAutorizacionSalidas)
            EnableCmd(True, btnReglamento)
            cmdSalir.Text = "&SALIR"
            EnableCmd(False, btn_imprimir)
            Alu = New Alumno
            sala = ""
            txtLegajo.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtLegajo.Text = "" Then
            ColorearValidacion(True, lblLegajo)
            B = False
        Else
            If Not Editar Then
                Dim repo = New RepoAlumno
                If repo.Existe(Trim(txtLegajo.Text)) Then
                    ColorearValidacion(True, lblLegajo)
                    MsgBox(msgErrLegajoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        End If
        If txtApellido.Text = "" Then
            ColorearValidacion(True, lblApellido)
            B = False
        End If
        If txtDNI.Text = "" Then
            ColorearValidacion(True, lblDNI)
            B = False
        End If
        If txtNivel.Text = "" Then
            ColorearValidacion(True, lblNivel)
            B = False
        End If
        If txtTurno.Text = "" Then
            ColorearValidacion(True, lblTurno)
            B = False
        End If
        If cbxCurso.Text = "" Then
            ColorearValidacion(True, lblSala)
            B = False
        End If
        If txtHorario.Text = "" Then
            ColorearValidacion(True, lblHorario)
            B = False
        End If

        Return B
    End Function

    Private Sub txtTiempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempo.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnoLectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnoLectivo.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescuento.KeyPress
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    'Private Sub CargarLocalidades()
    '    DS = repoAlu.Localidades
    ' asignar el DataSource al combobox
    '    cbxLocalidad.DataSource = DS.Tables(0)
    ' Asignar el campo a la propiedad DisplayMember del combo   
    '    cbxLocalidad.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    'End Sub

    Private Sub cmdMadre_Click(sender As Object, e As EventArgs) Handles cmdMadre.Click
        If Editar Then
            FrmMadre.cargarpadre(Alu.madre)
            FrmMadre.alu = Alu
            If sucursal = "ZOO" Then
                FrmMadre.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                FrmMadre.MdiParent = frmMainKSC
            End If
            FrmMadre.Show()
        Else
            FrmMadre.Show()
        End If
    End Sub

    Private Sub cmdPadre_Click(sender As Object, e As EventArgs) Handles cmdPadre.Click
        If Editar Then
            frmPadre.cargarpadre(Alu.padre)
            frmPadre.alu = Alu
            If sucursal = "ZOO" Then
                frmPadre.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmPadre.MdiParent = frmMainKSC
            End If
            frmPadre.Show()
        Else
            frmPadre.Show()
        End If
    End Sub

    Private Sub btnAutorizacionImagenes_Click(sender As Object, e As EventArgs) Handles btnAutorizacionImagenes.Click
        If Alu IsNot Nothing Or (Alu.nombre <> "" And Alu.apellido <> "") Then
            VisRepAutorizacionImagenes.alumno = String.Format("{0}, {1}", Alu.apellido, Alu.nombre)
            If sucursal = "ZOO" Then
                VisRepAutorizacionImagenes.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                VisRepAutorizacionImagenes.MdiParent = frmMainKSC
            End If
            VisRepAutorizacionImagenes.Show()
        Else
            MsgBox(msgCompletarNombreyApellido, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
        End If
    End Sub

    Private Sub btnAutorizacionSalidas_Click(sender As Object, e As EventArgs) Handles btnAutorizacionSalidas.Click
        If Alu IsNot Nothing Or (Alu.nombre <> "" And Alu.apellido <> "") Then
            visRepAutorizacionSalidas.alumno = String.Format("{0}, {1}", Alu.apellido, Alu.nombre)
            If sucursal = "ZOO" Then
                visRepAutorizacionSalidas.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                visRepAutorizacionSalidas.MdiParent = frmMainKSC
            End If
            visRepAutorizacionSalidas.Show()
        Else
            MsgBox(msgCompletarNombreyApellido, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
        End If
    End Sub

    Private Sub btnReglamento_Click(sender As Object, e As EventArgs) Handles btnReglamento.Click
        If Alu IsNot Nothing Or (Alu.nombre <> "" And Alu.apellido <> "") Then
            visRepCompromiso.alumno = String.Format("{0}, {1}", Alu.apellido, Alu.nombre)
            visRepCompromiso.sala = sala
            visRepCompromiso.turno = Alu.turno
            If sucursal = "ZOO" Then
                visRepCompromiso.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                visRepCompromiso.MdiParent = frmMainKSC
            End If
            visRepCompromiso.Show()
        Else
            MsgBox(msgCompletarNombreyApellido, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
        End If
    End Sub

    Private Sub btnHorario_Click(sender As Object, e As EventArgs) Handles btnHorario.Click
        If Alu IsNot Nothing Or (Alu.nombre <> "" And Alu.apellido <> "") Then
            visRepHorariosAsistencia.alumno = String.Format("{0}, {1}", Alu.apellido, Alu.nombre)
            visRepHorariosAsistencia.sala = sala
            visRepHorariosAsistencia.turno = Alu.turno
            visRepHorariosAsistencia.dni = Alu.dni
            visRepHorariosAsistencia.horario = Alu.horario
            If sucursal = "ZOO" Then
                visRepHorariosAsistencia.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                visRepHorariosAsistencia.MdiParent = frmMainKSC
            End If
            visRepHorariosAsistencia.Show()
        Else
            MsgBox(msgCompletarNombreyApellido, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
        End If
    End Sub

    Private Sub txtFNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles txtFNacimiento.ValueChanged
        txtEdad.Text = Calcular_Edad(txtFNacimiento.Text)
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        visRepAlumnoInicial.idAlumno = Alu.id
        visRepAlumnoInicial.idMadre = Alu.madre
        visRepAlumnoInicial.idPadre = Alu.padre
        If sucursal = "ZOO" Then
            visRepAlumnoInicial.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepAlumnoInicial.MdiParent = frmMainKSC
        End If
        visRepAlumnoInicial.Show()
    End Sub

End Class