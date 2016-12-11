Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoPaseCuentas

    'Devuelve el id y el nombre de las cuentas del plan de cuentas
    Public Function Cuentas(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas ORDER BY cue_nombre")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    Public Function Cuentas_Estado_Tipo(tipo As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_grupo = {0} ORDER BY cue_nombre", tipo)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Devuelve el id, el nombre y el precio de los servicios que brinda la escuela
    Public Function Servicios(Optional ByVal bd As Boolean = True) As DataSet
        'Esto iría en repoServicios
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_id, serv_nombre, serv_precio FROM servicios ORDER BY serv_nombre")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function Pase(ByVal cuentasalida As String, ByVal cuentaentrada As String, ByVal monto As Double, ByVal concepto As String, ByVal observaciones As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DS_dde As DataSet = New DataSet()
        Dim DS_temp As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA_dde As New MySqlClient.MySqlDataAdapter
        Dim DA_temp As New MySqlClient.MySqlDataAdapter
        Dim SQL, SQL2 As String
        Dim result, result1, result2 As Integer
        Dim repoServ As New RepoServicio

        con.AbrirConexion(bd)
        'se realizon dos movimientos, que suponen un pase entre cuentas
        SQL = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                                         0, "Movimiento entre cuentas", Cts.movPaseIn, DateTime.Now().ToString("yyyy/MM/dd").ToString, monto, "-", "-", observaciones, concepto, cuentaentrada, cuentaentrada)
        SQL2 = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                                         0, "Movimiento entre cuentas", Cts.movPaseOut, DateTime.Now().ToString("yyyy/MM/dd").ToString, monto, "-", "-", observaciones, concepto, cuentasalida, cuentasalida)
        Try
            result1 = con.EjecutarComando(SQL)
            result2 = con.EjecutarComando(SQL2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        If result1 = 1 And result2 = 1 Then
            result = 1
        Else
            result = 0
        End If
        con.CerrarConexion()
        Return result
    End Function


    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function FacturarAlu(ByVal alu As Integer, ByVal dev_id As Integer, ByVal encargado As String, ByVal cuenta As String, ByVal concepto As String, ByVal ptovta As Integer, ByVal total As Decimal, ByVal observaciones As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DS_dde As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DA_dde As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim nrofact As String = ""
        Dim nrofact_n As Integer
        Dim movId As Integer
        Dim result As Integer
        Dim repoServ As New RepoServicio

        con.AbrirConexion(bd)
        'se obtien el ultimo movimiento correspondiente a una factura
        SQL = String.Format("SELECT MAX(mov_id) FROM `movimientos` WHERE mov_tipo = 1 AND mov_pto_venta = {0}", ptovta)
        'SQL = "SELECT MAX(mov_nro_factura) FROM `movimientos` WHERE mov_tipo = 1"
        Try
            DA = con.EjecutarConsulta(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            ' si es el primer movimiento, la consulta devuelve null, lo que es equivalente a cero
            If IsDBNull(DS.Tables(0).Rows(0).ItemArray(0)) Then
                movId = 0
            Else
                movId = DS.Tables(0).Rows(0).ItemArray(0)
            End If
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        DA.Dispose()
        DS.Clear()
        DS.Dispose()

        If movId = 0 And ptovta = 2 Then
            nrofact = "0001436"
        ElseIf movId = 0 And ptovta = 3 Then
            nrofact = "0000140"
        Else
            'se obtiene el numero de factura de la ultima facturacion en el punto de venta indicado por argumento
            SQL = String.Format("SELECT mov_nro_factura FROM `movimientos` WHERE mov_id = {0}", movId)
            'SQL = "SELECT MAX(mov_nro_factura) FROM `movimientos` WHERE mov_tipo = 1"
            Try
                DA = con.EjecutarConsulta(SQL)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
            DA.Fill(DS2)
            If DS2.Tables(0).Rows.Count > 0 Then
                ' si es la primera factura, la consulta devuelve null, lo que es equivalente a 1
                If IsDBNull(DS2.Tables(0).Rows(0).ItemArray(0)) Then
                    nrofact = "0001436"
                Else
                    'se construye el numero de factura correspondiente a la presente facturacion
                    nrofact_n = Convert.ToInt16(DS2.Tables(0).Rows(0).ItemArray(0)) + 1
                    nrofact = nrofact_n.ToString
                    nrofact = nrofact.PadLeft(8, "0")
                End If
            Else
                MsgBox(Cts.msgErrSinResultados)
            End If
        End If
        DA.Dispose()
        DS2.Clear()
        DS2.Dispose()

        'se factura
        SQL = String.Format("INSERT INTO `movimientos` (`mov_id`, `per_id`,`mov_encargado`, `mov_tipo`, `mov_fecha`, `mov_total`, `mov_pto_venta`, `mov_nro_factura`, `mov_obs`, `mov_concepto`, `mov_cuentaDebe`, `mov_cuentaHaber`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                                         alu, encargado, Cts.movCobro, DateTime.Now().ToString("yyyy/MM/dd").ToString, total, ptovta, nrofact, observaciones, "", "", "")
        Try
            result = con.EjecutarComando(SQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se facturan los detalles
        SQL = String.Format("INSERT INTO movimientosdetalles(`mde_id`, `mov_id`, `cue_nombre`, `mde_tipo`, `mde_monto`, `mde_concepto`, `mde_observaciones`, `dev_id`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                        movId + 1, cuenta, Cts.movCobro, total, concepto, observaciones, dev_id)
        SQL2 = String.Format("UPDATE devengacionesdetalles as d SET d.dde_cancelada = 1 WHERE d.dev_id = {0}", dev_id)
        Try
            result = con.EjecutarComando(SQL)
            result = con.EjecutarComando(SQL2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        con.CerrarConexion()
        Return movId + 1
    End Function


    'Devuelve el id y el nombre de los cursos
    Public Function Curso(cursoid As Integer, Optional ByVal bd As Boolean = True) As String
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_nombre FROM cursos WHERE cur_id = '{0}'", cursoid)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Curso = ""
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Dim dr As DataRow
            dr = DS.Tables(0).Rows(0)
            Curso = dr("cur_nombre")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Curso
    End Function

    'Devuelve el monto de un servicio a partir de su id
    'Esto iría en repoServicios
    Public Function montoServicio(id As Integer, Optional ByVal bd As Boolean = True) As Double
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_precio FROM servicios WHERE serv_id = '{0}'", id)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            Dim dr As DataRow
            dr = DS.Tables(0).Rows(0)
            montoServicio = dr("serv_precio")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Anula un movimiento por su id
    Public Function Anular_Movimiento(ByVal id_mov As Integer, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("UPDATE movimientos as m SET m.mov_anulada = 1 WHERE m.mov_id = {0}", id_mov)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim id As Integer = 0
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            'id = DS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function


End Class
