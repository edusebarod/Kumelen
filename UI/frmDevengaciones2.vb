﻿Public Class frmDevengaciones2
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public Dev As New Devengacion
    Public repoDeveng As New RepoDevengación
    Public DS As DataSet
    Public repoServ As New RepoServicio
    Public sucursal As String

    Private Sub frmDevengaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        'EnableCmd(False, btnAdd)
        EnableCmd(False, btnDel)
        EnableCmd(False, btnDevengar)
        EnableCmd(False, btnDevengar1v)
        EnableCmd(False, btnDevengar2v)
        EnableCmd(False, btnDevengarsv)
        CargarCuentas()
        CargarServicios()
        CargarProductos()
    End Sub
    Private Sub CargarCuentas()
        DS = repoDeveng.Cuentas(False)
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarServicios()
        DS = repoDeveng.Servicios(False)
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarProductos()
        DS = repoDeveng.Productos(False)
        ' asignar el DataSource al combobox
        cbxProducto.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxProducto.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validar() Then
            EnableCmd(False, btnAdd)
            If chbxProducto.Checked Then
                dgDetalle.Rows.Add(cbxProducto.Text, cbxProducto.SelectedValue(0), txtMonto.Text, cbxCuenta.Text)
            End If
            If chbxServicio.Checked Then
                dgDetalle.Rows.Add(cbxServicio.Text, cbxServicio.SelectedValue(0), txtMonto.Text, cbxCuenta.Text)
            End If
            EnableCmd(True, btnAdd)
            txtTotal.Text = CDbl(txtTotal.Text) + CDbl(txtMonto.Text)
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
        If Not (chbxProducto.Checked Or chbxServicio.Checked) Then
            'ColorearValidacion(True, chbxProducto.Text)
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
        If cbxMes.Text = "" Then
            MsgBox("No se seleccinó el mes")
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
            Dim msg As String = String.Format(msgErrBuscaCod, "Alumno")
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
        'seleccionarCuenta()
        'sugerirMonto()
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

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle, cbxMes.SelectedText.ToString, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                visRepDevengacionvia2.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacionvia2.sala = txtSala.Text
                visRepDevengacionvia2.turno = txtTurno.Text
                visRepDevengacionvia2.iddevengacion = devengacion
                visRepDevengacionvia2.nroDev = nroDev
                visRepDevengacionvia2.beca = Alu.descuento.ToString
                visRepDevengacionvia2.bd = False
                visRepDevengacionvia2.mes = cbxMes.SelectedText.ToString

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacionvia2.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacionvia2.MdiParent = frmMainKSC
                End If
                visRepDevengacionvia2.Show()
            End If
        End If
    End Sub

    'selecciona un elemento del cbxServicio, pero depende fuertemente de los datos
    'en la bd sean compatibles con los chequeos del IF. TODO: cambiar esto
    Private Sub seleccionarServicio(alu As Alumno)

        'If alu.tipo = "Primario" Then
        ' cbxServicio.SelectedIndex = 1
        'ElseIf alu.tipo = "Inicial" Then
        ' cbxServicio.SelectedIndex = 0
        ''  ElseIf alu.tipo = "Maternal" Then
        ' cbxServicio.SelectedIndex = 2
        '  End If
    End Sub

    Private Sub seleccionarCuenta()
        If cbxServicio.SelectedIndex() = 0 Or cbxServicio.SelectedIndex() = 1 Then
            cbxCuenta.SelectedIndex = 12
        End If
    End Sub

    Private Sub sugerirMonto(ByVal tipo As String)
        Dim monto As Double
        If tipo = "servicio" Then
            monto = repoDeveng.montoServicio(cbxServicio.SelectedValue(0), False)
            If Alu.descuento <> 0 Then
                monto = monto / 100 * (100 - Convert.ToDouble(Alu.descuento))
            End If
        ElseIf tipo = "producto" Then
            monto = repoDeveng.montoServicio(cbxProducto.SelectedValue(0), False)
        End If
        txtMonto.Text = monto
    End Sub

    Private Sub chbxServicio_CheckedChanged(sender As Object, e As EventArgs) Handles chbxServicio.CheckedChanged
        If chbxServicio.Checked Then
            If chbxProducto.Checked Then
                chbxProducto.CheckState = 0
            End If
            sugerirMonto("servicio")
        End If
    End Sub

    Private Sub chbxProducto_CheckedChanged(sender As Object, e As EventArgs) Handles chbxProducto.CheckedChanged
        If chbxProducto.Checked Then
            If chbxServicio.Checked Then
                chbxServicio.CheckState = 0
            End If
            sugerirMonto("producto")
        End If
    End Sub

    Private Sub cbxServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServicio.SelectedIndexChanged
        If chbxServicio.Checked Then
            sugerirMonto("servicio")
        End If
    End Sub

    Private Sub cbxProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProducto.SelectedIndexChanged
        If chbxProducto.Checked Then
            sugerirMonto("producto")
        End If
    End Sub

    Private Sub btnDevengar1v_Click(sender As Object, e As EventArgs) Handles btnDevengar1v.Click
        Dim nroDev As String

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle, cbxMes.SelectedText.ToString, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                visRepDevengacionvia21v.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacionvia21v.sala = txtSala.Text
                visRepDevengacionvia21v.turno = txtTurno.Text
                visRepDevengacionvia21v.iddevengacion = devengacion
                visRepDevengacionvia21v.nroDev = nroDev
                visRepDevengacionvia21v.beca = Alu.descuento.ToString
                visRepDevengacionvia21v.bd = False
                visRepDevengacionvia21v.mes = cbxMes.SelectedText.ToString


                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacionvia21v.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacionvia21v.MdiParent = frmMainKSC
                End If
                visRepDevengacionvia21v.Show()
            End If
        End If
    End Sub

    Private Sub btnDevengar2v_Click(sender As Object, e As EventArgs) Handles btnDevengar2v.Click
        Dim nroDev As String

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle, cbxMes.SelectedText.ToString, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                visRepDevengacionvia22v.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacionvia22v.sala = txtSala.Text
                visRepDevengacionvia22v.turno = txtTurno.Text
                visRepDevengacionvia22v.iddevengacion = devengacion
                visRepDevengacionvia22v.nroDev = nroDev
                visRepDevengacionvia22v.beca = Alu.descuento.ToString
                visRepDevengacionvia22v.bd = False
                visRepDevengacionvia22v.mes = cbxMes.SelectedText.ToString

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacionvia22v.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacionvia22v.MdiParent = frmMainKSC
                End If
                visRepDevengacionvia22v.Show()
            End If
        End If
    End Sub

    Private Sub btnDevengarsv_Click(sender As Object, e As EventArgs) Handles btnDevengarsv.Click
        Dim nroDev As String

        If validardev() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnDevengar)
                EnableCmd(False, btnDevengar1v)
                EnableCmd(False, btnDevengar2v)
                EnableCmd(False, btnDevengarsv)
                Dim devengacion As Integer
                devengacion = repoDeveng.Devengar(Alu.id, Convert.ToDouble(txtTotal.Text), txtObservaciones.Text, dgDetalle, cbxMes.SelectedText.ToString, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnDevengar)
                EnableCmd(True, btnDevengar1v)
                EnableCmd(True, btnDevengar2v)
                EnableCmd(True, btnDevengarsv)

                dgDetalle.Rows.Clear()

                nroDev = devengacion.ToString
                nroDev = nroDev.PadLeft(8, "0")
                visRepDevengacionvia2sv.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepDevengacionvia2sv.sala = txtSala.Text
                visRepDevengacionvia2sv.turno = txtTurno.Text
                visRepDevengacionvia2sv.iddevengacion = devengacion
                visRepDevengacionvia2sv.nroDev = nroDev
                visRepDevengacionvia2sv.beca = Alu.descuento.ToString
                visRepDevengacionvia2sv.bd = False
                visRepDevengacionvia2sv.mes = cbxMes.SelectedText.ToString

                limpiarControles()
                txtTotal.Text = "0"
                ColorearControles(Me)
                ColorearFRM(Me)
                ColorearBusqueda(True, txtDNI)
                ColorearBusqueda(True, txtApellido)
                txtApellido.Select()

                If sucursal = "ZOO" Then
                    visRepDevengacionvia2sv.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepDevengacionvia2sv.MdiParent = frmMainKSC
                End If
                visRepDevengacionvia2sv.Show()
            End If
        End If
    End Sub
End Class