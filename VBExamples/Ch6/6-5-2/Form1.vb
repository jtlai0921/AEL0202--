Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 3
            For j As Integer = 1 To 3 - i
                txtOutput.Text &= "  "
            Next
            For j As Integer = 1 To 2 * i - 1
                If j = 1 Or j = 2 * i - 1 Then
                    txtOutput.Text &= "*"
                Else
                    txtOutput.Text &= "  "
                End If
            Next
            txtOutput.Text &= vbCrLf
        Next
        For i As Integer = 2 To 1 Step -1
            For j As Integer = 1 To 3 - i
                txtOutput.Text &= "  "
            Next
            For j As Integer = 1 To 2 * i - 1
                If j = 1 Or j = 2 * i - 1 Then
                    txtOutput.Text &= "*"
                Else
                    txtOutput.Text &= "  "
                End If
            Next
            txtOutput.Text &= vbCrLf
        Next
    End Sub
End Class
