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
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtType2 = New System.Windows.Forms.RadioButton()
        Me.rbtType1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtColorBlue = New System.Windows.Forms.RadioButton()
        Me.rbtColorGreen = New System.Windows.Forms.RadioButton()
        Me.rbtColorRed = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtShow
        '
        Me.txtShow.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtShow.Location = New System.Drawing.Point(39, 24)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(450, 40)
        Me.txtShow.TabIndex = 0
        Me.txtShow.Text = "測試文字"
        Me.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtType2)
        Me.GroupBox1.Controls.Add(Me.rbtType1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "字型"
        '
        'rbtType2
        '
        Me.rbtType2.AutoSize = True
        Me.rbtType2.Location = New System.Drawing.Point(19, 69)
        Me.rbtType2.Name = "rbtType2"
        Me.rbtType2.Size = New System.Drawing.Size(59, 16)
        Me.rbtType2.TabIndex = 1
        Me.rbtType2.Text = "標楷體"
        Me.rbtType2.UseVisualStyleBackColor = True
        '
        'rbtType1
        '
        Me.rbtType1.AutoSize = True
        Me.rbtType1.Checked = True
        Me.rbtType1.Location = New System.Drawing.Point(19, 36)
        Me.rbtType1.Name = "rbtType1"
        Me.rbtType1.Size = New System.Drawing.Size(71, 16)
        Me.rbtType1.TabIndex = 0
        Me.rbtType1.TabStop = True
        Me.rbtType1.Text = "新細明體"
        Me.rbtType1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtColorBlue)
        Me.GroupBox2.Controls.Add(Me.rbtColorGreen)
        Me.GroupBox2.Controls.Add(Me.rbtColorRed)
        Me.GroupBox2.Location = New System.Drawing.Point(196, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 138)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "顏色"
        '
        'rbtColorBlue
        '
        Me.rbtColorBlue.AutoSize = True
        Me.rbtColorBlue.Location = New System.Drawing.Point(17, 101)
        Me.rbtColorBlue.Name = "rbtColorBlue"
        Me.rbtColorBlue.Size = New System.Drawing.Size(47, 16)
        Me.rbtColorBlue.TabIndex = 2
        Me.rbtColorBlue.Text = "藍色"
        Me.rbtColorBlue.UseVisualStyleBackColor = True
        '
        'rbtColorGreen
        '
        Me.rbtColorGreen.AutoSize = True
        Me.rbtColorGreen.Location = New System.Drawing.Point(17, 69)
        Me.rbtColorGreen.Name = "rbtColorGreen"
        Me.rbtColorGreen.Size = New System.Drawing.Size(47, 16)
        Me.rbtColorGreen.TabIndex = 1
        Me.rbtColorGreen.Text = "綠色"
        Me.rbtColorGreen.UseVisualStyleBackColor = True
        '
        'rbtColorRed
        '
        Me.rbtColorRed.AutoSize = True
        Me.rbtColorRed.Checked = True
        Me.rbtColorRed.Location = New System.Drawing.Point(17, 36)
        Me.rbtColorRed.Name = "rbtColorRed"
        Me.rbtColorRed.Size = New System.Drawing.Size(47, 16)
        Me.rbtColorRed.TabIndex = 0
        Me.rbtColorRed.TabStop = True
        Me.rbtColorRed.Text = "紅色"
        Me.rbtColorRed.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Location = New System.Drawing.Point(358, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 138)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "字型樣式"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(17, 69)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton7.TabIndex = 1
        Me.RadioButton7.Text = "粗體"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(17, 36)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "正常"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 242)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtShow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtShow As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtType2 As RadioButton
    Friend WithEvents rbtType1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtColorBlue As RadioButton
    Friend WithEvents rbtColorGreen As RadioButton
    Friend WithEvents rbtColorRed As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
End Class
