Public Class frmTenCities
    Private Sub frmTenCities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the list boxes
        For i = 0 To frmMain.RENTALS.GetUpperBound(0)
            lstCities.Items.Add(frmMain.RENTALS(i, 0))
            lstPrices.Items.Add(frmMain.RENTALS(i, 1))
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Close this form
        Close()
    End Sub
End Class