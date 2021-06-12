Imports System.Data.OleDb
Module Connection

    Public con As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String


    Public Sub conn()

        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\Users\Manuel\Desktop\Stuff\pro1\online web for blood type\online web for blood type\bloodTast1.mdb"

    End Sub

End Module