<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.cmdBuscaNombre = New System.Windows.Forms.Button()
        Me.grbxCuentas = New System.Windows.Forms.GroupBox()
        Me.chbxPagosHaber = New System.Windows.Forms.CheckBox()
        Me.chbxPagosDebe = New System.Windows.Forms.CheckBox()
        Me.chbxFacturaciones = New System.Windows.Forms.CheckBox()
        Me.chbxDevengaciones = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.grbxCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdNuevo.Location = New System.Drawing.Point(20, 254)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(102, 31)
        Me.cmdNuevo.TabIndex = 5
        Me.cmdNuevo.Text = "&NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(237, 84)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(66, 20)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 12)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(252, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(11, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Nombre"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(75, 69)
        Me.txtSaldo.MaxLength = 12
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(121, 20)
        Me.txtSaldo.TabIndex = 2
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(11, 73)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(45, 16)
        Me.lblSaldo.TabIndex = 36
        Me.lblSaldo.Text = "Saldo"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(262, 254)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(102, 31)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(141, 254)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(102, 31)
        Me.cmdGrabar.TabIndex = 6
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(12, 101)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 16)
        Me.lblTipo.TabIndex = 38
        Me.lblTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(75, 96)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 3
        '
        'cmdBuscaNombre
        '
        Me.cmdBuscaNombre.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.cmdBuscaNombre.Location = New System.Drawing.Point(341, 12)
        Me.cmdBuscaNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdBuscaNombre.Name = "cmdBuscaNombre"
        Me.cmdBuscaNombre.Size = New System.Drawing.Size(37, 38)
        Me.cmdBuscaNombre.TabIndex = 8
        Me.cmdBuscaNombre.UseVisualStyleBackColor = True
        '
        'grbxCuentas
        '
        Me.grbxCuentas.Controls.Add(Me.chbxPagosHaber)
        Me.grbxCuentas.Controls.Add(Me.chbxPagosDebe)
        Me.grbxCuentas.Controls.Add(Me.chbxFacturaciones)
        Me.grbxCuentas.Controls.Add(Me.chbxDevengaciones)
        Me.grbxCuentas.Location = New System.Drawing.Point(12, 164)
        Me.grbxCuentas.Name = "grbxCuentas"
        Me.grbxCuentas.Size = New System.Drawing.Size(362, 76)
        Me.grbxCuentas.TabIndex = 42
        Me.grbxCuentas.TabStop = False
        Me.grbxCuentas.Text = "Habilitación de ventanas"
        '
        'chbxPagosHaber
        '
        Me.chbxPagosHaber.AutoSize = True
        Me.chbxPagosHaber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxPagosHaber.Location = New System.Drawing.Point(193, 43)
        Me.chbxPagosHaber.Name = "chbxPagosHaber"
        Me.chbxPagosHaber.Size = New System.Drawing.Size(121, 20)
        Me.chbxPagosHaber.TabIndex = 42
        Me.chbxPagosHaber.Text = "Pagos - Egreso"
        Me.chbxPagosHaber.UseVisualStyleBackColor = True
        '
        'chbxPagosDebe
        '
        Me.chbxPagosDebe.AutoSize = True
        Me.chbxPagosDebe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxPagosDebe.Location = New System.Drawing.Point(49, 43)
        Me.chbxPagosDebe.Name = "chbxPagosDebe"
        Me.chbxPagosDebe.Size = New System.Drawing.Size(114, 20)
        Me.chbxPagosDebe.TabIndex = 41
        Me.chbxPagosDebe.Text = "Pagos - Gasto"
        Me.chbxPagosDebe.UseVisualStyleBackColor = True
        '
        'chbxFacturaciones
        '
        Me.chbxFacturaciones.AutoSize = True
        Me.chbxFacturaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxFacturaciones.Location = New System.Drawing.Point(193, 17)
        Me.chbxFacturaciones.Name = "chbxFacturaciones"
        Me.chbxFacturaciones.Size = New System.Drawing.Size(116, 20)
        Me.chbxFacturaciones.TabIndex = 40
        Me.chbxFacturaciones.Text = "Facturaciones"
        Me.chbxFacturaciones.UseVisualStyleBackColor = True
        '
        'chbxDevengaciones
        '
        Me.chbxDevengaciones.AutoSize = True
        Me.chbxDevengaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxDevengaciones.Location = New System.Drawing.Point(49, 17)
        Me.chbxDevengaciones.Name = "chbxDevengaciones"
        Me.chbxDevengaciones.Size = New System.Drawing.Size(124, 20)
        Me.chbxDevengaciones.TabIndex = 39
        Me.chbxDevengaciones.Text = "Devengaciones"
        Me.chbxDevengaciones.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(75, 38)
        Me.txtCodigo.MaxLength = 120
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 44
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(11, 42)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 16)
        Me.lblCodigo.TabIndex = 45
        Me.lblCodigo.Text = "Código"
        '
        'cbxGrupo
        '
        Me.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Items.AddRange(New Object() {"(1) Cuentas de Activo - Medios de Pago", "(2) Cuentas de Gasto", "(3) Cuentas de Deudores", "(4) Cuentas de Ganancias"})
        Me.cbxGrupo.Location = New System.Drawing.Point(75, 127)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(187, 21)
        Me.cbxGrupo.TabIndex = 46
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(12, 132)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(47, 16)
        Me.lblGrupo.TabIndex = 47
        Me.lblGrupo.Text = "Grupo"
        '
        'frmCuentas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(387, 296)
        Me.Controls.Add(Me.cbxGrupo)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.grbxCuentas)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.cmdBuscaNombre)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentas2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cuentas Vía 2"
        Me.grbxCuentas.ResumeLayout(False)
        Me.grbxCuentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuscaNombre As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents grbxCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents chbxPagosHaber As System.Windows.Forms.CheckBox
    Friend WithEvents chbxPagosDebe As System.Windows.Forms.CheckBox
    Friend WithEvents chbxFacturaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chbxDevengaciones As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents cbxGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
End Class
