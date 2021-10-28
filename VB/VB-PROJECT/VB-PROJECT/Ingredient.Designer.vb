<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodeLabel As System.Windows.Forms.Label
        Dim Stock_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredient))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Ingredients_StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._VB_PROJECTDataSet = New VB_PROJECT._VB_PROJECTDataSet()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingredients_StockTableAdapter = New VB_PROJECT._VB_PROJECTDataSetTableAdapters.Ingredients_StockTableAdapter()
        Me.TableAdapterManager = New VB_PROJECT._VB_PROJECTDataSetTableAdapters.TableAdapterManager()
        Me.Ingredients_StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Ingredients_StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CodeLabel = New System.Windows.Forms.Label()
        Stock_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ingredients_StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._VB_PROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingredients_StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ingredients_StockBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(126, 87)
        CodeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(91, 32)
        CodeLabel.TabIndex = 0
        CodeLabel.Text = "Code:"
        '
        'Stock_IDLabel
        '
        Stock_IDLabel.AutoSize = True
        Stock_IDLabel.Location = New System.Drawing.Point(126, 141)
        Stock_IDLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Stock_IDLabel.Name = "Stock_IDLabel"
        Stock_IDLabel.Size = New System.Drawing.Size(128, 32)
        Stock_IDLabel.TabIndex = 2
        Stock_IDLabel.Text = "Stock ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(126, 196)
        NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(98, 32)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(126, 250)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(130, 32)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Quantity:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 100
        Me.Button1.Location = New System.Drawing.Point(63, 1038)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.CodeTextBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Stock_IDLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Stock_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 112)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1194, 418)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingredients"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(922, 218)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(183, 46)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "NEXT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(922, 141)
        Me.Button5.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(183, 46)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "PREVIOUS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(675, 260)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 46)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(675, 182)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 46)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ingredients_StockBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(268, 81)
        Me.CodeTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(196, 38)
        Me.CodeTextBox.TabIndex = 1
        '
        'Ingredients_StockBindingSource
        '
        Me.Ingredients_StockBindingSource.DataMember = "Ingredients Stock"
        Me.Ingredients_StockBindingSource.DataSource = Me._VB_PROJECTDataSet
        '
        '_VB_PROJECTDataSet
        '
        Me._VB_PROJECTDataSet.DataSetName = "_VB_PROJECTDataSet"
        Me._VB_PROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(675, 105)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 46)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ingredients_StockBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(268, 190)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(196, 38)
        Me.NameTextBox.TabIndex = 5
        '
        'Stock_IDTextBox
        '
        Me.Stock_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ingredients_StockBindingSource, "Stock ID", True))
        Me.Stock_IDTextBox.Location = New System.Drawing.Point(268, 136)
        Me.Stock_IDTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Stock_IDTextBox.Name = "Stock_IDTextBox"
        Me.Stock_IDTextBox.Size = New System.Drawing.Size(196, 38)
        Me.Stock_IDTextBox.TabIndex = 3
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ingredients_StockBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(268, 244)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(196, 38)
        Me.QuantityTextBox.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 583)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1194, 418)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " List Ingredient Stock"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.StockIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Ingredients_StockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 81)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1114, 291)
        Me.DataGridView1.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.Width = 125
        '
        'StockIDDataGridViewTextBoxColumn
        '
        Me.StockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock ID"
        Me.StockIDDataGridViewTextBoxColumn.HeaderText = "Stock ID"
        Me.StockIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockIDDataGridViewTextBoxColumn.Name = "StockIDDataGridViewTextBoxColumn"
        Me.StockIDDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'Ingredients_StockTableAdapter
        '
        Me.Ingredients_StockTableAdapter.ClearBeforeFill = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Flavour_StockTableAdapter = Nothing
        Me.TableAdapterManager.Handpacked_StockTableAdapter = Nothing
        Me.TableAdapterManager.IceCream_Base_StockTableAdapter = Nothing
        Me.TableAdapterManager.Ingredients_StockTableAdapter = Me.Ingredients_StockTableAdapter
        Me.TableAdapterManager.List_Stock_CategoryTableAdapter = Nothing
        Me.TableAdapterManager.Toppings_StockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VB_PROJECT._VB_PROJECTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ingredients_StockBindingNavigator
        '
        Me.Ingredients_StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Ingredients_StockBindingNavigator.BindingSource = Me.Ingredients_StockBindingSource
        Me.Ingredients_StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Ingredients_StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ingredients_StockBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Ingredients_StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Ingredients_StockBindingNavigatorSaveItem})
        Me.Ingredients_StockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Ingredients_StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Ingredients_StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Ingredients_StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Ingredients_StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Ingredients_StockBindingNavigator.Name = "Ingredients_StockBindingNavigator"
        Me.Ingredients_StockBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.Ingredients_StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Ingredients_StockBindingNavigator.Size = New System.Drawing.Size(2350, 48)
        Me.Ingredients_StockBindingNavigator.TabIndex = 3
        Me.Ingredients_StockBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(87, 41)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 48)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(96, 47)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(58, 41)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'Ingredients_StockBindingNavigatorSaveItem
        '
        Me.Ingredients_StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ingredients_StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("Ingredients_StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Ingredients_StockBindingNavigatorSaveItem.Name = "Ingredients_StockBindingNavigatorSaveItem"
        Me.Ingredients_StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 41)
        Me.Ingredients_StockBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2350, 1136)
        Me.Controls.Add(Me.Ingredients_StockBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Ingredient"
        Me.Text = "Ingredient | Ice Cream Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ingredients_StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._VB_PROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingredients_StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ingredients_StockBindingNavigator.ResumeLayout(False)
        Me.Ingredients_StockBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents _VB_PROJECTDataSet As _VB_PROJECTDataSet
    Friend WithEvents Ingredients_StockBindingSource As BindingSource
    Friend WithEvents Ingredients_StockTableAdapter As _VB_PROJECTDataSetTableAdapters.Ingredients_StockTableAdapter
    Friend WithEvents TableAdapterManager As _VB_PROJECTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ingredients_StockBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Ingredients_StockBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Stock_IDTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
