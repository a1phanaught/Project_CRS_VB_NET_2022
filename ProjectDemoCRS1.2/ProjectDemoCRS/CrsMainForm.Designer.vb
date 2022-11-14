<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrsMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindStaffTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationInformationStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPassButton = New System.Windows.Forms.Button()
        Me.GreetingsLabel = New System.Windows.Forms.Label()
        Me.AccessLabel = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 26)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.SubjectInformationToolStripMenuItem, Me.RegistrationInformationStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 1, 0, 1)
        Me.MenuStrip2.Size = New System.Drawing.Size(1067, 26)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.ApplicationToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherInformationToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Enabled = False
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.TeacherInformationToolStripMenuItem.Text = "Class List"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindStaffTeacherToolStripMenuItem, Me.AddTeacherToolStripMenuItem})
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 24)
        Me.ToolStripMenuItem1.Text = "Staff and Teacher"
        '
        'FindStaffTeacherToolStripMenuItem
        '
        Me.FindStaffTeacherToolStripMenuItem.Name = "FindStaffTeacherToolStripMenuItem"
        Me.FindStaffTeacherToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.FindStaffTeacherToolStripMenuItem.Text = "Find Staff/Teacher"
        '
        'AddTeacherToolStripMenuItem
        '
        Me.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem"
        Me.AddTeacherToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.AddTeacherToolStripMenuItem.Text = "Add Teacher"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem, Me.SubmitGradeToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 24)
        Me.ToolStripMenuItem2.Text = "Student Information"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Enabled = False
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'SubmitGradeToolStripMenuItem
        '
        Me.SubmitGradeToolStripMenuItem.Enabled = False
        Me.SubmitGradeToolStripMenuItem.Name = "SubmitGradeToolStripMenuItem"
        Me.SubmitGradeToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.SubmitGradeToolStripMenuItem.Text = "Submit Grade"
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectListToolStripMenuItem})
        Me.SubjectInformationToolStripMenuItem.Enabled = False
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Information"
        '
        'SubjectListToolStripMenuItem
        '
        Me.SubjectListToolStripMenuItem.Name = "SubjectListToolStripMenuItem"
        Me.SubjectListToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SubjectListToolStripMenuItem.Text = "Subject List"
        '
        'RegistrationInformationStripMenuItem
        '
        Me.RegistrationInformationStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentRegistrationToolStripMenuItem})
        Me.RegistrationInformationStripMenuItem.Enabled = False
        Me.RegistrationInformationStripMenuItem.Name = "RegistrationInformationStripMenuItem"
        Me.RegistrationInformationStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.RegistrationInformationStripMenuItem.Text = "Registration Information"
        '
        'StudentRegistrationToolStripMenuItem
        '
        Me.StudentRegistrationToolStripMenuItem.Name = "StudentRegistrationToolStripMenuItem"
        Me.StudentRegistrationToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.StudentRegistrationToolStripMenuItem.Text = "Student Registration"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem, Me.AssignUserToolStripMenuItem})
        Me.ToolStripMenuItem3.Enabled = False
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(58, 24)
        Me.ToolStripMenuItem3.Text = "Users"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'AssignUserToolStripMenuItem
        '
        Me.AssignUserToolStripMenuItem.Name = "AssignUserToolStripMenuItem"
        Me.AssignUserToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AssignUserToolStripMenuItem.Text = "Assign User/Staff"
        '
        'ResetPassButton
        '
        Me.ResetPassButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetPassButton.Location = New System.Drawing.Point(460, 378)
        Me.ResetPassButton.Name = "ResetPassButton"
        Me.ResetPassButton.Size = New System.Drawing.Size(140, 41)
        Me.ResetPassButton.TabIndex = 2
        Me.ResetPassButton.Text = "Reset Password"
        Me.ResetPassButton.UseVisualStyleBackColor = True
        '
        'GreetingsLabel
        '
        Me.GreetingsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GreetingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreetingsLabel.Location = New System.Drawing.Point(0, 194)
        Me.GreetingsLabel.Name = "GreetingsLabel"
        Me.GreetingsLabel.Size = New System.Drawing.Size(1067, 69)
        Me.GreetingsLabel.TabIndex = 3
        Me.GreetingsLabel.Text = "Label1"
        Me.GreetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccessLabel
        '
        Me.AccessLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessLabel.AutoSize = True
        Me.AccessLabel.Location = New System.Drawing.Point(918, 82)
        Me.AccessLabel.Name = "AccessLabel"
        Me.AccessLabel.Size = New System.Drawing.Size(48, 16)
        Me.AccessLabel.TabIndex = 4
        Me.AccessLabel.Text = "Label1"
        Me.AccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CrsMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.AccessLabel)
        Me.Controls.Add(Me.GreetingsLabel)
        Me.Controls.Add(Me.ResetPassButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CrsMainForm"
        Me.Text = "CrsMain"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationInformationStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FindStaffTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPassButton As Button
    Friend WithEvents GreetingsLabel As Label
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccessLabel As Label
    Friend WithEvents SubmitGradeToolStripMenuItem As ToolStripMenuItem
End Class
