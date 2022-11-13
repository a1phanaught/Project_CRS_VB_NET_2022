Imports System.Data.OleDb
Friend Structure UserRecord
    Dim userName, password, userLevel As String
End Structure
Public Class User
    Private conn As New OleDb.OleDbConnection

    Friend Function deleteUserRecord(userName As String) As Boolean
        Dim sqlString As String

        ' Do not, in any case, let anyone delete the current logged in user
        If userName = CrsMainForm.friendUsername Then
            Return False
        End If

        Try
            conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            conn.Open()
            sqlString = "delete from userTbl where ([userName] = '" & userName & "')"
            MessageBox.Show(sqlString)
            Dim cmd As New OleDbCommand(sqlString, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
            Return False
        End Try
    End Function

    Friend Function addUser(newUserRec As UserRecord) As Boolean
        Try
            Dim sqlString As String
            conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If

            ' This error is kinda weird so had to put variables in square brackets
            sqlString = "Insert into userTbl([userName], [password], [userLevel]) "
            sqlString = sqlString & "values('" & newUserRec.userName & "', '" & newUserRec.password & "', '" & newUserRec.userLevel & "')"

            MessageBox.Show(sqlString)

            Dim cmd As New OleDbCommand(sqlString, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error adding new user record. Message:" & ex.ToString)
            conn.Close()
            Return False
        End Try

    End Function
End Class
