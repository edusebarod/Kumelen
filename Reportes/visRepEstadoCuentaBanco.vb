Public Class visRepEstadoCuentaBanco
    Public tipo As Integer
    Public monto As Decimal
    Public cuenta As String
    Public fechadesde As String
    Public fechahasta As String
    Public objrep As New rptEstadoCuentaBanco
    Public bd As Boolean

    Private Sub visRepEstadoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldoG As Double

        'Suma en facturaciones y en pasesIn. Resta en pagos y pasesOut (caja)
        If tipo = 1 Then
            If fechadesde = fechahasta Then
                SQL = String.Format("(SELECT dn.razon_social as proveedor, m.mov_CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                    "FROM movimientos as m, datosnegocio as dn " +
                                    "WHERE dn.id = m.per_id AND (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59') AND m.mov_tipo = 0 " +
                                    "UNION " +
                                    "(SELECT dn.razon_social as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                    "FROM movimientos AS m, movimientosdetalles AS md, datosnegocio as dn " +
                                    "WHERE dn.id = m.per_id AND m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59' AND m.mov_tipo = 0 " +
                                    "UNION " +
                                    "(SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as proveedor, m.mov_CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                    "FROM movimientos as m, personas as p " +
                                    "WHERE p.perid = m.per_id AND (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59' AND m.mov_tipo = 1) " +
                                    "UNION " +
                                    "(SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                    "FROM movimientos AS m, movimientosdetalles AS md, personas as p " +
                                    "WHERE p.per_id = m.per_id AND m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59') ORDER BY fecha", cuenta, fechadesde, fechahasta)
            Else
                SQL = String.Format("(SELECT dn.razon_social as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                    "FROM movimientos as m, datosnegocio as dn " +
                                    "WHERE dn.id = m.per_id AND (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}' AND m.mov_tipo = 0) " +
                                    "UNION " +
                                    "(SELECT dn.razon_social as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                    "FROM movimientos AS m, movimientosdetalles AS md, datosnegocio as dn " +
                                    "WHERE dn.id = m.per_id AND m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1}' AND '{2}' AND m.mov_tipo = 0) " +
                                    "UNION " +
                                    "(SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                    "FROM movimientos as m, personas as p " +
                                    "WHERE p.per_id = m.per_id AND (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}' AND m.mov_tipo = 1) " +
                                    "UNION " +
                                    "(SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as proveedor, CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                    "FROM movimientos AS m, movimientosdetalles AS md, personas as p " +
                                    "WHERE p.per_id = m.per_id AND m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1}' AND '{2}' AND m.mov_tipo = 1) ORDER BY fecha", cuenta, fechadesde, fechahasta)
            End If
           
            Try
                conexion.AbrirConexion(bd)
                DA = conexion.EjecutarConsulta(SQL)
                conexion.CerrarConexion()
                DA.Fill(DS)
                DS.Tables(0).TableName = "Detalle"

                DS = corregirvizualizacion(DS, tipo)
                saldoG = saldoGlobal(cuenta)
                objrep.SetDataSource(DS)
                objrep.SetParameterValue(0, cuenta)
                objrep.SetParameterValue(1, monto)
                objrep.SetParameterValue(2, fechadesde)
                objrep.SetParameterValue(3, fechahasta)
                objrep.SetParameterValue(4, saldoG)

                CrystalReportViewer1.ReportSource = objrep
                CrystalReportViewer1.Dock = DockStyle.Fill
                CrystalReportViewer1.Refresh()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'Suma en pagos y paseIn. Resta en paseOut (gastos)
        ElseIf tipo = 2 Then
            SQL = String.Format("(SELECT dn.razon_social as proveedor, m.mov_fecha AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                "FROM movimientos as m, datosnegocio as dn " +
                                "WHERE dn.id = m.per_id AND (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}') " +
                                "UNION " +
                                "(SELECT dn.razon_social as proveedor, m.mov_fecha AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                "FROM movimientos AS m, movimientosdetalles AS md, datosnegocio as dn  " +
                                "WHERE dn.id = m.per_id AND  m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}'" +
                                "ORDER BY fecha", cuenta, fechadesde, fechahasta)

            Try
                conexion.AbrirConexion(bd)
                DA = conexion.EjecutarConsulta(SQL)
                conexion.CerrarConexion()
                DA.Fill(DS)
                DS.Tables(0).TableName = "Detalle"

                DS = corregirvizualizacion(DS, tipo)

                objrep.SetDataSource(DS)
                objrep.SetParameterValue(0, cuenta)
                objrep.SetParameterValue(1, monto)
                objrep.SetParameterValue(2, fechadesde)
                objrep.SetParameterValue(3, fechahasta)

                CrystalReportViewer1.ReportSource = objrep
                CrystalReportViewer1.Refresh()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            'Suma en devengaciones no canceladas y en paseIn. Resta en paseOut(Deudores a Cobrar) 
        ElseIf tipo = 3 Then
            'Suma en devengaciones y en paseIn (Ingresos)
        ElseIf tipo = 4 Then
            'Suma en Pagos y en paseIn. Resta en devengaciones (Bs de Venta) y paseOut
        ElseIf tipo = 5 Then

        End If


    End Sub

    Private Function corregirvizualizacion(DS As DataSet, tipo As Integer)

        If tipo = 1 Then
            For Each dr As DataRow In DS.Tables(0).Rows
                'Si la cuenta es tipo1, se corregen los montos a visualizar
                If dr("tipo") = 0 Or dr("tipo") = 3 Then
                    dr("monto") = dr("monto") * -1
                End If
            Next
        End If
        Return DS
    End Function

    Private Function saldoGlobal(cuenta As String) As Double
        Dim conexion As New cBaseDatos
        Dim SQL1, SQL2 As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim saldo As Double

        SQL1 = String.Format("SELECT SUM(md.mde_monto) FROM movimientosdetalles as md WHERE md.cue_nombre LIKE '{0}' AND md.mde_tipo = 1", cuenta)
        SQL2 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 2", cuenta)
        SQL3 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaHaber LIKE '{0}' AND m.mov_tipo = 0", cuenta)
        SQL4 = String.Format("SELECT SUM(m.mov_total) FROM movimientos as m WHERE m.mov_cuentaDebe LIKE '{0}' AND m.mov_tipo = 3", cuenta)

        conexion.AbrirConexion(bd)
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

        conexion.AbrirConexion(False)

        Return saldo
    End Function
End Class