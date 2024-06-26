Public Class MainFrm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = "PyDesinger - B站ChenXiaoThi"
        版权声明.Text = "B站ChenXiaoThi"
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub NewProjectBtn_Click(sender As Object, e As EventArgs) Handles NewProjectBtn.Click
        ProjectWizard.Show()
        Close()
    End Sub

    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        Application.Exit()
    End Sub
End Class