Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OracleConnection1.Open()
            Dim command As String
            command = "insert into ARTIST(Artist,Company,Sales)" _
                      & " values('" & cmbArtist.Text & "', '" _
                      & cmbCompany.Text & "', " & txtSales.Text & ")"

            OracleDataAdapter1.InsertCommand.CommandText = command

            lblSQL.Text = command

            OracleDataAdapter1.InsertCommand.ExecuteNonQuery()

            MsgBox("Insert Successful", MsgBoxStyle.Information, "Insert Status")
            clear()
            reLoad()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OracleConnection1.Open()
            Dim command As String

            If cmbArtist.Text = Nothing Then
                MsgBox("Please Enter Artist", MsgBoxStyle.Critical, "Error")
            Else
                If (cmbCompany.Text <> Nothing And txtSales.Text = Nothing) Then
                    command = "update ARTIST set Company = '" & _
                                cmbCompany.Text & "' " & " where Artist = '" & cmbArtist.Text & "'"
                ElseIf (cmbCompany.Text = Nothing And txtSales.Text <> Nothing) Then
                    command = "update ARTIST set Sales = " & txtSales.Text _
                                & " where Artist = '" & cmbArtist.Text & "'"
                Else
                    command = "update ARTIST set Company = '" & _
                    cmbCompany.Text & "', " & "Sales = " & txtSales.Text _
                    & " where Artist = '" & cmbArtist.Text & "'"
                End If
                OracleDataAdapter1.UpdateCommand.CommandText = command

                lblSQL.Text = command

                OracleDataAdapter1.UpdateCommand.ExecuteNonQuery()
                MsgBox("Update Successful", MsgBoxStyle.Information, "Update Status")
                clear()
                reLoad()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim table As New DataTable
            Dim command As String
            Dim recordCount As Integer


            If cmbArtist.Text = Nothing Then
                MsgBox("Please Enter Artist", MsgBoxStyle.Critical, "Error")
            Else
                command = "select * from ARTIST where " _
                & "Artist = " & " '" & cmbArtist.Text & "'"

                OracleDataAdapter1.SelectCommand.CommandText = command
                lblSQL.Text = command

                table.Clear()
                recordCount = OracleDataAdapter1.Fill(table)

                If recordCount <> 0 Then
                    cmbCompany.Text = CStr(table.Rows(0)(1))
                    txtSales.Text = CStr(table.Rows(0)(2))
                Else
                    MessageBox.Show("Company not found")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OracleConnection1.Open()
            Dim command As String
            Dim recordCount As Integer

            If cmbArtist.Text = Nothing Then
                MsgBox("Please Enter Artist", MsgBoxStyle.Critical, "Error")
            Else
                command = "delete from ARTIST where Artist = '" _
                   & cmbArtist.Text & "'"

                OracleDataAdapter1.DeleteCommand.CommandText = command

                lblSQL.Text = command

                recordCount = OracleDataAdapter1.DeleteCommand.ExecuteNonQuery()
                If (recordCount <> 0) Then
                    MsgBox("Delete Successful", MsgBoxStyle.Information, "Delete Status")
                    clear()
                    reLoad()
                Else
                    MessageBox.Show("Artist not found")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub
    Private Sub clear()
        cmbArtist.Text = Nothing
        cmbCompany.Text = Nothing
        txtSales.Text = Nothing
        cmbCompany2.Text = Nothing
        txtLocation.Text = Nothing
        txtCountry.Text = Nothing
    End Sub
    Private Sub reLoad()
        Dim table As New DataTable
        Dim command As String
        Dim recordCount As Integer

        Try

            command = "select company from company"

            OracleDataAdapter1.SelectCommand.CommandText = command


            table.Clear()
            cmbCompany.Text = Nothing
            recordCount = OracleDataAdapter1.Fill(table)
            Dim index As Short = 0
            cmbCompany.Items.Clear()
            While index < recordCount
                'table.Rows.Count

                cmbCompany.Items.Add(CStr(table.Rows(index)(0)))
                index = index + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try


            command = "select artist from artist"

            OracleDataAdapter1.SelectCommand.CommandText = command

            table = New DataTable
            table.Clear()
            cmbArtist.Text = Nothing
            recordCount = OracleDataAdapter1.Fill(table)
            Dim index As Short = 0
            cmbArtist.Items.Clear()
            While index < recordCount
                'table.Rows.Count

                cmbArtist.Items.Add(CStr(table.Rows(index)(0)))
                index = index + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Try

            command = "select company from company"

            OracleDataAdapter1.SelectCommand.CommandText = command

            table = New DataTable
            table.Clear()
            cmbCompany2.Text = Nothing
            recordCount = OracleDataAdapter1.Fill(table)
            Dim index As Short = 0
            cmbCompany2.Items.Clear()
            While index < recordCount
                'table.Rows.Count

                cmbCompany2.Items.Add(CStr(table.Rows(index)(0)))
                index = index + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reLoad()
    End Sub

    Private Sub cmbArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArtist.SelectedIndexChanged

    End Sub

    Private Sub cmbCompany2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompany2.SelectedIndexChanged

    End Sub

    Private Sub btnInsert2_Click(sender As Object, e As EventArgs) Handles btnInsert2.Click
        Try
            OracleConnection1.Open()
            Dim command As String
            command = "insert into COMPANY(Company,Location,Country)" _
                      & " values('" & cmbCompany2.Text & "', '" _
                      & txtLocation.Text & "', '" & txtCountry.Text & "')"

            OracleDataAdapter1.InsertCommand.CommandText = command

            lblSQL.Text = command

            OracleDataAdapter1.InsertCommand.ExecuteNonQuery()

            MsgBox("Insert Successful", MsgBoxStyle.Information, "Insert Status")
            clear()
            reLoad()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        Try
            OracleConnection1.Open()
            Dim command As String
            Dim recordCount As Integer

            If cmbCompany2.Text = Nothing Then
                MsgBox("Please Enter Artist", MsgBoxStyle.Critical, "Error")
            Else
                command = "delete from COMPANY where Company = '" _
                   & cmbCompany2.Text & "'"

                OracleDataAdapter1.DeleteCommand.CommandText = command

                lblSQL.Text = command

                recordCount = OracleDataAdapter1.DeleteCommand.ExecuteNonQuery()
                If (recordCount <> 0) Then
                    MsgBox("Delete Successful", MsgBoxStyle.Information, "Delete Status")
                    clear()
                    reLoad()
                Else
                    MessageBox.Show("Company not found")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub

    Private Sub btnRetrieve2_Click(sender As Object, e As EventArgs) Handles btnRetrieve2.Click
        Try
            Dim table As New DataTable
            Dim command As String
            Dim recordCount As Integer


            If cmbCompany2.Text = Nothing Then
                MsgBox("Please Enter Company", MsgBoxStyle.Critical, "Error")
            Else
                command = "select * from Company where " _
                & "Company = " & " '" & cmbCompany2.Text & "'"

                OracleDataAdapter1.SelectCommand.CommandText = command
                lblSQL.Text = command

                table.Clear()
                recordCount = OracleDataAdapter1.Fill(table)

                If recordCount <> 0 Then
                    txtLocation.Text = CStr(table.Rows(0)(1))
                    txtCountry.Text = CStr(table.Rows(0)(2))
                Else
                    MessageBox.Show("Location not found")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Try
            OracleConnection1.Open()
            Dim command As String

            If cmbCompany2.Text = Nothing Then
                MsgBox("Please Enter Company", MsgBoxStyle.Critical, "Error")
            Else
                If (txtLocation.Text <> Nothing And txtCountry.Text = Nothing) Then
                    command = "update COMPANY set Location = '" & _
                                txtLocation.Text & "' " & " where Company = '" & cmbCompany2.Text & "'"
                ElseIf (txtLocation.Text = Nothing And txtCountry.Text <> Nothing) Then
                    command = "update COMPANY set Country = '" & txtCountry.Text _
                        & "' where Company = '" & cmbCompany2.Text & "'"
                Else
                    command = "update COMPANY set Location = '" & _
                    txtLocation.Text & "', " & "Country = '" & txtCountry.Text _
                    & "' where Company = '" & cmbCompany2.Text & "'"
                End If
                OracleDataAdapter1.UpdateCommand.CommandText = command

                lblSQL.Text = command

                OracleDataAdapter1.UpdateCommand.ExecuteNonQuery()
                MsgBox("Update Successful", MsgBoxStyle.Information, "Update Status")
                clear()
                reLoad()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            OracleConnection1.Close()
        End Try
    End Sub

    Private Sub lblSQL_Click(sender As Object, e As EventArgs) Handles lblSQL.Click

    End Sub

    Private Sub OracleDataAdapter1_RowUpdated(sender As Object, e As OracleClient.OracleRowUpdatedEventArgs) Handles OracleDataAdapter1.RowUpdated

    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged

    End Sub
    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        clear()
    End Sub
End Class