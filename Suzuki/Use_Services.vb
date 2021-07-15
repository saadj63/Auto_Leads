Imports System.Data.SqlClient
Public Class Use_Services
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim sql4 As String
    Dim sql5 As String
    Dim sql6 As String
    Dim usql As String
    Dim Usql1 As String
    Dim Usql2 As String
    Dim Usql3 As String
    Dim Usql4 As String
    Dim Usql5 As String
    Dim Usql6 As String


    Dim result As Integer

    Private Sub Use_Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        gc.Enabled = False
        wa.Enabled = False
        wb.Enabled = False
        vc.Enabled = False
        ac.Enabled = False
        cws.Enabled = False
        cs.Enabled = False
        Try



            Dim conn As New SqlConnection("Data Source=DESKTOP-QIKDG9C;Initial Catalog=masuzu; Integrated Security=True")
            conn.Open()
            Dim cmd As New SqlCommand("Select * from Avl_Service where card_id='" & Label3.Text & "'", conn)
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            If myreader.Read Then

                Dim a, a1, a2, a3, a4, a5, a6 As Integer
                a = myreader("Genral_checkup")
                a1 = myreader("ac")
                a2 = myreader("washing")
                a3 = myreader("alignment")
                a4 = myreader("balancing")
                a5 = myreader("checkup")
                a6 = myreader("scanning")


                If (a > 0) Then
                    gc.Enabled = True

                End If

                If (a1 > 0) Then
                    ac.Enabled = True

                End If
                If (a2 > 0) Then
                    cws.Enabled = True

                End If

                If (a3 > 0) Then
                    wa.Enabled = True

                End If

                If (a4 > 0) Then
                    wb.Enabled = True

                End If

                If (a5 > 0) Then
                    vc.Enabled = True

                End If

                If (a6 > 0) Then
                    cs.Enabled = True

                End If

            Else
                MessageBox.Show("No Data Found")

            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dt As Date = Today
        Dim st As String = Label3.Text
        Dim cd As String = Convert.ToInt32(st)

        If (gc.Checked = True) Then


            sql = "UPDATE Avl_Service
                SET Genral_checkup = Genral_checkup-1
                WHERE card_id ='" & st & "'"
            usql = "Update Used_Service SET Genral_checkup = Genral_checkup+'," & dt & "' where card_id='" & st & "'"

            saveData(sql)
            saveUsql(usql)

        End If

        If (ac.Checked = True) Then

            sql1 = "UPDATE Avl_Service
                SET ac = ac-1
                WHERE card_id ='" & st & "'"
            Usql1 = "Update Used_Service SET ac = ac+'," & dt & "' where card_id='" & st & "'"


            saveData1(sql1)
            saveUsql1(Usql1)

        End If

        If (cws.Checked = True) Then

            sql2 = "UPDATE Avl_Service
                SET washing = washing-1
                WHERE card_id ='" & st & "'"
            Usql2 = "Update Used_Service SET washing = washing+'," & dt & "' where card_id='" & st & "'"

            saveData2(sql2)
            saveUsql2(Usql2)
        End If

        If (wa.Checked = True) Then

            sql3 = "UPDATE Avl_Service
                SET alignment = alignment-1
                WHERE card_id ='" & st & "'"
            Usql3 = "Update Used_Service SET alignment = alignment+'," & dt & "' where card_id='" & st & "'"

            saveData3(sql3)
            saveUsql3(Usql3)

        End If

        If (wb.Checked = True) Then

            sql4 = "UPDATE Avl_Service
                SET balancing = balancing-1
                WHERE card_id ='" & st & "'"
            Usql4 = "Update Used_Service SET balancing = balancing+'," & dt & "' where card_id='" & st & "'"

            saveData4(sql4)
            saveUsql4(Usql4)

        End If

        If (vc.Checked = True) Then

            sql5 = "UPDATE Avl_Service
                SET checkup = checkup-1
                WHERE card_id ='" & st & "'"
            Usql5 = "Update Used_Service SET checkup = checkup+'," & dt & "' where card_id='" & st & "'"

            saveData5(sql5)
            saveUsql5(Usql5)
        End If

        If (cs.Checked = True) Then
            sql6 = "UPDATE Avl_Service
                SET scanning = scanning-1
                WHERE card_id ='" & st & "'"
            Usql6 = "Update Used_Service SET scanning = scanning+'," & dt & "' where card_id='" & st & "'"


            saveData6(sql6)
            saveUsql6(Usql6)


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
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql(usql As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub saveData1(sql1 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql1
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql1(usql1 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql1
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub saveData2(sql2 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql2
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("Sql2", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql2(usql2 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql2
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then

                Dim s As New Use_Services
                s.Show()

            End If

        Catch ex As Exception
            MessageBox.Show("uSql2", ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub saveData3(sql3 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql3
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("sql3", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql3(usql3 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql3
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("usql3", ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub saveData4(sql4 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql4
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("sql4", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql4(usql4 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql4
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("sql4", ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub saveData5(sql5 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql5
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then

            End If

        Catch ex As Exception
            MessageBox.Show("sql5", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql5(usql5 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql5
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("usql5",ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub saveData6(sql6 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql6
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("sql6", ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub saveUsql6(usql6 As String)

        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = usql6
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then


            End If

        Catch ex As Exception
            MessageBox.Show("usql6", ex.Message)
        Finally
            con.Close()
        End Try
        Dim d As New Dashboard
        d.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim d As New Dashboard
        d.Show()


    End Sub


End Class