Public Class frmDatosNegocio
    Public datosNeg As New Proveedor
    Public repoDatosNeg As New RepoDatosNegocio
    Private editar As Boolean
    Public sucursal As String

    Private Sub frmProductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmAyuda.Dispose()
            Ayuda.LeerAyuda("frmDatosNegocio")
            frmAyuda.Show()
        End If
    End Sub
    Private Sub frmDatosNegocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        ColorearBusqueda(True, txtRazonSocial)
        EnableCmd(False, cmdGrabar)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If cmdSalir.Text = "&CANCELAR" Then
            LimpiarControles(Me)
            ColorearBusqueda(True, txtRazonSocial)
            EnableCmd(False, cmdGrabar)
            cmdSalir.Text = "&SALIR"
            editar = False
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click
        If Validar() Then
            EnableCmd(False, cmdGrabar)
            Dim repo = New RepoDatosNegocio
            datosNeg.cuit = Trim(txtCUIT.Text)
            datosNeg.direccion = Trim(txtDireccion.Text)
            datosNeg.localidad = Trim(txtLocalidad.Text)
            datosNeg.mail = Trim(txtMail.Text)
            datosNeg.razonsocial = Trim(txtRazonSocial.Text)
            datosNeg.telefono = Trim(txtTelefono.Text)
            datosNeg.web = Trim(txtWeb.Text)
            If editar Then
                repo.Editar(datosNeg)
            Else
                repo.agregar(datosNeg)
            End If
            MsgBox(Cts.msgGraboOK, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Cts.msgTitulo)
            EnableCmd(True, cmdGrabar)
            ColorearValidacion(False, lblRazonSocial)
            ColorearValidacion(False, lblDireccion)
            ColorearValidacion(False, lblCUIT)
            ColorearValidacion(False, lblLocalidad)
            ColorearBusqueda(True, txtRazonSocial)
            ' EnableCmd(False, btnAdd)
            LimpiarControles(Me)
            txtRazonSocial.Select()
        Else
            MsgBox(Cts.msgValidar, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, Cts.msgTitulo)
        End If

    End Sub

    Private Function Validar() As Boolean
        Dim B As Boolean = True
        If txtRazonSocial.Text = "" Then
            ColorearValidacion(True, lblRazonSocial)
            B = False
        End If
        If txtDireccion.Text = "" Then
            ColorearValidacion(True, lblDireccion)
            B = False
        End If
        If txtCUIT.Text = "" Then
            ColorearValidacion(True, lblCUIT)
            B = False
        End If
        Return B
    End Function


    Private Sub btnBuscaProv_Click(sender As Object, e As EventArgs) Handles btnBuscaProv.Click
        Dim proveedor As String
        Dim proveedor_id As Integer
        Dim id As Integer
        If txtRazonSocial.Text <> "" Then
            Dim CuerpoSelect As String = "id, id, razon_social, razon_social"
            id = 0
            FormatoBusqueda("datosnegocio", CuerpoSelect, "razon_social", Trim(txtRazonSocial.Text), True, "id", "razon_social", id)
            frmBusqueda.ShowDialog()
            proveedor_id = frmBusqueda.Codigo
            proveedor = frmBusqueda.Nombre
            frmBusqueda.Dispose()
            If proveedor_id <> 0 Then
                repoDatosNeg.Traer(proveedor_id, datosNeg)
                acomodoProveedor()
                AcomodoDespuesDeBusqueda()
            Else
                txtRazonSocial.Select()
            End If
        End If
    End Sub

    Private Sub acomodoProveedor()
        txtRazonSocial.Text = datosNeg.razonsocial
        txtDireccion.Text = datosNeg.direccion
        txtLocalidad.Text = datosNeg.localidad
        txtCUIT.Text = datosNeg.cuit
        txtTelefono.Text = datosNeg.telefono
        txtMail.Text = datosNeg.mail
        txtWeb.Text = datosNeg.web
    End Sub

    Private Sub AcomodoDespuesDeBusqueda()
        editar = True
        ColorearBusqueda(False, txtRazonSocial)
        EnableCmd(False, btnAdd)
        EnableCmd(True, cmdGrabar)
        cmdSalir.Text = "&CANCELAR"
        cmdSalir.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        LimpiarControles(Me)
        ColorearBusqueda(False, txtRazonSocial)
        EnableCmd(True, cmdGrabar)
        cmdSalir.Text = "&CANCELAR"
        txtRazonSocial.Select()
        editar = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        visRepProveedor.db = True
        If sucursal = "ZOO" Then
            visRepProveedor.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepProveedor.MdiParent = frmMainKSC
        End If
        visRepProveedor.Show()
    End Sub
End Class