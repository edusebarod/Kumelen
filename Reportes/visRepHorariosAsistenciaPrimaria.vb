Public Class visRepHorariosAsistenciaPrimario
    Public alumno As String
    Public sala As String
    Public turno As String
    Public dni As String
    Public horario As String
    Public objrep As New rptHorariosAsistenciaPrimario

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        objrep.SetParameterValue(0, alumno)
        objrep.SetParameterValue(1, sala)
        objrep.SetParameterValue(2, turno)
        objrep.SetParameterValue(3, dni)
        objrep.SetParameterValue(4, horario)
        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.Refresh()
    End Sub
End Class