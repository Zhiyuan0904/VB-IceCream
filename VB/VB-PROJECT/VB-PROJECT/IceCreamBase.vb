Public Class IceCreamBase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub IceCream_Base_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IceCream_Base_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IceCream_Base_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub IceCreamBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.IceCream_Base_Stock' table. You can move, or remove it, as needed.
        Me.IceCream_Base_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.IceCream_Base_Stock)

    End Sub
End Class