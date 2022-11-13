<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentGradeForm
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
        Me.StudentRegDataGridView = New System.Windows.Forms.DataGridView()
        Me.MatricNoButton = New System.Windows.Forms.Button()
        Me.ViewMatricNoTextBox = New System.Windows.Forms.TextBox()
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentRegDataGridView
        '
        Me.StudentRegDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRegDataGridView.Location = New System.Drawing.Point(85, 125)
        Me.StudentRegDataGridView.Name = "StudentRegDataGridView"
        Me.StudentRegDataGridView.RowHeadersWidth = 51
        Me.StudentRegDataGridView.Size = New System.Drawing.Size(676, 360)
        Me.StudentRegDataGridView.TabIndex = 0
        '
        'MatricNoButton
        '
        Me.MatricNoButton.Location = New System.Drawing.Point(528, 66)
        Me.MatricNoButton.Name = "MatricNoButton"
        Me.MatricNoButton.Size = New System.Drawing.Size(139, 23)
        Me.MatricNoButton.TabIndex = 1
        Me.MatricNoButton.Text = "View Subject"
        Me.MatricNoButton.UseVisualStyleBackColor = True
        '
        'ViewMatricNoTextBox
        '
        Me.ViewMatricNoTextBox.Location = New System.Drawing.Point(270, 67)
        Me.ViewMatricNoTextBox.Name = "ViewMatricNoTextBox"
        Me.ViewMatricNoTextBox.Size = New System.Drawing.Size(178, 22)
        Me.ViewMatricNoTextBox.TabIndex = 2
        '
        'StudentGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 548)
        Me.Controls.Add(Me.ViewMatricNoTextBox)
        Me.Controls.Add(Me.MatricNoButton)
        Me.Controls.Add(Me.StudentRegDataGridView)
        Me.Name = "StudentGradeForm"
        Me.Text = "StudentGradeForm"
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentRegDataGridView As DataGridView
    Friend WithEvents MatricNoButton As Button
    Friend WithEvents ViewMatricNoTextBox As TextBox
End Class
