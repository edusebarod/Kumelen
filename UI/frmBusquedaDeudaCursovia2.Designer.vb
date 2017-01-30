<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaDeudaCursovia2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaDeudaCursovia2))
        Me.datos_sala = New System.Windows.Forms.GroupBox()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.txtTurno = New System.Windows.Forms.ComboBox()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.datos_sala.SuspendLayout()
        Me.SuspendLayout()
        '
        'datos_sala
        '
        Me.datos_sala.Controls.Add(Me.cbxCurso)
        Me.datos_sala.Controls.Add(Me.txtTurno)
        Me.datos_sala.Controls.Add(Me.lblSala)
        Me.datos_sala.Controls.Add(Me.lblTurno)
        Me.datos_sala.Location = New System.Drawing.Point(18, 15)
        Me.datos_sala.Name = "datos_sala"
        Me.datos_sala.Size = New System.Drawing.Size(622, 75)
        Me.datos_sala.TabIndex = 28
        Me.datos_sala.TabStop = False
        Me.datos_sala.Text = "Datos de la Sala"
        '
        'cbxCurso
        '
        Me.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(77, 32)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(250, 21)
        Me.cbxCurso.TabIndex = 29
        '
        'txtTurno
        '
        Me.txtTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTurno.FormattingEnabled = True
        Me.txtTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.txtTurno.Location = New System.Drawing.Point(449, 33)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(137, 21)
        Me.txtTurno.TabIndex = 28
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(14, 33)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(37, 16)
        Me.lblSala.TabIndex = 44
        Me.lblSala.Text = "Sala"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(373, 37)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 43
        Me.lblTurno.Text = "Turno"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(540, 113)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 36
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(488, 104)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 38)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmBusquedaDeudaCursovia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 152)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.datos_sala)
        Me.Name = "frmBusquedaDeudaCursovia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Deuda por Sala / Grado Vía 2"
        Me.datos_sala.ResumeLayout(False)
        Me.datos_sala.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datos_sala As System.Windows.Forms.GroupBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
