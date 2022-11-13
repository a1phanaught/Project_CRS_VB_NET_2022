Public Class CrsMainForm

    Friend friendUsername As String
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
    End Sub

    Private Sub ResetPassButton_Click(sender As Object, e As EventArgs) Handles ResetPassButton.Click
        ResetPasswordForm.ShowDialog()
    End Sub
End Class
