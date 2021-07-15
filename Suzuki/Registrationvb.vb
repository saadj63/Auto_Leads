
Imports System.Data.SqlClient
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
            sql = "INSERT INTO Customers (card_id,name,mobile_no,address,rc_no,model,Status,joining_date,expiry_date) VALUES ('" & cridtxt.Text & "','" & nmtxt.Text & "','" & mbtxt.Text & "','" & addtxt.Text & "','" & rctxt.Text & "','" & mdtxt.Text & "','" & st & "','" & dt & "','" & dt.AddYears(1) & "')"
            sql1 = "INSERT INTO Avl_Service VALUES('" & cridtxt.Text & "','1','3','2','2','2','2','2')"
            sql2 = "INSERT INTO Used_Service VALUES('" & cridtxt.Text & "','0','0','0','0','0','0','0')"
            saveData(sql)
            saveAvl(sql1)
            saveUse(sql2)


            cridtxt.Clear()
            nmtxt.Clear()
            mbtxt.Clear()
            addtxt.Clear()
            rctxt.Clear()
            mdtxt.Clear()
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
                Me.Hide()
                Dim rg As New Dashboard
                rg.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveAvl(sql1 As String)
        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql1
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
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