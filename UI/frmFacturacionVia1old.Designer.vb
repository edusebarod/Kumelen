<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionVia1old
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.txtEncargado = New System.Windows.Forms.TextBox()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.btnBuscaDNI = New System.Windows.Forms.Button()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.btnBuscaApell = New System.Windows.Forms.Button()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.datos_alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(720, 362)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 29)
        Me.btnSalir.TabIndex = 62
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(832, 362)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(94, 31)
        Me.btnFacturar.TabIndex = 63
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxServicio)
        Me.GroupBox1.Controls.Add(Me.cbxCuenta)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 217)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles Factura"
        '
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Location = New System.Drawing.Point(123, 53)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(459, 21)
        Me.cbxServicio.TabIndex = 6
        '
        'cbxCuenta
        '
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Location = New System.Drawing.Point(124, 19)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(459, 21)
        Me.cbxCuenta.TabIndex = 5
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(123, 89)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 20)
        Me.txtMonto.TabIndex = 7
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(17, 90)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(47, 16)
        Me.lblMonto.TabIndex = 51
        Me.lblMonto.Text = "Monto"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(124, 125)
        Me.txtObservaciones.MaxLength = 512
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(780, 80)
        Me.txtObservaciones.TabIndex = 8
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(18, 125)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 40
        Me.lblObservaciones.Text = "Observaciones"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(17, 54)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(60, 16)
        Me.lblConcepto.TabIndex = 39
        Me.lblConcepto.Text = "Servicio"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(17, 23)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(53, 16)
        Me.lblCuenta.TabIndex = 40
        Me.lblCuenta.Text = "Cuenta"
        '
        'datos_alumno
        '
        Me.datos_alumno.Controls.Add(Me.txtEncargado)
        Me.datos_alumno.Controls.Add(Me.lblEncargado)
        Me.datos_alumno.Controls.Add(Me.btnBuscaDNI)
        Me.datos_alumno.Controls.Add(Me.txtSala)
        Me.datos_alumno.Controls.Add(Me.btnBuscaApell)
        Me.datos_alumno.Controls.Add(Me.lblSala)
        Me.datos_alumno.Controls.Add(Me.txtApellido)
        Me.datos_alumno.Controls.Add(Me.txtDNI)
        Me.datos_alumno.Controls.Add(Me.txtNombre)
        Me.datos_alumno.Controls.Add(Me.lblDNI)
        Me.datos_alumno.Controls.Add(Me.lblApellido)
        Me.datos_alumno.Controls.Add(Me.lblNombre)
        Me.datos_alumno.Location = New System.Drawing.Point(11, 19)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(916, 93)
        Me.datos_alumno.TabIndex = 64
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'txtEncargado
        '
        Me.txtEncargado.Location = New System.Drawing.Point(374, 53)
        Me.txtEncargado.MaxLength = 12
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(206, 20)
        Me.txtEncargado.TabIndex = 4
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(296, 57)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(76, 16)
        Me.lblEncargado.TabIndex = 62
        Me.lblEncargado.Text = "Encargado"
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscaDNI.Location = New System.Drawing.Point(883, 20)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaDNI.TabIndex = 59
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(95, 57)
        Me.txtSala.MaxLength = 12
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(180, 20)
        Me.txtSala.TabIndex = 3
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscaApell.Location = New System.Drawing.Point(586, 19)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaApell.TabIndex = 60
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(17, 57)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 51
        Me.lblSala.Text = "Sala"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(374, 19)
        Me.txtApellido.MaxLength = 12
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(206, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(662, 19)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(215, 20)
        Me.txtDNI.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(95, 19)
        Me.txtNombre.MaxLength = 12
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(626, 20)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(296, 23)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'frmFacturacionVia1old
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 413)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_alumno)
        Me.Name = "frmFacturacionVia1old"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmFacturacionVia1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents btnBuscaDNI As System.Windows.Forms.Button
    Friend WithEvents txtSala As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaApell As System.Windows.Forms.Button
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
