<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.northOption = New System.Windows.Forms.RadioButton()
        Me.westOption = New System.Windows.Forms.RadioButton()
        Me.eastOption = New System.Windows.Forms.RadioButton()
        Me.southOption = New System.Windows.Forms.RadioButton()
        Me.slowOption = New System.Windows.Forms.RadioButton()
        Me.mediumOption = New System.Windows.Forms.RadioButton()
        Me.fastOption = New System.Windows.Forms.RadioButton()
        Me.carLabel = New System.Windows.Forms.Label()
        Me.toggleButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.southOption)
        Me.GroupBox1.Controls.Add(Me.eastOption)
        Me.GroupBox1.Controls.Add(Me.westOption)
        Me.GroupBox1.Controls.Add(Me.northOption)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "移動方向"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fastOption)
        Me.GroupBox2.Controls.Add(Me.mediumOption)
        Me.GroupBox2.Controls.Add(Me.slowOption)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "速度"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.carLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(230, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 383)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "畫面"
        '
        'northOption
        '
        Me.northOption.AutoSize = True
        Me.northOption.Location = New System.Drawing.Point(52, 42)
        Me.northOption.Name = "northOption"
        Me.northOption.Size = New System.Drawing.Size(35, 16)
        Me.northOption.TabIndex = 0
        Me.northOption.TabStop = True
        Me.northOption.Text = "北"
        Me.northOption.UseVisualStyleBackColor = True
        '
        'westOption
        '
        Me.westOption.AutoSize = True
        Me.westOption.Location = New System.Drawing.Point(6, 99)
        Me.westOption.Name = "westOption"
        Me.westOption.Size = New System.Drawing.Size(35, 16)
        Me.westOption.TabIndex = 1
        Me.westOption.TabStop = True
        Me.westOption.Text = "西"
        Me.westOption.UseVisualStyleBackColor = True
        '
        'eastOption
        '
        Me.eastOption.AutoSize = True
        Me.eastOption.Location = New System.Drawing.Point(105, 99)
        Me.eastOption.Name = "eastOption"
        Me.eastOption.Size = New System.Drawing.Size(35, 16)
        Me.eastOption.TabIndex = 2
        Me.eastOption.TabStop = True
        Me.eastOption.Text = "東"
        Me.eastOption.UseVisualStyleBackColor = True
        '
        'southOption
        '
        Me.southOption.AutoSize = True
        Me.southOption.Location = New System.Drawing.Point(52, 157)
        Me.southOption.Name = "southOption"
        Me.southOption.Size = New System.Drawing.Size(35, 16)
        Me.southOption.TabIndex = 3
        Me.southOption.TabStop = True
        Me.southOption.Text = "南"
        Me.southOption.UseVisualStyleBackColor = True
        '
        'slowOption
        '
        Me.slowOption.AutoSize = True
        Me.slowOption.Location = New System.Drawing.Point(40, 33)
        Me.slowOption.Name = "slowOption"
        Me.slowOption.Size = New System.Drawing.Size(47, 16)
        Me.slowOption.TabIndex = 0
        Me.slowOption.TabStop = True
        Me.slowOption.Text = "慢速"
        Me.slowOption.UseVisualStyleBackColor = True
        '
        'mediumOption
        '
        Me.mediumOption.AutoSize = True
        Me.mediumOption.Location = New System.Drawing.Point(40, 55)
        Me.mediumOption.Name = "mediumOption"
        Me.mediumOption.Size = New System.Drawing.Size(47, 16)
        Me.mediumOption.TabIndex = 1
        Me.mediumOption.TabStop = True
        Me.mediumOption.Text = "中等"
        Me.mediumOption.UseVisualStyleBackColor = True
        '
        'fastOption
        '
        Me.fastOption.AutoSize = True
        Me.fastOption.Location = New System.Drawing.Point(40, 77)
        Me.fastOption.Name = "fastOption"
        Me.fastOption.Size = New System.Drawing.Size(47, 16)
        Me.fastOption.TabIndex = 2
        Me.fastOption.TabStop = True
        Me.fastOption.Text = "快速"
        Me.fastOption.UseVisualStyleBackColor = True
        '
        'carLabel
        '
        Me.carLabel.AutoSize = True
        Me.carLabel.Location = New System.Drawing.Point(241, 185)
        Me.carLabel.Name = "carLabel"
        Me.carLabel.Size = New System.Drawing.Size(29, 12)
        Me.carLabel.TabIndex = 0
        Me.carLabel.Text = "車子"
        '
        'toggleButton
        '
        Me.toggleButton.Location = New System.Drawing.Point(64, 359)
        Me.toggleButton.Name = "toggleButton"
        Me.toggleButton.Size = New System.Drawing.Size(75, 23)
        Me.toggleButton.TabIndex = 1
        Me.toggleButton.Text = "開始移動"
        Me.toggleButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 406)
        Me.Controls.Add(Me.toggleButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents southOption As RadioButton
    Friend WithEvents eastOption As RadioButton
    Friend WithEvents westOption As RadioButton
    Friend WithEvents northOption As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fastOption As RadioButton
    Friend WithEvents mediumOption As RadioButton
    Friend WithEvents slowOption As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents carLabel As Label
    Friend WithEvents toggleButton As Button
    Friend WithEvents Timer1 As Timer
End Class
