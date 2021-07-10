Public Class Thhuthu
    Private Sub Thhuthu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)
        'TODO: This line of code loads data into the 'DatabaseDataSet.XU_LY_VI_PHAM' table. You can move, or remove it, as needed.
        Me.XU_LY_VI_PHAMTableAdapter.Fill(Me.DatabaseDataSet.XU_LY_VI_PHAM)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)

    End Sub
    '==========================================================================================='
    'Command_Thông tin sách'
    'Thêm dòng'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        THONGTINSACHBindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        THONGTINSACHBindingSource.EndEdit()
        THONG_TIN_SACHTableAdapter.Update(DatabaseDataSet.THONG_TIN_SACH)
        MessageBox.Show("Thành công!", "Thông tin sách", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    'Xoá'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        THONGTINSACHBindingSource.RemoveCurrent()

    End Sub
    'Trước'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        THONGTINSACHBindingSource.MovePrevious()

    End Sub
    'Tiếp'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        THONGTINSACHBindingSource.MoveNext()

    End Sub
    'Đầu'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        THONGTINSACHBindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        THONGTINSACHBindingSource.MoveLast()

    End Sub
    'Tìm kiếm'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cnt0 = THONGTINSACHBindingSource.Count
            Me.THONG_TIN_SACHTableAdapter.Search(Me.DatabaseDataSet.THONG_TIN_SACH, TextBox6.Text)
            If cnt0 = 0 Then
                MessageBox.Show("Không tìm thấy sách " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt0 = 1 Then
                MessageBox.Show("Tìm thấy sách " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy sách " & TextBox6.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '=============================================================================================='
    'Command_Mượn trả'
    'Thêm dòng'
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        MUONTRABindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MUONTRABindingSource.EndEdit()
        MUON_TRATableAdapter.Update(DatabaseDataSet.MUON_TRA)
        MessageBox.Show("Thành công!", "Mượn trả", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    'Xoá'
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        MUONTRABindingSource.RemoveCurrent()

    End Sub
    'Đầu'
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        MUONTRABindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MUONTRABindingSource.MoveLast()

    End Sub
    'Trước'
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        MUONTRABindingSource.MovePrevious()

    End Sub
    'Tiếp'
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        MUONTRABindingSource.MoveNext()

    End Sub
    'Tìm kiếm'
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim cnt1 = MUONTRABindingSource.Count
            Me.MUON_TRATableAdapter.Search2(Me.DatabaseDataSet.MUON_TRA, TextBox14.Text)
            If cnt1 = 0 Then
                MessageBox.Show("Không tìm thấy mã độc giả " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt1 = 1 Then
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '=========================================================================================='
    'Vi phạm'
    'Thêm dòng'
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        XU_LY_VI_PHAMBindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        XU_LY_VI_PHAMBindingSource.EndEdit()
        XU_LY_VI_PHAMTableAdapter.Update(DatabaseDataSet.XU_LY_VI_PHAM)
        MessageBox.Show("Thành công!", "Vi phạm", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        XU_LY_VI_PHAMBindingSource.RemoveCurrent()

    End Sub
    'Đầu'
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        XU_LY_VI_PHAMBindingSource.MoveFirst()

    End Sub
    'Tìm kiếm'
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Try
            Dim cnt2 = XU_LY_VI_PHAMBindingSource.Count
            Me.XU_LY_VI_PHAMTableAdapter.Search5(Me.DatabaseDataSet.XU_LY_VI_PHAM, TextBox18.Text)
            If cnt2 = 0 Then
                MessageBox.Show("Không tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt2 = 1 Then
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Cuối'
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        XU_LY_VI_PHAMBindingSource.MoveLast()

    End Sub
    'Trước'
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        XU_LY_VI_PHAMBindingSource.MovePrevious()

    End Sub
    'Tiếp'
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        XU_LY_VI_PHAMBindingSource.MoveNext()

    End Sub
    '============================================================================================='
    'Nút thoát'
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim log = Login
            Login.Close()
        End If
    End Sub
    'Nút đăng xuất'
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim log = Login
            Login.Show()
        End If
    End Sub
    'Thay đổi mật khẩu'
    Private Sub ThayĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiMậtKhẩuToolStripMenuItem.Click
        Dim changepass = ChangePassword_Thuthu
        changepass.Show()
    End Sub
    'Edit -> Copy'
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
        TextBox2.Copy()
        TextBox3.Copy()
        TextBox4.Copy()
        TextBox5.Copy()
        TextBox6.Copy()
        TextBox7.Copy()
        TextBox8.Copy()
        TextBox9.Copy()
        TextBox10.Copy()
        TextBox11.Copy()
        TextBox11.Copy()
        TextBox12.Copy()
        TextBox13.Copy()
        TextBox14.Copy()
        TextBox15.Copy()
        TextBox16.Copy()
        TextBox17.Copy()
        TextBox18.Copy()
        TextBox19.Copy()

    End Sub
    'Edit -> Paste'
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
        TextBox2.Paste()
        TextBox3.Paste()
        TextBox4.Paste()
        TextBox5.Paste()
        TextBox6.Paste()
        TextBox7.Paste()
        TextBox8.Paste()
        TextBox9.Paste()
        TextBox10.Paste()
        TextBox11.Paste()
        TextBox11.Paste()
        TextBox12.Paste()
        TextBox13.Paste()
        TextBox14.Paste()
        TextBox15.Paste()
        TextBox16.Paste()
        TextBox17.Paste()
        TextBox18.Paste()
        TextBox19.Paste()

    End Sub
    'Edit -> Cut'
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
        TextBox2.Cut()
        TextBox3.Cut()
        TextBox4.Cut()
        TextBox5.Cut()
        TextBox6.Cut()
        TextBox7.Cut()
        TextBox8.Cut()
        TextBox9.Cut()
        TextBox10.Cut()
        TextBox11.Cut()
        TextBox11.Cut()
        TextBox12.Cut()
        TextBox13.Cut()
        TextBox14.Cut()
        TextBox15.Cut()
        TextBox16.Cut()
        TextBox17.Cut()
        TextBox18.Cut()
        TextBox19.Cut()

    End Sub
    'Edit -> Undo'
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
        TextBox2.Undo()
        TextBox3.Undo()
        TextBox4.Undo()
        TextBox5.Undo()
        TextBox6.Undo()
        TextBox7.Undo()
        TextBox8.Undo()
        TextBox9.Undo()
        TextBox10.Undo()
        TextBox11.Undo()
        TextBox11.Undo()
        TextBox12.Undo()
        TextBox13.Undo()
        TextBox14.Undo()
        TextBox15.Undo()
        TextBox16.Undo()
        TextBox17.Undo()
        TextBox18.Undo()
        TextBox19.Undo()

    End Sub
    'About'
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    '=========================================================================================='

End Class
