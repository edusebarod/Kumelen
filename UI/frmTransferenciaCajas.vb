Public Class FrmTransferenciaCajas
    Public pago As Pago
    Public Cta As New Cuenta
    Public repotransf As New RepoTransferencias
    'Public repoFact As New RepoFacturacion
    Public DS As DataSet
    Public DS2 As DataSet

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        EnableCmd(False, btnPagar)
        CargarCuentas()
    End Sub

    Private Sub CargarCuentas()
        DS = repotransf.CuentasDestino(True)
        ' asignar el DataSource al combobox
        cbxCtaOrigen.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaOrigen.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

        DS2 = repotransf.CuentasOrigen(True)
        ' asignar el DataSource al combobox
        cbxCtaDestino.DataSource = DS2.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCtaDestino.DisplayMember = DS2.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        'se transfiere
        If validar() Then
            repotransf.Transferir(txtMonto.Text, txtNroComprobante.Text, txtObservaciones.Text, txtConcepto.Text, cbxCtaOrigen.Text, "", cbxCtaDestino.Text, "", txtFecha.Value)
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

    Private Function validar() As Boolean
        Dim B As Boolean = True

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
        If Not (chbxVia1Destino.Checked) Or Not (chbxVia2Destino.Checked) Then
            'ColorearValidacion(True, chbxVia1Destino.)
            'ColorearValidacion()
            B = False
        End If
        If Not (chbxVia1Origen.Checked) Or Not (chbxVia2Origen.Checked) Then
            'ColorearValidacion(True, chbxVia1Destino.)
            'ColorearValidacion()
            B = False
        End If
        Return B
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        frmDatosNegocio.MdiParent = frmMain
        frmDatosNegocio.Show()
    End Sub
End Class