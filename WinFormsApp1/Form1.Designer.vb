<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Goldenrod
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.Location = New Point(268, 186)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(251, 35)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSION (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.LightBlue
        btnCreateSubmission.FlatStyle = FlatStyle.Flat
        btnCreateSubmission.Location = New Point(268, 244)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(251, 35)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 13F)
        TextBox1.Location = New Point(233, 84)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(371, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Vaibhav Patil,  Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 401)
        Controls.Add(TextBox1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Font = New Font("Segoe UI", 9F)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents TextBox1 As TextBox

End Class
