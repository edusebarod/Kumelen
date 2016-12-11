Public Class visRepCompromisoPrimario
    Public alumno As String
    Public sala As String
    Public turno As String
    Public objrep As New rptCompromisoPrimario

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        objrep.SetParameterValue(0, alumno)
        objrep.SetParameterValue(1, turno)
        objrep.SetParameterValue(2, sala)
        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub visRepCompromiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class