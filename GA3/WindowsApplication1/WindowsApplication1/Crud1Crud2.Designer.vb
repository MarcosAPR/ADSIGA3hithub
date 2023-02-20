<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crud1Crud2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button1.ForeColor = System.Drawing.Color.Peru
        Me.Button1.Location = New System.Drawing.Point(156, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 32)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Crud1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button2.ForeColor = System.Drawing.Color.Peru
        Me.Button2.Location = New System.Drawing.Point(314, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 32)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Crud2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Peru
        Me.Label29.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Label29.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label29.Location = New System.Drawing.Point(77, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(434, 25)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "A donde quieres ir?"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button7.ForeColor = System.Drawing.Color.Maroon
        Me.Button7.Location = New System.Drawing.Point(223, 232)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(134, 58)
        Me.Button7.TabIndex = 74
        Me.Button7.Text = "Regresar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Crud1Crud2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 322)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Crud1Crud2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crud1Crud2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Button7 As Button
End Class
