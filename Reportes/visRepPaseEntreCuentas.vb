Public Class visRepPaseEntreCuentas

    Public tipo As Integer
    Public monto As Decimal
    Public cuenta As String
    Public fechadesde As Date
    Public fechahasta As Date
    Public objrep As New rptPaseEntreCuentas
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
            SQL = String.Format("(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_cuentaDebe as cuenta, m.mov_total as monto, m.mov_obs as observaciones, m.mov_tipo as tipo " +
                               "FROM movimientos as m " +
                               "WHERE (m.mov_tipo = 2 OR m.mov_tipo = 3) AND m.mov_anulada = 0 AND m.timestamp BETWEEN '{0} 00:00' AND '{1} 23:59') " +
                               "ORDER BY fecha", fecha1_f, fecha2_f)
        Else
            SQL = String.Format("(SELECT CONVERT(m.mov_fecha, CHAR) AS fecha, m.mov_concepto as concepto, m.mov_cuentaDebe as cuenta, m.mov_total as monto, m.mov_obs as observaciones, m.mov_tipo as tipo " +
                               "FROM movimientos as m " +
                               "WHERE (m.mov_tipo = 2 OR m.mov_tipo = 3) AND m.mov_anulada = 0 AND m.timestamp BETWEEN '{0}' AND '{1}')" +
                               "ORDER BY fecha", fecha1_f, fecha2_f)
        End If
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Detalles"

            'DS = corregirvizualizacion(DS, tipo)
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

    'Private Function corregirvizualizacion(DS As DataSet, tipo As Integer)

    '        If tipo = 1 Then
    '            For Each dr As DataRow In DS.Tables(0).Rows
    '    'Si la cuenta es tipo1, se corregen los montos a visualizar
    '               If dr("tipo") = 0 Or dr("tipo") = 3 Then
    '                   dr("monto") = dr("monto") * -1
    '               End If
    '           Next
    '       End If
    '       Return DS
    '  End Function

    Private Function corregirvizualizacion(DS As DataSet)

        For Each dr As DataRow In DS.Tables(0).Rows
            'Si la cuenta es tipo1, se corregen los montos a visualizar
            If dr("tipo") = 3 Then
                dr("monto") = dr("monto") * -1
            End If
        Next
        Return DS
    End Function
End Class