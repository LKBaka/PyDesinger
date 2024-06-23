Public Class Frm
    Public Function NewControl(control As String, x As Long, y As Long, size As List(Of Long), text As String, name As String) As Object
        Dim Control_ = Nothing
        If control = "按钮" Then
            Control_ = New Button
            With Control_
                .Location = New Point(x, y)
                .Size = New Size(size(0), size(1))
                .Text = text
                .Name = name

            End With
        ElseIf control = "文本框" Then
            Control_ = New TextBox

            With Control_
                .Location = New Point(x, y)
                .Size = New Size(size(0), size(1))
                .Text = text
                .Name = name

            End With
        ElseIf control = "标签" Then
            Control_ = New Label

            With Control_
                .Location = New Point(x, y)
                .Size = New Size(size(0), size(1))
                .Text = text
                .Name = name

            End With
        End If

        Return Control_
    End Function
End Class
