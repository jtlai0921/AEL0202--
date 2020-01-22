Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total_cost As Integer  '在結帳鈕上點滑鼠左鍵兩下進入此程式區塊
        If chk1.Checked Then total_cost += 80 * Val(TextBox1.Text)
        If chk2.Checked Then total_cost += 95 * Val(TextBox2.Text)
        If chk3.Checked Then total_cost += 90 * Val(TextBox3.Text)
        lblOutput.Text = "總計 " & total_cost & "元"
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chk1.Checked = False  '在重新輸入鈕上點滑鼠左鍵兩下進入此程式區塊
        chk2.Checked = False
        chk3.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        lblOutput.Text = "歡迎光臨小李子快餐坊"
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub
End Class
