Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sr As New IO.StreamReader("D:\DATA\學生成績.txt")
        While Not sr.EndOfStream
            TextBox1.Text &= Chr(sr.Read)
        End While
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sr As New IO.StreamReader("D:\DATA\學生成績.txt")
        While Not sr.EndOfStream
            TextBox1.Text &= sr.ReadLine & vbCrLf
        End While
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sr As New IO.StreamReader("D:\DATA\學生成績.txt")
        TextBox1.Text = sr.ReadToEnd
    End Sub
End Class
