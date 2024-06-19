<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnSave = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        lblTimer = New TextBox()
        Timer = New Timer(components)
        btnToggle = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(225, 353)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(283, 35)
        btnSave.TabIndex = 1
        btnSave.Text = "SUBMIT (CTRL + S)"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(225, 105)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 3
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(228, 152)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(225, 197)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(41, 15)
        lblPhone.TabIndex = 5
        lblPhone.Text = "Phone"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.Location = New Point(225, 240)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(76, 40)
        lblGithubLink.TabIndex = 6
        lblGithubLink.Text = "Github Link For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(344, 102)
        txtName.Name = "txtName"
        txtName.Size = New Size(164, 23)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(344, 149)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(164, 23)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(344, 194)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(164, 23)
        txtPhone.TabIndex = 9
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(344, 240)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(164, 36)
        txtGithubLink.TabIndex = 10
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = SystemColors.MenuBar
        lblTimer.Location = New Point(424, 295)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(84, 23)
        lblTimer.TabIndex = 11
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.Goldenrod
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Location = New Point(225, 295)
        btnToggle.Margin = New Padding(0, 3, 3, 0)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(193, 23)
        btnToggle.TabIndex = 13
        btnToggle.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 13F)
        TextBox1.Location = New Point(201, 30)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(382, 40)
        TextBox1.TabIndex = 14
        TextBox1.Text = "Vaibhav Patil,  Slidely Task 2 - Create Submission"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(btnToggle)
        Controls.Add(lblTimer)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnSave)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblTimer As TextBox
    Friend WithEvents btnToggle As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
