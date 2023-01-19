Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.Configuration
Imports System.Configuration
Imports System.Data.Common
Imports Telerik.Reporting
Imports System.IO
Imports System.Data.SQLite
Imports Telerik.Reporting.Processing

Public Class PODGeneration
    Inherits System.Web.UI.Page

    'Dim con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Connect").ConnectionString)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim con As String = System.Configuration.ConfigurationManager.ConnectionStrings("Connect").ConnectionString
        rd_POD.Width = Unit.Pixel(138)
    End Sub

    Protected Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        If rd_POD.HasFile Then
            Dim sPath As String = Server.MapPath("~/POSTEXEL/" + rd_POD.FileName)
            rd_POD.SaveAs(sPath)
            ImporttoSQL(sPath)
        End If
    End Sub

    Private Sub ImporttoSQL(sPath As String)
        Try

            Dim sSourceConstr As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/POSTEXEL/" + rd_POD.FileName) + ";Extended Properties=""Excel 12.0 Xml;HDR=YES;""", sPath)

            Dim sSourceConnection As New OleDbConnection(sSourceConstr)

            sSourceConnection.Open()
            Dim sql As String = String.Format("Select * FROM [{0}]", "Sheet1$")

            Dim command As New OleDbCommand(sql, sSourceConnection)
            Dim adp As OleDbDataAdapter = New OleDbDataAdapter(command)
            Dim dt As DataTable = New DataTable()
            adp.Fill(dt)

            Dim dtOdd As New DataTable
            dtOdd.Columns.Add("Comapny_Name")
            dtOdd.Columns.Add("SUB_NO")
            dtOdd.Columns.Add("NAME")
            dtOdd.Columns.Add("ADD_1")
            dtOdd.Columns.Add("ADD_2")
            dtOdd.Columns.Add("ADD_3")
            dtOdd.Columns.Add("STATE")
            dtOdd.Columns.Add("PIN")
            dtOdd.Columns.Add("Status")
            dtOdd.Columns.Add("Id")
            dtOdd.Columns.Add("DATE", GetType(Date))
            dtOdd.Columns.Add("ClientName")
            dtOdd.Columns.Add("RefNO")
            'dtOdd.Columns.Add("NO")


            Dim dtEven As New DataTable
            dtEven.Columns.Add("Comapny_Name")
            dtEven.Columns.Add("SUB_NO")
            dtEven.Columns.Add("NAME")
            dtEven.Columns.Add("ADD_1")
            dtEven.Columns.Add("ADD_2")
            dtEven.Columns.Add("ADD_3")
            dtEven.Columns.Add("STATE")
            dtEven.Columns.Add("PIN")
            dtEven.Columns.Add("Status")
            dtEven.Columns.Add("Id")
            dtEven.Columns.Add("DATE", GetType(Date))
            dtEven.Columns.Add("ClientName")
            dtEven.Columns.Add("RefNO")
            'dtEven.Columns.Add("NO")
            If dt.Rows.Count > 0 Then
                For index = 0 To dt.Rows.Count - 1

                    If index Mod 2 = 0 Then
                        If dt.Rows(index)(0) IsNot DBNull.Value And dt.Rows(index)(1) IsNot DBNull.Value Then
                            Dim dr1 As DataRow = dtEven.NewRow
                            dr1("Comapny_Name") = cmbcompany.Text
                            dr1("SUB_NO") = CStr(IIf(dt.Rows(index)(0) Is DBNull.Value, " ", dt.Rows(index)(0).ToString.ToString))
                            dr1("NAME") = CStr(IIf(dt.Rows(index)(2) Is DBNull.Value, " ", dt.Rows(index)(2).ToString.ToString))
                            dr1("ADD_1") = CStr(IIf(dt.Rows(index)(3) Is DBNull.Value, " ", dt.Rows(index)(3).ToString.ToString))
                            dr1("ADD_2") = CStr(IIf(dt.Rows(index)(4) Is DBNull.Value, " ", dt.Rows(index)(4).ToString.ToString))
                            dr1("ADD_3") = CStr(IIf(dt.Rows(index)(5) Is DBNull.Value, " ", dt.Rows(index)(5).ToString.ToString))
                            dr1("STATE") = CStr(IIf(dt.Rows(index)(6) Is DBNull.Value, " ", dt.Rows(index)(6).ToString.ToString))
                            dr1("PIN") = CStr(IIf(dt.Rows(index)(7) Is DBNull.Value, " ", dt.Rows(index)(7).ToString.ToString))
                            dr1("Status") = CStr(IIf(dt.Rows(index)(8) Is DBNull.Value, " ", dt.Rows(index)(8).ToString.ToString))
                            dr1("Id") = index
                            dr1("DATE") = CDate(IIf(dt.Rows(index)(10) Is DBNull.Value, " ", dt.Rows(index)(10).ToString.ToString))
                            dr1("ClientName") = CStr(IIf(dt.Rows(index)(9) Is DBNull.Value, " ", dt.Rows(index)(9).ToString.ToString))
                            dr1("RefNO") = CStr(IIf(dt.Rows(index)(1) Is DBNull.Value, " ", dt.Rows(index)(1).ToString.ToString))
                            'dr1("NO") = index + 1
                            dtEven.Rows.Add(dr1)
                        End If
                    End If

                    If index Mod 2 <> 0 Then
                        If dt.Rows(index)(0) IsNot DBNull.Value And dt.Rows(index)(1) IsNot DBNull.Value Then
                            Dim dr As DataRow = dtOdd.NewRow
                            dr("Comapny_Name") = cmbcompany.Text
                            dr("SUB_NO") = CStr(IIf(dt.Rows(index)(0) Is DBNull.Value, " ", dt.Rows(index)(0).ToString.ToString))
                            dr("NAME") = CStr(IIf(dt.Rows(index)(2) Is DBNull.Value, " ", dt.Rows(index)(2).ToString.ToString))
                            dr("ADD_1") = CStr(IIf(dt.Rows(index)(3) Is DBNull.Value, "", dt.Rows(index)(3).ToString.ToString))
                            dr("ADD_2") = CStr(IIf(dt.Rows(index)(4) Is DBNull.Value, "", dt.Rows(index)(4).ToString.ToString))
                            dr("ADD_3") = CStr(IIf(dt.Rows(index)(5) Is DBNull.Value, "", dt.Rows(index)(5).ToString.ToString))
                            dr("STATE") = CStr(IIf(dt.Rows(index)(6) Is DBNull.Value, "", dt.Rows(index)(6).ToString.ToString))
                            dr("PIN") = CStr(IIf(dt.Rows(index)(7) Is DBNull.Value, " ", dt.Rows(index)(7).ToString.ToString))
                            dr("Status") = CStr(IIf(dt.Rows(index)(8) Is DBNull.Value, " ", dt.Rows(index)(8).ToString.ToString))
                            dr("Id") = index
                            dr("DATE") = CDate(IIf(dt.Rows(index)(10) Is DBNull.Value, " ", dt.Rows(index)(10).ToString.ToString))
                            dr("ClientName") = CStr(IIf(dt.Rows(index)(9) Is DBNull.Value, " ", dt.Rows(index)(9).ToString.ToString))
                            dr("RefNO") = CStr(IIf(dt.Rows(index)(1) Is DBNull.Value, " ", dt.Rows(index)(1).ToString.ToString))
                            'dr("NO") = index + 1
                            dtOdd.Rows.Add(dr)
                        End If
                    End If
                Next
            End If
            sSourceConnection.Close()

            Dim Comapny_Name As String
            Dim SUB_NO As String
            Dim NAME As String
            Dim ADD_1 As String
            Dim ADD_2 As String
            Dim ADD_3 As String
            Dim STATE As String
            Dim PIN As String
            Dim Status As String
            Dim ClientName As String
            Dim Poddate As String
            Dim RefNO As String
            'saving data in database
            Dim live As String = System.Configuration.ConfigurationManager.AppSettings("LiveServer")
            If live = "0" Then
                Dim con As SQLiteConnection = New SQLiteConnection(ConfigurationManager.ConnectionStrings("Connect").ConnectionString)
                Dim cmd As SQLiteCommand
                Dim drItems As SQLiteDataReader
                Dim id As String = "0"
                con.Open()
                'Dim transcation As SQLiteTransaction = con.BeginTransaction()
                'Using command1 = con.CreateCommand()
                For index = 0 To dt.Rows.Count - 1
                    If dt.Rows(index)(0) IsNot DBNull.Value And dt.Rows(index)(1) IsNot DBNull.Value Then

                        SUB_NO = CStr(IIf(dt.Rows(index)(0) Is DBNull.Value, Nothing, dt.Rows(index)(0).ToString.ToString))
                        NAME = CStr(IIf(dt.Rows(index)(1) Is DBNull.Value, Nothing, dt.Rows(index)(2).ToString))
                        ADD_1 = CStr(IIf(dt.Rows(index)(2) Is DBNull.Value, Nothing, dt.Rows(index)(3).ToString))
                        ADD_2 = CStr(IIf(dt.Rows(index)(3) Is DBNull.Value, Nothing, dt.Rows(index)(4).ToString))
                        ADD_3 = CStr(IIf(dt.Rows(index)(4) Is DBNull.Value, Nothing, dt.Rows(index)(5).ToString))
                        STATE = CStr(IIf(dt.Rows(index)(5) Is DBNull.Value, Nothing, dt.Rows(index)(6).ToString))
                        PIN = CStr(IIf(dt.Rows(index)(6) Is DBNull.Value, Nothing, dt.Rows(index)(7).ToString))
                        Status = CStr(IIf(dt.Rows(index)(7) Is DBNull.Value, Nothing, dt.Rows(index)(8).ToString))
                        ClientName = CStr(IIf(dt.Rows(index)(8) Is DBNull.Value, Nothing, dt.Rows(index)(9).ToString))
                        Poddate = CStr(IIf(dt.Rows(index)(9) Is DBNull.Value, Nothing, dt.Rows(index)(10).ToString))
                        Comapny_Name = cmbcompany.Text
                        RefNO = CStr(IIf(dt.Rows(index)(1) Is DBNull.Value, Nothing, dt.Rows(index)(1).ToString))
                        cmd = New SQLiteCommand("select SUB_NO  from tb_PODGenration where SUB_NO='" + SUB_NO + "'", con)
                        drItems = cmd.ExecuteReader()
                        If drItems.HasRows Then

                            While (drItems.Read())


                                cmd = New SQLiteCommand("update tb_PODGenration set SUB_NO=@SUB_NO,NAME=@NAME,ADD_1=@ADD_1,ADD_2=@ADD_2,ADD_3=@ADD_3,STATE=@STATE,PIN=@PIN,Status=@Status,ClientName=@ClientName,Poddate=@Poddate,Comapny_Name=@Comapny_Name,RefNO=@RefNO where SUB_NO='" + SUB_NO + "'  ", con)
                                cmd.Parameters.AddWithValue("@SUB_NO", SUB_NO)
                                cmd.Parameters.AddWithValue("@NAME", NAME)
                                cmd.Parameters.AddWithValue("@ADD_1", ADD_1)
                                cmd.Parameters.AddWithValue("@ADD_2", ADD_2)
                                cmd.Parameters.AddWithValue("@ADD_3", ADD_3)
                                cmd.Parameters.AddWithValue("@STATE", STATE)
                                cmd.Parameters.AddWithValue("@PIN", PIN)
                                cmd.Parameters.AddWithValue("@Status", Status)
                                cmd.Parameters.AddWithValue("@ClientName", ClientName)
                                cmd.Parameters.AddWithValue("@Poddate", Poddate)
                                cmd.Parameters.AddWithValue("@Comapny_Name", Comapny_Name)
                                cmd.Parameters.AddWithValue("@RefNO", RefNO)
                                'command1.CommandText = "update tb_PODGenration set SUB_NO='" + SUB_NO + "',NAME='" + NAME + "',ADD_1='" + ADD_1 + "',ADD_2='" + ADD_2 + "',ADD_3='" + ADD_3 + "',STATE='" + STATE + "',PIN='" + PIN + "',Status='" + Status + "',ClientName='" + ClientName + "',Poddate='" + Poddate + "',Comapny_Name='" + Comapny_Name + "',RefNO='" + RefNO + "' where SUB_NO='" + SUB_NO + "'  "
                                cmd.ExecuteNonQuery()

                            End While
                        Else
                            cmd = New SQLiteCommand("select max(id) from tb_PODGenration", con)
                            If cmd.ExecuteScalar().ToString() = String.Empty Then
                                id = "1"
                            Else
                                id = CStr(CInt(cmd.ExecuteScalar()) + 1)
                            End If

                            cmd = New SQLiteCommand("insert into tb_PODGenration(id,SUB_NO,NAME,ADD_1,ADD_2,ADD_3,STATE,PIN,Status,ClientName,Poddate,Comapny_Name,RefNO) values (@id,@SUB_NO,@NAME,@ADD_1,@ADD_2,@ADD_3,@STATE,@PIN,@Status,@ClientName,@Poddate,@Comapny_Name,@RefNO)", con)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.Parameters.AddWithValue("@SUB_NO", SUB_NO)
                            cmd.Parameters.AddWithValue("@NAME", NAME)
                            cmd.Parameters.AddWithValue("@ADD_1", ADD_1)
                            cmd.Parameters.AddWithValue("@ADD_2", ADD_2)
                            cmd.Parameters.AddWithValue("@ADD_3", ADD_3)
                            cmd.Parameters.AddWithValue("@STATE", STATE)
                            cmd.Parameters.AddWithValue("@PIN", PIN)
                            cmd.Parameters.AddWithValue("@Status", Status)
                            cmd.Parameters.AddWithValue("@ClientName", ClientName)
                            cmd.Parameters.AddWithValue("@Poddate", Poddate)
                            cmd.Parameters.AddWithValue("@Comapny_Name", Comapny_Name)
                            cmd.Parameters.AddWithValue("@RefNO", RefNO)
                            'command1.CommandText = "insert into tb_PODGenration(id,SUB_NO,NAME,ADD_1,ADD_2,ADD_3,STATE,PIN,Status,ClientName,Poddate,Comapny_Name,RefNO) values ('" + id + "','" + SUB_NO + "','" + NAME + "','" + ADD_1 + "','" + ADD_2 + "','" + ADD_3 + "','" + STATE + "','" + PIN + "','" + Status + "','" + ClientName + "','" + Poddate + "','" + Comapny_Name + "','" + RefNO + "')"
                            cmd.ExecuteNonQuery()
                        End If
                        drItems.Close()
                    End If
                Next
                '    transcation.Commit()
                'End Using
                con.Close()
            Else


                'binding Report viewer with dtEven and dtOdd
                Dim result As Telerik.Reporting.Processing.RenderingResult
                Dim objRpt As New POD
                Dim reportSource As New Telerik.Reporting.InstanceReportSource
                Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor()
                Dim List1 As Telerik.Reporting.List = DirectCast(objRpt.Items(0).Items("List1"), Telerik.Reporting.List)
                Dim List2 As Telerik.Reporting.List = DirectCast(objRpt.Items(0).Items("List2"), Telerik.Reporting.List)
                Dim Textbox1 As Telerik.Reporting.TextBox = DirectCast(List1.Items(0).Items("TextBox23"), Telerik.Reporting.TextBox)
                Dim Textbox2 As Telerik.Reporting.TextBox = DirectCast(List2.Items(0).Items("TextBox4"), Telerik.Reporting.TextBox)
                'If CStr(dtEven(0)("Comapny_Name")) = "SHREE KRISHNA ENTERPRISE" Then
                '    Textbox1.Value = ""
                '    Textbox2.Value = ""
                'ElseIf CStr(dtEven(0)("Comapny_Name")) = "S K EXPRESS" Then
                Textbox1.Value = "www.skexpress.in"
                Textbox2.Value = "www.skexpress.in"
                'End If
                If dtEven.Rows.Count > 0 Then
                    List1.DataSource = dtEven
                End If
                If dtOdd.Rows.Count > 0 Then
                    List2.DataSource = dtOdd
                End If

                Dim rptBook As New ReportBook
                rptBook.Reports.Add(objRpt)

                reportSource.ReportDocument = rptBook
                Dim deviceInfo As New System.Collections.Hashtable()

                'ReportViewer1.ReportSource = reportSource
                result = reportProcessor.RenderReport("PDF", reportSource, deviceInfo)
                Dim fileName As String = result.DocumentName + "." + result.Extension
                Response.Clear()
                Response.ContentType = result.MimeType
                Response.Cache.SetCacheability(HttpCacheability.Private)
                Response.Expires = -1
                Response.Buffer = True
                Response.AddHeader("Content-Disposition", String.Format("{0};FileName=""{1}""", "attachment", fileName))
                Response.BinaryWrite(result.DocumentBytes)
                Response.End()
                'ScriptManager.RegisterStartupScript(Me, Me.GetType(), "AlertC", "setTimeout( fnViewReport(),50000);", True)
            End If

            sSourceConnection.Close()

            'Delete file from path after saving data
            File.Delete(sPath)


        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "AlertC", "alert('" + ex.Message.Replace("'", "") + "');", True)
        End Try
    End Sub
End Class