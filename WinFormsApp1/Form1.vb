Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable the form to receive key events before the focused control
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        OpenViewSubmissionsForm()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        OpenCreateSubmissionForm()
    End Sub

    Private Sub OpenViewSubmissionsForm()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub OpenCreateSubmissionForm()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Handle key events for shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    OpenViewSubmissionsForm()
                Case Keys.N
                    OpenCreateSubmissionForm()
            End Select
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Your code here (if needed)
    End Sub
End Class
