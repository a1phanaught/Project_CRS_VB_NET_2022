Public Class TeacherForm
    Dim myTeacher As New Teacher
    Dim oldTeacherRec As TeacherRecord

    Friend Sub prepareToUpdateTeacher(teacherIC As String)

    End Sub

    Friend Sub prepareToAddNewTeacher()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            'addTeacher
            addThisTeacher()
        Else
            'updateTeacher
        End If
    End Sub

    Private Sub addThisTeacher()
        Dim theNewTeacherRec As New TeacherRecord
        Dim addOk As Boolean
        Dim messageString As String

        With theNewTeacherRec
            .ic = ICTextBox.Text
            .name = NameTextBox.Text
            .email = EmailTextBox.Text
            .phoneNumber = PhoneNumTextBox.Text
        End With

        addOk = myTeacher.addTeacher(theNewTeacherRec)
        If addOk Then
            messageString = "New teacher with IC: " & theNewTeacherRec.ic & " has been added"
            MessageBox.Show(messageString, "Add New Teacher ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub clearStudentForm()
        With Me
            .NameTextBox.Clear()
            .ICTextBox.Clear()
            .EmailTextBox.Clear()
            .PhoneNumTextBox.Clear()

        End With
    End Sub


End Class