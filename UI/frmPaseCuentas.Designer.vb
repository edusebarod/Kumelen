<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaseCuentas
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
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.cbxCuentaSalida = New System.Windows.Forms.ComboBox()
        Me.lblCuentaSalida = New System.Windows.Forms.Label()
        Me.cbxCuentaEntrada = New System.Windows.Forms.ComboBox()
        Me.lblCuentaEntrada = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRealizar
        '
        Me.btnRealizar.Location = New System.Drawing.Point(460, 254)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(114, 36)
        Me.btnRealizar.TabIndex = 70
        Me.btnRealizar.Text = "Realizar"
        Me.btnRealizar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(156, 106)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 20)
        Me.txtMonto.TabIndex = 73
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(87, 109)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(47, 16)
        Me.lblMonto.TabIndex = 74
        Me.lblMonto.Text = "Monto"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(156, 132)
        Me.txtObservaciones.MaxLength = 512
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(392, 80)
        Me.txtObservaciones.TabIndex = 69
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(33, 134)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 72
        Me.lblObservaciones.Text = "Observaciones"
        '
        'cbxCuentaSalida
        '
        Me.cbxCuentaSalida.FormattingEnabled = True
        Me.cbxCuentaSalida.Location = New System.Drawing.Point(156, 50)
        Me.cbxCuentaSalida.Name = "cbxCuentaSalida"
        Me.cbxCuentaSalida.Size = New System.Drawing.Size(392, 21)
        Me.cbxCuentaSalida.TabIndex = 68
        '
        'lblCuentaSalida
        '
        Me.lblCuentaSalida.AutoSize = True
        Me.lblCuentaSalida.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaSalida.Location = New System.Drawing.Point(10, 52)
        Me.lblCuentaSalida.Name = "lblCuentaSalida"
        Me.lblCuentaSalida.Size = New System.Drawing.Size(124, 16)
        Me.lblCuentaSalida.TabIndex = 71
        Me.lblCuentaSalida.Text = "Cuenta Extracción"
        '
        'cbxCuentaEntrada
        '
        Me.cbxCuentaEntrada.FormattingEnabled = True
        Me.cbxCuentaEntrada.Location = New System.Drawing.Point(156, 79)
        Me.cbxCuentaEntrada.Name = "cbxCuentaEntrada"
        Me.cbxCuentaEntrada.Size = New System.Drawing.Size(392, 21)
        Me.cbxCuentaEntrada.TabIndex = 75
        '
        'lblCuentaEntrada
        '
        Me.lblCuentaEntrada.AutoSize = True
        Me.lblCuentaEntrada.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaEntrada.Location = New System.Drawing.Point(22, 81)
        Me.lblCuentaEntrada.Name = "lblCuentaEntrada"
        Me.lblCuentaEntrada.Size = New System.Drawing.Size(112, 16)
        Me.lblCuentaEntrada.TabIndex = 76
        Me.lblCuentaEntrada.Text = "Cuenta Depósito"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.cbxCuentaSalida)
        Me.GroupBox1.Controls.Add(Me.cbxCuentaEntrada)
        Me.GroupBox1.Controls.Add(Me.lblCuentaSalida)
        Me.GroupBox1.Controls.Add(Me.lblCuentaEntrada)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 224)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de las Cuentas"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(156, 23)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(392, 20)
        Me.txtConcepto.TabIndex = 78
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(66, 23)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(68, 16)
        Me.lblConcepto.TabIndex = 77
        Me.lblConcepto.Text = "Concepto"
        '
        'frmPaseCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 304)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRealizar)
        Me.Name = "frmPaseCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pase entre cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRealizar As System.Windows.Forms.Button
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents cbxCuentaSalida As System.Windows.Forms.ComboBox
    Friend WithEvents lblCuentaSalida As System.Windows.Forms.Label
    Friend WithEvents cbxCuentaEntrada As System.Windows.Forms.ComboBox
    Friend WithEvents lblCuentaEntrada As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
End Class
