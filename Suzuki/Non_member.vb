Imports System.Data.SqlClient
Imports System.IO

Public Class Non_member

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As String


    Private Sub Non_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        disp()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into OnlyCust values('" + nm.Text + "','" + mb.Text + "','" + md.Text + "','" + rc.Text + "','" + add.Text + "') "
            cmd.ExecuteNonQuery()
            disp()
            MessageBox.Show("SAVED SUCCESSFULLY")
            DataGridView1.ClearSelection()

            nm.Clear()
            mb.Clear()
            add.Clear()
            rc.Clear()
            md.Clear()
        Catch ex As Exception
            MessageBox.Show("RECORD ALREADY EXISTS")
        End Try
    End Sub


    Public Sub disp()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from OnlyCust "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            i = DataGridView1.SelectedCells.Item(0).Value


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from OnlyCust where Name= '" & i & "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                nm.Text = dr.GetString(0)
                mb.Text = dr.GetString(1)
                md.Text = dr.GetString(2)
                rc.Text = dr.GetString(3)
                add.Text = dr.GetString(4)
                DataGridView1.ClearSelection()

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update OnlyCust SET Name='" & nm.Text & "',Mobile = '" & mb.Text & "',Model = '" & md.Text & "',RC ='" & rc.Text & "',Address='" & add.Text & "' where Name='" & i & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD UPDATED SUCCESSFULLY")
        nm.Clear()
        mb.Clear()
        add.Clear()
        rc.Clear()
        md.Clear()


        disp()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Delete from OnlyCust  where Name='" & i & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD DELETED SUCCESSFULLY")
        nm.Clear()
        mb.Clear()
        add.Clear()
        rc.Clear()
        md.Clear()
        disp()
        DataGridView1.ClearSelection()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.ClearSelection()
        nm.Clear()
        mb.Clear()
        add.Clear()
        rc.Clear()
        md.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            DataGridView1.ClearSelection()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from OnlyCust where Name LIKE  '%" + nm.Text + "%'"
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("NOT FOUND")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from OnlyCust "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

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

            Dim tw As IO.TextWriter = New IO.StreamWriter("D:\Test1.CSV")
            tw.Write(StrExport)
            tw.Close()
            MessageBox.Show("File Exported Successfully at Drive D ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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
End Class