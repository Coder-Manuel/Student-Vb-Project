Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        If ProgressBar.Value = 100 Then
            HospitalS.Show()
            Me.Hide()
        End If
        Label1.Text = ProgressBar.Value & ("%")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class