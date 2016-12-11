<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAyuda))
        Me.txtayuda = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtayuda
        '
        Me.txtayuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtayuda.BackColor = System.Drawing.SystemColors.Info
        Me.txtayuda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtayuda.Location = New System.Drawing.Point(0, 1)
        Me.txtayuda.Multiline = True
        Me.txtayuda.Name = "txtayuda"
        Me.txtayuda.ReadOnly = True
        Me.txtayuda.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtayuda.Size = New System.Drawing.Size(543, 424)
        Me.txtayuda.TabIndex = 0
        '
        'frmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(543, 425)
        Me.Controls.Add(Me.txtayuda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAyuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AYUDA KUMELEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtayuda As System.Windows.Forms.TextBox
End Class
