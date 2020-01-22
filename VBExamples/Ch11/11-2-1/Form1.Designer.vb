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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picCar1 = New System.Windows.Forms.PictureBox()
        Me.picCar2 = New System.Windows.Forms.PictureBox()
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "前進"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picCar1
        '
        Me.picCar1.Image = Global._11_2_1.My.Resources.Resources.黃色汽車
        Me.picCar1.Location = New System.Drawing.Point(298, 24)
        Me.picCar1.Name = "picCar1"
        Me.picCar1.Size = New System.Drawing.Size(100, 50)
        Me.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCar1.TabIndex = 1
        Me.picCar1.TabStop = False
        '
        'picCar2
        '
        Me.picCar2.Image = Global._11_2_1.My.Resources.Resources.紅色汽車
        Me.picCar2.Location = New System.Drawing.Point(298, 95)
        Me.picCar2.Name = "picCar2"
        Me.picCar2.Size = New System.Drawing.Size(100, 50)
        Me.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCar2.TabIndex = 2
        Me.picCar2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 219)
        Me.Controls.Add(Me.picCar2)
        Me.Controls.Add(Me.picCar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents picCar1 As PictureBox
    Friend WithEvents picCar2 As PictureBox
End Class
