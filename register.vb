Public Class register


    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Register1DataSet.reg' table. You can move, or remove it, as needed.
        Me.RegTableAdapter.Fill(Me.Register1DataSet.reg)


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SaveError

        RegBindingSource.EndEdit()
        RegTableAdapter.Update(Register1DataSet.reg)

        MsgBox("Data has been Saved")

SaveError:
        Exit Sub

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim login = New login
        login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class