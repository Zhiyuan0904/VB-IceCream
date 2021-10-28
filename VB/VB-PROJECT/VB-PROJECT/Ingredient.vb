Public Class Ingredient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Ingredients_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ingredients_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ingredients_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub Ingredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.Ingredients_Stock' table. You can move, or remove it, as needed.
        Me.Ingredients_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.Ingredients_Stock)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ingredients_StockBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ingredients_StockBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        Ingredients_StockBindingSource.EndEdit()
        Ingredients_StockTableAdapter.Update(_VB_PROJECTDataSet.Ingredients_Stock)
        MessageBox.Show(”OK”)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ingredients_StockBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ingredients_StockBindingSource.MoveNext()
    End Sub
End Class