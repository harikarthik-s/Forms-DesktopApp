<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.githubTB = New System.Windows.Forms.TextBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.githubLabel = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'githubTB
        '
        Me.githubTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.githubTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubTB.Location = New System.Drawing.Point(203, 262)
        Me.githubTB.Margin = New System.Windows.Forms.Padding(4)
        Me.githubTB.Name = "githubTB"
        Me.githubTB.Size = New System.Drawing.Size(304, 29)
        Me.githubTB.TabIndex = 18
        Me.githubTB.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.githubTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'phoneTB
        '
        Me.phoneTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.phoneTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTB.Location = New System.Drawing.Point(203, 209)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(304, 29)
        Me.phoneTB.TabIndex = 17
        Me.phoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailTB
        '
        Me.emailTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.emailTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTB.Location = New System.Drawing.Point(203, 155)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(4)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(304, 29)
        Me.emailTB.TabIndex = 16
        Me.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nameTB
        '
        Me.nameTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nameTB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTB.Location = New System.Drawing.Point(203, 100)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(4)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(304, 29)
        Me.nameTB.TabIndex = 15
        Me.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'githubLabel
        '
        Me.githubLabel.AutoEllipsis = True
        Me.githubLabel.AutoSize = True
        Me.githubLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.githubLabel.Location = New System.Drawing.Point(23, 265)
        Me.githubLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.githubLabel.Name = "githubLabel"
        Me.githubLabel.Size = New System.Drawing.Size(109, 44)
        Me.githubLabel.TabIndex = 14
        Me.githubLabel.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " For Task 2"
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLabel.Location = New System.Drawing.Point(21, 212)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(109, 22)
        Me.phoneLabel.TabIndex = 13
        Me.phoneLabel.Text = "Phone Num"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(45, 158)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(57, 22)
        Me.emailLabel.TabIndex = 12
        Me.emailLabel.Text = "Email"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(45, 103)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(60, 22)
        Me.nameLabel.TabIndex = 11
        Me.nameLabel.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hari Karthik S, Slidely Task 2 - Create Submission"
        '
        'btnToggle
        '
        Me.btnToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnToggle.Location = New System.Drawing.Point(27, 353)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(329, 33)
        Me.btnToggle.TabIndex = 19
        Me.btnToggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggle.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(26, 421)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(481, 43)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.BackColor = System.Drawing.SystemColors.Control
        Me.timerLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(413, 353)
        Me.timerLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Padding = New System.Windows.Forms.Padding(3)
        Me.timerLabel.Size = New System.Drawing.Size(94, 29)
        Me.timerLabel.TabIndex = 21
        Me.timerLabel.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(553, 488)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.githubTB)
        Me.Controls.Add(Me.phoneTB)
        Me.Controls.Add(Me.emailTB)
        Me.Controls.Add(Me.nameTB)
        Me.Controls.Add(Me.githubLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreateSubmissionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents githubTB As TextBox
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents emailTB As TextBox
    Friend WithEvents nameTB As TextBox
    Friend WithEvents githubLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents timerLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
