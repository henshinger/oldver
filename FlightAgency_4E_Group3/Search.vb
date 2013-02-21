Public Class frmSearch


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim strTable As String
        Me.Hide()
        Select Case cboType.SelectedItem
            Case "User"
                strTable = "UserTable"
            Case "Seat"
                strTable = "SeatTable"
            Case "Flight"
                strTable = "FlightTable"
            Case Else
                MessageBox.Show("Please specify what to search for")
        End Select

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmHome.Show()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged

    End Sub
End Class
