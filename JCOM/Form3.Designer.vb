﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BbButton汎用1 = New BB.BBButton汎用()
        Me.SuspendLayout()
        '
        'BbButton汎用1
        '
        Me.BbButton汎用1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BbButton汎用1.BBメッセージ表示名 = Nothing
        Me.BbButton汎用1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BbButton汎用1.Location = New System.Drawing.Point(38, 63)
        Me.BbButton汎用1.Name = "BbButton汎用1"
        Me.BbButton汎用1.Size = New System.Drawing.Size(220, 33)
        Me.BbButton汎用1.TabIndex = 0
        Me.BbButton汎用1.Text = "BbButton汎用1"
        Me.BbButton汎用1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BbButton汎用1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbButton汎用1 As BB.BBButton汎用
End Class
