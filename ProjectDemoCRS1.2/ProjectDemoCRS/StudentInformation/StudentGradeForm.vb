Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlTypes
Imports System.Net.Mail
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

    Private Sub MatricNoButton_Click(sender As Object, e As EventArgs) Handles MatricNoButton.Click
        Dim cmd1 As New OleDbCommand("SELECT student.matricNumber,student.name,subjectregister.subjectCode,subject.subjectName,subject.credit FROM (student INNER JOIN subjectregister on student.matricNumber = subjectregister.matricNumber) INNER JOIN subject on subject.subjectCode = subjectregister.subjectCode WHERE student.matricNumber like '%" + ViewMatricNoTextBox.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        StudentRegDataGridView.DataSource = dt

        StudentRegDataGridView.Columns(0).HeaderText = "Matric Number"
        StudentRegDataGridView.Columns(1).HeaderText = "Name"
        StudentRegDataGridView.Columns(2).HeaderText = "Subject Code"
        StudentRegDataGridView.Columns(3).HeaderText = "Subject Name"
        StudentRegDataGridView.Columns(4).HeaderText = "Subject Credit"

        'Remove Duplicate Cell
    End Sub
End Class