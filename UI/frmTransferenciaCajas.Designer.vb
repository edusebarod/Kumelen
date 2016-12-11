<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransferenciaCajas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.cbxCtaDestino = New System.Windows.Forms.ComboBox()
        Me.lblCtaDestinio = New System.Windows.Forms.Label()
        Me.txtNroComprobante = New System.Windows.Forms.TextBox()
        Me.lblNroComprobante = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cbxCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.chbxVia1Origen = New System.Windows.Forms.CheckBox()
        Me.chbxVia2Origen = New System.Windows.Forms.CheckBox()
        Me.chbxVia1Destino = New System.Windows.Forms.CheckBox()
        Me.chbxVia2Destino = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbxVia2Destino)
        Me.GroupBox1.Controls.Add(Me.chbxVia1Destino)
        Me.GroupBox1.Controls.Add(Me.chbxVia2Origen)
        Me.GroupBox1.Controls.Add(Me.chbxVia1Origen)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.cbxCtaDestino)
        Me.GroupBox1.Controls.Add(Me.lblCtaDestinio)
        Me.GroupBox1.Controls.Add(Me.txtNroComprobante)
        Me.GroupBox1.Controls.Add(Me.lblNroComprobante)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.cbxCtaOrigen)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.lblCtaOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 320)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de la transferencia entre cajas"
        '
        'txtFecha
        '
        Me.txtFecha.Checked = False
        Me.txtFecha.CustomFormat = "yyyy/MM/dd"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(179, 81)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ShowCheckBox = True
        Me.txtFecha.Size = New System.Drawing.Size(94, 20)
        Me.txtFecha.TabIndex = 72
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
        'cbxCtaDestino
        '
        Me.cbxCtaDestino.FormattingEnabled = True
        Me.cbxCtaDestino.Location = New System.Drawing.Point(179, 52)
        Me.cbxCtaDestino.Name = "cbxCtaDestino"
        Me.cbxCtaDestino.Size = New System.Drawing.Size(270, 21)
        Me.cbxCtaDestino.TabIndex = 68
        '
        'lblCtaDestinio
        '
        Me.lblCtaDestinio.AutoSize = True
        Me.lblCtaDestinio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaDestinio.Location = New System.Drawing.Point(12, 56)
        Me.lblCtaDestinio.Name = "lblCtaDestinio"
        Me.lblCtaDestinio.Size = New System.Drawing.Size(123, 16)
        Me.lblCtaDestinio.TabIndex = 69
        Me.lblCtaDestinio.Text = "Cuenta de destino"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(179, 152)
        Me.txtNroComprobante.MaxLength = 12
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(180, 20)
        Me.txtNroComprobante.TabIndex = 4
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
        Me.txtObservaciones.Location = New System.Drawing.Point(179, 221)
        Me.txtObservaciones.MaxLength = 512
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(414, 80)
        Me.txtObservaciones.TabIndex = 6
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(179, 116)
        Me.txtConcepto.MaxLength = 500
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(414, 20)
        Me.txtConcepto.TabIndex = 3
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 221)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 65
        Me.lblObservaciones.Text = "Observaciones"
        '
        'cbxCtaOrigen
        '
        Me.cbxCtaOrigen.FormattingEnabled = True
        Me.cbxCtaOrigen.Location = New System.Drawing.Point(179, 19)
        Me.cbxCtaOrigen.Name = "cbxCtaOrigen"
        Me.cbxCtaOrigen.Size = New System.Drawing.Size(270, 21)
        Me.cbxCtaOrigen.TabIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(179, 185)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 20)
        Me.txtMonto.TabIndex = 5
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(13, 186)
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
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtaOrigen.Location = New System.Drawing.Point(12, 23)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(118, 16)
        Me.lblCtaOrigen.TabIndex = 40
        Me.lblCtaOrigen.Text = "Cuenta de origen"
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(506, 377)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(114, 36)
        Me.btnPagar.TabIndex = 7
        Me.btnPagar.Text = "Realizar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'chbxVia1Origen
        '
        Me.chbxVia1Origen.AutoSize = True
        Me.chbxVia1Origen.Location = New System.Drawing.Point(466, 22)
        Me.chbxVia1Origen.Name = "chbxVia1Origen"
        Me.chbxVia1Origen.Size = New System.Drawing.Size(52, 17)
        Me.chbxVia1Origen.TabIndex = 73
        Me.chbxVia1Origen.Text = "Vía 1"
        Me.chbxVia1Origen.UseVisualStyleBackColor = True
        '
        'chbxVia2Origen
        '
        Me.chbxVia2Origen.AutoSize = True
        Me.chbxVia2Origen.Location = New System.Drawing.Point(533, 23)
        Me.chbxVia2Origen.Name = "chbxVia2Origen"
        Me.chbxVia2Origen.Size = New System.Drawing.Size(52, 17)
        Me.chbxVia2Origen.TabIndex = 74
        Me.chbxVia2Origen.Text = "Vía 2"
        Me.chbxVia2Origen.UseVisualStyleBackColor = True
        '
        'chbxVia1Destino
        '
        Me.chbxVia1Destino.AutoSize = True
        Me.chbxVia1Destino.Location = New System.Drawing.Point(466, 55)
        Me.chbxVia1Destino.Name = "chbxVia1Destino"
        Me.chbxVia1Destino.Size = New System.Drawing.Size(52, 17)
        Me.chbxVia1Destino.TabIndex = 75
        Me.chbxVia1Destino.Text = "Vía 1"
        Me.chbxVia1Destino.UseVisualStyleBackColor = True
        '
        'chbxVia2Destino
        '
        Me.chbxVia2Destino.AutoSize = True
        Me.chbxVia2Destino.Location = New System.Drawing.Point(533, 56)
        Me.chbxVia2Destino.Name = "chbxVia2Destino"
        Me.chbxVia2Destino.Size = New System.Drawing.Size(52, 17)
        Me.chbxVia2Destino.TabIndex = 76
        Me.chbxVia2Destino.Text = "Vía 2"
        Me.chbxVia2Destino.UseVisualStyleBackColor = True
        '
        'FrmTransferenciaCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 426)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTransferenciaCajas"
        Me.Text = "Transferecia entra Cajas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents cbxCtaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents cbxCtaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaDestinio As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbxVia2Destino As System.Windows.Forms.CheckBox
    Friend WithEvents chbxVia1Destino As System.Windows.Forms.CheckBox
    Friend WithEvents chbxVia2Origen As System.Windows.Forms.CheckBox
    Friend WithEvents chbxVia1Origen As System.Windows.Forms.CheckBox
End Class
