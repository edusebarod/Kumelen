Public Class frmPadre
    Dim Editar As Boolean = False
    Public repoPad As New RepoPadres
    Public repoAlu As New RepoAlumno
    Public Pad As New Padre
    Public DS As DataSet
    Public alu As New Alumno

    Private Sub frmPadre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtApellido)
        If txtApellido.Text = "" Then
            EnableCmd(False, btnGrabar)
        Else
            EnableCmd(True, btnNuevo)
            Editar = True
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtDNI)
        ColorearBusqueda(False, txtApellido)
        EnableCmd(False, btnNuevo)
        EnableCmd(True, btnGrabar)
        cmdSalir.Text = "&CANCELAR"
        txtNombre.Select()
        Editar = False
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            LimpiarControles(Me)
            ColorearBusqueda(True, txtDNI)
            ColorearBusqueda(True, txtApellido)
            EnableCmd(True, btnNuevo)
            EnableCmd(False, btnGrabar)

            cmdSalir.Text = "&SALIR"

            Editar = False
        Else
            Me.Dispose()
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

    Private Sub AcomodoPadre()
        Dim item As Integer
        txtNombre.Text = Pad.nombre
        txtApellido.Text = Pad.apellido
        txtDNI.Text = Pad.dni
        If Pad.fechanacimiento = "00/00/0000" Or Pad.fechanacimiento = "" Then
            txtNacimiento.Checked = False
        Else
            txtNacimiento.Text = Pad.fechanacimiento
            txtNacimiento.Checked = True
        End If
        txtEdad.Text = Calcular_Edad(Pad.fechanacimiento).ToString
        item = buscaElementoString(Pad.nivelescolaridad, cbxEscolaridad)
        If item > 0 Then
            cbxEscolaridad.SelectedItem = cbxEscolaridad.Items()
        Else
            cbxEscolaridad.SelectedItem = Nothing
        End If
        txtDomicilio.Text = Pad.domicilio
        txtLocalidad.Text = Pad.localidad
        txtEstadoCivil.Text = Pad.estadocivil
        txtOcupacion.Text = Pad.ocupacion
        txtEmpresa.Text = Pad.empresa
        txtTelefono.Text = Pad.telefono
        txtCelular.Text = Pad.celular
        txtEmail.Text = Pad.mail
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        Editar = True
        ColorearBusqueda(False, txtApellido)
        EnableCmd(True, btnGrabar)
        'EnableCmd(False, cmdBuscaCod)
        'EnableCmd(False, cmdBuscaNombre)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Validar() Then
            EnableCmd(False, btnGrabar)
            'Dim repoPad = New RepoPadres
            'Dim repoAlu = New RepoAlumno
            Pad.nombre = Trim(txtNombre.Text)
            Pad.apellido = Trim(txtApellido.Text)
            Pad.dni = Trim(txtDNI.Text)
            Pad.fechanacimiento = txtNacimiento.Value.ToString("yyyy-MM-dd")
            Pad.nivelescolaridad = Trim(cbxEscolaridad.Text)
            Pad.domicilio = Trim(txtDomicilio.Text)
            Pad.localidad = Trim(txtLocalidad.Text)
            Pad.estadocivil = Trim(txtEstadoCivil.Text)
            Pad.ocupacion = Trim(txtOcupacion.Text)
            Pad.empresa = Trim(txtEmpresa.Text)
            Pad.telefono = Trim(txtTelefono.Text)
            Pad.celular = Trim(txtCelular.Text)
            Pad.mail = Trim(txtEmail.Text)
            
            If Editar Then
                repoPad.Editar(Pad)
                Editar = False
                alu.padre = Pad.id
            Else
                alu.padre = repoPad.Agregar(Pad)
            End If

            'se agrega el padre al alumno
            repoAlu.Editar(alu)

            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, btnGrabar)
            LimpiarControles(Me)
            txtApellido.Select()
            cmdSalir.PerformClick()
            Me.Dispose()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If

    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtApellido.Text = "" Then
            ColorearValidacion(True, lblApellido)
            B = False
        Else
            If Not Editar And txtDNI.Text <> "" Then
                Dim repo = New RepoPadres
                If repo.Existe(Trim(txtDNI.Text)) Then
                    ColorearValidacion(True, lblApellido)
                    MsgBox(msgErrLegajoUsado, MsgBoxStyle.Information + MsgBoxStyle.Exclamation, msgTitulo)
                    B = False
                End If
            End If
        End If
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        End If
        Return B
    End Function

    Public Sub cargarpadre(ByVal id As String)
        If IsNothing(id) Or id = 0 Then
            Exit Sub
        Else
            repoPad.Traer_X_ID(id, Pad)
            AcomodoPadre()
        End If
    End Sub

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Pad.id() = 0
            Dim CuerpoSelect As String = "per_id, per_dni, per_nombre, CONCAT(per_apellido, "", "", per_nombre) as nombre"
            FormatoBusqueda("personas", CuerpoSelect, "per_apellido", Trim(txtApellido.Text), True, "per_id", "nombre", Pad.id)
            frmBusqueda.ShowDialog()
            Pad.id = frmBusqueda.Codigo
            If Pad.id <> 0 Then
                Dim repo As New RepoPadres
                If repo.Traer_X_ID(Pad.id, Pad) Then
                    AcomodoPadre()
                    AcomodoDespuesDeBusqueda()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles txtNacimiento.ValueChanged
        txtEdad.Text = Calcular_Edad(txtNacimiento.Text)
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub
End Class