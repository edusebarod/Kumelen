Public Class RepoCurso
    Private aID As String = "cur_id"
    Private aDocente As String = "emp_id"
    Private aNombre As String = "cur_nombre"
    Private aActivo As String = "cur_activo"
    Private aAnoLectivo As String = "cur_anolectivo"
    Private aTurno As String = "cur_turno"

    Public Function Traer_X_nombre(ByRef Nombre As String, ByRef Cur As Curso, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM cursos WHERE cur_nombre LIKE {0}", Nombre)
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Cur
                    .id = dr(aID)
                    .docente = dr(aDocente)
                    .nombre = dr(aNombre)
                    .activo = dr(aActivo)
                    .activo = dr(aAnoLectivo)
                    .turno = dr(aTurno)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Traer_X_id(ByRef ID As Integer, ByRef Cur As Curso, Optional ByVal db As Boolean = True) As Boolean
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM cursos WHERE cur_id = {0}", ID)
        'Dim DA As New SqlClient.SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            conexion.AbrirConexion(db)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then Return False
            For Each dr As DataRow In DS.Tables(0).Rows
                With Cur
                    .id = dr(aID)
                    .docente = dr(aDocente)
                    .nombre = dr(aNombre)
                    .activo = dr(aActivo)
                    .anolectivo = dr(aAnoLectivo)
                    .turno = dr(aTurno)
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Public Function Existe(ByVal Nombre As String, Optional ByVal db As Boolean = True) As Boolean
        Dim B As Boolean = True
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("SELECT * FROM cursos WHERE cur_nombre LIKE '{0}'", Nombre)
        'Dim DA As SqlDataAdapter
        Dim DA As New MySqlClient.MySqlDataAdapter
        Try
            con.AbrirConexion(db)
            DA = con.EjecutarConsulta(SQL)
            Dim DS As DataSet = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count = 0 Then B = False
            con.CerrarConexion()
            Return B
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Agregar(ByVal cur As Curso, Optional ByVal db As Boolean = True) As Integer
        Dim con As New cBaseDatos
        Dim SQL As String = String.Format("INSERT INTO cursos (emp_id, cur_anolectivo, cur_nombre, cur_turno, cur_activo) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                          cur.docente, cur.anolectivo, cur.nombre, cur.turno, cur.activo)
        Dim result As Integer
        Try
            con.AbrirConexion(True)
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

    Public Function Editar(ByVal Cur As Curso, Optional ByVal db As Boolean = True) As Integer
        Dim result As Integer
        Dim SQL As String = String.Format("UPDATE cursos SET emp_id = '{0}', cur_anolectivo = '{1}', cur_nombre = '{2}', cur_turno = '{3}', cur_activo = {4} WHERE cur_id = {5}",
                                          Cur.docente, Cur.anolectivo, Cur.nombre, Cur.turno, Cur.activo, Cur.id)
        Dim con As New cBaseDatos
        Try
            con.AbrirConexion(True)
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

    'Devuelve el emp_id y el nombre de los docentes
    Public Function Docentes(Optional ByVal db As Boolean = True) As DataSet
        'Dim combo As ComboBox
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT e.emp_id, CONCAT(per_apellido, ', ', per_nombre) FROM personas as p, empleados as e WHERE p.per_id = e.per_id AND e.emp_tipo LIKE ""%Docente%""")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(db)
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