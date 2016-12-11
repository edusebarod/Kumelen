Public Class frmAlumnosMaternal
    Dim Editar As Boolean = False
    Public repoAlu As New RepoAlumno
    Public Alu As New Alumno
    Public DS As DataSet
    Public sucursal As String
    Private sala As String = ""

    Private Sub frmAlumnosMaternal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtLegajo)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, cmdGrabar)
        EnableCmd(False, cmdPadre)
        EnableCmd(False, cmdMadre)
        EnableCmd(False, btn_imprimir)
        CargarCursos(cbxCurso, False)
        CargarServicios(cbxServicios)
        'Seleccionos el servicios Todos
        cbxServicios.SelectedValue = 100
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            MsgBox("f1")
        End If
    End Sub

    Private Sub cmdNuevo2_Click(sender As Object, e As EventArgs) Handles cmdNuevo2.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtLegajo)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, cmdNuevo)
        EnableCmd(False, cmdNuevo2)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, btn_imprimir)
        cmdSalir.Text = "&CANCELAR"
        txtNivel.SelectedItem() = "Maternal"
        chbxActivo.Checked = True
        chbxBaja.Checked = False
        txtLegajo.Select()
        Editar = False
        'Alu = Nothing
        Alu = New Alumno
        sala = ""
        txtDescuento.Text = "0000"
    End Sub

    Private Sub frmAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmAlumnos")
            frmAyuda.Show()
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            LimpiarControles(Me)
            ColorearBusqueda(True, txtLegajo)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)

            EnableCmd(False, cmdGrabar)
            EnableCmd(False, cmdPadre)
            EnableCmd(False, cmdMadre)
            EnableCmd(True, btnBuscaApell)
            EnableCmd(True, btnBuscaDNI)
            EnableCmd(True, btnBuscaLeg)
            EnableCmd(True, cmdNuevo)
            EnableCmd(True, cmdNuevo2)
            EnableCmd(False, btn_imprimir)

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
        EnableCmd(False, cmdNuevo)
        EnableCmd(False, cmdNuevo2)
        EnableCmd(True, cmdGrabar)
        EnableCmd(False, btn_imprimir)
        cmdSalir.Text = "&CANCELAR"
        txtNivel.SelectedItem() = "Maternal"
        chbxActivo.Checked = True
        chbxBaja.Checked = False
        txtLegajo.Select()
        'Alu = Nothing
        Alu = New Alumno
        sala = ""
        txtDescuento.Text = "0000"
        Editar = False
    End Sub

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Maternal' AND  alumnos.per_id = personas.per_id AND per_apellido", Trim(txtApellido.Text), False, "per_id", "nombre", Alu.id)
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
        If txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBuscaLeg_Click(sender As Object, e As EventArgs) Handles btnBuscaLeg.Click
        If txtLegajo.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Maternal' AND alumnos.per_id = personas.per_id AND alu_legajo", Trim(txtLegajo.Text), False, "alu_legajo", "per_apellido", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_Legajo(Alu.id, Alu) Then
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
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
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
        If txtLegajo.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, alumnos.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("alumnos, personas", CuerpoSelect, "alumnos.alu_tipo LIKE 'Maternal' AND  alumnos.per_id = personas.per_id AND per_dni", Trim(txtDNI.Text), False, "alu_legajo", "per_apellido", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            If Alu.id <> 0 Then
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
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaDNI.PerformClick()
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
        If Alu.activo Then
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

        CargarCursos(cbxCurso, False)
        elem = buscaElemento(Alu.curso, cbxCurso)
        If elem <> -1 Then
            cbxCurso.SelectedItem = cbxCurso.Items()
        End If
        txtHorario.Text = Alu.horario

        txtDescuento.Text = Alu.descuento
        If Not IsDBNull(Alu.servdescuento) And Alu.servdescuento <> "" Then
            cbxServicios.SelectedValue = Alu.servdescuento
        End If

        'If Trim(txtDescuento.Text) = "" Then
        ' Alu.descuento = 0
        'Else
        'Alu.descuento = System.Convert.ToDecimal(Trim(txtDescuento.Text))
        'End If
        If Alu.vivienda <> "" Then
            'cbxVivienda.SelectedItem = cbxVivienda.Items(buscaElemento(Alu.vivienda, cbxVivienda))
            cbxVivienda.Text = Alu.vivienda
        End If
        If Alu.patio Then
            chbxPatio.Checked = True
        End If
        If Alu.espacioverde Then
            chbxEspaciosVerdes.Checked = True
        End If
        If Alu.animales Then
            chbxAnimales.Checked = True
        End If
        If Alu.plantas Then
            chbxPlantas.Checked = True
        End If
        If Alu.relacionplantas Then
            chbxRealcionPlantas.Checked = True
        End If
        txtJuegos.Text = Alu.juegos
        If Alu.fotocopiaDNI Then
            chbxFotocopiaDNI.Checked = True
        End If
        If Alu.fotocopiaDNIPadre Then
            chbxFotocopiaDNIPadre.Checked = True
        End If
        If Alu.fotocopiaDNIMadre Then
            chbxFotocopiaDNIMadre.Checked = True
        End If
        If Alu.fotocarnet Then
            chbxFotoCarnet.Checked = True
        End If
        If Alu.certificadoSalud Then
            chbxCertificadoSalud.Checked = True
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
            If txtTiempo.Text <> "" Then
                Alu.tiempo = Trim(txtTiempo.Text)
            Else
                Alu.tiempo = 0
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
            'Alu.tipo = "Maternal"
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

            Alu.vivienda = Trim(cbxVivienda.Text)

            If chbxPatio.Checked Then
                Alu.patio = Cts.Activo
            Else
                Alu.patio = Cts.Inactivo
            End If
            If chbxEspaciosVerdes.Checked Then
                Alu.espacioverde = Cts.Activo
            Else
                Alu.espacioverde = Cts.Inactivo
            End If
            If chbxAnimales.Checked Then
                Alu.animales = Cts.Activo
            Else
                Alu.animales = Cts.Inactivo
            End If
            If chbxPlantas.Checked Then
                Alu.plantas = Cts.Activo
            Else
                Alu.plantas = Cts.Inactivo
            End If
            If chbxRealcionPlantas.Checked Then
                Alu.relacionplantas = Cts.Activo
            Else
                Alu.relacionplantas = Cts.Inactivo
            End If
            Alu.juegos = Trim(txtJuegos.Text)
            If chbxFotocopiaDNI.Checked Then
                Alu.fotocopiaDNI = Cts.Activo
            Else
                Alu.fotocopiaDNI = Cts.Inactivo
            End If
            If chbxFotocopiaDNIPadre.Checked Then
                Alu.fotocopiaDNIPadre = Cts.Activo
            Else
                Alu.fotocopiaDNIPadre = Cts.Inactivo
            End If
            If chbxFotocopiaDNIMadre.Checked Then
                Alu.fotocopiaDNIMadre = Cts.Activo
            Else
                Alu.fotocopiaDNIMadre = Cts.Inactivo
            End If
            If chbxFotoCarnet.Checked Then
                Alu.fotocarnet = Cts.Activo
            Else
                Alu.fotocarnet = Cts.Inactivo
            End If
            If chbxCertificadoSalud.Checked Then
                Alu.certificadoSalud = Cts.Activo
            Else
                Alu.certificadoSalud = Cts.Inactivo
            End If
            If Not IsNothing(cbxFacturacion.SelectedItem) Then
                Alu.tutor = Trim(cbxFacturacion.SelectedItem)
            End If

            If Editar Then
                repo.Editar(Alu, False)
            Else
                repo.Agregar(Alu, False)
            End If

            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)

            LimpiarControles(Me)
            'txtFIngreso.Text = "00000000"
            ColorearBusqueda(True, txtLegajo)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)
            EnableCmd(True, cmdNuevo)
            EnableCmd(True, cmdNuevo2)
            EnableCmd(True, cmdGrabar)
            EnableCmd(False, btn_imprimir)
            cmdSalir.Text = "&SALIR"
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
    '   DS = repoAlu.Localidades
    ' asignar el DataSource al combobox
    '   cbxLocalidad.DataSource = DS.Tables(0)
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
            If sucursal = "ZOO" Then
                FrmMadre.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                FrmMadre.MdiParent = frmMainKSC
            End If
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
            If sucursal = "ZOO" Then
                frmPadre.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmPadre.MdiParent = frmMainKSC
            End If
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
            'visRepCompromiso.MdiParent = frmMain
            'visRepCompromiso.Show()
        Else
            MsgBox(msgCompletarNombreyApellido, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
        End If
    End Sub

    Private Sub txtFNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles txtFNacimiento.ValueChanged
        txtEdad.Text = Calcular_Edad(txtFNacimiento.Text)
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        visRepAlumnoMaternal.idAlumno = Alu.id
        visRepAlumnoMaternal.idMadre = Alu.madre
        visRepAlumnoMaternal.idPadre = Alu.padre
        If sucursal = "ZOO" Then
            visRepAlumnoMaternal.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepAlumnoMaternal.MdiParent = frmMainKSC
        End If
        visRepAlumnoMaternal.Show()
    End Sub
End Class