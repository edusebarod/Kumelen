﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagosvia1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagosvia1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbxInterbanking = New System.Windows.Forms.CheckBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.txtNroCheque = New System.Windows.Forms.TextBox()
        Me.lblNroCheque = New System.Windows.Forms.Label()
        Me.chbxDebito = New System.Windows.Forms.CheckBox()
        Me.chbxTransferencia = New System.Windows.Forms.CheckBox()
        Me.chbxCheque = New System.Windows.Forms.CheckBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.cbxCtaEgreso = New System.Windows.Forms.ComboBox()
        Me.lblCtaEgreso = New System.Windows.Forms.Label()
        Me.txtNroComprobante = New System.Windows.Forms.TextBox()
        Me.lblNroComprobante = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cbxCtaGasto = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblCtaGasto = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBuscaProv = New System.Windows.Forms.Button()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.datos_alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbxInterbanking)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.lblBanco)
        Me.GroupBox1.Controls.Add(Me.txtVencimiento)
        Me.GroupBox1.Controls.Add(Me.lblVencimiento)
        Me.GroupBox1.Controls.Add(Me.txtLugar)
        Me.GroupBox1.Controls.Add(Me.lblLugar)
        Me.GroupBox1.Controls.Add(Me.txtNroCheque)
        Me.GroupBox1.Controls.Add(Me.lblNroCheque)
        Me.GroupBox1.Controls.Add(Me.chbxDebito)
        Me.GroupBox1.Controls.Add(Me.chbxTransferencia)
        Me.GroupBox1.Controls.Add(Me.chbxCheque)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.cbxCtaEgreso)
        Me.GroupBox1.Controls.Add(Me.lblCtaEgreso)
        Me.GroupBox1.Controls.Add(Me.txtNroComprobante)
        Me.GroupBox1.Controls.Add(Me.lblNroComprobante)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.cbxCtaGasto)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.lblCtaGasto)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 417)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del Pago"
        '
        'chbxInterbanking
        '
        Me.chbxInterbanking.AutoSize = True
        Me.chbxInterbanking.Location = New System.Drawing.Point(429, 193)
        Me.chbxInterbanking.Name = "chbxInterbanking"
        Me.chbxInterbanking.Size = New System.Drawing.Size(85, 17)
        Me.chbxInterbanking.TabIndex = 10
        Me.chbxInterbanking.Text = "Interbanking"
        Me.chbxInterbanking.UseVisualStyleBackColor = True
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(66, 224)
        Me.txtBanco.MaxLength = 12
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(245, 20)
        Me.txtBanco.TabIndex = 11
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.Location = New System.Drawing.Point(15, 225)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(48, 16)
        Me.lblBanco.TabIndex = 83
        Me.lblBanco.Text = "Banco"
        '
        'txtVencimiento
        '
        Me.txtVencimiento.Checked = False
        Me.txtVencimiento.CustomFormat = "yyyy/MM/dd"
        Me.txtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimiento.Location = New System.Drawing.Point(451, 249)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.ShowCheckBox = True
        Me.txtVencimiento.Size = New System.Drawing.Size(141, 20)
        Me.txtVencimiento.TabIndex = 14
        Me.txtVencimiento.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.Location = New System.Drawing.Point(358, 249)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(87, 16)
        Me.lblVencimiento.TabIndex = 81
        Me.lblVencimiento.Text = "Vencimiento"
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(66, 252)
        Me.txtLugar.MaxLength = 12
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(245, 20)
        Me.txtLugar.TabIndex = 13
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(15, 253)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(45, 16)
        Me.lblLugar.TabIndex = 79
        Me.lblLugar.Text = "Lugar"
        '
        'txtNroCheque
        '
        Me.txtNroCheque.Location = New System.Drawing.Point(414, 223)
        Me.txtNroCheque.MaxLength = 12
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.Size = New System.Drawing.Size(180, 20)
        Me.txtNroCheque.TabIndex = 12
        '
        'lblNroCheque
        '
        Me.lblNroCheque.AutoSize = True
        Me.lblNroCheque.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroCheque.Location = New System.Drawing.Point(325, 224)
        Me.lblNroCheque.Name = "lblNroCheque"
        Me.lblNroCheque.Size = New System.Drawing.Size(83, 16)
        Me.lblNroCheque.TabIndex = 77
        Me.lblNroCheque.Text = "Nro Cheque"
        '
        'chbxDebito
        '
        Me.chbxDebito.AutoSize = True
        Me.chbxDebito.Location = New System.Drawing.Point(340, 193)
        Me.chbxDebito.Name = "chbxDebito"
        Me.chbxDebito.Size = New System.Drawing.Size(57, 17)
        Me.chbxDebito.TabIndex = 9
        Me.chbxDebito.Text = "Debito"
        Me.chbxDebito.UseVisualStyleBackColor = True
        '
        'chbxTransferencia
        '
        Me.chbxTransferencia.AutoSize = True
        Me.chbxTransferencia.Location = New System.Drawing.Point(178, 193)
        Me.chbxTransferencia.Name = "chbxTransferencia"
        Me.chbxTransferencia.Size = New System.Drawing.Size(136, 17)
        Me.chbxTransferencia.TabIndex = 8
        Me.chbxTransferencia.Text = "Transferencia Bancaria"
        Me.chbxTransferencia.UseVisualStyleBackColor = True
        '
        'chbxCheque
        '
        Me.chbxCheque.AutoSize = True
        Me.chbxCheque.Location = New System.Drawing.Point(84, 193)
        Me.chbxCheque.Name = "chbxCheque"
        Me.chbxCheque.Size = New System.Drawing.Size(63, 17)
        Me.chbxCheque.TabIndex = 7
        Me.chbxCheque.Text = "Cheque"
        Me.chbxCheque.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Checked = False
        Me.txtFecha.CustomFormat = "yyyy/MM/dd"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(179, 81)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ShowCheckBox = True
        Me.txtFecha.Size = New System.Drawing.Size(132, 20)
        Me.txtFecha.TabIndex = 4
        Me.txtFecha.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(12, 86)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(161, 16)
        Me.lbl_Fecha.TabIndex = 71
        Me.lbl_Fecha.Text = "Fecha del Comprobante"
        '
        'cbxCtaEgreso
        '
        Me.cbxCtaEgreso.FormattingEnabled = True
        Me.cbxCtaEgreso.Location = New System.Drawing.Point(179, 52)
        Me.cbxCtaEgreso.Name = "cbxCtaEgreso"
        Me.cbxCtaEgreso.Size = New System.Drawing.Size(414, 21)
        Me.cbxCtaEgreso.TabIndex = 3
        '
        'lblCtaEgreso
        '
        Me.lblCtaEgreso.AutoSize = True
        Me.lblCtaEgreso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaEgreso.Location = New System.Drawing.Point(12, 56)
        Me.lblCtaEgreso.Name = "lblCtaEgreso"
        Me.lblCtaEgreso.Size = New System.Drawing.Size(120, 16)
        Me.lblCtaEgreso.TabIndex = 69
        Me.lblCtaEgreso.Text = "Cuenta de egreso"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(179, 152)
        Me.txtNroComprobante.MaxLength = 12
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(180, 20)
        Me.txtNroComprobante.TabIndex = 6
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.AutoSize = True
        Me.lblNroComprobante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroComprobante.Location = New System.Drawing.Point(13, 152)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(110, 16)
        Me.lblNroComprobante.TabIndex = 67
        Me.lblNroComprobante.Text = "Nº comprobante"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(179, 323)
        Me.txtObservaciones.MaxLength = 512
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(414, 80)
        Me.txtObservaciones.TabIndex = 16
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(179, 116)
        Me.txtConcepto.MaxLength = 500
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(414, 20)
        Me.txtConcepto.TabIndex = 5
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 323)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 65
        Me.lblObservaciones.Text = "Observaciones"
        '
        'cbxCtaGasto
        '
        Me.cbxCtaGasto.FormattingEnabled = True
        Me.cbxCtaGasto.Location = New System.Drawing.Point(179, 19)
        Me.cbxCtaGasto.Name = "cbxCtaGasto"
        Me.cbxCtaGasto.Size = New System.Drawing.Size(414, 21)
        Me.cbxCtaGasto.TabIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(179, 287)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 20)
        Me.txtMonto.TabIndex = 15
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(13, 288)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(47, 16)
        Me.lblMonto.TabIndex = 51
        Me.lblMonto.Text = "Monto"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(13, 120)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(68, 16)
        Me.lblConcepto.TabIndex = 39
        Me.lblConcepto.Text = "Concepto"
        '
        'lblCtaGasto
        '
        Me.lblCtaGasto.AutoSize = True
        Me.lblCtaGasto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaGasto.Location = New System.Drawing.Point(12, 23)
        Me.lblCtaGasto.Name = "lblCtaGasto"
        Me.lblCtaGasto.Size = New System.Drawing.Size(111, 16)
        Me.lblCtaGasto.TabIndex = 40
        Me.lblCtaGasto.Text = "Cuenta de gasto"
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(506, 513)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(114, 36)
        Me.btnPagar.TabIndex = 17
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'datos_alumno
        '
        Me.datos_alumno.AutoSize = True
        Me.datos_alumno.Controls.Add(Me.btnAdd)
        Me.datos_alumno.Controls.Add(Me.btnBuscaProv)
        Me.datos_alumno.Controls.Add(Me.txtProveedor)
        Me.datos_alumno.Controls.Add(Me.lblProveedor)
        Me.datos_alumno.Location = New System.Drawing.Point(20, 12)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(600, 75)
        Me.datos_alumno.TabIndex = 1
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Proveedor"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(553, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 41)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Tag = "Agregar un concepto"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBuscaProv
        '
        Me.btnBuscaProv.Image = CType(resources.GetObject("btnBuscaProv.Image"), System.Drawing.Image)
        Me.btnBuscaProv.Location = New System.Drawing.Point(504, 15)
        Me.btnBuscaProv.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscaProv.Name = "btnBuscaProv"
        Me.btnBuscaProv.Size = New System.Drawing.Size(39, 41)
        Me.btnBuscaProv.TabIndex = 60
        Me.btnBuscaProv.UseVisualStyleBackColor = True
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(123, 33)
        Me.txtProveedor.MaxLength = 100
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(368, 20)
        Me.txtProveedor.TabIndex = 1
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(23, 37)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(74, 16)
        Me.lblProveedor.TabIndex = 39
        Me.lblProveedor.Text = "Proveedor"
        '
        'frmPagosvia1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 559)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_alumno)
        Me.Name = "frmPagosvia1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pagos Vía 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents cbxCtaGasto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblCtaGasto As System.Windows.Forms.Label
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscaProv As System.Windows.Forms.Button
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cbxCtaEgreso As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaEgreso As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents txtNroCheque As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCheque As System.Windows.Forms.Label
    Friend WithEvents chbxDebito As System.Windows.Forms.CheckBox
    Friend WithEvents chbxTransferencia As System.Windows.Forms.CheckBox
    Friend WithEvents chbxCheque As System.Windows.Forms.CheckBox
    Friend WithEvents txtVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVencimiento As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents chbxInterbanking As System.Windows.Forms.CheckBox
End Class
