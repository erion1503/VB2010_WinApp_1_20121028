Imports System.IO 'wav読み込みに必要

Public Class Form1

    Dim WithEvents Grid As New ReverseGrid

    'Dim Computer As New Computer1(Grid, CellStatus.White) 'コンピュータの追加
    Dim Computer As New Computer2(Grid, CellStatus.White) 'コンピュータの追加

    '描画処理イベント
    Private Sub PictureBox1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Grid.Draw(e.Graphics)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        'マウスの座標をPictureBoxのコントロール座標に変換する。
        Dim Pos As Point = PictureBox1.PointToClient(Windows.Forms.Cursor.Position)
        Dim ThisCell As Cell
        ThisCell = Grid.CellFromPoint(Pos.X, Pos.Y)
        If Grid.Put(Turn, ThisCell.Position.X, ThisCell.Position.Y) Then
            ChangeTurn()
        End If
    End Sub

    ''' <summary>マウスの移動に伴ってセルにアクティブを示す枠を描画する</summary>
    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim ThisCell As Cell
        'マウスがある位置のセルを取得
        ThisCell = Grid.CellFromPoint(e.X, e.Y)
        If Not IsNothing(ThisCell) Then
            'セルが取得できた場合は、セルにアクティブを示す枠を描画
            ThisCell.Focus()
            '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
            PictureBox1.Invalidate() '←実際の描画はすべてここで行う。
        End If
    End Sub

    Dim Turn As CellStatus = CellStatus.Black '今のどっちの順番か
    Dim PlayerColor As CellStatus = CellStatus.Black 'プレイヤーの色
    '■ChangeTurn
    '''<summary>ターン交代</summary>
    Public Sub ChangeTurn()
        '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
        PictureBox1.Invalidate()

        '▼勝敗判定
        If Grid.Count(CellStatus.Nothing) = 0 Then
            '全セルへの配置が終了した場合は勝敗判定して終了
            If Grid.Count(CellStatus.Black) > Grid.Count(CellStatus.White) Then
                MsgBox("黒の勝利です。")
            ElseIf Grid.Count(CellStatus.White) > Grid.Count(CellStatus.Black) Then
                MsgBox("白の勝ちです。")
            Else
                MsgBox("引き分けです。")
            End If
            Return
        ElseIf Grid.PuttableCount(CellStatus.Black) = 0 AndAlso Grid.PuttableCount(CellStatus.White) = 0 Then
            '空いているセルがあるのに白も黒もおけない場合
            If Grid.Count(CellStatus.Black) > Grid.Count(CellStatus.White) Then
                MsgBox("黒の勝ちです。")
            ElseIf Grid.Count(CellStatus.White) > Grid.Count(CellStatus.Black) Then
                MsgBox("白の勝ちです。")
            Else
                MsgBox("引き分けです。")
            End If
            Return
            If Grid.Count(CellStatus.Black) = 0 Then
                MsgBox("白の勝ちです。")
                Return
            ElseIf Grid.Count(CellStatus.White) = 0 Then
                MsgBox("黒の勝ちです。")
                Return
            End If
        End If

        '▼次のターンの決定
        If Turn = CellStatus.Black Then
            Turn = CellStatus.White
            lblWhiteTurn.Visible = True
            lblBlackTurn.Visible = False
        Else
            Turn = CellStatus.Black
            lblBlackTurn.Visible = True
            lblWhiteTurn.Visible = False
        End If

        '▼置ける場所があるか判定
        If Grid.PuttableCount(Turn) = 0 Then
            '置く場所がなければパスして次のターン
            ChangeTurn()
        End If

        '▼人間かコンピュータかで処理を分岐
        If Turn = PlayerColor Then
            '人間の場合ならば、PictureBoxを使用可能にする
            PictureBox1.Enabled = True
        Else
            'コンピュータの番なら、PictureBoxを使用不可にする
            PictureBox1.Enabled = False

            'ちょっと時間をおく
            Application.DoEvents()
            System.Threading.Thread.Sleep(500)

            'コンピュータに石を置かせる。どのセルに置くかはコンピュータ(AI)が決定する。
            Computer.Put()
            ChangeTurn() 'プレイヤーの番へ
        End If

    End Sub

    ''' <summary>Startメソッドで代用するため現在不要</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Grid.Initialize()
        'lblBlackCount.Text = Grid.Count(CellStatus.Black)
        'lblWhiteCount.Text = Grid.Count(CellStatus.White)
        'lblWhiteTurn.Visible = False
        'lblBlackTurn.Visible = True
    End Sub

    '■Start
    '''<Summary>ゲームを開始します。</Summary>
    ''' <param name="PlayerColor">人間の石の色を指定します</param>
    ''' <remarks>黒が先手になります。</remarks>
    Private Sub Start(ByVal PlayerColor As CellStatus)
        Grid.Initialize()
        Me.PlayerColor = PlayerColor

        If PlayerColor = CellStatus.Black Then
            Computer.Standard = CellStatus.White 'コンピュータの色は白
            lblWhiteTurn.Visible = False
            lblBlackTurn.Visible = True
        Else
            Computer.Standard = CellStatus.Black 'コンピュータの色は黒
            lblWhiteTurn.Visible = True
            lblBlackTurn.Visible = False
        End If

        '現在の白と黒の駒の数を表示する。
        lblBlackCount.Text = Grid.Count(CellStatus.Black)
        lblWhiteCount.Text = Grid.Count(CellStatus.White)

        'そのため仮に今は白の番であることとする。
        Turn = CellStatus.White
        ChangeTurn()

        'lblWhiteTurn.Visible = False '★修正対象メソッド（黒番COMPUTERからのゲーム開始時、初回の白番で黒音声流れる不具合有り。)
        'lblBlackTurn.Visible = True

    End Sub

    '''<summary>石をひっくり返すテストコード</summary>
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ThisCell As Cell
        ThisCell = Grid.Cells(3, 3)
        Select Case ThisCell.Status
            Case CellStatus.Black
                ThisCell.Status = CellStatus.White
            Case CellStatus.White
                ThisCell.Status = CellStatus.Black
        End Select
        PictureBox1.Invalidate() '表示を更新する
    End Sub

    '音声ファイルを読み込む
    Private WhiteVoice As System.IO.Stream = My.Resources.バルサミコ酢
    Private BlackVoice As System.IO.Stream = My.Resources.なっとくいかねぇ

    Private PlayVoice As System.IO.Stream = Nothing

    ''' <summary>石を置いたときに発生するイベント</summary>
    Private Sub Grid_PutNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.PutNew
        Call Grid_Reversed(sender, e)

        '◆追加_黒番で石を置いた時のVoice処理
        'If lblBlackTurn.Visible = True Then
        If lblBlackTurn.Visible = True Then
            PlayVoice = BlackVoice
        Else
            PlayVoice = WhiteVoice
        End If

        PlayVoice.Seek(0, SeekOrigin.Begin)

        My.Computer.Audio.Play(PlayVoice, AudioPlayMode.Background)

    End Sub

    '''<Summary>石がひっくり返された時に発生するイベント</Summary>
    Private Sub Grid_Reversed(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Grid.Reversed
        '現在の状態を描画(PictureBox1のPaintイベントを発生させる)
        PictureBox1.Invalidate()
        '現在の黒と白の石の色の数を表示する
        lblBlackCount.Text = Grid.Count(CellStatus.Black)
        lblWhiteCount.Text = Grid.Count(CellStatus.White)
        'ちょっと時間を置く
        Application.DoEvents()
        System.Threading.Thread.Sleep(500)
    End Sub

    ''' <summary>ゲーム初期化</summary>
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Form1_Load(sender, e) 'Startメソッドを使用するため不要
        Start(Computer.Standard)
        PictureBox1.Invalidate()
    End Sub

    ''' <summary>コンピュータのレベル変更フォームを起動します</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AILEVELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AILEVELToolStripMenuItem.Click
        Dim f As New AILevelForm
        f.Owner = Me
        f.ShowDialog()
    End Sub

    '''<summary>黒（先手）で開始</summary>
    Private Sub btnStartBlack_Click(sender As Object, e As EventArgs) Handles btnStartBlack.Click
        Start(CellStatus.Black)
    End Sub

    '''<summary>白（先手）で開始</summary>
    Private Sub btnStartWhite_Click(sender As Object, e As EventArgs) Handles btnStartWhite.Click
        Start(CellStatus.White)
    End Sub
End Class
