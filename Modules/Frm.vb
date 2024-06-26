Imports System.CodeDom
Imports Sunny.UI

Public Class Frm
    Public attribute_CN_EN As New Dictionary(Of String, String) From
    {
        {"名称", "Name"},
        {"文本", "Text"},
        {"位置", "Location"},
        {"大小", "Size"}
    }
    Public typeDic As New Dictionary(Of String, String) From
    {
        {"System.Windows.Forms.Button", "Button"},
        {"System.Windows.Forms.Label", "Label"}
    }
    Public events_Funcs As New List(Of String)


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
    Public Function generatorWidgetCode(f As Form) As String
#Region "生成控件UI代码"
        Dim codeLine =
$"
    def createWidgets(self):{vbCrLf}
        self.top = self.winfo_toplevel(){vbCrLf}
        self.style = Style(){vbCrLf}
"

        For Each control_ As Control In f.Controls
            codeLine +=
$"
        self.{control_.Name}Var = StringVar(value = '{control_.Text}'){vbCrLf}
"
            Dim control_type = typeDic(control_.GetType.FullName)
            Select Case control_type
                Case "Button"
                    codeLine +=
$"          
        self.style.configure('T{control_.Name}.T{control_type}', font=('黑体',9)){vbCrLf}
"
                Case "Label"
                    codeLine +=
$"          
        self.style.configure('T{control_.Name}.T{control_type}',anchor='w', font=('黑体',9)){vbCrLf}
"
            End Select
            codeLine +=
$"
        self.{control_.Name} = {control_type}({getPythonArgs(control_type, control_)}){vbCrLf}
"
            codeLine +=
$"
        self.{control_.Name}.setText = lambda x: self.{control_.Name}Var.set(x){vbCrLf}
"
            codeLine +=
$"
        self.{control_.Name}.text = lambda : self.{control_.Name}Var.get(){vbCrLf}
"
            Dim 比率 = 3 '经过调试在缩放125情况下与设计器完全匹配的比率
            Select Case control_type
                Case "Label"
                    codeLine +=
$"
        self.{control_.Name}.place(relx={Math.Round(control_.Location.X * 比率 / 1000, 3)} , rely={Math.Round(control_.Location.Y / 1000, 3)} , relwidth={Math.Round(control_.Size.Width * 比率 / 1000, 3)}, relheight={Math.Round(control_.Size.Height * 比率 / 2 / 1000, 3)} ){vbCrLf}
"
                Case "Button"
                    codeLine +=
$"
        self.{control_.Name}.place(relx={Math.Round(control_.Location.X * 比率 / 1000, 3)} , rely={Math.Round(control_.Location.Y * 比率 / 1000, 3)} , relwidth={Math.Round(control_.Size.Width * 比率 / 1000, 3)}, relheight={Math.Round(control_.Size.Height * 比率 / 1000, 3)} ){vbCrLf}
"
            End Select

        Next
#End Region
        Return codeLine
    End Function
    Public Function getPythonArgs(controlType As String, control_ As Control) As String

        Select Case controlType
            Case "Button"
                events_Funcs.Add(control_.Name)

                Return $"self.top, text='{control_.Text}', textvariable=self.{control_.Name}Var, command=self.{control_.Name}_Click, style='T{control_.Name}.TButton'"
            Case "Label"
                Return $"self.top, text='{control_.Text}', textvariable=self.{control_.Name}Var, style='T{control_.Name}.TLabel'"

        End Select

        Return ""
    End Function
    Public Async Function ConvertToPythonTk(f As Form) As Task(Of String)
#Region "导入库"
        Dim Import =
            "import os, sys" & vbCrLf &
            "from tkinter import * " & vbCrLf &
            "from tkinter.font import Font" & vbCrLf &
            "from tkinter.ttk import *" & vbCrLf &
            "#Usage:showinfo/warning/error,askquestion/okcancel/yesno/retrycancel" & vbCrLf &
            "from tkinter.messagebox import *" & vbCrLf &
            "#from tkinter import filedialog  #.askopenfilename()" & vbCrLf &
            "#from tkinter import simpledialog  #.askstring()" & vbCrLf
#End Region
#Region "UI类&初始化"
        Dim Application_ui =
$"
class {f.Name}(Frame):{vbCrLf} 
    def __init__(self, master=None):{vbCrLf}
        super().__init__(master){vbCrLf}
        self.master.title('{f.Text}'){vbCrLf}
        self.master.geometry('{CStr(f.Size.Width)}x{CStr(f.Size.Height)}'){vbCrLf}
        self.createWidgets(){vbCrLf}
            
"
#End Region

#Region "创建UI"
        Dim codeLine = generatorWidgetCode(f)
#End Region
#Region "创建事件函数"
        Dim eventsCode = ""
        For Each EventsFunc In events_Funcs
            Debug.Print(eventsCode)

            eventsCode += $"    def {EventsFunc}_Click(self,event = None):{vbCrLf}"
            eventsCode += $"        #TODO:在这里编写事件代码{vbCrLf}"
            eventsCode += $"        pass{vbCrLf}"
        Next
#End Region

#Region "创建主程序窗口"
        Dim MainCode = ""
        MainCode +=
$"
if __name__ == '__main__':{vbCrLf}
    win = Tk(){vbCrLf}
    {f.Name}(win).mainloop(){vbCrLf}
"
#End Region
        Return Import & Application_ui & eventsCode & codeLine & MainCode ' 返回Python代码
    End Function
End Class
