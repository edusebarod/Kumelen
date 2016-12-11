Public Class frmFacturacionMasiva
    Public db As Boolean
    Public sala As String
    Public turno As String
    Public cuenta As String
    Public servicio As String
    Public ptoVenta As String
    Public vencimiento As String
    Public encargado As String
    Public observaciones As String
    Private repoalum As New RepoAlumno

    Private Sub frmDevengacionesD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT CONCAT(p.per_apellido, ', ', p.per_nombre) as Alumno, p.per_dni AS DNI, a.alu_descuento AS Beca, a.per_id as id FROM personas as p, alumnos as a WHERE a.per_id = p.per_id AND a.alu_curso LIKE '{0}' AND a.alu_turno LIKE '{1}' AND a.alu_activo = 1 ORDER BY Alumno", sala, turno)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim salaNombre As String

        ColorearControles(Me)
        ColorearFRM(Me)
        salaNombre = traersala(sala)
        lbl_sala.Text = salaNombre
        lbl_turno.Text = turno

        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)

            ' Creamos la nueva columna
            '
            Dim columna As New DataGridViewCheckBoxColumn
            With columna
                .Name = "Facturar"
                .HeaderText = "Facturar"
            End With

            ' Añadimos la columna la cual aparecerá en la primera posición
            dgalumnos.DataSource = DS.Tables(0)
            dgalumnos.Columns.Insert(0, columna)
            dgalumnos.Columns(0).Width = 50
            dgalumnos.Columns(1).Width = 250
            dgalumnos.Columns(3).Width = 50
            dgalumnos.Columns(4).Width = 50

            'Dim ind As Integer = 0
            'Dim cant As Integer = 0
            'cant = dgalumnos.Rows.Count
            'For i As Integer = 0 To cant - 1
            'dgalumnos.Rows(i).Cells(4).Value = 1
            'Next
            'For Each row As DataGridViewRow In dgalumnos.Rows
            'row.Cells(3).Value = CheckState.Checked
            'dgalumnos.Rows(ind) = row
            'Next
            'MsgBox(dgalumnos.Rows(0).Cells(4).Value.ToString)
            Me.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'visRepDeudaAlumno.idalumno = idAlumno
        'visRepDeudaAlumno.MdiParent = frmMain
        'visRepDeudaAlumno.intereses = intereses
        'visRepDeudaAlumno.bd = db
        'visRepDeudaAlumno.Show()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim repoFact As New RepoFacturacion
        Dim dev_id As Integer
        Dim total As Decimal
        Dim ds As New DataSet
        Dim factura As Integer

        Dim conexion As New cBaseDatos
        Dim SQL As String = ""
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS1 As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim fecha As String
        'Dim objrep As New rptFacturacion1
        Dim objrep As New rptDuplicadosvia1
        Dim printername As String = ""
        Dim printDialog1 = New PrintDialog()
        Dim result As Integer

        'El usuario elige en que impresora imprimir
        result = printDialog1.ShowDialog()

        If result = DialogResult.OK Then
            printername = printDialog1.PrinterSettings.PrinterName
        End If

        EnableCmd(False, btnFacturar)

        'Por cada alumno marcado, se busca la devengaciób correspondiente y se factura
        For Each row As DataGridViewRow In dgalumnos.Rows
            If row.Cells(0).Value Then
                ds = devAlu(row.Cells(4).Value, servicio, vencimiento)
                If ds.Tables(0).Rows.Count > 0 Then
                    dev_id = ds.Tables(0).Rows(0).Item(0)
                    total = ds.Tables(0).Rows(0).Item(1)
                    If encargado = "" Then
                        encargado = repoalum.tutor(row.Cells(4).Value)
                    End If
                    factura = repoFact.FacturarAlu(row.Cells(4).Value, dev_id, encargado, cuenta, servicio, ptoVenta, total, observaciones)

                    Try
                        conexion.AbrirConexion(db)
                        'Se busca la facturación realizada, se carga el reporte y se lo manda a imprimir directamente
                        SQL = String.Format("SELECT * FROM movimientos as m WHERE m.mov_id = {0}; SELECT * FROM movimientosdetalles as md WHERE md.mov_id = {1}", factura, factura)
                        DA = conexion.EjecutarConsulta(SQL)
                        DA.Fill(DS1)
                        conexion.CerrarConexion()

                        DS1.Tables(0).TableName = "movimientos"
                        DS1.Tables(1).TableName = "movimientosdetalles"
                        fecha = DS1.Tables(0).Rows(0).ItemArray(4).ToString
                        objrep.SetDataSource(DS1)

                        objrep.SetParameterValue(0, row.Cells(1).Value.ToString)
                        objrep.SetParameterValue(1, sala)
                        objrep.SetParameterValue(2, fecha)

                        objrep.PrintOptions.PrinterName = printername
                        objrep.PrintToPrinter(1, False, 0, 0)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    DA.Dispose()
                    DS1.Tables.RemoveAt(1)
                    DS1.Tables.RemoveAt(0)
                    DS1.Clear()
                    DS1.Dispose()
                    ds.Tables.RemoveAt(0)
                    ds.Clear()
                    ds.Dispose()
                End If
            End If
        Next
        EnableCmd(True, btnFacturar)
        MsgBox("Se realizaron las facturas con éxito")
        Me.Dispose()
    End Sub

    Private Function devAlu(alu_id As Integer, servicio As String, vencimiento As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim con As New cBaseDatos
        Dim da As New MySqlClient.MySqlDataAdapter
        con.AbrirConexion()
        sql = String.Format("SELECT d.dev_id, d.dev_total FROM `devengaciones` as d, devengacionesdetalles as dd WHERE d.dev_id = dd.dev_id AND d.per_id = {0} AND dd.serv_nombre = '{1}' AND dd.dde_cancelada = 0 AND d.dev_vencimiento1 = '{2}'", alu_id, servicio, vencimiento)
        Try
            da = con.EjecutarConsulta(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        con.CerrarConexion()
        da.Fill(ds)

        Return ds
    End Function
End Class