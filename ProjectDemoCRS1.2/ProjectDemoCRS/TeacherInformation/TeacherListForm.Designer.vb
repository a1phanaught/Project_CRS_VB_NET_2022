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
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(80, 67)
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.RowHeadersWidth = 51
        Me.TeacherDataGridView.RowTemplate.Height = 24
        Me.TeacherDataGridView.Size = New System.Drawing.Size(848, 341)
        Me.TeacherDataGridView.TabIndex = 0
        '
        'DeleteTeacherButton
        '
        Me.DeleteTeacherButton.Location = New System.Drawing.Point(438, 454)
        Me.DeleteTeacherButton.Name = "DeleteTeacherButton"
        Me.DeleteTeacherButton.Size = New System.Drawing.Size(119, 54)
        Me.DeleteTeacherButton.TabIndex = 1
        Me.DeleteTeacherButton.Text = "Delete"
        Me.DeleteTeacherButton.UseVisualStyleBackColor = True
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.Location = New System.Drawing.Point(261, 454)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(119, 54)
        Me.AddTeacherButton.TabIndex = 2
        Me.AddTeacherButton.Text = "Add Teacher"
        Me.AddTeacherButton.UseVisualStyleBackColor = True
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(619, 454)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(119, 54)
        Me.UpdateTeacherButton.TabIndex = 3
        Me.UpdateTeacherButton.Text = "Update Teacher"
        Me.UpdateTeacherButton.UseVisualStyleBackColor = True
        '
        'TeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 557)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.DeleteTeacherButton)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.Name = "TeacherListForm"
        Me.Text = "TeacherListForm"
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TeacherDataGridView As DataGridView
    Friend WithEvents DeleteTeacherButton As Button
    Friend WithEvents AddTeacherButton As Button
    Friend WithEvents UpdateTeacherButton As Button
End Class
