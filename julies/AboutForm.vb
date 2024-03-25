Imports System.IO
Public Class AboutForm
    '..\..\..\..\..\database1\
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Test.doc"
        Dim sw As New System.IO.StreamWriter(Path)

        sw.Write(RichTextBox1.Rtf)
        sw.Flush()

        sw.Close()
    End Sub
End Class