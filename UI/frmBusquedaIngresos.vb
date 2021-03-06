﻿Public Class frmBusquedaIngresos
    Public repoFact As New RepoFacturacion
    Public db As Boolean
    Public sucursal As String

    Private Sub frmBuscarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearControles(Me)
        ColorearFRM(Me)
        CargarServicios()
        CargarCuentas()
    End Sub

    Private Sub CargarServicios()
        DS = repoFact.Servicios(db)
        ' asignar el DataSource al combobox
        cbxServicio.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxServicio.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub CargarCuentas()
        DS = repoFact.Cuentas_Estado()
        ' asignar el DataSource al combobox
        cbxCuentas.DataSource = DS.Tables(0)
        ' Asignar el campo a la propiedad DisplayMember del combo   
        cbxCuentas.DisplayMember = DS.Tables(0).Columns(1).Caption.ToString
    End Sub

    Private Sub txtFEchaFinal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaFinal.KeyPress
        If txtFechaFinal.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnFecha.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_Fecha_Click(sender As Object, e As EventArgs) Handles btnFecha.Click
        visRepIngresosFecha.fecha1 = txtFechaInicial.Value.ToString("yyyy-MM-dd")
        visRepIngresosFecha.fecha2 = txtFechaFinal.Value.ToString("yyyy-MM-dd")
        visRepIngresosFecha.bd = db
        If sucursal = "ZOO" Then
            visRepIngresosFecha.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepIngresosFecha.MdiParent = frmMainKSC
        End If
        visRepIngresosFecha.Show()
    End Sub

    Private Sub txtFEchaFinal2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaFinal2.KeyPress
        If txtFechaFinal2.Text <> "" Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                btnServicio.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        visRepIngresosServicio.fecha1 = txtFecchaInicial2.Value.ToString("yyyy-MM-dd")
        visRepIngresosServicio.fecha2 = txtFechaFinal2.Value.ToString("yyyy-MM-dd")
        visRepIngresosServicio.servicio = cbxServicio.Text
        visRepIngresosServicio.bd = db
        If sucursal = "ZOO" Then
            visRepIngresosServicio.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepIngresosServicio.MdiParent = frmMainKSC
        End If
        visRepIngresosServicio.Show()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        visRepIngresosCuenta.fecha1 = txtFecchaInicial3.Value.ToString("yyyy-MM-dd")
        visRepIngresosCuenta.fecha2 = txtFechaFinal3.Value.ToString("yyyy-MM-dd")
        visRepIngresosCuenta.cuenta = cbxCuentas.Text
        visRepIngresosCuenta.bd = db
        If sucursal = "ZOO" Then
            visRepIngresosCuenta.MdiParent = frmMain
        ElseIf sucursal = "KSC" Then
            visRepIngresosCuenta.MdiParent = frmMainKSC
        End If
        visRepIngresosCuenta.Show()
    End Sub
End Class