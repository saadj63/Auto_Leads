Imports System.Data.SqlClient

Public Class service
    Private Sub service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized


            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("Select * from Avl_Service where card_id='" & Label20.Text & "'", conn)

            Dim myreader As SqlDataReader

            myreader = cmd.ExecuteReader




            If myreader.Read Then
                Label7.Text = myreader("Genral_checkup")
                Label8.Text = myreader("washing")
                Label9.Text = myreader("alignment")
                Label18.Text = myreader("balancing")
                Label11.Text = myreader("checkup")
                Label12.Text = myreader("scanning")
                Label19.Text = myreader("ac")

            Else
                MessageBox.Show("No Data Found")

            End If
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try


        Try


            Dim conn1 As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn1.Open()
            Dim cmd1 As New SqlCommand("Select * from Used_Service where card_id='" & Label20.Text & "'", conn1)

            Dim myreader1 As SqlDataReader

            myreader1 = cmd1.ExecuteReader




            If myreader1.Read Then
                Label32.Text = myreader1("Genral_checkup")
                Label27.Text = myreader1("washing")
                Label28.Text = myreader1("alignment")
                Label5.Text = myreader1("balancing")
                Label33.Text = myreader1("checkup")
                Label30.Text = myreader1("scanning")
                Label31.Text = myreader1("ac")

            Else
                MessageBox.Show("No Data Found")

            End If
            conn1.Close()


        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Us As New Use_Services

        Us.Label3.Text = Label20.Text

        Us.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New Dashboard
        da.Show()
        Me.Hide()
    End Sub


End Class