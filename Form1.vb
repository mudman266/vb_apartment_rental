Public Class frmMain
    'Class variables
    Public Shared FILENAME = "c:\school\csc-139\chapter8\rentals.txt"
    Public Shared RENTALS(9, 1)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup file reader
        Dim objReader As IO.StreamReader
        objReader = IO.File.OpenText(FILENAME)
        'Read the city names and rental costs into the 2D array RENTALS
        Dim strNextLine As String
        For i = 0 To 10
            strNextLine = objReader.ReadLine
            If strNextLine <> "" Then
                RENTALS(i, 0) = strNextLine
                RENTALS(i, 1) = objReader.ReadLine
                'Add the city to the listbox
                lstCities.Items.Add(RENTALS(i, 0))
            End If
        Next
    End Sub

    Private Sub Get_City_Cost(sender As Object, e As EventArgs) Handles lstCities.SelectedIndexChanged
        If lstCities.SelectedIndex <> -1 Then
            lblSelectedCost.Text = "The selected city rental's median cost of $" & RENTALS(lstCities.SelectedIndex, 1)
            lblSelectedCost.Visible = True
        End If
    End Sub

    Private Sub btnComputeAverage_Click(sender As Object, e As EventArgs) Handles btnComputeAverage.Click
        Dim decTotalCost As Decimal
        For i = 0 To RENTALS.GetUpperBound(0)
            decTotalCost += Convert.ToDecimal(RENTALS(i, 1))
        Next
        Compute_Avg(decTotalCost)
    End Sub

    Private Sub Compute_Avg(decTotal)
        'The program restrictions require 2 sub methods to compute the average
        Dim decAvg As Decimal = decTotal / (RENTALS.GetUpperBound(0) + 1)
        lblAvgCost.Text = "Average Rental City Cost: " & decAvg.ToString("C2")
        lblAvgCost.Visible = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstCities.SelectedIndex = -1
        lblSelectedCost.Visible = False
        lblAvgCost.Visible = False
    End Sub

    Private Sub DisplayTopTenCitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayTopTenCitiesToolStripMenuItem.Click
        frmTenCities.Show()
    End Sub
End Class
