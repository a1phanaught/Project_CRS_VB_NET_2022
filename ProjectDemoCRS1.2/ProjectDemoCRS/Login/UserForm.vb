Public Class UserForm
    Dim myUser As New User
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click

        If UserLevelComboBox.SelectedItem = "" And userNameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MessageBox.Show("Please fill in all the fields!")
            Exit Sub
        End If

        Dim theNewUserRec As New UserRecord
        Dim addOk As Boolean
        Dim messageString As String

        With theNewUserRec
            .userName = userNameTextBox.Text
            .password = PasswordTextBox.Text
            .userLevel = UserLevelComboBox.SelectedItem
        End With

        addOk = myUser.addUser(theNewUserRec)
        If addOk Then
            MessageBox.Show("User added!")
            Me.Close()
        End If
    End Sub
End Class