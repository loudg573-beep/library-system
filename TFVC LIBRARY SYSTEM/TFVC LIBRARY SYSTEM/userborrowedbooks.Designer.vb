<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userborrowedbooks
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
        dgvBorrowedBooks = New DataGridView()
        colTitle = New DataGridViewTextBoxColumn()
        colAuthor = New DataGridViewTextBoxColumn()
        colBorrowDate = New DataGridViewTextBoxColumn()
        colDueDate = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colDaysRemaining = New DataGridViewTextBoxColumn()
        lblTitle = New Label()
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBorrowedBooks
        ' 
        dgvBorrowedBooks.AllowUserToAddRows = False
        dgvBorrowedBooks.AllowUserToDeleteRows = False
        dgvBorrowedBooks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowedBooks.Columns.AddRange(New DataGridViewColumn() {colTitle, colAuthor, colBorrowDate, colDueDate, colStatus, colDaysRemaining})
        dgvBorrowedBooks.Location = New Point(242, 141)
        dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        dgvBorrowedBooks.ReadOnly = True
        dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBorrowedBooks.Size = New Size(760, 388)
        dgvBorrowedBooks.TabIndex = 3
        ' 
        ' colTitle
        ' 
        colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colTitle.HeaderText = "Book Title"
        colTitle.Name = "colTitle"
        colTitle.ReadOnly = True
        ' 
        ' colAuthor
        ' 
        colAuthor.HeaderText = "Author"
        colAuthor.Name = "colAuthor"
        colAuthor.ReadOnly = True
        colAuthor.Width = 150
        ' 
        ' colBorrowDate
        ' 
        colBorrowDate.HeaderText = "Borrow Date"
        colBorrowDate.Name = "colBorrowDate"
        colBorrowDate.ReadOnly = True
        colBorrowDate.Width = 110
        ' 
        ' colDueDate
        ' 
        colDueDate.HeaderText = "Due Date"
        colDueDate.Name = "colDueDate"
        colDueDate.ReadOnly = True
        colDueDate.Width = 110
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colDaysRemaining
        ' 
        colDaysRemaining.HeaderText = "Days Remaining"
        colDaysRemaining.Name = "colDaysRemaining"
        colDaysRemaining.ReadOnly = True
        colDaysRemaining.Width = 120
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitle.Location = New Point(242, 100)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(222, 25)
        lblTitle.TabIndex = 2
        lblTitle.Text = "MY BORROWED BOOKS"
        ' 
        ' userborrowedbooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvBorrowedBooks)
        Controls.Add(lblTitle)
        Name = "userborrowedbooks"
        Size = New Size(1245, 629)
        CType(dgvBorrowedBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents colDueDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDaysRemaining As DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As Label

End Class
