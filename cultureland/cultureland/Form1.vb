Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As New Random
        Dim A, B, C, D
        Dim i
        For i = 1 To HScrollBar1.Value
            A = random.Next(1000, 9999)
            B = random.Next(1000, 9999)
            C = random.Next(1000, 9999)
            D = random.Next(100000, 999999)
            TextBox1.AppendText(A & "-" & B & "-" & C & "-" & D & Environment.NewLine)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = "생성 개수 : " & HScrollBar1.Value
    End Sub
End Class
