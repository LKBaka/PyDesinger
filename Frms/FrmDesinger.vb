Imports System.Reflection
Imports PyDesigner.Win32API

Public Class FrmDesinger
    Public WithEvents Frm As New Form
    Public control_type = ""
    Public controls_ As New List(Of Control)
    Public WithEvents control_ As New Control
    Public attribute_CN_EN As New Dictionary(Of String, String) From
    {
        {"名称", "Name"},
        {"文本", "Text"},
        {"位置", "Location"},
        {"大小", "Size"}
    }
    Public selControl = New Control
    Public Sub New(mode As String)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        If mode = "write" Then
            Frm = New Form
            With Frm
                .FormBorderStyle = FormBorderStyle.FixedSingle
            End With
        End If
    End Sub

    Private Sub FrmDesinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm.Show()
        Frm.Location = New Point(Width - Width / 1.5, Height - Height / 1.5)

        SetParent(Frm.Handle, Handle)
    End Sub

    Private Sub ToolBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ToolBox.SelectedIndexChanged
        control_type = ToolBox.Items.Item(ToolBox.SelectedIndex)
        Debug.Print(ToolBox.Items.Item(ToolBox.SelectedIndex))
    End Sub

    Private Sub Frm_Click(sender As Object, e As MouseEventArgs) Handles Frm.MouseDown
        Debug.Print("down")
        Dim F As New Frm()
        Dim r As New Random
        Debug.Print(control_type)
        control_ = F.NewControl(control_type, e.X, e.Y, {64, CLng(64)}.ToList, control_type, $"{control_type}{CStr(r.Next)}")

        Frm.Controls.Add(control_)
        controls_.Add(control_)
        If control_ IsNot Nothing Then
            AddHandler control_.Click, AddressOf ControlClickHandler
        End If
    End Sub

    Public Sub ControlClickHandler(sender As Object, e As EventArgs)
        Dim anyCtrl As Object = sender
        selControl = anyCtrl
        Debug.Print(anyCtrl.GetType.Name)
        If anyCtrl IsNot Nothing Then
            attributeView.Rows.Clear()
            attributeView.Rows.Add("名称", anyCtrl.Name)
            attributeView.Rows.Add("文本", anyCtrl.Text)
            attributeView.Rows.Add("位置", $"{anyCtrl.Location.X},{anyCtrl.Location.Y}")
            attributeView.Rows.Add("大小", $"{anyCtrl.Size.Width},{anyCtrl.Size.Height}")

        End If
    End Sub

    Private Sub attributeView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles attributeView.CellValueChanged
        If Not Me.attributeView.IsCurrentCellDirty Then Exit Sub

        ' 获取被修改的单元格的值  
        Dim attributeNewValue As String = Me.attributeView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim attributeName As String = attribute_CN_EN(attributeView.Rows(e.RowIndex).Cells(0).Value)
        Debug.Print(selControl.Location.GetType.FullName )
        '修改control值
        If attributeName = "Size" Then
            '分割 , 并转为 Size 类型
            Dim size As New Size(CInt(attributeNewValue.Split(",")(0)), CInt(attributeNewValue.Split(",")(0)))
            selControl.GetType().GetProperty(attributeName).SetValue(selControl, size)
        ElseIf attributeName = "Location" Then
            Dim point As New Point(CInt(attributeNewValue.Split(",")(0)), CInt(attributeNewValue.Split(",")(0)))
            selControl.GetType().GetProperty(attributeName).SetValue(selControl, point)
        Else
            selControl.GetType().GetProperty(attributeName).SetValue(selControl, attributeNewValue)
        End If
        controls_(controls_.IndexOf(selControl)) = selControl
        Frm.Controls.Remove(selControl)
        Frm.Controls.Add(selControl)
    End Sub
End Class