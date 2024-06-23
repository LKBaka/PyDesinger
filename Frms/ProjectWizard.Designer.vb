<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectWizard
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectWizard))
        Me.版权声明 = New System.Windows.Forms.Label()
        Me.BTitle = New System.Windows.Forms.Label()
        Me.PathBox = New System.Windows.Forms.TextBox()
        Me.BroswerFolder = New System.Windows.Forms.Button()
        Me.NewProjectBtn = New System.Windows.Forms.Button()
        Me.PrjNameBox = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '版权声明
        '
        Me.版权声明.AutoSize = True
        Me.版权声明.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.版权声明.ForeColor = System.Drawing.Color.DarkGray
        Me.版权声明.Location = New System.Drawing.Point(580, 414)
        Me.版权声明.Name = "版权声明"
        Me.版权声明.Size = New System.Drawing.Size(208, 27)
        Me.版权声明.TabIndex = 11
        Me.版权声明.Text = "B站ChenXiaoThi"
        '
        'BTitle
        '
        Me.BTitle.AutoSize = True
        Me.BTitle.Font = New System.Drawing.Font("黑体", 36.0!)
        Me.BTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.BTitle.Location = New System.Drawing.Point(284, 57)
        Me.BTitle.Name = "BTitle"
        Me.BTitle.Size = New System.Drawing.Size(325, 60)
        Me.BTitle.TabIndex = 10
        Me.BTitle.Text = "PyDesigner"
        '
        'PathBox
        '
        Me.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PathBox.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.PathBox.Location = New System.Drawing.Point(54, 273)
        Me.PathBox.Multiline = True
        Me.PathBox.Name = "PathBox"
        Me.PathBox.Size = New System.Drawing.Size(695, 40)
        Me.PathBox.TabIndex = 12
        Me.PathBox.Text = "项目路径"
        '
        'BroswerFolder
        '
        Me.BroswerFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BroswerFolder.Font = New System.Drawing.Font("黑体", 12.0!)
        Me.BroswerFolder.Location = New System.Drawing.Point(519, 223)
        Me.BroswerFolder.Name = "BroswerFolder"
        Me.BroswerFolder.Size = New System.Drawing.Size(112, 40)
        Me.BroswerFolder.TabIndex = 13
        Me.BroswerFolder.Text = "浏览"
        Me.BroswerFolder.UseVisualStyleBackColor = True
        '
        'NewProjectBtn
        '
        Me.NewProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewProjectBtn.Font = New System.Drawing.Font("黑体", 12.0!)
        Me.NewProjectBtn.Location = New System.Drawing.Point(637, 223)
        Me.NewProjectBtn.Name = "NewProjectBtn"
        Me.NewProjectBtn.Size = New System.Drawing.Size(112, 40)
        Me.NewProjectBtn.TabIndex = 14
        Me.NewProjectBtn.Text = "创建"
        Me.NewProjectBtn.UseVisualStyleBackColor = True
        '
        'PrjNameBox
        '
        Me.PrjNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrjNameBox.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.PrjNameBox.Location = New System.Drawing.Point(54, 223)
        Me.PrjNameBox.Multiline = True
        Me.PrjNameBox.Name = "PrjNameBox"
        Me.PrjNameBox.Size = New System.Drawing.Size(458, 40)
        Me.PrjNameBox.TabIndex = 15
        Me.PrjNameBox.Text = "项目名"
        '
        'Logo
        '
        Me.Logo.Image = Global.PyDesigner.My.Resources.Resources.PyIcon
        Me.Logo.Location = New System.Drawing.Point(162, 39)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(107, 104)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 9
        Me.Logo.TabStop = False
        '
        'ProjectWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PrjNameBox)
        Me.Controls.Add(Me.NewProjectBtn)
        Me.Controls.Add(Me.BroswerFolder)
        Me.Controls.Add(Me.PathBox)
        Me.Controls.Add(Me.版权声明)
        Me.Controls.Add(Me.BTitle)
        Me.Controls.Add(Me.Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProjectWizard"
        Me.Text = "ProjectWizard"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 版权声明 As Label
    Friend WithEvents BTitle As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents PathBox As TextBox
    Friend WithEvents BroswerFolder As Button
    Friend WithEvents NewProjectBtn As Button
    Friend WithEvents PrjNameBox As TextBox
End Class
