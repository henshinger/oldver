Imports System.Data.OleDb
Imports System.Data
Public Class frmNewTransaction
    Dim con As New OleDb.OleDbConnection
    Dim userDA, transactionDA, seatDA, flightDA As OleDb.OleDbDataAdapter
    Dim userDS, transactionDS, seatDS, flightDS As New DataSet
    Dim userSQL, transactionSQL, seatSQL, flightSQL As String
    Dim cmd As New OleDbCommand
    Dim dtr As OleDbDataReader
    Dim blnAutofilled As Boolean
    Dim intUserID, intFlightID As Integer
    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub btnSav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Dim userCB As New OleDb.OleDbCommandBuilder(userDA)
        Dim transactionCB As New OleDb.OleDbCommandBuilder(transactionDA)
        Dim seatCB As New OleDb.OleDbCommandBuilder(seatDA)
        Dim flightCB As New OleDb.OleDbCommandBuilder(flightDA)
        Dim userDR, transactionDR, seatDR, flightDR As DataRow
        'move to different form
        cmd.CommandText = "Select * From FlightTable WHERE Airline = " & cboNam.SelectedItem & "AND Date = to_date(" & dtpDat.Value & ", 'dd-mon-yyyy') AND Time = " & cboTim.SelectedItem & " AND Status = " & cboSta.SelectedItem & " AND FlightNO = " & cboFli.SelectedItem & " AND DestinationTo = " & cboTo.SelectedItem & "AND DestinationFrom = " & cboFro.SelectedItem
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        dtr = cmd.ExecuteReader()
        If dtr.HasRows Then
            intUserID = dtr.Item("FlightId")
        End If

        transactionDR = transactionDS.Tables("AirlineData").NewRow
        transactionDR.Item("Class") = cboCla.SelectedItem
        transactionDR.Item("Status") = cboSta.SelectedItem
        transactionDR.Item("FlightId") = intFlightID
        transactionDS.Tables("AirlineData").Rows.Add(transactionDR)
        transactionDA.Update(transactionDS, "AirlineData")

        If Not (blnAutofilled) Then
            userDR = userDS.Tables("AirlineData").NewRow
            userDR.Item("FirstName") = txtFir.Text
            userDR.Item("LastName") = txtLas.Text
            userDR.Item("Gender") = txtGen.Text
            userDR.Item("PassportNo") = txtPas.Text
            userDR.Item("Birthday") = dtpBir.Value
            userDR.Item("Nationality") = txtNat.Text
            userDR.Item("TransactionId") = transactionDR.Item("TransactionId")
            userDS.Tables("AirlineData").Rows.Add(userDR)
            userDA.Update(userDS, "AirlineData")
            intUserID = Val(txtPas.Text)
        End If

        For Each seatNo As String In lstSel.Items
            seatDR = seatDS.Tables("AirlineData").NewRow
            seatDR.Item("SeatNo") = seatNo
            seatDR.Item("Class") = cboCla.SelectedItem
            seatDR.Item("TransactionId") = transactionDR.Item("TransactionId")
            seatDS.Tables("AirlineData").Rows.Add(seatDR)
            seatDA.Update(seatDS, "AirlineData")
        Next

       
        


    End Sub

    Private Sub frmNewFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OleDB.4.0;Data Source=C:\Database\AirlineData.mdb"
        con.Open()
        userSQL = "Select * From UserTable"
        userDA = New OleDb.OleDbDataAdapter(userSQL, con)
        userDA.Fill(userDS, "AirlineData")
        transactionSQL = "Select * From TransactionTable"
        transactionDA = New OleDb.OleDbDataAdapter(transactionSQL, con)
        transactionDA.Fill(transactionDS, "AirlineData")
        seatSQL = "Select * From SeatTable"
        seatDA = New OleDb.OleDbDataAdapter(seatSQL, con)
        seatDA.Fill(seatDS, "AirlineData")
        flightSQL = "Select * From FlightTable"
        flightDA = New OleDb.OleDbDataAdapter(flightSQL, con)
        flightDA.Fill(flightDS, "AirlineData")


    End Sub

    Private Sub clistSea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstSel.Items.Clear()
        For i As Integer = 0 To clistSea.CheckedItems.Count - 1
            lstSel.Items.Add(clistSea.CheckedItems(i))
        Next
    End Sub

    Private Sub btnAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmd.CommandText = "Select * From UserTable WHERE PassportNo = " & Val(txtPas.Text)
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        dtr = cmd.ExecuteReader()
        If dtr.HasRows Then
            intUserID = dtr.Item("PassportNo")
            txtFir.Text = dtr.Item("FirstName")
            txtLas.Text = dtr.Item("LastName")
            txtGen.Text = dtr.Item("Gender")
            dtpDat.Value = dtr.Item("Birthday")
            txtNat.Text = dtr.Item("Nationality")
        End If
    End Sub

    Private Sub btnCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCle.Click
        cboNam.SelectedIndex = -1
        cboTim.SelectedIndex = -1
        cboSta.SelectedIndex = -1
        cboFli.SelectedIndex = -1
        cboTo.SelectedIndex = -1
        cboFro.SelectedIndex = -1
        cboCla.SelectedIndex = -1
        cboSta.SelectedIndex = -1
        txtFir.Text = ""
        txtLas.Text = ""
        txtGen.Text = ""
        txtPas.Text = ""
        dtpBir.Value = ""
        txtNat.Text = ""
        cboCla.SelectedIndex = -1
        For i As Integer = 0 To clistSea.Items.Count - 1
            clistSea.SetItemChecked(i, False)
        Next i
        clistSea.Items.Clear()
        lstSel.Items.Clear()
    End Sub
End Class
