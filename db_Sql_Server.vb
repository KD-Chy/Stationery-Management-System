Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException

Module db_Sql_Server
    Public con As New SqlConnection("Data Source=SUSHILAKARAN;Initial Catalog=stationeryRecordKeepingSystem;Integrated Security=True")
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public dt As DataTable
    Public qr As String
    Public i As Integer

    Public Function SearchData(ByVal qr As String) As DataSet
        da = New SqlDataAdapter(qr, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function Insertdata(ByVal qr As String) As Integer
        cmd = New SqlCommand(qr, con)
        con.Open()
        i = cmd.ExecuteNonQuery
        con.Close()
        Return i
    End Function
End Module
