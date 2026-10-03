<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userbrowsebooks
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
        dgvBooks = New DataGridView()
        colBookID = New DataGridViewTextBoxColumn()
        colCover = New DataGridViewImageColumn()
        colTitle = New DataGridViewTextBoxColumn()
        colAuthor = New DataGridViewTextBoxColumn()
        colCategory = New DataGridViewTextBoxColumn()
        colShelf = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        grpAvailability = New GroupBox()
        rbAvailableOnly = New RadioButton()
        rbAll = New RadioButton()
        cbCategory = New ComboBox()
        txtSearch = New TextBox()
        lblTitle = New Label()
        btnViewDetails = New Button()
        btnRequest = New Button()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        grpAvailability.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvBooks
        ' 
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Columns.AddRange(New DataGridViewColumn() {colBookID, colCover, colTitle, colAuthor, colCategory, colShelf, colStatus})
        dgvBooks.Location = New Point(18, 78)
        dgvBooks.MultiSelect = False
        dgvBooks.Name = "dgvBooks"
        dgvBooks.ReadOnly = True
        dgvBooks.RowTemplate.Height = 60
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBooks.Size = New Size(812, 280)
        dgvBooks.TabIndex = 12
        ' 
        ' colBookID
        ' 
        colBookID.HeaderText = "Book ID"
        colBookID.Name = "colBookID"
        colBookID.ReadOnly = True
        colBookID.Width = 60
        ' 
        ' colCover
        ' 
        colCover.HeaderText = "Cover"
        colCover.Name = "colCover"
        colCover.ReadOnly = True
        colCover.Width = 60
        ' 
        ' colTitle
        ' 
        colTitle.HeaderText = "Title"
        colTitle.Name = "colTitle"
        colTitle.ReadOnly = True
        colTitle.Width = 200
        ' 
        ' colAuthor
        ' 
        colAuthor.HeaderText = "Author"
        colAuthor.Name = "colAuthor"
        colAuthor.ReadOnly = True
        colAuthor.Width = 140
        ' 
        ' colCategory
        ' 
        colCategory.HeaderText = "Category"
        colCategory.Name = "colCategory"
        colCategory.ReadOnly = True
        colCategory.Width = 120
        ' 
        ' colShelf
        ' 
        colShelf.HeaderText = "Shelf Location"
        colShelf.Name = "colShelf"
        colShelf.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 90
        ' 
        ' grpAvailability
        ' 
        grpAvailability.Controls.Add(rbAvailableOnly)
        grpAvailability.Controls.Add(rbAll)
        grpAvailability.Location = New Point(590, 11)
        grpAvailability.Name = "grpAvailability"
        grpAvailability.Size = New Size(180, 46)
        grpAvailability.TabIndex = 11
        grpAvailability.TabStop = False
        grpAvailability.Text = "Availability"
        ' 
        ' rbAvailableOnly
        ' 
        rbAvailableOnly.AutoSize = True
        rbAvailableOnly.Location = New Point(75, 17)
        rbAvailableOnly.Name = "rbAvailableOnly"
        rbAvailableOnly.Size = New Size(99, 19)
        rbAvailableOnly.TabIndex = 1
        rbAvailableOnly.Text = "Available only"
        rbAvailableOnly.UseVisualStyleBackColor = True
        ' 
        ' rbAll
        ' 
        rbAll.AutoSize = True
        rbAll.Checked = True
        rbAll.Location = New Point(15, 20)
        rbAll.Name = "rbAll"
        rbAll.Size = New Size(39, 19)
        rbAll.TabIndex = 0
        rbAll.TabStop = True
        rbAll.Text = "All"
        rbAll.UseVisualStyleBackColor = True
        ' 
        ' cbCategory
        ' 
        cbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategory.FormattingEnabled = True
        cbCategory.Items.AddRange(New Object() {"All Categories", "Fiction", "Computer Science", "History", "General Reference"})
        cbCategory.Location = New Point(404, 39)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(180, 23)
        cbCategory.TabIndex = 10
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(18, 39)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by Title, Author, or ISBN"
        txtSearch.Size = New Size(380, 23)
        txtSearch.TabIndex = 9
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTitle.Location = New Point(18, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(164, 25)
        lblTitle.TabIndex = 8
        lblTitle.Text = "📚 Browse Books"
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnViewDetails.Location = New Point(717, 364)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(106, 27)
        btnViewDetails.TabIndex = 14
        btnViewDetails.Text = "View Details"
        btnViewDetails.UseVisualStyleBackColor = True
        ' 
        ' btnRequest
        ' 
        btnRequest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRequest.Location = New Point(605, 364)
        btnRequest.Name = "btnRequest"
        btnRequest.Size = New Size(106, 27)
        btnRequest.TabIndex = 13
        btnRequest.Text = "Request/Reserve"
        btnRequest.UseVisualStyleBackColor = True
        ' 
        ' userbrowsebooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvBooks)
        Controls.Add(grpAvailability)
        Controls.Add(cbCategory)
        Controls.Add(txtSearch)
        Controls.Add(lblTitle)
        Controls.Add(btnViewDetails)
        Controls.Add(btnRequest)
        Name = "userbrowsebooks"
        Size = New Size(1245, 629)
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        grpAvailability.ResumeLayout(False)
        grpAvailability.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBooks As DataGridView
    Private WithEvents colBookID As DataGridViewTextBoxColumn
    Private WithEvents colCover As DataGridViewImageColumn
    Private WithEvents colTitle As DataGridViewTextBoxColumn
    Private WithEvents colAuthor As DataGridViewTextBoxColumn
    Private WithEvents colCategory As DataGridViewTextBoxColumn
    Private WithEvents colShelf As DataGridViewTextBoxColumn
    Private WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents grpAvailability As GroupBox
    Friend WithEvents rbAvailableOnly As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnRequest As Button

End Class
