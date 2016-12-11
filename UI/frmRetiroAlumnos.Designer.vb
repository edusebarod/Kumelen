<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetiroAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetiroAlumnos))
        Me.cmdBuscaNombre = New System.Windows.Forms.Button()
        Me.cmdBuscaLegajo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.lblLegajo = New System.Windows.Forms.Label()
        Me.cmdBuscaApellido = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.txtNewApellido = New System.Windows.Forms.TextBox()
        Me.lblNewApellido = New System.Windows.Forms.Label()
        Me.txtNewNombre = New System.Windows.Forms.TextBox()
        Me.lblNewNombre = New System.Windows.Forms.Label()
        Me.txtNewVinculo = New System.Windows.Forms.TextBox()
        Me.lblVinculo = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBuscaNombre
        '
        Me.cmdBuscaNombre.Image = CType(resources.GetObject("cmdBuscaNombre.Image"), System.Drawing.Image)
        Me.cmdBuscaNombre.Location = New System.Drawing.Point(360, 38)
        Me.cmdBuscaNombre.Name = "cmdBuscaNombre"
        Me.cmdBuscaNombre.Size = New System.Drawing.Size(20, 20)
        Me.cmdBuscaNombre.TabIndex = 4
        Me.cmdBuscaNombre.UseVisualStyleBackColor = True
        '
        'cmdBuscaLegajo
        '
        Me.cmdBuscaLegajo.Image = CType(resources.GetObject("cmdBuscaLegajo.Image"), System.Drawing.Image)
        Me.cmdBuscaLegajo.Location = New System.Drawing.Point(181, 12)
        Me.cmdBuscaLegajo.Name = "cmdBuscaLegajo"
        Me.cmdBuscaLegajo.Size = New System.Drawing.Size(20, 20)
        Me.cmdBuscaLegajo.TabIndex = 2
        Me.cmdBuscaLegajo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 39)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(11, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'txtLegajo
        '
        Me.txtLegajo.Location = New System.Drawing.Point(75, 12)
        Me.txtLegajo.MaxLength = 12
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(100, 20)
        Me.txtLegajo.TabIndex = 1
        '
        'lblLegajo
        '
        Me.lblLegajo.AutoSize = True
        Me.lblLegajo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegajo.Location = New System.Drawing.Point(11, 16)
        Me.lblLegajo.Name = "lblLegajo"
        Me.lblLegajo.Size = New System.Drawing.Size(52, 16)
        Me.lblLegajo.TabIndex = 13
        Me.lblLegajo.Text = "Legajo"
        '
        'cmdBuscaApellido
        '
        Me.cmdBuscaApellido.Image = CType(resources.GetObject("cmdBuscaApellido.Image"), System.Drawing.Image)
        Me.cmdBuscaApellido.Location = New System.Drawing.Point(360, 65)
        Me.cmdBuscaApellido.Name = "cmdBuscaApellido"
        Me.cmdBuscaApellido.Size = New System.Drawing.Size(20, 20)
        Me.cmdBuscaApellido.TabIndex = 6
        Me.cmdBuscaApellido.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(75, 65)
        Me.txtApellido.MaxLength = 120
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(279, 20)
        Me.txtApellido.TabIndex = 5
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(11, 69)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblApellido.TabIndex = 21
        Me.lblApellido.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Lo puede retirar"
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.Location = New System.Drawing.Point(75, 136)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(305, 69)
        Me.lstRetiros.TabIndex = 7
        '
        'txtNewApellido
        '
        Me.txtNewApellido.Location = New System.Drawing.Point(75, 277)
        Me.txtNewApellido.MaxLength = 120
        Me.txtNewApellido.Name = "txtNewApellido"
        Me.txtNewApellido.Size = New System.Drawing.Size(305, 20)
        Me.txtNewApellido.TabIndex = 11
        '
        'lblNewApellido
        '
        Me.lblNewApellido.AutoSize = True
        Me.lblNewApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewApellido.Location = New System.Drawing.Point(11, 281)
        Me.lblNewApellido.Name = "lblNewApellido"
        Me.lblNewApellido.Size = New System.Drawing.Size(61, 16)
        Me.lblNewApellido.TabIndex = 27
        Me.lblNewApellido.Text = "Apellido"
        '
        'txtNewNombre
        '
        Me.txtNewNombre.Location = New System.Drawing.Point(75, 251)
        Me.txtNewNombre.MaxLength = 120
        Me.txtNewNombre.Name = "txtNewNombre"
        Me.txtNewNombre.Size = New System.Drawing.Size(305, 20)
        Me.txtNewNombre.TabIndex = 10
        '
        'lblNewNombre
        '
        Me.lblNewNombre.AutoSize = True
        Me.lblNewNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewNombre.Location = New System.Drawing.Point(11, 255)
        Me.lblNewNombre.Name = "lblNewNombre"
        Me.lblNewNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNewNombre.TabIndex = 25
        Me.lblNewNombre.Text = "Nombre"
        '
        'txtNewVinculo
        '
        Me.txtNewVinculo.Location = New System.Drawing.Point(75, 303)
        Me.txtNewVinculo.MaxLength = 120
        Me.txtNewVinculo.Name = "txtNewVinculo"
        Me.txtNewVinculo.Size = New System.Drawing.Size(305, 20)
        Me.txtNewVinculo.TabIndex = 12
        '
        'lblVinculo
        '
        Me.lblVinculo.AutoSize = True
        Me.lblVinculo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVinculo.Location = New System.Drawing.Point(11, 307)
        Me.lblVinculo.Name = "lblVinculo"
        Me.lblVinculo.Size = New System.Drawing.Size(56, 16)
        Me.lblVinculo.TabIndex = 29
        Me.lblVinculo.Text = "Vinculo"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(141, 211)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 34)
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = "&Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Location = New System.Drawing.Point(239, 211)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(75, 34)
        Me.cmdQuitar.TabIndex = 9
        Me.cmdQuitar.Text = "&Quitar"
        Me.cmdQuitar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(282, 329)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 13
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'frmRetiroAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 364)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdQuitar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.txtNewVinculo)
        Me.Controls.Add(Me.lblVinculo)
        Me.Controls.Add(Me.txtNewApellido)
        Me.Controls.Add(Me.lblNewApellido)
        Me.Controls.Add(Me.txtNewNombre)
        Me.Controls.Add(Me.lblNewNombre)
        Me.Controls.Add(Me.lstRetiros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBuscaApellido)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.cmdBuscaNombre)
        Me.Controls.Add(Me.cmdBuscaLegajo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.lblLegajo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetiroAlumnos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "<< Retiros de Alumnos >>"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuscaNombre As System.Windows.Forms.Button
    Friend WithEvents cmdBuscaLegajo As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents lblLegajo As System.Windows.Forms.Label
    Friend WithEvents cmdBuscaApellido As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstRetiros As System.Windows.Forms.ListBox
    Friend WithEvents txtNewApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblNewApellido As System.Windows.Forms.Label
    Friend WithEvents txtNewNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNewNombre As System.Windows.Forms.Label
    Friend WithEvents txtNewVinculo As System.Windows.Forms.TextBox
    Friend WithEvents lblVinculo As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
End Class
