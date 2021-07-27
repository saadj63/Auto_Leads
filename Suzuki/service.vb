Imports System.Data.SqlClient

Public Class service
    Private Sub service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized


            Label14.Text = Today

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
                Dim l32 As String = myreader1("Genral_checkup")
                Dim s32 As String = l32.Trim(",")

                Label32.Text = s32



                Dim l27 As String
                l27 = myreader1("washing")

                Label27.Text = l27.Trim(",")


                Dim l28 As String = myreader1("alignment")
                Label28.Text = l28.Trim(",")

                Dim l15 As String = myreader1("balancing")

                Label5.Text = l15.Trim(",")

                Dim l33 As String
                l33 = myreader1("checkup")

                Label33.Text = l33.Trim(",")

                Dim l30 As String = myreader1("scanning")
                Label30.Text = l30.Trim(",")

                Dim l31 As String = myreader1("ac")
                Label31.Text = l31.Trim(",")

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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim csd As New Customer_Details
        csd.id.Text = Label20.Text
        csd.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.WindowState = FormWindowState.Maximized

            Label14.Text = Today

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
                Dim l32 As String = myreader1("Genral_checkup")
                Dim s32 As String = l32.Trim(",")

                Label32.Text = s32



                Dim l27 As String
                l27 = myreader1("washing")

                Label27.Text = l27.Trim(",")


                Dim l28 As String = myreader1("alignment")
                Label28.Text = l28.Trim(",")

                Dim l15 As String = myreader1("balancing")

                Label5.Text = l15.Trim(",")

                Dim l33 As String
                l33 = myreader1("checkup")

                Label33.Text = l33.Trim(",")

                Dim l30 As String = myreader1("scanning")
                Label30.Text = l30.Trim(",")

                Dim l31 As String = myreader1("ac")
                Label31.Text = l31.Trim(",")

            Else
                MessageBox.Show("No Data Found")

            End If
            conn1.Close()


        Catch ex As Exception

        End Try




    End Sub
End Class