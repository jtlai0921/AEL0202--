Public Class Form1
    Sub Swap_by_Value(ByVal x, ByVal y)
        Dim temp = x
        x = y
        y = temp
        Debug.Print("在Swap_by_Value內, x=" & x & " y=" & y)
    End Sub
    Sub Swap_by_Address(ByRef x, ByRef y)
        Dim temp = x
        x = y
        y = temp
        Debug.Print("在Swap_by_Address內, x=" & x & " y=" & y)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i = 3
        Dim j = 5
        Debug.Print("呼叫Swap_by_Value前, i=" & i & " j=" & j)
        Swap_by_Value(i, j)
        Debug.Print("呼叫Swap_by_Value後, i=" & i & " j=" & j)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i = 3
        Dim j = 5
        Debug.Print("呼叫Swap_by_Address前, i=" & i & " j=" & j)
        Swap_by_Address(i, j)
        Debug.Print("呼叫Swap_by_Address後, i=" & i & " j=" & j)
    End Sub
End Class
