Public Class visRepEstadoCuentaCaja
    Public tipo As Integer
    Public monto As Decimal
    Public cuenta As String
    Public fechadesde As String
    Public fechahasta As String
    Public objrep As New rptEstadoCuentaCaja
    Public bd As Boolean

    Private Sub visRepEstadoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()

        If tipo = 1 Then
            'If fechadesde = fechahasta Then
            'SQL = String.Format("(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura " +
            '                  "FROM movimientos as m " +
            '                 "WHERE (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59') " +
            '                "UNION " +
            '               "(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura " +
            '              "FROM movimientos AS m, movimientosdetalles AS md " +
            '             "WHERE m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1} 00:00' AND '{2} 23:59') ORDER BY fecha", cuenta, fechadesde, fechahasta)
            'Else
            '   SQL = String.Format("(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura " +
            '                      "FROM movimientos as m " +
            '                     "WHERE (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}') " +
            '                    "UNION " +
            '                   "(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura " +
            '                  "FROM movimientos AS m, movimientosdetalles AS md " +
            '                 "WHERE m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1}' AND '{2}') ORDER BY fecha", cuenta, fechadesde, fechahasta)
            'End If
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

                objrep.SetDataSource(DS)
                objrep.SetParameterValue(0, cuenta)
                objrep.SetParameterValue(1, monto)
                objrep.SetParameterValue(2, fechadesde)
                objrep.SetParameterValue(3, fechahasta)

                CrystalReportViewer1.ReportSource = objrep
                CrystalReportViewer1.Dock = DockStyle.Fill
                CrystalReportViewer1.Refresh()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf tipo = 2 Then
            SQL = String.Format("(SELECT m.mov_fecha AS fecha, m.mov_concepto as concepto, m.mov_total as monto, m.mov_encargado as encargado, m.mov_obs as observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, m.mov_id as id " +
                                "FROM movimientos as m " +
                                "WHERE (m.mov_cuentaDebe LIKE '{0}' OR m.mov_cuentaHaber LIKE '{0}') AND m.timestamp BETWEEN '{1}' AND '{2}') " +
                                "UNION " +
                                "(SELECT m.mov_fecha AS fecha, md.mde_concepto AS concepto, md.mde_monto AS monto, m.mov_encargado as encargado, m.mov_obs AS observaciones, m.mov_tipo as tipo, m.mov_nro_factura as nroFactura, md.mde_id as id " +
                                "FROM movimientos AS m, movimientosdetalles AS md " +
                                "WHERE m.mov_id = md.mov_id AND md.cue_nombre LIKE  '{0}' AND m.timestamp BETWEEN '{1}' AND '{2}')" +
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
        ElseIf tipo = 3 Then

        ElseIf tipo = 4 Then

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
End Class