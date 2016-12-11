Public Class frmDevengaciones3
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public Dev As New Devengacion
    Public repoDeveng As New RepoDevengación
    Public DS As DataSet

    Private Sub frmDevengaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, btnAdd)
        EnableCmd(False, btnDel)
        EnableCmd(False, btnDevengar)
        CargarCuentas()
        CargarServicios()
    End Sub
    Private Sub CargarCuentas()
        DS = repoDeveng.Cuentas
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoDeveng.Servicios
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        'Cargar el monto del servicio !!!!!!!!!!!!!!Esto no me sale!!!!!!!!!!!!!!!!!!!!!!
        'txtMonto.Text = DS.Tables(0).Rows(2).ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validar() Then
            EnableCmd(False, btnAdd)
            dgDetalle.Rows.Add(cbxServicio.Text, txtMonto.Text, cbxCuenta.Text)
            EnableCmd(True, btnAdd)
            txtTotal.Text = CDbl(txtTotal.Text) + CDbl(txtMonto.Text)
            txtMonto.Clear()
            EnableCmd(True, btnDel)
            EnableCmd(True, btnDevengar)
            txtMonto.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgDetalle.RowCount > 0 Then
            txtTotal.Text = CDbl(txtTotal.Text) - CDbl(dgDetalle.CurrentRow.Cells(1).Value)
            dgDetalle.Rows.Remove(dgDetalle.CurrentRow)
        End If
        'Si no hay mas filas, se dehabilita el boton borrar
        If dgDetalle.RowCount = 0 Then
            EnableCmd(False, btnDel)
        End If
    End Sub

    Private Function validar() As Boolean
        Dim B As Boolean = True
        If txtApellido.Text = "" Then
            ColorearValidacion(True, lblApellido)
            B = False
        End If
        If txtNombre.Text = "" Then
            ColorearValidacion(True, lblNombre)
            B = False
        End If
        If txtMonto.Text = "" Then
            ColorearValidacion(True, lblMonto)
            B = False
        End If
        Return B
    End Function

    Private Function validardev() As Boolean
        Dim B As Boolean = True
        If dgDetalle.Rows.Count < 1 Then
            MsgBox("No hay elementos en el detalle de devengaciones")
            B = False
        End If
        Return B
    End Function

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        Dim repo As New RepoAlumno
        If repo.Traer_X_DNI(Trim(txtDNI.Text), Alu) Then
            AcomodoDevengacion()
            txtMonto.Select()
        Else
            Dim msg As String = String.Format(msgErrBuscaCod, "facturacion")
            MsgBox(msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, msgTitulo)
            txtDNI.SelectAll()
        End If
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If txtDNI.Text <> "" Then
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

    Private Sub btnBuscaApell_Click(sender As Object, e As EventArgs) Handles btnBuscaApell.Click
        If txtApellido.Text <> "" Then
            Alu.id() = 0
            Dim CuerpoSelect As String = "alu_legajo, per_nombre, per_dni, CONCAT(per_apellido, "", "", per_nombre) as nombre, personas.per_id"
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txtApellido.Text), True, "per_id", "nombre", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            Alu.apellido = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID_activo(Alu.id, Alu) Then
                    AcomodoDevengacion()
                    txtMonto.Select()
                End If
            Else
                txtNombre.Select()
            End If
        End If
    End Sub

    Private Sub txtapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If txtApellido.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaApell.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AcomodoDevengacion()
        'TODO verificar que el alumno este activo
        txtNombre.Text = Alu.nombre
        txtApellido.Text = Alu.apellido
        txtDNI.Text = Alu.dni
        txtSala.Text = repoDeveng.Curso(Alu.curso)
        txtTurno.Text = Alu.turno
        seleccionarServicio(Alu)
        seleccionarcuenta()
        sugerirmonto()
        EnableCmd(True, btnAdd)
        EnableCmd(True, btnDevengar)
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If txtMonto.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnAdd.PerformClick()
                e.Handled = True
            End If
        End If
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        ElseIf e.KeyChar = Chr(46) Then
            If InStr(txtMonto.Text, ".") <> 0 Then
                e.KeyChar = ""
            ElseIf txtMonto.Text = "" Then
                txtMonto.Text = "0."
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub limpiarControles()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDNI.Clear()
        txtSala.Clear()
        txtTurno.Clear()
        txtMonto.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnDevengar_Click(sender As Object, e As EventArgs) Handles btnDevengar.Click
        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)

                For Each dr As DataGridViewRow In dgDetalle.Rows
                    dgDetalle.Rows.Remove(dr)
                Next

                visRepDevengacion.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacion.sala = txtSala.Text
                visRepDevengacion.turno = txtTurno.Text
                visRepDevengacion.iddevengacion = devengacion
                limpiarControles()
                txtApellido.Select()
                visRepDevengacion.MdiParent = frmMain
                visRepDevengacion.Show()
            End If
        End If
    End Sub

    Private Sub seleccionarServicio(alu As Alumno)
        If alu.tipo = "Primario" Then
            cbxServicio.SelectedIndex = 1
        ElseIf alu.tipo = "Inicial" Then
            cbxServicio.SelectedIndex = 0
        End If
    End Sub

    Private Sub seleccionarCuenta()
        If cbxServicio.SelectedIndex() = 0 Or cbxServicio.SelectedIndex() = 1 Then
            cbxCuenta.SelectedIndex = 12
        End If
    End Sub

    Private Sub sugerirMonto()
        Dim monto As Double
        monto = repoDeveng.montoServicio(cbxServicio.SelectedIndex() + 1)

        If Alu.descuento <> 0 Then
            monto = monto / 100 * Convert.ToDouble(Alu.descuento)
        End If
        txtMonto.Text = monto
    End Sub
End Class