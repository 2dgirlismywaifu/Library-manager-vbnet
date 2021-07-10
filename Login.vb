Imports System.Data.OleDb

Public Class Login
    'Đăng nhập'
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim con0 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\AccountLogin1.accdb")
        Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb")
        Dim con2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb")

        Dim cmd0 As OleDbCommand = New OleDbCommand("SELECT * FROM Account WHERE USERNAME='" & UsernameTextBox.Text & "' AND PASSCODE='" & PasswordTextBox.Text & "'", con0)
        Dim cmd1 As OleDbCommand = New OleDbCommand("SELECT TAIKHOAN, MATKHAU FROM THU_THU WHERE TAIKHOAN='" & UsernameTextBox.Text & "' AND MATKHAU='" & PasswordTextBox.Text & "'", con1)
        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT TAIKHOAN, MATKHAU FROM DOC_GIA WHERE TAIKHOAN='" & UsernameTextBox.Text & "' AND MATKHAU='" & PasswordTextBox.Text & "'", con2)

        Dim user As String = ""

        Dim pass As String = ""

        If (CmbUserType.SelectedIndex = 0) Then
            'Admin'
            con0.Open()

            Dim sdr0 As OleDbDataReader = cmd0.ExecuteReader()

            If (sdr0.Read() = True) Then

                user = sdr0("USERNAME")

                pass = sdr0("PASSCODE")

                MessageBox.Show("Bạn đã đăng nhập vào quản trị!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Dim qt = Admin
                qt.Show()

            Else

                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con0.Close()
            '======================================================================================================================'
        ElseIf (CmbUserType.SelectedIndex = 1) Then
            'Thủ thư'
            con1.Open()

            Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader()

            If (sdr1.Read() = True) Then

                user = sdr1("TAIKHOAN")

                pass = sdr1("MATKHAU")

                MessageBox.Show("Xin chào thủ thư " & UsernameTextBox.Text, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Dim t As New Thhuthu
                t.Show()

            Else

                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con1.Close()
            '======================================================================================================================'
        Else
            'Độc giả'
            con2.Open()

            Dim sdr2 As OleDbDataReader = cmd2.ExecuteReader()

            If (sdr2.Read() = True) Then

                user = sdr2("TAIKHOAN")

                pass = sdr2("MATKHAU")

                MessageBox.Show("Xin chào độc giả " & UsernameTextBox.Text, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Dim dg = Docgia
                dg.Show()

            Else

                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con2.Close()
        End If

    End Sub
    'Nút thoát'
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.ExitThread()
    End Sub

    'Quên mật khẩu'
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Liên hệ với quản trị viên để được cấp lại mật khẩu!", "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Nút Exit_thanh công cụ'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Application.ExitThread()

    End Sub
    'Về phần mềm'
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a = About
        About.Show()
    End Sub
    'Hiển thị mật khẩu'
    Private Sub ShowPasswordChecked_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordChecked.CheckedChanged
        If (Me.ShowPasswordChecked.Checked = True) Then
            Me.PasswordTextBox.PasswordChar = ""
        Else
            Me.PasswordTextBox.PasswordChar = "*"c
        End If
    End Sub
    'Liên quan đến hiển thị mật khẩu'
    Public Sub clearControls()
        If (Me.UsernameTextBox.CanSelect) Then
            Me.UsernameTextBox.Clear()
            Me.PasswordTextBox.Clear()
            Me.UsernameTextBox.Select()
        End If
        If (Me.ShowPasswordChecked.Checked = True) Then Me.ShowPasswordChecked.Checked = False
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub
End Class
