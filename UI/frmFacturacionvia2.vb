Public Class frmFacturacionvia2
    Public Alu As New Alumno
    Public Cta As New Cuenta
    Public Dev As New Devengacion
    Public repoFact As New RepoFacturacion
    Public repoAlum As New RepoAlumno
    Public sucursal As String
    'Public repoDeveng As New RepoDevengación
    Public DS As DataSet
    Private flag As Boolean

    Private Sub frmFacturacion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtDNI)
        ColorearBusqueda(True, txtApellido)
        EnableCmd(False, btnAdd)
        EnableCmd(False, btnDel)
        EnableCmd(False, btnFacturar)
        cbxCuenta.SelectedIndex = cbxCuenta.FindStringExact("Caja Efectivo")
        cbxMedioPago.SelectedIndex = cbxMedioPago.FindStringExact("Efectivo")
        'CargarCuentas()
        'selecciona el punto de venta 002 como predeterminado
        cbxPtoVta.SelectedIndex() = 0
        flag = True
    End Sub
    Private Sub CargarCuentas()
        DS = repoFact.Cuentas(False)
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        ' Selecciona la cuenta Caja Efectivo como predeterminado
        cbxCuenta.SelectedIndex = cbxCuenta.FindStringExact("Caja Efectivo")
    End Sub

    Public Sub agregarDetalles(dev_id As Integer, dde_id As Integer, servicio As String, monto As Double)
        dgDetalle.Rows.Add(dev_id, dde_id, servicio, monto, cbxCuenta.Text)
        If txtTotal.Text = "" Then
            txtTotal.Text = monto
        Else
            txtTotal.Text = CDbl(txtTotal.Text) + monto
        End If
        EnableCmd(True, btnDel)
        EnableCmd(True, btnFacturar)
        btnAdd.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validar() Then
            If flag Then
                frmDevengacionesD.Dispose()
                frmDevengacionesD.Close()
                frmDevengacionesD.idAlumno = Alu.id
                frmDevengacionesD.facturar = True
                If sucursal = "ZOO" Then
                    frmDevengacionesD.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmDevengacionesD.MdiParent = frmMainKSC
                End If
                frmDevengacionesD.db = False
                If ChbxIntereses.Checked Then
                    frmDevengacionesD.intereses = True
                End If
                frmDevengacionesD.Show()
                flag = False 'se levanta la bandera para que no se vuelvan a cargar las devengaciones
            Else
                frmDevengacionesD.idAlumno = Alu.id
                frmDevengacionesD.facturar = True
                If sucursal = "ZOO" Then
                    frmDevengacionesD.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    frmDevengacionesD.MdiParent = frmMainKSC
                End If
                frmDevengacionesD.db = False
                If ChbxIntereses.Checked Then
                    frmDevengacionesD.intereses = True
                End If
                frmDevengacionesD.Visible = True
            End If
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgDetalle.RowCount > 0 Then
            txtTotal.Text = CDbl(txtTotal.Text) - CDbl(dgDetalle.CurrentRow.Cells("Monto").Value)
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
        'If txtEncargado.Text = "" Then
        'ColorearValidacion(True, lblEncargado)
        'B = False
        'End If
        If txtSala.Text = "" Then
            ColorearValidacion(True, lblSala)
            B = False
        End If
        If txtTurno.Text = "" Then
            ColorearValidacion(True, lblTurno)
            B = False
        End If
        If cbxPtoVta.Text = "" Then
            ColorearValidacion(True, lblPtoVta)
            B = False
        End If
        If cbxMedioPago.Text = "" Then
            ColorearValidacion(True, lblMedioPago)
            B = False
        End If
        Return B
    End Function

    Private Function validarfact() As Boolean
        Dim B As Boolean = True
        If Not validar() Then
            MsgBox("Faltan datos requeridos para facturar")
            B = False
        ElseIf dgDetalle.Rows.Count < 1 Then
            MsgBox("No hay elementos en el detalle de la factura")
            B = False
        End If
        Return B
    End Function

    Private Sub btnBuscaDNI_Click(sender As Object, e As EventArgs) Handles btnBuscaDNI.Click
        Dim repo As New RepoAlumno
        If repo.Traer_X_DNI(Trim(txtDNI.Text), Alu, False) Then
            AcomodoFactura()
            limpiargrilla()
            frmDevengacionesD.Dispose()
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
            FormatoBusqueda("alumnos INNER JOIN personas ON personas.per_id = alumnos.per_id", CuerpoSelect, "per_apellido", Trim(txtApellido.Text), False, "per_id", "nombre", Alu.id)
            frmBusqueda.ShowDialog()
            Alu.id = frmBusqueda.Codigo
            Alu.apellido = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If Alu.id <> 0 Then
                Dim repo As New RepoAlumno
                If repo.Traer_X_ID_activo(Alu.id, Alu, False) Then
                    AcomodoFactura()
                    limpiargrilla()
                    frmDevengacionesD.Dispose()
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

    Private Sub txtEncargado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEncargado.KeyPress
        If txtEncargado.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnAdd.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AcomodoFactura()
        'TODO verificar que el alumno este activo
        txtNombre.Text = Alu.nombre
        txtApellido.Text = Alu.apellido
        txtDNI.Text = Alu.dni
        txtSala.Text = repoFact.Curso(Alu.curso, False)
        txtTurno.Text = Alu.turno
        txtEncargado.Text = repoAlum.tutor(Alu.id)
        txtEncargado.Select()
        EnableCmd(True, btnAdd)
        EnableCmd(True, btnFacturar)
    End Sub

    Private Sub limpiarControles()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDNI.Clear()
        txtSala.Clear()
        txtEncargado.Clear()
        txtTotal.Clear()
        txtObservaciones.Clear()
        flag = False
        frmDevengacionesD.Dispose()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim repo As New RepoAlumno
        If validarfact() Then
            If dgDetalle.RowCount > 0 Then
                EnableCmd(False, btnFacturar)
                Dim factura As Integer
                factura = repoFact.Facturar(Alu.id, txtEncargado.Text, Convert.ToDouble(txtTotal.Text), cbxPtoVta.Text, txtObservaciones.Text, txtSala.Text, dgDetalle, cbxMedioPago.SelectedText, False)

                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

                EnableCmd(True, btnFacturar)

                txtApellido.Select()
                visRepFacturacionvia2.idFactura = factura
                visRepFacturacionvia2.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                visRepFacturacionvia2.sala = repo.Sala(Alu.curso)
                visRepFacturacionvia2.bd = False
                visRepFacturacionvia2.print = True
                'visRepDuplicadovía2.idFactura = factura
                'visRepDuplicadovía2.alumno = String.Format("{0}, {1}", txtApellido.Text, txtNombre.Text)
                'visRepDuplicadovía2.sala = repo.Sala(Alu.curso)
                'visRepDuplicadovía2.bd = False

                limpiargrilla()
                limpiarControles()
                frmDevengacionesD.Dispose()

                If sucursal = "ZOO" Then
                    visRepFacturacionvia2.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepFacturacionvia2.MdiParent = frmMainKSC
                End If

                visRepFacturacionvia2.Show()
            End If
        End If
    End Sub

    Private Sub cbxCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCuenta.SelectedIndexChanged
        If cbxCuenta.SelectedItem(1).ToString = "Pago Electrónico" Then
            txtEncargado.Text = "Pago electrónico"
        End If
    End Sub

    Private Sub dgDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDetalle.CellValueChanged
        Dim res As Decimal = 0
        'se recorren los detalles de la factura sumando los totales parciales
        For Each row As DataGridViewRow In dgDetalle.Rows
            res = res + row.Cells(3).Value
        Next
        'se actualiza el valor del total
        txtTotal.Text = res
    End Sub

    Private Sub limpiargrilla()
        Me.dgDetalle.Rows.Clear()
    End Sub
End Class