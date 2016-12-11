<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActasCompromiso
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
        Me.dgAlumnos = New System.Windows.Forms.DataGridView()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCopiar = New System.Windows.Forms.Button()
        CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAlumnos
        '
        Me.dgAlumnos.AllowUserToOrderColumns = True
        Me.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAlumnos.Location = New System.Drawing.Point(12, 77)
        Me.dgAlumnos.Name = "dgAlumnos"
        Me.dgAlumnos.Size = New System.Drawing.Size(825, 432)
        Me.dgAlumnos.TabIndex = 0
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 24)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(377, 20)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Datos de Alumnos para las Actas compromiso"
        '
        'Button1
        '
        Me.Button1.Image = Global.Kumelen.My.Resources.Resources.imprimir
        Me.Button1.Location = New System.Drawing.Point(791, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Tag = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCopiar
        '
        Me.btnCopiar.Location = New System.Drawing.Point(695, 24)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(75, 23)
        Me.btnCopiar.TabIndex = 3
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'frmActasCompromiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(849, 536)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgAlumnos)
        Me.Name = "frmActasCompromiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Datos para Actas Compromiso"
        CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCopiar As System.Windows.Forms.Button
End Class
