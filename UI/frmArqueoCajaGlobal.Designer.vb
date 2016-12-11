<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueoCajaGlobal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArqueoCajaGlobal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDetalleCajaFuerte = New System.Windows.Forms.TextBox()
        Me.lblDetalleCajaFuerte = New System.Windows.Forms.Label()
        Me.txtCajaFuerte = New System.Windows.Forms.TextBox()
        Me.lblCajaFuerte = New System.Windows.Forms.Label()
        Me.txtSobresDetalles = New System.Windows.Forms.TextBox()
        Me.lblSobresDetalles = New System.Windows.Forms.Label()
        Me.txtSobres = New System.Windows.Forms.TextBox()
        Me.lblSobres = New System.Windows.Forms.Label()
        Me.txtDetallesVales = New System.Windows.Forms.TextBox()
        Me.lblValesDetalles = New System.Windows.Forms.Label()
        Me.txtVales = New System.Windows.Forms.TextBox()
        Me.lblVales = New System.Windows.Forms.Label()
        Me.txtExistenciaFisica = New System.Windows.Forms.TextBox()
        Me.lblExistenciaFisica = New System.Windows.Forms.Label()
        Me.txtSaldoVia2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFallodeCaja = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtSaldoVia1 = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.lblDiferencia = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDetalleCajaFuerte)
        Me.GroupBox1.Controls.Add(Me.lblDetalleCajaFuerte)
        Me.GroupBox1.Controls.Add(Me.txtCajaFuerte)
        Me.GroupBox1.Controls.Add(Me.lblCajaFuerte)
        Me.GroupBox1.Controls.Add(Me.txtSobresDetalles)
        Me.GroupBox1.Controls.Add(Me.lblSobresDetalles)
        Me.GroupBox1.Controls.Add(Me.txtSobres)
        Me.GroupBox1.Controls.Add(Me.lblSobres)
        Me.GroupBox1.Controls.Add(Me.txtDetallesVales)
        Me.GroupBox1.Controls.Add(Me.lblValesDetalles)
        Me.GroupBox1.Controls.Add(Me.txtVales)
        Me.GroupBox1.Controls.Add(Me.lblVales)
        Me.GroupBox1.Controls.Add(Me.txtExistenciaFisica)
        Me.GroupBox1.Controls.Add(Me.lblExistenciaFisica)
        Me.GroupBox1.Controls.Add(Me.txtSaldoVia2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFallodeCaja)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtSaldoVia1)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtDiferencia)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtExistencia)
        Me.GroupBox1.Controls.Add(Me.lblDiferencia)
        Me.GroupBox1.Controls.Add(Me.lblExistencia)
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 584)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arqueo de Caja"
        '
        'txtDetalleCajaFuerte
        '
        Me.txtDetalleCajaFuerte.Location = New System.Drawing.Point(91, 409)
        Me.txtDetalleCajaFuerte.Multiline = True
        Me.txtDetalleCajaFuerte.Name = "txtDetalleCajaFuerte"
        Me.txtDetalleCajaFuerte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleCajaFuerte.Size = New System.Drawing.Size(316, 60)
        Me.txtDetalleCajaFuerte.TabIndex = 85
        '
        'lblDetalleCajaFuerte
        '
        Me.lblDetalleCajaFuerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleCajaFuerte.Location = New System.Drawing.Point(9, 409)
        Me.lblDetalleCajaFuerte.Name = "lblDetalleCajaFuerte"
        Me.lblDetalleCajaFuerte.Size = New System.Drawing.Size(75, 60)
        Me.lblDetalleCajaFuerte.TabIndex = 84
        Me.lblDetalleCajaFuerte.Text = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Caja Fuerte"
        '
        'txtCajaFuerte
        '
        Me.txtCajaFuerte.Location = New System.Drawing.Point(91, 382)
        Me.txtCajaFuerte.Name = "txtCajaFuerte"
        Me.txtCajaFuerte.Size = New System.Drawing.Size(142, 20)
        Me.txtCajaFuerte.TabIndex = 83
        '
        'lblCajaFuerte
        '
        Me.lblCajaFuerte.AutoSize = True
        Me.lblCajaFuerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajaFuerte.Location = New System.Drawing.Point(9, 382)
        Me.lblCajaFuerte.Name = "lblCajaFuerte"
        Me.lblCajaFuerte.Size = New System.Drawing.Size(81, 17)
        Me.lblCajaFuerte.TabIndex = 82
        Me.lblCajaFuerte.Text = "Caja Fuerte"
        '
        'txtSobresDetalles
        '
        Me.txtSobresDetalles.Location = New System.Drawing.Point(92, 315)
        Me.txtSobresDetalles.Multiline = True
        Me.txtSobresDetalles.Name = "txtSobresDetalles"
        Me.txtSobresDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSobresDetalles.Size = New System.Drawing.Size(316, 60)
        Me.txtSobresDetalles.TabIndex = 81
        '
        'lblSobresDetalles
        '
        Me.lblSobresDetalles.AutoSize = True
        Me.lblSobresDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobresDetalles.Location = New System.Drawing.Point(10, 315)
        Me.lblSobresDetalles.Name = "lblSobresDetalles"
        Me.lblSobresDetalles.Size = New System.Drawing.Size(73, 34)
        Me.lblSobresDetalles.TabIndex = 80
        Me.lblSobresDetalles.Text = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Sobres"
        '
        'txtSobres
        '
        Me.txtSobres.Location = New System.Drawing.Point(92, 288)
        Me.txtSobres.Name = "txtSobres"
        Me.txtSobres.Size = New System.Drawing.Size(142, 20)
        Me.txtSobres.TabIndex = 79
        '
        'lblSobres
        '
        Me.lblSobres.AutoSize = True
        Me.lblSobres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobres.Location = New System.Drawing.Point(10, 288)
        Me.lblSobres.Name = "lblSobres"
        Me.lblSobres.Size = New System.Drawing.Size(53, 17)
        Me.lblSobres.TabIndex = 78
        Me.lblSobres.Text = "Sobres"
        '
        'txtDetallesVales
        '
        Me.txtDetallesVales.Location = New System.Drawing.Point(92, 224)
        Me.txtDetallesVales.Multiline = True
        Me.txtDetallesVales.Name = "txtDetallesVales"
        Me.txtDetallesVales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesVales.Size = New System.Drawing.Size(316, 60)
        Me.txtDetallesVales.TabIndex = 77
        '
        'lblValesDetalles
        '
        Me.lblValesDetalles.AutoSize = True
        Me.lblValesDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValesDetalles.Location = New System.Drawing.Point(8, 225)
        Me.lblValesDetalles.Name = "lblValesDetalles"
        Me.lblValesDetalles.Size = New System.Drawing.Size(63, 34)
        Me.lblValesDetalles.TabIndex = 76
        Me.lblValesDetalles.Text = "Detalle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Vales"
        '
        'txtVales
        '
        Me.txtVales.Location = New System.Drawing.Point(92, 198)
        Me.txtVales.Name = "txtVales"
        Me.txtVales.Size = New System.Drawing.Size(142, 20)
        Me.txtVales.TabIndex = 75
        '
        'lblVales
        '
        Me.lblVales.AutoSize = True
        Me.lblVales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVales.Location = New System.Drawing.Point(8, 198)
        Me.lblVales.Name = "lblVales"
        Me.lblVales.Size = New System.Drawing.Size(43, 17)
        Me.lblVales.TabIndex = 74
        Me.lblVales.Text = "Vales"
        '
        'txtExistenciaFisica
        '
        Me.txtExistenciaFisica.Location = New System.Drawing.Point(92, 133)
        Me.txtExistenciaFisica.Multiline = True
        Me.txtExistenciaFisica.Name = "txtExistenciaFisica"
        Me.txtExistenciaFisica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExistenciaFisica.Size = New System.Drawing.Size(316, 60)
        Me.txtExistenciaFisica.TabIndex = 73
        '
        'lblExistenciaFisica
        '
        Me.lblExistenciaFisica.AutoSize = True
        Me.lblExistenciaFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistenciaFisica.Location = New System.Drawing.Point(6, 134)
        Me.lblExistenciaFisica.Name = "lblExistenciaFisica"
        Me.lblExistenciaFisica.Size = New System.Drawing.Size(71, 34)
        Me.lblExistenciaFisica.TabIndex = 72
        Me.lblExistenciaFisica.Text = "Existencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Física"
        '
        'txtSaldoVia2
        '
        Me.txtSaldoVia2.Location = New System.Drawing.Point(92, 81)
        Me.txtSaldoVia2.Name = "txtSaldoVia2"
        Me.txtSaldoVia2.Size = New System.Drawing.Size(142, 20)
        Me.txtSaldoVia2.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Saldo Vía 2"
        '
        'btnFallodeCaja
        '
        Me.btnFallodeCaja.Image = CType(resources.GetObject("btnFallodeCaja.Image"), System.Drawing.Image)
        Me.btnFallodeCaja.Location = New System.Drawing.Point(243, 11)
        Me.btnFallodeCaja.Name = "btnFallodeCaja"
        Me.btnFallodeCaja.Size = New System.Drawing.Size(37, 38)
        Me.btnFallodeCaja.TabIndex = 69
        Me.btnFallodeCaja.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = Global.Kumelen.My.Resources.Resources.imprimir
        Me.btn_imprimir.Location = New System.Drawing.Point(362, 64)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(46, 52)
        Me.btn_imprimir.TabIndex = 66
        Me.btn_imprimir.Tag = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnNuevo.Location = New System.Drawing.Point(299, 64)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 52)
        Me.btnNuevo.TabIndex = 68
        Me.btnNuevo.Tag = "Agregar un concepto"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Checked = False
        Me.txtFecha.CustomFormat = "yyyy/MM/dd"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(88, 24)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ShowCheckBox = True
        Me.txtFecha.Size = New System.Drawing.Size(142, 20)
        Me.txtFecha.TabIndex = 67
        Me.txtFecha.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(6, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 20)
        Me.lblFecha.TabIndex = 67
        Me.lblFecha.Text = "Fecha"
        '
        'txtSaldoVia1
        '
        Me.txtSaldoVia1.Location = New System.Drawing.Point(92, 54)
        Me.txtSaldoVia1.Name = "txtSaldoVia1"
        Me.txtSaldoVia1.Size = New System.Drawing.Size(142, 20)
        Me.txtSaldoVia1.TabIndex = 13
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(115, 503)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(289, 70)
        Me.txtObservaciones.TabIndex = 12
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Location = New System.Drawing.Point(92, 476)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(142, 20)
        Me.txtDiferencia.TabIndex = 12
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(6, 504)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(103, 17)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(92, 107)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(142, 20)
        Me.txtExistencia.TabIndex = 12
        '
        'lblDiferencia
        '
        Me.lblDiferencia.AutoSize = True
        Me.lblDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferencia.Location = New System.Drawing.Point(6, 476)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(72, 17)
        Me.lblDiferencia.TabIndex = 2
        Me.lblDiferencia.Text = "Diferencia"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(6, 107)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(71, 17)
        Me.lblExistencia.TabIndex = 2
        Me.lblExistencia.Text = "Existencia"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(6, 55)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(80, 17)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "Saldo Vía 1"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(363, 604)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(266, 604)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 11
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'frmArqueoCajaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 635)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArqueoCajaGlobal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Arqueo de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoVia1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblDiferencia As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnFallodeCaja As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtSaldoVia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesVales As System.Windows.Forms.TextBox
    Friend WithEvents lblValesDetalles As System.Windows.Forms.Label
    Friend WithEvents txtVales As System.Windows.Forms.TextBox
    Friend WithEvents lblVales As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaFisica As System.Windows.Forms.TextBox
    Friend WithEvents lblExistenciaFisica As System.Windows.Forms.Label
    Friend WithEvents txtSobresDetalles As System.Windows.Forms.TextBox
    Friend WithEvents lblSobresDetalles As System.Windows.Forms.Label
    Friend WithEvents txtSobres As System.Windows.Forms.TextBox
    Friend WithEvents lblSobres As System.Windows.Forms.Label
    Friend WithEvents txtDetalleCajaFuerte As System.Windows.Forms.TextBox
    Friend WithEvents lblDetalleCajaFuerte As System.Windows.Forms.Label
    Friend WithEvents txtCajaFuerte As System.Windows.Forms.TextBox
    Friend WithEvents lblCajaFuerte As System.Windows.Forms.Label
End Class
