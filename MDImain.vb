Imports System.Windows.Forms
Imports System.Xml
Imports System.IO

Public Class MDImain
    'TODO seguro hay un lugar mejor para esto
    Public ayudatext As String = ""
    Public ayudaform As String = ""
    Public Util As New Util

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Click
        frmLocalidades.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MDImain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class


'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
'    Me.LayoutMdi(MdiLayout.Cascade)
'End Sub

'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
'    Me.LayoutMdi(MdiLayout.TileVertical)
'End Sub

'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
'    Me.LayoutMdi(MdiLayout.TileHorizontal)
'End Sub

'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
'    Me.LayoutMdi(MdiLayout.ArrangeIcons)
'End Sub

'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
'    ' Close all child forms of the parent.
'    For Each ChildForm As Form In Me.MdiChildren
'        ChildForm.Close()
'    Next
'End Sub
'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
'    ' Create a new instance of the child form.
'    Dim ChildForm As New System.Windows.Forms.Form
'    ' Make it a child of this MDI form before showing it.
'    ChildForm.MdiParent = Me
'    m_ChildFormNumber += 1
'    ChildForm.Text = "Window " & m_ChildFormNumber
'    ChildForm.Show()
'End Sub

