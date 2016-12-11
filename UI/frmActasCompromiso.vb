Public Class frmActasCompromiso
    Public repoAlumno As New RepoAlumno
    Public DS As DataSet
    Public sucursal As String
    
    Private Sub frmActasCompromiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'se carga la lista de devengaciones
        DS = repoAlumno.actasCompromiso

        dgAlumnos.DataSource = DS.Tables(0)

    End Sub

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        dgAlumnos.SelectAll()
        dgAlumnos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Clipboard.SetDataObject(dgAlumnos.GetClipboardContent())
    End Sub
End Class