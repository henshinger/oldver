Public Class frmSearch

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Select Case cboType.SelectedItem
            Case "User"
                frmEditUser.Show()
            Case "Seat"
                frmEditSeat.Show()
            Case "Flight"
                frmEditFlight.Show()
            Case Else
                MessageBox.Show("Please specify what to search for")
        End Select

    End Sub
End Class
