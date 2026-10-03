<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userprofile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        txtCurrentPassword = New TextBox()
        lblNewPassword = New Label()
        txtNewPassword = New TextBox()
        lblConfirmPassword = New Label()
        btnChangePassword = New Button()
        LabelTitle = New Label()
        GroupBoxSecurity = New GroupBox()
        lblCurrentPassword = New Label()
        txtConfirmPassword = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblPhone = New Label()
        lblYearSection = New Label()
        btnSaveUpdates = New Button()
        lblCourse = New Label()
        txtPhone = New TextBox()
        PictureBoxAvatar = New PictureBox()
        lblStudentID = New Label()
        lblFullName = New Label()
        PanelProfile = New Panel()
        GroupBoxContact = New GroupBox()
        GroupBoxSecurity.SuspendLayout()
        CType(PictureBoxAvatar, ComponentModel.ISupportInitialize).BeginInit()
        PanelProfile.SuspendLayout()
        GroupBoxContact.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Location = New Point(140, 24)
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.Size = New Size(300, 23)
        txtCurrentPassword.TabIndex = 1
        txtCurrentPassword.UseSystemPasswordChar = True
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Location = New Point(16, 64)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(87, 15)
        lblNewPassword.TabIndex = 2
        lblNewPassword.Text = "New Password:"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(140, 60)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(300, 23)
        txtNewPassword.TabIndex = 3
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Location = New Point(16, 100)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(107, 15)
        lblConfirmPassword.TabIndex = 4
        lblConfirmPassword.Text = "Confirm Password:"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Location = New Point(140, 124)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(140, 28)
        btnChangePassword.TabIndex = 6
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelTitle.Location = New Point(234, 135)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(131, 25)
        LabelTitle.TabIndex = 9
        LabelTitle.Text = "👤 My Profile"
        ' 
        ' GroupBoxSecurity
        ' 
        GroupBoxSecurity.Controls.Add(lblCurrentPassword)
        GroupBoxSecurity.Controls.Add(txtCurrentPassword)
        GroupBoxSecurity.Controls.Add(lblNewPassword)
        GroupBoxSecurity.Controls.Add(txtNewPassword)
        GroupBoxSecurity.Controls.Add(lblConfirmPassword)
        GroupBoxSecurity.Controls.Add(txtConfirmPassword)
        GroupBoxSecurity.Controls.Add(btnChangePassword)
        GroupBoxSecurity.Location = New Point(552, 333)
        GroupBoxSecurity.Name = "GroupBoxSecurity"
        GroupBoxSecurity.Size = New Size(458, 160)
        GroupBoxSecurity.TabIndex = 12
        GroupBoxSecurity.TabStop = False
        GroupBoxSecurity.Text = "Security"
        ' 
        ' lblCurrentPassword
        ' 
        lblCurrentPassword.AutoSize = True
        lblCurrentPassword.Location = New Point(16, 28)
        lblCurrentPassword.Name = "lblCurrentPassword"
        lblCurrentPassword.Size = New Size(103, 15)
        lblCurrentPassword.TabIndex = 0
        lblCurrentPassword.Text = "Current Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(140, 96)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(300, 23)
        txtConfirmPassword.TabIndex = 5
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(16, 28)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(39, 15)
        lblEmail.TabIndex = 0
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 24)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(320, 23)
        txtEmail.TabIndex = 1
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(16, 64)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(44, 15)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblYearSection
        ' 
        lblYearSection.AutoSize = True
        lblYearSection.Location = New Point(128, 110)
        lblYearSection.Name = "lblYearSection"
        lblYearSection.Size = New Size(77, 15)
        lblYearSection.TabIndex = 6
        lblYearSection.Text = "Year & Section:"
        ' 
        ' btnSaveUpdates
        ' 
        btnSaveUpdates.Location = New Point(120, 100)
        btnSaveUpdates.Name = "btnSaveUpdates"
        btnSaveUpdates.Size = New Size(120, 30)
        btnSaveUpdates.TabIndex = 4
        btnSaveUpdates.Text = "Save Updates"
        btnSaveUpdates.UseVisualStyleBackColor = True
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(128, 80)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(47, 15)
        lblCourse.TabIndex = 5
        lblCourse.Text = "Course:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(120, 60)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 23)
        txtPhone.TabIndex = 3
        ' 
        ' PictureBoxAvatar
        ' 
        PictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle
        PictureBoxAvatar.Location = New Point(16, 16)
        PictureBoxAvatar.Name = "PictureBoxAvatar"
        PictureBoxAvatar.Size = New Size(96, 96)
        PictureBoxAvatar.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxAvatar.TabIndex = 2
        PictureBoxAvatar.TabStop = False
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(128, 20)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(65, 15)
        lblStudentID.TabIndex = 3
        lblStudentID.Text = "Student ID:"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(128, 50)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(64, 15)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full Name:"
        ' 
        ' PanelProfile
        ' 
        PanelProfile.BorderStyle = BorderStyle.FixedSingle
        PanelProfile.Controls.Add(PictureBoxAvatar)
        PanelProfile.Controls.Add(lblStudentID)
        PanelProfile.Controls.Add(lblFullName)
        PanelProfile.Controls.Add(lblCourse)
        PanelProfile.Controls.Add(lblYearSection)
        PanelProfile.Location = New Point(234, 171)
        PanelProfile.Name = "PanelProfile"
        PanelProfile.Size = New Size(300, 220)
        PanelProfile.TabIndex = 10
        ' 
        ' GroupBoxContact
        ' 
        GroupBoxContact.Controls.Add(lblEmail)
        GroupBoxContact.Controls.Add(txtEmail)
        GroupBoxContact.Controls.Add(lblPhone)
        GroupBoxContact.Controls.Add(txtPhone)
        GroupBoxContact.Controls.Add(btnSaveUpdates)
        GroupBoxContact.Location = New Point(552, 171)
        GroupBoxContact.Name = "GroupBoxContact"
        GroupBoxContact.Size = New Size(458, 150)
        GroupBoxContact.TabIndex = 11
        GroupBoxContact.TabStop = False
        GroupBoxContact.Text = "Update Contact"
        ' 
        ' userprofile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LabelTitle)
        Controls.Add(GroupBoxSecurity)
        Controls.Add(PanelProfile)
        Controls.Add(GroupBoxContact)
        Name = "userprofile"
        Size = New Size(1245, 629)
        GroupBoxSecurity.ResumeLayout(False)
        GroupBoxSecurity.PerformLayout()
        CType(PictureBoxAvatar, ComponentModel.ISupportInitialize).EndInit()
        PanelProfile.ResumeLayout(False)
        PanelProfile.PerformLayout()
        GroupBoxContact.ResumeLayout(False)
        GroupBoxContact.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents LabelTitle As Label
    Friend WithEvents GroupBoxSecurity As GroupBox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblYearSection As Label
    Friend WithEvents btnSaveUpdates As Button
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents PictureBoxAvatar As PictureBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents PanelProfile As Panel
    Friend WithEvents GroupBoxContact As GroupBox

End Class
