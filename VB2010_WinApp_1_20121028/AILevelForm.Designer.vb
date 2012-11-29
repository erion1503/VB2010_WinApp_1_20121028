<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AILevelForm
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
        Me.RadioBtnEasy = New System.Windows.Forms.RadioButton()
        Me.RadioBtnNormal = New System.Windows.Forms.RadioButton()
        Me.RadioBtnExtra = New System.Windows.Forms.RadioButton()
        Me.lblComent1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioBtnEasy
        '
        Me.RadioBtnEasy.AutoSize = True
        Me.RadioBtnEasy.Location = New System.Drawing.Point(60, 39)
        Me.RadioBtnEasy.Name = "RadioBtnEasy"
        Me.RadioBtnEasy.Size = New System.Drawing.Size(90, 16)
        Me.RadioBtnEasy.TabIndex = 0
        Me.RadioBtnEasy.TabStop = True
        Me.RadioBtnEasy.Tag = ""
        Me.RadioBtnEasy.Text = "イージーモード"
        Me.RadioBtnEasy.UseVisualStyleBackColor = True
        '
        'RadioBtnNormal
        '
        Me.RadioBtnNormal.AutoSize = True
        Me.RadioBtnNormal.Location = New System.Drawing.Point(60, 61)
        Me.RadioBtnNormal.Name = "RadioBtnNormal"
        Me.RadioBtnNormal.Size = New System.Drawing.Size(88, 16)
        Me.RadioBtnNormal.TabIndex = 1
        Me.RadioBtnNormal.TabStop = True
        Me.RadioBtnNormal.Tag = ""
        Me.RadioBtnNormal.Text = "ノーマルモード"
        Me.RadioBtnNormal.UseVisualStyleBackColor = True
        '
        'RadioBtnExtra
        '
        Me.RadioBtnExtra.AutoSize = True
        Me.RadioBtnExtra.Location = New System.Drawing.Point(60, 83)
        Me.RadioBtnExtra.Name = "RadioBtnExtra"
        Me.RadioBtnExtra.Size = New System.Drawing.Size(93, 16)
        Me.RadioBtnExtra.TabIndex = 2
        Me.RadioBtnExtra.TabStop = True
        Me.RadioBtnExtra.Tag = ""
        Me.RadioBtnExtra.Text = "エクストラモード"
        Me.RadioBtnExtra.UseVisualStyleBackColor = True
        '
        'lblComent1
        '
        Me.lblComent1.AutoSize = True
        Me.lblComent1.Location = New System.Drawing.Point(12, 9)
        Me.lblComent1.Name = "lblComent1"
        Me.lblComent1.Size = New System.Drawing.Size(87, 12)
        Me.lblComent1.TabIndex = 3
        Me.lblComent1.Text = "コンピュータの強さ"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(60, 119)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(141, 119)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AILevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 154)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblComent1)
        Me.Controls.Add(Me.RadioBtnExtra)
        Me.Controls.Add(Me.RadioBtnNormal)
        Me.Controls.Add(Me.RadioBtnEasy)
        Me.Name = "AILevelForm"
        Me.Text = "AILevelForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioBtnEasy As System.Windows.Forms.RadioButton
    Friend WithEvents RadioBtnNormal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioBtnExtra As System.Windows.Forms.RadioButton
    Friend WithEvents lblComent1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
