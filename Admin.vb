Imports System.IO
Public Class Admin


    Private Sub QLTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.XU_LY_VI_PHAM' table. You can move, or remove it, as needed.
        Me.XU_LY_VI_PHAMTableAdapter.Fill(Me.DatabaseDataSet.XU_LY_VI_PHAM)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THU_THU' table. You can move, or remove it, as needed.
        Me.THU_THUTableAdapter.Fill(Me.DatabaseDataSet.THU_THU)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.DOC_GIA' table. You can move, or remove it, as needed.
        Me.DOC_GIATableAdapter.Fill(Me.DatabaseDataSet.DOC_GIA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THU_THU' table. You can move, or remove it, as needed.
        Me.THU_THUTableAdapter.Fill(Me.DatabaseDataSet.THU_THU)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THU_THU' table. You can move, or remove it, as needed.
        Me.THU_THUTableAdapter.Fill(Me.DatabaseDataSet.THU_THU)
        'TODO: This line of code loads data into the 'DatabaseDataSet.DOC_GIA' table. You can move, or remove it, as needed.
        Me.DOC_GIATableAdapter.Fill(Me.DatabaseDataSet.DOC_GIA)
        'TODO: This line of code loads data into the 'DatabaseDataSet2.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet2.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet2.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet2.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet2.DOC_GIA' table. You can move, or remove it, as needed.
        Me.DOC_GIATableAdapter.Fill(Me.DatabaseDataSet2.DOC_GIA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.MUON_TRA' table. You can move, or remove it, as needed.
        Me.MUON_TRATableAdapter.Fill(Me.DatabaseDataSet.MUON_TRA)
        'TODO: This line of code loads data into the 'DatabaseDataSet1.DOC_GIA' table. You can move, or remove it, as needed.
        Me.DOC_GIATableAdapter.Fill(Me.DatabaseDataSet1.DOC_GIA)
        'TODO: This line of code loads data into the 'DatabaseDataSet.THONG_TIN_SACH' table. You can move, or remove it, as needed.
        Me.THONG_TIN_SACHTableAdapter.Fill(Me.DatabaseDataSet.THONG_TIN_SACH)


    End Sub

    '=============================================================================================================================='
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

    '=============================================================================================================================='
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
        TextBox12.Copy()
        TextBox13.Copy()
        TextBox14.Copy()
        TextBox15.Copy()
        TextBox16.Copy()
        TextBox17.Copy()
        TextBox18.Copy()
        TextBox22.Copy()
        MADGTextBox.Copy()
        MADGTextBox1.Copy()
        MADGTextBox2.Copy()
        HOTENTextBox.Copy()
        HOTENTextBox1.Copy()
        MASACHTextBox.Copy()
        TENSACHTextBox.Copy()
        SLTextBox.Copy()
        MATHUTHUTextBox.Copy()
        NAMETextBox.Copy()
        USERTextBox.Copy()
        PASSWORDTextBox.Copy()
        LYDOVPTextBox.Copy()
        HTXLTextBox.Copy()
        NXLTextBox.Copy()

    End Sub

    '=============================================================================================================================='
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
        TextBox12.Paste()
        TextBox13.Paste()
        TextBox14.Paste()
        TextBox15.Paste()
        TextBox16.Paste()
        TextBox17.Paste()
        TextBox18.Paste()
        TextBox22.Paste()
        MADGTextBox.Paste()
        MADGTextBox1.Paste()
        MADGTextBox2.Paste()
        HOTENTextBox.Paste()
        HOTENTextBox1.Paste()
        MASACHTextBox.Paste()
        TENSACHTextBox.Paste()
        SLTextBox.Paste()
        MATHUTHUTextBox.Paste()
        NAMETextBox.Paste()
        USERTextBox.Paste()
        PASSWORDTextBox.Paste()
        LYDOVPTextBox.Paste()
        HTXLTextBox.Paste()
        NXLTextBox.Paste()

    End Sub

    '=============================================================================================================================='
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
        TextBox12.Cut()
        TextBox13.Cut()
        TextBox14.Cut()
        TextBox15.Cut()
        TextBox16.Cut()
        TextBox17.Cut()
        TextBox18.Cut()
        TextBox22.Cut()
        MADGTextBox.Cut()
        MADGTextBox1.Cut()
        MADGTextBox2.Cut()
        HOTENTextBox.Cut()
        HOTENTextBox1.Cut()
        MASACHTextBox.Cut()
        TENSACHTextBox.Cut()
        SLTextBox.Cut()
        MATHUTHUTextBox.Cut()
        NAMETextBox.Cut()
        USERTextBox.Cut()
        PASSWORDTextBox.Cut()
        LYDOVPTextBox.Cut()
        HTXLTextBox.Cut()
        NXLTextBox.Cut()

    End Sub

    '=============================================================================================================================='
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
        TextBox12.Undo()
        TextBox13.Undo()
        TextBox14.Undo()
        TextBox15.Undo()
        TextBox16.Undo()
        TextBox17.Undo()
        TextBox18.Undo()
        TextBox22.Undo()
        MADGTextBox.Undo()
        MADGTextBox1.Undo()
        MADGTextBox2.Undo()
        HOTENTextBox.Undo()
        HOTENTextBox1.Undo()
        MASACHTextBox.Undo()
        TENSACHTextBox.Undo()
        SLTextBox.Undo()
        MATHUTHUTextBox.Undo()
        NAMETextBox.Undo()
        USERTextBox.Undo()
        PASSWORDTextBox.Undo()
        LYDOVPTextBox.Undo()
        HTXLTextBox.Undo()
        NXLTextBox.Undo()


    End Sub

    '=============================================================================================================================='
    'Command_Quản lý độc giả'
    'Tìm kiếm'
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Dim cnt1 = DOCGIABindingSource.Count
            Me.DOC_GIATableAdapter.Search1(Me.DatabaseDataSet.DOC_GIA, TextBox12.Text)
            If cnt1 = 0 Then
                MessageBox.Show("Không tìm thấy độc giả " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt1 = 1 Then
                MessageBox.Show("Tìm thấy độc giả " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy độc giả " & TextBox12.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Thêm dòng'
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        DOCGIABindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        DOCGIABindingSource.EndEdit()
        DOC_GIATableAdapter.Update(DatabaseDataSet.DOC_GIA)
        MessageBox.Show("Thành công!", "Thông tin độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        DOCGIABindingSource.RemoveCurrent()
    End Sub
    'Trước'
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        DOCGIABindingSource.MovePrevious()
    End Sub
    'Tiếp'
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        DOCGIABindingSource.MoveNext()
    End Sub
    'Đầu'
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DOCGIABindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DOCGIABindingSource.MoveLast()
    End Sub

    '=============================================================================================================================='
    'Command_Quản lý mượn trả'
    'Thêm dòng'
    Private Sub Button24_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button23_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.EndEdit()
        MUON_TRATableAdapter.Update(DatabaseDataSet.MUON_TRA)
        MessageBox.Show("Thành công!", "Mượn trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Tìm kiếm'
    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Try
            Dim cnt2 = MUONTRABindingSource.Count
            Me.MUON_TRATableAdapter.Search2(Me.DatabaseDataSet2.MUON_TRA, TextBox13.Text)
            If cnt2 = 0 Then
                MessageBox.Show("Không tìm thấy độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt2 = 1 Then
                MessageBox.Show("Tìm thấy độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Không tìm thấy độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Xoá'
    Private Sub Button21_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.RemoveCurrent()
    End Sub
    'Trước'
    Private Sub Button20_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.MovePrevious()
    End Sub
    'Tiếp'
    Private Sub Button19_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.MoveNext()
    End Sub
    'Đầu'
    Private Sub Button18_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button17_Click(sender As Object, e As EventArgs)
        MUONTRABindingSource.MoveLast()
    End Sub

    '=============================================================================================================================='
    'Command_Thủ thư'
    'Thêm dòng'
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        THUTHUBindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        THUTHUBindingSource.EndEdit()
        THU_THUTableAdapter.Update(DatabaseDataSet.THU_THU)
        MessageBox.Show("Thành công!", "Quản lý tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Tìm kiếm'
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Dim cnt3 = THUTHUBindingSource.Count
            Me.THU_THUTableAdapter.Search3(Me.DatabaseDataSet.THU_THU, TextBox14.Text)
            If cnt3 = 0 Then
                MessageBox.Show("Không tìm thấy mã thủ thư " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt3 = 1 Then
                MessageBox.Show("Tìm thấy mã thủ thư " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã thủ thư " & TextBox14.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Xoá'
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        THUTHUBindingSource.RemoveCurrent()
    End Sub
    'Trước'
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        THUTHUBindingSource.MovePrevious()
    End Sub
    'Tiếp'
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        THUTHUBindingSource.MoveNext()
    End Sub
    'Đầu'
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        THUTHUBindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        THUTHUBindingSource.MoveLast()
    End Sub

    '=============================================================================================================================='
    'Command_tài khoản độc giả'
    'Thêm dòng'
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        DOCGIABindingSource.AddNew()
    End Sub
    'Lưu'
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        DOCGIABindingSource.EndEdit()
        DOC_GIATableAdapter.Update(DatabaseDataSet.DOC_GIA)
        MessageBox.Show("Thành công!", "Quản lý tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Tìm kiếm'
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            Dim cnt4 = DOCGIABindingSource.Count
            Me.DOC_GIATableAdapter.Search4(Me.DatabaseDataSet.DOC_GIA, TextBox22.Text)
            If cnt4 = 0 Then
                MessageBox.Show("Không tìm thấy mã độc giả " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt4 = 1 Then
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox22.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Xoá'
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        DOCGIABindingSource.RemoveCurrent()
    End Sub
    'Đầu'
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        DOCGIABindingSource.MoveFirst()
    End Sub
    'Cuối'
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        DOCGIABindingSource.MoveLast()
    End Sub
    'Tiếp'
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        DOCGIABindingSource.MoveNext()
    End Sub
    'Trước'
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        DOCGIABindingSource.MovePrevious()
    End Sub
    '=============================================================================================================================='
    'Sao lưu '
    Private Sub SaoLưuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaoLưuToolStripMenuItem.Click
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog = vbOK Then
                File.Copy(Application.StartupPath & "\Database.accdb", fbd.SelectedPath & "\Backup-" & Format(Now(), "dd-M-yyyy H-m-s") & ".accdb")
                MessageBox.Show("Sao lưu thành công!", "Sao lưu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '=============================================================================================================================='
    'Phục hồi'
    Private Sub PhụcHồiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhụcHồiToolStripMenuItem.Click
        Try

            Dim restorefile As String = Application.StartupPath & "\Database.accdb"

            Dim msgText As String

            OpenFileDialog1.Filter = "Access | *.accdb"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                msgText = "Bạn chắc chắn muốn phục hồi CSDL? Chương trình sẽ ghi đè lên dữ liệu đang có."

                If MessageBox.Show(msgText, "Restore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                    FileCopy(OpenFileDialog1.FileName, restorefile)
                    MessageBox.Show("Phục hồi thành công!", "Phục hồi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '=============================================================================================================================='
    'Thay đổi mật khẩu'
    Private Sub ThayĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiMậtKhẩuToolStripMenuItem.Click
        Dim changepass = ChangePassword
        ChangePassword.Show()
    End Sub
    '=============================================================================================================================='
    'Đăng xuất'
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim log = Login
            Login.Show()
        End If

    End Sub
    '=============================================================================================================================='
    'Thoát chương trình'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
            Dim log = Login
            Login.Close()
        End If

    End Sub

    '================================================================================================================================'
    'Command_Mượn trả'
    'Thêm mới'
    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        MUONTRABindingSource.AddNew()

    End Sub
    'Lưu'
    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        MUONTRABindingSource.EndEdit()
        MUON_TRATableAdapter.Update(DatabaseDataSet.MUON_TRA)
        MessageBox.Show("Thành công!", "Mượn trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Xoá'
    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        MUONTRABindingSource.RemoveCurrent()

    End Sub
    'Trước'
    Private Sub Button23_Click_1(sender As Object, e As EventArgs) Handles Button23.Click
        MUONTRABindingSource.MovePrevious()

    End Sub
    'Tiếp'
    Private Sub Button24_Click_1(sender As Object, e As EventArgs) Handles Button24.Click
        MUONTRABindingSource.MoveNext()

    End Sub
    'Đầu'
    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        MUONTRABindingSource.MoveFirst()

    End Sub
    'Cuối'
    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        MUONTRABindingSource.MovePrevious()

    End Sub
    'Tìm kiếm'
    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim cnt5 = MUONTRABindingSource.Count
            Me.MUON_TRATableAdapter.Search2(Me.DatabaseDataSet1.MUON_TRA, TextBox13.Text)
            If cnt5 = 0 Then
                MessageBox.Show("Không tìm thấy mã độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt5 = 1 Then
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox13.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '=========================================================================================='
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
    'Tìm kiếm'
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Try
            Dim cnt6 = XU_LY_VI_PHAMBindingSource.Count
            Me.XU_LY_VI_PHAMTableAdapter.Search5(Me.DatabaseDataSet.XU_LY_VI_PHAM, TextBox18.Text)
            If cnt6 = 0 Then
                MessageBox.Show("Không tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cnt6 = 1 Then
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tìm thấy mã độc giả " & TextBox18.Text, "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub


    '==========================================================================================='

End Class
