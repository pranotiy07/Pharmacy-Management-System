Public Class supplier

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuppmsDataSet.sup1' table. You can move, or remove it, as needed.
        Me.Sup1TableAdapter.Fill(Me.SuppmsDataSet.sup1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sup1BindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sup1BindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sup1BindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Sup1BindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        On Error GoTo SaveError

        Sup1BindingSource.EndEdit()
        Sup1TableAdapter.Update(SuppmsDataSet.sup1)

        MsgBox("Data has been saved")

SaveError:
        Exit Sub

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim home = New home
        home.Show()
    End Sub
End Class