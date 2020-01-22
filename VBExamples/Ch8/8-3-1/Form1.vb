Public Class Form1
    Dim dog, monkey As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dog += 1
        Label1.Text = "小狗目前" & dog & "票"
        If dog > monkey Then
            picDog.Image = My.Resources.小狗勝
            picMonkey.Image = My.Resources.小猴
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        monkey += 1
        Label2.Text = "小猴目前" & monkey & "票"
        If monkey > dog Then
            picMonkey.Image = My.Resources.小猴勝
            picDog.Image = My.Resources.小狗
        End If
    End Sub
End Class