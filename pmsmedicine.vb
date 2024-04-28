Public Class pmsmedicine

    Private Sub pmsmedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalmedicineDataSet.medicine1' table. You can move, or remove it, as needed.
        Me.Medicine1TableAdapter.Fill(Me.FinalmedicineDataSet.medicine1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Medicine1BindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Medicine1BindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Medicine1BindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Medicine1BindingSource.RemoveCurrent()


    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim home = New home
        home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveError

        Medicine1BindingSource.EndEdit()

        Medicine1TableAdapter.Update(FinalmedicineDataSet.medicine1)

        MsgBox("Data has been Saved")

SaveError:
        Exit Sub
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class