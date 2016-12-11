Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoFacturacion
    'Devuelve el id y el nombre de las cuentas del plan de cuentas
    Public Function Cuentas(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_facturaciones = 1 ORDER BY cue_nombre")
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

    Public Function Cuentas_Estado(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas ORDER BY cue_nombre")
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

    Public Function Cuentas_Estado_Tipo(tipo As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_grupo = {0} ORDER BY cue_nombre", tipo)
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

    'Devuelve el id, el nombre y el precio de los servicios que brinda la escuela
    Public Function Servicios(Optional ByVal bd As Boolean = True) As DataSet
        'Esto iría en repoServicios
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_id, serv_nombre, serv_precio FROM servicios WHERE serv_activo = 1 ORDER BY serv_nombre")
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

    'Devuelve un dataset con las facturas con su detalle por persona
    Public Function Facturas(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura), mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 ORDER BY alumno")
        Dim SQL As String = String.Format("SELECT mov_id, mov_pto_venta, mov_nro_factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 ORDER BY alumno")
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

    'Devuelve un dataset con los gastos con su detalle
    Public Function Gastos(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura), mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 ORDER BY alumno")
        Dim SQL As String = String.Format("SELECT mov_id, mov_nro_factura, mov_fecha, mov_concepto, razon_social, mov_total FROM movimientos as m, datosnegocio as p WHERE m.per_id = p.id AND m.mov_tipo = 0 AND mov_anulada = 0 ORDER BY mov_id")
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

    'Devuelve un dataset con las facturas con su detalle por nro de factura
    Public Function Facturas_Nro_Factura(ByVal pto_venta As Integer, ByVal nro_factura As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura), mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND mov_pto_venta = {0} AND mov_nro_factura = {1} ORDER BY alumno", pto_venta, nro_factura)
        Dim SQL As String = String.Format("SELECT mov_id, mov_pto_venta, mov_nro_factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND mov_pto_venta = {0} AND mov_nro_factura = {1} ORDER BY alumno", pto_venta, nro_factura)
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

    'Devuelve un dataset con los gastos con su detalle por nro de comprobante
    Public Function Gastos_Nro_Comprobante(ByVal nro_comprobante As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT mov_id, mov_nro_factura, mov_fecha, mov_concepto, razon_social, mov_total FROM movimientos as m, datosnegocio as p WHERE m.per_id = p.id AND m.mov_tipo = 0 AND mov_nro_factura LIKE '%{0}%' AND mov_anulada = 0 ORDER BY mov_id", nro_comprobante)
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

    'Devuelve un dataset con las facturas con su detalle en un rango de fechas
    Public Function Facturas_Fecha(ByVal fecha1 As String, ByVal fecha2 As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura), mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND mov_fecha BETWEEN '{0}' AND '{1}' ORDER BY alumno", fecha1, fecha2)
        Dim SQL As String = String.Format("SELECT mov_id, mov_pto_venta, mov_nro_factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND mov_fecha BETWEEN '{0}' AND '{1}' ORDER BY alumno", fecha1, fecha2)
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

    'Devuelve un dataset con los gastos con su detalle en un rango de fechas
    Public Function Gastos_Fecha(ByVal fecha1 As String, ByVal fecha2 As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura), mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND mov_fecha BETWEEN '{0}' AND '{1}' ORDER BY alumno", fecha1, fecha2)
        Dim SQL As String = String.Format("SELECT mov_id, mov_nro_factura, mov_fecha, mov_concepto, razon_social, mov_total FROM movimientos as m, datosnegocio as p WHERE m.per_id = p.id AND m.mov_tipo = 0 AND mov_fecha BETWEEN '{0}' AND '{1}' AND mov_anulada = 0 ORDER BY mov_id", fecha1, fecha2)
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

    'Devuelve un dataset con las facturas con su detalle en un rango de fechas par< FE AFIP
    Public Function Facturas_Fecha_FEAFIP(ByVal fecha1 As String, ByVal fecha2 As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT ""015"" as TipoComp, `mov_fecha` as ""FechaComp"", ""0005"" as PtoVta, `mov_nro_factura` as NCompDesde, `mov_nro_factura` as NCompHasta, ""96"" as TipoDoc, `mov_encargado` as DNIPapa, `mov_total` as ImpTotalOp, ""0"" as ITCNING, ""0"" as ING, ""0"" as IL, ""0"" as ILRNI, `mov_total` as ImpOpExentas FROM `movimientos` WHERE `mov_pto_venta` = 2 AND `mov_fecha` BETWEEN '{0}' AND '{1}'", fecha1, fecha2)
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
    'Devuelve un dataset con las facturas con su detalle por apellido del alumno
    Public Function Facturas_Alumno_nombre(ByVal Alumno As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura) as Nro_Factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND p.per_apellido LIKE '%{0}%' ORDER BY alumno", Alumno)
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

    'Devuelve un dataset con las facturas con su detalle por apellido del alumno
    Public Function Facturas_Alumno_id(ByVal id As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        'Dim SQL As String = String.Format("SELECT mov_id, CONCAT(mov_pto_venta, '-', mov_nro_factura) as Nro_Factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND p.per_id = {0} ORDER BY alumno", id)
        Dim SQL As String = String.Format("SELECT mov_id, mov_pto_venta, mov_nro_factura, mov_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, mov_total FROM movimientos as m, personas as p WHERE m.per_id = p.per_id AND m.mov_tipo = 1 AND p.per_id = {0} ORDER BY alumno", id)
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
    Public Function Facturar(ByVal alu As Integer, ByVal encargado As String, ByVal total As Double, ByVal ptovta As String, ByVal observaciones As String, ByVal sala As String, ByVal detalle As DataGridView, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DS_dde As DataSet = New DataSet()
        Dim DS_temp As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA_dde As New MySqlClient.MySqlDataAdapter
        Dim DA_temp As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim SQL_dev As String
        Dim SQL_dde As String
        Dim SQL_temp As String
        Dim nrofact As String = ""
        Dim nrofact_n As Integer
        Dim movId As Integer
        Dim devId As Integer
        Dim ddeId As Integer
        Dim result As Integer
        Dim idmov As Integer
        'Dim dr As DataRow
        'Dim cantidad As Integer
        Dim repoServ As New RepoServicio

        con.AbrirConexion(bd)
        'se obtien el ultimo movimiento correspondiente a una factura
        SQL = String.Format("SELECT MAX(mov_id) FROM `movimientos` WHERE mov_tipo = 1 AND mov_pto_venta = {0}", ptovta)
        Try
            DA = con.EjecutarConsulta(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            ' si es el primer movimiento, la consulta devuelve null, lo que es equivalente a cero
            If IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                movId = 0
            Else
                movId = DS.Tables(0).Rows(0).ItemArray(0)
            End If
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        DA.Dispose()
        DS.Clear()
        DS.Dispose()

        If movId = 0 And ptovta = 2 Then
            nrofact = "0001436"
        ElseIf movId = 0 And ptovta = 3 Then
            nrofact = "0000140"
        ElseIf movId = 0 And ptovta = 4 Then
            nrofact = "0000001"
        Else
            'se obtiene el numero de factura de la ultima facturacion en el punto de venta indicado por argumento
            SQL = String.Format("SELECT mov_nro_factura FROM `movimientos` WHERE mov_id = {0}", movId)
            Try
                DA = con.EjecutarConsulta(SQL)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
            DA.Fill(DS2)
            If DS2.Tables(0).Rows.Count > 0 Then
                ' si es la primera factura, la consulta devuelve null, lo que es equivalente a 1
                If IsDBNull(DS2.Tables(0).Rows(0).ItemArray(0)) Then
                    nrofact = "0001436"
                Else
                    'se construye el numero de factura correspondiente a la presente facturacion
                    nrofact_n = Convert.ToInt16(DS2.Tables(0).Rows(0).ItemArray(0)) + 1
                    nrofact = nrofact_n.ToString
                    nrofact = nrofact.PadLeft(8, "0")
                End If
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If
        End If
        DA.Dispose()
        DS2.Clear()
        DS2.Dispose()

        'se factura
        SQL = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`, `mov_sala`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                                         alu, encargado, Cts.movCobro, DateTime.Now().ToString("yyyy/MM/dd").ToString, total, ptovta, nrofact, observaciones, "", "", "", sala)
        Try
            result = con.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se facturan los detalles
        For Each row As DataGridViewRow In detalle.Rows
            'si el id de la devengacion y de del detalle son 0, entonces es un interes por mora
            If row.Cells("dev_id").Value = 0 And row.Cells("dde_id").Value = 0 Then
                'se devenga 
                SQL_dev = String.Format("INSERT INTO `devengaciones` (`dev_id`, `dev_vencimiento1`, `dev_vencimiento2`, `dev_vencimiento3`, `per_id`, `dev_total`, `dev_fecha`, `dev_observaciones`, `dev_tipo`, `dev_cancelada`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                  DateTime.Now().ToString("yyyy/MM/dd").ToString, DateTime.Now().ToString("yyyy/MM/dd").ToString, DateTime.Now().ToString("yyyy/MM/dd").ToString, alu, row.Cells("Monto").Value, DateTime.Now.ToString("yyyy/MM/dd").ToString, observaciones, 0, 0)
                Try
                    result = con.EjecutarComando(SQL_dev)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return Nothing
                End Try

                SQL_dde = "SELECT MAX(dev_id) FROM `devengaciones`"
                Try
                    DA_dde = con.EjecutarConsulta(SQL_dde)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
                DA_dde.Fill(DS_dde)
                If DS_dde.Tables(0).Rows.Count > 0 Then
                    devId = DS_dde.Tables(0).Rows(0).ItemArray(0)
                Else
                    MsgBox(Cts.msgErrSinResultados)
                End If

                ' para cada fila de la grilla se hace un insert en la bd
                SQL = String.Format("INSERT INTO devengacionesdetalles (`dde_id`, `dev_id`, `cue_nombre`, `serv_nombre`, `dde_monto`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}')",
                                            devId, "Ingresos por Intereses", "Intereses devengados", row.Cells("monto").Value)
                Try
                    result = con.EjecutarComando(SQL)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
                row.Cells("dev_id").Value = devId

                DA_dde.Dispose()
                DS_dde.Clear()
                DS_dde.Reset()
                DS_dde.Dispose()
                SQL_dde = "SELECT MAX(dde_id) FROM `devengacionesdetalles`"
                Try
                    DA_dde = con.EjecutarConsulta(SQL_dde)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
                DA_dde.Fill(DS_dde)
                If DS_dde.Tables(0).Rows.Count > 0 Then
                    ddeId = DS_dde.Tables(0).Rows(0).ItemArray(0)
                Else
                    MsgBox(Cts.msgErrSinResultados)
                End If
                row.Cells("dde_id").Value = ddeId
            End If

            'se facturan los detalles
            'calculo el id del movimiento insertado recientemente
            SQL_temp = "SELECT MAX(m.mov_id) FROM movimientos as m"
            Try
                DA_temp = con.EjecutarConsulta(SQL_temp)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
            DA_temp.Fill(DS_temp)
            If DS_temp.Tables(0).Rows.Count > 0 Then
                idmov = DS_temp.Tables(0).Rows(0).ItemArray(0)
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If

            SQL = String.Format("INSERT INTO movimientosdetalles(`mde_id`, `mov_id`, `cue_nombre`, `mde_tipo`, `mde_monto`, `mde_concepto`, `mde_observaciones`, `dev_id`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                            idmov, row.Cells("cuenta").Value, Cts.movCobro, row.Cells("monto").Value, row.Cells("concepto").Value, observaciones, row.Cells("dev_id").Value)
            SQL2 = String.Format("UPDATE devengacionesdetalles as d SET d.dde_cancelada = 1 WHERE d.dde_id = {0}", row.Cells("dde_id").Value)
            'If Not bd Then
            '   If repoServ.EsProducto(row.Cells("concepto").Value, False) Then
            'SQL3 = String.Format("SELECT serv_cantidad FROM servicios s WHERE s.serv_nombre LIKE '{0}'", row.Cells("concepto").Value)
            '
            'Try
            'DA = con.EjecutarConsulta(SQL3)
            'DA.Fill(DS3)
            'dr = DS3.Tables(0).Rows(0)
            'cantidad = Convert.ToInt16(dr("serv_cantidad"))
            'SQL4 = String.Format("UPDATE servicios as s SET s.serv_cantidad = {0} WHERE s.serv_id = {1}", cantidad - 1, row.Cells("dev_id").Value)
            'result = con.EjecutarComando(SQL4)
            'Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            ' Return Nothing
            ' End Try
            '     End If
            'End If
            Try
                result = con.EjecutarComando(SQL)
                result = con.EjecutarComando(SQL2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        Next
        con.CerrarConexion()
        Return idmov
    End Function


    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function FacturarAlu(ByVal alu As Integer, ByVal dev_id As Integer, ByVal encargado As String, ByVal cuenta As String, ByVal concepto As String, ByVal ptovta As String, ByVal total As Decimal, ByVal observaciones As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DS_dde As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA_dde As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim nrofact As String = ""
        Dim nrofact_n As Integer
        Dim movId As Integer
        Dim result As Integer
        Dim repoServ As New RepoServicio

        con.AbrirConexion(bd)
        'se obtien el ultimo movimiento correspondiente a una factura
        SQL = String.Format("SELECT MAX(mov_id) FROM `movimientos` WHERE mov_tipo = 1 AND mov_pto_venta = {0}", ptovta)
        'SQL = "SELECT MAX(mov_nro_factura) FROM `movimientos` WHERE mov_tipo = 1"
        Try
            DA = con.EjecutarConsulta(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            ' si es el primer movimiento, la consulta devuelve null, lo que es equivalente a cero
            If IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                movId = 0
            Else
                movId = DS.Tables(0).Rows(0).ItemArray(0)
            End If
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        DA.Dispose()
        DS.Clear()
        DS.Dispose()

        If movId = 0 And ptovta = 2 Then
            nrofact = "0001436"
        ElseIf movId = 0 And ptovta = 3 Then
            nrofact = "0000140"
        Else
            'se obtiene el numero de factura de la ultima facturacion en el punto de venta indicado por argumento
            SQL = String.Format("SELECT mov_nro_factura FROM `movimientos` WHERE mov_id = {0}", movId)
            'SQL = "SELECT MAX(mov_nro_factura) FROM `movimientos` WHERE mov_tipo = 1"
            Try
                DA = con.EjecutarConsulta(SQL)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
            DA.Fill(DS2)
            If DS2.Tables(0).Rows.Count > 0 Then
                ' si es la primera factura, la consulta devuelve null, lo que es equivalente a 1
                If IsDBNull(DS2.Tables(0).Rows(0).ItemArray(0)) Then
                    nrofact = "0001436"
                Else
                    'se construye el numero de factura correspondiente a la presente facturacion
                    nrofact_n = Convert.ToInt16(DS2.Tables(0).Rows(0).ItemArray(0)) + 1
                    nrofact = nrofact_n.ToString
                    nrofact = nrofact.PadLeft(8, "0")
                End If
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If
        End If
        DA.Dispose()
        DS2.Clear()
        DS2.Dispose()

        'se factura
        SQL = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                                         alu, encargado, Cts.movCobro, DateTime.Now().ToString("yyyy/MM/dd").ToString, total, ptovta, nrofact, observaciones, "", "", "")
        Try
            result = con.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se facturan los detalles
        SQL = String.Format("INSERT INTO movimientosdetalles(`mde_id`, `mov_id`, `cue_nombre`, `mde_tipo`, `mde_monto`, `mde_concepto`, `mde_observaciones`, `dev_id`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                        movId + 1, cuenta, Cts.movCobro, total, concepto, observaciones, dev_id)
        SQL2 = String.Format("UPDATE devengacionesdetalles as d SET d.dde_cancelada = 1 WHERE d.dev_id = {0}", dev_id)
        Try
            result = con.EjecutarComando(SQL)
            result = con.EjecutarComando(SQL2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        con.CerrarConexion()
        Return movId + 1
    End Function


    'Devuelve el id y el nombre de los cursos
    Public Function Curso(cursoid As Integer, Optional ByVal bd As Boolean = True) As String
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_nombre FROM cursos WHERE cur_id = '{0}'", cursoid)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Curso = ""
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Dim dr As DataRow
            dr = DS.Tables(0).Rows(0)
            Curso = dr("cur_nombre")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Curso
    End Function

    'Devuelve el monto de un servicio a partir de su id
    'Esto iría en repoServicios
    Public Function montoServicio(id As Integer, Optional ByVal bd As Boolean = True) As Double
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_precio FROM servicios WHERE serv_id = '{0}'", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Dim dr As DataRow
            dr = DS.Tables(0).Rows(0)
            montoServicio = dr("serv_precio")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Anula un movimiento por su id
    Public Function Anular_Movimiento(ByVal id_mov As Integer, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("UPDATE movimientos as m SET m.mov_anulada = 1 WHERE m.mov_id = {0}", id_mov)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim id As Integer = 0
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            'id = DS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

    'Anula una factura con todos sus detalles y devengaciones asociadas
    Public Function Anula_Factura(nrofactura As String, ptoVta As Integer, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DA2 As New MySqlClient.MySqlDataAdapter
        Dim DS2 As DataSet = New DataSet()
        Dim movid As Integer

        'se extrae el id del moviemiento
        SQL = String.Format("SELECT mov_id FROM `movimientos` WHERE `mov_nro_factura` = {0} AND `mov_pto_venta` = {1}", nrofactura, ptoVta)

        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            movid = DS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'se extraen los id de las devengaciones asociadas
        SQL = String.Format("SELECT dev_id FROM `movimientosdetalles` WHERE `mov_id` = {0}", movid)

        Try
            DA2 = conexion.EjecutarConsulta(SQL)
            DA2.Fill(DS2)
            'devid = DS2.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'se descancelan las devengaciones asociadas y se anulan los detalles del movimiento
        Try
            For Each row As DataRow In DS2.Tables(0).Rows
                SQL = String.Format("UPDATE  `devengacionesdetalles` SET  `dde_cancelada` =  '0' WHERE  `devengacionesdetalles`.`dev_id` = {0}; " +
                                    "UPDATE  `devengacionesdetalles` SET  `dde_anulada` =  '1' WHERE  `devengacionesdetalles`.`dev_id` = {0} AND serv_nombre LIKE 'Intereses devengados'; ", row(0))
                conexion.EjecutarComando(SQL)
            Next

            SQL = String.Format("UPDATE `movimientosdetalles` SET `cue_nombre` = '-', `mde_tipo` = '0', `mde_monto` = '0', `mde_concepto` = '-', `mde_observaciones` = 'ANULADA', `dev_id` = '0' WHERE `movimientosdetalles`.`mov_id` = {0}", movid)
            conexion.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'se anula el movimiento
        SQL = String.Format("UPDATE `movimientos` SET `mov_obs` = 'ANULADA', `mov_anulada` = '1' WHERE `movimientos`.`mov_id` = {0}", movid)
        Try
            conexion.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return movid
    End Function

    'Anula un gasto con todos sus detalles por numero de comprobante
    Public Function Anula_Gasto(nrocomprobante As String, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim DA2 As New MySqlClient.MySqlDataAdapter
        Dim DS2 As DataSet = New DataSet()
        Dim movid As Integer

        'se extrae el id del moviemiento
        SQL = String.Format("SELECT mov_id FROM `movimientos` WHERE `mov_nro_factura` LIKE '{0}' AND mov_tipo = 0", nrocomprobante)

        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            movid = DS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'se anula el movimiento
        SQL = String.Format("UPDATE `movimientos` SET `mov_obs` = 'ANULADA', `mov_anulada` = '1' WHERE `movimientos`.`mov_id` = {0}", movid)
        Try
            conexion.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return movid
    End Function

    'Anula un gasto con todos sus detalles por id
    Public Sub Anula_GastoXid(id As String, Optional ByVal bd As Boolean = True)
        Dim conexion As New cBaseDatos
        Dim SQL As String

        'se anula el movimiento
        SQL = String.Format("UPDATE `movimientos` SET `mov_obs` = 'ANULADA', `mov_anulada` = '1' WHERE `movimientos`.`mov_id` = {0}", id)
        Try
            conexion.AbrirConexion(bd)
            conexion.EjecutarComando(SQL)
            conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
