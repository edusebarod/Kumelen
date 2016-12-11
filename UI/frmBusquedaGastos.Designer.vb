<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaGastos
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
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_y = New System.Windows.Forms.DateTimePicker()
        Me.lbl_entre = New System.Windows.Forms.Label()
        Me.lbl_y = New System.Windows.Forms.Label()
        Me.gb_Fecha = New System.Windows.Forms.GroupBox()
        Me.btn_Fecha = New System.Windows.Forms.Button()
        Me.gb_Fecha.SuspendLayout()
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
        'gb_Fecha
        '
        Me.gb_Fecha.Controls.Add(Me.btn_Fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_y)
        Me.gb_Fecha.Controls.Add(Me.lbl_entre)
        Me.gb_Fecha.Controls.Add(Me.txt_y)
        Me.gb_Fecha.Controls.Add(Me.txt_fecha)
        Me.gb_Fecha.Controls.Add(Me.lbl_fecha)
        Me.gb_Fecha.Location = New System.Drawing.Point(12, 12)
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
        'frmBusquedaGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 118)
        Me.Controls.Add(Me.gb_Fecha)
        Me.Name = "frmBusquedaGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gastos"
        Me.gb_Fecha.ResumeLayout(False)
        Me.gb_Fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_y As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_entre As System.Windows.Forms.Label
    Friend WithEvents lbl_y As System.Windows.Forms.Label
    Friend WithEvents gb_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Fecha As System.Windows.Forms.Button
End Class
