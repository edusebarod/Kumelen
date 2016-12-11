Public Class frmBuscarFEAFIP
    Public repoFact As New RepoFacturacion
    'Public DS As DataSet
    Public fecha1 As Date
    Public fecha2 As Date


    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btn_Fecha.Click
        Dim fecha1_f As String
        Dim fecha2_f As String

        fecha1 = txt_fecha.Value
        fecha2 = txt_y.Value
        fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
        fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
        'DS = repoFact.Facturas_Fecha_FEAFIP(fecha1_f, fecha2_f)
        
        'VisRepFEAFIP.ds = DS
        VisRepFEAFIP.fecha1 = fecha1_f
        VisRepFEAFIP.fecha2 = fecha2_f
        VisRepFEAFIP.MdiParent = frmMain
        VisRepFEAFIP.Show()
    End Sub
End Class