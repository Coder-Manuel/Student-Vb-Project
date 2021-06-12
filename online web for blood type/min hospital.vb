Imports System.Data.SqlClient


Public Class mhospital
    Dim connection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\pro1\online web for blood type\online web for blood type\Database1.mdf;Integrated Security=True")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("want to Exit ?", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
        Me.Hide()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mhospital_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub filterData(valueToSearch As String)
        Try
            conn()
            con.Open()
            str = "SELECT * From bloodtype1 WHERE Name like '%" & valueToSearch & "%' OR BloodType like '%" & valueToSearch & "%' Or phoneNumber like '%" & valueToSearch & "%' OR Addres like '%" & valueToSearch & "%' OR Age like '%" & valueToSearch & "%'"
            cmd.Connection = con
            cmd.CommandText = str
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        'Dim command As New SqlCommand(searchQuery, connection)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()


        'adapter.Fill(table)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'filterData("")
    End Sub

    Private Sub BTN_FILTER_Click(sender As Object, e As EventArgs) Handles BTN_FILTER.Click
        filterData(TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Database1DataSetBindingSource.MovePrevious()

    End Sub
End Class