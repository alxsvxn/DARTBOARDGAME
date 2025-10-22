<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartBoardForm
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
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ThrowButton = New System.Windows.Forms.Button()
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
        Me.ThrowButton.Location = New System.Drawing.Point(288, 297)
        Me.ThrowButton.Name = "ThrowButton"
        Me.ThrowButton.Size = New System.Drawing.Size(217, 151)
        Me.ThrowButton.TabIndex = 1
        Me.ThrowButton.Text = "THROW YAM!"
        Me.ThrowButton.UseVisualStyleBackColor = True
        '
        'DartBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ThrowButton)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "DartBoardForm"
        Me.Text = "Form1"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ThrowButton As Button
End Class
