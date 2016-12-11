Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoTransferencias
    'Devuelve el id y el nombre de las cuentas del plan de cuentas
    Public Function CuentasOrigen(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_pagosGasto = 1 ORDER BY cue_nombre")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function


    Public Function CuentasDestino(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_pagosGasto = 1 ORDER BY cue_nombre")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function


    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function Transferir(ByVal monto As Decimal, ByVal nrocomprobante As String, ByVal observaciones As String, ByVal concepto As String, ByVal ctaOrigen As String, viaCtaOrigen As String, ctaDestino As String, viaCtadestino As String, ByVal fechaComprobante As Date) As Integer
        Dim con As New cBaseDatos
        Dim SQL, SQL2, SQL3 As String
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim movId As Integer = 0
        Dim fechacomp As String
        Dim hoy As String


        Try
            'se formatean la fecha de comprobante y la fecha de hoy
            fechacomp = fechaComprobante.ToString("yyyy-MM-dd")
            hoy = DateTime.Now().ToString("yyyy/MM/dd").ToString

            'Se inserte el movimiento (pago)
            SQL = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_fechaComprobante`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                                             "S/P", "", Cts.movPago, hoy, fechacomp, monto, "0", nrocomprobante, observaciones, concepto, ctaOrigen, ctaDestino)
            'Se obtiene el id del movimiento insertado
            SQL2 = "SELECT MAX(mov_id) FROM `movimientos`"

            con.AbrirConexion()

            result = con.EjecutarComando(SQL)
            DA = con.EjecutarConsulta(SQL2)

            DA.Fill(DS)
            If DS.Tables(0).Rows.Count > 0 Then
                ' se calcula el mvo_id del INSERT anterior
                If IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                    movId = 0
                Else
                    movId = DS.Tables(0).Rows(0).ItemArray(0)
                End If
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If

            ' Se inserta el datalle corespondiente, no asociado a ninguna devengación
            SQL3 = String.Format("INSERT INTO movimientosdetalles(`mde_id`, `mov_id`, `cue_nombre`, `mde_tipo`, `mde_monto`, `mde_concepto`, `mde_observaciones`, `dev_id`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
            movId, ctaOrigen, Cts.movPago, monto, concepto, observaciones, 0)

            result = con.EjecutarComando(SQL3)
            con.CerrarConexion()

            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Function

End Class
