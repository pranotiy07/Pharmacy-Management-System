Public Class billing

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Payment1DataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.Payment1DataSet.bill)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BillBindingSource.MovePrevious()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BillBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BillBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim home = New home
        home.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BillBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveError

        BillBindingSource.EndEdit()

        BillTableAdapter.Update(Payment1DataSet.bill)

        MsgBox("Data has been Saved")

SaveError:
        Exit Sub
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

    End Sub

End Class