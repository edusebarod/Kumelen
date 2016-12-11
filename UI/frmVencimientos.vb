Public Class frmVencimientos
    Public v1 As String
    Public v2 As String
    Public v3 As String

    Private Sub frmVencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repo = New RepoVencimiento
        repo.traerVencimientos()
        If v1 = "00/00/0000" Then
            txtVencimiento1.Checked = False
        Else
            txtVencimiento1.Text = v1
            txtVencimiento1.Checked = True
        End If
        If v2 = "00/00/0000" Then
            txtVencimiento2.Checked = False
        Else
            txtVencimiento2.Text = v2
            txtVencimiento2.Checked = True
        End If

        If v3 = "00/00/0000" Then
            txtVencimiento3.Checked = False
        Else
            txtVencimiento3.Text = v3
            txtVencimiento3.Checked = True
        End If

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Validar() Then
            Dim repo = New RepoVencimiento
            v1 = txtVencimiento1.Value.ToString("yyyy-MM-dd")
            v2 = txtVencimiento2.Value.ToString("yyyy-MM-dd")
            v3 = txtVencimiento3.Value.ToString("yyyy-MM-dd")
            repo.Editar(v1, v2, v3)
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            LimpiarControles(Me)
            cmdSalir.PerformClick()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtVencimiento1.Text = "" Then
            ColorearValidacion(True, lblVencimiento1)
            B = False
        ElseIf txtvencimiento2.Text = "" Then
            ColorearValidacion(True, lblvencimiento2)
            B = False
        ElseIf txtvencimiento3.Text = "" Then
            ColorearValidacion(True, lblvencimiento3)
            B = False
        End If
        Return B
    End Function


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub
End Class