Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports System.Configuration
Imports System.Data.Common
Imports Telerik.Reporting
Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class Mail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rd_POD.Width = Unit.Pixel(138)
        flAtch.Width = Unit.Pixel(138)

    End Sub

    Private Sub btnEmailUpload_Click(sender As Object, e As EventArgs) Handles btnEmailUpload.Click
        Try
            Dim sPath As String = Server.MapPath("~/POSTEXEL/" + rd_POD.FileName)
            rd_POD.SaveAs(sPath)
            Dim sSourceConstr As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/POSTEXEL/" + rd_POD.FileName) + ";Extended Properties=""Excel 12.0 Xml;HDR=YES;""")

            Dim sSourceConnection As New OleDbConnection(sSourceConstr)

            sSourceConnection.Open()
            Dim sql As String = String.Format("Select * FROM [sheet1$]")

            Dim command As New OleDbCommand(sql, sSourceConnection)
            Dim adp As New OleDbDataAdapter(command)
            Dim dt As New DataTable()
            adp.Fill(dt)
            ViewState.Add("EmailData", dt)

            Dim strMailAddress As String = String.Empty

            If dt.Rows.Count > 0 Then

                For index = 0 To dt.Rows.Count - 1
                    If Not IsDBNull(dt.Rows(index)(0)) Then
                        strMailAddress += CStr(dt.Rows(index)(0)) + " , "
                    End If
                Next
                txtTo.Text = strMailAddress
            End If
            dt.Dispose()
            sSourceConnection.Close()

            'Delete file from path after saving data
            File.Delete(sPath)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "AlertC", "alert('" + ex.Message.Replace("'", "") + "');", True)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim dt As DataTable = Email()
            Dim emaildata As DataTable = Email()
            Dim mmMsg As New MailMessage
            Dim SMTP As New SmtpClient
            Dim mail As New MailMessage()
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then


                    With mmMsg
                        .From = New MailAddress("skmailing09@gmail.com")
                        '.From = New MailAddress("shreayfiles@gmail.com")
                        For index = 0 To dt.Rows.Count - 1
                            .Subject = txtSubject.Text
                            '.Body = "To," + "<br />" + "" + dt.Rows(index)(1).ToString + "  (" + dt.Rows(index)(3).ToString + ")" + "<br />" + "</t>" + "<b>" + dt.Rows(index)(2).ToString + "</b>" + "<br/>" + "</t>" + "<br /><br />" + dt.Rows(index)(4).ToString + txtBody.Text
                            .Body = "Dear  " + dt.Rows(index)(1).ToString + "," + "<p>" + txtBody.Text + "</P>"
                            mmMsg.Bcc.Add(New MailAddress(dt.Rows(index)(0).ToString))
                        Next
                        'ATTACH FILES TO EMAIL WITHOUT STORING ON DISK
                        Dim fileName As String = Path.GetFileName(flAtch.PostedFile.FileName)
                        If fileName <> "" Then
                            Dim myAttachment As New Attachment(flAtch.FileContent, fileName)
                            .Attachments.Add(myAttachment)
                        End If
                        .IsBodyHtml = True
                        .Priority = Net.Mail.MailPriority.High
                    End With

                    With SMTP
                        .EnableSsl = True
                        .Credentials = New Net.NetworkCredential("skmailing09@gmail.com", txtPassword.Text.Trim)
                    End With
                    SMTP.Send(mmMsg)


                End If
                End If 
                'ClearCachedClientID RECORD AFTER SEND MAIL
                txtTo.Text = String.Empty
                txtSubject.Text = String.Empty
                txtPassword.Text = String.Empty
                txtBody.Text = String.Empty
                flAtch.Dispose()
            rd_POD.Dispose()
            Dim msg As String = "Mails sent successfully"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "AlertC", "alert('" + msg + "');", True)
        Catch ex As Exception

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "AlertC", "alert('" + ex.Message + "');", True)
        End Try
    End Sub
    Private Function Email() As DataTable
        If ViewState("EmailData") Is Nothing Then
            'CREATE EMPTY VIEW STATE WITH TABLE STRUCTURE FOR GRID
            Dim Details_dt As New DataTable
            Details_dt.Columns.Add("Email")
            Details_dt.Columns.Add("ClientName")
            Details_dt.Columns.Add("CompanyName")
            Details_dt.Columns.Add("Address")
            Details_dt.Columns.Add("Designation")
            ViewState.Add("Emaildata", Details_dt)
            Return CType(ViewState("EmailData"), DataTable)
        Else
            'PASS VIEW STATE WITH EXISTING DATA
            Return CType(ViewState("EmailData"), DataTable)
        End If
    End Function
End Class