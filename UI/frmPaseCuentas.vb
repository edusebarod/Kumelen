Public Class frmPaseCuentas
    Private repoPase As New RepoPaseCuentas
    Private DS As DataSet
    Private DS2 As DataSet
    Public db As Boolean

    Private Sub frmPaseCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMonto.Text = "0"
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarCuentas()
    End Sub

    Private Sub CargarCuentas()
        'asignar memoria al date set y refenciarlos internamente
        DS = repoPase.Cuentas(db)
        DS2 = repoPase.Cuentas(db)

        ' Asignar el DataSource al combobox
        cbxCuentaEntrada.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuentaEntrada.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString

        ' Asignar el DataSource al combobox
        cbxCuentaSalida.DataSource = DS2.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuentaSalida.DisplayMember = DS2.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub txMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If InStr("0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        If validar() Then
            repoPase.Pase(cbxCuentaSalida.Text, cbxCuentaEntrada.Text, txtMonto.Text, txtConcepto.Text, txtObservaciones.Text, db)
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, Cts.msgTitulo)

            limpiarControles()

        End If
    End Sub

    Private Function validar() As Boolean
        Dim B As Boolean = True
        If cbxCuentaEntrada.Text = "" Then
            ColorearValidacion(True, lblCuentaEntrada)
            B = False
        End If
        If cbxCuentaSalida.Text = "" Then
            ColorearValidacion(True, lblCuentaSalida)
            B = False
        End If
        If txtMonto.Text = "" Or txtMonto.Text = "0" Then
            ColorearValidacion(True, lblMonto)
            B = False
        End If
        If txtObservaciones.Text = "" Then
            ColorearValidacion(True, lblObservaciones)
            B = False
        End If
        Return B
    End Function

    Private Sub limpiarControles()
        cbxCuentaEntrada.SelectedItem = Nothing
        cbxCuentaSalida.SelectedItem = Nothing
        txtMonto.Clear()
        txtObservaciones.Clear()
    End Sub

    'Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs) Handles txtConcepto.TextChanged
    '    If validar() Then
    ''        EnableCmd(True, btnRealizar)
    '    End If
    'End Sub

    'Private Sub cbxCuentaSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCuentaSalida.SelectedIndexChanged
    '   If validar() Then
    '      EnableCmd(True, btnRealizar)
    ' End If
    'End Sub

    'Private Sub cbxCuentaEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCuentaEntrada.SelectedIndexChanged
    '    If validar() Then
    '        EnableCmd(True, btnRealizar)
    '   End If
    'End Sub

    'Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
    '    If validar() Then
    '        EnableCmd(True, btnRealizar)
    '    End If
    'End Sub

    'Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged
    '   If validar() Then
    '       EnableCmd(True, btnRealizar)
    '   End If
    'End Sub
End Class