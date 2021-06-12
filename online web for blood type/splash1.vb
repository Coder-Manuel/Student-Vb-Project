Public Class splash1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Home.Show()
            Me.Hide()
        End If
        Label2.Text = ProgressBar1.Value & ("%")
    End Sub

    Private Sub splash1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class