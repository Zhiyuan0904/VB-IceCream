Public Class Flavour
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Flavour_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Flavour_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub Flavour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.Flavour_Stock' table. You can move, or remove it, as needed.
        Me.Flavour_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.Flavour_Stock)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class