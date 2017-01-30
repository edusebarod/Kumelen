<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visRepDeudaCurso
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
        Me.DeudaCurso = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'DeudaCurso
        '
        Me.DeudaCurso.ActiveViewIndex = -1
        Me.DeudaCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeudaCurso.Cursor = System.Windows.Forms.Cursors.Default
        Me.DeudaCurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeudaCurso.Location = New System.Drawing.Point(0, 0)
        Me.DeudaCurso.Name = "DeudaCurso"
        Me.DeudaCurso.Size = New System.Drawing.Size(1008, 729)
        Me.DeudaCurso.TabIndex = 0
        '
        'visRepDeudaCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.DeudaCurso)
        Me.Name = "visRepDeudaCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte de Deuda Alumno"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DeudaCurso As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
