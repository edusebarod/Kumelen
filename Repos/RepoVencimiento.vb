Imports System.Data.SqlClient
Imports System.Text

Public Class RepoVencimiento

    Public Function Editar(ByVal v1 As String, ByVal v2 As String, ByVal v3 As String) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE vencimientos SET vencimiento1 = '{0}', vencimiento2 = '{1}', vencimiento3 = '{2}' WHERE venc_id = 1",
                                          v1, v2, v3)
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion()
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            con.AbrirConexion(False)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub traerVencimientos()
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim v1 As String = ""
        Dim v2 As String = ""
        Dim v3 As String = ""

        'se obtien el primer vencimiento
        SQL = "SELECT vencimiento1 FROM vencimientos WHERE venc_id = 1"
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v1 = DS.Tables(0).Rows(0).ItemArray(0).ToString
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        'se obtien el segundo vencimiento
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()

        SQL = "SELECT vencimiento2 FROM vencimientos WHERE venc_id = 1"
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v2 = DS.Tables(0).Rows(0).ItemArray(0).ToString
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        'se obtien el tercer vencimiento
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()

        SQL = "SELECT vencimiento3 FROM vencimientos WHERE venc_id = 1"
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v3 = DS.Tables(0).Rows(0).ItemArray(0).ToString
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        frmVencimientos.v1 = v1
        frmVencimientos.v2 = v2
        frmVencimientos.v3 = v3

    End Sub
End Class
