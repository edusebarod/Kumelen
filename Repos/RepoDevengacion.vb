Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class RepoDevengación
    ''' <summary>
    ''' Devuelve el id y el nombre de las cuentas del plan de cuentas
    ''' </summary>
    ''' <param name="bd">True = Via1, False = Via2</param>
    ''' <returns>Un DataSet con dos columnas: id de ka cuenta y nombre de la cuenta</returns>
    ''' <remarks></remarks>
    Public Function Cuentas(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cue_id, cue_nombre FROM cuentas WHERE cue_devengaciones = 1 ORDER BY cue_nombre")
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

    ''' <summary>
    ''' Devuelve el id, el nombre y el precio de los servicios que brinda la escuela
    ''' </summary>
    ''' <param name="bd">True = Via1, False = Via2</param>
    ''' <returns>Un DataSet con las columnas: Id del Servicio, nombre del servicio y precio del servicio</returns>
    ''' <remarks></remarks>
    Public Function Servicios(Optional ByVal bd As Boolean = True) As DataSet
        'Esto iría en repoServicios
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_id, serv_nombre, serv_precio FROM servicios WHERE serv_tipo = 0 AND serv_activo = 1 ORDER BY serv_nombre")
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

    'Devuelve el id, el nombre y el precio de los productos que vende la escuela
    Public Function Productos(Optional ByVal bd As Boolean = True) As DataSet
        'Esto iría en repoServicios
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_id, serv_nombre, serv_precio FROM servicios WHERE serv_tipo = 1 ORDER BY serv_nombre")
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

    'TODO impactar bien los detalles de la factura
    'Impacta la devengación en la base de datos
    'cta: nombre de la cuenta contra la que se devenga
    'ser: nombre del servicio que se devenga
    'alu: id del alumno al que se le devenga
    'Total: monto total de la devengación
    'observaciones: observaciones de la devengación
    Public Function Devengar(ByVal alu As Integer, ByVal total As Double, ByVal observaciones As String, ByVal detalle As DataGridView, ByVal mes As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim devId As Integer
        Dim result As Integer
        Dim v1 As String = ""
        Dim v2 As String = ""
        Dim v3 As String = ""
        Dim repoServ As New RepoServicio
        Dim dr As DataRow
        Dim cantidad As Integer

        'se obtien el primer vencimiento
        SQL = "SELECT vencimiento1 FROM vencimientos WHERE venc_id = 1"
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v1 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
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
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v2 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
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
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v3 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        'se devenga 
        SQL = String.Format("INSERT INTO `devengaciones` (`dev_id`, `dev_vencimiento1`, `dev_vencimiento2`, `dev_vencimiento3`, `per_id`, `dev_total`, `dev_fecha`, `dev_observaciones`, `dev_tipo`, `dev_cancelada`, `dev_mes`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}')",
                                          v1, v2, v3, alu, total, DateTime.Now.ToString("yyyy/MM/dd").ToString, observaciones, 0, 0, mes)
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se devengan los detalles
        'se obtiene el dev_id
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()
        SQL = "SELECT MAX(dev_id) FROM `devengaciones`"
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            devId = DS.Tables(0).Rows(0).ItemArray(0)
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        ' para cada fila de la grilla se hace un insert en la bd
        For Each row As DataGridViewRow In detalle.Rows
            SQL = String.Format("INSERT INTO devengacionesdetalles (`dde_id`, `dev_id`, `cue_nombre`, `serv_nombre`, `dde_monto`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}')",
                                        devId, row.Cells("cuenta").Value, row.Cells("concepto").Value, row.Cells("monto").Value)
            If Not bd Then
                If repoServ.EsProducto(row.Cells("concepto").Value, False) Then
                    SQL3 = String.Format("SELECT serv_cantidad FROM servicios s WHERE s.serv_nombre LIKE '{0}'", row.Cells("concepto").Value)

                    Try
                        con.AbrirConexion(bd)
                        DA = con.EjecutarConsulta(SQL3)
                        DA.Fill(DS3)
                        dr = DS3.Tables(0).Rows(0)
                        cantidad = Convert.ToInt16(dr("serv_cantidad"))
                        SQL4 = String.Format("UPDATE servicios as s SET s.serv_cantidad = {0} WHERE s.serv_id = {1}", cantidad - 1, row.Cells("serv_id").Value)
                        result = con.EjecutarComando(SQL4)
                        con.CerrarConexion()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return Nothing
                    End Try
                End If
            End If

            Try
                con.AbrirConexion(bd)
                result = con.EjecutarComando(SQL)
                con.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        Next
        Return devId
    End Function


    'Impacta las devengaciones para los alumnos de una sala en la base de datos
    'alu: id del alumno al que se le devenga
    'observaciones: observaciones de la devengación
    'cuenta: cuenta contra la cual se devenga 
    'concepto: concepto por el que se devenga 
    'monto: monto de la devengación
    Public Function Devengar_sala(ByVal alu As Integer, ByVal observaciones As String, ByVal cuenta As String, ByVal concepto As String, ByVal monto As Decimal, ByVal mes As String, Optional ByVal bd As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim DS As DataSet = New DataSet()
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim SQL As String
        Dim devId As Integer
        Dim result As Integer
        Dim v1 As String = ""
        Dim v2 As String = ""
        Dim v3 As String = ""

        'se obtien el primer vencimiento
        SQL = "SELECT vencimiento1 FROM vencimientos WHERE venc_id = 1"
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v1 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
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
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v2 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
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
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            v3 = DS.Tables(0).Rows(0).ItemArray(0).ToString()
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        'se devenga 
        SQL = String.Format("INSERT INTO `devengaciones` (`dev_id`, `dev_vencimiento1`, `dev_vencimiento2`, `dev_vencimiento3`, `per_id`, `dev_total`, `dev_fecha`, `dev_observaciones`, `dev_tipo`, `dev_mes`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                          v1, v2, v3, alu, monto, DateTime.Now.ToString("yyyy/MM/dd").ToString, observaciones, 0, mes)
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        'se devengan los detalles
        'se obtiene el dev_id
        DA.Dispose()
        DS.Clear()
        DS.Reset()
        DS.Dispose()
        SQL = "SELECT MAX(dev_id) FROM `devengaciones`"
        Try
            con.AbrirConexion(bd)
            DA = con.EjecutarConsulta(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            devId = DS.Tables(0).Rows(0).ItemArray(0)
        Else
            MsgBox(Cts.msgErrSinResultados)
        End If

        SQL = String.Format("INSERT INTO devengacionesdetalles (`dde_id`, `dev_id`, `cue_nombre`, `serv_nombre`, `dde_monto`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}')",
                                        devId, cuenta, concepto, monto)
        Try
            con.AbrirConexion(bd)
            result = con.EjecutarComando(SQL)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
        Return devId
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

    'Devuelve un dataset con las devengaciones por id del alumno
    Public Function Devengaciones_Alumno(ByVal idAlumno As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT dev_id, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3, CONCAT(per_apellido, ', ', per_nombre) FROM devengaciones as d, personas as p WHERE d.per_id = p.per_id AND p.per_id = {0}", idAlumno)
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

    'Devuelve un dataset con las devengaciones no canceladas por id del alumno
    Public Function Devengaciones_NoCanceladas_Alumno(ByVal idAlumno As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        If idAlumno = 0 Then
            SQL = "SELECT dd.serv_nombre, d.dev_observaciones, dd.dde_monto, dd.dev_id, dde_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p WHERE d.dev_id = dd.dev_id AND d.per_id = p.per_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno"
        Else
            SQL = String.Format("SELECT dd.serv_nombre, d.dev_observaciones, dd.dde_monto, dd.dev_id, dde_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p WHERE d.dev_id = dd.dev_id AND d.per_id = p.per_id AND p.per_id = {0} AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno", idAlumno)

        End If
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            DA.Fill(DS)
            conexion.CerrarConexion()

            Return DS
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DS
    End Function

    'Devuelve un dataset con todas las devengaciones no canceladas
    Public Function Devengaciones_NoCanceladas(ByVal idAlumno As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        If idAlumno = 0 Then
            SQL = "SELECT dd.serv_nombre, d.dev_observaciones, dd.dde_monto, dd.dev_id, d.dev_mesCONVERT(dev_fecha, CHAR(20)) AS dev_fecha, d.dev_mes as Mes, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno"
        Else
            SQL = String.Format("SELECT dd.serv_nombre, d.dev_observaciones, dd.dde_monto, dd.dev_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, d.dev_mes as Mes, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND p.per_id = {0} AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno", idAlumno)
        End If
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

    'Devuelve un dataset con todas las devengaciones no canceladas
    Public Function Devengaciones_NoCanceladas(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()

        SQL = "SELECT CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni as dni, c.cur_nombre as curso, dd.serv_nombre as concepto, dd.dde_monto as monto, CONVERT(dev_fecha, CHAR(20)) AS fecha FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 AND a.alu_activo = 1 AND a.alu_baja = 0 ORDER BY alumno"
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

    'Devuelve un dataset con las devengaciones no anuladas por id del alumno, si el id es 0
    Public Function Devengaciones_NoAnuladas_Alumno(ByVal idAlumno As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        If idAlumno = 0 Then
            SQL = "SELECT dd.dev_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dd.dde_monto, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno"
        Else
            SQL = String.Format("SELECT dd.dev_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dd.dde_monto, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND p.per_id = {0} AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno", idAlumno)
        End If
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

    'Devuelve un dataset con las devengaciones no anuladas por id del alumno, si el id es 0
    Public Function Devengaciones_NoAnuladas_Curso(ByVal curso As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()

        SQL = String.Format("SELECT dd.dev_id, dde_id, CONVERT(dev_fecha, CHAR(20)) AS dev_fecha, CONCAT(per_apellido, ', ', per_nombre) as Alumno, per_dni, serv_nombre, dd.dde_monto, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengaciones as d, devengacionesdetalles as dd, personas as p, alumnos as a, cursos as c WHERE p.per_id = a.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND a.alu_curso = {0} AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 AND a.alu_activo = 1 AND a.alu_baja = 0 ORDER BY alumno", curso)

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
    'Devuelve un dataset con una devengacion
    Public Function DevengacionXid(ByVal idDevengacion As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM devengaciones as d WHERE d.dev_id = {0}", idDevengacion)
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

    'Devuelve un dataset con los detalles de una devengacion
    Public Function Detalles(ByVal idDevengacion As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM devengacionesdetalles as dd WHERE dd.dev_id = {0}", idDevengacion)
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

    'Devuelve el 1 vencimiento de una devengación por su id
    Public Function Vencimiento1(ByVal idDevengacion As Integer, Optional ByVal bd As Boolean = True) As String
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT dev_vencimiento1 FROM devengaciones as d WHERE d.dev_id = {0}", idDevengacion)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim result As String = ""
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            result = DS.Tables(0).Rows(0).ItemArray(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return result
    End Function

    'Devuelve el id de la persona asociada a un devengacion, a traves del id de la misma
    Public Function Id_persona(ByVal id_dev As Integer, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT per_id FROM devengaciones as d WHERE d.dev_id = {0}", id_dev)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Dim id As Integer = 0
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            id = DS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return id
    End Function

    ''' <summary>
    ''' Anula una devengación por su id
    ''' </summary>
    ''' <param name="id_dev">Id de la devengación a anular</param>
    ''' <param name="bd">True = Via1, False = Via2</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Anular_Devengacion(ByVal id_dev As Integer, Optional ByVal bd As Boolean = True) As Integer
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("UPDATE devengaciones as d SET d.dev_anulada = 1 WHERE d.dev_id = {0}", id_dev)
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

    'Devuelve un dataset con las devengaciones y sus detalle en un rango de fechas
    Public Function Devengaciones_Fecha(ByVal fecha1 As String, ByVal fecha2 As String, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT dd.serv_nombre, d.dev_observaciones, d.dev_total, d.dev_id, dev_fecha, d.dev_mes, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengacionesdetalles as dd, devengaciones as d, personas as p, alumnos as a, cursos as c WHERE a.per_id = p.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 AND dev_fecha BETWEEN '{0}' AND '{1}' ORDER BY alumno", fecha1, fecha2)
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

    'Devuelve un dataset con las devenagciones y sus detalles por nro de devengacion
    Public Function Devengaciones_NroDevengacion(ByVal nro_devengacion As Integer, Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT dd.serv_nombre, d.dev_observaciones, d.dev_total, d.dev_id, dev_fecha, d.dev_mes, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, a.alu_descuento, c.cur_nombre, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3  FROM devengacionesdetalles as dd, devengaciones as d, personas as p, alumnos as a , cursos as c WHERE a.per_id = p.per_id AND d.per_id = p.per_id AND a.alu_curso = c.cur_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 AND d.dev_id = {0} ORDER BY alumno", nro_devengacion)
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

    'Devuelve un dataset con las devengaciones y sus detalles 
    Public Function Devengaciones(Optional ByVal bd As Boolean = True) As DataSet
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT dd.serv_nombre, d.dev_observaciones, d.dev_total, d.dev_id, dev_fecha, d.dev_mes, CONCAT(per_apellido, ', ', per_nombre) as alumno, per_dni, dev_vencimiento1, dev_vencimiento2, dev_vencimiento3 FROM devengacionesdetalles as dd, devengaciones as d, personas as p WHERE d.per_id = p.per_id AND d.dev_id = dd.dev_id AND dd.dde_cancelada = 0 AND d.dev_anulada = 0 ORDER BY alumno")
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

End Class
