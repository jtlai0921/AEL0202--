Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Do While (picCar1.Left > 0) And (picCar2.Left > 0)
            Dim x, y As Integer
            x = Int(Rnd() * 10) + 1
            picCar1.Left -= x
            y = Int(Rnd() * 10) + 1
            picCar2.Left -= y
        Loop
        If (picCar1.Left <= 0) Then MsgBox("1號車獲勝")
        If (picCar2.Left <= 0) Then MsgBox("2號車獲勝")
    End Sub
End Class
