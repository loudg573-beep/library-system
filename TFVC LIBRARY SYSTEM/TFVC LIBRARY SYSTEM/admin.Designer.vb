<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        contentPanel = New Panel()
        headerPanel = New Panel()
        titleLabel = New Label()
        navFlow = New FlowLayoutPanel()
        linkLogout = New LinkLabel()
        linkSettings = New LinkLabel()
        linkReports = New LinkLabel()
        linkManageUsers = New LinkLabel()
        linkCategories = New LinkLabel()
        linkOverdue = New LinkLabel()
        linkReturnBooks = New LinkLabel()
        linkBorrowBooks = New LinkLabel()
        linkBorrowers = New LinkLabel()
        linkBooks = New LinkLabel()
        linkDashboard = New LinkLabel()
        leftPanel = New Panel()
        smallLogo = New PictureBox()
        headerPanel.SuspendLayout()
        navFlow.SuspendLayout()
        leftPanel.SuspendLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' contentPanel
        ' 
        contentPanel.BackColor = Color.WhiteSmoke
        contentPanel.Dock = DockStyle.Fill
        contentPanel.Location = New Point(174, 59)
        contentPanel.Margin = New Padding(12)
        contentPanel.Name = "contentPanel"
        contentPanel.Size = New Size(1311, 626)
        contentPanel.TabIndex = 3
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.SteelBlue
        headerPanel.Controls.Add(titleLabel)
        headerPanel.Dock = DockStyle.Top
        headerPanel.Location = New Point(174, 0)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(1311, 59)
        headerPanel.TabIndex = 5
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        titleLabel.ForeColor = Color.White
        titleLabel.Location = New Point(575, 9)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(208, 25)
        titleLabel.TabIndex = 4
        titleLabel.Text = "Library System Admin"
        ' 
        ' navFlow
        ' 
        navFlow.AutoSize = True
        navFlow.BackColor = Color.Transparent
        navFlow.Controls.Add(linkDashboard)
        navFlow.Controls.Add(linkBooks)
        navFlow.Controls.Add(linkBorrowers)
        navFlow.Controls.Add(linkBorrowBooks)
        navFlow.Controls.Add(linkReturnBooks)
        navFlow.Controls.Add(linkOverdue)
        navFlow.Controls.Add(linkCategories)
        navFlow.Controls.Add(linkManageUsers)
        navFlow.Controls.Add(linkReports)
        navFlow.Controls.Add(linkSettings)
        navFlow.Controls.Add(linkLogout)
        navFlow.FlowDirection = FlowDirection.TopDown
        navFlow.Location = New Point(4, 84)
        navFlow.Margin = New Padding(0)
        navFlow.Name = "navFlow"
        navFlow.Size = New Size(168, 390)
        navFlow.TabIndex = 1
        navFlow.WrapContents = False
        ' 
        ' linkLogout
        ' 
        linkLogout.ActiveLinkColor = Color.LightGray
        linkLogout.AutoSize = True
        linkLogout.Font = New Font("Segoe UI", 10F)
        linkLogout.LinkColor = Color.White
        linkLogout.Location = New Point(3, 316)
        linkLogout.Margin = New Padding(3, 6, 3, 6)
        linkLogout.Name = "linkLogout"
        linkLogout.Size = New Size(80, 19)
        linkLogout.TabIndex = 10
        linkLogout.TabStop = True
        linkLogout.Text = "🚪  Logout"
        ' 
        ' linkSettings
        ' 
        linkSettings.ActiveLinkColor = Color.LightGray
        linkSettings.AutoSize = True
        linkSettings.Font = New Font("Segoe UI", 10F)
        linkSettings.LinkColor = Color.White
        linkSettings.Location = New Point(3, 285)
        linkSettings.Margin = New Padding(3, 6, 3, 6)
        linkSettings.Name = "linkSettings"
        linkSettings.Size = New Size(85, 19)
        linkSettings.TabIndex = 9
        linkSettings.TabStop = True
        linkSettings.Text = "⚙️  Settings"
        ' 
        ' linkReports
        ' 
        linkReports.ActiveLinkColor = Color.LightGray
        linkReports.AutoSize = True
        linkReports.Font = New Font("Segoe UI", 10F)
        linkReports.LinkColor = Color.White
        linkReports.Location = New Point(3, 254)
        linkReports.Margin = New Padding(3, 6, 3, 6)
        linkReports.Name = "linkReports"
        linkReports.Size = New Size(83, 19)
        linkReports.TabIndex = 8
        linkReports.TabStop = True
        linkReports.Text = "📊  Reports"
        ' 
        ' linkManageUsers
        ' 
        linkManageUsers.ActiveLinkColor = Color.LightGray
        linkManageUsers.AutoSize = True
        linkManageUsers.Font = New Font("Segoe UI", 10F)
        linkManageUsers.LinkColor = Color.White
        linkManageUsers.Location = New Point(3, 223)
        linkManageUsers.Margin = New Padding(3, 6, 3, 6)
        linkManageUsers.Name = "linkManageUsers"
        linkManageUsers.Size = New Size(124, 19)
        linkManageUsers.TabIndex = 7
        linkManageUsers.TabStop = True
        linkManageUsers.Text = "👥  Manage Users"
        ' 
        ' linkCategories
        ' 
        linkCategories.ActiveLinkColor = Color.LightGray
        linkCategories.AutoSize = True
        linkCategories.Font = New Font("Segoe UI", 10F)
        linkCategories.LinkColor = Color.White
        linkCategories.Location = New Point(3, 192)
        linkCategories.Margin = New Padding(3, 6, 3, 6)
        linkCategories.Name = "linkCategories"
        linkCategories.Size = New Size(101, 19)
        linkCategories.TabIndex = 6
        linkCategories.TabStop = True
        linkCategories.Text = "📂  Categories"
        ' 
        ' linkOverdue
        ' 
        linkOverdue.ActiveLinkColor = Color.LightGray
        linkOverdue.AutoSize = True
        linkOverdue.Font = New Font("Segoe UI", 10F)
        linkOverdue.LinkColor = Color.White
        linkOverdue.Location = New Point(3, 161)
        linkOverdue.Margin = New Padding(3, 6, 3, 6)
        linkOverdue.Name = "linkOverdue"
        linkOverdue.Size = New Size(130, 19)
        linkOverdue.TabIndex = 5
        linkOverdue.TabStop = True
        linkOverdue.Text = "⚠️  Overdue Books"
        ' 
        ' linkReturnBooks
        ' 
        linkReturnBooks.ActiveLinkColor = Color.LightGray
        linkReturnBooks.AutoSize = True
        linkReturnBooks.Font = New Font("Segoe UI", 10F)
        linkReturnBooks.LinkColor = Color.White
        linkReturnBooks.Location = New Point(3, 130)
        linkReturnBooks.Margin = New Padding(3, 6, 3, 6)
        linkReturnBooks.Name = "linkReturnBooks"
        linkReturnBooks.Size = New Size(111, 19)
        linkReturnBooks.TabIndex = 4
        linkReturnBooks.TabStop = True
        linkReturnBooks.Text = "↩️  Return Books"
        ' 
        ' linkBorrowBooks
        ' 
        linkBorrowBooks.ActiveLinkColor = Color.LightGray
        linkBorrowBooks.AutoSize = True
        linkBorrowBooks.Font = New Font("Segoe UI", 10F)
        linkBorrowBooks.LinkColor = Color.White
        linkBorrowBooks.Location = New Point(3, 99)
        linkBorrowBooks.Margin = New Padding(3, 6, 3, 6)
        linkBorrowBooks.Name = "linkBorrowBooks"
        linkBorrowBooks.Size = New Size(121, 19)
        linkBorrowBooks.TabIndex = 3
        linkBorrowBooks.TabStop = True
        linkBorrowBooks.Text = "🔄  Borrow Books"
        ' 
        ' linkBorrowers
        ' 
        linkBorrowers.ActiveLinkColor = Color.LightGray
        linkBorrowers.AutoSize = True
        linkBorrowers.Font = New Font("Segoe UI", 10F)
        linkBorrowers.LinkColor = Color.White
        linkBorrowers.Location = New Point(3, 68)
        linkBorrowers.Margin = New Padding(3, 6, 3, 6)
        linkBorrowers.Name = "linkBorrowers"
        linkBorrowers.Size = New Size(98, 19)
        linkBorrowers.TabIndex = 2
        linkBorrowers.TabStop = True
        linkBorrowers.Text = "🎓  Borrowers"
        ' 
        ' linkBooks
        ' 
        linkBooks.ActiveLinkColor = Color.LightGray
        linkBooks.AutoSize = True
        linkBooks.Font = New Font("Segoe UI", 10F)
        linkBooks.LinkColor = Color.White
        linkBooks.Location = New Point(3, 37)
        linkBooks.Margin = New Padding(3, 6, 3, 6)
        linkBooks.Name = "linkBooks"
        linkBooks.Size = New Size(73, 19)
        linkBooks.TabIndex = 1
        linkBooks.TabStop = True
        linkBooks.Text = "📚  Books"
        ' 
        ' linkDashboard
        ' 
        linkDashboard.ActiveLinkColor = Color.LightGray
        linkDashboard.AutoSize = True
        linkDashboard.Font = New Font("Segoe UI", 10F)
        linkDashboard.LinkColor = Color.White
        linkDashboard.Location = New Point(3, 6)
        linkDashboard.Margin = New Padding(3, 6, 3, 6)
        linkDashboard.Name = "linkDashboard"
        linkDashboard.Size = New Size(103, 19)
        linkDashboard.TabIndex = 0
        linkDashboard.TabStop = True
        linkDashboard.Text = "🏠  Dashboard"
        ' 
        ' leftPanel
        ' 
        leftPanel.BackColor = Color.FromArgb(CByte(17), CByte(90), CByte(131))
        leftPanel.Controls.Add(smallLogo)
        leftPanel.Controls.Add(navFlow)
        leftPanel.Dock = DockStyle.Left
        leftPanel.Location = New Point(0, 0)
        leftPanel.Name = "leftPanel"
        leftPanel.Padding = New Padding(8)
        leftPanel.Size = New Size(174, 685)
        leftPanel.TabIndex = 4
        ' 
        ' smallLogo
        ' 
        smallLogo.BackColor = Color.White
        smallLogo.Image = My.Resources.Resources._CED4CB1E_B9E6_4804_BFA1_E279BD154C18_
        smallLogo.Location = New Point(-2, 0)
        smallLogo.Name = "smallLogo"
        smallLogo.Size = New Size(174, 81)
        smallLogo.SizeMode = PictureBoxSizeMode.StretchImage
        smallLogo.TabIndex = 3
        smallLogo.TabStop = False
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1485, 685)
        Controls.Add(contentPanel)
        Controls.Add(headerPanel)
        Controls.Add(leftPanel)
        Name = "admin"
        Text = "admin"
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        navFlow.ResumeLayout(False)
        navFlow.PerformLayout()
        leftPanel.ResumeLayout(False)
        leftPanel.PerformLayout()
        CType(smallLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents contentPanel As Panel
    Private WithEvents headerPanel As Panel
    Private WithEvents titleLabel As Label
    Private WithEvents navFlow As FlowLayoutPanel
    Private WithEvents linkDashboard As LinkLabel
    Private WithEvents linkBooks As LinkLabel
    Private WithEvents linkBorrowers As LinkLabel
    Private WithEvents linkBorrowBooks As LinkLabel
    Private WithEvents linkReturnBooks As LinkLabel
    Private WithEvents linkOverdue As LinkLabel
    Private WithEvents linkCategories As LinkLabel
    Private WithEvents linkManageUsers As LinkLabel
    Private WithEvents linkReports As LinkLabel
    Private WithEvents linkSettings As LinkLabel
    Private WithEvents linkLogout As LinkLabel
    Private WithEvents leftPanel As Panel
    Private WithEvents smallLogo As PictureBox
End Class
