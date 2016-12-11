<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosNegociovia2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosNegociovia2))
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.lblCUIT = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBuscaProv = New System.Windows.Forms.Button()
        Me.Preoveedor = New System.Windows.Forms.GroupBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Preoveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(360, 229)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 29)
        Me.cmdSalir.TabIndex = 9
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Location = New System.Drawing.Point(240, 229)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(100, 29)
        Me.cmdGrabar.TabIndex = 8
        Me.cmdGrabar.Text = "&GRABAR"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(9, 125)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(63, 16)
        Me.lblTelefono.TabIndex = 34
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(9, 97)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(71, 16)
        Me.lblLocalidad.TabIndex = 33
        Me.lblLocalidad.Text = "Localidad"
        '
        'txtCUIT
        '
        Me.txtCUIT.Location = New System.Drawing.Point(281, 93)
        Me.txtCUIT.MaxLength = 13
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(156, 20)
        Me.txtCUIT.TabIndex = 4
        '
        'lblCUIT
        '
        Me.lblCUIT.AutoSize = True
        Me.lblCUIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCUIT.Location = New System.Drawing.Point(228, 93)
        Me.lblCUIT.Name = "lblCUIT"
        Me.lblCUIT.Size = New System.Drawing.Size(38, 16)
        Me.lblCUIT.TabIndex = 32
        Me.lblCUIT.Text = "CUIT"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(104, 64)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(333, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(9, 68)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(68, 16)
        Me.lblDireccion.TabIndex = 31
        Me.lblDireccion.Text = "Dirección"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(104, 29)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(233, 20)
        Me.txtRazonSocial.TabIndex = 1
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.Location = New System.Drawing.Point(9, 33)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(89, 16)
        Me.lblRazonSocial.TabIndex = 19
        Me.lblRazonSocial.Text = "Razon social"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(104, 121)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(333, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(104, 147)
        Me.txtMail.MaxLength = 100
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(333, 20)
        Me.txtMail.TabIndex = 6
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(104, 173)
        Me.txtWeb.MaxLength = 100
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(333, 20)
        Me.txtWeb.TabIndex = 7
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(9, 151)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(35, 16)
        Me.lblMail.TabIndex = 39
        Me.lblMail.Text = "Mail"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(9, 177)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(68, 16)
        Me.lblWeb.TabIndex = 40
        Me.lblWeb.Text = "Sitio web"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(398, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 41)
        Me.btnAdd.TabIndex = 61
        Me.btnAdd.Tag = "Agregar un concepto"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBuscaProv
        '
        Me.btnBuscaProv.Image = CType(resources.GetObject("btnBuscaProv.Image"), System.Drawing.Image)
        Me.btnBuscaProv.Location = New System.Drawing.Point(349, 10)
        Me.btnBuscaProv.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscaProv.Name = "btnBuscaProv"
        Me.btnBuscaProv.Size = New System.Drawing.Size(39, 41)
        Me.btnBuscaProv.TabIndex = 62
        Me.btnBuscaProv.UseVisualStyleBackColor = True
        '
        'Preoveedor
        '
        Me.Preoveedor.Controls.Add(Me.txtLocalidad)
        Me.Preoveedor.Controls.Add(Me.lblWeb)
        Me.Preoveedor.Controls.Add(Me.btnAdd)
        Me.Preoveedor.Controls.Add(Me.btnBuscaProv)
        Me.Preoveedor.Controls.Add(Me.lblMail)
        Me.Preoveedor.Controls.Add(Me.txtWeb)
        Me.Preoveedor.Controls.Add(Me.txtMail)
        Me.Preoveedor.Controls.Add(Me.txtTelefono)
        Me.Preoveedor.Controls.Add(Me.lblTelefono)
        Me.Preoveedor.Controls.Add(Me.lblLocalidad)
        Me.Preoveedor.Controls.Add(Me.txtCUIT)
        Me.Preoveedor.Controls.Add(Me.lblCUIT)
        Me.Preoveedor.Controls.Add(Me.txtDireccion)
        Me.Preoveedor.Controls.Add(Me.lblDireccion)
        Me.Preoveedor.Controls.Add(Me.txtRazonSocial)
        Me.Preoveedor.Controls.Add(Me.lblRazonSocial)
        Me.Preoveedor.Location = New System.Drawing.Point(3, 15)
        Me.Preoveedor.Name = "Preoveedor"
        Me.Preoveedor.Size = New System.Drawing.Size(457, 208)
        Me.Preoveedor.TabIndex = 63
        Me.Preoveedor.TabStop = False
        Me.Preoveedor.Text = "Datos de Proveedor"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(104, 92)
        Me.txtLocalidad.MaxLength = 13
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(118, 20)
        Me.txtLocalidad.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ver todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDatosNegociovia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(471, 274)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Preoveedor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosNegociovia2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Proveedor"
        Me.Preoveedor.ResumeLayout(False)
        Me.Preoveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents txtCUIT As System.Windows.Forms.TextBox
    Friend WithEvents lblCUIT As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBuscaProv As System.Windows.Forms.Button
    Friend WithEvents Preoveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
