Public Class home

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim medicine = New medicine
        medicine.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim supplier = New supplier
        supplier.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim billing = New billing
        billing.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim login = New login
        login.Show()
    End Sub

    
End Class