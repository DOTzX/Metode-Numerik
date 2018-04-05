Public Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Opacity = 0
        tmrOpacityManager.Enabled = True
    End Sub

    Private Sub tmrOpacityManager_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOpacityManager.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity >= 1 Then
            tmrOpacityManager.Enabled = False
            frmMain.Show()
            Me.Hide()
        End If
    End Sub

End Class