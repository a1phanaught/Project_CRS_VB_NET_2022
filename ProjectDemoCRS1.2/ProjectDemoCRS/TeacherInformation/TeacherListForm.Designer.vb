<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherListForm
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
        Me.TeacherDataGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteTeacherButton = New System.Windows.Forms.Button()
        Me.AddTeacherButton = New System.Windows.Forms.Button()
        Me.UpdateTeacherButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchICButton = New System.Windows.Forms.Button()
        Me.SearchNameButton = New System.Windows.Forms.Button()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(91, 129)
        Me.TeacherDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.RowHeadersWidth = 51
        Me.TeacherDataGridView.RowTemplate.Height = 24
        Me.TeacherDataGridView.Size = New System.Drawing.Size(994, 405)
        Me.TeacherDataGridView.TabIndex = 0
        '
        'DeleteTeacherButton
        '
        Me.DeleteTeacherButton.Location = New System.Drawing.Point(491, 571)
        Me.DeleteTeacherButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteTeacherButton.Name = "DeleteTeacherButton"
        Me.DeleteTeacherButton.Size = New System.Drawing.Size(150, 45)
        Me.DeleteTeacherButton.TabIndex = 1
        Me.DeleteTeacherButton.Text = "Delete"
        Me.DeleteTeacherButton.UseVisualStyleBackColor = True
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.Location = New System.Drawing.Point(209, 571)
        Me.AddTeacherButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(150, 45)
        Me.AddTeacherButton.TabIndex = 2
        Me.AddTeacherButton.Text = "Add Teacher"
        Me.AddTeacherButton.UseVisualStyleBackColor = True
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(757, 571)
        Me.UpdateTeacherButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(163, 45)
        Me.UpdateTeacherButton.TabIndex = 3
        Me.UpdateTeacherButton.Text = "Update Teacher"
        Me.UpdateTeacherButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(136, 64)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(194, 28)
        Me.SearchTextBox.TabIndex = 4
        '
        'SearchICButton
        '
        Me.SearchICButton.Location = New System.Drawing.Point(457, 59)
        Me.SearchICButton.Name = "SearchICButton"
        Me.SearchICButton.Size = New System.Drawing.Size(168, 38)
        Me.SearchICButton.TabIndex = 5
        Me.SearchICButton.Text = "Search By IC"
        Me.SearchICButton.UseVisualStyleBackColor = True
        '
        'SearchNameButton
        '
        Me.SearchNameButton.Location = New System.Drawing.Point(669, 59)
        Me.SearchNameButton.Name = "SearchNameButton"
        Me.SearchNameButton.Size = New System.Drawing.Size(168, 38)
        Me.SearchNameButton.TabIndex = 6
        Me.SearchNameButton.Text = "Search By Name"
        Me.SearchNameButton.UseVisualStyleBackColor = True
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.Location = New System.Drawing.Point(874, 59)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(150, 38)
        Me.DisplayAllButton.TabIndex = 7
        Me.DisplayAllButton.Text = "Display All"
        Me.DisplayAllButton.UseVisualStyleBackColor = True
        '
        'TeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 644)
        Me.Controls.Add(Me.DisplayAllButton)
        Me.Controls.Add(Me.SearchNameButton)
        Me.Controls.Add(Me.SearchICButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.DeleteTeacherButton)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TeacherListForm"
        Me.Text = "TeacherListForm"
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TeacherDataGridView As DataGridView
    Friend WithEvents DeleteTeacherButton As Button
    Friend WithEvents AddTeacherButton As Button
    Friend WithEvents UpdateTeacherButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchICButton As Button
    Friend WithEvents SearchNameButton As Button
    Friend WithEvents DisplayAllButton As Button
End Class
