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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        loginPanel = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        headerPanel = New Panel()
        headerLabel = New Label()
        subtitleLabel = New Label()
        usernameLabel = New Label()
        usernameTextBox = New TextBox()
        passwordLabel = New Label()
        passwordTextBox = New TextBox()
        loginButton = New Button()
        createAccountButton = New Button()
        leftPanel = New Panel()
        topPanel = New Panel()
        PictureBoxLogo = New PictureBox()
        titleLabel = New Label()
        loginPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        headerPanel.SuspendLayout()
        topPanel.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.White
        loginPanel.BorderStyle = BorderStyle.FixedSingle
        loginPanel.Controls.Add(PictureBox2)
        loginPanel.Controls.Add(PictureBox3)
        loginPanel.Controls.Add(PictureBox1)
        loginPanel.Controls.Add(headerPanel)
        loginPanel.Controls.Add(usernameLabel)
        loginPanel.Controls.Add(usernameTextBox)
        loginPanel.Controls.Add(passwordLabel)
        loginPanel.Controls.Add(passwordTextBox)
        loginPanel.Controls.Add(loginButton)
        loginPanel.Controls.Add(createAccountButton)
        loginPanel.Location = New Point(555, 311)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(717, 275)
        loginPanel.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._B6325D80_0E9D_46BB_9B7C_027AB01B1AEE_
        PictureBox2.Location = New Point(11, 152)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(428, 68)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(284, 203)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._F05D3536_EF6F_453B_A65C_746E448B028D_
        PictureBox1.Location = New Point(11, 92)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.FromArgb(CByte(30), CByte(120), CByte(180))
        headerPanel.Controls.Add(headerLabel)
        headerPanel.Controls.Add(subtitleLabel)
        headerPanel.Location = New Point(-1, -1)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(728, 63)
        headerPanel.TabIndex = 0
        ' 
        ' headerLabel
        ' 
        headerLabel.AutoSize = True
        headerLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        headerLabel.ForeColor = Color.White
        headerLabel.Location = New Point(16, 12)
        headerLabel.Name = "headerLabel"
        headerLabel.Size = New Size(140, 25)
        headerLabel.TabIndex = 0
        headerLabel.Text = "Welcome Back"
        ' 
        ' subtitleLabel
        ' 
        subtitleLabel.AutoSize = True
        subtitleLabel.Font = New Font("Segoe UI", 9F)
        subtitleLabel.ForeColor = Color.FromArgb(CByte(220), CByte(240), CByte(255))
        subtitleLabel.Location = New Point(16, 40)
        subtitleLabel.Name = "subtitleLabel"
        subtitleLabel.Size = New Size(203, 15)
        subtitleLabel.TabIndex = 1
        subtitleLabel.Text = "Sign in to access your library account"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Segoe UI", 9F)
        usernameLabel.Location = New Point(64, 92)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(60, 15)
        usernameLabel.TabIndex = 3
        usernameLabel.Text = "Username"
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(64, 112)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(260, 23)
        usernameTextBox.TabIndex = 4
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Segoe UI", 9F)
        passwordLabel.Location = New Point(64, 152)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(57, 15)
        passwordLabel.TabIndex = 6
        passwordLabel.Text = "Password"
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(64, 172)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(260, 23)
        passwordTextBox.TabIndex = 7
        passwordTextBox.UseSystemPasswordChar = True
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.FromArgb(CByte(30), CByte(120), CByte(180))
        loginButton.FlatAppearance.BorderSize = 0
        loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(25), CByte(100), CByte(160))
        loginButton.FlatStyle = FlatStyle.Flat
        loginButton.ForeColor = Color.White
        loginButton.Location = New Point(64, 208)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(120, 36)
        loginButton.TabIndex = 8
        loginButton.Text = "Log In"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' createAccountButton
        ' 
        createAccountButton.BackColor = Color.White
        createAccountButton.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(120), CByte(180))
        createAccountButton.FlatStyle = FlatStyle.Flat
        createAccountButton.ForeColor = Color.FromArgb(CByte(30), CByte(120), CByte(180))
        createAccountButton.Location = New Point(204, 208)
        createAccountButton.Name = "createAccountButton"
        createAccountButton.Size = New Size(120, 36)
        createAccountButton.TabIndex = 9
        createAccountButton.Text = "Create Account"
        createAccountButton.UseVisualStyleBackColor = False
        ' 
        ' leftPanel
        ' 
        leftPanel.BackColor = Color.FromArgb(CByte(18), CByte(90), CByte(140))
        leftPanel.Dock = DockStyle.Left
        leftPanel.Location = New Point(0, 80)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(96, 660)
        leftPanel.TabIndex = 4
        ' 
        ' topPanel
        ' 
        topPanel.BackColor = Color.FromArgb(CByte(30), CByte(120), CByte(180))
        topPanel.Controls.Add(PictureBoxLogo)
        topPanel.Controls.Add(titleLabel)
        topPanel.Dock = DockStyle.Top
        topPanel.Location = New Point(0, 0)
        topPanel.Name = "topPanel"
        topPanel.Size = New Size(1506, 80)
        topPanel.TabIndex = 5
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.WhiteSmoke
        PictureBoxLogo.Image = My.Resources.Resources._4EBBE486_D879_4CF0_AA27_34B66C33211E_
        PictureBoxLogo.Location = New Point(0, 0)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(96, 80)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 6
        PictureBoxLogo.TabStop = False
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        titleLabel.ForeColor = Color.White
        titleLabel.Location = New Point(102, 23)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(208, 37)
        titleLabel.TabIndex = 1
        titleLabel.Text = "Library System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1506, 740)
        Controls.Add(loginPanel)
        Controls.Add(leftPanel)
        Controls.Add(topPanel)
        Name = "Form1"
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        topPanel.ResumeLayout(False)
        topPanel.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents loginPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents headerPanel As Panel
    Private WithEvents headerLabel As Label
    Private WithEvents subtitleLabel As Label
    Private WithEvents usernameLabel As Label
    Private WithEvents usernameTextBox As TextBox
    Private WithEvents passwordLabel As Label
    Private WithEvents passwordTextBox As TextBox
    Private WithEvents loginButton As Button
    Private WithEvents createAccountButton As Button
    Private WithEvents leftPanel As Panel
    Private WithEvents topPanel As Panel
    Private WithEvents titleLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents PictureBoxLogo As PictureBox

End Class
