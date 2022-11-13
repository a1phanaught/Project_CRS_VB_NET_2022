Imports System.Data.SqlTypes

Public Class UserListForm

    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mUsernameString As String
    Dim userMdl As New User
    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                displayAllUser()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    Private Sub displayAllUser()
        'clear here
        Me.ds.Clear()
        sqlString = "Select * from userTbl"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.UserDataGridView.DataMember = "ihsanTuitionCenterDb"
        UserDataGridView.DataSource = ds
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOk As Boolean
        Dim messageString = "Delete User: " & mUsernameString
        If mUsernameString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Delete User?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOk = userMdl.deleteUserRecord(mUsernameString)
                displayAllUser()
            End If
        End If
    End Sub

    Private Sub UserDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        ' MessageBox.Show(StudentGroupDataGridView.CurrentCell.ColumnIndex)
        Try
            col = UserDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then 'ignore if not click on primary key - groupId
                disableButton()
                Exit Sub
            End If
            inc = UserDataGridView.CurrentCell.RowIndex
            'store the selected studentGroupId from the cell selection
            mUsernameString = UserDataGridView.CurrentCell.Value
            If (mUsernameString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub disableButton()
        With Me
            .AddUserButton.Enabled = False
            .DeleteUserButton.Enabled = False
        End With
    End Sub

    Private Sub enableButton()
        With Me
            .AddUserButton.Enabled = True
            .DeleteUserButton.Enabled = True
        End With
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        UserForm.ShowDialog()
        displayAllUser()
    End Sub
End Class