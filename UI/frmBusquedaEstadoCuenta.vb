Public Class frmBusquedaEstadoCuenta
    Public repoFact As New RepoFacturacion
    Public bd As Boolean
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        'CargarCuentas()
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxCuenta.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnVer.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub CargarCuentas(tipo As Integer)
        DS = repoFact.Cuentas_Estado_Tipo(tipo)
        ' asignar el DataSource al combobox
        cbxCuenta.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuenta.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs)
        frmEstadoCuenta.cuenta = cbxCuenta.Text
        frmEstadoCuenta.bd = bd
        If sucursal = "ZOO" Then
            frmEstadoCuenta.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmEstadoCuenta.MdiParent = frmMainKSC
        End If
        frmEstadoCuenta.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        frmEstadoCuenta.cuenta = cbxCuenta.Text
        frmEstadoCuenta.tipo = cbx_tipo.SelectedIndex + 1
        frmEstadoCuenta.bd = bd
        frmEstadoCuenta.fecha1 = txt_fecha.Value
        frmEstadoCuenta.fecha2 = txt_y.Value
        frmEstadoCuenta.general = False
        If sucursal = "ZOO" Then
            frmEstadoCuenta.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmEstadoCuenta.MdiParent = frmMainKSC
        End If
        frmEstadoCuenta.Show()
    End Sub

    Private Sub cbx_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipo.SelectedIndexChanged
        CargarCuentas(cbx_tipo.SelectedIndex + 1)
    End Sub
End Class