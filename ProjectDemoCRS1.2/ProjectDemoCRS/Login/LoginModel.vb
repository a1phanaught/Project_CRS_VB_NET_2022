Imports System.Data.OleDb

Public Class LoginModel

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String

    Public Function checkLogin(user As UserClass) As Boolean
        Dim userName As String = user.userName
        Dim password As String = user.password

        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        sqlString = "select * from userTbl where userName = '" & user.userName & "' and password = '" & user.password & "'"

        Dim cmd As New OleDbCommand(sqlString, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.HasRows Then
            MessageBox.Show("Login Successful!")
            dr.Read()
            CrsMainForm.friendUsername = dr("userName")
            conn.Close()
            Return True
        End If


        conn.Close()
        Return False
    End Function
End Class
