Public Class forgetpassword

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Your Password Has been changed sucessfully its will be activated after 30 min")
        login.Show()
        Me.Hide()
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub YHH_TextChanged(sender As Object, e As EventArgs) Handles YHH.TextChanged

    End Sub

    Private Sub forgetpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class