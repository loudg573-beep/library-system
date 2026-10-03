<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createaccount
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
        txtCAConfirm = New TextBox()
        lblCAConfirm = New Label()
        gbPersonal = New GroupBox()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        lblLastName = New Label()
        txtLastName = New TextBox()
        lblCourseDept = New Label()
        cmbCourseDept = New ComboBox()
        lblYearSection = New Label()
        txtYearSection = New TextBox()
        lblContact = New Label()
        txtContact = New TextBox()
        gbAccountType = New GroupBox()
        rdoStudent = New RadioButton()
        rdoTeacher = New RadioButton()
        createPanel = New Panel()
        PictureBox1 = New PictureBox()
        gbCredentials = New GroupBox()
        IDNUMBER = New Label()
        txtCAStudentID = New TextBox()
        lblCAUsername = New Label()
        txtCAUsername = New TextBox()
        lblCAPassword = New Label()
        txtCAPassword = New TextBox()
        btnCreateAccount = New Button()
        btnCancelCreate = New Button()
        linkLogin = New LinkLabel()
        loginPanel = New Panel()
        headerPanel = New Panel()
        headerLabel = New Label()
        iconUser = New PictureBox()
        txtUsername = New TextBox()
        iconKey = New PictureBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCreate = New Button()
        rightLogo = New PictureBox()
        panelLeft = New Panel()
        panelTop = New Panel()
        smallLogo = New PictureBox()
        titleLabel = New Label()
        gbPersonal.SuspendLayout()
        gbAccountType.SuspendLayout()
        createPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gbCredentials.SuspendLayout()
        loginPanel.SuspendLayout()
        headerPanel.SuspendLayout()
        CType(iconUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(iconKey, ComponentModel.ISupportInitialize).BeginInit()
        CType(rightLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelTop.SuspendLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCAConfirm
        ' 
        txtCAConfirm.Location = New Point(140, 104)
        txtCAConfirm.Name = "txtCAConfirm"
        txtCAConfirm.Size = New Size(340, 23)
        txtCAConfirm.TabIndex = 7
        txtCAConfirm.UseSystemPasswordChar = True
        ' 
        ' lblCAConfirm
        ' 
        lblCAConfirm.Location = New Point(12, 104)
        lblCAConfirm.Name = "lblCAConfirm"
        lblCAConfirm.Size = New Size(120, 20)
        lblCAConfirm.TabIndex = 6
        lblCAConfirm.Text = "Confirm Password"
        ' 
        ' gbPersonal
        ' 
        gbPersonal.Controls.Add(lblFirstName)
        gbPersonal.Controls.Add(txtFirstName)
        gbPersonal.Controls.Add(lblLastName)
        gbPersonal.Controls.Add(txtLastName)
        gbPersonal.Controls.Add(lblCourseDept)
        gbPersonal.Controls.Add(cmbCourseDept)
        gbPersonal.Controls.Add(lblYearSection)
        gbPersonal.Controls.Add(txtYearSection)
        gbPersonal.Controls.Add(lblContact)
        gbPersonal.Controls.Add(txtContact)
        gbPersonal.Controls.Add(gbAccountType)
        gbPersonal.Location = New Point(8, 153)
        gbPersonal.Name = "gbPersonal"
        gbPersonal.Size = New Size(510, 159)
        gbPersonal.TabIndex = 1
        gbPersonal.TabStop = False
        gbPersonal.Text = "Personal Information"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Location = New Point(12, 24)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(120, 20)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(140, 22)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(240, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' lblLastName
        ' 
        lblLastName.Location = New Point(12, 52)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(120, 20)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(140, 50)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(240, 23)
        txtLastName.TabIndex = 3
        ' 
        ' lblCourseDept
        ' 
        lblCourseDept.Location = New Point(12, 80)
        lblCourseDept.Name = "lblCourseDept"
        lblCourseDept.Size = New Size(120, 20)
        lblCourseDept.TabIndex = 4
        lblCourseDept.Text = "Course / Department"
        ' 
        ' cmbCourseDept
        ' 
        cmbCourseDept.Location = New Point(140, 78)
        cmbCourseDept.Name = "cmbCourseDept"
        cmbCourseDept.Size = New Size(180, 23)
        cmbCourseDept.TabIndex = 5
        ' 
        ' lblYearSection
        ' 
        lblYearSection.Location = New Point(12, 108)
        lblYearSection.Name = "lblYearSection"
        lblYearSection.Size = New Size(120, 20)
        lblYearSection.TabIndex = 6
        lblYearSection.Text = "Year / Section"
        ' 
        ' txtYearSection
        ' 
        txtYearSection.Location = New Point(140, 106)
        txtYearSection.Name = "txtYearSection"
        txtYearSection.Size = New Size(120, 23)
        txtYearSection.TabIndex = 7
        ' 
        ' lblContact
        ' 
        lblContact.Location = New Point(12, 136)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(120, 20)
        lblContact.TabIndex = 8
        lblContact.Text = "Contact / Phone No."
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(140, 134)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(180, 23)
        txtContact.TabIndex = 9
        ' 
        ' gbAccountType
        ' 
        gbAccountType.Controls.Add(rdoStudent)
        gbAccountType.Controls.Add(rdoTeacher)
        gbAccountType.Location = New Point(392, 20)
        gbAccountType.Name = "gbAccountType"
        gbAccountType.Size = New Size(106, 80)
        gbAccountType.TabIndex = 10
        gbAccountType.TabStop = False
        gbAccountType.Text = "Account Type"
        ' 
        ' rdoStudent
        ' 
        rdoStudent.Location = New Point(8, 20)
        rdoStudent.Name = "rdoStudent"
        rdoStudent.Size = New Size(104, 24)
        rdoStudent.TabIndex = 0
        rdoStudent.Text = "Student"
        ' 
        ' rdoTeacher
        ' 
        rdoTeacher.Location = New Point(8, 44)
        rdoTeacher.Name = "rdoTeacher"
        rdoTeacher.Size = New Size(104, 24)
        rdoTeacher.TabIndex = 1
        rdoTeacher.Text = "Teacher"
        ' 
        ' createPanel
        ' 
        createPanel.BackColor = Color.White
        createPanel.BorderStyle = BorderStyle.FixedSingle
        createPanel.Controls.Add(PictureBox1)
        createPanel.Controls.Add(gbCredentials)
        createPanel.Controls.Add(gbPersonal)
        createPanel.Controls.Add(btnCreateAccount)
        createPanel.Controls.Add(btnCancelCreate)
        createPanel.Controls.Add(linkLogin)
        createPanel.Location = New Point(379, 176)
        createPanel.Name = "createPanel"
        createPanel.Size = New Size(855, 356)
        createPanel.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._C78BBCDF_138A_4E64_ABD7_CF434DE483B3_
        PictureBox1.Location = New Point(534, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(303, 341)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' gbCredentials
        ' 
        gbCredentials.Controls.Add(IDNUMBER)
        gbCredentials.Controls.Add(txtCAStudentID)
        gbCredentials.Controls.Add(lblCAUsername)
        gbCredentials.Controls.Add(txtCAUsername)
        gbCredentials.Controls.Add(lblCAPassword)
        gbCredentials.Controls.Add(txtCAConfirm)
        gbCredentials.Controls.Add(txtCAPassword)
        gbCredentials.Controls.Add(lblCAConfirm)
        gbCredentials.Location = New Point(8, 8)
        gbCredentials.Name = "gbCredentials"
        gbCredentials.Size = New Size(510, 139)
        gbCredentials.TabIndex = 0
        gbCredentials.TabStop = False
        gbCredentials.Text = "Account Credentials"
        ' 
        ' IDNUMBER
        ' 
        IDNUMBER.Location = New Point(12, 24)
        IDNUMBER.Name = "IDNUMBER"
        IDNUMBER.Size = New Size(120, 20)
        IDNUMBER.TabIndex = 0
        IDNUMBER.Text = "ID number"
        ' 
        ' txtCAStudentID
        ' 
        txtCAStudentID.Location = New Point(140, 22)
        txtCAStudentID.Name = "txtCAStudentID"
        txtCAStudentID.Size = New Size(340, 23)
        txtCAStudentID.TabIndex = 1
        ' 
        ' lblCAUsername
        ' 
        lblCAUsername.Location = New Point(12, 52)
        lblCAUsername.Name = "lblCAUsername"
        lblCAUsername.Size = New Size(120, 20)
        lblCAUsername.TabIndex = 2
        lblCAUsername.Text = "Username"
        ' 
        ' txtCAUsername
        ' 
        txtCAUsername.Location = New Point(140, 50)
        txtCAUsername.Name = "txtCAUsername"
        txtCAUsername.Size = New Size(340, 23)
        txtCAUsername.TabIndex = 3
        ' 
        ' lblCAPassword
        ' 
        lblCAPassword.Location = New Point(12, 80)
        lblCAPassword.Name = "lblCAPassword"
        lblCAPassword.Size = New Size(120, 20)
        lblCAPassword.TabIndex = 4
        lblCAPassword.Text = "Password"
        ' 
        ' txtCAPassword
        ' 
        txtCAPassword.Location = New Point(140, 78)
        txtCAPassword.Name = "txtCAPassword"
        txtCAPassword.Size = New Size(340, 23)
        txtCAPassword.TabIndex = 5
        txtCAPassword.UseSystemPasswordChar = True
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = Color.FromArgb(CByte(28), CByte(115), CByte(166))
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(286, 321)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(116, 28)
        btnCreateAccount.TabIndex = 2
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnCancelCreate
        ' 
        btnCancelCreate.Location = New Point(408, 323)
        btnCancelCreate.Name = "btnCancelCreate"
        btnCancelCreate.Size = New Size(80, 28)
        btnCancelCreate.TabIndex = 3
        btnCancelCreate.Text = "Cancel"
        ' 
        ' linkLogin
        ' 
        linkLogin.Location = New Point(20, 328)
        linkLogin.Name = "linkLogin"
        linkLogin.Size = New Size(220, 20)
        linkLogin.TabIndex = 4
        linkLogin.TabStop = True
        linkLogin.Text = "Already have an account? Login"
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.White
        loginPanel.BorderStyle = BorderStyle.FixedSingle
        loginPanel.Controls.Add(headerPanel)
        loginPanel.Controls.Add(iconUser)
        loginPanel.Controls.Add(txtUsername)
        loginPanel.Controls.Add(iconKey)
        loginPanel.Controls.Add(txtPassword)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(btnCreate)
        loginPanel.Controls.Add(rightLogo)
        loginPanel.Location = New Point(518, 223)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(526, 246)
        loginPanel.TabIndex = 12
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.FromArgb(CByte(28), CByte(115), CByte(166))
        headerPanel.Controls.Add(headerLabel)
        headerPanel.Dock = DockStyle.Top
        headerPanel.Location = New Point(0, 0)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(524, 48)
        headerPanel.TabIndex = 0
        ' 
        ' headerLabel
        ' 
        headerLabel.AutoSize = True
        headerLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        headerLabel.ForeColor = Color.White
        headerLabel.Location = New Point(12, 12)
        headerLabel.Name = "headerLabel"
        headerLabel.Size = New Size(369, 21)
        headerLabel.TabIndex = 1
        headerLabel.Text = "WELCOME TO FISHER VALLEY COLLEGE LIBRARY"
        ' 
        ' iconUser
        ' 
        iconUser.BackColor = Color.Black
        iconUser.Location = New Point(12, 72)
        iconUser.Name = "iconUser"
        iconUser.Size = New Size(32, 32)
        iconUser.TabIndex = 2
        iconUser.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(56, 76)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(240, 23)
        txtUsername.TabIndex = 3
        ' 
        ' iconKey
        ' 
        iconKey.BackColor = Color.Black
        iconKey.Location = New Point(12, 112)
        iconKey.Name = "iconKey"
        iconKey.Size = New Size(32, 32)
        iconKey.TabIndex = 4
        iconKey.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(56, 116)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(240, 23)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(28), CByte(115), CByte(166))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(56, 156)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(100, 28)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCreate
        ' 
        btnCreate.FlatStyle = FlatStyle.Flat
        btnCreate.Location = New Point(164, 156)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(100, 28)
        btnCreate.TabIndex = 7
        btnCreate.Text = "Create Account"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' rightLogo
        ' 
        rightLogo.BackColor = Color.LightGray
        rightLogo.Location = New Point(332, 56)
        rightLogo.Name = "rightLogo"
        rightLogo.Size = New Size(176, 152)
        rightLogo.SizeMode = PictureBoxSizeMode.CenterImage
        rightLogo.TabIndex = 8
        rightLogo.TabStop = False
        ' 
        ' panelLeft
        ' 
        panelLeft.BackColor = Color.FromArgb(CByte(11), CByte(85), CByte(128))
        panelLeft.Dock = DockStyle.Left
        panelLeft.Location = New Point(0, 56)
        panelLeft.Name = "panelLeft"
        panelLeft.Size = New Size(72, 629)
        panelLeft.TabIndex = 10
        ' 
        ' panelTop
        ' 
        panelTop.BackColor = Color.FromArgb(CByte(11), CByte(85), CByte(128))
        panelTop.Controls.Add(smallLogo)
        panelTop.Controls.Add(titleLabel)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(1485, 56)
        panelTop.TabIndex = 11
        ' 
        ' smallLogo
        ' 
        smallLogo.BackColor = Color.White
        smallLogo.Image = My.Resources.Resources._CED4CB1E_B9E6_4804_BFA1_E279BD154C18_
        smallLogo.Location = New Point(0, 0)
        smallLogo.Name = "smallLogo"
        smallLogo.Size = New Size(72, 56)
        smallLogo.SizeMode = PictureBoxSizeMode.StretchImage
        smallLogo.TabIndex = 2
        smallLogo.TabStop = False
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        titleLabel.ForeColor = Color.White
        titleLabel.Location = New Point(78, 18)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(144, 25)
        titleLabel.TabIndex = 3
        titleLabel.Text = "Library System"
        ' 
        ' createaccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1485, 685)
        Controls.Add(createPanel)
        Controls.Add(loginPanel)
        Controls.Add(panelLeft)
        Controls.Add(panelTop)
        Name = "createaccount"
        Text = "createaccount"
        gbPersonal.ResumeLayout(False)
        gbPersonal.PerformLayout()
        gbAccountType.ResumeLayout(False)
        createPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gbCredentials.ResumeLayout(False)
        gbCredentials.PerformLayout()
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        CType(iconUser, ComponentModel.ISupportInitialize).EndInit()
        CType(iconKey, ComponentModel.ISupportInitialize).EndInit()
        CType(rightLogo, ComponentModel.ISupportInitialize).EndInit()
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents txtCAConfirm As TextBox
    Private WithEvents lblCAConfirm As Label
    Private WithEvents gbPersonal As GroupBox
    Private WithEvents lblFirstName As Label
    Private WithEvents txtFirstName As TextBox
    Private WithEvents lblLastName As Label
    Private WithEvents txtLastName As TextBox
    Private WithEvents lblCourseDept As Label
    Private WithEvents cmbCourseDept As ComboBox
    Private WithEvents lblYearSection As Label
    Private WithEvents txtYearSection As TextBox
    Private WithEvents lblContact As Label
    Private WithEvents txtContact As TextBox
    Private WithEvents gbAccountType As GroupBox
    Private WithEvents rdoStudent As RadioButton
    Private WithEvents rdoTeacher As RadioButton
    Private WithEvents createPanel As Panel
    Private WithEvents gbCredentials As GroupBox
    Private WithEvents IDNUMBER As Label
    Private WithEvents txtCAStudentID As TextBox
    Private WithEvents lblCAUsername As Label
    Private WithEvents txtCAUsername As TextBox
    Private WithEvents lblCAPassword As Label
    Private WithEvents txtCAPassword As TextBox
    Private WithEvents btnCreateAccount As Button
    Private WithEvents btnCancelCreate As Button
    Private WithEvents linkLogin As LinkLabel
    Private WithEvents loginPanel As Panel
    Private WithEvents headerPanel As Panel
    Private WithEvents headerLabel As Label
    Private WithEvents iconUser As PictureBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents iconKey As PictureBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents btnCreate As Button
    Private WithEvents rightLogo As PictureBox
    Private WithEvents panelLeft As Panel
    Private WithEvents panelTop As Panel
    Private WithEvents smallLogo As PictureBox
    Private WithEvents titleLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
