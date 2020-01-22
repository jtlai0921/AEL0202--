Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("歌曲1") '在表單上點兩下進入程式編輯區
        ListBox1.Items.Add("歌曲2")
        ListBox1.Items.Add("歌曲3")
        ListBox1.Items.Add("歌曲4")
        ListBox1.Items.Add("歌曲5")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As Object In ListBox1.SelectedItems '在選取鈕連點兩下
            ListBox2.Items.Add(item)
        Next
    End Sub
End Class
