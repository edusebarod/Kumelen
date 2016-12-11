<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueoCajaGlobal2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoVia2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtSaldoVia1 = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoVia2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtSaldoVia1)
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 123)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arqueo de Caja"
        '
        'txtSaldoVia2
        '
        Me.txtSaldoVia2.Location = New System.Drawing.Point(92, 81)
        Me.txtSaldoVia2.Name = "txtSaldoVia2"
        Me.txtSaldoVia2.Size = New System.Drawing.Size(142, 20)
        Me.txtSaldoVia2.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Saldo Vía 2"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Kumelen.My.Resources.Resources.add
        Me.btnNuevo.Location = New System.Drawing.Point(243, 55)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 52)
        Me.btnNuevo.TabIndex = 68
        Me.btnNuevo.Tag = "Agregar un concepto"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Checked = False
        Me.txtFecha.CustomFormat = "yyyy/MM/dd"
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFecha.Location = New System.Drawing.Point(88, 24)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ShowCheckBox = True
        Me.txtFecha.Size = New System.Drawing.Size(142, 20)
        Me.txtFecha.TabIndex = 67
        Me.txtFecha.Value = New Date(2014, 10, 23, 9, 18, 50, 0)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(6, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(83, 20)
        Me.lblFecha.TabIndex = 67
        Me.lblFecha.Text = "Fecha"
        '
        'txtSaldoVia1
        '
        Me.txtSaldoVia1.Location = New System.Drawing.Point(92, 54)
        Me.txtSaldoVia1.Name = "txtSaldoVia1"
        Me.txtSaldoVia1.Size = New System.Drawing.Size(142, 20)
        Me.txtSaldoVia1.TabIndex = 13
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(6, 55)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(80, 17)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "Saldo Vía 1"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(245, 152)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmArqueoCajaGlobal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 191)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArqueoCajaGlobal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Arqueo de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents txtSaldoVia1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtSaldoVia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
