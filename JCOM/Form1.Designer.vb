<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SuspendLayout()
        '
        'BbLabelタイトル1
        '
        Me.BbLabelタイトル1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BbLabelタイトル1.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル1.Location = New System.Drawing.Point(4, 78)
        Me.BbLabelタイトル1.Name = "BbLabelタイトル1"
        Me.BbLabelタイトル1.Size = New System.Drawing.Size(271, 73)
        Me.BbLabelタイトル1.TabIndex = 0
        Me.BbLabelタイトル1.Text = "HELLO WORD!"
        Me.BbLabelタイトル1.UseMnemonic = False
        '
        'BbLabelタイトル2
        '
        Me.BbLabelタイトル2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BbLabelタイトル2.BBメッセージ表示名 = Nothing
        Me.BbLabelタイトル2.Location = New System.Drawing.Point(4, 167)
        Me.BbLabelタイトル2.Name = "BbLabelタイトル2"
        Me.BbLabelタイトル2.Size = New System.Drawing.Size(271, 73)
        Me.BbLabelタイトル2.TabIndex = 1
        Me.BbLabelタイトル2.Text = "HELLO WORD!"
        Me.BbLabelタイトル2.UseMnemonic = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BbLabelタイトル2)
        Me.Controls.Add(Me.BbLabelタイトル1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbLabelタイトル1 As BB.BBLabelタイトル
    Friend WithEvents BbLabelタイトル2 As BB.BBLabelタイトル

End Class
