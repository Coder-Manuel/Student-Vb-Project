Imports System.Data.OleDb
Public Class HospitalS

    Private Sub Boodtype1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Boodtype1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Boodtype1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloodTast1DataSet)

    End Sub

    Private Sub HospitalS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Boodtype1TableAdapter.Fill(Me.BloodTast1DataSet.boodtype1)
        Try
            conn()
            con.Open()
            str = "select * from bloodtype1"
            cmd.Connection = con
            cmd.CommandText = str
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No User In The Database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DataGridView1.DataSource = dt
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BloodTypeToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Boodtype1TableAdapter.BloodType(Me.BloodTast1DataSet.boodtype1)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Boodtype1TableAdapter.Name(Me.BloodTast1DataSet.boodtype1)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn()
            con.Open()
            str = "select * from bloodtype1 where BloodType = '" & TextBox1.Text & "'"
            cmd.Connection = con
            cmd.CommandText = str
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No User Found with That Blood Type", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DataGridView1.DataSource = dt
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("want to Exit ?", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Home.Show()
        Me.Close()
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        'Me.Close()
        Me.Hide()
    End Sub
End Class