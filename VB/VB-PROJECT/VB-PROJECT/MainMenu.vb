Public Class MainMenu

    Private Sub ingredientButton_Click(sender As Object, e As EventArgs) Handles ingredientButton.Click
        Me.Hide()
        Ingredient.Show()
    End Sub

    Private Sub toppingButton_Click(sender As Object, e As EventArgs) Handles toppingButton.Click
        Me.Hide()
        Topping.Show()
    End Sub

    Private Sub flavourButton_Click(sender As Object, e As EventArgs) Handles flavourButton.Click
        Me.Hide()
        Flavour.Show()
    End Sub

    Private Sub baseButton_Click(sender As Object, e As EventArgs) Handles baseButton.Click
        Me.Hide()
        IceCreamBase.Show()
    End Sub

    Private Sub handpackedButton_Click(sender As Object, e As EventArgs) Handles handpackedButton.Click
        Me.Hide()
        Handpacked.Show()
    End Sub

    Private Sub welcomepageButton_Click(sender As Object, e As EventArgs) Handles welcomepageButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub
End Class