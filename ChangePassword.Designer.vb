<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OldPasswordText = New System.Windows.Forms.TextBox()
        Me.NewPasswordText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ConfirmPasswordText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountLogin1DataSet = New QUANLYTHUVIEN.AccountLogin1DataSet()
        Me.AccountTableAdapter = New QUANLYTHUVIEN.AccountLogin1DataSetTableAdapters.AccountTableAdapter()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountLogin1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mật khẩu mới"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu cũ"
        '
        'OldPasswordText
        '
        Me.OldPasswordText.Location = New System.Drawing.Point(105, 47)
        Me.OldPasswordText.Name = "OldPasswordText"
        Me.OldPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.OldPasswordText.TabIndex = 2
        '
        'NewPasswordText
        '
        Me.NewPasswordText.Location = New System.Drawing.Point(105, 73)
        Me.NewPasswordText.Name = "NewPasswordText"
        Me.NewPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.NewPasswordText.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Cập nhật"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Huỷ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ConfirmPasswordText
        '
        Me.ConfirmPasswordText.Location = New System.Drawing.Point(105, 99)
        Me.ConfirmPasswordText.Name = "ConfirmPasswordText"
        Me.ConfirmPasswordText.Size = New System.Drawing.Size(202, 20)
        Me.ConfirmPasswordText.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mật khẩu mới"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tài khoản"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountBindingSource, "USERNAME", True))
        Me.Label5.Location = New System.Drawing.Point(107, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Text"
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataMember = "Account"
        Me.AccountBindingSource.DataSource = Me.AccountLogin1DataSet
        '
        'AccountLogin1DataSet
        '
        Me.AccountLogin1DataSet.DataSetName = "AccountLogin1DataSet"
        Me.AccountLogin1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountTableAdapter
        '
        Me.AccountTableAdapter.ClearBeforeFill = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConfirmPasswordText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NewPasswordText)
        Me.Controls.Add(Me.OldPasswordText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChangePassword"
        Me.Text = "Thay đổi mật khẩu"
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountLogin1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OldPasswordText As TextBox
    Friend WithEvents NewPasswordText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ConfirmPasswordText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AccountLogin1DataSet As AccountLogin1DataSet
    Friend WithEvents AccountBindingSource As BindingSource
    Friend WithEvents AccountTableAdapter As AccountLogin1DataSetTableAdapters.AccountTableAdapter
End Class
