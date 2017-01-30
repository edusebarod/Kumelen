Imports System.IO
Imports System.Xml

Public Module Ayuda
    Public textoAyuda As String = ""

    Public Sub LeerAyuda(ByVal Formulario As String)
        'Dim xmldoc As New XmlDataDocument()
        'Dim xmlnode As XmlNodeList
        'Dim fs As New FileStream("ayuda.xml", FileMode.Open, FileAccess.Read)
        'Try
        'xmldoc.Load(fs)
        'xmlnode = xmldoc.GetElementsByTagName(Formulario)
        'textoAyuda = xmlnode(0).ChildNodes.Item(0).InnerText
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'End Try
    End Sub

End Module
