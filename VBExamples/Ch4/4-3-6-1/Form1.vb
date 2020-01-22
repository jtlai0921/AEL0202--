Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cap, rate, year As Double
        cap = Val(txtCapital.Text)
        rate = Val(txtRate.Text)
        year = Val(txtYear.Text)
        cap *= (1 + rate / 100) ^ year
        MsgBox("經過" & year & "年" & "本利和為" & cap)
    End Sub
End Class
