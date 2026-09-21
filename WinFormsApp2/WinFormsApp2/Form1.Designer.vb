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
    Private PanelLeft As System.Windows.Forms.Panel
    Private PanelHeader As System.Windows.Forms.Panel
    Private LabelTitle As System.Windows.Forms.Label
    Private PictureBoxLogo As System.Windows.Forms.PictureBox
    Private PictureBoxYouTube As System.Windows.Forms.PictureBox
    Private PictureBoxFb As System.Windows.Forms.PictureBox
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private PanelReportOptions As System.Windows.Forms.Panel
    Private PanelReportViewer As System.Windows.Forms.Panel
    Private PanelReportContent As System.Windows.Forms.Panel
    Private LabelStudentInfoTitle As System.Windows.Forms.Label
    Private LabelIDNumber As System.Windows.Forms.Label
    Private TextBoxID As System.Windows.Forms.TextBox
    Private LabelName As System.Windows.Forms.Label
    Private TextBoxName As System.Windows.Forms.TextBox
    Private LabelCourse As System.Windows.Forms.Label
    Private ComboBoxCourse As System.Windows.Forms.ComboBox
    Private LabelBookInfoTitle As System.Windows.Forms.Label
    Private LabelBookID As System.Windows.Forms.Label
    Private TextBoxBookID As System.Windows.Forms.TextBox
    Private LabelBookTitle As System.Windows.Forms.Label
    Private TextBoxBookTitle As System.Windows.Forms.TextBox
    Private LabelAuthor As System.Windows.Forms.Label
    Private TextBoxAuthor As System.Windows.Forms.TextBox
    Private ButtonBorrow As System.Windows.Forms.Button
    Private ButtonReturn As System.Windows.Forms.Button
    Private ButtonLogIn As System.Windows.Forms.Button
    Private ButtonBooks As System.Windows.Forms.Button
    Private ButtonBorrower As System.Windows.Forms.Button
    Private ButtonBorrowBooks As System.Windows.Forms.Button
    Private ButtonReturnBooks As System.Windows.Forms.Button
    Private ButtonOverdues As System.Windows.Forms.Button
    Private ButtonCategory As System.Windows.Forms.Button
    Private ButtonManageUsers As System.Windows.Forms.Button
    Private WithEvents ButtonReports As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelLeft = New Panel()
        ButtonReports = New Button()
        ButtonManageUsers = New Button()
        ButtonLogIn = New Button()
        ButtonCategory = New Button()
        ButtonOverdues = New Button()
        ButtonReturnBooks = New Button()
        ButtonBorrowBooks = New Button()
        ButtonBorrower = New Button()
        ButtonBooks = New Button()
        PanelHeader = New Panel()
        PictureBoxFb = New PictureBox()
        PictureBoxYouTube = New PictureBox()
        PictureBoxLogo = New PictureBox()
        LabelTitle = New Label()
        SplitContainer1 = New SplitContainer()
        PanelReportOptions = New Panel()
        LabelStudentInfoTitle = New Label()
        LabelIDNumber = New Label()
        TextBoxID = New TextBox()
        LabelName = New Label()
        TextBoxName = New TextBox()
        LabelCourse = New Label()
        ComboBoxCourse = New ComboBox()
        LabelBookInfoTitle = New Label()
        LabelBookID = New Label()
        TextBoxBookID = New TextBox()
        LabelBookTitle = New Label()
        TextBoxBookTitle = New TextBox()
        LabelAuthor = New Label()
        TextBoxAuthor = New TextBox()
        ButtonBorrow = New Button()
        ButtonReturn = New Button()
        PanelReportViewer = New Panel()
        PanelReportContent = New Panel()
        PanelLeft.SuspendLayout()
        PanelHeader.SuspendLayout()
        CType(PictureBoxFb, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxYouTube, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        PanelReportOptions.SuspendLayout()
        PanelReportViewer.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.FromArgb(CByte(17), CByte(78), CByte(128))
        PanelLeft.Controls.Add(ButtonReports)
        PanelLeft.Controls.Add(ButtonManageUsers)
        PanelLeft.Controls.Add(ButtonLogIn)
        PanelLeft.Controls.Add(ButtonCategory)
        PanelLeft.Controls.Add(ButtonOverdues)
        PanelLeft.Controls.Add(ButtonReturnBooks)
        PanelLeft.Controls.Add(ButtonBorrowBooks)
        PanelLeft.Controls.Add(ButtonBorrower)
        PanelLeft.Controls.Add(ButtonBooks)
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(160, 600)
        PanelLeft.TabIndex = 2
        ' 
        ' ButtonReports
        ' 
        ButtonReports.Dock = DockStyle.Top
        ButtonReports.FlatAppearance.BorderSize = 0
        ButtonReports.FlatStyle = FlatStyle.Flat
        ButtonReports.ForeColor = Color.White
        ButtonReports.Location = New Point(0, 352)
        ButtonReports.Name = "ButtonReports"
        ButtonReports.Padding = New Padding(12, 0, 0, 0)
        ButtonReports.Size = New Size(160, 48)
        ButtonReports.TabIndex = 0
        ButtonReports.Text = "Reports"
        ButtonReports.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonManageUsers
        ' 
        ButtonManageUsers.Dock = DockStyle.Top
        ButtonManageUsers.FlatAppearance.BorderSize = 0
        ButtonManageUsers.FlatStyle = FlatStyle.Flat
        ButtonManageUsers.ForeColor = Color.White
        ButtonManageUsers.Location = New Point(0, 304)
        ButtonManageUsers.Name = "ButtonManageUsers"
        ButtonManageUsers.Padding = New Padding(12, 0, 0, 0)
        ButtonManageUsers.Size = New Size(160, 48)
        ButtonManageUsers.TabIndex = 1
        ButtonManageUsers.Text = "Manage Users"
        ButtonManageUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonLogIn
        ' 
        ButtonLogIn.Dock = DockStyle.Bottom
        ButtonLogIn.FlatAppearance.BorderSize = 0
        ButtonLogIn.FlatStyle = FlatStyle.Flat
        ButtonLogIn.ForeColor = Color.White
        ButtonLogIn.Location = New Point(0, 552)
        ButtonLogIn.Name = "ButtonLogIn"
        ButtonLogIn.Padding = New Padding(12, 0, 0, 0)
        ButtonLogIn.Size = New Size(160, 48)
        ButtonLogIn.TabIndex = 1
        ButtonLogIn.Text = "Log In"
        ButtonLogIn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonCategory
        ' 
        ButtonCategory.Dock = DockStyle.Top
        ButtonCategory.FlatAppearance.BorderSize = 0
        ButtonCategory.FlatStyle = FlatStyle.Flat
        ButtonCategory.ForeColor = Color.White
        ButtonCategory.Location = New Point(0, 256)
        ButtonCategory.Name = "ButtonCategory"
        ButtonCategory.Padding = New Padding(12, 0, 0, 0)
        ButtonCategory.Size = New Size(160, 48)
        ButtonCategory.TabIndex = 2
        ButtonCategory.Text = "Category"
        ButtonCategory.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonOverdues
        ' 
        ButtonOverdues.Dock = DockStyle.Top
        ButtonOverdues.FlatAppearance.BorderSize = 0
        ButtonOverdues.FlatStyle = FlatStyle.Flat
        ButtonOverdues.ForeColor = Color.White
        ButtonOverdues.Location = New Point(0, 208)
        ButtonOverdues.Name = "ButtonOverdues"
        ButtonOverdues.Padding = New Padding(12, 0, 0, 0)
        ButtonOverdues.Size = New Size(160, 48)
        ButtonOverdues.TabIndex = 3
        ButtonOverdues.Text = "Overdues Books"
        ButtonOverdues.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonReturnBooks
        ' 
        ButtonReturnBooks.Dock = DockStyle.Top
        ButtonReturnBooks.FlatAppearance.BorderSize = 0
        ButtonReturnBooks.FlatStyle = FlatStyle.Flat
        ButtonReturnBooks.ForeColor = Color.White
        ButtonReturnBooks.Location = New Point(0, 160)
        ButtonReturnBooks.Name = "ButtonReturnBooks"
        ButtonReturnBooks.Padding = New Padding(12, 0, 0, 0)
        ButtonReturnBooks.Size = New Size(160, 48)
        ButtonReturnBooks.TabIndex = 4
        ButtonReturnBooks.Text = "Return Books"
        ButtonReturnBooks.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonBorrowBooks
        ' 
        ButtonBorrowBooks.Dock = DockStyle.Top
        ButtonBorrowBooks.FlatAppearance.BorderSize = 0
        ButtonBorrowBooks.FlatStyle = FlatStyle.Flat
        ButtonBorrowBooks.ForeColor = Color.White
        ButtonBorrowBooks.Location = New Point(0, 112)
        ButtonBorrowBooks.Name = "ButtonBorrowBooks"
        ButtonBorrowBooks.Padding = New Padding(12, 0, 0, 0)
        ButtonBorrowBooks.Size = New Size(160, 48)
        ButtonBorrowBooks.TabIndex = 5
        ButtonBorrowBooks.Text = "Borrow Books"
        ButtonBorrowBooks.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonBorrower
        ' 
        ButtonBorrower.Dock = DockStyle.Top
        ButtonBorrower.FlatAppearance.BorderSize = 0
        ButtonBorrower.FlatStyle = FlatStyle.Flat
        ButtonBorrower.ForeColor = Color.White
        ButtonBorrower.Location = New Point(0, 64)
        ButtonBorrower.Name = "ButtonBorrower"
        ButtonBorrower.Padding = New Padding(12, 0, 0, 0)
        ButtonBorrower.Size = New Size(160, 48)
        ButtonBorrower.TabIndex = 6
        ButtonBorrower.Text = "Borrower"
        ButtonBorrower.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ButtonBooks
        ' 
        ButtonBooks.Dock = DockStyle.Top
        ButtonBooks.FlatAppearance.BorderSize = 0
        ButtonBooks.FlatStyle = FlatStyle.Flat
        ButtonBooks.ForeColor = Color.White
        ButtonBooks.Location = New Point(0, 0)
        ButtonBooks.Name = "ButtonBooks"
        ButtonBooks.Padding = New Padding(12, 0, 0, 0)
        ButtonBooks.Size = New Size(160, 64)
        ButtonBooks.TabIndex = 7
        ButtonBooks.Text = "Books"
        ButtonBooks.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(10), CByte(120), CByte(200))
        PanelHeader.Controls.Add(PictureBoxFb)
        PanelHeader.Controls.Add(PictureBoxYouTube)
        PanelHeader.Controls.Add(PictureBoxLogo)
        PanelHeader.Controls.Add(LabelTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(160, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1434, 64)
        PanelHeader.TabIndex = 1
        ' 
        ' PictureBoxFb
        ' 
        PictureBoxFb.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxFb.BackColor = Color.WhiteSmoke
        PictureBoxFb.Location = New Point(2164, 18)
        PictureBoxFb.Name = "PictureBoxFb"
        PictureBoxFb.Size = New Size(28, 28)
        PictureBoxFb.TabIndex = 0
        PictureBoxFb.TabStop = False
        ' 
        ' PictureBoxYouTube
        ' 
        PictureBoxYouTube.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBoxYouTube.BackColor = Color.WhiteSmoke
        PictureBoxYouTube.Location = New Point(2130, 18)
        PictureBoxYouTube.Name = "PictureBoxYouTube"
        PictureBoxYouTube.Size = New Size(28, 28)
        PictureBoxYouTube.TabIndex = 1
        PictureBoxYouTube.TabStop = False
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.WhiteSmoke
        PictureBoxLogo.Location = New Point(12, 12)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(56, 40)
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 20.0F)
        LabelTitle.ForeColor = Color.White
        LabelTitle.Location = New Point(84, 12)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(188, 37)
        LabelTitle.TabIndex = 3
        LabelTitle.Text = "Library System"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(160, 64)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PanelReportOptions)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(PanelReportViewer)
        SplitContainer1.Size = New Size(1434, 536)
        SplitContainer1.SplitterDistance = 420
        SplitContainer1.TabIndex = 0
        ' 
        ' PanelReportOptions
        ' 
        PanelReportOptions.BackColor = Color.WhiteSmoke
        PanelReportOptions.Controls.Add(LabelStudentInfoTitle)
        PanelReportOptions.Controls.Add(LabelIDNumber)
        PanelReportOptions.Controls.Add(TextBoxID)
        PanelReportOptions.Controls.Add(LabelName)
        PanelReportOptions.Controls.Add(TextBoxName)
        PanelReportOptions.Controls.Add(LabelCourse)
        PanelReportOptions.Controls.Add(ComboBoxCourse)
        PanelReportOptions.Controls.Add(LabelBookInfoTitle)
        PanelReportOptions.Controls.Add(LabelBookID)
        PanelReportOptions.Controls.Add(TextBoxBookID)
        PanelReportOptions.Controls.Add(LabelBookTitle)
        PanelReportOptions.Controls.Add(TextBoxBookTitle)
        PanelReportOptions.Controls.Add(LabelAuthor)
        PanelReportOptions.Controls.Add(TextBoxAuthor)
        PanelReportOptions.Controls.Add(ButtonBorrow)
        PanelReportOptions.Controls.Add(ButtonReturn)
        PanelReportOptions.Dock = DockStyle.Fill
        PanelReportOptions.Location = New Point(0, 0)
        PanelReportOptions.Name = "PanelReportOptions"
        PanelReportOptions.Size = New Size(420, 536)
        PanelReportOptions.TabIndex = 0
        ' 
        ' LabelStudentInfoTitle
        ' 
        LabelStudentInfoTitle.AutoSize = True
        LabelStudentInfoTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelStudentInfoTitle.Location = New Point(12, 12)
        LabelStudentInfoTitle.Name = "LabelStudentInfoTitle"
        LabelStudentInfoTitle.Size = New Size(143, 19)
        LabelStudentInfoTitle.TabIndex = 0
        LabelStudentInfoTitle.Text = "Student Information"
        ' 
        ' LabelIDNumber
        ' 
        LabelIDNumber.AutoSize = True
        LabelIDNumber.Location = New Point(12, 44)
        LabelIDNumber.Name = "LabelIDNumber"
        LabelIDNumber.Size = New Size(68, 15)
        LabelIDNumber.TabIndex = 1
        LabelIDNumber.Text = "ID Number:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        TextBoxID.Location = New Point(110, 40)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(120, 23)
        TextBoxID.TabIndex = 2
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(12, 78)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(42, 15)
        LabelName.TabIndex = 3
        LabelName.Text = "Name:"
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        TextBoxName.Location = New Point(110, 74)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(120, 23)
        TextBoxName.TabIndex = 4
        ' 
        ' LabelCourse
        ' 
        LabelCourse.AutoSize = True
        LabelCourse.Location = New Point(12, 112)
        LabelCourse.Name = "LabelCourse"
        LabelCourse.Size = New Size(47, 15)
        LabelCourse.TabIndex = 5
        LabelCourse.Text = "Course:"
        ' 
        ' ComboBoxCourse
        ' 
        ComboBoxCourse.Items.AddRange(New Object() {"BSCS", "BSIT", "BSED"})
        ComboBoxCourse.Location = New Point(110, 108)
        ComboBoxCourse.Name = "ComboBoxCourse"
        ComboBoxCourse.Size = New Size(120, 23)
        ComboBoxCourse.TabIndex = 6
        ' 
        ' LabelBookInfoTitle
        ' 
        LabelBookInfoTitle.AutoSize = True
        LabelBookInfoTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelBookInfoTitle.Location = New Point(12, 150)
        LabelBookInfoTitle.Name = "LabelBookInfoTitle"
        LabelBookInfoTitle.Size = New Size(127, 19)
        LabelBookInfoTitle.TabIndex = 7
        LabelBookInfoTitle.Text = "Book Information"
        ' 
        ' LabelBookID
        ' 
        LabelBookID.AutoSize = True
        LabelBookID.Location = New Point(12, 182)
        LabelBookID.Name = "LabelBookID"
        LabelBookID.Size = New Size(51, 15)
        LabelBookID.TabIndex = 8
        LabelBookID.Text = "Book ID:"
        ' 
        ' TextBoxBookID
        ' 
        TextBoxBookID.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        TextBoxBookID.Location = New Point(110, 178)
        TextBoxBookID.Name = "TextBoxBookID"
        TextBoxBookID.Size = New Size(120, 23)
        TextBoxBookID.TabIndex = 9
        ' 
        ' LabelBookTitle
        ' 
        LabelBookTitle.AutoSize = True
        LabelBookTitle.Location = New Point(12, 214)
        LabelBookTitle.Name = "LabelBookTitle"
        LabelBookTitle.Size = New Size(32, 15)
        LabelBookTitle.TabIndex = 10
        LabelBookTitle.Text = "Title:"
        ' 
        ' TextBoxBookTitle
        ' 
        TextBoxBookTitle.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        TextBoxBookTitle.Location = New Point(110, 210)
        TextBoxBookTitle.Name = "TextBoxBookTitle"
        TextBoxBookTitle.Size = New Size(120, 23)
        TextBoxBookTitle.TabIndex = 11
        ' 
        ' LabelAuthor
        ' 
        LabelAuthor.AutoSize = True
        LabelAuthor.Location = New Point(12, 246)
        LabelAuthor.Name = "LabelAuthor"
        LabelAuthor.Size = New Size(47, 15)
        LabelAuthor.TabIndex = 12
        LabelAuthor.Text = "Author:"
        ' 
        ' TextBoxAuthor
        ' 
        TextBoxAuthor.BackColor = Color.FromArgb(CByte(255), CByte(250), CByte(230))
        TextBoxAuthor.Location = New Point(110, 242)
        TextBoxAuthor.Name = "TextBoxAuthor"
        TextBoxAuthor.Size = New Size(120, 23)
        TextBoxAuthor.TabIndex = 13
        ' 
        ' ButtonBorrow
        ' 
        ButtonBorrow.Location = New Point(28, 285)
        ButtonBorrow.Name = "ButtonBorrow"
        ButtonBorrow.Size = New Size(75, 28)
        ButtonBorrow.TabIndex = 14
        ButtonBorrow.Text = "Borrow"
        ' 
        ' ButtonReturn
        ' 
        ButtonReturn.Location = New Point(120, 285)
        ButtonReturn.Name = "ButtonReturn"
        ButtonReturn.Size = New Size(75, 28)
        ButtonReturn.TabIndex = 15
        ButtonReturn.Text = "Return"
        ' 
        ' PanelReportViewer
        ' 
        PanelReportViewer.BackColor = Color.LightGray
        PanelReportViewer.Controls.Add(PanelReportContent)
        PanelReportViewer.Dock = DockStyle.Fill
        PanelReportViewer.Location = New Point(0, 0)
        PanelReportViewer.Name = "PanelReportViewer"
        PanelReportViewer.Size = New Size(1010, 536)
        PanelReportViewer.TabIndex = 0
        ' 
        ' PanelReportContent
        ' 
        PanelReportContent.BackColor = Color.White
        PanelReportContent.BorderStyle = BorderStyle.FixedSingle
        PanelReportContent.Location = New Point(20, 12)
        PanelReportContent.Name = "PanelReportContent"
        PanelReportContent.Size = New Size(796, 512)
        PanelReportContent.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1594, 600)
        Controls.Add(SplitContainer1)
        Controls.Add(PanelHeader)
        Controls.Add(PanelLeft)
        Name = "Form1"
        Text = "Form1"
        PanelLeft.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        CType(PictureBoxFb, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxYouTube, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        PanelReportOptions.ResumeLayout(False)
        PanelReportOptions.PerformLayout()
        PanelReportViewer.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

End Class
