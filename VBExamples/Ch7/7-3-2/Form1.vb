Public Class Form1
    Private Sub rbtType1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtType1.CheckedChanged
        txtShow.Font = New Font("新細明體", 20, txtShow.Font.Style)
    End Sub
    Private Sub rbtType2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtType2.CheckedChanged
        txtShow.Font = New Font("標楷體", 20, txtShow.Font.Style)
    End Sub
    Private Sub rbtColorRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbtColorRed.CheckedChanged
        txtShow.ForeColor = Color.Red
    End Sub
    Private Sub rbtColorGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbtColorGreen.CheckedChanged
        txtShow.ForeColor = Color.Green
    End Sub
    Private Sub rbtColorBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbtColorBlue.CheckedChanged
        txtShow.ForeColor = Color.Blue
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        txtShow.Font = New Font(txtShow.Font.Name, 20, FontStyle.Regular)
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        txtShow.Font = New Font(txtShow.Font.Name, 20, FontStyle.Bold)
    End Sub
End Class