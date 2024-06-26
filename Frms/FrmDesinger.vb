Imports System.ComponentModel
Imports System.Reflection
Imports PyDesigner.Win32API

Public Class FrmDesinger
    Public WithEvents Frm As New Form
    Public control_type = ""
    Public controls_ As New List(Of Control)
    Public WithEvents control_ As New Control

    Public selControl = New Control
    Public MouseDown_ As Boolean = False
    Private dragStartPoint As Point = Point.Empty
    Public f As New Frm
    Public Sub New(mode As String)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        If mode = "write" Then
            Frm = New Form
            Dim r As New Random
            With Frm
                .Name = $"Form{r.Next}"
                .Text = $"Form{r.Next}"

            End With
            Frm.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).SetValue(Frm, True, Nothing)
        End If
    End Sub

    Private Sub FrmDesinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm.Show()
        Frm.Location = New Point(Width - Width / 1.5, Height - Height / 1.5)

        SetParent(Frm.Handle, Panel1.Handle)
    End Sub

    Private Sub ToolBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ToolBox.SelectedIndexChanged
        control_type = ToolBox.Items.Item(ToolBox.SelectedIndex)
        Debug.Print(ToolBox.Items.Item(ToolBox.SelectedIndex))
    End Sub

    Private Sub Frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Frm.MouseDown
        Debug.Print("down")
        Dim r As New Random
        Debug.Print(control_type)
        control_ = F.NewControl(control_type, e.X, e.Y, {64, CLng(64)}.ToList, control_type, $"{control_type}{CStr(r.Next)}")

        Frm.Controls.Add(control_)
        controls_.Add(control_)
        If control_ IsNot Nothing Then
            AddHandler control_.Click, AddressOf ControlClickHandler
            AddHandler control_.MouseDown, AddressOf ControlMouseDownHandler
            AddHandler control_.MouseUp, AddressOf ControlMouseUpHandler
            AddHandler control_.MouseMove, AddressOf ControlMouseMoveHandler

        End If
        AddHandler Frm.Click, AddressOf ControlClickHandler
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
    Public Sub ControlMouseDownHandler(sender As Object, e As MouseEventArgs)
        Dim anyCtrl As Object = sender
        selControl = anyCtrl
        Debug.Print(anyCtrl.GetType.Name)
        If anyCtrl IsNot Nothing Then
            MouseDown_ = True
            dragStartPoint = Me.PointToClient(Cursor.Position) ' 记录鼠标按下时的屏幕位置转换为窗体坐标 
        End If
    End Sub

    Public Sub ControlMouseUpHandler(sender As Object, e As MouseEventArgs)
        Dim anyCtrl As Object = sender
        selControl = anyCtrl
        Debug.Print(anyCtrl.GetType.Name)
        If anyCtrl IsNot Nothing Then
            MouseDown_ = False
        End If
    End Sub

    Public Sub ControlMouseMoveHandler(sender As Object, e As MouseEventArgs)
        Dim anyCtrl As Object = sender
        selControl = anyCtrl
        Debug.Print(anyCtrl.GetType.Name)
        If anyCtrl IsNot Nothing Then
            If MouseDown_ Then
                Dim diff As Point = Me.PointToClient(Cursor.Position) - dragStartPoint
                selControl.Left += diff.X
                selControl.Top += diff.Y
                ' 更新dragStartPoint以便下一次计算  
                dragStartPoint = Me.PointToClient(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub attributeView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles attributeView.CellValueChanged
        If Not Me.attributeView.IsCurrentCellDirty Then Exit Sub

        ' 获取被修改的单元格的值  
        Dim attributeNewValue As String = Me.attributeView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim attributeName As String = f.attribute_CN_EN(attributeView.Rows(e.RowIndex).Cells(0).Value)
        Debug.Print(selControl.Location.GetType.FullName)
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

        If selControl IsNot Frm Then
            controls_(controls_.IndexOf(selControl)) = selControl
            Frm.Controls.Remove(selControl)
            Frm.Controls.Add(selControl)
        End If

    End Sub

    Private Sub Frm_Closing(sender As Object, e As CancelEventArgs) Handles Frm.Closing

    End Sub

    Private Sub 转PythonTkinkerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 转PythonTkinkerToolStripMenuItem.Click
        Dim f As New generatorFrm(Frm)
        f.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 编写事件代码ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编写事件代码ToolStripMenuItem.Click

    End Sub

    Private Sub FrmDesinger_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainFrm.Show()
    End Sub
End Class