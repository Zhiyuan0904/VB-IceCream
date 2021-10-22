Public Class Handpacked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Handpacked_StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click, MyBase_StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Handpacked_StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._VB_PROJECTDataSet)

    End Sub

    Private Sub Handpacked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_VB_PROJECTDataSet.Handpacked_Stock' table. You can move, or remove it, as needed.
        Me.Handpacked_StockTableAdapter.Fill(Me._VB_PROJECTDataSet.Handpacked_Stock)

    End Sub
End Class