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
        clstFilters.Items.Add(cboColumn.SelectedItem & " = " & cboVal.Text)
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Dim userCol() As String = {"FirstName", "LastName", "Gender", "Birthday"}
        Dim seatCol() As String = {"SeatNo"}
        Dim flightCol() As String = {"Airline", "Status"}
        Select Case cboType.SelectedItem
            Case "User"
                For Each col As String In userCol
                    cboColumn.Items.Add(col)
                Next
            Case "Seat"
                For Each col As String In seatCol
                    cboColumn.Items.Add(col)
                Next
            Case "Flight"
                For Each col As String In flightCol
                    cboColumn.Items.Add(col)
                Next
            Case Else
                MessageBox.Show("Please specify what to search for")
        End Select
    End Sub
End Class
'