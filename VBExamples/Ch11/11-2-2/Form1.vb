Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(), b() As String
        Dim c() As Integer
        a = Split(TextBox1.Text)
        b = Split(TextBox2.Text)
        c = Add(a, b)
        Output(c)
    End Sub
    Function Add(ByVal a() As String, ByVal b() As String)
        Dim r(Max(UBound(a), UBound(b))) As Integer
        For i As Integer = 0 To UBound(a)
            r(i + UBound(r) - UBound(a)) = Val(a(i))
        Next
        For i As Integer = 0 To UBound(b)
            r(i + UBound(r) - UBound(b)) += Val(b(i))
        Next
        Return r
    End Function
    Function Max(ByVal a As Integer, ByVal b As Integer)
        If a > b Then Return a Else Return b
    End Function
    Sub Output(ByVal a() As Integer)
        txtOutput.Text = ""
        For i As Integer = 0 To UBound(a)
            txtOutput.Text &= a(i) & " "
        Next
    End Sub
End Class
