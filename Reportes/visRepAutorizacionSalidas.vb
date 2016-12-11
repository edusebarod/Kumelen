Public Class visRepAutorizacionSalidas
    Public alumno As String
    Public objrep As New rptAutorizaciónSalidas

    Private Sub visRepAutorizacionSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objrep.SetParameterValue(0, Alumno)
        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.Refresh()
    End Sub

End Class