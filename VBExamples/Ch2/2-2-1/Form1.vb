Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "表單開始被使用: 來抓我啊"
        Me.SetDesktopLocation(50, 50)
        Me.BackColor = Color.Yellow
    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Text = "滑鼠按一下: 阿! 被抓到了"
        Me.BackColor = Color.Red
    End Sub
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.Text = "滑鼠游標離開表單: 快來抓我阿"
    End Sub
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.Text = "滑鼠游標進入表單"
        Me.SetDesktopLocation(Me.Location.X + 10, Me.Location.Y + 10)
    End Sub
End Class