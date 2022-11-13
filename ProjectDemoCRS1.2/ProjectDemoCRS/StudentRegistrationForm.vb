Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlTypes
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
                clearStudentSubjectGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    'SEARCH STUDENT AND DISPLAY THEIR REGISTERTATION SUBJECT
    Private Sub MatricNoButton_Click(sender As Object, e As EventArgs) Handles ViewMatricNoButton.Click
        'display registration slip
        clearStudentSubjectGrid()
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


        'display total credit and fee amount
        Dim colsum As Decimal
        For Each row As DataGridViewRow In StudentRegDataGridView.Rows
            colsum += row.Cells(4).Value
        Next
        TotalCreditLabel.Text = colsum.ToString
        FeeAmountLabel.Text = (colsum * 50).ToString("C")



    End Sub


    'PRINT STUDENT REGISTRATION SLIP
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

    'EMAIL STUDENT REGISTRATION SLIP (WIP)
    Private Sub EmailStudentSlipButton_Click(sender As Object, e As EventArgs) Handles EmailStudentSlipButton.Click
        EmailStudentSlip.ShowDialog()
    End Sub

    'VIEW STUDENT LIST BY SUBJECT CODE
    Private Sub ViewSubjectCodeButton_Click(sender As Object, e As EventArgs) Handles ViewSubjectCodeButton.Click
        clearStudentSubjectGrid()
        Dim cmd1 As New OleDbCommand("SELECT subjectregister.subjectCode,subject.subjectName,student.matricNumber,student.name FROM (student INNER JOIN subjectregister on student.matricNumber = subjectregister.matricNumber) INNER JOIN subject on subject.subjectCode = subjectregister.subjectCode WHERE subjectregister.subjectCode like '%" + SubjectCodeTextBox.Text + "%'", conn)

        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        da.SelectCommand = cmd1
        dt.Clear()
        da.Fill(dt)
        SubjectListGridView.DataSource = dt

        SubjectListGridView.Columns(0).HeaderText = "Subject Code"
        SubjectListGridView.Columns(1).HeaderText = "Subject Name"
        SubjectListGridView.Columns(2).HeaderText = "Matric No"
        SubjectListGridView.Columns(3).HeaderText = "Name"

    End Sub

    'PRINT STUDENT LIST BY CODE
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