Imports System.Data.OleDb
Friend Structure SubjectRecordinfo
    Dim subjectcode, subjectname, subjectcredit
End Structure

Public Class Subjectinfo

    Private con As New OleDb.OleDbConnection
    Friend Function getSubjectRecordinfo(subjectcode) As SubjectRecordinfo
        Dim dr As OleDbDataReader
        Dim SubjectRec As New SubjectRecordinfo
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sqlString = "select * from subject where (subjectCode = '" & subjectcode & "')"

            MessageBox.Show(sqlString)
            Debug.WriteLine(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                SubjectRec.subjectcode = dr("subjectCode").ToString
                SubjectRec.subjectname = dr("subjectName").ToString
                SubjectRec.subjectcredit = dr("credit").ToString
                con.Close()
                Return SubjectRec
            End If
        Catch ex As Exception
            MessageBox.Show("Error accessing subject record for subject with Code :" & subjectcode)
            con.Close()
            Return SubjectRec
        End Try
        Return SubjectRec
    End Function
    Friend Function addSubject(newSubjectRec As SubjectRecordinfo) As Boolean
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

            sqlString = "insert into subject(subjectCode, subjectName, credit)"
            sqlString = sqlString & " values('" & newSubjectRec.subjectcode & "','" & newSubjectRec.subjectname & "','" & newSubjectRec.subjectcredit & "')"
            MessageBox.Show(sqlString)
            Debug.WriteLine(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error adding new subject record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True
    End Function
    Friend Function updateThisSubject(oldSubjectRec As SubjectRecordinfo, newSubjectRec As SubjectRecordinfo) As Boolean
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sqlString = "update subject set subjectCode = '" & newSubjectRec.subjectcode & "',"
            sqlString = sqlString & " subjectName = '" & newSubjectRec.subjectname & "',"
            sqlString = sqlString & " credit = '" & newSubjectRec.subjectcredit & "'"
            sqlString = sqlString & " where subjectCode = '" & oldSubjectRec.subjectcode & "'"

            MessageBox.Show(sqlString)
            Dim cmd As New OleDbCommand(sqlString, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating subject record. Message:" & ex.ToString)
            Return False
        End Try
    End Function
    Friend Function deleteSubjectRecord(subjectcode As String) As Boolean
        Try
            Dim sqlString As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sqlString = "delete from subject where (subjectCode = '" & subjectcode & "')"
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
