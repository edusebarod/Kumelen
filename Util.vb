
Public Module Util
    'Coloreo de controles de un formulario segun su tipo
    Public Sub ColorearControles(ByVal F As Form)
        For Each ctl In F.Controls
            If TypeOf ctl Is Label Or TypeOf ctl Is CheckBox Or TypeOf ctl Is RadioButton Then
                ctl.Font = New Font("Arial", 10, FontStyle.Bold)
                ctl.BackColor = Cts.lblFondo
                ctl.ForeColor = Cts.lblFuente
            ElseIf TypeOf ctl Is TextBox Or TypeOf ctl Is ListBox Or TypeOf ctl Is ComboBox Then 'Or TypeOf ctl Is GroupBox Then
                ctl.Font = New Font("Arial", 10, FontStyle.Bold)
                ctl.ForeColor = Cts.txtFuente
                If Not TypeOf ctl Is GroupBox Then ctl.BackColor = Cts.txtFondo
            ElseIf TypeOf ctl Is Button Then
                ctl.Font = New Font("Arial", 10, FontStyle.Bold)
                ctl.BackColor = Cts.cmdFondo
                ctl.forecolor = Cts.cmdFuente
            End If
        Next
    End Sub

    'coloreo de un formulario
    Public Sub ColorearFRM(ByVal F As Form)

        F.BackColor = Cts.frmFondo
    End Sub

    'coloreo de un label para indicar falla en la validacion
    Public Sub ColorearValidacion(ByVal Colorear As Boolean, ByVal Elem As Label)
        If Colorear Then
            Elem.ForeColor = Cts.lblFuenteError
            Elem.BackColor = Cts.lblFondoError
        Else
            Elem.ForeColor = Cts.lblFuente
            Elem.BackColor = Cts.lblFondo
        End If
    End Sub

    'coloreo de un textbox para indicar que es un campo de busqueda
    Public Sub ColorearBusqueda(ByVal Busco As Boolean, ByVal Elem As TextBox)
        'en el else van los mismos colores que en la funcion colorear
        If Busco Then
            Elem.ForeColor = Cts.txtFuenteBusco
            Elem.BackColor = Cts.txtFondoBusco
        Else
            Elem.ForeColor = Cts.txtFuente
            Elem.BackColor = Cts.txtFondo
        End If
    End Sub

    'habilita/deshabilita y colorea un boton
    Public Sub EnableCmd(ByVal Enable As Boolean, ByVal Elem As Button)
        Elem.Enabled = Enable
        If Enable Then
            Elem.BackColor = Cts.cmdFondo
            Elem.ForeColor = Cts.cmdFuente
        Else
            Elem.BackColor = Cts.cmdFondoDisable
            Elem.ForeColor = Cts.cmdFuenteDisable
        End If
    End Sub

    'limpia todos los controles de un form
    Public Sub LimpiarControles(ByRef F As Form)
        'Dim l As New ListBox
        For Each ctl In F.Controls
            If TypeOf ctl Is TextBox Then
                ctl.text = ""
            ElseIf TypeOf ctl Is CheckBox Then
                ctl.checked = False
                'ElseIf TypeOf ctl Is ListBox Or TypeOf ctl Is ComboBox Then
                '    ctl.Items.Clear()
            ElseIf TypeOf ctl Is MaskedTextBox Then
                ctl.text = ""
            ElseIf TypeOf ctl Is DateTimePicker Then
                ctl.checked = False
            ElseIf TypeOf ctl Is GroupBox Then
                For Each elem In ctl.Controls
                    If TypeOf elem Is TextBox Then
                        elem.text = ""
                    ElseIf TypeOf elem Is CheckBox Then
                        elem.checked = False
                    ElseIf TypeOf elem Is MaskedTextBox Then
                        elem.text = ""
                    ElseIf TypeOf elem Is ComboBox Then
                        elem.selecteditem = Nothing
                    ElseIf TypeOf elem Is DateTimePicker Then
                        elem.checked = False
                    End If
                Next
            ElseIf TypeOf ctl Is ComboBox Then
                ctl.selecteditem = Nothing
            End If
        Next
    End Sub

    'valida el formato de un string segun el formato del tipo moneda
    Public Function ValidarPrecio(ByVal Precio As String) As String
        'PRE Precio e {0123456789.}*
        Dim result As String = "0"
        If Precio <> "" Then
            If InStr(".", Precio) = 1 Then
                'Si empieza con , deberia escribir 0,
                result = "0."
            ElseIf InStr(".", Precio) > 1 Then
                result = Precio - 1
            End If
        End If
        Return result
    End Function

    'Carga las localidades cargadas en la base de datos
    Public Sub CargarLocalidades(ByRef cbo As ComboBox, Optional ByVal bd As Boolean = True)
        cbo.Items.Clear()
        Dim repo As New RepoLocalidad
        Dim DS As DataSet = repo.TraerTodas(True)
        cbo.DataSource = DS.Tables(0)
        cbo.DisplayMember = "loc_nombre" 'DS.Tables(0).Columns(0).Caption.ToString()
        cbo.ValueMember = "loc_id" 'DS.Tables(0).Columns(1).Caption.ToString()
    End Sub

    'Se cargan los tipos de cuenta en un combobox
    Public Sub CargarTipoCuenta(ByRef cbo As ComboBox)
        Dim tipos As New ArrayList()
        tipos.Add(New TipoCuenta(Cobros, "Cobros"))
        tipos.Add(New TipoCuenta(Pagos, "Pagos"))
        cbo.Items.Clear()
        cbo.DataSource = tipos
        cbo.DisplayMember = "tipo"
        cbo.ValueMember = "idtipo"
    End Sub

    'formatea los parametros de la clase frmBusqueda
    'TODO mejorar este funcion o la forma que se hace esto
    Public Sub FormatoBusqueda(ByVal Tabla As String, ByVal CuerpoSelect As String, CampoFiltro As String,
                               ByVal Parametro As String, ByVal TipoConexion As Boolean,
                               ByVal sID As String, ByVal sNombre As String, ByRef Result As Integer)
        'PARAMETROS:
        'Tabla: tabla donde voy a buscar
        'CuerpoSelect: lo que va en el select de la consulta
        'CampoFiltro: el campo por el que filtro, generalmente xxx_nombre o xxx_apellido
        'Parametro: lo que tengo escrito en el txt que ejecuta la busqueda
        'TipoConexion: si es A o B
        'sID el campo que quiero que tenga el codigo de la lst
        'sNombre el campo que se va a mostrar en el lst
        'result 
        'podriamos agregar el tema de que este activa
        Dim sql As String
        sql = String.Format("SELECT {0} FROM {1} WHERE {2}", CuerpoSelect, Tabla, CampoFiltro)
        frmBusqueda.SQL = String.Format("SELECT {0} FROM {1} WHERE {2}", CuerpoSelect, Tabla, CampoFiltro)
        frmBusqueda.Buscar = Parametro
        frmBusqueda.Tabla = Tabla
        frmBusqueda.TipoCon = TipoConexion
        frmBusqueda.ID = sID
        frmBusqueda.Nombre = sNombre
        frmBusqueda.Codigo = Result
    End Sub

    'Calcula la edad de una persona a partir de la fecha de nacimiento
    Function Calcular_Edad(Fecha_Nacimiento As String) As Integer
        Dim fechaNac As Date
        Dim Años As Object

        ' comprueba si el valor no es nulo  
        If IsNothing(Fecha_Nacimiento) Or Fecha_Nacimiento = "0000-00-00" Or Fecha_Nacimiento = "/  /" Or Fecha_Nacimiento = "" Or Fecha_Nacimiento = "0000/00/00" Then
            Calcular_Edad = 0
            Exit Function
        Else
            'se obtiene fechaNac en formato Date
            fechaNac = Date.Parse(Fecha_Nacimiento)

            'se obtiene la cantidad de años desde la fecha de nacimiento hasta el momento de ejecución
            Años = DateDiff("yyyy", fechaNac, Now)

            If Now < fechaNac Then
                Años = Años - 1
            End If

            Calcular_Edad = CInt(Años)
        End If
    End Function

    'busca un elemento por su numero de posicion dentro de una lista de un combobox
    Function buscaElemento(elemento As Integer, lista As ComboBox) As Integer
        Dim i As Integer
        Dim ii As Integer

        buscaElemento = -1

        For i = 0 To lista.Items.Count - 1
            lista.SelectedIndex = i
            ii = lista.SelectedItem(0)
            If ii = elemento Then
                buscaElemento = i
                Exit For
            End If
        Next i
    End Function

    'Busca un string dentro de la lista de un combobox
    Function buscaElementoString(elemento As String, lista As ComboBox) As Integer
        Dim i As Integer
        Dim ii As String

        buscaElementoString = -1

        For i = 0 To lista.Items.Count - 1
            lista.SelectedIndex = i
            ii = lista.SelectedItem()
            If ii = elemento Then
                buscaElementoString = i
                Exit For
            End If
        Next i
    End Function

    'Carga las salas desde la base de datos segun los vías
    Public Function traersala(id As Integer) As String
        Dim sql As String = String.Format("SELECT cur_nombre FROM cursos WHERE cur_id = {0}", id)
        Dim con As New cBaseDatos
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            con.AbrirConexion()
            DA = con.EjecutarConsulta(sql)
            con.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

        DA.Fill(DS)
        If DS.Tables(0).Rows.Count > 0 Then
            traersala = DS.Tables(0).Rows(0).ItemArray(0)
        Else
            MsgBox(Cts.msgErrSinResultados)
            Return Nothing
        End If
    End Function

    'Cargo los cursos desde la base de datos de cada una de las vías
    Public Sub CargarCursos(ByRef cbx As ComboBox, Optional ByVal bd As Boolean = True)
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_id, cur_nombre FROM cursos")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' asignar el DataSource al combobox
        cbx.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbx.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        cbx.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
    End Sub

    'Devuelve el id, el nombre y el precio de los servicios que brinda la escuela
    Public Sub CargarServicios(ByRef cbx As ComboBox, Optional ByVal bd As Boolean = True)
        'Esto iría en repoServicios
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT serv_id, serv_nombre FROM servicios WHERE serv_tipo = 0 AND serv_activo = 1 ORDER BY serv_nombre")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' asignar el DataSource al combobox
        DS.Tables(0).Rows.Add(100, "Todos")
        cbx.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbx.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        cbx.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
    End Sub

    'Cargo los cursos desde la base de datos de cada una de las vías
    Public Sub CargarCursosPrimario(ByRef cbx As ComboBox, Optional ByVal bd As Boolean = True)
        Dim conexion As New cBaseDatos
        Dim SQL As String = String.Format("SELECT cur_id, cur_nombre FROM cursos WHERE cur_nombre LIKE '%grado%'")
        Dim DA As New MySqlClient.MySqlDataAdapter
        Dim DS As DataSet = New DataSet()
        Try
            conexion.AbrirConexion(bd)
            DA = conexion.EjecutarConsulta(SQL)
            conexion.CerrarConexion()
            DA.Fill(DS)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ' asignar el DataSource al combobox
        cbx.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbx.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
        cbx.ValueMember = DS.Tables(0).Columns(0).Caption.ToString
    End Sub

    'Carga los niveles definidos internamente segun la bd correspondiente a los vias
    Public Sub CargarNiveles(ByRef cbx As ComboBox, Optional ByVal db As Boolean = True)
        ' Se agregan los items manualmente
        If db Then
            cbx.Items.Add("Inicial")
            cbx.Items.Add("Primario")
        Else
            cbx.Items.Add("Inicial")
            cbx.Items.Add("Maternal")
            cbx.Items.Add("Primario")
        End If
    End Sub

    'Genera el codigo con formato de pago mis cuentas para luego obtener un codigo de barras
    Public Function generarCodBarra(nroReferencia As String, nroComprobante As String, fecha As String)
        Dim codBarra As String = ""
        Dim digiVerif As String

        'acondicionamiento de argumentos
        nroRef = nroReferencia.PadLeft(12, "0")
        nroComprobante = nroComprobante.PadLeft(15, "0")
        fecha = fecha.Replace("-", "")
        fecha = fecha.Replace("/", "")

        'construcción del código de barra
        codBarra = "4729" + nroRef + nroComprobante + fecha + "04004729"

        'Calculo del digito de verificación
        digiVerif = modulo10(codBarra)
        'Código de barra final
        codBarra = codBarra + digiVerif
        'codBarra = "*" + codBarra + "*"
        Return codBarra
    End Function

    'obtiene un codigo de verificacion segun el metodo modulo 10 con factores 31313131....13 
    Public Function modulo10(codigo As String)
        Dim digito As String = ""
        Dim arrCodigo As String = ""
        Dim temp As Integer = 0
        Dim factores As String = "31313131313131313131313131313131313131313131313"
        Dim suma As Integer = 0
        Dim result As Integer
        Dim i As Integer


        For i = 0 To codigo.Length - 1
            temp = Val(codigo(i)) * Val(factores(i))
            suma = suma + temp
        Next

        result = suma Mod 10

        If result <> 0 Then
            result = 10 - result
        End If

        digito = result.ToString

        Return digito
    End Function

    Public Function Code_128(ByVal Codigo As String) As String
        ' C128Tools 29may12 jwhiting
        ' Copyright 2012 Azalea Software, Inc. All rights reserved. www.azalea.com

        ' Creating a Code 128 code set A barcode using C128Tools.
        ' Your input, yourData, is a string to be encoded as a Code 128 code set A symbol.
        ' yourData must be the Code 128 code set A character set. Input error checking is your responsibility.

        Dim temp As String                 'a temporary placeholder
        Dim chunk As String                'loop chunk
        Dim i As Integer                   'our loop counter
        Dim checkDigitSubtotal As Integer  'a check digit throwaway
        Dim e As Integer                   'a placeholder variable
        Dim code As String = ""

        'seed the variables
        temp = Chr(181)                   'code set A start glyph
        checkDigitSubtotal = 103          'code set A start checkdigit value

        'map the input string into the C128Tools character set
        For i = 1 To Len(Codigo) Step 1
            chunk = Mid(Codigo, i, 1)
            Select Case Asc(chunk)
                'map from above ASCII 182 placeholders to the font's character assignments
                Case Is > 95
                    temp = temp & Chr(Asc(chunk) - 66)
                Case Is = 32 'move the space character
                    temp = temp & Chr(206)
                Case Else
                    temp = temp & chunk
            End Select
        Next i

        'Calculate the Code 128 mod 103 check digit
        For i = 1 To Len(Codigo)
            e = Asc(Mid(Codigo, i, 1)) - 32
            If e <> 142 Then
                checkDigitSubtotal = checkDigitSubtotal + (e * i)
            End If
        Next i
        checkDigitSubtotal = checkDigitSubtotal Mod 103

        'Put together the final output string
        'code set A start bar, the encoded string, check digit, stop bar
        Select Case checkDigitSubtotal
            Case 0
                code = temp & Chr(206) & Chr(196)
            Case 1 To 93
                code = temp & Chr(checkDigitSubtotal + 32) & Chr(196)
            Case Is > 93
                code = temp & Chr(checkDigitSubtotal + 103) & Chr(196)
        End Select

        Return code
    End Function

    'Funcion que calcula los intereses en a partir de un monto (base imponible) y tres fechas de vencimiento
    Public Function calcular_intereses(monto As Decimal, fecha As String, venc1 As String, venc2 As String, venc3 As String) As Decimal
        Dim total As Decimal                'valor de return: total con intereses
        Dim dias As Integer                 'cantidad de dias entre momento de ejecucion y fecha de facturacion
        Dim diasc As Integer                'cantidad de dias a cobrar despues del tercer vencimiento
        Dim dias1, dias2, dias3 As Integer  'cantidad de dias entre vencimientos y momento de ejecucuion
        Dim fec, v1, v2, v3 As Date         'fechas y vencimientos parseados a date

        ' comprueba si el valor de los parametros no es nulo  
        If IsNothing(venc1) Or venc1 = "0000-00-00" Or venc1 = "/  /" Or venc1 = "" Or venc1 = "0000/00/00" Then
            total = 0
            Exit Function
        ElseIf IsNothing(venc2) Or venc2 = "0000-00-00" Or venc2 = "/  /" Or venc2 = "" Or venc2 = "0000/00/00" Then
            total = 0
            Exit Function
        ElseIf IsNothing(venc3) Or venc3 = "0000-00-00" Or venc3 = "/  /" Or venc3 = "" Or venc3 = "0000/00/00" Then
            total = 0
            Exit Function
        ElseIf IsNothing(fecha) Or fecha = "0000-00-00" Or fecha = "/  /" Or fecha = "" Or fecha = "0000/00/00" Then
            total = 0
            Exit Function
        Else
            'se obtienen las fechas en formato date
            v1 = Date.Parse(venc1)
            v2 = Date.Parse(venc2)
            v3 = Date.Parse(venc3)
            fec = Date.Parse(fecha)

            'se calculan la cantidad de dias desde la fecha de facturacion hasta el momento de ejecucion
            dias = DateDiff("d", fec, Now)
            'en caso de que haya pasado el tercer vencimiento los dias a cobrar son desde v3 hasta now

            diasc = DateDiff("d", v3, Now)

            'se calculan la cantidad de dias entre vencimientos y la fecha de facturacion
            dias1 = DateDiff("d", fec, v1)
            dias2 = DateDiff("d", fec, v2)
            dias3 = DateDiff("d", fec, v3)

            'se calcula el monto con intereses
            If dias > dias3 Then
                total = (monto * 1.04) * 1.001628 ^ diasc
                total = total - monto
            Else
                If dias > dias2 Then
                    total = monto * 1.04
                    total = total - monto
                Else
                    If dias > dias1 Then
                        total = monto * 1.02
                        total = total - monto
                    Else
                        total = 0
                    End If
                End If
            End If
        End If

        Return total
    End Function
End Module


Public Class TipoCuenta
    Private _idtipo As Integer
    Private _tipo As String

    Public Sub New(ByVal id As Integer, ByVal descripcion As String)
        idtipo = id
        tipo = descripcion
    End Sub

    Public Property idtipo() As Integer
        Get
            Return _idtipo
        End Get
        Set(value As Integer)
            _idtipo = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

End Class