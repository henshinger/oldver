Module Var
    Public MaxRows As Integer
    Imports System.Data.OleDb
    Public Class Form1
        Dim connetionString As String
        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim oledbCmdBuilder As OleDbCommandBuilder
        Dim ds As New DataSet
        Dim changes As DataSet
        Dim i As Integer
        Dim sql As String

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Your mdb filename;"
            connection = New OleDbConnection(connetionString)
            Sql = "select * from tblUsers"
            Try
                connection.Open()
                oledbAdapter = New OleDbDataAdapter(Sql, connection)
                oledbAdapter.Fill(ds)
                DataGridView1.Data(Source = ds.Tables(0))
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Try
                oledbCmdBuilder = New OleDbCommandBuilder(oledbAdapter)
                changes = ds.GetChanges()
                If changes IsNot Nothing Then
                    oledbAdapter.Update(ds.Tables(0))
                End If
                ds.AcceptChanges()
                MsgBox("Save changes")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class
End Module
