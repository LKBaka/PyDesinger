<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.BTitle = New System.Windows.Forms.Label()
        Me.NewProjectLbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.版权声明 = New System.Windows.Forms.Label()
        Me.NewProjectBtn = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.NewProjectBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTitle
        '
        Me.BTitle.AutoSize = True
        Me.BTitle.Font = New System.Drawing.Font("黑体", 36.0!)
        Me.BTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.BTitle.Location = New System.Drawing.Point(295, 73)
        Me.BTitle.Name = "BTitle"
        Me.BTitle.Size = New System.Drawing.Size(325, 60)
        Me.BTitle.TabIndex = 5
        Me.BTitle.Text = "PyDesigner"
        '
        'NewProjectLbl
        '
        Me.NewProjectLbl.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.NewProjectLbl.ForeColor = System.Drawing.Color.DarkGray
        Me.NewProjectLbl.Location = New System.Drawing.Point(169, 336)
        Me.NewProjectLbl.Name = "NewProjectLbl"
        Me.NewProjectLbl.Size = New System.Drawing.Size(99, 40)
        Me.NewProjectLbl.TabIndex = 7
        Me.NewProjectLbl.Text = "新项目"
        Me.NewProjectLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        '版权声明
        '
        Me.版权声明.AutoSize = True
        Me.版权声明.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.版权声明.ForeColor = System.Drawing.Color.DarkGray
        Me.版权声明.Location = New System.Drawing.Point(592, 443)
        Me.版权声明.Name = "版权声明"
        Me.版权声明.Size = New System.Drawing.Size(208, 27)
        Me.版权声明.TabIndex = 8
        Me.版权声明.Text = "B站ChenXiaoThi"
        '
        'NewProjectBtn
        '
        Me.NewProjectBtn.Image = Global.PyDesigner.My.Resources.Resources.NewProject
        Me.NewProjectBtn.Location = New System.Drawing.Point(173, 230)
        Me.NewProjectBtn.Name = "NewProjectBtn"
        Me.NewProjectBtn.Size = New System.Drawing.Size(95, 90)
        Me.NewProjectBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NewProjectBtn.TabIndex = 6
        Me.NewProjectBtn.TabStop = False
        '
        'Logo
        '
        Me.Logo.Image = Global.PyDesigner.My.Resources.Resources.PyIcon
        Me.Logo.Location = New System.Drawing.Point(173, 55)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(107, 104)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 4
        Me.Logo.TabStop = False
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 479)
        Me.Controls.Add(Me.版权声明)
        Me.Controls.Add(Me.NewProjectLbl)
        Me.Controls.Add(Me.NewProjectBtn)
        Me.Controls.Add(Me.BTitle)
        Me.Controls.Add(Me.Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainFrm"
        Me.Text = "PyDesinger-B站ChenXiaoThi"
        CType(Me.NewProjectBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTitle As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents NewProjectBtn As PictureBox
    Friend WithEvents NewProjectLbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 版权声明 As Label
End Class
