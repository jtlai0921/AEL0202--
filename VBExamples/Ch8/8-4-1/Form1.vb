﻿Public Class Form1
    Private Sub 開啟_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picShow.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub
End Class
