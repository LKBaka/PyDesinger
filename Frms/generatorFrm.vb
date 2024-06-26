Imports System.IO
Imports System.Text
Imports System.Threading

Public Class generatorFrm
    Public generatorForm As Form

    Public Sub New(f As Form)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        generatorForm = f
    End Sub
    Private Async Sub generatorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        generatorIngLbl.Text = "生成中..."

        For 进度 = 0 To 99
            PBar1.Value = 进度
            Thread.Sleep(10)
        Next
        Dim clsFrm As New Frm()
        Dim result = Await clsFrm.ConvertToPythonTk(generatorForm)
        Debug.Print(result)

        PBar1.Value = 100
        generatorIngLbl.Text = "生成完成,请选择保存" & generatorForm.Name & "的路径"
        Dim folderBrower = New FolderBrowserDialog
        If folderBrower.ShowDialog = DialogResult.OK Then
            Dim path As String = folderBrower.SelectedPath
            Using sw As New StreamWriter($"{path}\{generatorForm.Name}.py", False, Encoding.UTF8)
                sw.Write(result)
            End Using

            MsgBox("操作已完成！正在退出")
        End If

        Close()
    End Sub

    Private Sub generatorFrm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class