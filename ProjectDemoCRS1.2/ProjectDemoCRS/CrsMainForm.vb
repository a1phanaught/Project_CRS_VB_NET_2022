Public Class CrsMainForm

    Friend friendUsername As String
    Friend friendAccessLevel As String
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub CrsMainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub TeacherInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherInformationToolStripMenuItem.Click
        StudentGroupListForm.ShowDialog()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        StudentListForm.ShowDialog()
    End Sub

    Private Sub FindStaffTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindStaffTeacherToolStripMenuItem.Click
        TeacherListForm.ShowDialog()
    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        SubjectListForm.ShowDialog()
    End Sub


    'Taufiq edit StudentRegistration
    Private Sub StudentRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        StudentRegistrationForm.ShowDialog()
    End Sub

    Private Sub CrsMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GreetingsLabel.Text = "Welcome, " & friendUsername & "!"
        AccessLabel.Text = "Access Level: " & friendAccessLevel

        ' Users' data can only be accessed by a staff with access level 'S'
        If friendAccessLevel = "S" Then
            RegistrarToolStripMenuItem.Enabled = True
            ToolStripMenuItem1.Enabled = True
            StudentListToolStripMenuItem.Enabled = True
            SubjectInformationToolStripMenuItem.Enabled = True
            RegistrationInformationStripMenuItem.Enabled = True
            ToolStripMenuItem3.Enabled = True
        ElseIf friendAccessLevel = "R" Then
            RegistrarToolStripMenuItem.Enabled = True
            ToolStripMenuItem1.Enabled = True
            StudentListToolStripMenuItem.Enabled = True
            SubjectInformationToolStripMenuItem.Enabled = True
            RegistrationInformationStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ResetPassButton_Click(sender As Object, e As EventArgs) Handles ResetPassButton.Click
        ResetPasswordForm.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        UserListForm.ShowDialog()
    End Sub

    Private Sub AssignUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignUserToolStripMenuItem.Click
        UserForm.ShowDialog()
    End Sub

    Private Sub AddTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTeacherToolStripMenuItem.Click
        TeacherForm.ShowDialog()
    End Sub

    Private Sub SubmitGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitGradeToolStripMenuItem.Click
        StudentGradeForm.ShowDialog()
    End Sub
End Class
