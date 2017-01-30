Public Class frmLegajos
    Public repoAlu As New RepoAlumno
    Public DS As DataSet
    Public idAlumno As Integer
    Public facturar As Boolean
    Public intereses As Boolean
    Public db As Boolean
    'Public flag As Boolean 'bandera up, ya se cargaron las devengaciones. Bandera down, no se cargaron las devengaciones

    Private Sub frmDevengacionesD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)

        DS = repoAlu.Alumnos()
        dgLegajos.DataSource = DS.Tables(0)
        corregirVisualizacion()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        visRepDeudaAlumno.idalumno = idAlumno
        visRepDeudaAlumno.MdiParent = frmMain
        visRepDeudaAlumno.intereses = intereses
        visRepDeudaAlumno.bd = db
        visRepDeudaAlumno.Show()
    End Sub

    Sub corregirVisualizacion()
        'según la bandera se carga la lista de devengaciones no canceladas
        For Each Row As DataGridViewRow In dgLegajos.Rows
            If Row.Cells(31).Value = 1 Then
                Row.Cells(31).Value = "Si"
            ElseIf Row.Cells(31).Value = 0 Then
                Row.Cells(31).Value = "No"
            End If
            If Row.Cells(32).Value = 1 Then
                Row.Cells(32).Value = "Si"
            ElseIf Row.Cells(32).Value = 0 Then
                Row.Cells(32).Value = "No"
            End If
            If Row.Cells(33).Value = 1 Then
                Row.Cells(33).Value = "Si"
            ElseIf Row.Cells(33).Value = 0 Then
                Row.Cells(33).Value = "No"
            End If
            If Row.Cells(34).Value = 1 Then
                Row.Cells(34).Value = "Si"
            ElseIf Row.Cells(34).Value = 0 Then
                Row.Cells(34).Value = "No"
            End If
            If Row.Cells(35).Value = 1 Then
                Row.Cells(35).Value = "Si"
            ElseIf Row.Cells(35).Value = 0 Then
                Row.Cells(35).Value = "No"
            End If
            If Row.Cells(36).Value = 1 Then
                Row.Cells(36).Value = "Si"
            ElseIf Row.Cells(36).Value = 0 Then
                Row.Cells(36).Value = "No"
            End If
            If Row.Cells(37).Value = 1 Then
                Row.Cells(37).Value = "Si"
            ElseIf Row.Cells(37).Value = 0 Then
                Row.Cells(37).Value = "No"
            End If
            If Row.Cells(38).Value = 1 Then
                Row.Cells(38).Value = "Si"
            ElseIf Row.Cells(38).Value = 0 Then
                Row.Cells(38).Value = "No"
            End If
            If Row.Cells(39).Value = 1 Then
                Row.Cells(39).Value = "Si"
            ElseIf Row.Cells(39).Value = 0 Then
                Row.Cells(39).Value = "No"
            End If
            If Row.Cells(40).Value = 1 Then
                Row.Cells(40).Value = "Si"
            ElseIf Row.Cells(40).Value = 0 Then
                Row.Cells(40).Value = "No"
            End If
        Next
        dgLegajos.Refresh()
    End Sub
End Class