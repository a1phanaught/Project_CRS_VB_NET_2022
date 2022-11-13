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

    Private Sub MatricNoButton_Click(sender As Object, e As EventArgs) Handles MatricNoButton.Click
        Dim cmd1 As New OleDbCommand("SELECT student.name,student.matricNumber,subject.subjectName,subjectregister.Grade FROM (student INNER JOIN subjectregister on student.matricNumber = subjectregister.matricNumber)  INNER JOIN subject on subject.subjectCode = subjectregister.subjectCode WHERE student.matricNumber like '%" + ViewMatricNoTextBox.Text + "%'", conn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        Me.ds.Clear()
        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        StudentRegDataGridView.DataSource = dt
        StudentRegDataGridView.Columns(0).HeaderText = "Name"
        StudentRegDataGridView.Columns(1).HeaderText = "Matric Number"
        StudentRegDataGridView.Columns(2).HeaderText = "Subject Name"
        StudentRegDataGridView.Columns(3).HeaderText = "Grade"

        StudentRegDataGridView.AllowUserToAddRows = False
        Dim buttoncolumn As New DataGridViewButtonColumn
        buttoncolumn.UseColumnTextForButtonValue = True
        buttoncolumn.HeaderText = "Update User"
        buttoncolumn.Width = 100
        buttoncolumn.Text = "Update"
        buttoncolumn.DefaultCellStyle.BackColor = Color.SkyBlue
        buttoncolumn.FlatStyle = FlatStyle.Flat
        StudentRegDataGridView.Columns.Insert(4, buttoncolumn)

    End Sub

    Private Sub StudentRegDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentRegDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim r1 As DataGridViewRow = StudentRegDataGridView.Rows(e.RowIndex)
            Dim cm2 As New OleDbCommand("UPDATE subjectregister SET Grade=@Grade", conn)
            cm2.Parameters.AddWithValue("Grade", r1.Cells("Grade").Value)
            conn.Open()
            cm2.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Grade Updated!")
        End If
    End Sub

    Private Sub StudentRegDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentRegDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = StudentRegDataGridView.Rows(index)
        UpdateGradeTB.Text = selectedrow.Cells(3).Value.ToString
    End Sub


End Class