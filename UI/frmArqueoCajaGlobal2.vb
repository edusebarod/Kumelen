Public Class frmArqueoCajaGlobal2
    Public repofdcg As New RepoFallodeCajaGlobal
    Private fdcg As New FallodeCajaGlobal

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ColorearControles(Me)
            ColorearFRM(Me)
            txtSaldoVia1.Enabled = False
            txtSaldoVia2.Enabled = False
            Me.Text = "Arqueo de Caja de Kumelen Zoológico"
            GroupBox1.Text = "Arqueo de Caja de Kumelen Zoológico"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If btnSalir.Text = "&Cancelar" Then
            LimpiarControles(Me)

            btnSalir.Text = "&Salir"
            fecha = ""
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim saldovia1, saldovia2 As Decimal

        Try
            LimpiarControles(Me)

            saldovia1 = calcularSaldo(Trim(txtFecha.Text.ToString.Replace("/", "-")), True)
            saldovia2 = calcularSaldo(Trim(txtFecha.Text.ToString.Replace("/", "-")), False)

            txtSaldoVia1.Text = saldovia1
            txtSaldoVia2.Text = saldovia2

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function calcularSaldo(fecha As String, bd As Boolean) As Decimal
        Dim conexion As New cBaseDatos
        Dim SQL1, SQL2, SQL3, SQL4 As String
        Dim saldo As Double = 0
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldo_dec As Decimal
        SQL1 = ""
        SQL2 = ""
        SQL3 = ""
        SQL4 = ""

        LimpiarControles(Me)
        conexion.AbrirConexion(bd)
        SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md, movimientos as m WHERE md.mov_id = m.mov_id AND m.mov_anulada = 0 AND md.cue_nombre LIKE 'Caja Efectivo' AND md.mde_tipo = 1 AND md.timestamp <= '{0} 23:59:99'", fecha)
        SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 2 AND timestamp <= '{0} 23:59:99'", fecha)
        SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE 'Caja Efectivo' AND m.mov_tipo = 0 AND m.mov_anulada = 0 AND timestamp <= '{0} 23:59:99'", fecha)
        SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE 'Caja Efectivo' AND m.mov_tipo = 3 AND timestamp <= '{0} 23:59:99'", fecha)
       
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
   
End Class