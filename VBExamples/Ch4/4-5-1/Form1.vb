Public Class Form1
    Dim total As Double
    Dim count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total += txtInput.Text
        count += 1
        lblTotal.Text = "數值總和: " & total
        lblCount.Text = "資料個數: " & count
        lblAvg.Text = "平均結果: " & total / count
        txtInput.Text = ""
    End Sub
End Class
