Public Class Home

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("want to Exit ?", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        Me.Hide()


    End Sub

    Private Sub WindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        MessageBox.Show("want to Exit ?", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        Me.Hide()

    End Sub

    Private Sub LoginHospitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginHospitalToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        user.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        MessageBox.Show("Yousef Aljabli - usfaljabli11@gmail.com")
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("Yousef Abdulmanan Aljabli - Middle east college student - 15F14022")

    End Sub

    Private Sub WhatIsMECToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatIsMECToolStripMenuItem.Click
        MECpage.Show()
    End Sub
End Class
