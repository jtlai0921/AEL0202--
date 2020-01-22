Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("目前位置:" + My.Computer.FileSystem.CurrentDirectory)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.CurrentDirectory = "C:\"
        MsgBox("修改後的位置:" + My.Computer.FileSystem.CurrentDirectory)
    End Sub
End Class
