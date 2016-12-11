<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCursosvia2
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
        Me.cbxDocente = New System.Windows.Forms.ComboBox()
        Me.lblDocente = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtAñoLectivo = New System.Windows.Forms.TextBox()
        Me.lblAñoLectivo = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdBuscaNombre = New System.Windows.Forms.Button()
        Me.cmdVerTodos = New System.Windows.Forms.Button()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtTurno = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbxDocente
        '
        Me.cbxDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDocente.FormattingEnabled = True
        Me.cbxDocente.Location = New System.Drawing.Point(101, 99)
        Me.cbxDocente.Name = "cbxDocente"
        Me.cbxDocente.Size = New System.Drawing.Size(278, 21)
        Me.cbxDocente.TabIndex = 6
        '
        'lblDocente
        '
        Me.lblDocente.AutoSize = True
        Me.lblDocente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocente.Location = New System.Drawing.Point(13, 100)
        Me.lblDocente.Name = "lblDocente"
        Me.lblDocente.Size = New System.Drawing.Size(60, 16)
        Me.lblDocente.TabIndex = 49
        Me.lblDocente.Text = "Docente"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 176)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(102, 31)
        Me.cmdNuevo.TabIndex = 8
        Me.cmdNuevo.Text = "&NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = False
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(237, 47)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(66, 20)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 21)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 48
        Me.lblNombre.Text = "Nombre"
        '
        'txtAñoLectivo
        '
        Me.txtAñoLectivo.Location = New System.Drawing.Point(101, 47)
        Me.txtAñoLectivo.MaxLength = 12
        Me.txtAñoLectivo.Name = "txtAñoLectivo"
        Me.txtAñoLectivo.Size = New System.Drawing.Size(118, 20)
        Me.txtAñoLectivo.TabIndex = 3
        '
        'lblAñoLectivo
        '
        Me.lblAñoLectivo.AutoSize = True
        Me.lblAñoLectivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoLectivo.Location = New System.Drawing.Point(12, 51)
        Me.lblAñoLectivo.Name = "lblAñoLectivo"
        Me.lblAñoLectivo.Size = New System.Drawing.Size(83, 16)
        Me.lblAñoLectivo.TabIndex = 47
        Me.lblAñoLectivo.Text = "Año Lectivo"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(277, 176)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(102, 31)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(143, 176)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(102, 31)
        Me.cmdGrabar.TabIndex = 9
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdBuscaNombre
        '
        Me.cmdBuscaNombre.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.cmdBuscaNombre.Location = New System.Drawing.Point(342, 21)
        Me.cmdBuscaNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdBuscaNombre.Name = "cmdBuscaNombre"
        Me.cmdBuscaNombre.Size = New System.Drawing.Size(37, 38)
        Me.cmdBuscaNombre.TabIndex = 2
        Me.cmdBuscaNombre.UseVisualStyleBackColor = True
        '
        'cmdVerTodos
        '
        Me.cmdVerTodos.Location = New System.Drawing.Point(277, 126)
        Me.cmdVerTodos.Name = "cmdVerTodos"
        Me.cmdVerTodos.Size = New System.Drawing.Size(102, 36)
        Me.cmdVerTodos.TabIndex = 7
        Me.cmdVerTodos.Text = "Ver todos"
        Me.cmdVerTodos.UseVisualStyleBackColor = True
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(12, 77)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 54
        Me.lblTurno.Text = "Turno"
        '
        'txtTurno
        '
        Me.txtTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTurno.FormattingEnabled = True
        Me.txtTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.txtTurno.Location = New System.Drawing.Point(101, 73)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(118, 21)
        Me.txtTurno.TabIndex = 5
        '
        'frmCursosvia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 219)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.cmdVerTodos)
        Me.Controls.Add(Me.cbxDocente)
        Me.Controls.Add(Me.lblDocente)
        Me.Controls.Add(Me.cmdBuscaNombre)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtAñoLectivo)
        Me.Controls.Add(Me.lblAñoLectivo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Name = "frmCursosvia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Salas - Grados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxDocente As System.Windows.Forms.ComboBox
    Friend WithEvents lblDocente As System.Windows.Forms.Label
    Friend WithEvents cmdBuscaNombre As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtAñoLectivo As System.Windows.Forms.TextBox
    Friend WithEvents lblAñoLectivo As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdVerTodos As System.Windows.Forms.Button
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.ComboBox
End Class
