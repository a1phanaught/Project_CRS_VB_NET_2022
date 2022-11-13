<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentGradeForm
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
        Me.StudentRegDataGridView = New System.Windows.Forms.DataGridView()
        Me.MatricNoButton = New System.Windows.Forms.Button()
        Me.ViewMatricNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdateGradeTB = New System.Windows.Forms.TextBox()
        Me.UpdateGradeButton = New System.Windows.Forms.Button()
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentRegDataGridView
        '
        Me.StudentRegDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRegDataGridView.Location = New System.Drawing.Point(11, 74)
        Me.StudentRegDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentRegDataGridView.Name = "StudentRegDataGridView"
        Me.StudentRegDataGridView.RowHeadersWidth = 51
        Me.StudentRegDataGridView.Size = New System.Drawing.Size(621, 320)
        Me.StudentRegDataGridView.TabIndex = 0
        '
        'MatricNoButton
        '
        Me.MatricNoButton.Location = New System.Drawing.Point(330, 11)
        Me.MatricNoButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MatricNoButton.Name = "MatricNoButton"
        Me.MatricNoButton.Size = New System.Drawing.Size(104, 19)
        Me.MatricNoButton.TabIndex = 1
        Me.MatricNoButton.Text = "View"
        Me.MatricNoButton.UseVisualStyleBackColor = True
        '
        'ViewMatricNoTextBox
        '
        Me.ViewMatricNoTextBox.Location = New System.Drawing.Point(180, 10)
        Me.ViewMatricNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewMatricNoTextBox.Name = "ViewMatricNoTextBox"
        Me.ViewMatricNoTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ViewMatricNoTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Student Matric Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Grade"
        '
        'UpdateGradeTB
        '
        Me.UpdateGradeTB.Location = New System.Drawing.Point(180, 44)
        Me.UpdateGradeTB.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateGradeTB.Name = "UpdateGradeTB"
        Me.UpdateGradeTB.Size = New System.Drawing.Size(134, 20)
        Me.UpdateGradeTB.TabIndex = 5
        '
        'UpdateGradeButton
        '
        Me.UpdateGradeButton.Location = New System.Drawing.Point(330, 45)
        Me.UpdateGradeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateGradeButton.Name = "UpdateGradeButton"
        Me.UpdateGradeButton.Size = New System.Drawing.Size(104, 19)
        Me.UpdateGradeButton.TabIndex = 6
        Me.UpdateGradeButton.Text = "Update"
        Me.UpdateGradeButton.UseVisualStyleBackColor = True
        '
        'StudentGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 445)
        Me.Controls.Add(Me.UpdateGradeButton)
        Me.Controls.Add(Me.UpdateGradeTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewMatricNoTextBox)
        Me.Controls.Add(Me.MatricNoButton)
        Me.Controls.Add(Me.StudentRegDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StudentGradeForm"
        Me.Text = "StudentGradeForm"
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentRegDataGridView As DataGridView
    Friend WithEvents MatricNoButton As Button
    Friend WithEvents ViewMatricNoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateGradeTB As TextBox
    Friend WithEvents UpdateGradeButton As Button
End Class
