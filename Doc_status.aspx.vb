Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SQLite

Public Class Doc_status
    Inherits System.Web.UI.Page


    Protected Sub btnSearchButton_Click(sender As Object, e As EventArgs) Handles btnSearchButton.Click

        Dim con As SQLiteConnection = New SQLiteConnection(ConfigurationManager.ConnectionStrings("Connect").ConnectionString)
        con.Open()
        Dim cmd As SQLiteCommand = New SQLiteCommand("SELECT SUB_NO,NAME,ADD_1||' ,'||ADD_2||', '|| ADD_3 AS Address,PIN,Status,STATE FROM tb_PODGenration WHERE SUB_NO ='" + txtTrackId.Text + "'", con)
        cmd.Parameters.AddWithValue("@SUB_NO", txtTrackId.Text)
        Dim drItems As SQLiteDataReader = Nothing
        drItems = cmd.ExecuteReader()
        If (drItems.Read()) Then
            txtTrackId.Text = (drItems("SUB_NO").ToString())
            txtName.Text = (drItems("Name").ToString())
            txtAddress.Text = (drItems("Address").ToString())
            txtState.Text = (drItems("STATE").ToString())
            txtPn.Text = (drItems("PIN").ToString())
            txtStatus.Text = (drItems("Status").ToString())
        End If
        drItems.Close()
        con.Close()

    End Sub

    Private Sub Doc_status_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not Request.QueryString("trackingId") Is Nothing Then
                Dim trackingId As String = Request.QueryString("trackingId")
                txtTrackId.Text = trackingId

                Dim con As SQLiteConnection = New SQLiteConnection(ConfigurationManager.ConnectionStrings("Connect").ConnectionString)
                con.Open()
                Dim cmd As SQLiteCommand = New SQLiteCommand("SELECT SUB_NO,NAME,ADD_1||' ,'||ADD_2||', '|| ADD_3 AS Address,PIN,Status,STATE FROM tb_PODGenration WHERE SUB_NO ='" + txtTrackId.Text + "'", con)
                cmd.Parameters.AddWithValue("@SUB_NO", txtTrackId.Text)
                Dim drItems As SQLiteDataReader = Nothing
                drItems = cmd.ExecuteReader()

                If (drItems.Read()) Then
                    txtTrackId.Text = (drItems("SUB_NO").ToString())
                    txtName.Text = (drItems("Name").ToString())
                    txtAddress.Text = (drItems("Address").ToString())
                    txtState.Text = (drItems("STATE").ToString())
                    txtPn.Text = (drItems("PIN").ToString())
                    txtStatus.Text = (drItems("Status").ToString())
                End If
                drItems.Close()
                con.Close()

            End If

        End If
    End Sub
End Class