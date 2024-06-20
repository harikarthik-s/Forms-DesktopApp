Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Public Class CreateSubmissionForm
    Dim ss, tt, vv As Integer
    Private client As HttpClient
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True

        client = New HttpClient()
    End Sub
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            Timer1.Enabled = Not Timer1.Enabled
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = nameTB.Text
        Dim email As String = emailTB.Text
        Dim phone As String = phoneTB.Text
        Dim githubLink As String = githubTB.Text
        Dim stopwatchTime As String = timerLabel.Text
        Timer1.Enabled = Not Timer1.Enabled

        Dim json As String = $"{{""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{githubLink}"",""stopwatch_time"":""{stopwatchTime}""}}"
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to submit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerLabel.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If tt > 59 Then
            tt = 0
            ss = ss + 1
        End If


    End Sub
End Class