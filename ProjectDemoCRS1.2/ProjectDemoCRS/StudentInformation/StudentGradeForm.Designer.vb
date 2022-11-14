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
        Me.ViewMatricNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdateGradeTB = New System.Windows.Forms.TextBox()
        Me.UpdateGradeButton = New System.Windows.Forms.Button()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ViewMatricNoTextBox
        '
        Me.ViewMatricNoTextBox.Location = New System.Drawing.Point(369, 123)
        Me.ViewMatricNoTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ViewMatricNoTextBox.Name = "ViewMatricNoTextBox"
        Me.ViewMatricNoTextBox.Size = New System.Drawing.Size(220, 26)
        Me.ViewMatricNoTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Student Matric Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 230)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Grade"
        '
        'UpdateGradeTB
        '
        Me.UpdateGradeTB.Location = New System.Drawing.Point(369, 230)
        Me.UpdateGradeTB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.UpdateGradeTB.Name = "UpdateGradeTB"
        Me.UpdateGradeTB.Size = New System.Drawing.Size(220, 26)
        Me.UpdateGradeTB.TabIndex = 5
        '
        'UpdateGradeButton
        '
        Me.UpdateGradeButton.Location = New System.Drawing.Point(252, 336)
        Me.UpdateGradeButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.UpdateGradeButton.Name = "UpdateGradeButton"
        Me.UpdateGradeButton.Size = New System.Drawing.Size(159, 29)
        Me.UpdateGradeButton.TabIndex = 6
        Me.UpdateGradeButton.Text = "Submit Grade"
        Me.UpdateGradeButton.UseVisualStyleBackColor = True
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(369, 177)
        Me.SubjectCodeTextBox.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(220, 26)
        Me.SubjectCodeTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter Subject Code"
        '
        'StudentGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 456)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubjectCodeTextBox)
        Me.Controls.Add(Me.UpdateGradeButton)
        Me.Controls.Add(Me.UpdateGradeTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ViewMatricNoTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "StudentGradeForm"
        Me.Text = "StudentGradeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewMatricNoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateGradeTB As TextBox
    Friend WithEvents UpdateGradeButton As Button
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents Label3 As Label
End Class
