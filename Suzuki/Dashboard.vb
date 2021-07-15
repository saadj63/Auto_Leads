Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.bcdtxt.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Registrationvb
        myForm.Show()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("Select * from Customers where card_id= '" & bcdtxt.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        Try

            If (dt.Rows.Count > 0) Then

                Dim vOut As String
                vOut = CStr(bcdtxt.Text())

                Dim ConnectionString As String = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True"
                Dim Sql As String = "Select * from Customers where card_id='" + vOut + "'"
                Dim Connection As New SqlConnection(ConnectionString)
                Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
                Dim DS As New DataSet()
                Connection.Open()
                DataAdapter.Fill(DS, "Customers")
                DataGridView1.DataSource = DS
                DataGridView1.DataMember = "Customers"

                Dim Da As New service
                Da.Label20.Text = bcdtxt.Text

                Da.Show()
                Me.Hide()

            Else


                MessageBox.Show("Sorry Customer Does Not EXIST !!! PLease Create Customer...")


            End If
        Catch ex As SqlException
            WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim ConnectionString As String = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True"
            Dim Sql As String = "Select * from Customers"
            Dim Connection As New SqlConnection(ConnectionString)
            Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
            Dim DS As New DataSet()
            Connection.Open()
            DataAdapter.Fill(DS, "Customers")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "Customers"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)


    End Sub
End Class