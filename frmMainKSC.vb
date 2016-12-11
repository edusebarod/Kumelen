Imports System.Windows.Forms


Public Class frmMainKSC
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

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUsuarios.Close()
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAlumnosInicial.Close()
        frmAlumnosInicial.sucursal = "KSC"
        frmAlumnosInicial.MdiParent = Me
        frmAlumnosInicial.Show()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmMaterias.Close()
        frmMaterias.sucursal = "KSC"
        frmMaterias.MdiParent = Me
        frmMaterias.Show()
    End Sub

    Private Sub RetirosAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmRetiroAlumnos.Close()
        frmRetiroAlumnos.sucursal = "KSC"
        frmRetiroAlumnos.MdiParent = Me
        frmRetiroAlumnos.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        frmProductos.Close()
        frmProductos.sucursal = "KSC"
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub

    Private Sub InicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicialToolStripMenuItem.Click
        frmAlumnosInicial.Close()
        frmAlumnosInicial.sucursal = "KSC"
        frmAlumnosInicial.MdiParent = Me
        frmAlumnosInicial.Show()
    End Sub

    Private Sub PrimariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimariaToolStripMenuItem.Click
        frmAlumnosPrimario.Close()
        frmAlumnosPrimario.sucursal = "KSC"
        frmAlumnosPrimario.MdiParent = Me
        frmAlumnosPrimario.Show()
    End Sub

    Private Sub DocentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocentesToolStripMenuItem.Click
        frmDocentes.Close()
        frmDocentes.sucursal = "KSC"
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
        frmFacturacionvia1.sucursal = "KSC"
        frmFacturacionvia1.MdiParent = Me
        frmFacturacionvia1.Show()
    End Sub

    Private Sub FacturarVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturarVía2ToolStripMenuItem.Click
        frmFacturacionvia2.Close()
        frmFacturacionvia2.sucursal = "KSC"
        frmFacturacionvia2.MdiParent = Me
        frmFacturacionvia2.Show()
    End Sub

    Private Sub VerFacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerFacturasToolStripMenuItem1.Click
        frmBuscarFacturas.Close()
        frmBuscarFacturas.sucursal = "KSC"
        frmBuscarFacturas.MdiParent = Me
        frmBuscarFacturas.Show()
    End Sub

    Private Sub VerFacturasVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFacturasVía2ToolStripMenuItem.Click
        frmBuscarFacturas2.Close()
        frmBuscarFacturas.sucursal = "KSC"
        frmBuscarFacturas2.MdiParent = Me
        frmBuscarFacturas2.Show()
    End Sub

    Private Sub AlumnosPorGradoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlumnosPorGradoToolStripMenuItem1.Click
        frmAlumnosXCurso.Close()
        frmAlumnosXCurso.sucursal = "KSC"
        frmAlumnosXCurso.MdiParent = Me
        frmAlumnosXCurso.Show()
    End Sub

    Private Sub AlumnosPorNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorNivelToolStripMenuItem.Click
        frmAlumnosXNivel.Close()
        frmAlumnosXNivel.sucursal = "KSC"
        frmAlumnosXNivel.MdiParent = Me
        frmAlumnosXNivel.Show()
    End Sub

    Private Sub MaternalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaternalToolStripMenuItem.Click
        frmAlumnosMaternal.Close()
        frmAlumnosMaternal.sucursal = "KSC"
        frmAlumnosMaternal.MdiParent = Me
        frmAlumnosMaternal.Show()
    End Sub

    Private Sub VencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmVencimientos.Close()
        frmVencimientos.MdiParent = Me
        frmVencimientos.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmCuentas.Close()
        frmCuentas.MdiParent = Me
        frmCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmCuentas2.Close()
        frmCuentas2.MdiParent = Me
        frmCuentas2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmServicios.Close()
        frmServicios.sucursal = "KSC"
        frmServicios.MdiParent = Me
        frmServicios.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmServicios2.Close()
        frmServicios2.sucursal = "KSC"
        frmServicios2.MdiParent = Me
        frmServicios2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem2.Click
        frmDevengaciones.Close()
        frmDevengaciones.sucursal = "KSC"
        frmDevengaciones.MdiParent = Me
        frmDevengaciones.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem2.Click
        frmDevengaciones2.Close()
        frmDevengaciones2.sucursal = "KSC"
        frmDevengaciones2.MdiParent = Me
        frmDevengaciones2.Show()
    End Sub

    Private Sub VerDevengacionesVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDevengacionesVía1ToolStripMenuItem.Click
        frmBuscarDevengacionesvia1.Close()
        frmBuscarDevengacionesvia1.sucursal = "KSC"
        frmBuscarDevengacionesvia1.MdiParent = Me
        frmBuscarDevengacionesvia1.Show()
    End Sub

    Private Sub VerDevengacionesVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDevengacionesVía2ToolStripMenuItem.Click
        frmBuscarDevengacionesvia2.Close()
        frmBuscarDevengacionesvia2.sucursal = "KSC"
        frmBuscarDevengacionesvia2.MdiParent = Me
        frmBuscarDevengacionesvia2.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        frmBusquedaGastos.Close()
        frmBusquedaGastos.sucursal = "KSC"
        frmBusquedaGastos.db = True
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub GastosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosVía2ToolStripMenuItem.Click
        frmBusquedaGastos.Close()
        frmBusquedaGastos.sucursal = "KSC"
        frmBusquedaGastos.db = False
        frmBusquedaGastos.MdiParent = Me
        frmBusquedaGastos.Show()
    End Sub

    Private Sub INgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INgresosToolStripMenuItem.Click
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.sucursal = "KSC"
        frmBusquedaIngresos.db = True
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub IngresosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosVía2ToolStripMenuItem.Click
        frmBusquedaIngresos.Close()
        frmBusquedaIngresos.sucursal = "KSC"
        frmBusquedaIngresos.db = False
        frmBusquedaIngresos.MdiParent = Me
        frmBusquedaIngresos.Show()
    End Sub

    Private Sub DeudasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudasToolStripMenuItem.Click
        frmBusquedaEstadoCuenta.Close()
        frmBusquedaEstadoCuenta.sucursal = "KSC"
        frmBusquedaEstadoCuenta.MdiParent = Me
        frmBusquedaEstadoCuenta.bd = True
        frmBusquedaEstadoCuenta.Show()
    End Sub

    Private Sub EstadoDeCuentaVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeCuentaVía2ToolStripMenuItem.Click
        frmBusquedaEstadoCuenta.Close()
        frmBusquedaEstadoCuenta.sucursal = "KSC"
        frmBusquedaEstadoCuenta.bd = False
        frmBusquedaEstadoCuenta.MdiParent = Me
        frmBusquedaEstadoCuenta.Show()
    End Sub

    Private Sub DeudaPorAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaPorAlumnoToolStripMenuItem.Click
        frmBusquedaDeudaAlumnosvia1.Close()
        frmBusquedaDeudaAlumnosvia1.sucursal = "KSC"
        frmBusquedaDeudaAlumnosvia1.MdiParent = Me
        frmBusquedaDeudaAlumnosvia1.Show()
    End Sub

    Private Sub PagosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosVía1ToolStripMenuItem.Click
        frmPagosvia1.Close()
        frmPagosvia1.sucursal = "KSC"
        frmPagosvia1.MdiParent = Me
        frmPagosvia1.Show()
    End Sub

    Private Sub PagosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosVía2ToolStripMenuItem.Click
        frmPagosvia2.Close()
        frmPagosvia2.sucursal = "KSC"
        frmPagosvia2.MdiParent = Me
        frmPagosvia2.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'se reportaran solo los productos
        visRepServicios.Close()
        visRepServicios.sucursal = "KSC"
        visRepServicios.tipo = 1
        visRepServicios.MdiParent = Me
        visRepServicios.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem3.Click
        frmDevengacionXCurso.Close()
        frmDevengacionXCurso.sucursal = "KSC"
        frmDevengacionXCurso.MdiParent = Me
        frmDevengacionXCurso.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem3.Click
        frmDevengacionXCursovia2.Close()
        frmDevengacionXCursovia2.MdiParent = Me
        frmDevengacionXCursovia2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem4.Click
        frmDatosNegocio.Close()
        frmDatosNegocio.sucursal = "KSC"
        frmDatosNegocio.MdiParent = Me
        frmDatosNegocio.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem4.Click
        frmDatosNegociovia2.Close()
        frmDatosNegociovia2.sucursal = "KSC"
        frmDatosNegociovia2.MdiParent = Me
        frmDatosNegociovia2.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Vía1ToolStripMenuItem5.Click
        frmCursos.Close()
        frmCursos.sucursal = "KSC"
        frmCursos.MdiParent = Me
        frmCursos.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles Vía2ToolStripMenuItem5.Click
        frmCursosvia2.Close()
        frmCursosvia2.sucursal = "KSC"
        frmCursosvia2.MdiParent = Me
        frmCursosvia2.Show()
    End Sub

    Private Sub PagoMisCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoMisCuentasToolStripMenuItem.Click
        visRepPagoMisCuentas.Close()
        visRepPagoMisCuentas.MdiParent = Me
        visRepPagoMisCuentas.Show()
    End Sub

    Private Sub AnularDevengacionVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularDevengacionVía1ToolStripMenuItem.Click
        frmBuscarADevengacionesvia1.Close()
        frmBuscarADevengacionesvia1.sucursal = "KSC"
        frmBuscarADevengacionesvia1.MdiParent = Me
        frmBuscarADevengacionesvia1.Show()
    End Sub

    Private Sub AnularDevengaciónVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularDevengaciónVía2ToolStripMenuItem.Click
        frmBuscarADevengacionesvia2.Close()
        frmBuscarADevengacionesvia2.sucursal = "KSC"
        frmBuscarADevengacionesvia2.MdiParent = Me
        frmBuscarADevengacionesvia2.Show()
    End Sub

    Private Sub TodosLosNivelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosNivelesToolStripMenuItem.Click
        frmAlumnosTodos.Close()
        frmAlumnosTodos.MdiParent = Me
        frmAlumnosTodos.Show()
    End Sub

    Private Sub AlumnosPorSalaConBecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorSalaConBecaToolStripMenuItem.Click
        frmAlumnosXCursoBeca.Close()
        frmAlumnosXCursoBeca.sucursal = "KSC"
        frmAlumnosXCursoBeca.MdiParent = Me
        frmAlumnosXCursoBeca.Show()
    End Sub

    Private Sub FacturacionPorSalaVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionPorSalaVía1ToolStripMenuItem.Click
        frmFacturacionXCurso.Close()
        frmFacturacionXCurso.sucursal = "KSC"
        frmFacturacionXCurso.MdiParent = Me
        frmFacturacionXCurso.Show()
    End Sub

    Private Sub FEAFIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FEAFIPToolStripMenuItem.Click
        frmBuscarFEAFIP.Close()
        frmBuscarFEAFIP.MdiParent = Me
        frmBuscarFEAFIP.Show()
    End Sub

    Private Sub PlanDeCuenctasVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDeCuenctasVía1ToolStripMenuItem.Click
        visRepCuentas.Close()
        visRepCuentas.via = "Vía 1"
        visRepCuentas.sucursal = "KSC"
        visRepCuentas.bd = True
        visRepCuentas.MdiParent = Me
        visRepCuentas.Show()
    End Sub

    Private Sub PlanDeCuentasVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDeCuentasVía2ToolStripMenuItem.Click
        visRepCuentas.Close()
        visRepCuentas.via = "Vía 2"
        visRepCuentas.sucursal = "KSC"
        visRepCuentas.bd = False
        visRepCuentas.MdiParent = Me
        visRepCuentas.Show()
    End Sub

    Private Sub ManualDeUsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsoToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/document/d/1XDXe08X3XgB4xhF0YaPV_GOtRwMCAxbqK-dZQs93MU4/pub")
    End Sub

    Private Sub AnularFacturaVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFacturaVía1ToolStripMenuItem.Click
        frmBuscarAFacturasvia1.Close()
        frmBuscarAFacturasvia1.sucursal = "KSC"
        frmBuscarAFacturasvia1.MdiParent = Me
        frmBuscarAFacturasvia1.Show()
    End Sub

    Private Sub AnularFacturaVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularFacturaVía2ToolStripMenuItem.Click
        frmBuscarAFacturasvia2.Close()
        frmBuscarAFacturasvia2.sucursal = "KSC"
        frmBuscarAFacturasvia2.MdiParent = Me
        frmBuscarAFacturasvia2.Show()
    End Sub

    Private Sub AlumnosPorGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorGradoToolStripMenuItem.Click
        frmAlumnosXGrado.Close()
        frmAlumnosXGrado.sucursal = "KSC"
        frmAlumnosXGrado.MdiParent = Me
        frmAlumnosXGrado.Show()
    End Sub

    Private Sub AlumnosPorGadoConBecaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosPorGadoConBecaToolStripMenuItem.Click
        frmAlumnosXGradoBeca.Close()
        frmAlumnosXGradoBeca.sucursal = "KSC"
        frmAlumnosXGradoBeca.MdiParent = Me
        frmAlumnosXGradoBeca.Show()
    End Sub

    Private Sub Vía1ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        frmPaseCuentas.Close()
        frmPaseCuentas.db = True
        frmPaseCuentas.MdiParent = Me
        frmPaseCuentas.Show()
    End Sub

    Private Sub Vía2ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        frmPaseCuentas.Close()
        frmPaseCuentas.db = False
        frmPaseCuentas.MdiParent = Me
        frmPaseCuentas.Show()
    End Sub

    Private Sub ZooGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmArqueoCajaGlobal.Close()
        frmArqueoCajaGlobal.sucursal = "ZOO"
        frmArqueoCajaGlobal.MdiParent = Me
        frmArqueoCajaGlobal.Show()
    End Sub

    Private Sub KSCVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KSCVía2ToolStripMenuItem.Click
        frmArqueoCajaGlobal.Close()
        frmArqueoCajaGlobal.sucursal = "KSC"
        frmArqueoCajaGlobal.MdiParent = Me
        frmArqueoCajaGlobal.Show()
    End Sub

    Private Sub AnularPagosVía1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularPagosVía1ToolStripMenuItem.Click
        frmBuscarAGastoVia1.MdiParent = Me
        frmBuscarAGastoVia1.sucursal = "KSC"
        frmBuscarAGastoVia1.Show()
    End Sub

    Private Sub AnularPagosVía2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularPagosVía2ToolStripMenuItem.Click
        frmBuscarAGastoVia2.MdiParent = Me
        frmBuscarAGastoVia2.sucursal = "KSC"
        frmBuscarAGastoVia2.Show()
    End Sub

    Private Sub CambiarDevengacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDevengacionesToolStripMenuItem.Click
        frmBuscarCDevengacionesvia2.MdiParent = Me
        frmBuscarCDevengacionesvia2.sucursal = "KSC"
        frmBuscarCDevengacionesvia2.Show()
    End Sub

    Private Sub ActasCompromisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasCompromisoToolStripMenuItem.Click
        frmActasCompromiso.MdiParent = Me
        frmActasCompromiso.sucursal = "KSC"
        frmActasCompromiso.Show()
    End Sub

    Private Sub ReimpresiónDeFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresiónDeFacturasToolStripMenuItem.Click
        frmReimpresionFacturas.bd = True
        frmReimpresionFacturas.sucursal = "KSC"
        frmReimpresionFacturas.MdiParent = Me
        frmReimpresionFacturas.Show()
    End Sub

    Private Sub Global2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmArqueoCajaGlobal2.MdiParent = Me
        frmArqueoCajaGlobal2.Show()
    End Sub
End Class