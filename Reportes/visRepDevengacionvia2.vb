Public Class visRepDevengacionvia2
    Public iddevengacion As Integer
    Public alumno As String
    Public sala As String
    Public turno As String
    Public nroDev As String
    Public beca As String
    Public objrep As New rptDevengacionvia2
    Public xsala As Boolean 'si es una devengacion por sala, no se previsualiza
    Public bd As Boolean
    Public cantVencimientos As Integer
    Public mes As String

    Private Sub devengacion_Load(sender As Object, e As EventArgs) Handles devengacion.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM devengaciones WHERE dev_id = {0}; SELECT * FROM devengacionesdetalles WHERE dev_id = {1}", iddevengacion, iddevengacion)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim fecha As String
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            DS.Tables(0).TableName = "devengaciones"
            DS.Tables(1).TableName = "devengacionesdetalles"
            fecha = DS.Tables(0).Rows(0).Item(6).ToString

            objrep.SetDataSource(DS)

            objrep.SetParameterValue(0, alumno)
            objrep.SetParameterValue(1, sala)
            objrep.SetParameterValue(2, turno)
            objrep.SetParameterValue(3, nroDev)
            objrep.SetParameterValue(4, beca)
            objrep.SetParameterValue(5, fecha)
            objrep.SetParameterValue(6, mes)

            If xsala Then
                objrep.PrintToPrinter(1, False, 0, 0)
            Else
                devengacion.ReportSource = objrep
                devengacion.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class