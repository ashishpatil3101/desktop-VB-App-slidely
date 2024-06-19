<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        TextBox1 = New TextBox()
        lable6 = New Label()
        txtStopWatch = New TextBox()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Goldenrod
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Location = New Point(221, 322)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(140, 34)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Location = New Point(371, 322)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(141, 34)
        btnNext.TabIndex = 1
        btnNext.Text = "NEXT (CTRL+ N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(221, 92)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 3
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(221, 131)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 4
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(221, 175)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(71, 15)
        lblPhone.TabIndex = 5
        lblPhone.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.Location = New Point(221, 220)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(71, 33)
        lblGithubLink.TabIndex = 6
        lblGithubLink.Text = "Github link for task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(348, 89)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(164, 23)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Menu
        txtEmail.Location = New Point(348, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(164, 23)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.Menu
        txtPhone.Location = New Point(348, 172)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(164, 23)
        txtPhone.TabIndex = 9
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.Menu
        txtGithubLink.Location = New Point(348, 217)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(164, 36)
        txtGithubLink.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLightLight
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 13F)
        TextBox1.Location = New Point(205, 25)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(382, 40)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Vaibhav patil ,  Slidely Task 2 -View Submissions"
        ' 
        ' lable6
        ' 
        lable6.AutoSize = True
        lable6.Location = New Point(221, 275)
        lable6.Name = "lable6"
        lable6.Size = New Size(92, 15)
        lable6.TabIndex = 12
        lable6.Text = "Stopwatch Time"
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = SystemColors.Menu
        txtStopWatch.Location = New Point(348, 275)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.Size = New Size(164, 23)
        txtStopWatch.TabIndex = 13
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Sienna
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(221, 371)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(291, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(txtStopWatch)
        Controls.Add(lable6)
        Controls.Add(TextBox1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lable6 As Label
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents btnDelete As Button
End Class

