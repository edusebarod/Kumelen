Public Class frmArqueoCajaGlobal
    Public sucursal As String
    Public repofdcg As New RepoFallodeCajaGlobal
    Private fdcg As New FallodeCajaGlobal
    Private editar As Boolean
    Private nuevo As Boolean


    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ColorearControles(Me)
            ColorearFRM(Me)
            EnableCmd(False, btn_imprimir)
            EnableCmd(False, btnGrabar)
            txtSaldoVia1.Enabled = False
            txtSaldoVia2.Enabled = False
            txtVales.Enabled = False
            txtDetallesVales.Enabled = False
            txtSobres.Enabled = False
            txtSobresDetalles.Enabled = False
            txtExistencia.Enabled = False
            txtExistenciaFisica.Enabled = False
            txtDiferencia.Enabled = False
            txtObservaciones.Enabled = False
            editar = False
            nuevo = False
            If sucursal = "ZOO" Then
                Me.Text = "Arqueo de Caja de Kumelen Zoológico"
                GroupBox1.Text = "Arqueo de Caja de Kumelen Zoológico"
            ElseIf sucursal = "KSC" Then
                Me.Text = "Arqueo de Caja de Kumelen San Carlos"
                GroupBox1.Text = "Arqueo de Caja de Kumelen San Carlos"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnSalir.Text = "&Cancelar" Then
            LimpiarControles(Me)

            btnSalir.Text = "&Salir"
            fecha = ""
            editar = False
            nuevo = False
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        visRepFallodeCajaGlobal.fecha = txtFecha.Text.ToString.Replace("/", "-")
        visRepFallodeCajaGlobal.sucursal = sucursal
        If sucursal = "ZOO" Then
            visRepFallodeCajaGlobal.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepFallodeCajaGlobal.MdiParent = frmMainKSC
        End If
        visRepFallodeCajaGlobal.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim saldovia1, saldovia2 As Decimal

        Try
            nuevo = True
            editar = False
            EnableCmd(False, btn_imprimir)
            EnableCmd(False, btnFallodeCaja)
            EnableCmd(True, btnGrabar)
            txtVales.Enabled = True
            txtDetallesVales.Enabled = True
            txtSobres.Enabled = True
            txtSobresDetalles.Enabled = True
            txtExistencia.Enabled = True
            txtExistenciaFisica.Enabled = True
            txtObservaciones.Enabled = True
            editar = False
            LimpiarControles(Me)

            saldovia1 = calcularSaldo(True)
            saldovia2 = calcularSaldo(False)

            txtSaldoVia1.Text = saldovia1
            txtSaldoVia2.Text = saldovia2

            txtFecha.Value = DateTime.Now()
            txtFecha.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function calcularSaldo(bd As Boolean) As Decimal
        Dim conexion As New cBaseDatos
        Dim SQL1, SQL2, SQL3, SQL4 As String
        Dim saldo As Double = 0
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldo_dec As Decimal
        Dim fecha As String
        SQL1 = ""
        SQL2 = ""
        SQL3 = ""
        SQL4 = ""

        fecha = DateTime.Now().ToString("yyyy/MM/dd").ToString
        conexion.AbrirConexion(bd)
        If sucursal = "ZOO" Then
            SQL1 = "SELECT SUM(md.mde_monto) FROM movimientosdetalles as md, movimientos as m WHERE md.mov_id = m.mov_id AND m.mov_anulada = 0 AND md.cue_nombre LIKE 'Caja Efectivo' AND md.mde_tipo = 1"
            SQL2 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 2"
            SQL3 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE 'Caja Efectivo' AND m.mov_tipo = 0 AND m.mov_anulada = 0"
            SQL4 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 3"
        ElseIf sucursal = "KSC" Then
            SQL1 = "SELECT SUM(md.mde_monto) FROM movimientosdetalles as md, movimientos as m WHERE md.mov_id = m.mov_id AND m.mov_anulada = 0 AND md.cue_nombre LIKE 'Caja Efectivo San Carlos' AND md.mde_tipo = 1"
            SQL2 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo San Carlos' AND m.mov_tipo = 2"
            SQL3 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE 'Caja Efectivo San Carlos' AND m.mov_tipo = 0 AND m.mov_anulada = 0"
            SQL4 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo San Carlos' AND m.mov_tipo = 3"
        End If

        'se suman los movimientos cobros
        DA = conexion.EjecutarConsulta(SQL1)
        DA.Fill(DS)
        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
            saldo = Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
        End If
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()

        'se suman los paseIn
        DA = conexion.EjecutarConsulta(SQL2)
        DA.Fill(DS)
        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
        End If
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()

        'se restan los movimientos pagos
        DA = conexion.EjecutarConsulta(SQL3)
        DA.Fill(DS)
        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
            saldo -= Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
        End If
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()

        'se restan los paseOut
        DA = conexion.EjecutarConsulta(SQL4)
        conexion.CerrarConexion()
        DA.Fill(DS)
        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
            saldo -= Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
        End If

        saldo_dec = Convert.ToDecimal(saldo)
        saldo_dec = Decimal.Round(saldo_dec, 2)

        Return saldo_dec
    End Function

    Private Sub btnFallodeCaja_Click(sender As Object, e As EventArgs) Handles btnFallodeCaja.Click
        If txtFecha.Checked Then
            fdcg.id = 0
            Dim CuerpoSelect As String = "fdcg_id, fdcg_fecha, fdcg_fecha, fdcg_fecha"
            FormatoBusqueda("fallodecajaglobal", CuerpoSelect, "fdcg_fecha", Trim(txtFecha.Text.ToString.Replace("/", "-")), False, "fdcg_id", "fdcg_fecha", fdcg.id)
            frmBusqueda.ShowDialog()
            fdcg.id = frmBusqueda.Codigo
            fdcg.fecha = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If fdcg.id <> 0 Then
                If repofdcg.FallodeCaja_Id(fdcg.id, fdcg) Then
                    AcomodoFallodeCaja()
                    EnableCmd(True, btn_imprimir)
                    EnableCmd(False, btnGrabar)
                    btnSalir.Text = "&Cancelar"
                    nuevo = False
                    editar = True
                End If
            Else
                txtFecha.Select()
            End If
        End If
    End Sub

    Private Sub AcomodoFallodeCaja()
        txtFecha.Text = fdcg.fecha
        txtSaldoVia1.Text = fdcg.saldovia1
        txtSaldoVia2.Text = fdcg.saldovia2
        txtExistencia.Text = fdcg.existencia
        txtExistenciaFisica.Text = fdcg.existenciaFisica
        txtSobres.Text = fdcg.sobres
        txtSobresDetalles.Text = fdcg.sobres
        txtVales.Text = fdcg.vales
        txtDetallesVales.Text = fdcg.valesdetalle
        txtDiferencia.Text = fdcg.diferencia
        txtObservaciones.Text = fdcg.observaciones
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If nuevo Then
            If validar() Then
                repofdcg.Insertar(txtFecha.Text, txtSaldoVia1.Text, txtSaldoVia2.Text, txtExistencia.Text, txtExistenciaFisica.Text, txtSobres.Text, txtSobresDetalles.Text, txtVales.Text, txtDetallesVales.Text, txtDiferencia.Text, txtObservaciones.Text, txtCajaFuerte.Text, txtDetalleCajaFuerte.Text)
                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
                LimpiarControles(Me)
                EnableCmd(True, btnFallodeCaja)
                txtFecha.Enabled = True
                visRepFallodeCajaGlobal.sucursal = sucursal
                visRepFallodeCajaGlobal.fecha = txtFecha.Text.ToString.Replace("/", "-")
                If sucursal = "ZOO" Then
                    visRepFallodeCajaGlobal.MdiParent = frmMain
                ElseIf sucursal = "KSC" Then
                    visRepFallodeCajaGlobal.MdiParent = frmMainKSC
                End If
                visRepFallodeCajaGlobal.Show()
            End If
        End If
    End Sub

    Private Function validar() As Boolean
        Dim res As Boolean

        res = True

        If Not txtFecha.Checked Then
            res = False
            ColorearValidacion(True, lblFecha)
        End If
        If txtSaldoVia1.Text = "" Then
            res = False
            ColorearValidacion(True, lblSaldo)
        End If
        If txtSaldoVia2.Text = "" Then
            res = False
            ColorearValidacion(True, lblSaldo)
        End If
        If txtExistencia.Text = "" Then
            res = False
            ColorearValidacion(True, lblExistencia)
        End If
        If txtDiferencia.Text = "" Then
            res = False
            ColorearValidacion(True, lblDiferencia)
        End If
        If txtCajaFuerte.Text = "" Then
            res = False
            ColorearValidacion(True, lblCajaFuerte)
        End If
        If txtObservaciones.Text = "" Then
            res = False
            ColorearValidacion(True, lblObservaciones)
        End If

        Return res
    End Function

    Private Sub txtExistencia_TextChanged(sender As Object, e As EventArgs) Handles txtExistencia.TextChanged
        If Not txtExistencia.Text = "" And Not txtSobres.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And Not txtSobres.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And Not txtSobres.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And Not txtSobres.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        End If
    End Sub

    Private Sub txtsobres_TextChanged(sender As Object, e As EventArgs) Handles txtSobres.TextChanged
        If Not txtExistencia.Text = "" And Not txtSobres.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtSobres.Text = "" And Not txtExistencia.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtSobres.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtSobres.Text)), 2))
        ElseIf Not txtSobres.Text = "" And Not txtExistencia.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtSobres.Text = "" And Not txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtSobres.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text)), 2))
        ElseIf Not txtSobres.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        ElseIf Not txtSobres.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text)), 2))
        End If
    End Sub

    Private Sub txtvales_TextChanged(sender As Object, e As EventArgs) Handles txtVales.TextChanged
        If Not txtExistencia.Text = "" And Not txtSobres.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtVales.Text = "" And Not txtSobres.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        ElseIf Not txtVales.Text = "" And Not txtSobres.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtVales.Text = "" And Not txtCajaFuerte.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtVales.Text = "" And Not txtSobres.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text)), 2))
        ElseIf Not txtVales.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtVales.Text)), 2))
        ElseIf Not txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text)), 2))
        End If
    End Sub

    Private Sub txtCajaFuerte_TextChanged(sender As Object, e As EventArgs) Handles txtVales.TextChanged
        If Not txtExistencia.Text = "" And Not txtSobres.Text = "" And Not txtVales.Text = "" And txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And Not txtSobres.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And Not txtVales.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And Not txtSobres.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And Not txtSobres.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtSobres.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And txtVales.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtVales.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" And txtExistencia.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtCajaFuerte.Text) - Convert.ToDecimal(txtExistencia.Text)), 2))
        ElseIf Not txtCajaFuerte.Text = "" Then
            txtDiferencia.Text = -1 * (Decimal.Round((Convert.ToDecimal(txtSaldoVia1.Text) + Convert.ToDecimal(txtSaldoVia2.Text) - Convert.ToDecimal(txtCajaFuerte.Text)), 2))
        End If
    End Sub
End Class