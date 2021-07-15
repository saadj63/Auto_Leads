Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("Select * from login where usernm= '" + Usertxt.Text + "'and pwd='" + pwdtxt.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        Try

            If (dt.Rows.Count > 0) Then
                Dim myForm As New Dashboard
                myForm.Show()

                Me.Hide()



            Else
                MessageBox.Show("ERROR LOGIN FAiled")

            End If
        Catch ex As SqlException
            Console.WriteLine(ex)
        End Try

    End Sub


End Class
