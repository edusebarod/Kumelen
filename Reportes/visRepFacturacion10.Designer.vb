<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visRepFacturacion10
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
        Me.facturacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'facturacion
        '
        Me.facturacion.ActiveViewIndex = -1
        Me.facturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.facturacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.facturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.facturacion.Location = New System.Drawing.Point(0, 0)
        Me.facturacion.Name = "facturacion"
        Me.facturacion.Size = New System.Drawing.Size(284, 262)
        Me.facturacion.TabIndex = 0
        '
        'visRepFacturacion10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.facturacion)
        Me.Name = "visRepFacturacion10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Facturacion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents facturacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
