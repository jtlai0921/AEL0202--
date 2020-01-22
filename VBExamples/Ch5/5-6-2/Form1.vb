Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start_Station, end_Station As Integer
        start_Station = Val(InputBox("請輸入起始站位置[1:台北 2:板橋 3:桃園 4:新竹]"))
        end_Station = Val(InputBox("請輸入目的站位置[1:台北 2:板橋 3:桃園 4:新竹]"))
        Select Case start_Station
            Case 1
                Select Case end_Station
                    Case 2 : MsgBox("[台北]到[板橋]票價45元")
                    Case 3 : MsgBox("[台北]到[桃園]票價175元")
                    Case 4 : MsgBox("[台北]到[新竹]票價315元")
                    Case Else : MsgBox("錯誤: 請輸入整數1~4而且起站和終站不能相同")
                End Select
            Case 2
                Select Case end_Station
                    Case 1 : MsgBox("[板橋]到[台北]票價45元")
                    Case 3 : MsgBox("[板橋]到[桃園]票價140元")
                    Case 4 : MsgBox("[板橋]到[新竹]票價280元")
                    Case Else : MsgBox("錯誤: 請輸入整數1~4而且起站和終站不能相同")
                End Select
            Case 3
                Select Case end_Station
                    Case 1 : MsgBox("[桃園]到[台北]票價175元")
                    Case 2 : MsgBox("[桃園]到[板橋]票價140元")
                    Case 4 : MsgBox("[桃園]到[新竹]票價140元")
                    Case Else : MsgBox("錯誤: 請輸入整數1~4而且起站和終站不能相同")
                End Select
            Case 4
                Select Case end_Station
                    Case 1 : MsgBox("[新竹]到[台北]票價315元")
                    Case 2 : MsgBox("[新竹]到[板橋]票價280元")
                    Case 3 : MsgBox("[新竹]到[桃園]票價140元")
                    Case Else : MsgBox("錯誤: 請輸入整數1~4而且起站和終站不能相同")
                End Select
            Case Else
                MsgBox("錯誤: 請輸入整數1~4而且起站和終站不能相同")
        End Select
    End Sub
End Class
