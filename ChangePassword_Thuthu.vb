Imports System.Data.OleDb

Public Class ChangePassword_Thuthu

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thay đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim con As OleDbConnection = New OleDbConnection()
        Dim cmd As OleDbCommand
        Dim sql = "SELECT TAIKHOAN, MATKHAU FROM THU_THU WHERE TAIKHOAN='" & USERTextBox.Text & "' AND MATKHAU='" & OldPasswordText.Text & "'"
        cmd = New OleDbCommand(sql, con)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb")
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader


        Try
            If dr.Read = False Then
                MessageBox.Show("Sai mật khẩu", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.OldPasswordText.PasswordChar = ""
                Me.NewPasswordText.PasswordChar = ""
                Me.ConfirmPasswordText.PasswordChar = ""
            ElseIf NewPasswordText.Text <> ConfirmPasswordText.Text Then
                MessageBox.Show("Mật khẩu không khớp", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.OldPasswordText.PasswordChar = ""
                Me.NewPasswordText.PasswordChar = ""
                Me.ConfirmPasswordText.PasswordChar = ""
            Else
                'Đổi mật khẩu tài khoản thủ thư'
                Dim cmdText = "UPDATE DOC_GIA SET MATKHAU = @pwd " & "WHERE TAIKHOAN = @uname AND TAIKHOAN = @oldpwd"
                dr.Close()
                Dim cmdUpdate As OleDbCommand
                cmdUpdate = New OleDbCommand(cmdText, con)
                cmdUpdate.Parameters.AddWithValue("@pwd", NewPasswordText.Text)
                cmdUpdate.Parameters.AddWithValue("@uname", USERTextBox.Text)
                cmdUpdate.Parameters.AddWithValue("@pwd", OldPasswordText.Text)
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Đổi mật khẩu thành công. Vui lòng đăng nhập lại!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.OldPasswordText.PasswordChar = ""
                Me.NewPasswordText.PasswordChar = ""
                Me.ConfirmPasswordText.PasswordChar = ""
                Me.Close()
                Application.ExitThread()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class
