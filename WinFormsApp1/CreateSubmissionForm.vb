Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class CreateSubmissionForm

    Private WithEvents stopwatch As New Stopwatch()
    Private WithEvents uiTimer As New Timer()
    Private httpClient As HttpClient = New HttpClient()
    Private stopwatchRunning As Boolean = False
    Private lastElapsed As TimeSpan = TimeSpan.Zero

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uiTimer.Interval = 100 ' Update UI every 100 milliseconds (adjust as needed)
        uiTimer.Start()
        ' Set the form's KeyPreview property to true to capture key events before they are passed to the controls
        Me.KeyPreview = True
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If Not stopwatchRunning Then
            ' Start or resume the stopwatch
            stopwatch.Start()
            stopwatchRunning = True
        Else
            ' Stop the stopwatch
            stopwatch.Stop()
            lastElapsed = stopwatch.Elapsed
            stopwatchRunning = False
        End If

        UpdateToggleButtonLabel()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSubmission()
    End Sub

    Private Sub SaveSubmission()
        ' Check if all fields are filled
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtPhone.Text) Or String.IsNullOrEmpty(txtGithubLink.Text) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate phone number
        If Not Regex.IsMatch(txtPhone.Text, "^\d+$") Then
            MessageBox.Show("Phone number should contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate email address
        If Not Regex.IsMatch(txtEmail.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Invalid email address format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = If(stopwatchRunning, FormatTimeSpan(stopwatch.Elapsed), FormatTimeSpan(lastElapsed))
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response = httpClient.PostAsync("http://localhost:3000/submit", content).Result
            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission saved successfully.")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Failed to save submission. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithubLink.Clear()
        stopwatch.Reset()
        lastElapsed = TimeSpan.Zero
        UpdateTimerLabel()
    End Sub

    Private Sub uiTimer_Tick(sender As Object, e As EventArgs) Handles uiTimer.Tick
        UpdateTimerLabel()
    End Sub

    Private Sub UpdateToggleButtonLabel()
        btnToggle.Text = If(stopwatchRunning, "TOGGLE STOPWATCH (CTRL + T )", "TOGGLE STOPWATCH (CTRL + T )")
    End Sub

    Private Sub UpdateTimerLabel()
        lblTimer.Text = If(stopwatchRunning, FormatTimeSpan(stopwatch.Elapsed), FormatTimeSpan(lastElapsed))
    End Sub

    Private Function FormatTimeSpan(ts As TimeSpan) As String
        ' Custom format for TimeSpan without milliseconds
        Return $"{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}"
    End Function

    Private Sub CreateSubmissionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        httpClient.Dispose() ' Dispose HttpClient when form is closed
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SaveSubmission()
            e.SuppressKeyPress = True ' Prevent the default action of the key press
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
            e.SuppressKeyPress = True ' Prevent the default action of the key press
        End If
    End Sub
End Class
