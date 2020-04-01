'Program name:      Lake Effect Snowfall
'Author:            Robert Herbert
'Date:              November 4, 2018




Public Class Form1
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstSnowfall.Items.Clear()
        lblTotalSnowfall.Visible = False
        btnEnterSnowfall.Enabled = True

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Close()

    End Sub

    Private Sub btnEnterSnowfall_Click(sender As Object, e As EventArgs) Handles btnEnterSnowfall.Click

        Dim strSnowfall As String
        Dim decSnowfall As Decimal
        Dim decTotalSnowfall As Decimal = 0D
        Dim strInputMessage As String = "Enter the amount of snowfall for day #"
        Dim strInputHeading As String = "Amount of snowfall"
        Dim strNormalMessage As String = "Enter the amount of snowfall for day #"
        Dim strNonNumericError As String = "Error - Enter a number for the amount of snowfall for day #"
        Dim strNegativeError As String = "Error - Enter a positive number for the amount of snowfall for day #"

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 1

        strSnowfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strSnowfall = strCancelClicked

            If IsNumeric(strSnowfall) Then
                decSnowfall = Convert.ToDecimal(strSnowfall)
                If decSnowfall > 0 Then
                    lstSnowfall.Items.Add(decSnowfall)
                    decTotalSnowfall += decSnowfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If

            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strSnowfall = InputBox(strInputMessage & intNumberOfEntries, strInputMessage, " ")
            End If

        Loop

        If intNumberOfEntries > 1 Then
            lblTotalSnowfall.Visible = True
            decTotalSnowfall = decTotalSnowfall
            lblTotalSnowfall.Text = "Total amount of snowfall is " &
                decTotalSnowfall.ToString("F1") & "ins"
        Else
            MsgBox("No snowfall amount entered")

            btnEnterSnowfall.Enabled = False

        End If

    End Sub
End Class
