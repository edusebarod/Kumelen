<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevengaciones2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevengaciones2))
        Me.datos_alumno = New System.Windows.Forms.GroupBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.lblTurno = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDevengarsv = New System.Windows.Forms.Button()
        Me.btnDevengar2v = New System.Windows.Forms.Button()
        Me.btnDevengar1v = New System.Windows.Forms.Button()
        Me.chbxProducto = New System.Windows.Forms.CheckBox()
        Me.chbxServicio = New System.Windows.Forms.CheckBox()
        Me.cbxProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnDevengar = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.datos_alumno.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datos_alumno
        '
        Me.datos_alumno.AutoSize = True
        Me.datos_alumno.Controls.Add(Me.txtTurno)
        Me.datos_alumno.Controls.Add(Me.lblTurno)
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
        Me.datos_alumno.Location = New System.Drawing.Point(24, 25)
        Me.datos_alumno.Name = "datos_alumno"
        Me.datos_alumno.Size = New System.Drawing.Size(926, 111)
        Me.datos_alumno.TabIndex = 54
        Me.datos_alumno.TabStop = False
        Me.datos_alumno.Text = "Datos del Alumno"
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(374, 72)
        Me.txtTurno.MaxLength = 12
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(180, 20)
        Me.txtTurno.TabIndex = 61
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(296, 72)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 62
        Me.lblTurno.Text = "Turno"
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
        Me.txtSala.Location = New System.Drawing.Point(95, 72)
        Me.txtSala.MaxLength = 12
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(180, 20)
        Me.txtSala.TabIndex = 3
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
        Me.txtDNI.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDevengarsv)
        Me.GroupBox1.Controls.Add(Me.btnDevengar2v)
        Me.GroupBox1.Controls.Add(Me.btnDevengar1v)
        Me.GroupBox1.Controls.Add(Me.chbxProducto)
        Me.GroupBox1.Controls.Add(Me.chbxServicio)
        Me.GroupBox1.Controls.Add(Me.cbxProducto)
        Me.GroupBox1.Controls.Add(Me.lblProducto)
        Me.GroupBox1.Controls.Add(Me.btnDevengar)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.lbl_Total)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Controls.Add(Me.cbxServicio)
        Me.GroupBox1.Controls.Add(Me.cbxCuenta)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblConcepto)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 464)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de la devengación"
        '
        'btnDevengarsv
        '
        Me.btnDevengarsv.Location = New System.Drawing.Point(812, 321)
        Me.btnDevengarsv.Name = "btnDevengarsv"
        Me.btnDevengarsv.Size = New System.Drawing.Size(92, 36)
        Me.btnDevengarsv.TabIndex = 76
        Me.btnDevengarsv.Text = "Devengar S / V"
        Me.btnDevengarsv.UseVisualStyleBackColor = True
        '
        'btnDevengar2v
        '
        Me.btnDevengar2v.Location = New System.Drawing.Point(722, 321)
        Me.btnDevengar2v.Name = "btnDevengar2v"
        Me.btnDevengar2v.Size = New System.Drawing.Size(83, 36)
        Me.btnDevengar2v.TabIndex = 75
        Me.btnDevengar2v.Text = "Devengar 2 V"
        Me.btnDevengar2v.UseVisualStyleBackColor = True
        '
        'btnDevengar1v
        '
        Me.btnDevengar1v.Location = New System.Drawing.Point(635, 321)
        Me.btnDevengar1v.Name = "btnDevengar1v"
        Me.btnDevengar1v.Size = New System.Drawing.Size(81, 36)
        Me.btnDevengar1v.TabIndex = 74
        Me.btnDevengar1v.Text = "Devengar 1 V"
        Me.btnDevengar1v.UseVisualStyleBackColor = True
        '
        'chbxProducto
        '
        Me.chbxProducto.AutoSize = True
        Me.chbxProducto.Location = New System.Drawing.Point(615, 88)
        Me.chbxProducto.Name = "chbxProducto"
        Me.chbxProducto.Size = New System.Drawing.Size(15, 14)
        Me.chbxProducto.TabIndex = 73
        Me.chbxProducto.UseVisualStyleBackColor = True
        '
        'chbxServicio
        '
        Me.chbxServicio.AutoSize = True
        Me.chbxServicio.Location = New System.Drawing.Point(615, 56)
        Me.chbxServicio.Name = "chbxServicio"
        Me.chbxServicio.Size = New System.Drawing.Size(15, 14)
        Me.chbxServicio.TabIndex = 72
        Me.chbxServicio.UseVisualStyleBackColor = True
        '
        'cbxProducto
        '
        Me.cbxProducto.FormattingEnabled = True
        Me.cbxProducto.Location = New System.Drawing.Point(124, 85)
        Me.cbxProducto.Name = "cbxProducto"
        Me.cbxProducto.Size = New System.Drawing.Size(459, 21)
        Me.cbxProducto.TabIndex = 4
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(18, 86)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(65, 16)
        Me.lblProducto.TabIndex = 71
        Me.lblProducto.Text = "Producto"
        '
        'btnDevengar
        '
        Me.btnDevengar.Location = New System.Drawing.Point(553, 321)
        Me.btnDevengar.Name = "btnDevengar"
        Me.btnDevengar.Size = New System.Drawing.Size(76, 36)
        Me.btnDevengar.TabIndex = 8
        Me.btnDevengar.Text = "Devengar"
        Me.btnDevengar.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Image = Global.Kumelen.My.Resources.Resources.del
        Me.btnDel.Location = New System.Drawing.Point(814, 220)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(39, 41)
        Me.btnDel.TabIndex = 11
        Me.btnDel.Tag = "Quitar el concepto seleccionado"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(814, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 41)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Tag = "Agregar un concepto"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(124, 333)
        Me.txtTotal.MaxLength = 12
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 20)
        Me.txtTotal.TabIndex = 66
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(18, 334)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(39, 16)
        Me.lbl_Total.TabIndex = 67
        Me.lbl_Total.Text = "Total"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(124, 371)
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
        Me.lblObservaciones.Location = New System.Drawing.Point(18, 371)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 65
        Me.lblObservaciones.Text = "Observaciones"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.concepto, Me.serv_id, Me.Monto, Me.cuenta})
        Me.dgDetalle.Location = New System.Drawing.Point(20, 157)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Size = New System.Drawing.Size(696, 158)
        Me.dgDetalle.TabIndex = 63
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 500
        '
        'serv_id
        '
        Me.serv_id.HeaderText = "serv_id"
        Me.serv_id.Name = "serv_id"
        Me.serv_id.Visible = False
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
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Location = New System.Drawing.Point(124, 53)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(459, 21)
        Me.cbxServicio.TabIndex = 3
        '
        'cbxCuenta
        '
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Location = New System.Drawing.Point(124, 19)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(459, 21)
        Me.cbxCuenta.TabIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(124, 121)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 20)
        Me.txtMonto.TabIndex = 5
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(18, 122)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(47, 16)
        Me.lblMonto.TabIndex = 51
        Me.lblMonto.Text = "Monto"
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
        Me.lblCuenta.Location = New System.Drawing.Point(18, 20)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(53, 16)
        Me.lblCuenta.TabIndex = 40
        Me.lblCuenta.Text = "Cuenta"
        '
        'frmDevengaciones2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 635)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_alumno)
        Me.Name = "frmDevengaciones2"
        Me.Text = "Devengaciones"
        Me.datos_alumno.ResumeLayout(False)
        Me.datos_alumno.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnDevengar As System.Windows.Forms.Button
    Friend WithEvents cbxProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents chbxProducto As System.Windows.Forms.CheckBox
    Friend WithEvents chbxServicio As System.Windows.Forms.CheckBox
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serv_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDevengarsv As System.Windows.Forms.Button
    Friend WithEvents btnDevengar2v As System.Windows.Forms.Button
    Friend WithEvents btnDevengar1v As System.Windows.Forms.Button
End Class
