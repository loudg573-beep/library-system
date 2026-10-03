<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelLeft = New Panel()
        panelTop = New Panel()
        smallLogo = New PictureBox()
        titleLabel = New Label()
        headerPanel = New Panel()
        headerLabel = New Label()
        loginPanel = New Panel()
        iconUser = New PictureBox()
        txtUsername = New TextBox()
        iconKey = New PictureBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCreate = New Button()
        rightLogo = New PictureBox()
        panelTop.SuspendLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).BeginInit()
        headerPanel.SuspendLayout()
        loginPanel.SuspendLayout()
        CType(iconUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(iconKey, ComponentModel.ISupportInitialize).BeginInit()
        CType(rightLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelLeft
        ' 
        panelLeft.BackColor = Color.FromArgb(CByte(11), CByte(85), CByte(128))
        panelLeft.Dock = DockStyle.Left
        panelLeft.Location = New Point(0, 56)
        panelLeft.Name = "panelLeft"
        panelLeft.Size = New Size(72, 629)
        panelLeft.TabIndex = 5
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
        panelTop.TabIndex = 6
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
        titleLabel.Location = New Point(78, 9)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(144, 25)
        titleLabel.TabIndex = 3
        titleLabel.Text = "Library System"
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
        loginPanel.Location = New Point(602, 268)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(526, 222)
        loginPanel.TabIndex = 7
        ' 
        ' iconUser
        ' 
        iconUser.BackColor = Color.Black
        iconUser.Image = My.Resources.Resources._B8682596_EC4A_457E_AEC8_462970145DA0_
        iconUser.Location = New Point(18, 71)
        iconUser.Name = "iconUser"
        iconUser.Size = New Size(32, 28)
        iconUser.SizeMode = PictureBoxSizeMode.StretchImage
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
        iconKey.Image = My.Resources.Resources._888C8C5F_2CB4_4C43_9EFE_44F0F5CB94E2_
        iconKey.Location = New Point(18, 110)
        iconKey.Name = "iconKey"
        iconKey.Size = New Size(32, 32)
        iconKey.SizeMode = PictureBoxSizeMode.StretchImage
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
        rightLogo.Image = My.Resources.Resources._6B3866CE_55A3_4DFC_BD9C_E26F7AD4EF56_
        rightLogo.Location = New Point(302, 36)
        rightLogo.Name = "rightLogo"
        rightLogo.Size = New Size(223, 185)
        rightLogo.SizeMode = PictureBoxSizeMode.StretchImage
        rightLogo.TabIndex = 8
        rightLogo.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1485, 685)
        Controls.Add(panelLeft)
        Controls.Add(panelTop)
        Controls.Add(loginPanel)
        Name = "Form1"
        Text = "Form1"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).EndInit()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        CType(iconUser, ComponentModel.ISupportInitialize).EndInit()
        CType(iconKey, ComponentModel.ISupportInitialize).EndInit()
        CType(rightLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents panelLeft As Panel
    Private WithEvents panelTop As Panel
    Private WithEvents smallLogo As PictureBox
    Private WithEvents titleLabel As Label
    Private WithEvents headerPanel As Panel
    Private WithEvents headerLabel As Label
    Private WithEvents loginPanel As Panel
    Private WithEvents iconUser As PictureBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents iconKey As PictureBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents btnCreate As Button
    Private WithEvents rightLogo As PictureBox

End Class
