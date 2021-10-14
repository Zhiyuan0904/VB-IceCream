<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ingredientButton = New System.Windows.Forms.Button()
        Me.flavourButton = New System.Windows.Forms.Button()
        Me.toppingButton = New System.Windows.Forms.Button()
        Me.baseButton = New System.Windows.Forms.Button()
        Me.handpackedButton = New System.Windows.Forms.Button()
        Me.welcomepageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ingredientButton
        '
        Me.ingredientButton.Location = New System.Drawing.Point(694, 297)
        Me.ingredientButton.Name = "ingredientButton"
        Me.ingredientButton.Size = New System.Drawing.Size(209, 100)
        Me.ingredientButton.TabIndex = 0
        Me.ingredientButton.Text = "Ingredient"
        Me.ingredientButton.UseVisualStyleBackColor = True
        '
        'flavourButton
        '
        Me.flavourButton.Location = New System.Drawing.Point(950, 297)
        Me.flavourButton.Name = "flavourButton"
        Me.flavourButton.Size = New System.Drawing.Size(193, 100)
        Me.flavourButton.TabIndex = 1
        Me.flavourButton.Text = "Flavour"
        Me.flavourButton.UseVisualStyleBackColor = True
        '
        'toppingButton
        '
        Me.toppingButton.Location = New System.Drawing.Point(694, 431)
        Me.toppingButton.Name = "toppingButton"
        Me.toppingButton.Size = New System.Drawing.Size(209, 99)
        Me.toppingButton.TabIndex = 2
        Me.toppingButton.Text = "Topping"
        Me.toppingButton.UseVisualStyleBackColor = True
        '
        'baseButton
        '
        Me.baseButton.Location = New System.Drawing.Point(950, 426)
        Me.baseButton.Name = "baseButton"
        Me.baseButton.Size = New System.Drawing.Size(193, 104)
        Me.baseButton.TabIndex = 3
        Me.baseButton.Text = "Ice Cream Base"
        Me.baseButton.UseVisualStyleBackColor = True
        '
        'handpackedButton
        '
        Me.handpackedButton.Location = New System.Drawing.Point(694, 553)
        Me.handpackedButton.Name = "handpackedButton"
        Me.handpackedButton.Size = New System.Drawing.Size(209, 96)
        Me.handpackedButton.TabIndex = 4
        Me.handpackedButton.Text = "Handpacked"
        Me.handpackedButton.UseVisualStyleBackColor = True
        '
        'welcomepageButton
        '
        Me.welcomepageButton.Location = New System.Drawing.Point(950, 553)
        Me.welcomepageButton.Name = "welcomepageButton"
        Me.welcomepageButton.Size = New System.Drawing.Size(193, 132)
        Me.welcomepageButton.TabIndex = 5
        Me.welcomepageButton.Text = "Exit To Welcome Page"
        Me.welcomepageButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1700, 922)
        Me.Controls.Add(Me.welcomepageButton)
        Me.Controls.Add(Me.handpackedButton)
        Me.Controls.Add(Me.baseButton)
        Me.Controls.Add(Me.toppingButton)
        Me.Controls.Add(Me.flavourButton)
        Me.Controls.Add(Me.ingredientButton)
        Me.Name = "MainMenu"
        Me.Text = "Ice Cream Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ingredientButton As Button
    Friend WithEvents flavourButton As Button
    Friend WithEvents toppingButton As Button
    Friend WithEvents baseButton As Button
    Friend WithEvents handpackedButton As Button
    Friend WithEvents welcomepageButton As Button
End Class
