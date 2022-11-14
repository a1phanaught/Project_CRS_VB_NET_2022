Imports System.Drawing.Printing
Imports System.Net.Mail


Public Class EmailStudentSlip
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()


            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("vb.net.utm@gmail.com", "wigaqvxiyeapsqvp")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("vb.net.utm@gmail.com")
            e_mail.To.Add(ToTextbox.Text)
            e_mail.Subject = "Student Slip"
            e_mail.IsBodyHtml = False
            'e_mail.Body = StudentRegistrationForm.imag
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub


End Class