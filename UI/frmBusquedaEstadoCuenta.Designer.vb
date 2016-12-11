<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaEstadoCuenta
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
        Me.lbl_y = New System.Windows.Forms.Label()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_entre = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.txt_y = New System.Windows.Forms.DateTimePicker()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_y)
        Me.GroupBox1.Controls.Add(Me.cbx_tipo)
        Me.GroupBox1.Controls.Add(Me.lbl_entre)
        Me.GroupBox1.Controls.Add(Me.lbl_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_y)
        Me.GroupBox1.Controls.Add(Me.cbxCuenta)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 183)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda Cuenta"
        '
        'lbl_y
        '
        Me.lbl_y.AutoSize = True
        Me.lbl_y.Location = New System.Drawing.Point(181, 143)
        Me.lbl_y.Name = "lbl_y"
        Me.lbl_y.Size = New System.Drawing.Size(12, 13)
        Me.lbl_y.TabIndex = 15
        Me.lbl_y.Text = "y"
        '
        'cbx_tipo
        '
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"(1) Cuentas de Activo - Medios de Pago", "(2) Cuentas de Gasto", "(3) Cuentas de Deudores", "(4) Cuentas de Ganancias"})
        Me.cbx_tipo.Location = New System.Drawing.Point(116, 31)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(260, 21)
        Me.cbx_tipo.TabIndex = 11
        '
        'lbl_entre
        '
        Me.lbl_entre.AutoSize = True
        Me.lbl_entre.Location = New System.Drawing.Point(181, 112)
        Me.lbl_entre.Name = "lbl_entre"
        Me.lbl_entre.Size = New System.Drawing.Size(32, 13)
        Me.lbl_entre.TabIndex = 14
        Me.lbl_entre.Text = "Entre"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.Location = New System.Drawing.Point(5, 31)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(105, 17)
        Me.lbl_tipo.TabIndex = 12
        Me.lbl_tipo.Text = "Tipo de Cuenta"
        '
        'txt_y
        '
        Me.txt_y.Checked = False
        Me.txt_y.CustomFormat = "dd/MM/yyyy"
        Me.txt_y.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_y.Location = New System.Drawing.Point(235, 143)
        Me.txt_y.Name = "txt_y"
        Me.txt_y.ShowCheckBox = True
        Me.txt_y.Size = New System.Drawing.Size(94, 20)
        Me.txt_y.TabIndex = 13
        '
        'cbxCuenta
        '
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Location = New System.Drawing.Point(69, 70)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(307, 21)
        Me.cbxCuenta.TabIndex = 1
        '
        'txt_fecha
        '
        Me.txt_fecha.Checked = False
        Me.txt_fecha.CustomFormat = "dd/MM/yyyy"
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_fecha.Location = New System.Drawing.Point(235, 106)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.ShowCheckBox = True
        Me.txt_fecha.Size = New System.Drawing.Size(94, 20)
        Me.txt_fecha.TabIndex = 12
        Me.txt_fecha.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(5, 70)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(53, 17)
        Me.lblCuenta.TabIndex = 2
        Me.lblCuenta.Text = "Cuenta"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(5, 110)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(132, 17)
        Me.lbl_fecha.TabIndex = 11
        Me.lbl_fecha.Text = "Intervalo de Fechas"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(341, 222)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(260, 222)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'frmBusquedaEstadoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 268)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBusquedaEstadoCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Estado de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents cbx_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_y As System.Windows.Forms.Label
    Friend WithEvents lbl_entre As System.Windows.Forms.Label
    Friend WithEvents txt_y As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
End Class
