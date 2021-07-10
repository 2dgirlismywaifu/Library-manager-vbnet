Public Class Form1
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim info = About
        About.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        THONGTINSACHBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        THONGTINSACHBindingSource.EndEdit()
        THONG_TIN_SACHTableAdapter.Update(DatabaseDataSet.THONG_TIN_SACH)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class