<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDevengacionesvia1
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
        Me.gb_Alumno = New System.Windows.Forms.GroupBox()
        Me.btn_Alumno = New System.Windows.Forms.Button()
        Me.txt_NombreAlumno = New System.Windows.Forms.TextBox()
        Me.lbl_NombreAlumno = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.bg_NroDeveng = New System.Windows.Forms.GroupBox()
        Me.btn_NroDeveng = New System.Windows.Forms.Button()
        Me.txt_NroDevengacion = New System.Windows.Forms.TextBox()
        Me.lbl_NroDevengacion = New System.Windows.Forms.Label()
        Me.gb_Fecha = New System.Windows.Forms.GroupBox()
        Me.btn_Fecha = New System.Windows.Forms.Button()
        Me.lbl_y = New System.Windows.Forms.Label()
        Me.lbl_entre = New System.Windows.Forms.Label()
        Me.txt_y = New System.Windows.Forms.DateTimePicker()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.gb_Alumno.SuspendLayout()
        Me.bg_NroDeveng.SuspendLayout()
        Me.gb_Fecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Alumno
        '
        Me.gb_Alumno.Controls.Add(Me.btn_Alumno)
        Me.gb_Alumno.Controls.Add(Me.txt_NombreAlumno)
        Me.gb_Alumno.Controls.Add(Me.lbl_NombreAlumno)
        Me.gb_Alumno.Location = New System.Drawing.Point(23, 23)
        Me.gb_Alumno.Name = "gb_Alumno"
        Me.gb_Alumno.Size = New System.Drawing.Size(449, 78)
        Me.gb_Alumno.TabIndex = 10
        Me.gb_Alumno.TabStop = False
        Me.gb_Alumno.Text = "Búsqueda por Alumno"
        '
        'btn_Alumno
        '
        Me.btn_Alumno.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_Alumno.Location = New System.Drawing.Point(403, 16)
        Me.btn_Alumno.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Alumno.Name = "btn_Alumno"
        Me.btn_Alumno.Size = New System.Drawing.Size(40, 42)
        Me.btn_Alumno.TabIndex = 4
        Me.btn_Alumno.TabStop = False
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
        Me.btnVerTodos.Location = New System.Drawing.Point(354, 304)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(118, 36)
        Me.btnVerTodos.TabIndex = 20
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.UseVisualStyleBackColor = True
        '
        'bg_NroDeveng
        '
        Me.bg_NroDeveng.Controls.Add(Me.btn_NroDeveng)
        Me.bg_NroDeveng.Controls.Add(Me.txt_NroDevengacion)
        Me.bg_NroDeveng.Controls.Add(Me.lbl_NroDevengacion)
        Me.bg_NroDeveng.Location = New System.Drawing.Point(23, 228)
        Me.bg_NroDeveng.Name = "bg_NroDeveng"
        Me.bg_NroDeveng.Size = New System.Drawing.Size(449, 70)
        Me.bg_NroDeveng.TabIndex = 12
        Me.bg_NroDeveng.TabStop = False
        Me.bg_NroDeveng.Text = "Búsqueda por Nro de Devengación"
        '
        'btn_NroDeveng
        '
        Me.btn_NroDeveng.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_NroDeveng.Location = New System.Drawing.Point(403, 14)
        Me.btn_NroDeveng.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_NroDeveng.Name = "btn_NroDeveng"
        Me.btn_NroDeveng.Size = New System.Drawing.Size(40, 42)
        Me.btn_NroDeveng.TabIndex = 4
        Me.btn_NroDeveng.UseVisualStyleBackColor = True
        '
        'txt_NroDevengacion
        '
        Me.txt_NroDevengacion.Location = New System.Drawing.Point(180, 38)
        Me.txt_NroDevengacion.Name = "txt_NroDevengacion"
        Me.txt_NroDevengacion.Size = New System.Drawing.Size(206, 20)
        Me.txt_NroDevengacion.TabIndex = 3
        '
        'lbl_NroDevengacion
        '
        Me.lbl_NroDevengacion.AutoSize = True
        Me.lbl_NroDevengacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroDevengacion.Location = New System.Drawing.Point(6, 39)
        Me.lbl_NroDevengacion.Name = "lbl_NroDevengacion"
        Me.lbl_NroDevengacion.Size = New System.Drawing.Size(138, 17)
        Me.lbl_NroDevengacion.TabIndex = 2
        Me.lbl_NroDevengacion.Text = "Nro de Devengación"
        '
        'gb_Fecha
        '
        Me.gb_Fecha.Controls.Add(Me.btn_Fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_y)
        Me.gb_Fecha.Controls.Add(Me.lbl_entre)
        Me.gb_Fecha.Controls.Add(Me.txt_y)
        Me.gb_Fecha.Controls.Add(Me.txt_fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_fecha)
        Me.gb_Fecha.Location = New System.Drawing.Point(22, 116)
        Me.gb_Fecha.Name = "gb_Fecha"
        Me.gb_Fecha.Size = New System.Drawing.Size(450, 97)
        Me.gb_Fecha.TabIndex = 11
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
        'lbl_y
        '
        Me.lbl_y.AutoSize = True
        Me.lbl_y.Location = New System.Drawing.Point(182, 59)
        Me.lbl_y.Name = "lbl_y"
        Me.lbl_y.Size = New System.Drawing.Size(12, 13)
        Me.lbl_y.TabIndex = 7
        Me.lbl_y.Text = "y"
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
        'frmBuscarDevengacionesvia1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 352)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.bg_NroDeveng)
        Me.Controls.Add(Me.gb_Fecha)
        Me.Controls.Add(Me.gb_Alumno)
        Me.Name = "frmBuscarDevengacionesvia1"
        Me.Text = "Busqueda de devengaciones Vía 1"
        Me.gb_Alumno.ResumeLayout(False)
        Me.gb_Alumno.PerformLayout()
        Me.bg_NroDeveng.ResumeLayout(False)
        Me.bg_NroDeveng.PerformLayout()
        Me.gb_Fecha.ResumeLayout(False)
        Me.gb_Fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreAlumno As System.Windows.Forms.Label
    Friend WithEvents btn_Alumno As System.Windows.Forms.Button
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
    Friend WithEvents bg_NroDeveng As System.Windows.Forms.GroupBox
    Friend WithEvents btn_NroDeveng As System.Windows.Forms.Button
    Friend WithEvents txt_NroDevengacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroDevengacion As System.Windows.Forms.Label
    Friend WithEvents gb_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Fecha As System.Windows.Forms.Button
    Friend WithEvents lbl_y As System.Windows.Forms.Label
    Friend WithEvents lbl_entre As System.Windows.Forms.Label
    Friend WithEvents txt_y As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
End Class
