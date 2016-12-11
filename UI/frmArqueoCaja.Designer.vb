<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueoCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArqueoCaja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFallodeCaja = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.lblDiferencia = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFallodeCaja)
        Me.GroupBox1.Controls.Add(Me.btn_imprimir)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtDiferencia)
        Me.GroupBox1.Controls.Add(Me.lblObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtExistencia)
        Me.GroupBox1.Controls.Add(Me.lblDiferencia)
        Me.GroupBox1.Controls.Add(Me.lblExistencia)
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 267)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arqueo de Caja"
        '
        'btnFallodeCaja
        '
        Me.btnFallodeCaja.Image = CType(resources.GetObject("btnFallodeCaja.Image"), System.Drawing.Image)
        Me.btnFallodeCaja.Location = New System.Drawing.Point(251, 20)
        Me.btnFallodeCaja.Name = "btnFallodeCaja"
        Me.btnFallodeCaja.Size = New System.Drawing.Size(37, 38)
        Me.btnFallodeCaja.TabIndex = 69
        Me.btnFallodeCaja.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Image = Global.Kumelen.My.Resources.Resources.imprimir
        Me.btn_imprimir.Location = New System.Drawing.Point(358, 103)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(46, 52)
        Me.btn_imprimir.TabIndex = 66
        Me.btn_imprimir.Tag = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnNuevo.Location = New System.Drawing.Point(358, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 56)
        Me.btnNuevo.TabIndex = 68
        Me.btnNuevo.Tag = "Agregar un concepto"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Checked = False
        Me.txtFecha.CustomFormat = "yyyy/MM/dd"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(88, 27)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ShowCheckBox = True
        Me.txtFecha.Size = New System.Drawing.Size(142, 20)
        Me.txtFecha.TabIndex = 67
        Me.txtFecha.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(6, 27)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 20)
        Me.lblFecha.TabIndex = 67
        Me.lblFecha.Text = "Fecha"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(88, 65)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(142, 20)
        Me.txtSaldo.TabIndex = 13
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(115, 176)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(289, 70)
        Me.txtObservaciones.TabIndex = 12
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Location = New System.Drawing.Point(88, 142)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(142, 20)
        Me.txtDiferencia.TabIndex = 12
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(6, 177)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(103, 17)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(88, 103)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(142, 20)
        Me.txtExistencia.TabIndex = 12
        '
        'lblDiferencia
        '
        Me.lblDiferencia.AutoSize = True
        Me.lblDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferencia.Location = New System.Drawing.Point(6, 142)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(72, 17)
        Me.lblDiferencia.TabIndex = 2
        Me.lblDiferencia.Text = "Diferencia"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.Location = New System.Drawing.Point(6, 103)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(71, 17)
        Me.lblExistencia.TabIndex = 2
        Me.lblExistencia.Text = "Existencia"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(6, 66)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(44, 17)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "Saldo"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(363, 295)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(266, 295)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 11
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'frmArqueoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 332)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArqueoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Arqueo de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblDiferencia As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnFallodeCaja As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
End Class
