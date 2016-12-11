Public Class frmDocentes
    Dim Editar As Boolean = False
    Public repoPer As New RepoPersonal
    Public Per As New Personal
    Public DS As DataSet
    Public sucursal As String


    Private Sub frmDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtApellido)
        ColorearBusqueda(True, txtDNI)
        EnableCmd(False, btnGrabar)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnSalir.Text = "&CANCELAR" Then
            LimpiarControles(Me)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)
            EnableCmd(False, btnGrabar)
            btnSalir.Text = "&SALIR"
            Editar = False
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Per.id() = 0
            Dim CuerpoSelect As String = "empleados.per_id, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre, per_dni"
            FormatoBusqueda("empleados, personas", CuerpoSelect, "empleados.per_id = personas.per_id AND per_apellido", Trim(txtApellido.Text), True, "per_id", "nombre", Per.id)
            frmBusqueda.ShowDialog()
            Per.id = frmBusqueda.Codigo
            If Per.id <> 0 Then
                Dim repo As New RepoPersonal
                If repo.Traer_X_id(Per.id, Per) Then
                    AcomodoPersonal()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If btnNuevo.Enabled And txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        If txtDNI.Text <> "" Then
            Per.id() = 0
            Dim CuerpoSelect As String = "per_dni, empleados.per_id, per_nombre, per_apellido, per_dni"
            FormatoBusqueda("empleados, personas", CuerpoSelect, "empleados.per_id = personas.per_id AND per_dni", Trim(txtDNI.Text), True, "per_dni", "per_apellido", Per.id)
            frmBusqueda.ShowDialog()
            Per.id = frmBusqueda.Codigo
            If Per.id <> 0 Then
                Dim repo As New RepoPersonal
                If repo.Traer_X_DNI(Per.dni, Per) Then
                    AcomodoPersonal()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If btnNuevo.Enabled And txtDNI.Text <> "" Then
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, btnBuscaApell)
        EnableCmd(False, btnBuscaDNI)
        EnableCmd(False, btnNuevo)
        EnableCmd(True, btnGrabar)
        btnSalir.Text = "&CANCELAR"
        txtNombre.Select()
        Editar = False
    End Sub

    Private Sub AcomodoPersonal()
        Dim edad As Integer

        txtNombre.Text = Per.nombre
        txtApellido.Text = Per.apellido
        txtDNI.Text = Per.dni
        txtCUIL.Text = Per.cuil
        If Per.fechanacimiento = "00/00/0000" Then
            txtFNacimiento.Checked = False
        Else
            txtFNacimiento.Text = Per.fechanacimiento
            txtFNacimiento.Checked = True
        End If
        If txtFNacimiento.Text = "" Then
            edad = 0
        Else
            edad = Calcular_Edad(Per.fechanacimiento)
        End If
        txtEdad.Text = edad.ToString
        'txtLNacimiento.Text = Per.lugarnacimiento
        txtSexo.Text = Per.sexo
        txtNacionalidad.Text = Per.nacionalidad
        txtDomicilio.Text = Per.domicilio
        txtCP.Text = Per.cp
        txtLocalidad.Text = Per.localidad
        If Per.activo Then
            chbxActivo.Checked = True
        End If
        txtTelefono.Text = Per.telefono
        txtCelular.Text = Per.celular
        txtEmail.Text = Per.mail
        txtEstadoCivil.Text = Per.estadocivil
        txtCargo.Text = Per.cargo
        If Per.fechaIngreso = "00/00/0000" Then
            txtFechaIngreso.Checked = False
        Else
            txtFechaIngreso.Text = Per.fechaIngreso
            txtFechaIngreso.Checked = True
        End If
        txtHoras.Text = Per.horas
        txtObservaciones.Text = Per.observaciones
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, btnNuevo)
        EnableCmd(True, btnGrabar)
        btnSalir.Text = "&CANCELAR"
        btnSalir.Select()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Validar() Then
            EnableCmd(False, btnGrabar)
            Dim repo = New RepoPersonal
            Try
                Per.nombre = Trim(txtNombre.Text)
                Per.apellido = Trim(txtApellido.Text)
                Per.dni = Trim(txtDNI.Text)
                Per.cuil = Trim(txtCUIL.Text)
                Per.fechanacimiento = txtFNacimiento.Value.ToString("yyyy-MM-dd")
                Per.sexo = Trim(txtSexo.Text)
                Per.nacionalidad = Trim(txtNacionalidad.Text)
                Per.domicilio = Trim(txtDomicilio.Text)
                Per.cp = Trim(txtCP.Text)
                Per.localidad = Trim(txtLocalidad.Text)

                If chbxActivo.Checked Then
                    Per.activo = Cts.Activo
                Else
                    Per.activo = Cts.Inactivo
                End If
                Per.telefono = Trim(txtTelefono.Text)
                Per.celular = Trim(txtCelular.Text)
                Per.mail = Trim(txtEmail.Text)
                Per.estadocivil = Trim(txtEstadoCivil.Text)
                Per.cargo = Trim(txtCargo.Text)
                'If Trim(txtFechaIngreso.Text) = "/  /" Then
                'Per.fechaIngreso = "0000/00/00"
                'Else
                'Per.fechaIngreso = Trim(txtFechaIngreso.Text)
                'End If
                Per.fechaIngreso = txtFechaIngreso.Value.ToString("yyyy-MM-dd")
                If Trim(txtHoras.Text) = "" Then
                    Per.horas = 0
                Else
                    Per.horas = Trim(txtHoras.Text)
                End If
                Per.observaciones = Trim(txtObservaciones.Text)

                If Editar Then
                    repo.Editar(Per)
                    Editar = False
                Else
                    repo.Agregar(Per)
                End If
                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
                EnableCmd(True, btnGrabar)
                LimpiarControles(Me)
                ColorearBusqueda(True, txtApellido)
                ColorearBusqueda(True, txtDNI)
                EnableCmd(True, btnBuscaApell)
                EnableCmd(True, btnBuscaDNI)
                txtNombre.Select()
                EnableCmd(False, btnGrabar)
                EnableCmd(True, btnNuevo)
                btnSalir.Text = "&SALIR"
                'btnSalir.PerformClick()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        Else
            If Not Editar Then
                Dim repo = New RepoPersonal
                If repo.Existe(Trim(txtDNI.Text)) Then
                    ColorearValidacion(True, lblDNI)
                    MsgBox(msgExisteDNI, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    Return False
                End If
            End If
        End If
        If txtApellido.Text = "" Then
            ColorearValidacion(True, lblApellido)
            B = False
        End If
        Return B
    End Function

    Private Sub txtHoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHoras.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    'Private Sub CargarLocalidades()
    '   DS = repoPer.Localidades
    ' asignar el DataSource al combobox
    '   cbxLocalidad.DataSource = DS.Tables(0)
    ' Asignar la columna que se muestra
    '    cbxLocalidad.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    ' Asignar la columna que es el valor del item seleccionado
    '    cbxLocalidad.ValueMember = DS.Tables(0).Columns(0).Caption
    'End Sub
End Class