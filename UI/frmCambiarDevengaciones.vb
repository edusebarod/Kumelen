Public Class frmCambiarDevengaciones
    Public repoDeveng As New RepoDevengación
    Public alu As New Alumno
    Public repoAlumno As New RepoAlumno
    Public DS As DataSet
    Public idAlumno As Integer
    Public bd As Boolean



    Private Sub frmAnularDevengacionesNoCanceladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'se carga la lista de facturas
        DS = repoDeveng.Devengaciones_NoAnuladas_Alumno(idAlumno, bd)

        dgDevengaciones.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        dgDevengaciones.Columns(0).HeaderText = "ID Devengación"
        dgDevengaciones.Columns(1).HeaderText = "Fecha"
        dgDevengaciones.Columns(2).HeaderText = "Alumno"
        dgDevengaciones.Columns(2).Width = 200
        dgDevengaciones.Columns(3).HeaderText = "DNI"
        dgDevengaciones.Columns(4).HeaderText = "Total"
        dgDevengaciones.Columns(5).HeaderText = "Vencimiento 1"
        dgDevengaciones.Columns(6).HeaderText = "Vencimiento 2"
        dgDevengaciones.Columns(7).HeaderText = "Vencimiento 3"

        'configuracion de los parametros del reporte, si se estan viendo todas las devengaciones no canceladas 
        'esta linea no tiene funcionalidad
        repoAlumno.Traer_X_ID_activo(idAlumno, alu, bd)
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDevengaciones.CellDoubleClick
        Dim dsDevengacion As DataSet
        Dim dsDetalles As DataSet
        'si idalumno = 0, entonces se estab viendo todas las devengaciones no canceladas y alu está vacío
        'If idAlumno = 0 Then
        'repoAlumno.Traer_X_DNI(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value, alu, bd)
        'End If
        'repoDeveng.Anular_Devengacion(Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(0).Value), bd)
        'MsgBox(Cts.msgDevengacionAnulada)
        'Me.Close()

        'se resupera la devengacion con su detalle
        dsDevengacion = repoDeveng.DevengacionXid(Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(0).Value), bd)
        dsDetalles = repoDeveng.Detalles(Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(0).Value), bd)

        'se carga la devengación y el datalle en el formulario de Cambio de devengación
        frmCambioDevengacionesVia2.txtApellido.Text = dsDevengacion.Tables(0).Rows(0).ItemArray("")


    End Sub

End Class