Imports System.Windows.Forms


Public Class frmMain
    Private m_ChildFormNumber As Integer

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Dispose()
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New Globalization.CultureInfo("es-ES")
        r.NumberFormat.CurrencyDecimalSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = r
        Me.ShowInTaskbar = True
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLocalidades.Close()
        frmLocalidades.MdiParent = Me
        frmLocalidades.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.Close()
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAlumnosInicial.Close()
        frmAlumnosInicial.sucursal = "ZOO"
        frmAlumnosInicial.MdiParent = Me
        frmAlumnosInicial.Show()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmMaterias.Close()
        frmMaterias.sucursal = "ZOO"
        frmMaterias.MdiParent = Me
        frmMaterias.Show()
    End Sub

    Private Sub RetirosAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmRetiroAlumnos.Close()
        frmRetiroAlumnos.sucursal = "ZOO"
        frmRetiroAlumnos.MdiParent = Me
        frmRetiroAlumnos.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        frmProductos.Close()
        frmProductos.sucursal = "ZOO"
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub

    Private Sub InicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicialToolStripMenuItem.Click
        frmAlumnosInicial.Close()
        frmAlumnosInicial.sucursal = "ZOO"
        frmAlumnosInicial.MdiParent = Me
        frmAlumnosInicial.Show()
    End Sub

    Private Sub PrimariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimariaToolStripMenuItem.Click
        frmAlumnosPrimario.Close()
        frmAlumnosPrimario.sucursal = "ZOO"
        frmAlumnosPrimario.MdiParent = Me
        frmAlumnosPrimario.Show()
    End Sub

    Private Sub DocentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocentesToolStripMenuItem.Click
        frmDocentes.Close()
        frmDocentes.sucursal = "ZOO"
        frmDocentes.MdiParent = Me
        frmDocentes.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmVentas.Close()
        frmVentas.MdiParent = Me
        frmVentas.Show()
    End Sub

    Private Sub FacturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarToolStripMenuItem.Click
        frmFacturacionvia1.Close()
        frmFacturacionvia1.sucursal = "ZOO"
        frmFacturacionvia1.MdiParent = Me
        frmFacturacionvia1.Show()
    End Sub

    Private Sub FacturarVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarVía2ToolStripMenuItem.Click
        frmFacturacionvia2.Close()
        frmFacturacionvia2.sucursal = "ZOO"
        frmFacturacionvia2.MdiParent = Me
        frmFacturacionvia2.Show()
    End Sub

    Private Sub VerFacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerFacturasToolStripMenuItem1.Click
        frmBuscarFacturas.Close()
        frmBuscarFacturas.sucursal = "ZOO"
        frmBuscarFacturas.MdiParent = Me
        frmBuscarFacturas.Show()
    End Sub

    Private Sub VerFacturasVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFacturasVía2ToolStripMenuItem.Click
        frmBuscarFacturas2.Close()
        frmBuscarFacturas2.sucursal = "ZOO"
        frmBuscarFacturas2.MdiParent = Me
        frmBuscarFacturas2.Show()
    End Sub

    Private Sub AlumnosPorGradoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlumnosPorGradoToolStripMenuItem1.Click
        frmAlumnosXCurso.Close()
        frmAlumnosXCurso.db = True
        frmAlumnosXCurso.MdiParent = Me
        frmAlumnosXCurso.Show()
    End Sub

    Private Sub AlumnosPorSalaVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorSalaVía2ToolStripMenuItem.Click
        frmAlumnosXCurso.Close()
        frmAlumnosXCurso.db = False
        frmAlumnosXCurso.MdiParent = Me
        frmAlumnosXCurso.Show()
    End Sub

    Private Sub AlumnosPorNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorNivelToolStripMenuItem.Click
        frmAlumnosXNivel.Close()
        frmAlumnosXNivel.MdiParent = Me
        frmAlumnosXNivel.Show()
    End Sub

    Private Sub MaternalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaternalToolStripMenuItem.Click
        frmAlumnosMaternal.Close()
        frmAlumnosMaternal.sucursal = "ZOO"
        frmAlumnosMaternal.MdiParent = Me
        frmAlumnosMaternal.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem.Click
        frmVencimientos.Close()
        frmVencimientos.MdiParent = Me
        frmVencimientos.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem.Click
        frmCuentas.Close()
        frmCuentas.MdiParent = Me
        frmCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem.Click
        frmCuentas2.Close()
        frmCuentas2.MdiParent = Me
        frmCuentas2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem1.Click
        frmServicios.Close()
        frmServicios.MdiParent = Me
        frmServicios.sucursal = "ZOO"
        frmServicios.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem1.Click
        frmServicios2.Close()
        frmServicios2.MdiParent = Me
        frmServicios2.sucursal = "ZOO"
        frmServicios2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem2.Click
        frmDevengaciones.Close()
        frmDevengaciones.MdiParent = Me
        frmDevengaciones.sucursal = "ZOO"
        frmDevengaciones.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem2.Click
        frmDevengaciones2.Close()
        frmDevengaciones2.MdiParent = Me
        frmDevengaciones2.sucursal = "ZOO"
        frmDevengaciones2.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmBusquedaGastos.Close()
        frmBusquedaGastos.db = True
        frmBusquedaGastos.sucursal = "ZOO"
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub GastosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmBusquedaGastos.Close()
        frmBusquedaGastos.db = False
        frmBusquedaGastos.sucursal = "ZOO"
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub INgresosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.db = True
        frmBusquedaIngresos.sucursal = "ZOO"
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub IngresosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.db = False
        frmBusquedaIngresos.sucursal = "ZOO"
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub DeudaPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaPorAlumnoToolStripMenuItem.Click
        frmBusquedaDeudaAlumnosvia1.Close()
        frmBusquedaDeudaAlumnosvia1.sucursal = "ZOO"
        frmBusquedaDeudaAlumnosvia1.MdiParent = Me
        frmBusquedaDeudaAlumnosvia1.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem7.Click
        frmBusquedaDeudaCursovia1.Close()
        frmBusquedaDeudaCursovia1.sucursal = "ZOO"
        frmBusquedaDeudaCursovia1.MdiParent = Me
        frmBusquedaDeudaCursovia1.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem7.Click
        frmBusquedaDeudaCursovia2.Close()
        frmBusquedaDeudaCursovia2.sucursal = "ZOO"
        frmBusquedaDeudaCursovia2.MdiParent = Me
        frmBusquedaDeudaCursovia2.Show()
    End Sub

    Private Sub PagosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosVía1ToolStripMenuItem.Click
        frmPagosvia1.Close()
        frmPagosvia1.sucursal = "ZOO"
        frmPagosvia1.MdiParent = Me
        frmPagosvia1.Show()
    End Sub

    Private Sub PagosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosVía2ToolStripMenuItem.Click
        frmPagosvia2.Close()
        frmPagosvia2.sucursal = "ZOO"
        frmPagosvia2.MdiParent = Me
        frmPagosvia2.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'se reportaran solo los productos
        visRepServicios.Close()
        visRepServicios.tipo = 1
        visRepServicios.sucursal = "ZOO"
        visRepServicios.MdiParent = Me
        visRepServicios.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem3.Click
        frmDevengacionXCurso.Close()
        frmDevengacionXCurso.sucursal = "ZOO"
        frmDevengacionXCurso.MdiParent = Me
        frmDevengacionXCurso.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem3.Click
        frmDevengacionXCursovia2.Close()
        frmDevengacionXCursovia2.MdiParent = Me
        frmDevengacionXCursovia2.sucursal = "ZOO"
        frmDevengacionXCursovia2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem4.Click
        frmDatosNegocio.Close()
        frmDatosNegocio.MdiParent = Me
        frmDatosNegocio.sucursal = "ZOO"
        frmDatosNegocio.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem4.Click
        frmDatosNegociovia2.Close()
        frmDatosNegociovia2.MdiParent = Me
        frmDatosNegociovia2.sucursal = "ZOO"
        frmDatosNegociovia2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem5.Click
        frmCursos.Close()
        frmCursos.MdiParent = Me
        frmCursos.sucursal = "ZOO"
        frmCursos.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem5.Click
        frmCursosvia2.Close()
        frmCursosvia2.MdiParent = Me
        frmCursosvia2.sucursal = "ZOO"
        frmCursosvia2.Show()
    End Sub

    Private Sub PagoMisCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoMisCuentasToolStripMenuItem.Click
        visRepPagoMisCuentas.Close()
        visRepPagoMisCuentas.MdiParent = Me
        visRepPagoMisCuentas.Show()
    End Sub

    Private Sub AnularDevengacionVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularDevengacionVía1ToolStripMenuItem.Click
        frmBuscarADevengacionesvia1.Close()
        frmBuscarADevengacionesvia1.MdiParent = Me
        frmBuscarADevengacionesvia1.sucursal = "ZOO"
        frmBuscarADevengacionesvia1.Show()
    End Sub

    Private Sub AnularDevengaciónVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularDevengaciónVía2ToolStripMenuItem.Click
        frmBuscarADevengacionesvia2.Close()
        frmBuscarADevengacionesvia2.MdiParent = Me
        frmBuscarADevengacionesvia2.sucursal = "ZOO"
        frmBuscarADevengacionesvia2.Show()
    End Sub

    Private Sub TodosLosNivelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosNivelesToolStripMenuItem.Click
        frmAlumnosTodos.Close()
        frmAlumnosTodos.MdiParent = Me
        frmAlumnosTodos.sucursal = "ZOO"
        frmAlumnosTodos.Show()
    End Sub

    Private Sub AlumnosPorSalaConBecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorSalaConBecaToolStripMenuItem.Click
        frmAlumnosXCursoBeca.Close()
        frmAlumnosXCursoBeca.MdiParent = Me
        frmAlumnosXCursoBeca.sucursal = "ZOO"
        frmAlumnosXCursoBeca.Show()
    End Sub

    Private Sub FacturacionPorSalaVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionPorSalaVía1ToolStripMenuItem.Click
        frmFacturacionXCurso.Close()
        frmFacturacionXCurso.MdiParent = Me
        frmFacturacionXCurso.sucursal = "ZOO"
        frmFacturacionXCurso.Show()
    End Sub

    Private Sub FEAFIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEAFIPToolStripMenuItem.Click
        frmBuscarFEAFIP.Close()
        frmBuscarFEAFIP.MdiParent = Me
        frmBuscarFEAFIP.Show()
    End Sub

    Private Sub ManualDeUsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsoToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/1XDXe08X3XgB4xhF0YaPV_GOtRwMCAxbqK-dZQs93MU4/pub")
    End Sub

    Private Sub AnularFacturaVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFacturaVía1ToolStripMenuItem.Click
        frmBuscarAFacturasvia1.Close()
        frmBuscarAFacturasvia1.MdiParent = Me
        frmBuscarAFacturasvia1.sucursal = "ZOO"
        frmBuscarAFacturasvia1.Show()
    End Sub

    Private Sub AnularFacturaVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFacturaVía2ToolStripMenuItem.Click
        frmBuscarAFacturasvia2.Close()
        frmBuscarAFacturasvia2.MdiParent = Me
        frmBuscarAFacturasvia2.sucursal = "ZOO"
        frmBuscarAFacturasvia2.Show()
    End Sub

    Private Sub AlumnosPorGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorGradoToolStripMenuItem.Click
        frmAlumnosXGrado.Close()
        frmAlumnosXGrado.MdiParent = Me
        frmAlumnosXGrado.sucursal = "ZOO"
        frmAlumnosXGrado.Show()
    End Sub

    Private Sub AlumnosPorGadoConBecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorGadoConBecaToolStripMenuItem.Click
        frmAlumnosXGradoBeca.Close()
        frmAlumnosXGradoBeca.MdiParent = Me
        frmAlumnosXGradoBeca.sucursal = "ZOO"
        frmAlumnosXGradoBeca.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem6.Click
        frmPaseCuentas.Close()
        frmPaseCuentas.db = True
        frmPaseCuentas.MdiParent = Me
        frmPaseCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem6.Click
        frmPaseCuentas.Close()
        frmPaseCuentas.db = False
        frmPaseCuentas.MdiParent = Me
        frmPaseCuentas.Show()
    End Sub

    Private Sub ZooGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZooGlobalToolStripMenuItem.Click
        frmArqueoCajaGlobal.Close()
        frmArqueoCajaGlobal.sucursal = "ZOO"
        frmArqueoCajaGlobal.MdiParent = Me
        frmArqueoCajaGlobal.Show()
    End Sub

    Private Sub KSCVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KSCVía2ToolStripMenuItem.Click
        frmArqueoCajaGlobal.Close()
        frmArqueoCajaGlobal.sucursal = "ZOO"
        frmArqueoCajaGlobal.MdiParent = Me
        frmArqueoCajaGlobal.Show()
    End Sub

    Private Sub AnularPagosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularPagosVía1ToolStripMenuItem.Click
        frmBuscarAGastoVia1.MdiParent = Me
        frmBuscarAGastoVia1.sucursal = "ZOO"
        frmBuscarAGastoVia1.Show()
    End Sub

    Private Sub AnularPagosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularPagosVía2ToolStripMenuItem.Click
        frmBuscarAGastoVia2.MdiParent = Me
        frmBuscarAGastoVia2.sucursal = "ZOO"
        frmBuscarAGastoVia2.Show()
    End Sub

    Private Sub CambiarDevengacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDevengacionesToolStripMenuItem.Click
        frmBuscarCDevengacionesvia2.MdiParent = Me
        frmBuscarCDevengacionesvia2.sucursal = "ZOO"
        frmBuscarCDevengacionesvia2.Show()
    End Sub

    Private Sub ActasCompromisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasCompromisoToolStripMenuItem.Click
        frmActasCompromiso.MdiParent = Me
        frmActasCompromiso.sucursal = "ZOO"
        frmActasCompromiso.Show()
    End Sub

    Private Sub ReimpresiónDeFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresiónDeFacturasToolStripMenuItem.Click
        frmReimpresionFacturas.bd = True
        frmReimpresionFacturas.sucursal = "ZOO"
        frmReimpresionFacturas.MdiParent = Me
        frmReimpresionFacturas.Show()
    End Sub

    Private Sub Global2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Global2ToolStripMenuItem.Click
        frmArqueoCajaGlobal2.MdiParent = Me
        frmArqueoCajaGlobal2.Show()
    End Sub

    Private Sub GastosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosVía1ToolStripMenuItem.Click
        frmBusquedaGastos.Close()
        frmBusquedaGastos.db = True
        frmBusquedaGastos.sucursal = "ZOO"
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub GastosVía2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosVía2ToolStripMenuItem1.Click
        frmBusquedaGastos.Close()
        frmBusquedaGastos.db = False
        frmBusquedaGastos.sucursal = "ZOO"
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub GastosXProveedorVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosXProveedorVía1ToolStripMenuItem.Click
        frmBusquedaGastosProveedor.Close()
        frmBusquedaGastosProveedor.db = True
        frmBusquedaGastosProveedor.sucursal = "ZOO"
        frmBusquedaGastosProveedor.MdiParent = Me
        frmBusquedaGastosProveedor.Show()
    End Sub

    Private Sub GastosXProveedorVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosXProveedorVía2ToolStripMenuItem.Click
        frmBusquedaGastosProveedor.Close()
        frmBusquedaGastosProveedor.db = False
        frmBusquedaGastosProveedor.sucursal = "ZOO"
        frmBusquedaGastosProveedor.MdiParent = Me
        frmBusquedaGastosProveedor.Show()
    End Sub

    Private Sub PagoMisCuentas2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoMisCuentas2ToolStripMenuItem.Click
        frmBusquedaPagoMisCuentas.Close()
        frmBusquedaPagoMisCuentas.sucursal = "ZOO"
        frmBusquedaPagoMisCuentas.db = True
        frmBusquedaPagoMisCuentas.MdiParent = Me
        frmBusquedaPagoMisCuentas.Show()
    End Sub

    Private Sub DevengacionesAlumnosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevengacionesAlumnosVía1ToolStripMenuItem.Click
        visRepDevengacionesAlumnos.Close()
        visRepDevengacionesAlumnos.bd = True
        visRepDevengacionesAlumnos.MdiParent = Me
        visRepDevengacionesAlumnos.Show()
    End Sub

    Private Sub DevengacionesAlumnosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevengacionesAlumnosVía2ToolStripMenuItem.Click
        visRepDevengacionesAlumnos.Close()
        visRepDevengacionesAlumnos.bd = False
        visRepDevengacionesAlumnos.MdiParent = Me
        visRepDevengacionesAlumnos.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem5.Click
        frmBuscarDevengacionesvia2.Close()
        frmBuscarDevengacionesvia2.MdiParent = Me
        frmBuscarDevengacionesvia2.sucursal = "ZOO"
        frmBuscarDevengacionesvia2.cantidadVencimientos = 3
        frmBuscarDevengacionesvia2.Show()
    End Sub

    Private Sub VencimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VencimientoToolStripMenuItem.Click
        frmBuscarDevengacionesvia2.Close()
        frmBuscarDevengacionesvia2.MdiParent = Me
        frmBuscarDevengacionesvia2.sucursal = "ZOO"
        frmBuscarDevengacionesvia2.cantidadVencimientos = 1
        frmBuscarDevengacionesvia2.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem4.Click
        frmBuscarDevengacionesvia2.Close()
        frmBuscarDevengacionesvia2.MdiParent = Me
        frmBuscarDevengacionesvia2.sucursal = "ZOO"
        frmBuscarDevengacionesvia2.cantidadVencimientos = 2
        frmBuscarDevengacionesvia2.Show()
    End Sub

    Private Sub SinVencimientosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SinVencimientosToolStripMenuItem1.Click
        frmBuscarDevengacionesvia2.Close()
        frmBuscarDevengacionesvia2.MdiParent = Me
        frmBuscarDevengacionesvia2.sucursal = "ZOO"
        frmBuscarDevengacionesvia2.cantidadVencimientos = 0
        frmBuscarDevengacionesvia2.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem3.Click
        frmBuscarDevengacionesvia1.Close()
        frmBuscarDevengacionesvia1.MdiParent = Me
        frmBuscarDevengacionesvia1.sucursal = "ZOO"
        frmBuscarDevengacionesvia1.cantidadVencimientos = 3
        frmBuscarDevengacionesvia1.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem1.Click
        frmBuscarDevengacionesvia1.Close()
        frmBuscarDevengacionesvia1.MdiParent = Me
        frmBuscarDevengacionesvia1.sucursal = "ZOO"
        frmBuscarDevengacionesvia1.cantidadVencimientos = 1
        frmBuscarDevengacionesvia1.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VencimientosToolStripMenuItem2.Click
        frmBuscarDevengacionesvia1.Close()
        frmBuscarDevengacionesvia1.MdiParent = Me
        frmBuscarDevengacionesvia1.sucursal = "ZOO"
        frmBuscarDevengacionesvia1.cantidadVencimientos = 2
        frmBuscarDevengacionesvia1.Show()
    End Sub

    Private Sub SinVencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinVencimientosToolStripMenuItem.Click
        frmBuscarDevengacionesvia1.Close()
        frmBuscarDevengacionesvia1.MdiParent = Me
        frmBuscarDevengacionesvia1.sucursal = "ZOO"
        frmBuscarDevengacionesvia1.cantidadVencimientos = 0
        frmBuscarDevengacionesvia1.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem8.Click
        visRepDeudaGeneral.Close()
        visRepDeudaGeneral.bd = True
        visRepDeudaGeneral.MdiParent = Me
        visRepDeudaGeneral.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem8.Click
        visRepDeudaGeneral.Close()
        visRepDeudaGeneral.bd = False
        visRepDeudaGeneral.MdiParent = Me
        visRepDeudaGeneral.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem9.Click
        frmBuscarMovimientos.Close()
        frmBuscarMovimientos.bd = True
        frmBuscarMovimientos.sucursal = "ZOO"
        frmBuscarMovimientos.MdiParent = Me
        frmBuscarMovimientos.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem9.Click
        frmBuscarMovimientos.Close()
        frmBuscarMovimientos.bd = False
        frmBuscarMovimientos.sucursal = "ZOO"
        frmBuscarMovimientos.MdiParent = Me
        frmBuscarMovimientos.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem10.Click
        frmPaseEntreCuentas.Close()
        frmPaseEntreCuentas.MdiParent = Me
        frmPaseEntreCuentas.bd = True
        frmPaseEntreCuentas.sucursal = "ZOO"
        frmPaseEntreCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem10.Click
        frmPaseEntreCuentas.Close()
        frmPaseEntreCuentas.MdiParent = Me
        frmPaseEntreCuentas.bd = False
        frmPaseEntreCuentas.sucursal = "ZOO"
        frmPaseEntreCuentas.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem11.Click
        frmBusquedaEstadoCuenta.Close()
        frmBusquedaEstadoCuenta.sucursal = "ZOO"
        frmBusquedaEstadoCuenta.MdiParent = Me
        frmBusquedaEstadoCuenta.bd = True
        frmBusquedaEstadoCuenta.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem11.Click
        frmBusquedaEstadoCuenta.Close()
        frmBusquedaEstadoCuenta.sucursal = "ZOO"
        frmBusquedaEstadoCuenta.bd = False
        frmBusquedaEstadoCuenta.MdiParent = Me
        frmBusquedaEstadoCuenta.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem12.Click
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.db = True
        frmBusquedaIngresos.sucursal = "ZOO"
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem12.Click
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.db = False
        frmBusquedaIngresos.sucursal = "ZOO"
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem13.Click
        visRepCuentas.Close()
        visRepCuentas.via = "Vía 1"
        visRepCuentas.sucursal = "ZOO"
        visRepCuentas.bd = True
        visRepCuentas.MdiParent = Me
        visRepCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem13.Click
        visRepCuentas.Close()
        visRepCuentas.via = "Vía 2"
        visRepCuentas.sucursal = "ZOO"
        visRepCuentas.bd = False
        visRepCuentas.MdiParent = Me
        visRepCuentas.Show()
    End Sub

    Private Sub LegajosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LegajosToolStripMenuItem.Click
        frmLegajos.Close()
        frmLegajos.MdiParent = Me
        frmLegajos.Show()
    End Sub
End Class