Public Class frmArqueoCaja
    Public repofdc As New RepoFallodeCaja
    Public bd As Boolean
    Private fdc As New FallodeCaja
    Private editar As Boolean
    Private nuevo As Boolean


    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ColorearControles(Me)
            ColorearFRM(Me)
            EnableCmd(False, btn_imprimir)
            EnableCmd(False, btnGrabar)
            txtSaldo.Enabled = False
            txtExistencia.Enabled = False
            txtDiferencia.Enabled = False
            txtObservaciones.Enabled = False
            editar = False
            nuevo = False
            If bd Then
                Text = "Arqueo de Caja Vía 1"
            Else
                Text = "Arqueo de Caja Vía 2"
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
        visRepFallodeCaja.fecha = txtFecha.Text.ToString.Replace("/", "-")
        visRepFallodeCaja.MdiParent = frmMain
        visRepFallodeCaja.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim conexion As New cBaseDatos
        Dim SQL1 As String
        Dim saldo As Double = 0
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldo_dec As Decimal
        Dim fecha As String

        Try
            nuevo = True
            editar = False
            EnableCmd(False, btn_imprimir)
            EnableCmd(False, btnFallodeCaja)
            EnableCmd(True, btnGrabar)
            txtSaldo.Enabled = False
            txtExistencia.Enabled = True
            'txtDiferencia.Enabled = True
            txtObservaciones.Enabled = True
            editar = False
            LimpiarControles(Me)

            fecha = DateTime.Now().ToString("yyyy/MM/dd").ToString

            'se calculan los movimientos del día
            conexion.AbrirConexion(bd)
            SQL1 = "SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE 'Caja Efectivo' AND md.mde_tipo = 1"
            SQL2 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 2"
            SQL3 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE 'Caja Efectivo' AND m.mov_tipo = 0"
            SQL4 = "SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 3"

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
            DA.Fill(DS)
            If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                saldo -= Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
            End If

            saldo_dec = Convert.ToDecimal(saldo)
            saldo_dec = Decimal.Round(saldo_dec, 2)
            txtSaldo.Text = Decimal.Round(saldo_dec, 2)
            txtFecha.Value = DateTime.Now()
            txtFecha.Enabled = False

            conexion.CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFallodeCaja_Click(sender As Object, e As EventArgs) Handles btnFallodeCaja.Click
        If txtFecha.Checked Then
            fdc.id = 0
            Dim CuerpoSelect As String = "fdc_id, fdc_fecha, fdc_fecha, fdc_fecha"
            FormatoBusqueda("fallodecaja", CuerpoSelect, "fdc_fecha", Trim(txtFecha.Text.ToString.Replace("/", "-")), True, "fdc_id", "fdc_fecha", fdc.id)
            frmBusqueda.ShowDialog()
            fdc.id = frmBusqueda.Codigo
            fdc.fecha = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If fdc.id <> 0 Then
                If repofdc.FallodeCaja_Id(fdc.id, fdc) Then
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
        txtFecha.Text = fdc.fecha
        txtSaldo.Text = fdc.saldo
        txtExistencia.Text = fdc.existencia
        txtDiferencia.Text = fdc.diferencia
        txtObservaciones.Text = fdc.observaciones
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If nuevo Then
            If validar() Then
                repofdc.Insertar(txtFecha.Text, txtSaldo.Text, txtExistencia.Text, txtDiferencia.Text, txtObservaciones.Text)
                MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
                LimpiarControles(Me)
                EnableCmd(True, btnFallodeCaja)
                txtFecha.Enabled = True
                visRepFallodeCaja.fecha = txtFecha.Text.ToString.Replace("/", "-")
                visRepFallodeCaja.MdiParent = frmMain
                visRepFallodeCaja.Show()
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
        If txtSaldo.Text = "" Then
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
        If txtObservaciones.Text = "" Then
            res = False
            ColorearValidacion(True, lblObservaciones)
        End If

        Return res
    End Function

    Private Sub txtExistencia_TextChanged(sender As Object, e As EventArgs) Handles txtExistencia.TextChanged
        If Not txtExistencia.Text = "" Then
            txtDiferencia.Text = Decimal.Round((Convert.ToDecimal(txtSaldo.Text) - Convert.ToDecimal(txtExistencia.Text)), 2)
        End If
    End Sub
End Class