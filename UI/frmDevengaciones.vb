Public Class frmDevengaciones
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public Dev As New Devengacion
    Public repoDeveng As New RepoDevengación
    Public DS As DataSet
    Public sucursal As String

    Private Sub frmDevengaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, btnAdd)
        EnableCmd(False, btnDel)
        EnableCmd(False, btnDevengar)
        EnableCmd(False, btnDevengar1v)
        EnableCmd(False, btnDevengar2v)
        EnableCmd(False, btnDevengarsv)
        CargarCuentas()
        CargarServicios()
    End Sub

    Private Sub CargarCuentas()
        DS = repoDeveng.Cuentas()
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoDeveng.Servicios()
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validar() Then
            EnableCmd(False, btnAdd)
            dgDetalle.Rows.Add(cbxServicio.Text, cbxServicio.SelectedValue(0), txtMonto.Text, cbxCuenta.Text)
            EnableCmd(True, btnAdd)
            If txtTotal.Text = "" Then
                txtTotal.Text = CDbl(txtMonto.Text)
            Else
                txtTotal.Text = CDbl(txtTotal.Text) + CDbl(txtMonto.Text)
            End If
            txtMonto.Clear()
            EnableCmd(True, btnDel)
            EnableCmd(True, btnDevengar)
            EnableCmd(True, btnDevengar1v)
            EnableCmd(True, btnDevengar2v)
            EnableCmd(True, btnDevengarsv)
            txtMonto.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgDetalle.RowCount > 0 Then
            txtTotal.Text = CDbl(txtTotal.Text) - CDbl(dgDetalle.CurrentRow.Cells(2).Value)
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
        'seleccionarcuenta()
        sugerirmonto()
        EnableCmd(True, btnAdd)
        EnableCmd(True, btnDevengar)
        EnableCmd(True, btnDevengar1v)
        EnableCmd(True, btnDevengar2v)
        EnableCmd(True, btnDevengarsv)
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
        Dim nroDev As String
        Dim codigo As String = ""
        Dim beca As String = ""
        Dim pagoElectronico As String = ""
        Dim sql As String = ""
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim v1 As String = ""

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                'se obtien el primer vencimiento
                v1 = repoDeveng.Vencimiento1(devengacion)

                codigo = generarCodBarra(Alu.dni, nroDev, v1)
                If Alu.descuento <> Nothing Or Alu.descuento = 0D Then
                    beca = Alu.descuento.ToString
                    pagoElectronico = "0000" + Alu.legajo.ToString
                End If

                visRepDevengacion.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacion.sala = txtSala.Text
                visRepDevengacion.turno = txtTurno.Text
                visRepDevengacion.iddevengacion = devengacion
                visRepDevengacion.nroDev = nroDev
                visRepDevengacion.codigo = codigo
                visRepDevengacion.beca = beca
                visRepDevengacion.pagoElectronico = pagoELectronico
                visRepDevengacion.bd = True

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacion.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacion.MdiParent = frmMainKSC
                End If
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
        monto = repoDeveng.montoServicio(cbxServicio.SelectedValue(0))

        If Alu.descuento <> 0 Then
            monto = monto / 100 * (100 - Convert.ToDouble(Alu.descuento))
        End If
        txtMonto.Text = monto
    End Sub

    Private Sub cbxServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServicio.SelectedIndexChanged
        sugerirMonto()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDevengar1v.Click
        Dim nroDev As String
        Dim codigo As String = ""
        Dim beca As String = ""
        Dim pagoElectronico As String = ""
        Dim sql As String = ""
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim v1 As String = ""

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                'se obtien el primer vencimiento
                v1 = repoDeveng.Vencimiento1(devengacion)

                codigo = generarCodBarra(Alu.dni, nroDev, v1)
                If Alu.descuento <> Nothing Or Alu.descuento = 0D Then
                    beca = Alu.descuento.ToString
                    pagoElectronico = "0000" + Alu.legajo.ToString
                End If

                visRepDevengacion1v.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacion1v.sala = txtSala.Text
                visRepDevengacion1v.turno = txtTurno.Text
                visRepDevengacion1v.iddevengacion = devengacion
                visRepDevengacion1v.nroDev = nroDev
                visRepDevengacion1v.codigo = codigo
                visRepDevengacion1v.beca = beca
                visRepDevengacion1v.pagoElectronico = pagoElectronico
                visRepDevengacion1v.bd = True

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacion1v.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacion1v.MdiParent = frmMainKSC
                End If
                visRepDevengacion1v.Show()

            End If
        End If
    End Sub

    Private Sub btnDevengar2v_Click(sender As Object, e As EventArgs) Handles btnDevengar2v.Click
        Dim nroDev As String
        Dim codigo As String = ""
        Dim beca As String = ""
        Dim pagoElectronico As String = ""
        Dim sql As String = ""
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim v1 As String = ""

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                'se obtien el primer vencimiento
                v1 = repoDeveng.Vencimiento1(devengacion)

                codigo = generarCodBarra(Alu.dni, nroDev, v1)
                If Alu.descuento <> Nothing Or Alu.descuento = 0D Then
                    beca = Alu.descuento.ToString
                    pagoElectronico = "0000" + Alu.legajo.ToString
                End If

                visRepDevengacion2v.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacion2v.sala = txtSala.Text
                visRepDevengacion2v.turno = txtTurno.Text
                visRepDevengacion2v.iddevengacion = devengacion
                visRepDevengacion2v.nroDev = nroDev
                visRepDevengacion2v.codigo = codigo
                visRepDevengacion2v.beca = beca
                visRepDevengacion2v.pagoElectronico = pagoElectronico
                visRepDevengacion2v.bd = True

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacion2v.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacion2v.MdiParent = frmMainKSC
                End If
                visRepDevengacion2v.Show()

            End If
        End If
    End Sub

    Private Sub btnDevengarsv_Click(sender As Object, e As EventArgs) Handles btnDevengarsv.Click
        Dim nroDev As String
        Dim codigo As String = ""
        Dim beca As String = ""
        Dim pagoElectronico As String = ""
        Dim sql As String = ""
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim v1 As String = ""

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                'se obtien el primer vencimiento
                v1 = repoDeveng.Vencimiento1(devengacion)

                codigo = generarCodBarra(Alu.dni, nroDev, v1)
                If Alu.descuento <> Nothing Or Alu.descuento = 0D Then
                    beca = Alu.descuento.ToString
                    pagoElectronico = "0000" + Alu.legajo.ToString
                End If

                visRepDevengacionsv.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacionsv.sala = txtSala.Text
                visRepDevengacionsv.turno = txtTurno.Text
                visRepDevengacionsv.iddevengacion = devengacion
                visRepDevengacionsv.nroDev = nroDev
                visRepDevengacionsv.codigo = codigo
                visRepDevengacionsv.beca = beca
                visRepDevengacionsv.pagoElectronico = pagoElectronico
                visRepDevengacionsv.bd = True

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacionsv.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacionsv.MdiParent = frmMainKSC
                End If
                visRepDevengacionsv.Show()

            End If
        End If
    End Sub
End Class