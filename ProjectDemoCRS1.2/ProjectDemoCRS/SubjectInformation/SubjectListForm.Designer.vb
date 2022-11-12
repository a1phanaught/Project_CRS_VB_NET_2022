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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectListForm))
        Me.SubjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.UpdateSubjectButton = New System.Windows.Forms.Button()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.DeleteSubjectButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.displayallsubButton = New System.Windows.Forms.Button()
        Me.bynameButton = New System.Windows.Forms.Button()
        Me.bycodeButton = New System.Windows.Forms.Button()
        Me.searchsubjectTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Location = New System.Drawing.Point(53, 115)
        Me.SubjectDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersWidth = 62
        Me.SubjectDataGridView.RowTemplate.Height = 28
        Me.SubjectDataGridView.Size = New System.Drawing.Size(623, 229)
        Me.SubjectDataGridView.TabIndex = 0
        '
        'UpdateSubjectButton
        '
        Me.UpdateSubjectButton.Location = New System.Drawing.Point(409, 361)
        Me.UpdateSubjectButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.UpdateSubjectButton.Name = "UpdateSubjectButton"
        Me.UpdateSubjectButton.Size = New System.Drawing.Size(89, 44)
        Me.UpdateSubjectButton.TabIndex = 6
        Me.UpdateSubjectButton.Text = "Update Subject"
        Me.UpdateSubjectButton.UseVisualStyleBackColor = True
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(80, 361)
        Me.AddSubjectButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(89, 44)
        Me.AddSubjectButton.TabIndex = 5
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'DeleteSubjectButton
        '
        Me.DeleteSubjectButton.Location = New System.Drawing.Point(238, 361)
        Me.DeleteSubjectButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DeleteSubjectButton.Name = "DeleteSubjectButton"
        Me.DeleteSubjectButton.Size = New System.Drawing.Size(89, 44)
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
        Me.GroupBox1.Location = New System.Drawing.Point(53, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(623, 58)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Subject"
        '
        'displayallsubButton
        '
        Me.displayallsubButton.BackColor = System.Drawing.Color.MintCream
        Me.displayallsubButton.Location = New System.Drawing.Point(501, 21)
        Me.displayallsubButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.displayallsubButton.Name = "displayallsubButton"
        Me.displayallsubButton.Size = New System.Drawing.Size(107, 27)
        Me.displayallsubButton.TabIndex = 4
        Me.displayallsubButton.Text = "Display All"
        Me.displayallsubButton.UseVisualStyleBackColor = False
        '
        'bynameButton
        '
        Me.bynameButton.BackColor = System.Drawing.Color.MintCream
        Me.bynameButton.Location = New System.Drawing.Point(413, 21)
        Me.bynameButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bynameButton.Name = "bynameButton"
        Me.bynameButton.Size = New System.Drawing.Size(84, 27)
        Me.bynameButton.TabIndex = 3
        Me.bynameButton.Text = "By Name"
        Me.bynameButton.UseVisualStyleBackColor = False
        '
        'bycodeButton
        '
        Me.bycodeButton.BackColor = System.Drawing.Color.MintCream
        Me.bycodeButton.Location = New System.Drawing.Point(325, 21)
        Me.bycodeButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bycodeButton.Name = "bycodeButton"
        Me.bycodeButton.Size = New System.Drawing.Size(84, 27)
        Me.bycodeButton.TabIndex = 2
        Me.bycodeButton.Text = "By Code"
        Me.bycodeButton.UseVisualStyleBackColor = False
        '
        'searchsubjectTextBox
        '
        Me.searchsubjectTextBox.Location = New System.Drawing.Point(150, 25)
        Me.searchsubjectTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchsubjectTextBox.Name = "searchsubjectTextBox"
        Me.searchsubjectTextBox.Size = New System.Drawing.Size(159, 26)
        Me.searchsubjectTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code / Name :"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(572, 361)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(89, 44)
        Me.PrintButton.TabIndex = 8
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 437)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateSubjectButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.DeleteSubjectButton)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
