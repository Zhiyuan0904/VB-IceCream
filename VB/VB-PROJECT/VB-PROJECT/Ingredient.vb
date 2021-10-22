Public Class Ingredient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Ingredients_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ingredients_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub Ingredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.Ingredients_Stock' table. You can move, or remove it, as needed.
        Me.Ingredients_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.Ingredients_Stock)

    End Sub
End Class