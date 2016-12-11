Public Class VisRepAutorizacionImagenes
    Public alumno As String
    Public objrep As New rptAutorizaciónImagenes

    Private Sub VisRepAutorizacionImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objrep.SetParameterValue(0, alumno)
        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.Refresh()
    End Sub
End Class