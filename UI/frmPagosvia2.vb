Public Class frmPagosvia2
    Public Cta As New Cuenta
    'Public repoFact As New RepoFacturacion
    Public repoPago As New RepoPago
    Public DS As DataSet
    Public proveedor As String
    Public proveedor_id As Integer
    Public sucursal As String

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtProveedor)
        EnableCmd(False, btnPagar)
        CargarCuentas()
    End Sub

    Private Sub CargarCuentas()
        DS = repoPago.CuentasGasto(False)
        ' asignar el DataSource al combobox
        cbxCtaGasto.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaGasto.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

        DS2 = repoPago.CuentasEgreso(False)
        ' asignar el DataSource al combobox
        cbxCtaEgreso.DataSource = DS2.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaEgreso.DisplayMember = DS2.Tables(0).Columns(1).Caption.ToString
    End Sub


    Private Sub btnBuscaProv_Click(sender As Object, e As EventArgs) Handles btnBuscaProv.Click
        If txtProveedor.Text <> "" Then
            Dim CuerpoSelect As String = "id, id, razon_social, razon_social"
            id = 0
            FormatoBusqueda("datosnegocio", CuerpoSelect, "razon_social", Trim(txtProveedor.Text), False, "id", "razon_social", id)
            frmBusqueda.ShowDialog()
            proveedor_id = frmBusqueda.Codigo
            proveedor = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If proveedor_id <> 0 Then
                txtProveedor.Text = proveedor
                EnableCmd(True, btnPagar)
            Else
                txtProveedor.Select()
            End If
        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        Dim tipomovbco As String

        If chbxCheque.Checked Then
            tipomovbco = chbxCheque.Text
        ElseIf chbxDebito.Checked Then
            tipomovbco = chbxDebito.Text
        ElseIf chbxTransferencia.Checked Then
            tipomovbco = chbxTransferencia.Text
        Else
            tipomovbco = ""
        End If

        'se paga
        If validar() Then
            repoPago.Pagar(proveedor_id, txtMonto.Text, txtNroComprobante.Text, txtObservaciones.Text, txtConcepto.Text, cbxCtaGasto.Text, cbxCtaEgreso.Text, txtFecha.Value, tipomovbco, txtBanco.Text, txtNroCheque.Text, txtLugar.Text, txtVencimiento.Text, False)
            LimpiarControles(Me)
        End If

    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        ElseIf e.KeyChar = Chr(46) Then
            If InStr(txtMonto.Text, ".") <> 0 Then
                e.KeyChar = ""
            ElseIf txtMonto.Text = "" Then
                txtMonto.Text = "0."
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProveedor.KeyPress
        If txtProveedor.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnBuscaProv.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Function validar() As Boolean
        Dim B As Boolean = True
        If txtProveedor.Text = "" Then
            ColorearValidacion(True, lblProveedor)
            B = False
        End If
        If txtConcepto.Text = "" Then
            ColorearValidacion(True, lblConcepto)
            B = False
        End If
        If txtMonto.Text = "" Then
            ColorearValidacion(True, lblMonto)
            B = False
        End If
        If txtNroComprobante.Text = "" Then
            ColorearValidacion(True, lblNroComprobante)
            B = False
        End If
        If Not txtFecha.Checked Then
            ColorearValidacion(True, lbl_Fecha)
            B = False
        End If
        Return B
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If sucursal = "ZOO" Then
            frmDatosNegociovia2.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmDatosNegociovia2.MdiParent = frmMainKSC
        End If
        frmDatosNegociovia2.Show()
    End Sub
End Class