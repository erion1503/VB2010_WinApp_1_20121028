'Public Class Constant

'End Class

'■CellStatus　■状態の保持
''' <summary>セルの状態を表します。</summary>
Public Enum CellStatus
    [Nothing] 'なし
    Black '黒
    White '白
End Enum

'■ScanDirection
'''<summary>方向を表示します。</summary>
Public Enum ScanDirection
    Left
    Right
    Up
    Down
    LeftUp
    LeftDown
    RightUp
    RightDown
End Enum
