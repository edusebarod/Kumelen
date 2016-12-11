Public Class visRepBuscarMovimientos

    Public tipo As Integer
    Public monto As Decimal
    Public cuenta As String
    Public fechadesde As Date
    Public fechahasta As Date
    Public objrep As New rptMovimientos
    Public bd As Boolean

    Private Sub visRepEstadoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim fecha1_f, fecha2_f As String

        fecha1_f = fechadesde.ToString("yyyy-MM-dd")
        fecha2_f = fechahasta.ToString("yyyy-MM-dd")

        If fechadesde = fechahasta Then
            SQL = String.Format("(SELECT CAST(mov_fecha as CHAR) as fecha, CAST(mov_tipo as CHAR) as tipo, md.mde_concepto as concepto, mov_sala as sala, CONCAT(p.per_apellido, ', ', p.per_nombre) as alumno, md.mde_monto as ingreso , '' as egreso, md.cue_nombre as cuenta, m.mov_obs as observaciones, mov_nro_factura as nroFactura " +
                                "FROM `movimientos` as m, movimientosdetalles as md, personas as p " +
                                "WHERE m.mov_id = md.mov_id AND m.per_id = p.per_id AND m.mov_tipo = 1 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0} 00:00' AND '{1} 23:59') " +
                                "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) as fecha, CAST(mov_tipo as CHAR) as tipo, m.mov_concepto as concepto, mov_sala as sala, dn.razon_social as alumno, '' as ingreso, m.mov_total as egreso, m.mov_cuentaHaber as cuenta, m.mov_obs as observaciones, mov_nro_factura as nroFactura  " +
                                "FROM `movimientos` as m,  datosnegocio as dn " +
                                "WHERE m.per_id = dn.id AND m.mov_tipo = 0 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0} 00:00' AND '{1} 23:59') " +
                                "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) AS fecha, CAST(mov_tipo as CHAR) AS tipo, m.mov_concepto AS concepto, mov_sala AS sala,  '' AS alumno, m.mov_total AS ingreso,  '' AS egreso, m.mov_cuentaDebe AS cuenta, m.mov_obs AS observaciones, mov_nro_factura as nroFactura  " +
                                "FROM  `movimientos` AS m " +
                                "WHERE m.mov_tipo = 2 AND m.mov_anulada =0 AND m.mov_fecha BETWEEN '{0} 00:00' AND  '{1} 23:59') " +
                                "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) AS fecha, CAST(mov_tipo as CHAR) AS tipo, m.mov_concepto AS concepto, mov_sala AS sala,  '' AS alumno,  '' AS ingreso, m.mov_total AS egreso, m.mov_cuentaHaber AS cuenta, m.mov_obs AS observaciones, mov_nro_factura as nroFactura  " +
                                "FROM  `movimientos` AS m " +
                                "WHERE m.mov_tipo = 3 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0} 00:00' AND '{1} 23:59') " +
                                "ORDER BY fecha ASC", fecha1_f, fecha2_f)
        Else
            SQL = String.Format("(SELECT CAST(mov_fecha as CHAR) as fecha, CAST(mov_tipo as CHAR) as tipo, md.mde_concepto as concepto, mov_sala as sala, CONCAT(p.per_apellido, ', ', p.per_nombre) as alumno, md.mde_monto as ingreso , '' as egreso, md.cue_nombre as cuenta, m.mov_obs as observaciones, mov_nro_factura as nroFactura  " +
                                "FROM `movimientos` as m, movimientosdetalles as md, personas as p " +
                                "WHERE m.mov_id = md.mov_id AND m.per_id = p.per_id AND m.mov_tipo = 1 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0}' AND '{1}') " +
                                "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) as fecha, CAST(mov_tipo as CHAR) as tipo, m.mov_concepto as concepto, mov_sala as sala, dn.razon_social as alumno, '' as ingreso, m.mov_total as egreso, m.mov_cuentaHaber as cuenta, m.mov_obs as observaciones, mov_nro_factura as nroFactura  " +
                                "FROM `movimientos` as m, datosnegocio as dn " +
                                "WHERE m.per_id = dn.id AND m.mov_tipo = 0 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0}' AND '{1}') " +
                                 "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) AS fecha, CAST(mov_tipo as CHAR) AS tipo, m.mov_concepto AS concepto, mov_sala AS sala,  '' AS alumno, m.mov_total AS ingreso,  '' AS egreso, m.mov_cuentaDebe AS cuenta, m.mov_obs AS observaciones, mov_nro_factura as nroFactura  " +
                                "FROM  `movimientos` AS m " +
                                "WHERE m.mov_tipo = 2 AND m.mov_anulada =0 AND m.mov_fecha BETWEEN '{0}' AND  '{1}') " +
                                "UNION " +
                                "(SELECT CAST(mov_fecha as CHAR) AS fecha, CAST(mov_tipo as CHAR) AS tipo, m.mov_concepto AS concepto, mov_sala AS sala,  '' AS alumno,  '' AS ingreso, m.mov_total AS egreso, m.mov_cuentaHaber AS cuenta, m.mov_obs AS observaciones, mov_nro_factura as nroFactura  " +
                                "FROM  `movimientos` AS m " +
                                "WHERE m.mov_tipo = 3 AND m.mov_anulada = 0 AND m.mov_fecha BETWEEN '{0}' AND '{1}') " +
                                "ORDER BY fecha ASC", fecha1_f, fecha2_f)
        End If


        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Detalles"

            DS = corregirvizualizacion(DS)
            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, fechadesde)
            objrep.SetParameterValue(1, fechahasta)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Dock = DockStyle.Fill
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cambia el tipo de movimiento con etiquetas significativas para el usuario
    ''' </summary>
    ''' <param name="DS"></param>
    ''' <returns>Retorna el mismo DS pero en la columna tipo reemplazo 0 por Egreo y 1 por Ingreso</returns>
    ''' <remarks></remarks>
    Private Function corregirvizualizacion(DS As DataSet)
        For Each dr As DataRow In DS.Tables(0).Rows
            If dr("tipo") = 0 Then
                dr("tipo") = "Egreso"
            ElseIf dr("tipo") = 1 Then
                dr("tipo") = "Ingreso"
            ElseIf dr("tipo") = 2 Then
                dr("tipo") = "Entrante"
            ElseIf dr("tipo") = 3 Then
                dr("tipo") = "Saliente"
            End If
        Next
        Return DS
    End Function
End Class