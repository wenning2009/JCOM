<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BbLabelタイトル1 = New BB.BBLabelタイトル()
        Me.BbLabelタイトル2 = New BB.BBLabelタイトル()
        Me.BbLabelタイトル3 = New BB.BBLabelタイトル()
        Me.BbLabelタイトル4 = New BB.BBLabelタイトル()
        Me.SuspendLayout()
        '
        'BbLabelタイトル1
        '
        Me.BbLabelタイトル1.AutoSize = True
        Me.BbLabelタイトル1.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル1.Location = New System.Drawing.Point(0, 42)
        Me.BbLabelタイトル1.Name = "BbLabelタイトル1"
        Me.BbLabelタイトル1.Size = New System.Drawing.Size(87, 12)
        Me.BbLabelタイトル1.TabIndex = 0
        Me.BbLabelタイトル1.Text = "BbLabelタイトル1"
        Me.BbLabelタイトル1.UseMnemonic = False
        '
        'BbLabelタイトル2
        '
        Me.BbLabelタイトル2.AutoSize = True
        Me.BbLabelタイトル2.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル2.Location = New System.Drawing.Point(99, 125)
        Me.BbLabelタイトル2.Name = "BbLabelタイトル2"
        Me.BbLabelタイトル2.Size = New System.Drawing.Size(87, 12)
        Me.BbLabelタイトル2.TabIndex = 1
        Me.BbLabelタイトル2.Text = "BbLabelタイトル2"
        Me.BbLabelタイトル2.UseMnemonic = False
        '
        'BbLabelタイトル3
        '
        Me.BbLabelタイトル3.AutoSize = True
        Me.BbLabelタイトル3.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル3.Location = New System.Drawing.Point(99, 183)
        Me.BbLabelタイトル3.Name = "BbLabelタイトル3"
        Me.BbLabelタイトル3.Size = New System.Drawing.Size(87, 12)
        Me.BbLabelタイトル3.TabIndex = 2
        Me.BbLabelタイトル3.Text = "BbLabelタイトル3"
        Me.BbLabelタイトル3.UseMnemonic = False
        '
        'BbLabelタイトル4
        '
        Me.BbLabelタイトル4.AutoSize = True
        Me.BbLabelタイトル4.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル4.Location = New System.Drawing.Point(131, 42)
        Me.BbLabelタイトル4.Name = "BbLabelタイトル4"
        Me.BbLabelタイトル4.Size = New System.Drawing.Size(87, 12)
        Me.BbLabelタイトル4.TabIndex = 3
        Me.BbLabelタイトル4.Text = "BbLabelタイトル4"
        Me.BbLabelタイトル4.UseMnemonic = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BbLabelタイトル4)
        Me.Controls.Add(Me.BbLabelタイトル3)
        Me.Controls.Add(Me.BbLabelタイトル2)
        Me.Controls.Add(Me.BbLabelタイトル1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BbLabelタイトル1 As BB.BBLabelタイトル
    Friend WithEvents BbLabelタイトル2 As BB.BBLabelタイトル
    Friend WithEvents BbLabelタイトル3 As BB.BBLabelタイトル
    Friend WithEvents BbLabelタイトル4 As BB.BBLabelタイトル
End Class
