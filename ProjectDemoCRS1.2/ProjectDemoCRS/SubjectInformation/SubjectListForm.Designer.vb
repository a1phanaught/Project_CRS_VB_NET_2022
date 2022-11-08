<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectListForm
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
        Me.SubjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.UpdateSubjectButton = New System.Windows.Forms.Button()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.DeleteSubjectButton = New System.Windows.Forms.Button()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Location = New System.Drawing.Point(80, 66)
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersWidth = 62
        Me.SubjectDataGridView.RowTemplate.Height = 28
        Me.SubjectDataGridView.Size = New System.Drawing.Size(859, 276)
        Me.SubjectDataGridView.TabIndex = 0
        '
        'UpdateSubjectButton
        '
        Me.UpdateSubjectButton.Location = New System.Drawing.Point(660, 395)
        Me.UpdateSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateSubjectButton.Name = "UpdateSubjectButton"
        Me.UpdateSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.UpdateSubjectButton.TabIndex = 6
        Me.UpdateSubjectButton.Text = "Update Subject"
        Me.UpdateSubjectButton.UseVisualStyleBackColor = True
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(258, 395)
        Me.AddSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.AddSubjectButton.TabIndex = 5
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'DeleteSubjectButton
        '
        Me.DeleteSubjectButton.Location = New System.Drawing.Point(457, 395)
        Me.DeleteSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteSubjectButton.Name = "DeleteSubjectButton"
        Me.DeleteSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.DeleteSubjectButton.TabIndex = 4
        Me.DeleteSubjectButton.Text = "Delete"
        Me.DeleteSubjectButton.UseVisualStyleBackColor = True
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 550)
        Me.Controls.Add(Me.UpdateSubjectButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.DeleteSubjectButton)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Name = "SubjectListForm"
        Me.Text = "SubjectListForm"
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubjectDataGridView As DataGridView
    Friend WithEvents UpdateSubjectButton As Button
    Friend WithEvents AddSubjectButton As Button
    Friend WithEvents DeleteSubjectButton As Button
End Class
