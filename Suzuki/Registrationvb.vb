
Imports System.Data.SqlClient
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources

Public Class Registrationvb
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Dim result As Integer

    Private Sub Registrationvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cridtxt.Text() <> "" And nmtxt.Text() <> "" And mbtxt.Text() <> "" And addtxt.Text() <> "" And mdtxt.Text() <> "") Then
            Dim dt As Date = Today
            Dim st As String
            st = "ACTIVE"
            sql1 = "INSERT INTO Avl_Service VALUES('" & cridtxt.Text & "','1','3','2','2','2','2','2')"
            sql2 = "INSERT INTO Used_Service VALUES('" & cridtxt.Text & "','','','','','','','')"

            If CheckBox1.Checked = True Then
                sql = "INSERT INTO Customers (card_id,name,mobile_no,address,rc_no,model,Status,joining_date,expiry_date,other) VALUES ('" & cridtxt.Text & "','" & nmtxt.Text & "','" & mbtxt.Text & "','" & addtxt.Text & "','" & rctxt.Text & "','" & mdtxt.Text & "','" & st & "','" & dt & "','" & dt.AddYears(1) & "','YES')"
                saveData(sql)
            Else

                sql = "INSERT INTO Customers (card_id,name,mobile_no,address,rc_no,model,Status,joining_date,expiry_date,other) VALUES ('" & cridtxt.Text & "','" & nmtxt.Text & "','" & mbtxt.Text & "','" & addtxt.Text & "','" & rctxt.Text & "','" & mdtxt.Text & "','" & st & "','" & dt & "','" & dt.AddYears(1) & "','NO')"
                saveData(sql)
            End If

            Dim strGet As String

            strGet = "http://api.bulksmsgateway.in/sendmessage.php?user=saadj63&password=Saadj63@&mobile=" & mbtxt.Text & "&message=Dear " & nmtxt.Text & " , Thank You for Purchasing Sai Auto Leads GOLD Membership Card. Your Card No is " & cridtxt.Text & " .&sender=SAIAUL&type=3&template_id=1007477721334841899"
            Try
                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(strGet)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            '  cridtxt.Clear()
            ' nmtxt.Clear()
            'mbtxt.Clear()
            'addtxt.Clear()
            'rctxt.Clear()
            'mdtxt.Clear()


            Me.Close()
        Else

            MessageBox.Show("Please Fill All Details")
        End If


    End Sub
    Private Sub saveData(sql As String)
        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                MessageBox.Show("Customer Created")

                saveAvl(sql1)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveAvl(sql1 As String)
        Try
            con.Close()

            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql1
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then

                saveUse(sql2)
                MessageBox.Show("Services Created")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUse(sql2 As String)
        Try
            con.Close()
            con.Open()

            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql2
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                MessageBox.Show(" Used Services Created")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class


