<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarADevengacionesvia2
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
        Me.gb_Alumno = New System.Windows.Forms.GroupBox()
        Me.btnBuscarAlumno = New System.Windows.Forms.Button()
        Me.txt_NombreAlumno = New System.Windows.Forms.TextBox()
        Me.lbl_NombreAlumno = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarNroDevengacion = New System.Windows.Forms.Button()
        Me.txt_NroDevengacion = New System.Windows.Forms.TextBox()
        Me.lblNroDevengacion = New System.Windows.Forms.Label()
        Me.gb_Alumno.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Alumno
        '
        Me.gb_Alumno.Controls.Add(Me.btnBuscarAlumno)
        Me.gb_Alumno.Controls.Add(Me.txt_NombreAlumno)
        Me.gb_Alumno.Controls.Add(Me.lbl_NombreAlumno)
        Me.gb_Alumno.Location = New System.Drawing.Point(23, 23)
        Me.gb_Alumno.Name = "gb_Alumno"
        Me.gb_Alumno.Size = New System.Drawing.Size(449, 71)
        Me.gb_Alumno.TabIndex = 10
        Me.gb_Alumno.TabStop = False
        Me.gb_Alumno.Text = "Búsqueda por Alumno"
        '
        'btnBuscarAlumno
        '
        Me.btnBuscarAlumno.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscarAlumno.Location = New System.Drawing.Point(403, 14)
        Me.btnBuscarAlumno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
        Me.btnBuscarAlumno.Size = New System.Drawing.Size(40, 42)
        Me.btnBuscarAlumno.TabIndex = 4
        Me.btnBuscarAlumno.UseVisualStyleBackColor = True
        '
        'txt_NombreAlumno
        '
        Me.txt_NombreAlumno.Location = New System.Drawing.Point(180, 38)
        Me.txt_NombreAlumno.Name = "txt_NombreAlumno"
        Me.txt_NombreAlumno.Size = New System.Drawing.Size(206, 20)
        Me.txt_NombreAlumno.TabIndex = 3
        '
        'lbl_NombreAlumno
        '
        Me.lbl_NombreAlumno.AutoSize = True
        Me.lbl_NombreAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreAlumno.Location = New System.Drawing.Point(6, 39)
        Me.lbl_NombreAlumno.Name = "lbl_NombreAlumno"
        Me.lbl_NombreAlumno.Size = New System.Drawing.Size(136, 17)
        Me.lbl_NombreAlumno.TabIndex = 2
        Me.lbl_NombreAlumno.Text = "Nombre del Alumno:"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.Location = New System.Drawing.Point(354, 195)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(118, 36)
        Me.btnVerTodos.TabIndex = 20
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarNroDevengacion)
        Me.GroupBox1.Controls.Add(Me.txt_NroDevengacion)
        Me.GroupBox1.Controls.Add(Me.lblNroDevengacion)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 69)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda por Devengacion"
        '
        'btnBuscarNroDevengacion
        '
        Me.btnBuscarNroDevengacion.Image = Global.Kumelen.My.Resources.Resources.buscar
        Me.btnBuscarNroDevengacion.Location = New System.Drawing.Point(403, 14)
        Me.btnBuscarNroDevengacion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscarNroDevengacion.Name = "btnBuscarNroDevengacion"
        Me.btnBuscarNroDevengacion.Size = New System.Drawing.Size(40, 42)
        Me.btnBuscarNroDevengacion.TabIndex = 4
        Me.btnBuscarNroDevengacion.UseVisualStyleBackColor = True
        '
        'txt_NroDevengacion
        '
        Me.txt_NroDevengacion.Location = New System.Drawing.Point(180, 38)
        Me.txt_NroDevengacion.Name = "txt_NroDevengacion"
        Me.txt_NroDevengacion.Size = New System.Drawing.Size(206, 20)
        Me.txt_NroDevengacion.TabIndex = 3
        '
        'lblNroDevengacion
        '
        Me.lblNroDevengacion.AutoSize = True
        Me.lblNroDevengacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroDevengacion.Location = New System.Drawing.Point(6, 39)
        Me.lblNroDevengacion.Name = "lblNroDevengacion"
        Me.lblNroDevengacion.Size = New System.Drawing.Size(138, 17)
        Me.lblNroDevengacion.TabIndex = 2
        Me.lblNroDevengacion.Text = "Nro de Devengación"
        '
        'frmBuscarADevengacionesvia2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 244)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_Alumno)
        Me.Name = "frmBuscarADevengacionesvia2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Anular devengaciones Vía 1"
        Me.gb_Alumno.ResumeLayout(False)
        Me.gb_Alumno.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_Alumno As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NombreAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreAlumno As System.Windows.Forms.Label
    Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarNroDevengacion As System.Windows.Forms.Button
    Friend WithEvents txt_NroDevengacion As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDevengacion As System.Windows.Forms.Label
End Class
