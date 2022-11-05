Public Class TeacherListForm

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mICString As String
    Dim teacherMdl As New Teacher

    Private Sub TeacherListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable all buttons here

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
End Class