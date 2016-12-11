Public Class visRepAlumnoInicial
    Public idAlumno As Integer
    Public idMadre As Integer
    Public idPadre As Integer
    Public objrep As New rptAlumnoInicial

    Private Sub visRepAlumnoInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT p.per_id," +
                                          "p.per_apellido," +
                                          "p.per_nombre, " +
                                          "p.per_fecnac, " +
                                          "p.per_lugnac, " +
                                          "p.per_dni, " +
                                          "p.per_sexo, " +
                                          "p.per_nacionalidad, " +
                                          "p.per_domicilio, " +
                                          "p.loc_id, " +
                                          "a.alu_legajo, " +
                                          "a.alu_enfermedades, " +
                                          "a.alu_alergias, " +
                                          "a.alu_medicacion, " +
                                          "a.alu_observaciones, " +
                                          "a.alu_padre, " +
                                          "a.alu_madre, " +
                                          "a.alu_fechabaja, " +
                                          "a.alu_fechaalta, " +
                                          "a.alu_activo, " +
                                          "a.alu_ciclo, " +
                                          "a.alu_tipo, " +
                                          "c.cur_nombre as alu_curso, " +
                                          "a.alu_anolectivo, " +
                                          "a.alu_turno, " +
                                          "a.alu_horario, " +
                                          "a.alu_obrasocial, " +
                                          "a.alu_salud, " +
                                          "a.alu_experiencia, " +
                                          "a.alu_tiempo, " +
                                          "a.alu_lugarexp, " +
                                          "a.alu_perRetiro, " +
                                          "a.alu_descuento, " +
                                          "CAST(a.alu_fDNI AS CHAR) AS alu_fDNI, " +
                                          "CAST(a.alu_fDNIpadre AS CHAR) AS alu_fDNIpadre, " +
                                          "CAST(a.alu_fDNImadre AS CHAR) AS alu_fDNImadre, " +
                                          "CAST(a.alu_fotocarnet AS CHAR) AS alu_fotocarnet, " +
                                          "CAST(a.alu_certifsalud AS CHAR) AS alu_certifsalud, " +
                                          "CAST(a.alu_fIPE AS CHAR) AS alu_fIPE, " +
                                          "CAST(a.alu_entrevistaDOE AS CHAR) AS alu_entrevistaDOE, " +
                                          "CAST(a.alu_fichaMedica AS CHAR) AS alu_fichaMedica, " +
                                          "CAST(a.alu_audiometria AS CHAR) AS alu_audiometria, " +
                                          "CAST(a.alu_certificadoBD AS CHAR) AS alu_certificadoBD, " +
                                          "a.alu_tutor, " +
                                          "a.alu_servdescuento " +
                                          "FROM  personas as p, alumnos as a, cursos as c " +
                                          "WHERE a.per_id = p.per_id AND a.alu_curso = c.cur_id AND p.per_id = {0}; " +
                                          "SELECT p.per_id, " +
                                          "p.per_apellido, " +
                                          "p.per_nombre, " +
                                          "p.per_fecnac, " +
                                          "p.per_lugnac, " +
                                          "p.per_dni, " +
                                          "p.per_sexo, " +
                                          "p.per_nacionalidad, " +
                                          "p.per_domicilio, " +
                                          "p.per_CP, " +
                                          "p.loc_id, " +
                                          "p.per_telefono, " +
                                          "p.per_celular, " +
                                          "p.per_mail, " +
                                          "p.per_nivelesc, " +
                                          "p.per_estadocivil, " +
                                          "p.per_ocupacion, " +
                                          "p.per_domlaboral, " +
                                          "p.per_empresa, " +
                                          "p.per_cuil " +
                                          "FROM  personas as p " +
                                          "WHERE p.per_id = {1}; " +
                                          "SELECT p.per_id, " +
                                          "p.per_apellido, " +
                                          "p.per_nombre, " +
                                          "p.per_fecnac, " +
                                          "p.per_lugnac, " +
                                          "p.per_dni, " +
                                          "p.per_sexo, " +
                                          "p.per_nacionalidad, " +
                                          "p.per_domicilio, " +
                                          "p.per_CP, " +
                                          "p.loc_id, " +
                                          "p.per_telefono, " +
                                          "p.per_celular, " +
                                          "p.per_mail, " +
                                          "p.per_nivelesc, " +
                                          "p.per_estadocivil, " +
                                          "p.per_ocupacion, " +
                                          "p.per_domlaboral, " +
                                          "p.per_empresa, " +
                                          "p.per_cuil " +
                                          "FROM  personas as p " +
                                          "WHERE p.per_id = {2}", idAlumno, idMadre, idPadre)

        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()

        Try
            conexion.AbrirConexion()
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
            DS.Tables(0).TableName = "Alumno"
            DS.Tables(1).TableName = "Madre"
            DS.Tables(2).TableName = "Padre"

            DS = corregirvizualizacion(DS, 33, 43)

            objrep.SetDataSource(DS)

            CrystalReportViewer1.ReportSource = objrep
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function corregirvizualizacion(DS As DataSet, desde As Integer, hasta As Integer)

        If desde <= hasta And Not IsNothing(DS) Then
            For i As Integer = desde To hasta
                If DS.Tables(0).Rows(0).Item(i).ToString = "1" Then
                    DS.Tables(0).Rows(0).Item(i) = "Si"
                End If

                If DS.Tables(0).Rows(0).Item(i).ToString = "0" Then
                    DS.Tables(0).Rows(0).Item(i) = "No"
                End If
            Next
        End If

        Return DS
    End Function
End Class