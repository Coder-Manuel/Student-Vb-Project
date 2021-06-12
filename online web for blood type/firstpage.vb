Public Class firstpage

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        splash1.Show()
        If splash1.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        splash1.Show()
        If splash1.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub firstpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class