Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Net.Mail
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StudentGradeForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mMatricString As String

    Dim studentMdl As New Student
    Private Sub StudentGradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                Me.ds.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    Private Sub UpdateGradeButton_Click(sender As Object, e As EventArgs) Handles UpdateGradeButton.Click
        Try
            Dim sqlString As String
            conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            conn.Open()

            sqlString = "UPDATE subjectregister SET Grade = '" & UpdateGradeTB.Text & "' WHERE matricNumber = '" & ViewMatricNoTextBox.Text & "' and subjectCode = '" & SubjectCodeTextBox.Text & "'"
            'sqlString = sqlString & " name = '" & newTeacherRec.name & "',"
            'sqlString = sqlString & " email = '" & newTeacherRec.email & "',"
            'sqlString = sqlString & " phoneNumber = '" & newTeacherRec.phoneNumber & "'"
            'sqlString = sqlString & " where icNumber = '" & oldTeacherRec.ic & "'"

            MessageBox.Show(sqlString)
            Dim cmd As New OleDbCommand(sqlString, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            'Return True
        Catch ex As Exception
            MessageBox.Show("Error updating teacher record. Message:" & ex.ToString)
            'Return False
            conn.Close()
        End Try
    End Sub
End Class