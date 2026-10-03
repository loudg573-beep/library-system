<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardcontrol
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
        ButtonViewAll = New Button()
        colStatus = New DataGridViewTextBoxColumn()
        colDueDate = New DataGridViewTextBoxColumn()
        colBorrowDate = New DataGridViewTextBoxColumn()
        colTitle = New DataGridViewTextBoxColumn()
        CardAvailable = New Panel()
        CardBorrowed = New Panel()
        CardDueSoon = New Panel()
        dgvBorrowed = New DataGridView()
        CardOverdue = New Panel()
        LabelNoRecords = New Label()
        CardsTable = New TableLayoutPanel()
        PictureBoxHeaderIllustration = New PictureBox()
        LabelTitle = New Label()
        LabelHeaderSub = New Label()
        PanelDgvContainer = New Panel()
        PanelHeader = New Panel()
        CType(dgvBorrowed, ComponentModel.ISupportInitialize).BeginInit()
        CardsTable.SuspendLayout()
        CType(PictureBoxHeaderIllustration, ComponentModel.ISupportInitialize).BeginInit()
        PanelDgvContainer.SuspendLayout()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonViewAll
        ' 
        ButtonViewAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonViewAll.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        ButtonViewAll.FlatStyle = FlatStyle.Flat
        ButtonViewAll.ForeColor = Color.White
        ButtonViewAll.Location = New Point(1658, 12)
        ButtonViewAll.Name = "ButtonViewAll"
        ButtonViewAll.Size = New Size(80, 28)
        ButtonViewAll.TabIndex = 2
        ButtonViewAll.Text = "View All"
        ButtonViewAll.UseVisualStyleBackColor = False
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colDueDate
        ' 
        colDueDate.HeaderText = "Due Date"
        colDueDate.Name = "colDueDate"
        colDueDate.ReadOnly = True
        ' 
        ' colBorrowDate
        ' 
        colBorrowDate.HeaderText = "Borrow Date"
        colBorrowDate.Name = "colBorrowDate"
        colBorrowDate.ReadOnly = True
        ' 
        ' colTitle
        ' 
        colTitle.HeaderText = "Title"
        colTitle.Name = "colTitle"
        colTitle.ReadOnly = True
        ' 
        ' CardAvailable
        ' 
        CardAvailable.BackColor = Color.FromArgb(CByte(232), CByte(246), CByte(255))
        CardAvailable.Location = New Point(3, 3)
        CardAvailable.Name = "CardAvailable"
        CardAvailable.Size = New Size(200, 100)
        CardAvailable.TabIndex = 0
        ' 
        ' CardBorrowed
        ' 
        CardBorrowed.BackColor = Color.FromArgb(CByte(232), CByte(255), CByte(240))
        CardBorrowed.Location = New Point(248, 3)
        CardBorrowed.Name = "CardBorrowed"
        CardBorrowed.Size = New Size(200, 100)
        CardBorrowed.TabIndex = 1
        ' 
        ' CardDueSoon
        ' 
        CardDueSoon.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(232))
        CardDueSoon.Location = New Point(493, 3)
        CardDueSoon.Name = "CardDueSoon"
        CardDueSoon.Size = New Size(200, 100)
        CardDueSoon.TabIndex = 2
        ' 
        ' dgvBorrowed
        ' 
        dgvBorrowed.AllowUserToAddRows = False
        dgvBorrowed.AllowUserToDeleteRows = False
        dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowed.Columns.AddRange(New DataGridViewColumn() {colTitle, colBorrowDate, colDueDate, colStatus})
        dgvBorrowed.Dock = DockStyle.Fill
        dgvBorrowed.Location = New Point(0, 0)
        dgvBorrowed.Name = "dgvBorrowed"
        dgvBorrowed.ReadOnly = True
        dgvBorrowed.Size = New Size(978, 198)
        dgvBorrowed.TabIndex = 0
        ' 
        ' CardOverdue
        ' 
        CardOverdue.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(240))
        CardOverdue.Location = New Point(738, 3)
        CardOverdue.Name = "CardOverdue"
        CardOverdue.Size = New Size(200, 100)
        CardOverdue.TabIndex = 3
        ' 
        ' LabelNoRecords
        ' 
        LabelNoRecords.Dock = DockStyle.Fill
        LabelNoRecords.ForeColor = Color.Gray
        LabelNoRecords.Location = New Point(0, 0)
        LabelNoRecords.Name = "LabelNoRecords"
        LabelNoRecords.Size = New Size(978, 198)
        LabelNoRecords.TabIndex = 1
        LabelNoRecords.Text = "No records found."
        LabelNoRecords.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CardsTable
        ' 
        CardsTable.ColumnCount = 4
        CardsTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        CardsTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        CardsTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        CardsTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        CardsTable.Controls.Add(CardAvailable, 0, 0)
        CardsTable.Controls.Add(CardBorrowed, 1, 0)
        CardsTable.Controls.Add(CardDueSoon, 2, 0)
        CardsTable.Controls.Add(CardOverdue, 3, 0)
        CardsTable.Location = New Point(56, 217)
        CardsTable.Name = "CardsTable"
        CardsTable.RowCount = 1
        CardsTable.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        CardsTable.Size = New Size(980, 120)
        CardsTable.TabIndex = 4
        ' 
        ' PictureBoxHeaderIllustration
        ' 
        PictureBoxHeaderIllustration.BackColor = Color.Transparent
        PictureBoxHeaderIllustration.Dock = DockStyle.Right
        PictureBoxHeaderIllustration.Image = My.Resources.Resources._B9543149_90CB_44F2_AF6A_D00ABB06F425_
        PictureBoxHeaderIllustration.Location = New Point(945, 0)
        PictureBoxHeaderIllustration.Name = "PictureBoxHeaderIllustration"
        PictureBoxHeaderIllustration.Size = New Size(300, 140)
        PictureBoxHeaderIllustration.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxHeaderIllustration.TabIndex = 0
        PictureBoxHeaderIllustration.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(20), CByte(45), CByte(80))
        LabelTitle.Location = New Point(20, 24)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(147, 41)
        LabelTitle.TabIndex = 1
        LabelTitle.Text = "Welcome"
        ' 
        ' LabelHeaderSub
        ' 
        LabelHeaderSub.AutoSize = True
        LabelHeaderSub.Font = New Font("Segoe UI", 10F)
        LabelHeaderSub.ForeColor = Color.DimGray
        LabelHeaderSub.Location = New Point(24, 64)
        LabelHeaderSub.Name = "LabelHeaderSub"
        LabelHeaderSub.Size = New Size(234, 19)
        LabelHeaderSub.TabIndex = 2
        LabelHeaderSub.Text = "Welcome back to the Library System."
        ' 
        ' PanelDgvContainer
        ' 
        PanelDgvContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelDgvContainer.BackColor = Color.White
        PanelDgvContainer.BorderStyle = BorderStyle.FixedSingle
        PanelDgvContainer.Controls.Add(dgvBorrowed)
        PanelDgvContainer.Controls.Add(LabelNoRecords)
        PanelDgvContainer.Controls.Add(ButtonViewAll)
        PanelDgvContainer.Location = New Point(56, 357)
        PanelDgvContainer.Name = "PanelDgvContainer"
        PanelDgvContainer.Size = New Size(980, 200)
        PanelDgvContainer.TabIndex = 3
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(235), CByte(245), CByte(250))
        PanelHeader.Controls.Add(PictureBoxHeaderIllustration)
        PanelHeader.Controls.Add(LabelTitle)
        PanelHeader.Controls.Add(LabelHeaderSub)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1245, 140)
        PanelHeader.TabIndex = 5
        ' 
        ' dashboardcontrol
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CardsTable)
        Controls.Add(PanelDgvContainer)
        Controls.Add(PanelHeader)
        Name = "dashboardcontrol"
        Size = New Size(1245, 629)
        CType(dgvBorrowed, ComponentModel.ISupportInitialize).EndInit()
        CardsTable.ResumeLayout(False)
        CType(PictureBoxHeaderIllustration, ComponentModel.ISupportInitialize).EndInit()
        PanelDgvContainer.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonViewAll As Button
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDueDate As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents CardAvailable As Panel
    Friend WithEvents CardBorrowed As Panel
    Friend WithEvents CardDueSoon As Panel
    Friend WithEvents dgvBorrowed As DataGridView
    Friend WithEvents CardOverdue As Panel
    Friend WithEvents LabelNoRecords As Label
    Friend WithEvents CardsTable As TableLayoutPanel
    Friend WithEvents PictureBoxHeaderIllustration As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelHeaderSub As Label
    Friend WithEvents PanelDgvContainer As Panel
    Friend WithEvents PanelHeader As Panel

End Class
