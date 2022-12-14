Imports System.Drawing.Printing

Public Class SubjectListForm

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mICString As String
    Dim SubjectMdl As New Subjectinfo

    Private Sub SubjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable all buttons here
        disableButtons()

        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                ' display all Subject function here
                displayAllSubject()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub displayAllSubject()
        'clear all here
        clearSubjectGrid()
        sqlString = "select * from subject"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub

    Private Sub clearSubjectGrid()
        Me.ds.Clear()
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        SubjectForm.prepareToAddNewSubject()
        SubjectForm.ShowDialog()
        displayAllSubject()
    End Sub
    Private Sub UpdateSubjectrButton_Click(sender As Object, e As EventArgs) Handles UpdateSubjectButton.Click
        If mICString <> "" Then
            SubjectForm.prepareToUpdateSubject(mICString)
            SubjectForm.ShowDialog()
            displayAllSubject()
        End If
    End Sub

    Private Sub SubjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer

        Try
            col = SubjectDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                ' disable all buttons here
                disableButtons()
                Exit Sub
            End If
            inc = SubjectDataGridView.CurrentCell.RowIndex
            mICString = SubjectDataGridView.CurrentCell.Value
            If (mICString <> "") Then
                enableButtons()
            Else
                disableButtons()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub disableButtons()
        With Me
            .AddSubjectButton.Enabled = False
            .UpdateSubjectButton.Enabled = False
            .DeleteSubjectButton.Enabled = False
        End With
    End Sub

    Private Sub enableButtons()
        With Me
            .AddSubjectButton.Enabled = True
            .UpdateSubjectButton.Enabled = True
            .DeleteSubjectButton.Enabled = True
        End With
    End Sub
    Private Sub DeleteSubjectButton_Click(sender As Object, e As EventArgs) Handles DeleteSubjectButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deleteOk As Boolean
        Dim messageString As String = "Delete subject : " & mICString
        If mICString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deleteOk = SubjectMdl.deleteSubjectRecord(mICString)
                displayAllSubject()
            End If
        End If
    End Sub

    Private Sub bycodeButton_Click(sender As Object, e As EventArgs) Handles bycodeButton.Click
        clearSubjectGrid()

        sqlString = "Select * from subject where subjectCode like '%" & searchsubjectTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub

    Private Sub displayallsubButton_Click(sender As Object, e As EventArgs) Handles displayallsubButton.Click
        displayAllSubject()
    End Sub

    Private Sub bynameButton_Click(sender As Object, e As EventArgs) Handles bynameButton.Click
        clearSubjectGrid()

        sqlString = "Select * from subject where subjectName like '%" & searchsubjectTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub

    'PRINT SUBJECT LIST BY SUBJECT CODE // ADD BY TAUFIQ ON 13/11/22
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.SubjectDataGridView.Width, Me.SubjectDataGridView.Height)
        SubjectDataGridView.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.SubjectDataGridView.Width, Me.SubjectDataGridView.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

End Class