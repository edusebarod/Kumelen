<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaIngresos
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
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.gb_Fecha = New System.Windows.Forms.GroupBox()
        Me.btnFecha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFEchaFinal2 = New System.Windows.Forms.Label()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.lblFechaInicial2 = New System.Windows.Forms.Label()
        Me.txtFechaFinal2 = New System.Windows.Forms.DateTimePicker()
        Me.btnServicio = New System.Windows.Forms.Button()
        Me.txtFecchaInicial2 = New System.Windows.Forms.DateTimePicker()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gb_Fecha.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(6, 26)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(132, 17)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Intervalo de Fechas"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Checked = False
        Me.txtFechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.txtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaInicial.Location = New System.Drawing.Point(236, 22)
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.ShowCheckBox = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaInicial.TabIndex = 4
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Checked = False
        Me.txtFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaFinal.Location = New System.Drawing.Point(236, 59)
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.ShowCheckBox = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaFinal.TabIndex = 5
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(182, 28)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(32, 13)
        Me.lblFechaInicial.TabIndex = 6
        Me.lblFechaInicial.Text = "Entre"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(182, 59)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaFinal.TabIndex = 7
        Me.lblFechaFinal.Text = "y"
        '
        'gb_Fecha
        '
        Me.gb_Fecha.Controls.Add(Me.btnFecha)
        Me.gb_Fecha.Controls.Add(Me.lblFechaFinal)
        Me.gb_Fecha.Controls.Add(Me.lblFechaInicial)
        Me.gb_Fecha.Controls.Add(Me.txtFechaFinal)
        Me.gb_Fecha.Controls.Add(Me.txtFechaInicial)
        Me.gb_Fecha.Controls.Add(Me.lbl_fecha)
        Me.gb_Fecha.Location = New System.Drawing.Point(12, 12)
        Me.gb_Fecha.Name = "gb_Fecha"
        Me.gb_Fecha.Size = New System.Drawing.Size(560, 97)
        Me.gb_Fecha.TabIndex = 9
        Me.gb_Fecha.TabStop = False
        Me.gb_Fecha.Text = "Búsqueda por Fecha"
        '
        'btnFecha
        '
        Me.btnFecha.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnFecha.Location = New System.Drawing.Point(508, 26)
        Me.btnFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(40, 42)
        Me.btnFecha.TabIndex = 3
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFEchaFinal2)
        Me.GroupBox1.Controls.Add(Me.cbxServicio)
        Me.GroupBox1.Controls.Add(Me.lblFechaInicial2)
        Me.GroupBox1.Controls.Add(Me.txtFechaFinal2)
        Me.GroupBox1.Controls.Add(Me.btnServicio)
        Me.GroupBox1.Controls.Add(Me.txtFecchaInicial2)
        Me.GroupBox1.Controls.Add(Me.lblServicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda Servicio"
        '
        'lblFEchaFinal2
        '
        Me.lblFEchaFinal2.AutoSize = True
        Me.lblFEchaFinal2.Location = New System.Drawing.Point(188, 108)
        Me.lblFEchaFinal2.Name = "lblFEchaFinal2"
        Me.lblFEchaFinal2.Size = New System.Drawing.Size(12, 13)
        Me.lblFEchaFinal2.TabIndex = 15
        Me.lblFEchaFinal2.Text = "y"
        '
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Location = New System.Drawing.Point(70, 26)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(432, 21)
        Me.cbxServicio.TabIndex = 4
        '
        'lblFechaInicial2
        '
        Me.lblFechaInicial2.AutoSize = True
        Me.lblFechaInicial2.Location = New System.Drawing.Point(188, 77)
        Me.lblFechaInicial2.Name = "lblFechaInicial2"
        Me.lblFechaInicial2.Size = New System.Drawing.Size(32, 13)
        Me.lblFechaInicial2.TabIndex = 14
        Me.lblFechaInicial2.Text = "Entre"
        '
        'txtFechaFinal2
        '
        Me.txtFechaFinal2.Checked = False
        Me.txtFechaFinal2.CustomFormat = "dd/MM/yyyy"
        Me.txtFechaFinal2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFechaFinal2.Location = New System.Drawing.Point(242, 108)
        Me.txtFechaFinal2.Name = "txtFechaFinal2"
        Me.txtFechaFinal2.ShowCheckBox = True
        Me.txtFechaFinal2.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaFinal2.TabIndex = 13
        '
        'btnServicio
        '
        Me.btnServicio.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnServicio.Location = New System.Drawing.Point(505, 79)
        Me.btnServicio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnServicio.Name = "btnServicio"
        Me.btnServicio.Size = New System.Drawing.Size(40, 42)
        Me.btnServicio.TabIndex = 3
        Me.btnServicio.UseVisualStyleBackColor = True
        '
        'txtFecchaInicial2
        '
        Me.txtFecchaInicial2.Checked = False
        Me.txtFecchaInicial2.CustomFormat = "dd/MM/yyyy"
        Me.txtFecchaInicial2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecchaInicial2.Location = New System.Drawing.Point(242, 71)
        Me.txtFecchaInicial2.Name = "txtFecchaInicial2"
        Me.txtFecchaInicial2.ShowCheckBox = True
        Me.txtFecchaInicial2.Size = New System.Drawing.Size(94, 20)
        Me.txtFecchaInicial2.TabIndex = 12
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(6, 26)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(58, 17)
        Me.lblServicio.TabIndex = 2
        Me.lblServicio.Text = "Servicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Intervalo de Fechas"
        '
        'frmBusquedaIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 292)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_Fecha)
        Me.Name = "frmBusquedaIngresos"
        Me.Text = "Ingresos"
        Me.gb_Fecha.ResumeLayout(False)
        Me.gb_Fecha.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents gb_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents btnFecha As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnServicio As System.Windows.Forms.Button
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents cbxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents lblFEchaFinal2 As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicial2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFinal2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFecchaInicial2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
