Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(,) = {{"張先生", 1, 4, 4},
            {"李小姐", 5, 3, 2},
            {"阮先生", 6, 2, 5}}
        Dim sw As New IO.StreamWriter("D:\DATA\紀念品銷售紀錄.txt")
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                sw.Write(data(i, j) & " ")
            Next
            sw.Write(vbCrLf)
        Next
        sw.Flush()
        sw.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim data(,) = {{"張先生", 1, 4, 4},
            {"李小姐", 5, 3, 2},
            {"阮先生", 6, 2, 5}}
        Dim sw As New IO.StreamWriter("D:\DATA\紀念品銷售紀錄.txt")
        For i As Integer = 0 To 2
            sw.WriteLine(data(i, 0) & " " & data(i, 1) & " " & data(i, 2) & " " & data(i, 3))
        Next
        sw.Flush()
        sw.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim data(,) = {{"張先生", 1, 4, 4},
            {"李小姐", 5, 3, 2},
            {"阮先生", 6, 2, 5}}
        Dim sw As New IO.StreamWriter("D:\DATA\紀念品銷售紀錄.txt")
        For i As Integer = 0 To 2
            sw.WriteLine("{0} {1} {2} {3}", data(i, 0), data(i, 1), data(i, 2), data(i, 3))
        Next
        sw.Flush()
        sw.Close()
    End Sub
End Class
