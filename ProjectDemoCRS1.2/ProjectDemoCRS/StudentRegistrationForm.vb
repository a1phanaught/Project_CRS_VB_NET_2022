Imports System.Data.Common
Imports System.Data.SqlTypes

Public Class StudentRegistrationForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mMatricString As String
    Dim studentMdl As New Student

    'Connect to DB
    Private Sub StudentRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                displayStudentSubject()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    'Search student 
    Private Sub MatricNoButton_Click(sender As Object, e As EventArgs) Handles ViewMatricNoButton.Click
        clearStudentSubjectGrid()
        'Try
        'sqlString = "Select student.name,student.course,student.dateOfBirth from student"
        'dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        'dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        'Me.StudentRegDataGridView.DataMember = "ihsanTuitionCenterDb"
        'entRegDataGridView.DataSource = ds
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    'Select matric, name and subject, total credit and fee from db
    Private Sub displayStudentSubject()
        clearStudentSubjectGrid()
        sqlString = "SELECT student.matricNumber,student.name,student.course from student " 'FULL OUTER JOIN subjectregister on student.matricNumber = subjectregister.matricNumber 
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentRegDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentRegDataGridView.DataSource = ds
    End Sub



    'Print Student Registration Slip
    Private Sub PrintStudentSlipButton_Click(sender As Object, e As EventArgs) Handles PrintStudentSlipButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.StudentRegDataGridView.Width, Me.StudentRegDataGridView.Height)
        StudentRegDataGridView.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.StudentRegDataGridView.Width, Me.StudentRegDataGridView.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    'Print Subject List by Code
    Private Sub PrintSubjectListButton_Click(sender As Object, e As EventArgs) Handles PrintSubjectListButton.Click
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog2.ShowDialog()

    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim imagebmp As New Bitmap(Me.SubjectListGridView.Width, Me.SubjectListGridView.Height)
        SubjectListGridView.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.SubjectListGridView.Width, Me.SubjectListGridView.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub


    'FUNCTION
    'F1) Clear the data in table
    Private Sub clearStudentSubjectGrid()
        Me.ds.Clear()
    End Sub


End Class