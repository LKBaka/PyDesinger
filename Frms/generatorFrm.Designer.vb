<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generatorFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(generatorFrm))
        Me.PBar1 = New System.Windows.Forms.ProgressBar()
        Me.generatorIngLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PBar1
        '
        Me.PBar1.Location = New System.Drawing.Point(88, 109)
        Me.PBar1.Name = "PBar1"
        Me.PBar1.Size = New System.Drawing.Size(386, 38)
        Me.PBar1.TabIndex = 0
        '
        'generatorIngLbl
        '
        Me.generatorIngLbl.AutoSize = True
        Me.generatorIngLbl.Font = New System.Drawing.Font("黑体", 14.0!)
        Me.generatorIngLbl.Location = New System.Drawing.Point(85, 74)
        Me.generatorIngLbl.Name = "generatorIngLbl"
        Me.generatorIngLbl.Size = New System.Drawing.Size(118, 24)
        Me.generatorIngLbl.TabIndex = 1
        Me.generatorIngLbl.Text = "生成中..."
        '
        'generatorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 251)
        Me.Controls.Add(Me.generatorIngLbl)
        Me.Controls.Add(Me.PBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "generatorFrm"
        Me.Text = "生成中..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBar1 As ProgressBar
    Friend WithEvents generatorIngLbl As Label
End Class
