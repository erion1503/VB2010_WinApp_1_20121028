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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBlackTurn = New System.Windows.Forms.Label()
        Me.lblWhiteTurn = New System.Windows.Forms.Label()
        Me.lblBlackCount = New System.Windows.Forms.Label()
        Me.lblWhiteCount = New System.Windows.Forms.Label()
        Me.lblBlackName = New System.Windows.Forms.Label()
        Me.lblWhiteName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AILEVELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStartBlack = New System.Windows.Forms.Button()
        Me.btnStartWhite = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblBlackTurn
        '
        Me.lblBlackTurn.AutoSize = True
        Me.lblBlackTurn.BackColor = System.Drawing.Color.Red
        Me.lblBlackTurn.Location = New System.Drawing.Point(414, 128)
        Me.lblBlackTurn.Name = "lblBlackTurn"
        Me.lblBlackTurn.Size = New System.Drawing.Size(9, 12)
        Me.lblBlackTurn.TabIndex = 2
        Me.lblBlackTurn.Text = " "
        Me.lblBlackTurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWhiteTurn
        '
        Me.lblWhiteTurn.AutoSize = True
        Me.lblWhiteTurn.BackColor = System.Drawing.Color.Red
        Me.lblWhiteTurn.Location = New System.Drawing.Point(414, 260)
        Me.lblWhiteTurn.Name = "lblWhiteTurn"
        Me.lblWhiteTurn.Size = New System.Drawing.Size(9, 12)
        Me.lblWhiteTurn.TabIndex = 3
        Me.lblWhiteTurn.Text = " "
        Me.lblWhiteTurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBlackCount
        '
        Me.lblBlackCount.AutoSize = True
        Me.lblBlackCount.Location = New System.Drawing.Point(490, 128)
        Me.lblBlackCount.Name = "lblBlackCount"
        Me.lblBlackCount.Size = New System.Drawing.Size(11, 12)
        Me.lblBlackCount.TabIndex = 4
        Me.lblBlackCount.Text = "0"
        '
        'lblWhiteCount
        '
        Me.lblWhiteCount.AutoSize = True
        Me.lblWhiteCount.Location = New System.Drawing.Point(490, 260)
        Me.lblWhiteCount.Name = "lblWhiteCount"
        Me.lblWhiteCount.Size = New System.Drawing.Size(11, 12)
        Me.lblWhiteCount.TabIndex = 5
        Me.lblWhiteCount.Text = "0"
        '
        'lblBlackName
        '
        Me.lblBlackName.AutoSize = True
        Me.lblBlackName.Location = New System.Drawing.Point(421, 128)
        Me.lblBlackName.Name = "lblBlackName"
        Me.lblBlackName.Size = New System.Drawing.Size(17, 12)
        Me.lblBlackName.TabIndex = 6
        Me.lblBlackName.Text = "黒"
        '
        'lblWhiteName
        '
        Me.lblWhiteName.AutoSize = True
        Me.lblWhiteName.Location = New System.Drawing.Point(421, 260)
        Me.lblWhiteName.Name = "lblWhiteName"
        Me.lblWhiteName.Size = New System.Drawing.Size(17, 12)
        Me.lblWhiteName.TabIndex = 7
        Me.lblWhiteName.Text = "白"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(565, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ゲーム初期化"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AILEVELToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'AILEVELToolStripMenuItem
        '
        Me.AILEVELToolStripMenuItem.Name = "AILEVELToolStripMenuItem"
        Me.AILEVELToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AILEVELToolStripMenuItem.Text = "敵レベル"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VB2010_WinApp_1_20121028.My.Resources.Resources.つかさ_白
        Me.PictureBox3.Location = New System.Drawing.Point(401, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 82)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VB2010_WinApp_1_20121028.My.Resources.Resources.かがみ_黒
        Me.PictureBox2.Location = New System.Drawing.Point(401, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 84)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VB2010_WinApp_1_20121028.My.Resources.Resources.masu0
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 384)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStartBlack
        '
        Me.btnStartBlack.Location = New System.Drawing.Point(391, 321)
        Me.btnStartBlack.Name = "btnStartBlack"
        Me.btnStartBlack.Size = New System.Drawing.Size(124, 23)
        Me.btnStartBlack.TabIndex = 12
        Me.btnStartBlack.Text = "プレイヤー（黒）で開始"
        Me.btnStartBlack.UseVisualStyleBackColor = True
        '
        'btnStartWhite
        '
        Me.btnStartWhite.Location = New System.Drawing.Point(391, 350)
        Me.btnStartWhite.Name = "btnStartWhite"
        Me.btnStartWhite.Size = New System.Drawing.Size(124, 23)
        Me.btnStartWhite.TabIndex = 13
        Me.btnStartWhite.Text = "プレイヤー（白）で開始"
        Me.btnStartWhite.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 413)
        Me.Controls.Add(Me.btnStartWhite)
        Me.Controls.Add(Me.btnStartBlack)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblWhiteName)
        Me.Controls.Add(Me.lblBlackName)
        Me.Controls.Add(Me.lblWhiteCount)
        Me.Controls.Add(Me.lblBlackCount)
        Me.Controls.Add(Me.lblWhiteTurn)
        Me.Controls.Add(Me.lblBlackTurn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "りば～し～"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblBlackTurn As System.Windows.Forms.Label
    Friend WithEvents lblWhiteTurn As System.Windows.Forms.Label
    Friend WithEvents lblBlackCount As System.Windows.Forms.Label
    Friend WithEvents lblWhiteCount As System.Windows.Forms.Label
    Friend WithEvents lblBlackName As System.Windows.Forms.Label
    Friend WithEvents lblWhiteName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AILEVELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStartBlack As System.Windows.Forms.Button
    Friend WithEvents btnStartWhite As System.Windows.Forms.Button

End Class
