<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionvia2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturacionvia2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxMedioPago = New System.Windows.Forms.ComboBox()
        Me.cbxPtoVta = New System.Windows.Forms.ComboBox()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.lblPtoVta = New System.Windows.Forms.Label()
        Me.ChbxIntereses = New System.Windows.Forms.CheckBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.dev_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dde_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.lblTurno = New System.Windows.Forms.Label()
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
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datos_alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxMedioPago)
        Me.GroupBox1.Controls.Add(Me.cbxPtoVta)
        Me.GroupBox1.Controls.Add(Me.lblMedioPago)
        Me.GroupBox1.Controls.Add(Me.lblPtoVta)
        Me.GroupBox1.Controls.Add(Me.ChbxIntereses)
        Me.GroupBox1.Controls.Add(Me.btnFacturar)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.lbl_Total)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Controls.Add(Me.cbxCuenta)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 443)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Factura"
        '
        'cbxMedioPago
        '
        Me.cbxMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMedioPago.FormattingEnabled = True
        Me.cbxMedioPago.Items.AddRange(New Object() {"Efectivo"})
        Me.cbxMedioPago.Location = New System.Drawing.Point(124, 263)
        Me.cbxMedioPago.Name = "cbxMedioPago"
        Me.cbxMedioPago.Size = New System.Drawing.Size(146, 21)
        Me.cbxMedioPago.TabIndex = 74
        '
        'cbxPtoVta
        '
        Me.cbxPtoVta.FormattingEnabled = True
        Me.cbxPtoVta.Items.AddRange(New Object() {"0002", "0003", "0004"})
        Me.cbxPtoVta.Location = New System.Drawing.Point(527, 18)
        Me.cbxPtoVta.Name = "cbxPtoVta"
        Me.cbxPtoVta.Size = New System.Drawing.Size(146, 21)
        Me.cbxPtoVta.TabIndex = 71
        '
        'lblMedioPago
        '
        Me.lblMedioPago.AutoSize = True
        Me.lblMedioPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.Location = New System.Drawing.Point(15, 263)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.Size = New System.Drawing.Size(104, 16)
        Me.lblMedioPago.TabIndex = 73
        Me.lblMedioPago.Text = "Medio de Pago"
        '
        'lblPtoVta
        '
        Me.lblPtoVta.AutoSize = True
        Me.lblPtoVta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtoVta.Location = New System.Drawing.Point(406, 23)
        Me.lblPtoVta.Name = "lblPtoVta"
        Me.lblPtoVta.Size = New System.Drawing.Size(105, 16)
        Me.lblPtoVta.TabIndex = 72
        Me.lblPtoVta.Text = "Punto de Venta"
        '
        'ChbxIntereses
        '
        Me.ChbxIntereses.AutoSize = True
        Me.ChbxIntereses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbxIntereses.Location = New System.Drawing.Point(752, 19)
        Me.ChbxIntereses.Name = "ChbxIntereses"
        Me.ChbxIntereses.Size = New System.Drawing.Size(152, 20)
        Me.ChbxIntereses.TabIndex = 69
        Me.ChbxIntereses.Text = "Calcular Intereses"
        Me.ChbxIntereses.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(790, 283)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(114, 36)
        Me.btnFacturar.TabIndex = 8
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Image = Global.Kumelen.My.Resources.Resources.del
        Me.btnDel.Location = New System.Drawing.Point(865, 130)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(39, 41)
        Me.btnDel.TabIndex = 6
        Me.btnDel.Tag = "Quitar el concepto seleccionado"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(865, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 41)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Tag = "Agregar un concepto"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(124, 302)
        Me.txtTotal.MaxLength = 12
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 20)
        Me.txtTotal.TabIndex = 66
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(18, 303)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(39, 16)
        Me.lbl_Total.TabIndex = 67
        Me.lbl_Total.Text = "Total"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(124, 340)
        Me.txtObservaciones.MaxLength = 512
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(780, 80)
        Me.txtObservaciones.TabIndex = 7
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(18, 340)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 65
        Me.lblObservaciones.Text = "Observaciones"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dev_id, Me.dde_id, Me.concepto, Me.Monto, Me.cuenta})
        Me.dgDetalle.Location = New System.Drawing.Point(16, 62)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(794, 189)
        Me.dgDetalle.TabIndex = 63
        '
        'dev_id
        '
        Me.dev_id.HeaderText = "dev_id"
        Me.dev_id.Name = "dev_id"
        Me.dev_id.Visible = False
        '
        'dde_id
        '
        Me.dde_id.HeaderText = "dde_id"
        Me.dde_id.Name = "dde_id"
        Me.dde_id.Visible = False
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 600
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 150
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Visible = False
        '
        'cbxCuenta
        '
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Items.AddRange(New Object() {"Caja Efectivo", "Caja Efectivo San Carlos"})
        Me.cbxCuenta.Location = New System.Drawing.Point(95, 18)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(255, 21)
        Me.cbxCuenta.TabIndex = 4
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
        Me.datos_alumno.AutoSize = True
        Me.datos_alumno.Controls.Add(Me.txtTurno)
        Me.datos_alumno.Controls.Add(Me.lblTurno)
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
        Me.datos_alumno.Location = New System.Drawing.Point(12, 12)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(926, 111)
        Me.datos_alumno.TabIndex = 63
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(326, 71)
        Me.txtTurno.MaxLength = 12
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(143, 20)
        Me.txtTurno.TabIndex = 22
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(260, 72)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 64
        Me.lblTurno.Text = "Turno"
        '
        'txtEncargado
        '
        Me.txtEncargado.Location = New System.Drawing.Point(585, 72)
        Me.txtEncargado.MaxLength = 50
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(332, 20)
        Me.txtEncargado.TabIndex = 3
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(507, 72)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(76, 16)
        Me.lblEncargado.TabIndex = 62
        Me.lblEncargado.Text = "Encargado"
        '
        'btnBuscaDNI
        '
        Me.btnBuscaDNI.Image = CType(resources.GetObject("btnBuscaDNI.Image"), System.Drawing.Image)
        Me.btnBuscaDNI.Location = New System.Drawing.Point(883, 16)
        Me.btnBuscaDNI.Name = "btnBuscaDNI"
        Me.btnBuscaDNI.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaDNI.TabIndex = 59
        Me.btnBuscaDNI.UseVisualStyleBackColor = True
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(76, 71)
        Me.txtSala.MaxLength = 12
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(133, 20)
        Me.txtSala.TabIndex = 21
        '
        'btnBuscaApell
        '
        Me.btnBuscaApell.Image = CType(resources.GetObject("btnBuscaApell.Image"), System.Drawing.Image)
        Me.btnBuscaApell.Location = New System.Drawing.Point(586, 16)
        Me.btnBuscaApell.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscaApell.Name = "btnBuscaApell"
        Me.btnBuscaApell.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscaApell.TabIndex = 60
        Me.btnBuscaApell.UseVisualStyleBackColor = True
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(17, 72)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 51
        Me.lblSala.Text = "Sala"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(374, 34)
        Me.txtApellido.MaxLength = 12
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(206, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(662, 34)
        Me.txtDNI.MaxLength = 12
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(215, 20)
        Me.txtDNI.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(95, 34)
        Me.txtNombre.MaxLength = 12
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(626, 35)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(30, 16)
        Me.lblDNI.TabIndex = 40
        Me.lblDNI.Text = "DNI"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(296, 38)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 39
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre"
        '
        'frmFacturacionvia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 588)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_alumno)
        Me.Name = "frmFacturacionvia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación Vía 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents datos_alumno As System.Windows.Forms.GroupBox
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
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents dev_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dde_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChbxIntereses As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPtoVta As System.Windows.Forms.ComboBox
    Friend WithEvents lblPtoVta As System.Windows.Forms.Label
    Friend WithEvents cbxMedioPago As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedioPago As System.Windows.Forms.Label
End Class
