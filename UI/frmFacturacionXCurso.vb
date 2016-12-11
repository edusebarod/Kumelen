Public Class frmFacturacionXCurso
    Public Fact As New Facturacion
    Public Dev As New Devengacion
    Public repoFact As New RepoFacturacion
    Public repoDeveng As New RepoDevengación
    Public sucursal As String
    Private DS As New DataSet

    Private Sub frmAlumnosXCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCursos(cbxCurso)
        CargarCuentas()
        CargarServicios()
    End Sub

    Private Sub CargarServicios()
        DS = repoDeveng.Servicios()
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If validar() Then
            frmFacturacionMasiva.db = True
            frmFacturacionMasiva.sala = cbxCurso.SelectedValue
            frmFacturacionMasiva.turno = cbxTurno.Text
            frmFacturacionMasiva.cuenta = cbxCuenta.Text
            frmFacturacionMasiva.ptoVenta = cbxPtoVta.Text
            frmFacturacionMasiva.servicio = cbxServicio.Text
            frmFacturacionMasiva.vencimiento = txtVencimiento1.Text
            frmFacturacionMasiva.encargado = txtEncargado.Text
            frmFacturacionMasiva.observaciones = txtObservaciones.Text
            If sucursal = "ZOO" Then
                frmFacturacionMasiva.MdiParent = frmMain
            ElseIf sucursal = "KSC" Then
                frmFacturacionMasiva.MdiParent = frmMainKSC
            End If
            frmFacturacionMasiva.Show()
            Me.Dispose()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub CargarCuentas()
        DS = repoFact.Cuentas
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Function validar() As Boolean
        Dim B As Boolean = True

        If cbxCurso.Text = "" Then
            ColorearValidacion(True, lblSala)
            B = False
        ElseIf cbxCuenta.Text = "" Then
            ColorearValidacion(True, lblCuenta)
            B = False
        ElseIf cbxTurno.Text = "" Then
            ColorearValidacion(True, lblTurno)
            B = False
        ElseIf cbxServicio.Text = "" Then
            ColorearValidacion(True, lblServicio)
            B = False
        ElseIf cbxPtoVta.Text = "" Then
            ColorearValidacion(True, lblPtoVta)
            B = False
            'ElseIf txtEncargado.Text = "" Then
            '    ColorearValidacion(True, lblEncargado)
            '    B = False
        ElseIf Not txtVencimiento1.Checked Then
            ColorearValidacion(True, lblVencimiento1)
            B = False
        End If

        Return B
    End Function
End Class