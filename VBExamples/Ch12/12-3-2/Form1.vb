Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = TextBox1.Text
        Dim sw As New IO.StreamWriter("D:\DATA\暗文.txt")
        For i As Integer = 0 To s.Length - 1
            If Char.IsUpper(s(i)) Then
                sw.Write(Chr((Asc(s(i)) - Asc("A") + 3) Mod 26 + Asc("A")))
            Else
                sw.Write(s(i))
            End If
        Next
        sw.Flush()
        sw.Close()
    End Sub
End Class
