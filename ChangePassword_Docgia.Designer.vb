﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword_Docgia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.USERTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewPasswordText = New System.Windows.Forms.TextBox()
        Me.OldPasswordText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'USERTextBox
        '
        Me.USERTextBox.Location = New System.Drawing.Point(114, 24)
        Me.USERTextBox.Name = "USERTextBox"
        Me.USERTextBox.Size = New System.Drawing.Size(202, 20)
        Me.USERTextBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tài khoản"
        '
        'ConfirmPasswordText
        '
        Me.ConfirmPasswordText.Location = New System.Drawing.Point(114, 109)
        Me.ConfirmPasswordText.Name = "ConfirmPasswordText"
        Me.ConfirmPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.ConfirmPasswordText.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mật khẩu mới"
        '
        'NewPasswordText
        '
        Me.NewPasswordText.Location = New System.Drawing.Point(114, 83)
        Me.NewPasswordText.Name = "NewPasswordText"
        Me.NewPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.NewPasswordText.TabIndex = 25
        '
        'OldPasswordText
        '
        Me.OldPasswordText.Location = New System.Drawing.Point(114, 57)
        Me.OldPasswordText.Name = "OldPasswordText"
        Me.OldPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.OldPasswordText.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Mật khẩu cũ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Mật khẩu mới"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(222, 154)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 21
        Me.Cancel.Text = "&Huỷ"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(50, 154)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 20
        Me.OK.Text = "&Cập nhật"
        '
        'ChangePassword_Docgia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.USERTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConfirmPasswordText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NewPasswordText)
        Me.Controls.Add(Me.OldPasswordText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ChangePassword_Docgia"
        Me.Text = "Thay đổi mật khẩu độc giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents USERTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ConfirmPasswordText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NewPasswordText As TextBox
    Friend WithEvents OldPasswordText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
End Class
