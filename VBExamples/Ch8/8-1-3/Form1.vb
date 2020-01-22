Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False  '在表單上點兩下進入程式編輯區
        btnRemove.Enabled = False
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then  '在TextBox1上點兩下進入程式編輯區
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub
    Private Sub lstStu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStu.SelectedIndexChanged
        If lstStu.SelectedIndex <> -1 Then  '在lstStu上點兩下進入程式編輯區
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstStu.Items.Add(TextBox1.Text) '在新增鈕點兩下進入程式編輯區
        TextBox1.Text = ""
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstStu.Items.RemoveAt(lstStu.SelectedIndex)
    End Sub
End Class
