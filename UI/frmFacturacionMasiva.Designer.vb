<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacionMasiva
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
        Me.dgalumnos = New System.Windows.Forms.DataGridView()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.lbl_sala = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        CType(Me.dgalumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgalumnos
        '
        Me.dgalumnos.AllowUserToOrderColumns = True
        Me.dgalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgalumnos.Location = New System.Drawing.Point(12, 61)
        Me.dgalumnos.Name = "dgalumnos"
        Me.dgalumnos.Size = New System.Drawing.Size(852, 534)
        Me.dgalumnos.TabIndex = 0
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 24)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(168, 20)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Alumnos de la Sala:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Kumelen.My.Resources.Resources.imprimir
        Me.btnImprimir.Location = New System.Drawing.Point(706, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(53, 52)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Tag = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(765, 21)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(94, 23)
        Me.btnFacturar.TabIndex = 3
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'lbl_sala
        '
        Me.lbl_sala.AutoSize = True
        Me.lbl_sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sala.Location = New System.Drawing.Point(189, 24)
        Me.lbl_sala.Name = "lbl_sala"
        Me.lbl_sala.Size = New System.Drawing.Size(45, 20)
        Me.lbl_sala.TabIndex = 4
        Me.lbl_sala.Text = "Sala"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Turno:"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.Location = New System.Drawing.Point(442, 24)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(55, 20)
        Me.lbl_turno.TabIndex = 6
        Me.lbl_turno.Text = "Turno"
        '
        'frmFacturacionMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 626)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_sala)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgalumnos)
        Me.Name = "frmFacturacionMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Facturación Masiva"
        CType(Me.dgalumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgalumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents lbl_sala As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
End Class
