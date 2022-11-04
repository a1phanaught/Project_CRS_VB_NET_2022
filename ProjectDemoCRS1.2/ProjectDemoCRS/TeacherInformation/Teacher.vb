Imports System.Data.OleDb
Friend Structure TeacherRecord
    Dim ic, name, email, phoneNumber
    Dim dob As Date
End Structure

Public Class Teacher

    Private con As New OleDb.OleDbConnection
    Friend Function getTeacherRecord(icNumber) As TeacherRecord
        Dim dr As OleDbDataReader
        Dim teacherRec As New TeacherRecord
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath
            con.Open()
            sqlString = "select * from teacher where (icNumber = '" & icNumber & "')"

            MessageBox.Show(sqlString)
            Debug.WriteLine(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                teacherRec.ic = dr("icNumber").ToString
                teacherRec.name = dr("name").ToString
                teacherRec.email = dr("email").ToString
                teacherRec.phoneNumber = dr("phoneNumber").ToString
                con.Close()
                Return teacherRec
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing teacher record for teacher with IC :" & icNumber)
            con.Close()
            Return teacherRec
        End Try
        Return teacherRec
    End Function

    Friend Function addTeacher(newTeacherRec As TeacherRecord) As Boolean
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            If con.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If

            sqlString = "insert into teacher(icNumber, name, email, phoneNumber)"
            sqlString = sqlString & " values('" & newTeacherRec.ic & "','" & newTeacherRec.name & "','" & newTeacherRec.email & "','" & newTeacherRec.phoneNumber & "')"
            MessageBox.Show(sqlString)
            Debug.WriteLine(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error adding new teacher record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True
    End Function

    Friend Function updateThisTeacher(oldTeacherRec As TeacherRecord, newTeacherRec As TeacherRecord) As Boolean
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sqlString = "update teacher set icNumber = '" & newTeacherRec.ic & "',"
            sqlString = sqlString & " name = '" & newTeacherRec.name & "',"
            sqlString = sqlString & " email = '" & newTeacherRec.email & "',"
            sqlString = sqlString & " phoneNumber = '" & newTeacherRec.phoneNumber & "',"

            MessageBox.Show(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating teacher record. Message:" & ex.ToString)
            Return False
        End Try
    End Function

    Friend Function deleteTeacherRecord(icNumber As String) As Boolean
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sqlString = "delete from teacher where (icNumber = '" & icNumber & "')"
            MessageBox.Show(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString) 'data integrity error
            Return False
        End Try
    End Function

End Class
