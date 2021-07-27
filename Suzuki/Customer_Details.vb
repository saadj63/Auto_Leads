Imports System.Data.SqlClient

Public Class Customer_Details
    Private Sub Customer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("Select * from Customers where card_id='" & id.Text & "'", conn)

            Dim myreader As SqlDataReader

            myreader = cmd.ExecuteReader




            If myreader.Read Then
                nm.Text = myreader("name")
                mb.Text = myreader("mobile_no")
                add.Text = myreader("address")
                md.Text = myreader("model")
                rc.Text = myreader("rc_no")
                st.Text = myreader("Status")
                jd.Text = myreader("joining_date")
                ed.Text = myreader("expiry_date")

            Else
                MessageBox.Show("No Data Found")

            End If
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Panel1.Visible = True) Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True

            Try



                Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
                conn.Open()
                Dim cmd As New SqlCommand("Select * from Customers where card_id='" & id.Text & "'", conn)

                Dim myreader As SqlDataReader

                myreader = cmd.ExecuteReader




                If myreader.Read Then
                    idtxt.Text = myreader("card_id")
                    nmtxt.Text = myreader("name")
                    mbtxt.Text = myreader("mobile_no")
                    addtxt.Text = myreader("address")
                    mdtxt.Text = myreader("model")
                    rcnotxt.Text = myreader("rc_no")
                    sttxt.Text = myreader("Status")
                    jdtxt.Text = myreader("joining_date")
                    edtxt.Text = myreader("expiry_date")

                Else
                    MessageBox.Show("No Data Found")

                End If
                conn.Close()
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try










        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Customers SET name='" + nmtxt.Text + " ',mobile_no = '" & mbtxt.Text & "',rc_no ='" + rcnotxt.Text + "',address='" & addtxt.Text & "',model='" & mdtxt.Text & "',joining_date='" & jdtxt.Text() & "',expiry_date='" & edtxt.Text & "' where card_id=" & id.Text


        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD UPDATED SUCCESSFULLY")

        Try



            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd1 As New SqlCommand("Select * from Customers where card_id='" & id.Text & "'", conn)

            Dim myreader As SqlDataReader

            myreader = cmd1.ExecuteReader




            If myreader.Read Then
                idtxt.Text = myreader("card_id")
                nmtxt.Text = myreader("name")
                mbtxt.Text = myreader("mobile_no")
                addtxt.Text = myreader("address")
                mdtxt.Text = myreader("model")
                rcnotxt.Text = myreader("rc_no")
                sttxt.Text = myreader("Status")
                jdtxt.Text = myreader("joining_date")
                edtxt.Text = myreader("expiry_date")

                show12()

            Else
                MessageBox.Show("No Data Found")

            End If
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try





    End Sub



    Public Sub show12()


        Try



            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("Select * from Customers where card_id='" & id.Text & "'", conn)

            Dim myreader As SqlDataReader

            myreader = cmd.ExecuteReader




            If myreader.Read Then
                nm.Text = myreader("name")
                mb.Text = myreader("mobile_no")
                add.Text = myreader("address")
                md.Text = myreader("model")
                rc.Text = myreader("rc_no")
                st.Text = myreader("Status")
                jd.Text = myreader("joining_date")
                ed.Text = myreader("expiry_date")
            Else
                MessageBox.Show("No Data Found")

            End If
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand


        con.ConnectionString = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete  from Customers  where card_id=" & id.Text
        cmd.ExecuteNonQuery()

        cmd1 = con.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "Delete  from Avl_Service  where card_id=" & id.Text
        cmd1.ExecuteNonQuery()


        cmd2 = con.CreateCommand()
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "Delete  from Used_Service where card_id=" & id.Text
        cmd2.ExecuteNonQuery()


        MessageBox.Show("RECORD Deleted  SUCCESSFULLY")
        con.Close()
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        Dim edt As Date = edtxt.Text

        cmd.CommandText = "update Customers SET expiry_date='" & edt.AddYears(1) & "' where card_id=" & id.Text


        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD UPDATED SUCCESSFULLY")

        Try



            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd1 As New SqlCommand("Select * from Customers where card_id='" & id.Text & "'", conn)

            Dim myreader As SqlDataReader

            myreader = cmd1.ExecuteReader




            If myreader.Read Then
                nm.Text = myreader("name")
                mb.Text = myreader("mobile_no")
                add.Text = myreader("address")
                md.Text = myreader("model")
                rc.Text = myreader("rc_no")
                st.Text = myreader("Status")
                jd.Text = myreader("joining_date")
                ed.Text = myreader("expiry_date")
            Else
                MessageBox.Show("No Data Found")

            End If
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try




    End Sub
End Class