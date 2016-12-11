<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visRepDevengacionvia2
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
        Me.devengacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptDevengacion1 = New Kumelen.rptDevengacion()
        Me.SuspendLayout()
        '
        'devengacion
        '
        Me.devengacion.ActiveViewIndex = 0
        Me.devengacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.devengacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.devengacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.devengacion.Location = New System.Drawing.Point(0, 0)
        Me.devengacion.Name = "devengacion"
        Me.devengacion.ReportSource = Me.rptDevengacion1
        Me.devengacion.Size = New System.Drawing.Size(1008, 729)
        Me.devengacion.TabIndex = 0
        '
        'visRepDevengacionvia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.devengacion)
        Me.Name = "visRepDevengacionvia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Devengaciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents devengacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptDevengacion1 As Kumelen.rptDevengacion
End Class
