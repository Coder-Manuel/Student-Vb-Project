Imports System.Data.SqlClient
Imports System.Data.OleDb





Public Class user

    'Dim con As New SqlConnection
    'Dim cmd As New SqlCommand

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'con.ConnectionString = " Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\usfaljabli\Desktop\pro1\online web for blood type\online web for blood type\bin\Debug\Database1.mdf;Integrated Security=True "
        'If con.State = ConnectionState.Open Then
        'con.Close()
        'End If




    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn()
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into [bloodtype1] ( [Name],[Age],[phoneNumber],[Addres],[BloodType]) values ('" + TextBox1.Text + "' , '" + TextBox2.Text + "' ,'" + TextBox3.Text + "' , '" + TextBox4.Text + "', '" + TextBox5.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Thank you .. Record Inserted successfuly and we will contact you from the hospital ")
        con.Close()
        Me.Close()
        firstpage.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("want to Exit ?", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        

    End Sub

    
End Class