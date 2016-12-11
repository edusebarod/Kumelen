<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFacturas
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
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.txt_nroFactura = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_y = New System.Windows.Forms.DateTimePicker()
        Me.lbl_entre = New System.Windows.Forms.Label()
        Me.lbl_y = New System.Windows.Forms.Label()
        Me.gb_nrofactura = New System.Windows.Forms.GroupBox()
        Me.cbb_PtoVenta = New System.Windows.Forms.ComboBox()
        Me.lbl_PtoVenta = New System.Windows.Forms.Label()
        Me.btn_NroFactura = New System.Windows.Forms.Button()
        Me.gb_Fecha = New System.Windows.Forms.GroupBox()
        Me.btn_Fecha = New System.Windows.Forms.Button()
        Me.gb_Alumno = New System.Windows.Forms.GroupBox()
        Me.btn_Alumno = New System.Windows.Forms.Button()
        Me.txt_NombreAlumno = New System.Windows.Forms.TextBox()
        Me.lbl_NombreAlumno = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.gb_nrofactura.SuspendLayout()
        Me.gb_Fecha.SuspendLayout()
        Me.gb_Alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_factura.Location = New System.Drawing.Point(6, 57)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(103, 17)
        Me.lbl_factura.TabIndex = 0
        Me.lbl_factura.Text = "Nro de Factura"
        '
        'txt_nroFactura
        '
        Me.txt_nroFactura.Location = New System.Drawing.Point(181, 57)
        Me.txt_nroFactura.Name = "txt_nroFactura"
        Me.txt_nroFactura.Size = New System.Drawing.Size(206, 20)
        Me.txt_nroFactura.TabIndex = 1
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
        'txt_fecha
        '
        Me.txt_fecha.Checked = False
        Me.txt_fecha.CustomFormat = "dd/MM/yyyy"
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_fecha.Location = New System.Drawing.Point(236, 22)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.ShowCheckBox = True
        Me.txt_fecha.Size = New System.Drawing.Size(94, 20)
        Me.txt_fecha.TabIndex = 4
        Me.txt_fecha.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'txt_y
        '
        Me.txt_y.Checked = False
        Me.txt_y.CustomFormat = "dd/MM/yyyy"
        Me.txt_y.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_y.Location = New System.Drawing.Point(236, 59)
        Me.txt_y.Name = "txt_y"
        Me.txt_y.ShowCheckBox = True
        Me.txt_y.Size = New System.Drawing.Size(94, 20)
        Me.txt_y.TabIndex = 5
        '
        'lbl_entre
        '
        Me.lbl_entre.AutoSize = True
        Me.lbl_entre.Location = New System.Drawing.Point(182, 28)
        Me.lbl_entre.Name = "lbl_entre"
        Me.lbl_entre.Size = New System.Drawing.Size(32, 13)
        Me.lbl_entre.TabIndex = 6
        Me.lbl_entre.Text = "Entre"
        '
        'lbl_y
        '
        Me.lbl_y.AutoSize = True
        Me.lbl_y.Location = New System.Drawing.Point(182, 59)
        Me.lbl_y.Name = "lbl_y"
        Me.lbl_y.Size = New System.Drawing.Size(12, 13)
        Me.lbl_y.TabIndex = 7
        Me.lbl_y.Text = "y"
        '
        'gb_nrofactura
        '
        Me.gb_nrofactura.Controls.Add(Me.cbb_PtoVenta)
        Me.gb_nrofactura.Controls.Add(Me.lbl_PtoVenta)
        Me.gb_nrofactura.Controls.Add(Me.btn_NroFactura)
        Me.gb_nrofactura.Controls.Add(Me.txt_nroFactura)
        Me.gb_nrofactura.Controls.Add(Me.lbl_factura)
        Me.gb_nrofactura.Location = New System.Drawing.Point(23, 22)
        Me.gb_nrofactura.Name = "gb_nrofactura"
        Me.gb_nrofactura.Size = New System.Drawing.Size(450, 96)
        Me.gb_nrofactura.TabIndex = 8
        Me.gb_nrofactura.TabStop = False
        Me.gb_nrofactura.Text = "Búsqueda por Nro de Factura"
        '
        'cbb_PtoVenta
        '
        Me.cbb_PtoVenta.FormattingEnabled = True
        Me.cbb_PtoVenta.Items.AddRange(New Object() {"0001", "0002", "0003", "0004"})
        Me.cbb_PtoVenta.Location = New System.Drawing.Point(181, 31)
        Me.cbb_PtoVenta.Name = "cbb_PtoVenta"
        Me.cbb_PtoVenta.Size = New System.Drawing.Size(206, 21)
        Me.cbb_PtoVenta.TabIndex = 5
        '
        'lbl_PtoVenta
        '
        Me.lbl_PtoVenta.AutoSize = True
        Me.lbl_PtoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PtoVenta.Location = New System.Drawing.Point(7, 32)
        Me.lbl_PtoVenta.Name = "lbl_PtoVenta"
        Me.lbl_PtoVenta.Size = New System.Drawing.Size(104, 17)
        Me.lbl_PtoVenta.TabIndex = 3
        Me.lbl_PtoVenta.Text = "Punto de venta"
        '
        'btn_NroFactura
        '
        Me.btn_NroFactura.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_NroFactura.Location = New System.Drawing.Point(404, 32)
        Me.btn_NroFactura.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_NroFactura.Name = "btn_NroFactura"
        Me.btn_NroFactura.Size = New System.Drawing.Size(40, 42)
        Me.btn_NroFactura.TabIndex = 2
        Me.btn_NroFactura.UseVisualStyleBackColor = True
        '
        'gb_Fecha
        '
        Me.gb_Fecha.Controls.Add(Me.btn_Fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_y)
        Me.gb_Fecha.Controls.Add(Me.lbl_entre)
        Me.gb_Fecha.Controls.Add(Me.txt_y)
        Me.gb_Fecha.Controls.Add(Me.txt_fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_fecha)
        Me.gb_Fecha.Location = New System.Drawing.Point(23, 124)
        Me.gb_Fecha.Name = "gb_Fecha"
        Me.gb_Fecha.Size = New System.Drawing.Size(450, 97)
        Me.gb_Fecha.TabIndex = 9
        Me.gb_Fecha.TabStop = False
        Me.gb_Fecha.Text = "Búsqueda por Fecha"
        '
        'btn_Fecha
        '
        Me.btn_Fecha.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_Fecha.Location = New System.Drawing.Point(404, 26)
        Me.btn_Fecha.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Fecha.Name = "btn_Fecha"
        Me.btn_Fecha.Size = New System.Drawing.Size(40, 42)
        Me.btn_Fecha.TabIndex = 3
        Me.btn_Fecha.UseVisualStyleBackColor = True
        '
        'gb_Alumno
        '
        Me.gb_Alumno.Controls.Add(Me.btn_Alumno)
        Me.gb_Alumno.Controls.Add(Me.txt_NombreAlumno)
        Me.gb_Alumno.Controls.Add(Me.lbl_NombreAlumno)
        Me.gb_Alumno.Location = New System.Drawing.Point(24, 236)
        Me.gb_Alumno.Name = "gb_Alumno"
        Me.gb_Alumno.Size = New System.Drawing.Size(449, 70)
        Me.gb_Alumno.TabIndex = 10
        Me.gb_Alumno.TabStop = False
        Me.gb_Alumno.Text = "Búsqueda por Alumno"
        '
        'btn_Alumno
        '
        Me.btn_Alumno.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_Alumno.Location = New System.Drawing.Point(403, 14)
        Me.btn_Alumno.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Alumno.Name = "btn_Alumno"
        Me.btn_Alumno.Size = New System.Drawing.Size(40, 42)
        Me.btn_Alumno.TabIndex = 4
        Me.btn_Alumno.UseVisualStyleBackColor = True
        '
        'txt_NombreAlumno
        '
        Me.txt_NombreAlumno.Location = New System.Drawing.Point(180, 38)
        Me.txt_NombreAlumno.Name = "txt_NombreAlumno"
        Me.txt_NombreAlumno.Size = New System.Drawing.Size(206, 20)
        Me.txt_NombreAlumno.TabIndex = 3
        '
        'lbl_NombreAlumno
        '
        Me.lbl_NombreAlumno.AutoSize = True
        Me.lbl_NombreAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreAlumno.Location = New System.Drawing.Point(6, 39)
        Me.lbl_NombreAlumno.Name = "lbl_NombreAlumno"
        Me.lbl_NombreAlumno.Size = New System.Drawing.Size(136, 17)
        Me.lbl_NombreAlumno.TabIndex = 2
        Me.lbl_NombreAlumno.Text = "Nombre del Alumno:"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.Location = New System.Drawing.Point(355, 312)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(118, 36)
        Me.btnVerTodos.TabIndex = 21
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.UseVisualStyleBackColor = True
        '
        'frmBuscarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 359)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.gb_Alumno)
        Me.Controls.Add(Me.gb_Fecha)
        Me.Controls.Add(Me.gb_nrofactura)
        Me.Name = "frmBuscarFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Busqueda de facturas Vía 1"
        Me.gb_nrofactura.ResumeLayout(False)
        Me.gb_nrofactura.PerformLayout()
        Me.gb_Fecha.ResumeLayout(False)
        Me.gb_Fecha.PerformLayout()
        Me.gb_Alumno.ResumeLayout(False)
        Me.gb_Alumno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_factura As System.Windows.Forms.Label
    Friend WithEvents txt_nroFactura As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_y As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_entre As System.Windows.Forms.Label
    Friend WithEvents lbl_y As System.Windows.Forms.Label
    Friend WithEvents gb_nrofactura As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents gb_Alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreAlumno As System.Windows.Forms.Label
    Friend WithEvents btn_NroFactura As System.Windows.Forms.Button
    Friend WithEvents btn_Fecha As System.Windows.Forms.Button
    Friend WithEvents btn_Alumno As System.Windows.Forms.Button
    Friend WithEvents lbl_PtoVenta As System.Windows.Forms.Label
    Friend WithEvents cbb_PtoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
End Class
