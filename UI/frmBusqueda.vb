Public Class frmBusqueda
    Public Buscar As String 'el texto que fue escrito
    Public Tabla As String 'la tabla donde quiero buscar
    Public SQL As String 'el sql que quiero traer
    Public TipoCon As Boolean
    Public ID As String
    Public Nombre As String
    Public Codigo As Integer

    Private Sub frmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.ColorearControles(Me)
        Util.ColorearFRM(Me)
        txtBuscar.Text = Buscar
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim repo As New Repo
        Dim Result As DataSet = repo.Traer_X_nombre(SQL, Trim(txtBuscar.Text), TipoCon)
        lstBuscar.DataSource = Result.Tables(0)
        lstBuscar.DisplayMember = Nombre
        lstBuscar.ValueMember = ID
    End Sub

    Private Sub lstBuscar_DoubleClick(sender As Object, e As EventArgs) Handles lstBuscar.DoubleClick
        cmdSelect.PerformClick()
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        If lstBuscar.Items.Count > 0 Then
            Codigo = lstBuscar.SelectedItem(lstBuscar.ValueMember)
            Nombre = lstBuscar.SelectedItem(3).ToString
            Me.Close()
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Codigo = 0
        Dispose()
    End Sub
End Class