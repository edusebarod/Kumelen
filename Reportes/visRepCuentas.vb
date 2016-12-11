Public Class visRepCuentas
    Public via As String
    Public bd As Boolean
    Public objrep As New rptCuentas
    Public sucursal As String

    Private Sub visRepCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = "SELECT cue_codigo, cue_nombre, cue_activa, cue_devengaciones, cue_facturaciones, cue_pagosEgreso, cue_pagosGasto FROM cuentas"
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()
            DS.Tables(0).TableName = "cuentas"
            objrep.SetDataSource(DS)
            objrep.SetParameterValue(0, via)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class