Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sum As Integer
        Dim i As Integer = 1       'i記錄目前的數字
        Dim j As Integer = 1       'j記錄與下一數字的差
        Do While i <= 106
            Sum += i               'Sum = Sum + i
            Debug.Print("i=" & i & " Sum=" & Sum)
            i += j                  'i=i+j計算下一位數
            j += 1                  'j=j+1差增加1 
        Loop
        MsgBox("Sum=" & Sum)
    End Sub
End Class
