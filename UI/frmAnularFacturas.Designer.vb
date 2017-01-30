<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularFacturas
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
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToOrderColumns = True
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.Location = New System.Drawing.Point(12, 61)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.Size = New System.Drawing.Size(960, 589)
        Me.dgFacturas.TabIndex = 0
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(12, 24)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(187, 20)
        Me.lbl_titulo.TabIndex = 1
        Me.lbl_titulo.Text = "Facturas No Anuladas"
        '
        'frmAnularFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.dgFacturas)
        Me.Name = "frmAnularFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Anular Facturas"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
End Class
