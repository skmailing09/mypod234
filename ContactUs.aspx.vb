Imports System.Net
Imports System.Net.Mail

Public Class ContactUs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            Dim mmMsg As New MailMessage
            Dim SMTP As New SmtpClient

            With mmMsg
                .From = New MailAddress("skmailing09@gmail.com", "Enquiry")
                .Subject = "Web Enquiry form " + txtName.Text.Trim
                .Body = "Name: " + txtName.Text.Trim + "<br /><br /> Email: " + txtEmail.Text.Trim + "<br /><br /> Subject: " + txtSubject.Text.Trim + "<br /><br /> Message: " + txtMessage.Text.Trim
                .IsBodyHtml = True

            End With

            mmMsg.To.Add(New MailAddress("skmailing09@gmail.com"))

            With SMTP
                .EnableSsl = True
                .Credentials = New Net.NetworkCredential("skmailing09@gmail.com", "Suresh@777")
            End With
            SMTP.Send(mmMsg)
            txtName.Text = String.Empty
            txtEmail.Text = String.Empty
            txtSubject.Text = String.Empty
            txtMessage.Text = String.Empty
            lblmessage.ForeColor = Drawing.Color.Green
            lblmessage.Text = "<br /><br />" + "Enquiry send successfully. skmailing will contact you soon."
        Catch ex As Exception
            lblmessage.ForeColor = Drawing.Color.Red
            lblmessage.Text = "Error in processing enquiry. Please try sending enquire on webdesigner@shreay.in"
        End Try
    End Sub
End Class