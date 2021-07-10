Imports System.Data.OleDb

Public Class ChangePassword
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thay đổi mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection = New OleDbConnection()
        Dim cmd As OleDbCommand
        Dim sql = "SELECT USERNAME, PASSCODE FROM Account WHERE USERNAME='" & Label5.Text & "' AND PASSCODE='" & OldPasswordText.Text & "'"
        cmd = New OleDbCommand(sql, con)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\AccountLogin1.accdb")
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
                'Đổi mật khẩu tài khoản quản trị'
                Dim cmdText = "UPDATE Account SET PASSCODE = @pwd " & "WHERE USERNAME = @uname AND PASSCODE = @oldpwd"
                dr.Close()
                Dim cmdUpdate As OleDbCommand
                cmdUpdate = New OleDbCommand(cmdText, con)
                cmdUpdate.Parameters.AddWithValue("@pwd", NewPasswordText.Text)
                cmdUpdate.Parameters.AddWithValue("@uname", Label5.Text)
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

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccountLogin1DataSet.Account' table. You can move, or remove it, as needed.
        Me.AccountTableAdapter.Fill(Me.AccountLogin1DataSet.Account)

    End Sub


End Class