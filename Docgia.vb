Public Class Docgia
    Private Sub THONG_TIN_SACHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.THONG_TIN_SACHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Docgia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)

    End Sub
    'Tìm kiếm'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cnt0 = THONG_TIN_SACHBindingSource.Count
            Me.THONG_TIN_SACHTableAdapter.Search(Me.DatabaseDataSet.THONG_TIN_SACH, TextBox1.Text)
            If cnt0 = 0 Then
                MessageBox.Show("Không tìm thấy sách " & TextBox1.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt0 = 1 Then
                MessageBox.Show("Tìm thấy sách " & TextBox1.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy sách " & TextBox1.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Đăng xuất'
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim log = Login
            Login.Show()
        End If
    End Sub
    'Thoát'
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.ExitThread()

        End If
    End Sub
    'Thay đổi mật khẩu'
    Private Sub ThayĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiMậtKhẩuToolStripMenuItem.Click
        Dim changepass = ChangePassword_Docgia
        ChangePassword_Docgia.Show()
    End Sub
    'Edit -> Copy'
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()

    End Sub
    'Paste'
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()

    End Sub
    'Cut'
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()

    End Sub
    'Undo'
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
End Class