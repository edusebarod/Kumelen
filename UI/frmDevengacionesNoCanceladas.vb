Public Class frmDevengacionesNoCanceladas
    Public repoDeveng As New RepoDevengación
    Public alu As New Alumno
    Public repoAlumno As New RepoAlumno
    Public DS As DataSet
    Public idAlumno As Integer
    Public fecha1 As Date
    Public fecha2 As Date
    Public fecha As Boolean 'true: se cargaron fecha1 y fecha2 False: estan vacias
    Public NroDeveng As String
    Public todas As Boolean
    Public bd As Boolean
    Public cantVencimientos As Integer

    Private Sub frmDevengacionesNoCanceladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'se carga la lista de devengaciones
        If (idAlumno <> 0) Then
            DS = repoDeveng.Devengaciones_NoCanceladas(idAlumno, bd)
        ElseIf (fecha) Then
            Dim fecha1_f As String
            fecha1_f = fecha1.ToString("yyyy-MM-dd hh:mm:ss")
            Dim fecha2_f As String
            fecha2_f = fecha2.ToString("yyyy-MM-dd hh:mm:ss")
            DS = repoDeveng.Devengaciones_Fecha(fecha1_f, fecha2_f, bd)
        ElseIf (NroDeveng <> "") Then
            DS = repoDeveng.Devengaciones_NroDevengacion(NroDeveng, bd)
        ElseIf todas Then
            DS = repoDeveng.Devengaciones(bd)
        End If

        dgDevengaciones.DataSource = DS.Tables(0)

        'configuracion de la tabla que se muestra
        'dgDevengaciones.Columns(0).HeaderText = "ID Devengación"
        dgDevengaciones.Columns(0).HeaderText = "Concepto"
        dgDevengaciones.Columns(1).HeaderText = "Observaciones"
        dgDevengaciones.Columns(2).HeaderText = "Total"
        dgDevengaciones.Columns(3).HeaderText = "ID Devengación"
        dgDevengaciones.Columns(4).HeaderText = "Fecha"
        dgDevengaciones.Columns(5).HeaderText = "Mes"
        dgDevengaciones.Columns(6).HeaderText = "Alumno"
        dgDevengaciones.Columns(6).Width = 200
        dgDevengaciones.Columns(7).HeaderText = "DNI"
        dgDevengaciones.Columns(8).HeaderText = "Beca"
        dgDevengaciones.Columns(9).HeaderText = "Sala"
        'dgDevengaciones.Columns(6).HeaderText = "Total"
        'dgDevengaciones.Columns(5).HeaderText = "Concepto"
        dgDevengaciones.Columns(10).HeaderText = "Vencimiento 1"
        dgDevengaciones.Columns(11).HeaderText = "Vencimiento 2"
        dgDevengaciones.Columns(12).HeaderText = "Vencimiento 3"

        'configuracion de los parametros del reporte, si se estan viendo todas las devengaciones no canceladas 
        'esta linea no tiene funcionalidad
        'repoAlumno.Traer_X_ID_activo(idAlumno, alu, bd)
    End Sub

    Private Sub dgFacturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDevengaciones.CellDoubleClick
        'MsgBox(dgFacturas.Rows(e.RowIndex).Cells(0).Value
        Dim idDev As Integer
        Dim nroDev As String
        Dim fecha As String
        Dim DNI As Integer
        Dim mes As String

        idDev = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value)
        fecha = dgDevengaciones.Rows(e.RowIndex).Cells(4).Value.ToString
        DNI = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(7).Value)
        nroDev = idDev.ToString
        nroDev = nroDev.PadLeft(8, "0")
        mes = Convert.ToString(dgDevengaciones.Rows(e.RowIndex).Cells(5).Value)
        'si se estan viendo todas las devengaciones o en un rango de fechas, entonces alu está vacío
        'If todas Or fecha Then
        repoAlumno.Traer_X_DNI(DNI, alu, bd)
        ' End If
        If bd Then
            If cantVencimientos = 3 Then
                visRepDevengacion.iddevengacion = idDev
                visRepDevengacion.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacion.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacion.turno = alu.turno
                visRepDevengacion.nroDev = nroDev
                visRepDevengacion.codigo = generarCodBarra(alu.dni, idDev.ToString, fecha)
                visRepDevengacion.beca = alu.descuento.ToString
                visRepDevengacion.pagoElectronico = "0000" + alu.legajo.ToString
                visRepDevengacion.bd = bd
                visRepDevengacion.mes = mes
                visRepDevengacion.MdiParent = frmMain
                visRepDevengacion.Show()
            End If
            If cantVencimientos = 2 Then
                visRepDevengacion2v.iddevengacion = idDev
                visRepDevengacion2v.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacion2v.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacion2v.turno = alu.turno
                visRepDevengacion2v.nroDev = nroDev
                visRepDevengacion2v.codigo = generarCodBarra(alu.dni, idDev.ToString, fecha)
                visRepDevengacion2v.beca = alu.descuento.ToString
                visRepDevengacion2v.pagoElectronico = "0000" + alu.legajo.ToString
                visRepDevengacion2v.bd = bd
                visRepDevengacion2v.mes = mes
                visRepDevengacion2v.MdiParent = frmMain
                visRepDevengacion2v.Show()
            End If
            If cantVencimientos = 1 Then
                visRepDevengacion1v.iddevengacion = idDev
                visRepDevengacion1v.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacion1v.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacion1v.turno = alu.turno
                visRepDevengacion1v.nroDev = nroDev
                visRepDevengacion1v.codigo = generarCodBarra(alu.dni, idDev.ToString, fecha)
                visRepDevengacion1v.beca = alu.descuento.ToString
                visRepDevengacion1v.pagoElectronico = "0000" + alu.legajo.ToString
                visRepDevengacion1v.bd = bd
                visRepDevengacion1v.mes = mes
                visRepDevengacion1v.MdiParent = frmMain
                visRepDevengacion1v.Show()
            End If
            If cantVencimientos = 0 Then
                visRepDevengacionsv.iddevengacion = idDev
                visRepDevengacionsv.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacionsv.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacionsv.turno = alu.turno
                visRepDevengacionsv.nroDev = nroDev
                visRepDevengacionsv.codigo = generarCodBarra(alu.dni, idDev.ToString, fecha)
                visRepDevengacionsv.beca = alu.descuento.ToString
                visRepDevengacionsv.pagoElectronico = "0000" + alu.legajo.ToString
                visRepDevengacionsv.bd = bd
                visRepDevengacionsv.mes = mes
                visRepDevengacionsv.MdiParent = frmMain
                visRepDevengacionsv.Show()
            End If
        Else
            If cantVencimientos = 3 Then
                visRepDevengacionvia2.iddevengacion = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value)
                visRepDevengacionvia2.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacionvia2.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacionvia2.turno = alu.turno
                visRepDevengacionvia2.nroDev = nroDev
                visRepDevengacionvia2.beca = alu.descuento.ToString
                visRepDevengacionvia2.bd = bd
                visRepDevengacionvia2.mes = mes
                visRepDevengacionvia2.MdiParent = frmMain
                visRepDevengacionvia2.Show()
            End If
            If cantVencimientos = 2 Then
                visRepDevengacionvia22v.iddevengacion = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value)
                visRepDevengacionvia22v.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacionvia22v.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacionvia22v.turno = alu.turno
                visRepDevengacionvia22v.nroDev = nroDev
                visRepDevengacionvia22v.beca = alu.descuento.ToString
                visRepDevengacionvia22v.bd = bd
                visRepDevengacionvia22v.mes = mes
                visRepDevengacionvia22v.MdiParent = frmMain
                visRepDevengacionvia22v.Show()
            End If
            If cantVencimientos = 1 Then
                visRepDevengacionvia21v.iddevengacion = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value)
                visRepDevengacionvia21v.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacionvia21v.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacionvia21v.turno = alu.turno
                visRepDevengacionvia21v.nroDev = nroDev
                visRepDevengacionvia21v.beca = alu.descuento.ToString
                visRepDevengacionvia21v.bd = bd
                visRepDevengacionvia21v.mes = mes
                visRepDevengacionvia21v.MdiParent = frmMain
                visRepDevengacionvia21v.Show()
            End If
            If cantVencimientos = 0 Then
                visRepDevengacionvia2sv.iddevengacion = Convert.ToInt32(dgDevengaciones.Rows(e.RowIndex).Cells(3).Value)
                visRepDevengacionvia2sv.alumno = String.Format("{0}, {1}", alu.apellido, alu.nombre)
                visRepDevengacionvia2sv.sala = repoAlumno.Sala(alu.curso, bd)
                visRepDevengacionvia2sv.turno = alu.turno
                visRepDevengacionvia2sv.nroDev = nroDev
                visRepDevengacionvia2sv.beca = alu.descuento.ToString
                visRepDevengacionvia2sv.bd = bd
                visRepDevengacionvia2sv.mes = mes
                visRepDevengacionvia2sv.MdiParent = frmMain
                visRepDevengacionvia2sv.Show()
            End If
        End If
    End Sub
End Class