Public Class frmGameOption
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If rdoEasy.Checked = True Then
            Dim eForm As New frmEasy
            eForm.Show()

        End If

        If rdoMedium.Checked = True Then
            Dim mForm As New frmMedium
            mForm.Show()

        End If

        If rdoHard.Checked = True Then
            Dim hForm As New frmHard
            hForm.Show()

        End If
    End Sub
End Class