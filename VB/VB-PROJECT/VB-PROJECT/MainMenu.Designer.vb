<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ingredientButton = New System.Windows.Forms.Button()
        Me.toppingButton = New System.Windows.Forms.Button()
        Me.flavourButton = New System.Windows.Forms.Button()
        Me.baseButton = New System.Windows.Forms.Button()
        Me.handpackedButton = New System.Windows.Forms.Button()
        Me.welcomepageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ingredientButton
        '
        Me.ingredientButton.Location = New System.Drawing.Point(400, 69)
        Me.ingredientButton.Name = "ingredientButton"
        Me.ingredientButton.Size = New System.Drawing.Size(103, 56)
        Me.ingredientButton.TabIndex = 0
        Me.ingredientButton.Text = "Ingredient"
        Me.ingredientButton.UseVisualStyleBackColor = True
        '
        'toppingButton
        '
        Me.toppingButton.Location = New System.Drawing.Point(540, 69)
        Me.toppingButton.Name = "toppingButton"
        Me.toppingButton.Size = New System.Drawing.Size(103, 56)
        Me.toppingButton.TabIndex = 1
        Me.toppingButton.Text = "Topping"
        Me.toppingButton.UseVisualStyleBackColor = True
        '
        'flavourButton
        '
        Me.flavourButton.Location = New System.Drawing.Point(698, 69)
        Me.flavourButton.Name = "flavourButton"
        Me.flavourButton.Size = New System.Drawing.Size(103, 56)
        Me.flavourButton.TabIndex = 2
        Me.flavourButton.Text = "Flavour"
        Me.flavourButton.UseVisualStyleBackColor = True
        '
        'baseButton
        '
        Me.baseButton.Location = New System.Drawing.Point(400, 166)
        Me.baseButton.Name = "baseButton"
        Me.baseButton.Size = New System.Drawing.Size(103, 56)
        Me.baseButton.TabIndex = 3
        Me.baseButton.Text = "Ice Cream Base"
        Me.baseButton.UseVisualStyleBackColor = True
        '
        'handpackedButton
        '
        Me.handpackedButton.Location = New System.Drawing.Point(540, 170)
        Me.handpackedButton.Name = "handpackedButton"
        Me.handpackedButton.Size = New System.Drawing.Size(112, 56)
        Me.handpackedButton.TabIndex = 4
        Me.handpackedButton.Text = "Handpacked"
        Me.handpackedButton.UseVisualStyleBackColor = True
        '
        'welcomepageButton
        '
        Me.welcomepageButton.Location = New System.Drawing.Point(698, 170)
        Me.welcomepageButton.Name = "welcomepageButton"
        Me.welcomepageButton.Size = New System.Drawing.Size(103, 56)
        Me.welcomepageButton.TabIndex = 5
        Me.welcomepageButton.Text = "Exit to welcome"
        Me.welcomepageButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 492)
        Me.Controls.Add(Me.welcomepageButton)
        Me.Controls.Add(Me.handpackedButton)
        Me.Controls.Add(Me.baseButton)
        Me.Controls.Add(Me.flavourButton)
        Me.Controls.Add(Me.toppingButton)
        Me.Controls.Add(Me.ingredientButton)
        Me.DoubleBuffered = True
        Me.Name = "MainMenu"
        Me.Text = " Ice Cream Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ingredientButton As Button
    Friend WithEvents toppingButton As Button
    Friend WithEvents flavourButton As Button
    Friend WithEvents baseButton As Button
    Friend WithEvents handpackedButton As Button
    Friend WithEvents welcomepageButton As Button
End Class
