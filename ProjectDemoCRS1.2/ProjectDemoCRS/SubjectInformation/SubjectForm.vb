Public Class SubjectForm
    Dim mySubject As New Subjectinfo
    Dim oldSubjectRec As SubjectRecordinfo

    Friend Sub prepareToUpdateSubject(Subjectcode As String)
        MessageBox.Show("Update Subject with CODE: " & Subjectcode)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        'display existing data here
        displayExistingSubjectInfo(Subjectcode)
    End Sub
    Private Sub displayExistingSubjectInfo(Subjectcode As String)
        Try
            oldSubjectRec = mySubject.getSubjectRecordinfo(Subjectcode)
            With Me
                .SubjectCodeTextBox.Text = oldSubjectRec.subjectcode
                .SubjectNameTextBox.Text = oldSubjectRec.subjectname
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Friend Sub prepareToAddNewSubject()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            'addSubject
            addThisSubject()
        Else
            'updateTeacher
            updateThisSubject(oldSubjectRec)
        End If
    End Sub

    Private Sub addThisSubject()
        Dim theNewSubjectRec As New SubjectRecordinfo
        Dim addOk As Boolean
        Dim messageString As String

        With theNewSubjectRec
            .subjectcode = SubjectCodeTextBox.Text
            .subjectname = SubjectNameTextBox.Text
        End With

        addOk = mySubject.addSubject(theNewSubjectRec)
        If addOk Then
            messageString = "New Subject with CODE: " & theNewSubjectRec.subjectcode & " has been added"
            MessageBox.Show(messageString, "Add New Subject ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub updateThisSubject(oldSubjectRec As SubjectRecordinfo)
        Dim theNewSubjectRec As New SubjectRecordinfo
        Dim updateOk As Boolean
        Dim messageString As String

        theNewSubjectRec.subjectcode = SubjectCodeTextBox.Text
        theNewSubjectRec.subjectname = SubjectNameTextBox.Text
        updateOk = mySubject.updateThisSubject(oldSubjectRec, theNewSubjectRec)

        If updateOk Then
            messageString = "Subject with CODE: " & theNewSubjectRec.subjectcode & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearSubjectForm()
            Me.Close()
        End If
    End Sub
    Private Sub clearSubjectForm()
        With Me
            .SubjectCodeTextBox.Clear()
            .SubjectNameTextBox.Clear()

        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class