Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private ReadOnly client As HttpClient
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True
        client = New HttpClient()
        LoadSubmission(currentIndex)
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim submission As JObject = JObject.Parse(content)
                nameTB.Text = submission("name").ToString()
                emailTB.Text = submission("email").ToString()
                phoneTB.Text = submission("phone").ToString()
                githubTB.Text = submission("github_link").ToString()
                timeTB.Text = submission("stopwatch_time").ToString()
                currentIndex = index
            Else
                MessageBox.Show("No more submissions", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        Else
            MessageBox.Show("This is the first submission", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        End If
        If btnEdit.Text = "SAVE (CTRL + S)" AndAlso e.Control AndAlso e.KeyCode = Keys.S Then
            btnEdit.PerformClick()
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim json As String = $"{{""index"":{currentIndex}}}"
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim request As New HttpRequestMessage(HttpMethod.Delete, "http://localhost:3000/delete")
            request.Content = content
            Dim response As HttpResponseMessage = Await client.SendAsync(request)
            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSubmission(currentIndex)
        Catch ex As Exception
            MessageBox.Show("Failed to delete: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT (CTRL + E)" Then
            nameTB.ReadOnly = False
            emailTB.ReadOnly = False
            phoneTB.ReadOnly = False
            githubTB.ReadOnly = False
            timeTB.ReadOnly = True

            nameTB.Cursor = Cursors.IBeam
            emailTB.Cursor = Cursors.IBeam
            phoneTB.Cursor = Cursors.IBeam
            githubTB.Cursor = Cursors.IBeam
            timeTB.Cursor = Cursors.No

            nameTB.Focus()

            btnEdit.Text = "SAVE (CTRL + S)"
        Else
            nameTB.ReadOnly = True
            emailTB.ReadOnly = True
            phoneTB.ReadOnly = True
            githubTB.ReadOnly = True
            timeTB.ReadOnly = True

            nameTB.Cursor = Cursors.No
            emailTB.Cursor = Cursors.No
            phoneTB.Cursor = Cursors.No
            githubTB.Cursor = Cursors.No
            timeTB.Cursor = Cursors.No

            Dim name As String = nameTB.Text
            Dim email As String = emailTB.Text
            Dim phone As String = phoneTB.Text
            Dim githubLink As String = githubTB.Text
            Dim stopwatchTime As String = timeTB.Text

            Dim json As String = $"{{""index"":{currentIndex},""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{githubLink}"",""stopwatch_time"":""{stopwatchTime}""}}"
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Try
                Dim response As HttpResponseMessage = Await client.PutAsync("http://localhost:3000/edit", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Failed to edit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            btnEdit.Text = "EDIT (CTRL + E)"
        End If
    End Sub
    Private Sub searchTB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchTB.GotFocus
        searchTB.Text = ""
    End Sub
    Private Sub searchTB_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchTB.LostFocus
        If searchTB.Text = "" Then
            searchTB.Text = "Search By Email"
        End If
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = searchTB.Text

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/search?email={email}")
            response.EnsureSuccessStatusCode()
            Dim content As String = Await response.Content.ReadAsStringAsync()
            Dim submissions As JArray = JArray.Parse(content)
            If submissions.Count > 0 Then
                Dim submission As JObject = submissions(0)
                nameTB.Text = submission("name").ToString()
                emailTB.Text = submission("email").ToString()
                phoneTB.Text = submission("phone").ToString()
                githubTB.Text = submission("github_link").ToString()
                timeTB.Text = submission("stopwatch_time").ToString()
            Else
                MessageBox.Show("No results found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class