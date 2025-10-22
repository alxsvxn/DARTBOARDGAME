<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DartBoardForm
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
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ThrowButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LogButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearHistoryButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(776, 279)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ThrowButton
        '
        Me.ThrowButton.Location = New System.Drawing.Point(111, 297)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(217, 151)
        Me.ThrowButton.TabIndex = 1
        Me.ThrowButton.Text = "THROW YAM!"
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 297)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 75)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear YAMS!!!"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(491, 297)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 141)
        Me.TextBox1.TabIndex = 3
        '
        'LogButton
        '
        Me.LogButton.Location = New System.Drawing.Point(334, 297)
        Me.LogButton.Name = "LogButton"
        Me.LogButton.Size = New System.Drawing.Size(151, 75)
        Me.LogButton.TabIndex = 4
        Me.LogButton.Text = "YAM History"
        Me.LogButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 373)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 75)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit Yam Thrower"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearHistoryButton
        '
        Me.ClearHistoryButton.Location = New System.Drawing.Point(334, 373)
        Me.ClearHistoryButton.Name = "ClearHistoryButton"
        Me.ClearHistoryButton.Size = New System.Drawing.Size(151, 75)
        Me.ClearHistoryButton.TabIndex = 6
        Me.ClearHistoryButton.Text = "CLEANSE YAM HISTORY"
        Me.ClearHistoryButton.UseVisualStyleBackColor = True
        '
        'DartBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClearHistoryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LogButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ThrowButton)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "DartBoardForm"
        Me.Text = "Form1"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ThrowButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LogButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearHistoryButton As Button
End Class
