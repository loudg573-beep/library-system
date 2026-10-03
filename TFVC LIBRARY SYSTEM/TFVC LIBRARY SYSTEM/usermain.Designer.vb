<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usermain
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
        btnMyBorrowed = New Button()
        btnHistory = New Button()
        btnProfile = New Button()
        btnLogout = New Button()
        panelTop = New Panel()
        smallLogo = New PictureBox()
        titleLabel = New Label()
        btnDashboard = New Button()
        btnBrowseBooks = New Button()
        navPanel = New Panel()
        mainContentPanel = New Panel()
        panelTop.SuspendLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).BeginInit()
        navPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnMyBorrowed
        ' 
        btnMyBorrowed.FlatAppearance.BorderSize = 0
        btnMyBorrowed.FlatStyle = FlatStyle.Flat
        btnMyBorrowed.ForeColor = Color.White
        btnMyBorrowed.Location = New Point(12, 105)
        btnMyBorrowed.Name = "btnMyBorrowed"
        btnMyBorrowed.Size = New Size(151, 36)
        btnMyBorrowed.TabIndex = 2
        btnMyBorrowed.Text = "📖  My Borrowed Books"
        btnMyBorrowed.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnHistory
        ' 
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(12, 153)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(151, 36)
        btnHistory.TabIndex = 3
        btnHistory.Text = "📜  Borrowing History"
        btnHistory.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnProfile
        ' 
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(12, 201)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(151, 36)
        btnProfile.TabIndex = 4
        btnProfile.Text = "👤  My Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(12, 249)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(151, 36)
        btnLogout.TabIndex = 5
        btnLogout.Text = "🚪  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
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
        panelTop.TabIndex = 12
        ' 
        ' smallLogo
        ' 
        smallLogo.BackColor = Color.White
        smallLogo.Image = My.Resources.Resources._F651FFDF_ABAB_4BCF_A188_DBA57EE45803_
        smallLogo.Location = New Point(0, 0)
        smallLogo.Name = "smallLogo"
        smallLogo.Size = New Size(82, 56)
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
        ' btnDashboard
        ' 
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(12, 21)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(216, 36)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "🏠  Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnBrowseBooks
        ' 
        btnBrowseBooks.FlatAppearance.BorderSize = 0
        btnBrowseBooks.FlatStyle = FlatStyle.Flat
        btnBrowseBooks.ForeColor = Color.White
        btnBrowseBooks.Location = New Point(12, 63)
        btnBrowseBooks.Name = "btnBrowseBooks"
        btnBrowseBooks.Size = New Size(151, 36)
        btnBrowseBooks.TabIndex = 1
        btnBrowseBooks.Text = "📚  Browse Books"
        btnBrowseBooks.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' navPanel
        ' 
        navPanel.BackColor = Color.FromArgb(CByte(17), CByte(90), CByte(131))
        navPanel.Controls.Add(btnDashboard)
        navPanel.Controls.Add(btnBrowseBooks)
        navPanel.Controls.Add(btnMyBorrowed)
        navPanel.Controls.Add(btnHistory)
        navPanel.Controls.Add(btnProfile)
        navPanel.Controls.Add(btnLogout)
        navPanel.Location = New Point(-6, 56)
        navPanel.Name = "navPanel"
        navPanel.Size = New Size(248, 629)
        navPanel.TabIndex = 13
        ' 
        ' mainContentPanel
        ' 
        mainContentPanel.BackColor = Color.WhiteSmoke
        mainContentPanel.Location = New Point(241, 56)
        mainContentPanel.Name = "mainContentPanel"
        mainContentPanel.Size = New Size(1245, 629)
        mainContentPanel.TabIndex = 14
        mainContentPanel.TabStop = True
        ' 
        ' usermain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1485, 685)
        Controls.Add(panelTop)
        Controls.Add(navPanel)
        Controls.Add(mainContentPanel)
        Name = "usermain"
        Text = "usermain"
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).EndInit()
        navPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents btnMyBorrowed As Button
    Private WithEvents btnHistory As Button
    Private WithEvents btnProfile As Button
    Private WithEvents btnLogout As Button
    Private WithEvents panelTop As Panel
    Private WithEvents smallLogo As PictureBox
    Private WithEvents titleLabel As Label
    Private WithEvents btnDashboard As Button
    Private WithEvents btnBrowseBooks As Button
    Private WithEvents navPanel As Panel
    Private WithEvents mainContentPanel As Panel
End Class
