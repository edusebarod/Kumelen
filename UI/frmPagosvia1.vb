Public Class frmPagosvia1
    Public pago As Pago
    Public Cta As New Cuenta
    Public repoPago As New RepoPago
    'Public repoFact As New RepoFacturacion
    Public DS As DataSet
    Public DS2 As DataSet
    Public proveedor As String
    Public proveedor_id As Integer
    Public sucursal As String

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtProveedor)
        EnableCmd(False, btnPagar)
        CargarCuentas()
        chbxCheque.Enabled = False
        chbxDebito.Enabled = False
        chbxTransferencia.Enabled = False
        chbxInterbanking.Enabled = False
        txtBanco.Enabled = False
        txtNroCheque.Enabled = False
        txtLugar.Enabled = False
        txtVencimiento.Enabled = False
    End Sub

    Private Sub CargarCuentas()
        DS = repoPago.CuentasGasto(True)
        ' asignar el DataSource al combobox
        cbxCtaGasto.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaGasto.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

        DS2 = repoPago.CuentasEgreso(True)
        ' asignar el DataSource al combobox
        cbxCtaEgreso.DataSource = DS2.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaEgreso.DisplayMember = DS2.Tables(0).Columns(1).Caption.ToString
    End Sub


    Private Sub btnBuscaProv_Click(sender As Object, e As EventArgs) Handles btnBuscaProv.Click
        If txtProveedor.Text <> "" Then
            Dim CuerpoSelect As String = "id, id, razon_social, razon_social"
            id = 0
            FormatoBusqueda("datosnegocio", CuerpoSelect, "razon_social", Trim(txtProveedor.Text), True, "id", "razon_social", id)
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
            repoPago.Pagar(proveedor_id, txtMonto.Text, txtNroComprobante.Text, txtObservaciones.Text, txtConcepto.Text, cbxCtaGasto.Text, cbxCtaEgreso.Text, txtFecha.Value, tipomovbco, txtBanco.Text, txtNroCheque.Text, txtLugar.Text, txtVencimiento.Text, True)
            LimpiarControles(Me)
        End If
    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
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
            frmDatosNegocio.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            frmDatosNegocio.MdiParent = frmMainKSC
        End If
        frmDatosNegocio.Show()
    End Sub

    Private Sub cbxCtaEgreso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCtaEgreso.SelectedValueChanged
        If InStr(cbxCtaEgreso.Text, "Banco") Then
            chbxCheque.Enabled = True
            chbxDebito.Enabled = True
            chbxTransferencia.Enabled = True
        Else
            chbxCheque.Enabled = False
            chbxDebito.Enabled = False
            chbxTransferencia.Enabled = False
        End If
    End Sub

    Private Sub chbxCheque_CheckedChanged(sender As Object, e As EventArgs) Handles chbxCheque.CheckedChanged
        If chbxCheque.Checked Then
            chbxDebito.Checked = False
            chbxTransferencia.Checked = False
            txtBanco.Enabled = True
            txtNroCheque.Enabled = True
            txtLugar.Enabled = True
            txtVencimiento.Enabled = True
        End If
    End Sub

    Private Sub chbxTransferencia_CheckedChanged(sender As Object, e As EventArgs) Handles chbxTransferencia.CheckedChanged
        If chbxTransferencia.Checked Then
            chbxDebito.Checked = False
            chbxCheque.Checked = False
            txtBanco.Text = ""
            txtBanco.Enabled = False
            txtNroCheque.Text = ""
            txtNroCheque.Enabled = False
            txtLugar.Text = ""
            txtLugar.Enabled = False
            txtVencimiento.Checked = False
            txtVencimiento.Enabled = False
        End If
    End Sub

    Private Sub chbxDebito_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDebito.CheckedChanged
        If chbxDebito.Checked Then
            chbxTransferencia.Checked = False
            chbxCheque.Checked = False
            txtBanco.Text = ""
            txtBanco.Enabled = False
            txtNroCheque.Text = ""
            txtNroCheque.Enabled = False
            txtLugar.Text = ""
            txtLugar.Enabled = False
            txtVencimiento.Checked = False
            txtVencimiento.Enabled = False
        End If
    End Sub
End Class