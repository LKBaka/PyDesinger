<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDesinger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesinger))
        Me.版权声明 = New System.Windows.Forms.Label()
        Me.ToolBox = New System.Windows.Forms.ListBox()
        Me.ToolBoxTitle = New System.Windows.Forms.Label()
        Me.attributeLbl = New System.Windows.Forms.Label()
        Me.attributeView = New System.Windows.Forms.DataGridView()
        Me.attributeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.attributeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '版权声明
        '
        Me.版权声明.AutoSize = True
        Me.版权声明.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.版权声明.ForeColor = System.Drawing.Color.DarkGray
        Me.版权声明.Location = New System.Drawing.Point(989, 643)
        Me.版权声明.Name = "版权声明"
        Me.版权声明.Size = New System.Drawing.Size(208, 27)
        Me.版权声明.TabIndex = 12
        Me.版权声明.Text = "B站ChenXiaoThi"
        '
        'ToolBox
        '
        Me.ToolBox.Font = New System.Drawing.Font("黑体", 15.0!)
        Me.ToolBox.FormattingEnabled = True
        Me.ToolBox.ItemHeight = 25
        Me.ToolBox.Items.AddRange(New Object() {"鼠标", "按钮", "文本框", "标签"})
        Me.ToolBox.Location = New System.Drawing.Point(12, 34)
        Me.ToolBox.Name = "ToolBox"
        Me.ToolBox.Size = New System.Drawing.Size(218, 629)
        Me.ToolBox.TabIndex = 14
        '
        'ToolBoxTitle
        '
        Me.ToolBoxTitle.AutoSize = True
        Me.ToolBoxTitle.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.ToolBoxTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.ToolBoxTitle.Location = New System.Drawing.Point(62, 4)
        Me.ToolBoxTitle.Name = "ToolBoxTitle"
        Me.ToolBoxTitle.Size = New System.Drawing.Size(96, 27)
        Me.ToolBoxTitle.TabIndex = 15
        Me.ToolBoxTitle.Text = "工具箱"
        '
        'attributeLbl
        '
        Me.attributeLbl.AutoSize = True
        Me.attributeLbl.Font = New System.Drawing.Font("黑体", 16.0!)
        Me.attributeLbl.ForeColor = System.Drawing.Color.DarkGray
        Me.attributeLbl.Location = New System.Drawing.Point(1025, 4)
        Me.attributeLbl.Name = "attributeLbl"
        Me.attributeLbl.Size = New System.Drawing.Size(68, 27)
        Me.attributeLbl.TabIndex = 17
        Me.attributeLbl.Text = "属性"
        '
        'attributeView
        '
        Me.attributeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.attributeView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.attributeName, Me.Value})
        Me.attributeView.Location = New System.Drawing.Point(920, 34)
        Me.attributeView.Name = "attributeView"
        Me.attributeView.RowHeadersWidth = 51
        Me.attributeView.RowTemplate.Height = 27
        Me.attributeView.Size = New System.Drawing.Size(277, 606)
        Me.attributeView.TabIndex = 18
        '
        'attributeName
        '
        Me.attributeName.HeaderText = "属性"
        Me.attributeName.MaxInputLength = 0
        Me.attributeName.MinimumWidth = 6
        Me.attributeName.Name = "attributeName"
        Me.attributeName.ReadOnly = True
        Me.attributeName.Width = 110
        '
        'Value
        '
        Me.Value.HeaderText = "值"
        Me.Value.MinimumWidth = 6
        Me.Value.Name = "Value"
        Me.Value.Width = 125
        '
        'FrmDesinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1209, 679)
        Me.Controls.Add(Me.attributeView)
        Me.Controls.Add(Me.attributeLbl)
        Me.Controls.Add(Me.ToolBoxTitle)
        Me.Controls.Add(Me.ToolBox)
        Me.Controls.Add(Me.版权声明)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDesinger"
        Me.Text = "FrmDesinger"
        CType(Me.attributeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 版权声明 As Label
    Friend WithEvents ToolBox As ListBox
    Friend WithEvents ToolBoxTitle As Label
    Friend WithEvents attributeLbl As Label
    Friend WithEvents attributeView As DataGridView
    Friend WithEvents attributeName As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
End Class
