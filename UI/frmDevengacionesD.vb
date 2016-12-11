Public Class frmDevengacionesD
    Public repoDev As New RepoDevengación
    Public DS As DataSet
    Public idAlumno As Integer
    Public facturar As Boolean
    Public intereses As Boolean
    Public db As Boolean
    'Public flag As Boolean 'bandera up, ya se cargaron las devengaciones. Bandera down, no se cargaron las devengaciones

    Private Sub frmDevengacionesD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)

        'según la bandera se carga la lista de devengaciones no canceladas
        'If flag Then
        DS = repoDev.Devengaciones_NoCanceladas_Alumno(idAlumno, db)
        dgDevengaciones.DataSource = DS.Tables(0)
        'Else
        'For Each Row As DataGridViewRow In dgDevengaciones.Rows
        ' If Row.Cells(1).Value = True Then
        ' dgDevengaciones.CurrentCell = Nothing
        ' dgDevengaciones.Rows(Row.Index).Visible = False
        'End If
        '   Next
        'End If

        'configuracion de la tabla que se muestra
        dgDevengaciones.Columns(0).HeaderText = "Concepto"
        dgDevengaciones.Columns(1).HeaderText = "Observaciones"
        dgDevengaciones.Columns(2).HeaderText = "Monto"
        dgDevengaciones.Columns(3).HeaderText = "ID Devengacion"
        dgDevengaciones.Columns(4).HeaderText = "ID Detalle"
        dgDevengaciones.Columns(4).Visible = False
        dgDevengaciones.Columns(5).HeaderText = "Fecha"
        dgDevengaciones.Columns(6).HeaderText = "Alumno"
        dgDevengaciones.Columns(7).HeaderText = "DNI"
        dgDevengaciones.Columns(8).HeaderText = "Vencimiento 1"
        dgDevengaciones.Columns(9).HeaderText = "Vencimiento 2"
        dgDevengaciones.Columns(10).HeaderText = "Vencimiento 3"

        'se agrega un columna con checkbox
        Dim chk As New DataGridViewCheckBoxColumn()
        dgDevengaciones.Columns.Add(chk)
        dgDevengaciones.Columns(11).HeaderText = "Seleccionar"
        dgDevengaciones.Columns(11).DisplayIndex = 0 ' Es para que la columna sea la primera en la grilla

        'se agrega un columna no visible con un booleano
        Dim chk2 As New DataGridViewCheckBoxColumn()
        dgDevengaciones.Columns.Add(chk2)
        dgDevengaciones.Columns(12).HeaderText = "usado"
        dgDevengaciones.Columns(12).Visible = False

        dgDevengaciones.Refresh()
    End Sub

    'Agrega detalles a la facturación
    Private Sub dgDevengaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDevengaciones.CellDoubleClick
        Dim dev_id As Integer
        Dim dde_id As Integer
        Dim serv_nombre As String
        Dim dde_monto As Double
        Dim dde_fecha As Date
        Dim venc1, venc2, venc3 As String
        'Dim temp As Integer

        Dim monto As Decimal

        If facturar Then
            
            dev_id = dgDevengaciones.Rows(e.RowIndex).Cells(5).Value
            dde_id = dgDevengaciones.Rows(e.RowIndex).Cells(6).Value
            serv_nombre = dgDevengaciones.Rows(e.RowIndex).Cells(2).Value.ToString
            dde_monto = dgDevengaciones.Rows(e.RowIndex).Cells(4).Value
            dde_fecha = dgDevengaciones.Rows(e.RowIndex).Cells(7).Value.ToString
            venc1 = dgDevengaciones.Rows(e.RowIndex).Cells(10).Value.ToString
            venc2 = dgDevengaciones.Rows(e.RowIndex).Cells(11).Value.ToString
            venc3 = dgDevengaciones.Rows(e.RowIndex).Cells(12).Value.ToString
            dgDevengaciones.Rows(e.RowIndex).Cells(1).Value = True
            'temp = dgDevengaciones.Rows(e.RowIndex).Index
            'dgDevengaciones.CurrentCell = Nothing
            'dgDevengaciones.Rows.RemoveAt(temp)
            'dgDevengaciones.Rows(temp).Visible = False

            dgDevengaciones.Refresh()
            'Me.Refresh()

            If db Then
                frmFacturacionvia1.agregarDetalles(dev_id, dde_id, serv_nombre, Math.Round(dde_monto, 2))
                If intereses Then
                    monto = calcular_intereses(dde_monto, dde_fecha, venc1, venc2, venc3)
                    If monto > 0 Then
                        frmFacturacionvia1.agregarDetalles(0, 0, "Intereses por mora", Math.Round(monto, 2))
                    End If
                End If
            Else
                frmFacturacionvia2.agregarDetalles(dev_id, dde_id, serv_nombre, Math.Round(dde_monto, 2))
                If intereses Then
                    monto = calcular_intereses(dde_monto, dde_fecha, venc1, venc2, venc3)
                    If monto > 0 Then
                        frmFacturacionvia2.agregarDetalles(0, 0, "Intereses por mora", Math.Round(monto, 2))
                    End If
                End If
            End If
            Refresh2()
            Me.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        visRepDeudaAlumno.idalumno = idAlumno
        visRepDeudaAlumno.MdiParent = frmMain
        visRepDeudaAlumno.intereses = intereses
        visRepDeudaAlumno.bd = db
        visRepDeudaAlumno.Show()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim DS As New DataSet
        Dim dev_id As Integer
        Dim dde_id As Integer
        Dim serv_nombre As String
        Dim dde_monto As Double
        Dim dde_fecha As Date
        Dim venc1, venc2, venc3 As String

        Dim monto As Decimal

        For Each Row As DataGridViewRow In dgDevengaciones.Rows
            If Convert.ToBoolean(Row.Cells(0).Value) Then
                If facturar Then
                    dev_id = Row.Cells(5).Value
                    dde_id = Row.Cells(6).Value
                    serv_nombre = Row.Cells(2).Value.ToString
                    dde_monto = Row.Cells(4).Value
                    dde_fecha = Row.Cells(7).Value.ToString
                    venc1 = Row.Cells(10).Value.ToString
                    venc2 = Row.Cells(11).Value.ToString
                    venc3 = Row.Cells(12).Value.ToString
                    dgDevengaciones.Rows(Row.Index).Cells(1).Value = True
                    dgDevengaciones.Refresh()
                    'Me.Refresh()

                    If db Then
                        frmFacturacionvia1.agregarDetalles(dev_id, dde_id, serv_nombre, Math.Round(dde_monto, 2))
                        If intereses Then
                            monto = calcular_intereses(dde_monto, dde_fecha, venc1, venc2, venc3)
                            If monto > 0 Then
                                frmFacturacionvia1.agregarDetalles(0, 0, "Intereses por mora", Math.Round(monto, 2))
                            End If
                        End If
                    Else
                        frmFacturacionvia2.agregarDetalles(dev_id, dde_id, serv_nombre, Math.Round(dde_monto, 2))
                        If intereses Then
                            monto = calcular_intereses(dde_monto, dde_fecha, venc1, venc2, venc3)
                            If monto > 0 Then
                                frmFacturacionvia2.agregarDetalles(0, 0, "Intereses por mora", Math.Round(monto, 2))
                            End If
                        End If
                    End If
                End If

            End If
        Next
        Refresh2()
        Me.Visible = False
    End Sub

    Sub Refresh2()
        'según la bandera se carga la lista de devengaciones no canceladas
        Dim flag As Boolean = False
        While Not flag
            If dgDevengaciones.Rows.Count = 0 Then
                flag = True
            Else
                For Each Row As DataGridViewRow In dgDevengaciones.Rows
                    If Row.Cells(1).Value = True Then
                        dgDevengaciones.CurrentCell = Nothing
                        dgDevengaciones.Rows.RemoveAt(Row.Index)
                        Exit For
                        'dgDevengaciones.Rows(Row.Index).Visible = False
                    End If
                    If Row.Index = dgDevengaciones.Rows.Count - 1 Or dgDevengaciones.Rows.Count = 0 Then
                        flag = True
                    End If
                Next
            End If
        End While
        dgDevengaciones.Refresh()
    End Sub
End Class