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
        Me.StudentRegDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrintStudentSlipButton = New System.Windows.Forms.Button()
        Me.EmailStudentSlipButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintSubjectListButton = New System.Windows.Forms.Button()
        Me.SubjectListGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ViewMatricNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ViewMatricNoButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentRegDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SubjectListGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ViewMatricNoButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ViewMatricNoTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailStudentSlipButton)
        Me.GroupBox1.Controls.Add(Me.PrintStudentSlipButton)
        Me.GroupBox1.Controls.Add(Me.StudentRegDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Registration"
        '
        'StudentRegDataGridView
        '
        Me.StudentRegDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRegDataGridView.Location = New System.Drawing.Point(16, 60)
        Me.StudentRegDataGridView.Name = "StudentRegDataGridView"
        Me.StudentRegDataGridView.Size = New System.Drawing.Size(656, 133)
        Me.StudentRegDataGridView.TabIndex = 0
        '
        'PrintStudentSlipButton
        '
        Me.PrintStudentSlipButton.Location = New System.Drawing.Point(107, 213)
        Me.PrintStudentSlipButton.Name = "PrintStudentSlipButton"
        Me.PrintStudentSlipButton.Size = New System.Drawing.Size(116, 32)
        Me.PrintStudentSlipButton.TabIndex = 1
        Me.PrintStudentSlipButton.Text = "Print Student Slip"
        Me.PrintStudentSlipButton.UseVisualStyleBackColor = True
        '
        'EmailStudentSlipButton
        '
        Me.EmailStudentSlipButton.Location = New System.Drawing.Point(442, 213)
        Me.EmailStudentSlipButton.Name = "EmailStudentSlipButton"
        Me.EmailStudentSlipButton.Size = New System.Drawing.Size(116, 32)
        Me.EmailStudentSlipButton.TabIndex = 2
        Me.EmailStudentSlipButton.Text = "Email Student Slip"
        Me.EmailStudentSlipButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.PrintSubjectListButton)
        Me.GroupBox2.Controls.Add(Me.SubjectListGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(678, 280)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject List"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(442, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintSubjectListButton
        '
        Me.PrintSubjectListButton.Location = New System.Drawing.Point(275, 242)
        Me.PrintSubjectListButton.Name = "PrintSubjectListButton"
        Me.PrintSubjectListButton.Size = New System.Drawing.Size(116, 32)
        Me.PrintSubjectListButton.TabIndex = 1
        Me.PrintSubjectListButton.Text = "Print Subject List"
        Me.PrintSubjectListButton.UseVisualStyleBackColor = True
        '
        'SubjectListGridView
        '
        Me.SubjectListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectListGridView.Location = New System.Drawing.Point(16, 99)
        Me.SubjectListGridView.Name = "SubjectListGridView"
        Me.SubjectListGridView.Size = New System.Drawing.Size(656, 128)
        Me.SubjectListGridView.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(253, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Subject Code"
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
        'ViewMatricNoTextBox
        '
        Me.ViewMatricNoTextBox.Location = New System.Drawing.Point(253, 23)
        Me.ViewMatricNoTextBox.Name = "ViewMatricNoTextBox"
        Me.ViewMatricNoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ViewMatricNoTextBox.TabIndex = 5
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
        'ViewMatricNoButton
        '
        Me.ViewMatricNoButton.Location = New System.Drawing.Point(442, 16)
        Me.ViewMatricNoButton.Name = "ViewMatricNoButton"
        Me.ViewMatricNoButton.Size = New System.Drawing.Size(116, 32)
        Me.ViewMatricNoButton.TabIndex = 5
        Me.ViewMatricNoButton.Text = "View"
        Me.ViewMatricNoButton.UseVisualStyleBackColor = True
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintSubjectListButton As Button
    Friend WithEvents SubjectListGridView As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents ViewMatricNoTextBox As TextBox
    Friend WithEvents ViewMatricNoButton As Button
End Class
