<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.updateStudentButton = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.RegistrationButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateStudentButton
        '
        Me.updateStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentButton.Location = New System.Drawing.Point(801, 593)
        Me.updateStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(279, 74)
        Me.updateStudentButton.TabIndex = 12
        Me.updateStudentButton.Text = "Update Student"
        Me.updateStudentButton.UseVisualStyleBackColor = True
        '
        'AddStudentButton
        '
        Me.AddStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.Location = New System.Drawing.Point(507, 593)
        Me.AddStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(279, 74)
        Me.AddStudentButton.TabIndex = 11
        Me.AddStudentButton.Text = "Add New Student"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentButton.Location = New System.Drawing.Point(1096, 593)
        Me.DeleteStudentButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(304, 74)
        Me.DeleteStudentButton.TabIndex = 10
        Me.DeleteStudentButton.Text = "Delete Student"
        Me.DeleteStudentButton.UseVisualStyleBackColor = True
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(52, 199)
        Me.StudentDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 51
        Me.StudentDataGridView.Size = New System.Drawing.Size(1656, 363)
        Me.StudentDataGridView.TabIndex = 9
        '
        'Search
        '
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(137, 16)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search.Size = New System.Drawing.Size(1571, 101)
        Me.Search.TabIndex = 13
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.Location = New System.Drawing.Point(1132, 49)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(165, 38)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = True
        '
        'nameButton
        '
        Me.nameButton.Location = New System.Drawing.Point(932, 46)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(165, 42)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = True
        '
        'ICButton
        '
        Me.ICButton.Location = New System.Drawing.Point(719, 49)
        Me.ICButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(165, 38)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(293, 49)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(392, 37)
        Me.searchTextBox.TabIndex = 0
        '
        'RegistrationButton
        '
        Me.RegistrationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationButton.Location = New System.Drawing.Point(83, 593)
        Me.RegistrationButton.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(408, 74)
        Me.RegistrationButton.TabIndex = 15
        Me.RegistrationButton.Text = "View Subject Registration"
        Me.RegistrationButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(583, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Click on student matric number to enable more option"
        '
        'StudentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 832)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RegistrationButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.DeleteStudentButton)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StudentListForm"
        Me.Text = "StudentListForm"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updateStudentButton As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents DeleteStudentButton As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents Search As GroupBox
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents Label2 As Label
End Class
