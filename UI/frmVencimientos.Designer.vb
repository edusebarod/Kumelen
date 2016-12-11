<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVencimientos
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
        Me.lblVencimiento1 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.lblvencimiento2 = New System.Windows.Forms.Label()
        Me.lblvencimiento3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVencimiento1 = New System.Windows.Forms.DateTimePicker()
        Me.txtVencimiento2 = New System.Windows.Forms.DateTimePicker()
        Me.txtVencimiento3 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblVencimiento1
        '
        Me.lblVencimiento1.AutoSize = True
        Me.lblVencimiento1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento1.Location = New System.Drawing.Point(18, 28)
        Me.lblVencimiento1.Name = "lblVencimiento1"
        Me.lblVencimiento1.Size = New System.Drawing.Size(98, 16)
        Me.lblVencimiento1.TabIndex = 42
        Me.lblVencimiento1.Text = "Vencimiento 1"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(140, 124)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(102, 31)
        Me.cmdSalir.TabIndex = 41
        Me.cmdSalir.Text = "&SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'lblvencimiento2
        '
        Me.lblvencimiento2.AutoSize = True
        Me.lblvencimiento2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvencimiento2.Location = New System.Drawing.Point(18, 58)
        Me.lblvencimiento2.Name = "lblvencimiento2"
        Me.lblvencimiento2.Size = New System.Drawing.Size(98, 16)
        Me.lblvencimiento2.TabIndex = 44
        Me.lblvencimiento2.Text = "Vencimiento 2"
        '
        'lblvencimiento3
        '
        Me.lblvencimiento3.AutoSize = True
        Me.lblvencimiento3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvencimiento3.Location = New System.Drawing.Point(18, 87)
        Me.lblvencimiento3.Name = "lblvencimiento3"
        Me.lblvencimiento3.Size = New System.Drawing.Size(98, 16)
        Me.lblvencimiento3.TabIndex = 46
        Me.lblvencimiento3.Text = "Vencimiento 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&GRABAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVencimiento1
        '
        Me.txtVencimiento1.Checked = False
        Me.txtVencimiento1.CustomFormat = "dd/MM/yyyy"
        Me.txtVencimiento1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimiento1.Location = New System.Drawing.Point(140, 28)
        Me.txtVencimiento1.Name = "txtVencimiento1"
        Me.txtVencimiento1.ShowCheckBox = True
        Me.txtVencimiento1.Size = New System.Drawing.Size(94, 20)
        Me.txtVencimiento1.TabIndex = 1
        '
        'txtVencimiento2
        '
        Me.txtVencimiento2.Checked = False
        Me.txtVencimiento2.CustomFormat = "dd/MM/yyyy"
        Me.txtVencimiento2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimiento2.Location = New System.Drawing.Point(140, 58)
        Me.txtVencimiento2.Name = "txtVencimiento2"
        Me.txtVencimiento2.ShowCheckBox = True
        Me.txtVencimiento2.Size = New System.Drawing.Size(94, 20)
        Me.txtVencimiento2.TabIndex = 2
        '
        'txtVencimiento3
        '
        Me.txtVencimiento3.Checked = False
        Me.txtVencimiento3.CustomFormat = "dd/MM/yyyy"
        Me.txtVencimiento3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimiento3.Location = New System.Drawing.Point(140, 87)
        Me.txtVencimiento3.Name = "txtVencimiento3"
        Me.txtVencimiento3.ShowCheckBox = True
        Me.txtVencimiento3.Size = New System.Drawing.Size(94, 20)
        Me.txtVencimiento3.TabIndex = 3
        '
        'frmVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 166)
        Me.Controls.Add(Me.txtVencimiento3)
        Me.Controls.Add(Me.txtVencimiento2)
        Me.Controls.Add(Me.txtVencimiento1)
        Me.Controls.Add(Me.lblvencimiento3)
        Me.Controls.Add(Me.lblvencimiento2)
        Me.Controls.Add(Me.lblVencimiento1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmVencimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Vencimientos del Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVencimiento1 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents lblvencimiento2 As System.Windows.Forms.Label
    Friend WithEvents lblvencimiento3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtVencimiento1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVencimiento2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVencimiento3 As System.Windows.Forms.DateTimePicker
End Class
