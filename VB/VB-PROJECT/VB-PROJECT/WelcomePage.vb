Public Class WelcomePage
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
