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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchsubjectTextBox = New System.Windows.Forms.TextBox()
        Me.bycodeButton = New System.Windows.Forms.Button()
        Me.bynameButton = New System.Windows.Forms.Button()
        Me.displayallsubButton = New System.Windows.Forms.Button()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Location = New System.Drawing.Point(79, 177)
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersWidth = 62
        Me.SubjectDataGridView.RowTemplate.Height = 28
        Me.SubjectDataGridView.Size = New System.Drawing.Size(934, 353)
        Me.SubjectDataGridView.TabIndex = 0
        '
        'UpdateSubjectButton
        '
        Me.UpdateSubjectButton.Location = New System.Drawing.Point(660, 556)
        Me.UpdateSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateSubjectButton.Name = "UpdateSubjectButton"
        Me.UpdateSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.UpdateSubjectButton.TabIndex = 6
        Me.UpdateSubjectButton.Text = "Update Subject"
        Me.UpdateSubjectButton.UseVisualStyleBackColor = True
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(235, 556)
        Me.AddSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.AddSubjectButton.TabIndex = 5
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'DeleteSubjectButton
        '
        Me.DeleteSubjectButton.Location = New System.Drawing.Point(445, 556)
        Me.DeleteSubjectButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteSubjectButton.Name = "DeleteSubjectButton"
        Me.DeleteSubjectButton.Size = New System.Drawing.Size(134, 68)
        Me.DeleteSubjectButton.TabIndex = 4
        Me.DeleteSubjectButton.Text = "Delete"
        Me.DeleteSubjectButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.displayallsubButton)
        Me.GroupBox1.Controls.Add(Me.bynameButton)
        Me.GroupBox1.Controls.Add(Me.bycodeButton)
        Me.GroupBox1.Controls.Add(Me.searchsubjectTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(79, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 90)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code / Name :"
        '
        'searchsubjectTextBox
        '
        Me.searchsubjectTextBox.Location = New System.Drawing.Point(225, 39)
        Me.searchsubjectTextBox.Name = "searchsubjectTextBox"
        Me.searchsubjectTextBox.Size = New System.Drawing.Size(236, 35)
        Me.searchsubjectTextBox.TabIndex = 1
        '
        'bycodeButton
        '
        Me.bycodeButton.BackColor = System.Drawing.Color.MintCream
        Me.bycodeButton.Location = New System.Drawing.Point(488, 32)
        Me.bycodeButton.Name = "bycodeButton"
        Me.bycodeButton.Size = New System.Drawing.Size(126, 41)
        Me.bycodeButton.TabIndex = 2
        Me.bycodeButton.Text = "By Code"
        Me.bycodeButton.UseVisualStyleBackColor = False
        '
        'bynameButton
        '
        Me.bynameButton.BackColor = System.Drawing.Color.MintCream
        Me.bynameButton.Location = New System.Drawing.Point(620, 32)
        Me.bynameButton.Name = "bynameButton"
        Me.bynameButton.Size = New System.Drawing.Size(126, 41)
        Me.bynameButton.TabIndex = 3
        Me.bynameButton.Text = "By Name"
        Me.bynameButton.UseVisualStyleBackColor = False
        '
        'displayallsubButton
        '
        Me.displayallsubButton.BackColor = System.Drawing.Color.MintCream
        Me.displayallsubButton.Location = New System.Drawing.Point(752, 32)
        Me.displayallsubButton.Name = "displayallsubButton"
        Me.displayallsubButton.Size = New System.Drawing.Size(161, 41)
        Me.displayallsubButton.TabIndex = 4
        Me.displayallsubButton.Text = "Display All"
        Me.displayallsubButton.UseVisualStyleBackColor = False
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateSubjectButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.DeleteSubjectButton)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Name = "SubjectListForm"
        Me.Text = "SubjectListForm"
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubjectDataGridView As DataGridView
    Friend WithEvents UpdateSubjectButton As Button
    Friend WithEvents AddSubjectButton As Button
    Friend WithEvents DeleteSubjectButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchsubjectTextBox As TextBox
    Friend WithEvents displayallsubButton As Button
    Friend WithEvents bynameButton As Button
    Friend WithEvents bycodeButton As Button
End Class
