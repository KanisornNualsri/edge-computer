Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "start" Then
            Button1.Text = "stop"
        Else
            Button1.Text = "start"
        End If
    End Sub
End Class
