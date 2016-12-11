<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevengacionXCursovia2
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
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDevengar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.lbl_obervaciones = New System.Windows.Forms.Label()
        Me.cbxVencimiento = New System.Windows.Forms.ComboBox()
        Me.lblVencimientos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxCurso
        '
        Me.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(98, 59)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(293, 21)
        Me.cbxCurso.TabIndex = 45
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(26, 60)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 46
        Me.lblSala.Text = "Sala"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Devengación por Sala"
        '
        'btnDevengar
        '
        Me.btnDevengar.Location = New System.Drawing.Point(211, 321)
        Me.btnDevengar.Name = "btnDevengar"
        Me.btnDevengar.Size = New System.Drawing.Size(98, 23)
        Me.btnDevengar.TabIndex = 48
        Me.btnDevengar.Text = "Devengar"
        Me.btnDevengar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(315, 321)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 49
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.cbxTurno.Location = New System.Drawing.Point(98, 92)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(292, 21)
        Me.cbxTurno.TabIndex = 50
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(26, 97)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 51
        Me.lblTurno.Text = "Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Servicio"
        '
        'cbxServicio
        '
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Location = New System.Drawing.Point(98, 160)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(292, 21)
        Me.cbxServicio.TabIndex = 55
        '
        'cbxCuenta
        '
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Location = New System.Drawing.Point(99, 126)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(292, 21)
        Me.cbxCuenta.TabIndex = 54
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(133, 229)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(256, 77)
        Me.txt_observaciones.TabIndex = 59
        '
        'lbl_obervaciones
        '
        Me.lbl_obervaciones.AutoSize = True
        Me.lbl_obervaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obervaciones.Location = New System.Drawing.Point(25, 229)
        Me.lbl_obervaciones.Name = "lbl_obervaciones"
        Me.lbl_obervaciones.Size = New System.Drawing.Size(101, 16)
        Me.lbl_obervaciones.TabIndex = 58
        Me.lbl_obervaciones.Text = "Observaciones"
        '
        'cbxVencimiento
        '
        Me.cbxVencimiento.FormattingEnabled = True
        Me.cbxVencimiento.Items.AddRange(New Object() {"3 vencimientos", "2 vencimientos", "1 vencimineto", "Sin vencimientos"})
        Me.cbxVencimiento.Location = New System.Drawing.Point(130, 193)
        Me.cbxVencimiento.Name = "cbxVencimiento"
        Me.cbxVencimiento.Size = New System.Drawing.Size(259, 21)
        Me.cbxVencimiento.TabIndex = 61
        '
        'lblVencimientos
        '
        Me.lblVencimientos.AutoSize = True
        Me.lblVencimientos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimientos.Location = New System.Drawing.Point(25, 193)
        Me.lblVencimientos.Name = "lblVencimientos"
        Me.lblVencimientos.Size = New System.Drawing.Size(93, 16)
        Me.lblVencimientos.TabIndex = 60
        Me.lblVencimientos.Text = "Vencimientos"
        '
        'frmDevengacionXCursovia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 358)
        Me.Controls.Add(Me.cbxVencimiento)
        Me.Controls.Add(Me.lblVencimientos)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.lbl_obervaciones)
        Me.Controls.Add(Me.cbxServicio)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDevengar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCurso)
        Me.Controls.Add(Me.lblSala)
        Me.Name = "frmDevengacionXCursovia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Devengacion por sala"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDevengar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents lbl_obervaciones As System.Windows.Forms.Label
    Friend WithEvents cbxVencimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblVencimientos As System.Windows.Forms.Label
End Class
