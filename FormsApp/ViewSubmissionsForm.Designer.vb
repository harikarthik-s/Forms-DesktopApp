<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.githubLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.githubTB = New System.Windows.Forms.TextBox()
        Me.timeTB = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hari Karthik S, Slidely Task 2 - View Submissions"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(62, 181)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(60, 22)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(62, 233)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(57, 22)
        Me.emailLabel.TabIndex = 2
        Me.emailLabel.Text = "Email"
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLabel.Location = New System.Drawing.Point(38, 284)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(109, 22)
        Me.phoneLabel.TabIndex = 3
        Me.phoneLabel.Text = "Phone Num"
        '
        'githubLabel
        '
        Me.githubLabel.AutoEllipsis = True
        Me.githubLabel.AutoSize = True
        Me.githubLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubLabel.Location = New System.Drawing.Point(39, 334)
        Me.githubLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.githubLabel.Name = "githubLabel"
        Me.githubLabel.Size = New System.Drawing.Size(109, 44)
        Me.githubLabel.TabIndex = 4
        Me.githubLabel.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " For Task 2"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(39, 398)
        Me.timeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(103, 44)
        Me.timeLabel.TabIndex = 5
        Me.timeLabel.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'nameTB
        '
        Me.nameTB.BackColor = System.Drawing.SystemColors.Control
        Me.nameTB.Cursor = System.Windows.Forms.Cursors.No
        Me.nameTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTB.Location = New System.Drawing.Point(241, 172)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.ReadOnly = True
        Me.nameTB.Size = New System.Drawing.Size(331, 29)
        Me.nameTB.TabIndex = 6
        Me.nameTB.Text = "John Doe"
        Me.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailTB
        '
        Me.emailTB.BackColor = System.Drawing.SystemColors.Control
        Me.emailTB.Cursor = System.Windows.Forms.Cursors.No
        Me.emailTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTB.Location = New System.Drawing.Point(241, 229)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.ReadOnly = True
        Me.emailTB.Size = New System.Drawing.Size(331, 29)
        Me.emailTB.TabIndex = 7
        Me.emailTB.Text = "johndoes@gmail.com"
        Me.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'phoneTB
        '
        Me.phoneTB.BackColor = System.Drawing.SystemColors.Control
        Me.phoneTB.Cursor = System.Windows.Forms.Cursors.No
        Me.phoneTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTB.Location = New System.Drawing.Point(241, 280)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.ReadOnly = True
        Me.phoneTB.Size = New System.Drawing.Size(331, 29)
        Me.phoneTB.TabIndex = 8
        Me.phoneTB.Text = "9876543210"
        Me.phoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'githubTB
        '
        Me.githubTB.BackColor = System.Drawing.SystemColors.Control
        Me.githubTB.Cursor = System.Windows.Forms.Cursors.No
        Me.githubTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubTB.Location = New System.Drawing.Point(241, 330)
        Me.githubTB.Margin = New System.Windows.Forms.Padding(4)
        Me.githubTB.Multiline = True
        Me.githubTB.Name = "githubTB"
        Me.githubTB.ReadOnly = True
        Me.githubTB.Size = New System.Drawing.Size(331, 53)
        Me.githubTB.TabIndex = 9
        Me.githubTB.Text = "https://www.github.com/john_doe/slidely_task2/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.githubTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timeTB
        '
        Me.timeTB.BackColor = System.Drawing.SystemColors.Control
        Me.timeTB.Cursor = System.Windows.Forms.Cursors.No
        Me.timeTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeTB.Location = New System.Drawing.Point(241, 409)
        Me.timeTB.Margin = New System.Windows.Forms.Padding(4)
        Me.timeTB.Name = "timeTB"
        Me.timeTB.ReadOnly = True
        Me.timeTB.Size = New System.Drawing.Size(331, 29)
        Me.timeTB.TabIndex = 10
        Me.timeTB.Text = "00:01:19"
        Me.timeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrevious.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(26, 487)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(260, 43)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNext.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(312, 487)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(260, 43)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(25, 551)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(260, 43)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "DELETE (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(312, 551)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(260, 43)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "EDIT (CTRL + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'searchTB
        '
        Me.searchTB.AccessibleName = ""
        Me.searchTB.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTB.Location = New System.Drawing.Point(43, 93)
        Me.searchTB.Margin = New System.Windows.Forms.Padding(5)
        Me.searchTB.Name = "searchTB"
        Me.searchTB.Size = New System.Drawing.Size(373, 28)
        Me.searchTB.TabIndex = 15
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(422, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(150, 35)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search "
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(596, 639)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.searchTB)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.timeTB)
        Me.Controls.Add(Me.githubTB)
        Me.Controls.Add(Me.phoneTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.nameTB)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.githubLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewSubmissionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents githubLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents nameTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents githubTB As TextBox
    Friend WithEvents timeTB As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents searchTB As TextBox
    Friend WithEvents btnSearch As Button
End Class
