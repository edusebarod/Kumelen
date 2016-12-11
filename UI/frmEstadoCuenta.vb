Public Class frmEstadoCuenta
    Public repoFact As New RepoFacturacion
    Public cuenta As String
    Public tipo As Integer
    Public fecha1 As Date
    Public fecha2 As Date
    Public bd As Boolean
    Public general As Boolean
    Private saldoG As Decimal = 0
    Private fecha1_f, fecha2_f As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL1 As String
        Dim SQL2 As String
        Dim saldo As Double = 0
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldo_dec As Decimal

        If general Then
            fecha1_f = fecha1.ToString("yyyy-MM-dd")
            fecha2_f = fecha2.ToString("yyyy-MM-dd")
            ColorearControles(Me)
            ColorearFRM(Me)

            If Not cuenta = "" Then
                Try
                    txtCuenta.Text = cuenta
                    'calculo saldo en el via1

                    conexion.AbrirConexion(True)

                    'Suma en facturaciones y resta en pagos
                    If tipo = 1 Then
                        'se suman los movimientos cobros
                        If fecha1_f = fecha2_f Then
                            fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1}' AND '{2}'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If

                        DA = conexion.EjecutarConsulta(SQL1)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo = Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se restan los movimientos pagos
                        DA = conexion.EjecutarConsulta(SQL2)
                        conexion.CerrarConexion()

                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo -= Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If

                        'se calcula el saldo en vía 2

                        conexion.AbrirConexion(False)

                        'Suma en facturaciones y resta en pagos
                        'se suman los movimientos cobros
                        If fecha1_f = fecha2_f Then
                            fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1}' AND '{2}'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If

                        DA = conexion.EjecutarConsulta(SQL1)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se restan los movimientos pagos
                        DA = conexion.EjecutarConsulta(SQL2)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo -= Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            fecha1_f = fecha1.ToString("yyyy-MM-dd")
            fecha2_f = fecha2.ToString("yyyy-MM-dd")
            ColorearControles(Me)
            ColorearFRM(Me)

            If Not cuenta = "" Then
                Try
                    txtCuenta.Text = cuenta
                    conexion.AbrirConexion(bd)

                    'Suma en facturaciones y en pasesIn. Resta en pagos y pasesOut (caja)
                    If tipo = 1 Then
                        If fecha1_f = fecha2_f Then
                            'fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            'fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1 AND md.timestamp BETWEEN '{1}' AND '{2}'", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
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

                        'Suma en pagos y paseIn. Resta en paseOut (gastos)
                    ElseIf tipo = 2 Then
                        If fecha1_f = fecha2_f Then
                            'fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            'fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If
                        'se suman los pagos
                        DA = conexion.EjecutarConsulta(SQL1)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo = Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se suman los pases de cuentas paseIn
                        DA = conexion.EjecutarConsulta(SQL2)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
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
                        'Suma en devengaciones no canceladas y en paseIn. Resta en paseOut(Deudores a Cobrar) 
                    ElseIf tipo = 3 Then
                        If fecha1_f = fecha2_f Then
                            'fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            'fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59' AND dd.dde_cancelada = 0;", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp BETWEEN '{1}' AND '{2}' AND dd.dde_cancelada = 0;", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If

                        'se suman las devengaciones no canceladas
                        DA = conexion.EjecutarConsulta(SQL1)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo = Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se suman los pases de cuentas paseIn
                        DA = conexion.EjecutarConsulta(SQL2)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
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
                        'Suma en devengaciones y en paseIn (Ingresos)
                    ElseIf tipo = 4 Then
                        If fecha1_f = fecha2_f Then
                            'fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            'fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If

                        DA = conexion.EjecutarConsulta(SQL1)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo = Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se suman los pases de cuentas paseIn
                        DA = conexion.EjecutarConsulta(SQL2)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
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
                        'Suma en Pagos y en paseIn. Resta en devengaciones (Bs de Venta) y paseOut
                    ElseIf tipo = 5 Then
                        'se suman los movimientos pagos
                        If fecha1_f = fecha2_f Then
                            'fecha1_f = fecha1.ToString("yyyy-MM-dd")
                            'fecha2_f = fecha2.ToString("yyyy-MM-dd")
                            SQL1 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 0 AND m.mov_fechaBETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp = BETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 2 AND m.mov_fechaBETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 3 AND m.mov_fechaBETWEEN '{1} 00:00' AND '{2} 23:59';", cuenta, fecha1_f, fecha2_f)
                        Else
                            SQL1 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 0 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL2 = String.Format("SELECT SUM(dd.dde_monto) FROM devengacionesdetalles as dd WHERE dd.cue_nombre LIKE '{0}' AND dd.timestamp BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 2 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                            SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND md.mov_tipo = 3 AND m.mov_fecha BETWEEN '{1}' AND '{2}';", cuenta, fecha1_f, fecha2_f)
                        End If

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
                        DA = conexion.EjecutarConsulta(SQL3)
                        DA.Fill(DS)
                        If Not IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                            saldo += Convert.ToDouble(DS.Tables(0).Rows(0).ItemArray(0))
                        End If
                        DA.Dispose()
                        DS.Clear()
                        DS.Reset()
                        DS.Dispose()

                        'se restan los movimientos pagos
                        DA = conexion.EjecutarConsulta(SQL2)
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

                    ElseIf tipo = 6 Then
                        'Sin clasificación
                    End If

                    saldo_dec = Convert.ToDecimal(saldo)
                    saldoG = Decimal.Round(saldo_dec, 2)
                    txtSaldo.Text = Decimal.Round(saldo_dec, 2)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        If InStr(cuenta, "Banco") Then
            visRepEstadoCuentaBanco.cuenta = cuenta
            visRepEstadoCuentaBanco.tipo = tipo
            visRepEstadoCuentaBanco.monto = saldoG
            visRepEstadoCuentaBanco.fechadesde = fecha1_f
            visRepEstadoCuentaBanco.fechahasta = fecha2_f
            visRepEstadoCuentaBanco.MdiParent = frmMain
            visRepEstadoCuentaBanco.bd = bd
            visRepEstadoCuentaBanco.Show()
           
        ElseIf InStr(cuenta, "Caja") Then
            visRepEstadoCuentaCaja.cuenta = cuenta
            visRepEstadoCuentaCaja.tipo = tipo
            visRepEstadoCuentaCaja.monto = saldoG
            visRepEstadoCuentaCaja.fechadesde = fecha1_f
            visRepEstadoCuentaCaja.fechahasta = fecha2_f
            visRepEstadoCuentaCaja.MdiParent = frmMain
            visRepEstadoCuentaCaja.bd = bd
            visRepEstadoCuentaCaja.Show()
        ElseIf tipo = 2 Then
            visRepEstadoCuentaGastos.cuenta = cuenta
            visRepEstadoCuentaGastos.tipo = tipo
            visRepEstadoCuentaGastos.monto = saldoG
            visRepEstadoCuentaGastos.fechadesde = fecha1_f
            visRepEstadoCuentaGastos.fechahasta = fecha2_f
            visRepEstadoCuentaGastos.MdiParent = frmMain
            visRepEstadoCuentaGastos.bd = bd
            visRepEstadoCuentaGastos.Show()

        Else
            visRepEstadoCuenta.cuenta = cuenta
            visRepEstadoCuenta.tipo = tipo
            visRepEstadoCuenta.monto = saldoG
            visRepEstadoCuenta.fechadesde = fecha1_f
            visRepEstadoCuenta.fechahasta = fecha2_f
            visRepEstadoCuenta.MdiParent = frmMain
            visRepEstadoCuenta.bd = bd
            visRepEstadoCuenta.Show()
        End If
    End Sub
End Class