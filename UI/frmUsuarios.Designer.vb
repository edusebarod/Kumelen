<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtObse = New System.Windows.Forms.TextBox()
        Me.lblObser = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtClaveRe = New System.Windows.Forms.TextBox()
        Me.lblClaveRe = New System.Windows.Forms.Label()
        Me.cmdBuscaLogin = New System.Windows.Forms.Button()
        Me.cmdBuscaNombre = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(259, 65)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(66, 20)
        Me.chkActivo.TabIndex = 5
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtObse
        '
        Me.txtObse.Location = New System.Drawing.Point(129, 114)
        Me.txtObse.MaxLength = 250
        Me.txtObse.Multiline = True
        Me.txtObse.Name = "txtObse"
        Me.txtObse.Size = New System.Drawing.Size(293, 59)
        Me.txtObse.TabIndex = 7
        '
        'lblObser
        '
        Me.lblObser.AutoSize = True
        Me.lblObser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObser.Location = New System.Drawing.Point(12, 115)
        Me.lblObser.Name = "lblObser"
        Me.lblObser.Size = New System.Drawing.Size(101, 16)
        Me.lblObser.TabIndex = 32
        Me.lblObser.Text = "Observaciones"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(129, 62)
        Me.txtClave.MaxLength = 250
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(124, 20)
        Me.txtClave.TabIndex = 3
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(12, 66)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(44, 16)
        Me.lblClave.TabIndex = 30
        Me.lblClave.Text = "Clave"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(73, 36)
        Me.txtLogin.MaxLength = 50
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(180, 20)
        Me.txtLogin.TabIndex = 2
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(12, 40)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(44, 16)
        Me.lblLogin.TabIndex = 29
        Me.lblLogin.Text = "Login"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 10)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 14)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 16)
        Me.lblNombre.TabIndex = 19
        Me.lblNombre.Text = "Nombre"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(259, 92)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 16)
        Me.lblTipo.TabIndex = 33
        Me.lblTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(301, 87)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 6
        '
        'txtClaveRe
        '
        Me.txtClaveRe.Location = New System.Drawing.Point(129, 88)
        Me.txtClaveRe.MaxLength = 250
        Me.txtClaveRe.Name = "txtClaveRe"
        Me.txtClaveRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveRe.Size = New System.Drawing.Size(124, 20)
        Me.txtClaveRe.TabIndex = 4
        '
        'lblClaveRe
        '
        Me.lblClaveRe.AutoSize = True
        Me.lblClaveRe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveRe.Location = New System.Drawing.Point(12, 92)
        Me.lblClaveRe.Name = "lblClaveRe"
        Me.lblClaveRe.Size = New System.Drawing.Size(94, 16)
        Me.lblClaveRe.TabIndex = 36
        Me.lblClaveRe.Text = "Repetir Clave"
        '
        'cmdBuscaLogin
        '
        Me.cmdBuscaLogin.Image = CType(resources.GetObject("cmdBuscaLogin.Image"), System.Drawing.Image)
        Me.cmdBuscaLogin.Location = New System.Drawing.Point(259, 36)
        Me.cmdBuscaLogin.Name = "cmdBuscaLogin"
        Me.cmdBuscaLogin.Size = New System.Drawing.Size(20, 20)
        Me.cmdBuscaLogin.TabIndex = 12
        Me.cmdBuscaLogin.UseVisualStyleBackColor = True
        '
        'cmdBuscaNombre
        '
        Me.cmdBuscaNombre.Image = CType(resources.GetObject("cmdBuscaNombre.Image"), System.Drawing.Image)
        Me.cmdBuscaNombre.Location = New System.Drawing.Point(259, 10)
        Me.cmdBuscaNombre.Name = "cmdBuscaNombre"
        Me.cmdBuscaNombre.Size = New System.Drawing.Size(20, 20)
        Me.cmdBuscaNombre.TabIndex = 11
        Me.cmdBuscaNombre.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(298, 192)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 10
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGrabar.Location = New System.Drawing.Point(165, 192)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(100, 29)
        Me.cmdGrabar.TabIndex = 9
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(32, 192)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(100, 29)
        Me.cmdNuevo.TabIndex = 8
        Me.cmdNuevo.Text = "&NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(430, 239)
        Me.Controls.Add(Me.cmdBuscaLogin)
        Me.Controls.Add(Me.cmdBuscaNombre)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.txtClaveRe)
        Me.Controls.Add(Me.lblClaveRe)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtObse)
        Me.Controls.Add(Me.lblObser)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "<< Usuarios >>"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtObse As System.Windows.Forms.TextBox
    Friend WithEvents lblObser As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtClaveRe As System.Windows.Forms.TextBox
    Friend WithEvents lblClaveRe As System.Windows.Forms.Label
    Friend WithEvents cmdBuscaLogin As System.Windows.Forms.Button
    Friend WithEvents cmdBuscaNombre As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
End Class
