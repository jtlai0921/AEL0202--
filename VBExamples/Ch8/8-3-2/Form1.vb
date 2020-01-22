Public Class Form1
    Private Sub cbxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMode.SelectedIndexChanged
        PictureBox1.Size = New Size(370, 260)
        Select Case cbxMode.SelectedItem
            Case "左上角對齊"
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            Case "正中央對齊"
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Case "延展圖片"
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Case "維持比例放大"
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Case "方塊隨圖片大小而變"
                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        End Select
    End Sub
End Class
