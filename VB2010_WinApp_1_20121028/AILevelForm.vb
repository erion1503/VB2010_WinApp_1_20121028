Public Class AILevelForm

    ''' <summary>コンピュータの強さ変更</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If RadioBtnEasy.Checked = True Then


        ElseIf RadioBtnNormal.Checked = True Then

        Else

        End If
    End Sub

    ''' <summary>コンピュータの強さ変更キャンセル</summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class