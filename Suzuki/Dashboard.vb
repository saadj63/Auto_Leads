Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Dashboard

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As String
    Dim cmd1 As New SqlCommand
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.bcdtxt.Focus()


        con.ConnectionString = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If


        Dim dta As New Date
        dta = Today

        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Update  Customers Set Status= 'INACTIVE' Where expiry_date < '" & dta & "'"
        cmd.ExecuteNonQuery()
        con.Close()

        con.Open()
        cmd1 = con.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "Update  Customers Set Status= 'ACTIVE' Where expiry_date > '" & dta & "'"
        cmd1.ExecuteNonQuery()
        con.Close()


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
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.None





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim nm As New Non_member
        nm.Show()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sd As New SaveFileDialog
        sd.Filter = "CSV Files (*.csv)|*.csv"
        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then

            Try

                Dim StrExport As String = ""
                For Each C As DataGridViewColumn In DataGridView1.Columns
                    StrExport &= """" & C.HeaderText & ""","
                Next
                StrExport = StrExport.Substring(0, StrExport.Length - 1)
                StrExport &= Environment.NewLine

                For Each R As DataGridViewRow In DataGridView1.Rows
                    For Each C As DataGridViewCell In R.Cells
                        If Not C.Value Is Nothing Then
                            StrExport &= """" & C.Value.ToString & ""","
                        Else
                            StrExport &= """" & "" & ""","
                        End If
                    Next
                    StrExport = StrExport.Substring(0, StrExport.Length - 1)
                    StrExport &= Environment.NewLine
                Next

                Dim tw As IO.TextWriter = New IO.StreamWriter(sd.FileName)
                tw.Write(StrExport)
                tw.Close()
                MessageBox.Show("File Exported Successfully ")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            'save the file here
            Debug.WriteLine("Save file location:" + sd.FileName)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox1.SelectedIndex = 0 Then


            Try
                Dim ConnectionString As String = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True"
                Dim Sql As String = "Select * from Customers "
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
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Try
                Dim ConnectionString As String = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True"
                Dim Sql As String = "Select * from Customers where other='NO'"
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


        ElseIf ComboBox1.SelectedIndex = 2 Then

            Try
                Dim ConnectionString As String = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True"
                Dim Sql As String = "Select * from Customers where other='YES'"
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



        Else
            MessageBox.Show("Invalid Option")


        End If


    End Sub
End Class