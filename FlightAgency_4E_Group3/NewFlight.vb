Public Class frmNewFlight
    Dim con As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim cb As New OleDb.OleDbCommandBuilder(da)
    Dim dr As DataRow
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dr As DataRow

        dr = ds.Tables("AirlineData").NewRow
        dr.Item("Airline") = cboNam.SelectedItem
        dr.Item("Date") = dtpDat.Value
        dr.Item("Time") = cboTim.SelectedItem
        dr.Item("Status") = cboSta.SelectedItem
        dr.Item("FlightNo") = cboFli.SelectedItem
        dr.Item("DestinationTo") = cboTo.SelectedItem
        dr.Item("DestinationFrom") = cboFro.SelectedItem
        ds.Tables("AirlineData").Rows.Add(dr)

        ds.Tables("AirlineData").Rows.Add(dr)
        da.Update(ds, "AirlineData")

        MsgBox("Record save!!!")
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub frmNewFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OleDB.4.0;Data Source=C:\Database\AirlineData.mdb"
        con.Open()
        MsgBox("Database is now open...")
        sql = "Select * From FlightTable"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AirlineData")
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmHome.Show()
    End Sub

End Class