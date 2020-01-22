Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 12
        Debug.Print(x Mod 2 = 0 And x Mod 3 = 0)
        Debug.Print(x Mod 2 = 0 AndAlso x Mod 3 = 0)
        x = 5
        Debug.Print(x Mod 2 = 0 And x Mod 3 = 0)
        Debug.Print(x Mod 2 = 0 AndAlso x Mod 3 = 0)
        x = 0
        Debug.Print(x <> 0 AndAlso 5 Mod x = 0)
        Debug.Print(x <> 0 And 5 Mod x = 0)
    End Sub
End Class
