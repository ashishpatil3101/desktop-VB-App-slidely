Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private httpClient As HttpClient = New HttpClient()
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission) = New List(Of Submission)

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "View Submissions"
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnNext.Text = "NEXT (CTRL + N)"
        btnDelete.Text = "DELETE (CTRL + D)"
        btnPrevious.BackColor = Color.Goldenrod
        btnNext.BackColor = Color.LightBlue
        btnDelete.BackColor = Color.Sienna
        Me.KeyPreview = True

        AddHandler btnPrevious.Click, AddressOf btnPrevious_Click
        AddHandler btnNext.Click, AddressOf btnNext_Click
        AddHandler btnDelete.Click, AddressOf btnDelete_Click

        Await LoadAllSubmissions()

        ' Check if there are submissions to display
        If submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No submissions found.")
            Me.Close() ' Close the form if there are no submissions
        End If
    End Sub

    Private Async Function LoadAllSubmissions() As Task
        Dim index As Integer = 0
        Dim submission As Submission

        Do
            Try
                Dim response = Await httpClient.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim responseData = Await response.Content.ReadAsStringAsync()
                    submission = JsonConvert.DeserializeObject(Of Submission)(responseData)
                    submissions.Add(submission)
                    index += 1
                Else
                    Exit Do
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading submissions: " & ex.Message)
                Exit Do
            End Try
        Loop While True
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopWatch.Text = submission.StopwatchTime
        Else
            ClearFields()
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithubLink.Clear()
        txtStopWatch.Clear()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submissionToDelete = submissions(currentIndex)

            ' Call backend API to delete submission
            Try
                Dim response = httpClient.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}").Result
                response.EnsureSuccessStatusCode()

                ' Remove submission from local list
                submissions.RemoveAt(currentIndex)

                ' Display next submission after deletion
                If currentIndex >= submissions.Count Then
                    currentIndex = submissions.Count - 1
                End If

                ' If there are no submissions left, close the form
                If submissions.Count = 0 Then
                    MessageBox.Show("Submission deleted successfully.")
                    MessageBox.Show("No submissions found.")
                    Me.Close()
                Else
                    DisplaySubmission(currentIndex)
                    MessageBox.Show("Submission deleted successfully.")
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to delete submission. Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class
End Class



