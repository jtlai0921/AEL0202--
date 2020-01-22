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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.chkMusic = New System.Windows.Forms.CheckBox()
        Me.chkMovie = New System.Windows.Forms.CheckBox()
        Me.chkMount = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtFemale)
        Me.GroupBox1.Controls.Add(Me.rbtMale)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "性別"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMount)
        Me.GroupBox2.Controls.Add(Me.chkMovie)
        Me.GroupBox2.Controls.Add(Me.chkMusic)
        Me.GroupBox2.Location = New System.Drawing.Point(177, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 149)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "興趣"
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Location = New System.Drawing.Point(27, 46)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(47, 16)
        Me.rbtMale.TabIndex = 0
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "男性"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'rbtFemale
        '
        Me.rbtFemale.Location = New System.Drawing.Point(27, 89)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(89, 16)
        Me.rbtFemale.TabIndex = 0
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "女性"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'chkMusic
        '
        Me.chkMusic.Location = New System.Drawing.Point(22, 35)
        Me.chkMusic.Name = "chkMusic"
        Me.chkMusic.Size = New System.Drawing.Size(80, 16)
        Me.chkMusic.TabIndex = 0
        Me.chkMusic.Text = "聽音樂"
        Me.chkMusic.UseVisualStyleBackColor = True
        '
        'chkMovie
        '
        Me.chkMovie.Location = New System.Drawing.Point(22, 75)
        Me.chkMovie.Name = "chkMovie"
        Me.chkMovie.Size = New System.Drawing.Size(80, 16)
        Me.chkMovie.TabIndex = 0
        Me.chkMovie.Text = "看電影"
        Me.chkMovie.UseVisualStyleBackColor = True
        '
        'chkMount
        '
        Me.chkMount.Location = New System.Drawing.Point(22, 110)
        Me.chkMount.Name = "chkMount"
        Me.chkMount.Size = New System.Drawing.Size(80, 16)
        Me.chkMount.TabIndex = 0
        Me.chkMount.Text = "爬山"
        Me.chkMount.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "送出資料"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 238)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtMale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtFemale As RadioButton
    Friend WithEvents chkMount As CheckBox
    Friend WithEvents chkMovie As CheckBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents Button1 As Button
End Class
