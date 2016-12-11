<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionXCurso
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
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.cbxPtoVta = New System.Windows.Forms.ComboBox()
        Me.lblPtoVta = New System.Windows.Forms.Label()
        Me.cbxServicio = New System.Windows.Forms.ComboBox()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.txtVencimiento1 = New System.Windows.Forms.DateTimePicker()
        Me.lblVencimiento1 = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtEncargado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxCurso
        '
        Me.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(98, 59)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(293, 21)
        Me.cbxCurso.TabIndex = 1
        Me.cbxCurso.Tag = "Sala a facturar"
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(26, 60)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(46, 16)
        Me.lblSala.TabIndex = 46
        Me.lblSala.Text = "Sala *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Facturación por Sala"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(211, 398)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(98, 23)
        Me.btnContinuar.TabIndex = 9
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(315, 398)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
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
        Me.cbxTurno.TabIndex = 2
        Me.cbxTurno.Tag = "Turno de la Sala a  facturar"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(26, 97)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(53, 16)
        Me.lblTurno.TabIndex = 51
        Me.lblTurno.Text = "Turno *"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(26, 128)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(62, 16)
        Me.lblCuenta.TabIndex = 52
        Me.lblCuenta.Text = "Cuenta *"
        '
        'cbxCuenta
        '
        Me.cbxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.Location = New System.Drawing.Point(99, 126)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(292, 21)
        Me.cbxCuenta.TabIndex = 3
        Me.cbxCuenta.Tag = "Cuenta contable contra la que se facturara"
        '
        'cbxPtoVta
        '
        Me.cbxPtoVta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPtoVta.FormattingEnabled = True
        Me.cbxPtoVta.Items.AddRange(New Object() {"0002", "0003", "0004"})
        Me.cbxPtoVta.Location = New System.Drawing.Point(147, 194)
        Me.cbxPtoVta.Name = "cbxPtoVta"
        Me.cbxPtoVta.Size = New System.Drawing.Size(95, 21)
        Me.cbxPtoVta.TabIndex = 5
        Me.cbxPtoVta.Tag = "Punto de Venta a utilizar"
        '
        'lblPtoVta
        '
        Me.lblPtoVta.AutoSize = True
        Me.lblPtoVta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtoVta.Location = New System.Drawing.Point(26, 199)
        Me.lblPtoVta.Name = "lblPtoVta"
        Me.lblPtoVta.Size = New System.Drawing.Size(114, 16)
        Me.lblPtoVta.TabIndex = 72
        Me.lblPtoVta.Text = "Punto de Venta *"
        '
        'cbxServicio
        '
        Me.cbxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServicio.FormattingEnabled = True
        Me.cbxServicio.Location = New System.Drawing.Point(99, 160)
        Me.cbxServicio.Name = "cbxServicio"
        Me.cbxServicio.Size = New System.Drawing.Size(292, 21)
        Me.cbxServicio.TabIndex = 4
        Me.cbxServicio.Tag = "Servicio a facturar"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(25, 162)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(69, 16)
        Me.lblServicio.TabIndex = 73
        Me.lblServicio.Text = "Servicio *"
        '
        'txtVencimiento1
        '
        Me.txtVencimiento1.Checked = False
        Me.txtVencimiento1.CustomFormat = "dd/MM/yyyy"
        Me.txtVencimiento1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimiento1.Location = New System.Drawing.Point(148, 230)
        Me.txtVencimiento1.Name = "txtVencimiento1"
        Me.txtVencimiento1.ShowCheckBox = True
        Me.txtVencimiento1.Size = New System.Drawing.Size(94, 20)
        Me.txtVencimiento1.TabIndex = 6
        Me.txtVencimiento1.Tag = "1 Vencimiento de las devengaciones a facturar"
        '
        'lblVencimiento1
        '
        Me.lblVencimiento1.AutoSize = True
        Me.lblVencimiento1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento1.Location = New System.Drawing.Point(26, 232)
        Me.lblVencimiento1.Name = "lblVencimiento1"
        Me.lblVencimiento1.Size = New System.Drawing.Size(107, 16)
        Me.lblVencimiento1.TabIndex = 76
        Me.lblVencimiento1.Text = "Vencimiento 1 *"
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(26, 266)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(85, 16)
        Me.lblEncargado.TabIndex = 77
        Me.lblEncargado.Text = "Encargado *"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(25, 302)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 16)
        Me.lblObservaciones.TabIndex = 78
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtEncargado
        '
        Me.txtEncargado.Location = New System.Drawing.Point(147, 265)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(243, 20)
        Me.txtEncargado.TabIndex = 7
        Me.txtEncargado.Tag = "Persona que abona el servicio o producto"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(147, 301)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(243, 56)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.Tag = "Observaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(25, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 15)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "(Los campos marcados con * son obligatorios)"
        '
        'frmFacturacionXCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 435)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtEncargado)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblEncargado)
        Me.Controls.Add(Me.txtVencimiento1)
        Me.Controls.Add(Me.lblVencimiento1)
        Me.Controls.Add(Me.cbxServicio)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.cbxPtoVta)
        Me.Controls.Add(Me.lblPtoVta)
        Me.Controls.Add(Me.cbxCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCurso)
        Me.Controls.Add(Me.lblSala)
        Me.Name = "frmFacturacionXCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación por sala"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPtoVta As System.Windows.Forms.ComboBox
    Friend WithEvents lblPtoVta As System.Windows.Forms.Label
    Friend WithEvents cbxServicio As System.Windows.Forms.ComboBox
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents txtVencimiento1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
