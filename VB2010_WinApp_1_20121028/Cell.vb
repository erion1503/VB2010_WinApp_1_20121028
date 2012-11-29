Public Class Cell
    Public Status As CellStatus 'セルの状態。黒・白・空。
    Public Grid As ReverseGrid
    Public Position As Point '論理位置
    Public Rectangle As Rectangle '物理位置
    Public Focused As Boolean

    '■コンストラクタ
    ''' <summary>論理位置を指定してセルを作成します。</summary>
    ''' <param name="Grid">セルが属するグリッドを指定します。</param>
    ''' <param name="Position">セルの倫理位置を指定します。</param>
    Public Sub New(ByVal Grid As ReverseGrid, ByVal Position As Point)
        Me.Grid = Grid
        Me.Position = Position
        Dim Rect As New Rectangle
        '論理位置から物理位置を求めます。
        Rect.X = Position.X * ReverseGrid.CellSize
        Rect.Y = Position.Y * ReverseGrid.CellSize
        Rect.Width = ReverseGrid.CellSize
        Rect.Height = ReverseGrid.CellSize
        Me.Rectangle = Rect
    End Sub

    '画像ファイルを読み込む
    Private BlackImage As Image = My.Resources.かがみ_黒
    Private WhiteImage As Image = My.Resources.つかさ_白

    '■Draw
    ''' <summary>現在の状態を描画します。</summary>
    ''' <param name="g">描画対象のGraphicsオブジェクトを指定します。</param>
    Public Sub Draw(ByVal g As Graphics)
        Dim CellRect As Rectangle = Me.Rectangle '描画領域
        '▼描画領域の算定
        'セルいっぱいに描画するとぎちぎちになるので範囲を-2にする。
        CellRect = Me.Rectangle
        CellRect.Inflate(-2, -2)
        '▼描画実行
        Select Case Me.Status
            Case CellStatus.Black
                g.DrawImage(BlackImage, CellRect)
            Case CellStatus.White
                g.DrawImage(WhiteImage, CellRect)
        End Select

        '▼アクティブな場合は枠を描画する
        If Me.Focused Then
            g.DrawRectangle(Pens.Orange, CellRect)
        End If
    End Sub

    '■Focus
    ''' <summary>セルをアクティブにします。</summary>
    ''' <remarks>アクティブなセルとはFocusedプロパティがTrueのセルです。
    ''' このメソッドを呼び出すを同じ盤に属する他のセルのFocusedプロパティをFalseにします。
    ''' アクティブであることにそれ以上の効果はありませんが、
    ''' 描画の際にFocusedプロパティがTrueのセルに枠線を描画します。
    ''' </remarks>
    Public Sub Focus()
        Dim X As Integer
        Dim Y As Integer
        '同じグリッドに属する自分以外のセルを非アクティブにする。
        For Y = 0 To ReverseGrid.YCount - 1
            For X = 0 To ReverseGrid.XCount - 1
                Grid.Cells(X, Y).Focused = False
            Next
        Next
        '自分自身をアクティブにする。
        Me.Focused = True
    End Sub
End Class
