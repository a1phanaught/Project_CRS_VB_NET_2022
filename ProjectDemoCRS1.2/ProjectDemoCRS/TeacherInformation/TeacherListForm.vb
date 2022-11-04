Public Class TeacherListForm

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mICString As String
    Dim teacherMdl As New Teacher

    Private Sub TeacherListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class