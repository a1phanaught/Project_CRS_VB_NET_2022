Public Class TeacherListForm

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mICString As String
    Dim teacherMdl As New Teacher

    Private Sub TeacherListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable all buttons here
        disableButtons()

        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                ' display all teacher function here
                displayAllTeachers()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub displayAllTeachers()
        'clear all here
        clearTeacherGrid()
        sqlString = "select * from teacher"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub

    Private Sub clearTeacherGrid()
        Me.ds.Clear()
    End Sub

    Private Sub AddTeacherButton_Click(sender As Object, e As EventArgs) Handles AddTeacherButton.Click
        TeacherForm.prepareToAddNewTeacher()
        TeacherForm.ShowDialog()
    End Sub

    Private Sub UpdateTeacherButton_Click(sender As Object, e As EventArgs) Handles UpdateTeacherButton.Click
        If mICString <> "" Then
            TeacherForm.prepareToUpdateTeacher(mICString)
            TeacherForm.ShowDialog()
            displayAllTeachers()
        End If
    End Sub

    Private Sub TeacherDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer

        Try
            col = TeacherDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                ' disable all buttons here
                disableButtons()
                Exit Sub
            End If
            inc = TeacherDataGridView.CurrentCell.RowIndex
            mICString = TeacherDataGridView.CurrentCell.Value
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
            .AddTeacherButton.Enabled = False
            .UpdateTeacherButton.Enabled = False
            .DeleteTeacherButton.Enabled = False
        End With
    End Sub

    Private Sub enableButtons()
        With Me
            .AddTeacherButton.Enabled = True
            .UpdateTeacherButton.Enabled = True
            .DeleteTeacherButton.Enabled = True
        End With
    End Sub
End Class