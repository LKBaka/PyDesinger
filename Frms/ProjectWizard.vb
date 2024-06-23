
Public Class ProjectWizard
    Private Sub BroswerFolder_Click(sender As Object, e As EventArgs) Handles BroswerFolder.Click
        Dim broswer As New FolderBrowserDialog
        If broswer.ShowDialog = DialogResult.OK Then
            PathBox.Text = broswer.SelectedPath
        End If
    End Sub

    Private Sub NewProjectBtn_Click(sender As Object, e As EventArgs) Handles NewProjectBtn.Click
        Dim p As New Project(PathBox.Text, PrjNameBox.Text)
        Dim fd As New FrmDesinger("write")
        fd.Show()
        Close()
    End Sub
End Class