<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dtgv = New System.Windows.Forms.DataGridView()
        Me.NombreDeUsuario = New System.Windows.Forms.TextBox()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vereficar = New System.Windows.Forms.TextBox()
        Me.VContraseña = New System.Windows.Forms.Label()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv
        '
        Me.dtgv.AllowUserToAddRows = False
        Me.dtgv.AllowUserToDeleteRows = False
        Me.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv.Location = New System.Drawing.Point(-318, 462)
        Me.dtgv.Name = "dtgv"
        Me.dtgv.ReadOnly = True
        Me.dtgv.Size = New System.Drawing.Size(410, 158)
        Me.dtgv.TabIndex = 0
        '
        'NombreDeUsuario
        '
        Me.NombreDeUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.NombreDeUsuario.ForeColor = System.Drawing.Color.Teal
        Me.NombreDeUsuario.Location = New System.Drawing.Point(283, 166)
        Me.NombreDeUsuario.Name = "NombreDeUsuario"
        Me.NombreDeUsuario.Size = New System.Drawing.Size(171, 32)
        Me.NombreDeUsuario.TabIndex = 2
        '
        'Siguiente
        '
        Me.Siguiente.BackColor = System.Drawing.Color.Transparent
        Me.Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Siguiente.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Siguiente.ForeColor = System.Drawing.Color.LightGreen
        Me.Siguiente.Location = New System.Drawing.Point(283, 317)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(171, 40)
        Me.Siguiente.TabIndex = 3
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = False
        '
        'Contraseña
        '
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Contraseña.ForeColor = System.Drawing.Color.Teal
        Me.Contraseña.Location = New System.Drawing.Point(283, 209)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(171, 32)
        Me.Contraseña.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button1.ForeColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(497, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(278, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inicar Sesión"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Vereficar
        '
        Me.Vereficar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Vereficar.ForeColor = System.Drawing.Color.Teal
        Me.Vereficar.Location = New System.Drawing.Point(283, 247)
        Me.Vereficar.Name = "Vereficar"
        Me.Vereficar.Size = New System.Drawing.Size(171, 32)
        Me.Vereficar.TabIndex = 10
        '
        'VContraseña
        '
        Me.VContraseña.AutoSize = True
        Me.VContraseña.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VContraseña.Location = New System.Drawing.Point(57, 254)
        Me.VContraseña.Name = "VContraseña"
        Me.VContraseña.Size = New System.Drawing.Size(199, 25)
        Me.VContraseña.TabIndex = 11
        Me.VContraseña.Text = "Verificar Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 512)
        Me.Controls.Add(Me.VContraseña)
        Me.Controls.Add(Me.Vereficar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.NombreDeUsuario)
        Me.Controls.Add(Me.dtgv)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgv As DataGridView
    Friend WithEvents NombreDeUsuario As TextBox
    Friend WithEvents Siguiente As Button
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Vereficar As TextBox
    Friend WithEvents VContraseña As Label
End Class
