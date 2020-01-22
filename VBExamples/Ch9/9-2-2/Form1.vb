Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Math() As Integer = {66, 56, 78, 98, 77}
        Dim Chi() As Integer = {67, 76, 78, 87, 89}
        Dim Eng() As Integer = {45, 85, 67, 77, 90}
        Dim Math_Total, Chi_Total, Eng_total As Integer
        Dim Math_Avg, Chi_Avg, Eng_avg As Double
        For i As Integer = 0 To 4
            Math_Total += Math(i)
            Chi_Total += Chi(i)
            Eng_total += Eng(i)
        Next
        Math_Avg = Math_Total / 5
        Chi_Avg = Chi_Total / 5
        Eng_avg = Eng_total / 5
        Debug.Print("數學科總分=" & Math_Total & " 數學科平均=" & Math_Avg)
        Debug.Print("國文科總分=" & Chi_Total & " 國文科平均=" & Chi_Avg)
        Debug.Print("英文科總分=" & Eng_total & " 英文科平均=" & Eng_avg)
    End Sub
End Class
