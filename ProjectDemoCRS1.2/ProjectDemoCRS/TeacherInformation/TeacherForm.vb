Public Class TeacherForm
    Dim myTeacher As New Teacher
    Dim oldTeacherRec As TeacherRecord

    Friend Sub prepareToUpdateTeacher(teacherIC As String)
        MessageBox.Show("Update teacher with IC: " & teacherIC)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        'display existing data here
        displayExistingTeacherInfo(teacherIC)
    End Sub

    Private Sub displayExistingTeacherInfo(teacherIC As String)
        Try
            oldTeacherRec = myTeacher.getTeacherRecord(teacherIC)
            With Me
                .ICTextBox.Text = oldTeacherRec.ic
                .NameTextBox.Text = oldTeacherRec.name
                .EmailTextBox.Text = oldTeacherRec.email
                .PhoneNumTextBox.Text = oldTeacherRec.phoneNumber
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
            updateThisTeacher(oldTeacherRec)
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

    Private Sub updateThisTeacher(oldTeacherRec As TeacherRecord)
        Dim theNewTeacherRec As New TeacherRecord
        Dim updateOk As Boolean
        Dim messageString As String

        theNewTeacherRec.ic = ICTextBox.Text
        theNewTeacherRec.name = NameTextBox.Text
        theNewTeacherRec.email = EmailTextBox.Text
        theNewTeacherRec.phoneNumber = PhoneNumTextBox.Text
        updateOk = myTeacher.updateThisTeacher(oldTeacherRec, theNewTeacherRec)

        If updateOk Then
            messageString = "Teacher with IC: " & theNewTeacherRec.ic & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class