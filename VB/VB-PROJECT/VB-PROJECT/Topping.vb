Public Class Topping
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Toppings_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click, MyBases_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Toppings_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub Topping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.Toppings_Stock' table. You can move, or remove it, as needed.
        Me.Toppings_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.Toppings_Stock)

    End Sub
End Class