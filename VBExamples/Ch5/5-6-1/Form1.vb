Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Input_Year As Integer
        Input_Year = Val(InputBox("今年西元幾年？", "閏年判斷程式"))
        If (Input_Year Mod 100) <> 0 Then    '處理末兩位不為00的情況
            If (Input_Year Mod 4) = 0 Then
                MsgBox("閏年")
            Else
                MsgBox("不為閏年")
            End If
        Else     '此時Input_Year Mod 100 等於0，處理末兩位為00的情況
            If (Input_Year Mod 400) = 0 Then
                MsgBox("閏年")
            Else
                MsgBox("不為閏年")
            End If
        End If
    End Sub
End Class
