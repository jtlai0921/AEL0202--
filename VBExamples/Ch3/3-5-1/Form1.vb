Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.Print(MsgBox(Val(txt1.Text) * Val(txt2.Text), 64 + 1, ”結果”))
    End Sub
End Class