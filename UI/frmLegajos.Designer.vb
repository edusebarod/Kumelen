<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLegajos
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
        Me.dgLegajos = New System.Windows.Forms.DataGridView()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgLegajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLegajos
        '
        Me.dgLegajos.AllowDrop = True
        Me.dgLegajos.AllowUserToAddRows = False
        Me.dgLegajos.AllowUserToDeleteRows = False
        Me.dgLegajos.AllowUserToOrderColumns = True
        Me.dgLegajos.AllowUserToResizeRows = False
        Me.dgLegajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLegajos.Location = New System.Drawing.Point(12, 61)
        Me.dgLegajos.Name = "dgLegajos"
        Me.dgLegajos.Size = New System.Drawing.Size(943, 525)
        Me.dgLegajos.TabIndex = 0
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 24)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(247, 20)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Legajos de todos los alumnos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(861, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLegajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgLegajos)
        Me.Name = "frmLegajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Legajos"
        CType(Me.dgLegajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgLegajos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
