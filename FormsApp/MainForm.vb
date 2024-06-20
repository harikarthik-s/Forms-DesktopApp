Public Class MainForm
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Dim viewForm As New ViewSubmissionsForm()
            viewForm.Show()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Dim createForm As New CreateSubmissionForm()
            createForm.Show()
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.KeyPreview = True
        ' Add any initialization after the InitializeComponent() call.
    End Sub
End Class
