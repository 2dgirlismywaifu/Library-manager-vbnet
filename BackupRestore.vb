Imports System.Data.OleDb

Public Class BackupRestore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.FileName = TextBox1.Text
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb")
        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        cmd.



    End Sub
End Class