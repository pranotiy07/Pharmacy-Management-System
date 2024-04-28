Public Class forgetpswrd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login = New login
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim login = New login
        login.Show()
    End Sub

    
End Class