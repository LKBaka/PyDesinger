Imports System.IO

Public Class Project
    Public projectName
    Public Sub New()
    End Sub
    Public Sub New(prjPath As String, prjName As String)
        If Directory.Exists(prjPath & prjName) Then
            MsgBox($"项目{prjName}已存在！", MsgBoxStyle.Information, "PyDesinger")
        Else
            Directory.CreateDirectory(prjPath & "\" & prjName)
            Dim f = File.Create($"{prjPath}\{prjName}\{prjName}.pyPrj")
            f.Close()

            Using sw As New StreamWriter($"{prjPath}\{prjName}\{prjName}.pyPrj")
                Dim writeText As String
                writeText =
                $"ProjectName={prjName}"
                sw.Write(writeText)
            End Using
        End If
    End Sub

End Class
