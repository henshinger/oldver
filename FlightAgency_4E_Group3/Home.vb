Public Class frmHome

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFlight.Click
        Me.Hide()
        frmNewFlight.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.Hide()
        frmSearch.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesReport.Click
        Me.Hide()
        frmSalesReport.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub btnNewTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTransaction.Click
        Me.Hide()
        frmNewTransaction.Show()
    End Sub
End Class
