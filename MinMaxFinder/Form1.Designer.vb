<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.n1 = New System.Windows.Forms.NumericUpDown()
        Me.n2 = New System.Windows.Forms.NumericUpDown()
        Me.n3 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.minLabel = New System.Windows.Forms.Label()
        Me.maxLabel = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.n4 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.n1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.n2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.n3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.n4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'n1
        '
        Me.n1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.n1.Location = New System.Drawing.Point(24, 101)
        Me.n1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.n1.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(73, 23)
        Me.n1.TabIndex = 0
        '
        'n2
        '
        Me.n2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.n2.Location = New System.Drawing.Point(128, 101)
        Me.n2.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.n2.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(73, 23)
        Me.n2.TabIndex = 1
        '
        'n3
        '
        Me.n3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.n3.Location = New System.Drawing.Point(24, 141)
        Me.n3.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.n3.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(73, 23)
        Me.n3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Sirens DEMO", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(-4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(233, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MIN - MAX FINDER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Sirens DEMO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(87, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MIN"
        '
        'minLabel
        '
        Me.minLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minLabel.Font = New System.Drawing.Font("Sirens DEMO", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minLabel.Location = New System.Drawing.Point(-4, 224)
        Me.minLabel.Name = "minLabel"
        Me.minLabel.Size = New System.Drawing.Size(233, 37)
        Me.minLabel.TabIndex = 5
        Me.minLabel.Text = "0"
        Me.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maxLabel
        '
        Me.maxLabel.Font = New System.Drawing.Font("Sirens DEMO", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.maxLabel.Location = New System.Drawing.Point(-4, 288)
        Me.maxLabel.Name = "maxLabel"
        Me.maxLabel.Size = New System.Drawing.Size(233, 37)
        Me.maxLabel.TabIndex = 7
        Me.maxLabel.Text = "0"
        Me.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label3.Font = New System.Drawing.Font("Sirens DEMO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label3.ForeColor = System.Drawing.Color.Orange
        Me.label3.Location = New System.Drawing.Point(87, 325)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(45, 21)
        Me.label3.TabIndex = 6
        Me.label3.Text = "max"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(-4, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Input 4 numbers and the program will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "find the min and max"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'n4
        '
        Me.n4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.n4.Location = New System.Drawing.Point(128, 141)
        Me.n4.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.n4.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(73, 23)
        Me.n4.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "FInd"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 353)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.n4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.maxLabel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.minLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.n3)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.n1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.n1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.n2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.n3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.n4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents n1 As NumericUpDown
    Friend WithEvents n2 As NumericUpDown
    Friend WithEvents n3 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents minLabel As Label
    Friend WithEvents maxLabel As Label
    Friend WithEvents label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents n4 As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
