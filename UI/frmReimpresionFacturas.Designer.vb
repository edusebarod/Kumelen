<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReimpresionFacturas
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
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.txt_inicio = New System.Windows.Forms.TextBox()
        Me.gb_nrofactura = New System.Windows.Forms.GroupBox()
        Me.txt_final = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbb_PtoVenta = New System.Windows.Forms.ComboBox()
        Me.lbl_PtoVenta = New System.Windows.Forms.Label()
        Me.btn_NroFactura = New System.Windows.Forms.Button()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.gb_nrofactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_factura.Location = New System.Drawing.Point(6, 57)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(169, 17)
        Me.lbl_factura.TabIndex = 0
        Me.lbl_factura.Text = "Número de Factura Inicial"
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(181, 57)
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(206, 20)
        Me.txt_inicio.TabIndex = 1
        '
        'gb_nrofactura
        '
        Me.gb_nrofactura.Controls.Add(Me.txt_final)
        Me.gb_nrofactura.Controls.Add(Me.Label1)
        Me.gb_nrofactura.Controls.Add(Me.cbb_PtoVenta)
        Me.gb_nrofactura.Controls.Add(Me.lbl_PtoVenta)
        Me.gb_nrofactura.Controls.Add(Me.btn_NroFactura)
        Me.gb_nrofactura.Controls.Add(Me.txt_inicio)
        Me.gb_nrofactura.Controls.Add(Me.lbl_factura)
        Me.gb_nrofactura.Location = New System.Drawing.Point(23, 22)
        Me.gb_nrofactura.Name = "gb_nrofactura"
        Me.gb_nrofactura.Size = New System.Drawing.Size(450, 117)
        Me.gb_nrofactura.TabIndex = 8
        Me.gb_nrofactura.TabStop = False
        Me.gb_nrofactura.Text = "Intervalo por Numero de Factura"
        '
        'txt_final
        '
        Me.txt_final.Location = New System.Drawing.Point(182, 83)
        Me.txt_final.Name = "txt_final"
        Me.txt_final.Size = New System.Drawing.Size(206, 20)
        Me.txt_final.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Número de Factura Final"
        '
        'cbb_PtoVenta
        '
        Me.cbb_PtoVenta.FormattingEnabled = True
        Me.cbb_PtoVenta.Items.AddRange(New Object() {"0001", "0002", "0003", "0004"})
        Me.cbb_PtoVenta.Location = New System.Drawing.Point(181, 31)
        Me.cbb_PtoVenta.Name = "cbb_PtoVenta"
        Me.cbb_PtoVenta.Size = New System.Drawing.Size(206, 21)
        Me.cbb_PtoVenta.TabIndex = 5
        '
        'lbl_PtoVenta
        '
        Me.lbl_PtoVenta.AutoSize = True
        Me.lbl_PtoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PtoVenta.Location = New System.Drawing.Point(7, 32)
        Me.lbl_PtoVenta.Name = "lbl_PtoVenta"
        Me.lbl_PtoVenta.Size = New System.Drawing.Size(104, 17)
        Me.lbl_PtoVenta.TabIndex = 3
        Me.lbl_PtoVenta.Text = "Punto de venta"
        '
        'btn_NroFactura
        '
        Me.btn_NroFactura.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btn_NroFactura.Location = New System.Drawing.Point(404, 32)
        Me.btn_NroFactura.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_NroFactura.Name = "btn_NroFactura"
        Me.btn_NroFactura.Size = New System.Drawing.Size(40, 42)
        Me.btn_NroFactura.TabIndex = 2
        Me.btn_NroFactura.UseVisualStyleBackColor = True
        '
        'btnVerTodos
        '
        Me.btnVerTodos.Location = New System.Drawing.Point(355, 158)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(118, 36)
        Me.btnVerTodos.TabIndex = 21
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.UseVisualStyleBackColor = True
        '
        'frmReimpresionFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 213)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.gb_nrofactura)
        Me.Name = "frmReimpresionFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reimpresión de facturas Vía 1"
        Me.gb_nrofactura.ResumeLayout(False)
        Me.gb_nrofactura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_factura As System.Windows.Forms.Label
    Friend WithEvents txt_inicio As System.Windows.Forms.TextBox
    Friend WithEvents gb_nrofactura As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_PtoVenta As System.Windows.Forms.Label
    Friend WithEvents cbb_PtoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
    Friend WithEvents txt_final As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_NroFactura As System.Windows.Forms.Button
End Class
