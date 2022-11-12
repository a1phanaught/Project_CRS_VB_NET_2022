<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegistrationForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ViewMatricNoButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ViewMatricNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailStudentSlipButton = New System.Windows.Forms.Button()
        Me.PrintStudentSlipButton = New System.Windows.Forms.Button()
        Me.StudentRegDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ViewSubjectCodeButton = New System.Windows.Forms.Button()
        Me.PrintSubjectListButton = New System.Windows.Forms.Button()
        Me.SubjectListGridView = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalCreditLabel = New System.Windows.Forms.Label()
        Me.FeeAmountLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SubjectListGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FeeAmountLabel)
        Me.GroupBox1.Controls.Add(Me.TotalCreditLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ViewMatricNoButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ViewMatricNoTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailStudentSlipButton)
        Me.GroupBox1.Controls.Add(Me.PrintStudentSlipButton)
        Me.GroupBox1.Controls.Add(Me.StudentRegDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Registration"
        '
        'ViewMatricNoButton
        '
        Me.ViewMatricNoButton.Location = New System.Drawing.Point(442, 16)
        Me.ViewMatricNoButton.Name = "ViewMatricNoButton"
        Me.ViewMatricNoButton.Size = New System.Drawing.Size(116, 32)
        Me.ViewMatricNoButton.TabIndex = 5
        Me.ViewMatricNoButton.Text = "View"
        Me.ViewMatricNoButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Student Matric No"
        '
        'ViewMatricNoTextBox
        '
        Me.ViewMatricNoTextBox.Location = New System.Drawing.Point(253, 23)
        Me.ViewMatricNoTextBox.Name = "ViewMatricNoTextBox"
        Me.ViewMatricNoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ViewMatricNoTextBox.TabIndex = 5
        '
        'EmailStudentSlipButton
        '
        Me.EmailStudentSlipButton.Location = New System.Drawing.Point(556, 244)
        Me.EmailStudentSlipButton.Name = "EmailStudentSlipButton"
        Me.EmailStudentSlipButton.Size = New System.Drawing.Size(116, 32)
        Me.EmailStudentSlipButton.TabIndex = 2
        Me.EmailStudentSlipButton.Text = "Email Student Slip"
        Me.EmailStudentSlipButton.UseVisualStyleBackColor = True
        '
        'PrintStudentSlipButton
        '
        Me.PrintStudentSlipButton.Location = New System.Drawing.Point(420, 244)
        Me.PrintStudentSlipButton.Name = "PrintStudentSlipButton"
        Me.PrintStudentSlipButton.Size = New System.Drawing.Size(116, 32)
        Me.PrintStudentSlipButton.TabIndex = 1
        Me.PrintStudentSlipButton.Text = "Print Student Slip"
        Me.PrintStudentSlipButton.UseVisualStyleBackColor = True
        '
        'StudentRegDataGridView
        '
        Me.StudentRegDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRegDataGridView.Location = New System.Drawing.Point(16, 60)
        Me.StudentRegDataGridView.Name = "StudentRegDataGridView"
        Me.StudentRegDataGridView.Size = New System.Drawing.Size(656, 178)
        Me.StudentRegDataGridView.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.SubjectCodeTextBox)
        Me.GroupBox2.Controls.Add(Me.ViewSubjectCodeButton)
        Me.GroupBox2.Controls.Add(Me.PrintSubjectListButton)
        Me.GroupBox2.Controls.Add(Me.SubjectListGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(678, 280)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student List"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Subject Code"
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(253, 19)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(151, 20)
        Me.SubjectCodeTextBox.TabIndex = 3
        '
        'ViewSubjectCodeButton
        '
        Me.ViewSubjectCodeButton.Location = New System.Drawing.Point(442, 12)
        Me.ViewSubjectCodeButton.Name = "ViewSubjectCodeButton"
        Me.ViewSubjectCodeButton.Size = New System.Drawing.Size(116, 32)
        Me.ViewSubjectCodeButton.TabIndex = 2
        Me.ViewSubjectCodeButton.Text = "View"
        Me.ViewSubjectCodeButton.UseVisualStyleBackColor = True
        '
        'PrintSubjectListButton
        '
        Me.PrintSubjectListButton.Location = New System.Drawing.Point(288, 242)
        Me.PrintSubjectListButton.Name = "PrintSubjectListButton"
        Me.PrintSubjectListButton.Size = New System.Drawing.Size(116, 32)
        Me.PrintSubjectListButton.TabIndex = 1
        Me.PrintSubjectListButton.Text = "Print Subject List"
        Me.PrintSubjectListButton.UseVisualStyleBackColor = True
        '
        'SubjectListGridView
        '
        Me.SubjectListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectListGridView.Location = New System.Drawing.Point(16, 50)
        Me.SubjectListGridView.Name = "SubjectListGridView"
        Me.SubjectListGridView.Size = New System.Drawing.Size(656, 177)
        Me.SubjectListGridView.TabIndex = 0
        '
        'PrintDocument1
        '
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
        'PrintDocument2
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fee Amount"
        '
        'TotalCreditLabel
        '
        Me.TotalCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCreditLabel.Location = New System.Drawing.Point(253, 247)
        Me.TotalCreditLabel.Name = "TotalCreditLabel"
        Me.TotalCreditLabel.Size = New System.Drawing.Size(151, 20)
        Me.TotalCreditLabel.TabIndex = 10
        '
        'FeeAmountLabel
        '
        Me.FeeAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FeeAmountLabel.Location = New System.Drawing.Point(253, 272)
        Me.FeeAmountLabel.Name = "FeeAmountLabel"
        Me.FeeAmountLabel.Size = New System.Drawing.Size(151, 20)
        Me.FeeAmountLabel.TabIndex = 11
        '
        'StudentRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 636)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "StudentRegistrationForm"
        Me.Text = "StudentRegistrationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SubjectListGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentRegDataGridView As DataGridView
    Friend WithEvents EmailStudentSlipButton As Button
    Friend WithEvents PrintStudentSlipButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents ViewSubjectCodeButton As Button
    Friend WithEvents PrintSubjectListButton As Button
    Friend WithEvents SubjectListGridView As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents ViewMatricNoTextBox As TextBox
    Friend WithEvents ViewMatricNoButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalCreditLabel As Label
    Friend WithEvents FeeAmountLabel As Label
End Class
