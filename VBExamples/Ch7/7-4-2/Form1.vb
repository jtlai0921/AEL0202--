Public Class Form1
    Private Sub toggleButton_Click(sender As Object, e As EventArgs) Handles toggleButton.Click
        If (Timer1.Enabled = False) Then
            Timer1.Enabled = True
            toggleButton.Text = "暫停"
        Else
            Timer1.Enabled = False
            toggleButton.Text = "繼續"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (northOption.Checked = True) Then
            carLabel.Top -= 1
        ElseIf (westOption.Checked = True) Then
            carLabel.Left -= 1
        ElseIf (eastOption.Checked = True) Then
            carLabel.Left += 1
        ElseIf (southOption.Checked = True) Then
            carLabel.Top += 1
        End If
    End Sub

    Private Sub slowOption_Click(sender As Object, e As EventArgs) Handles slowOption.Click
        Timer1.Interval = 200
    End Sub
    Private Sub mediumOption_Click(sender As Object, e As EventArgs) Handles mediumOption.Click
        Timer1.Interval = 100
    End Sub
    Private Sub fastOption_Click(sender As Object, e As EventArgs) Handles fastOption.Click
        Timer1.Interval = 50
    End Sub
End Class