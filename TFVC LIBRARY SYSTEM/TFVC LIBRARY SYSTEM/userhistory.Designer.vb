<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userhistory
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
        dgvHistory = New DataGridView()
        hColTitle = New DataGridViewTextBoxColumn()
        hColBorrowDate = New DataGridViewTextBoxColumn()
        hColReturnDate = New DataGridViewTextBoxColumn()
        hColStatus = New DataGridViewTextBoxColumn()
        txtSearchHistory = New TextBox()
        lblSearchHistory = New Label()
        lblHistoryTitle = New Label()
        dgvBorrowedBooks = New DataGridView()
        lblTitle = New Label()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AllowUserToDeleteRows = False
        dgvHistory.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {hColTitle, hColBorrowDate, hColReturnDate, hColStatus})
        dgvHistory.Location = New Point(242, 391)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.ReadOnly = True
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.Size = New Size(760, 138)
        dgvHistory.TabIndex = 11
        ' 
        ' hColTitle
        ' 
        hColTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hColTitle.HeaderText = "Book Title"
        hColTitle.Name = "hColTitle"
        hColTitle.ReadOnly = True
        ' 
        ' hColBorrowDate
        ' 
        hColBorrowDate.HeaderText = "Borrow Date"
        hColBorrowDate.Name = "hColBorrowDate"
        hColBorrowDate.ReadOnly = True
        hColBorrowDate.Width = 120
        ' 
        ' hColReturnDate
        ' 
        hColReturnDate.HeaderText = "Return Date"
        hColReturnDate.Name = "hColReturnDate"
        hColReturnDate.ReadOnly = True
        hColReturnDate.Width = 120
        ' 
        ' hColStatus
        ' 
        hColStatus.HeaderText = "Status"
        hColStatus.Name = "hColStatus"
        hColStatus.ReadOnly = True
        hColStatus.Width = 150
        ' 
        ' txtSearchHistory
        ' 
        txtSearchHistory.Location = New Point(295, 357)
        txtSearchHistory.Name = "txtSearchHistory"
        txtSearchHistory.Size = New Size(240, 23)
        txtSearchHistory.TabIndex = 10
        ' 
        ' lblSearchHistory
        ' 
        lblSearchHistory.AutoSize = True
        lblSearchHistory.Location = New Point(242, 361)
        lblSearchHistory.Name = "lblSearchHistory"
        lblSearchHistory.Size = New Size(45, 15)
        lblSearchHistory.TabIndex = 9
        lblSearchHistory.Text = "Search:"
        ' 
        ' lblHistoryTitle
        ' 
        lblHistoryTitle.AutoSize = True
        lblHistoryTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblHistoryTitle.Location = New Point(242, 331)
        lblHistoryTitle.Name = "lblHistoryTitle"
        lblHistoryTitle.Size = New Size(179, 21)
        lblHistoryTitle.TabIndex = 8
        lblHistoryTitle.Text = "BORROWING HISTORY"
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.AllowUserToAddRows = False
        dgvBorrowedBooks.AllowUserToDeleteRows = False
        dgvBorrowedBooks.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Location = New Point(242, 141)
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.ReadOnly = True
        dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBorrowedBooks.Size = New Size(760, 180)
        dgvBorrowedBooks.TabIndex = 7
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitle.Location = New Point(242, 100)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(210, 25)
        lblTitle.TabIndex = 6
        lblTitle.Text = "CURRENT BORROWED"
        ' 
        ' userhistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvHistory)
        Controls.Add(txtSearchHistory)
        Controls.Add(lblSearchHistory)
        Controls.Add(lblHistoryTitle)
        Controls.Add(dgvBorrowedBooks)
        Controls.Add(lblTitle)
        Name = "userhistory"
        Size = New Size(1245, 629)
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents hColTitle As DataGridViewTextBoxColumn
    Friend WithEvents hColBorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents hColReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents hColStatus As DataGridViewTextBoxColumn
    Friend WithEvents txtSearchHistory As TextBox
    Friend WithEvents lblSearchHistory As Label
    Friend WithEvents lblHistoryTitle As Label
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents lblTitle As Label

End Class
