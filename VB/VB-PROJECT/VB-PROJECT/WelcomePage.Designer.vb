<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Ice Cream Management System"
        '
        'enterButton
        '
        Me.enterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.enterButton.ForeColor = System.Drawing.Color.Black
        Me.enterButton.Location = New System.Drawing.Point(382, 320)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(111, 43)
        Me.enterButton.TabIndex = 2
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.exitButton.Location = New System.Drawing.Point(622, 320)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 43)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 601)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "WelcomePage"
        Me.Text = "Welcome Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents enterButton As Button
    Friend WithEvents exitButton As Button
End Class
