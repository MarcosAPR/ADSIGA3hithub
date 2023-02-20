<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtMostrar = New System.Windows.Forms.Button()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.BtIngresar = New System.Windows.Forms.Button()
        Me.BtActualizar = New System.Windows.Forms.Button()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtEdad = New System.Windows.Forms.NumericUpDown()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(263, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Eres Administrador"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(598, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Teal
        Me.TxtNombre.Location = New System.Drawing.Point(12, 134)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 21)
        Me.TxtNombre.TabIndex = 3
        '
        'BtMostrar
        '
        Me.BtMostrar.BackColor = System.Drawing.Color.White
        Me.BtMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtMostrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtMostrar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.BtMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtMostrar.Location = New System.Drawing.Point(118, 346)
        Me.BtMostrar.Name = "BtMostrar"
        Me.BtMostrar.Size = New System.Drawing.Size(100, 40)
        Me.BtMostrar.TabIndex = 4
        Me.BtMostrar.Text = "Mosrar"
        Me.BtMostrar.UseVisualStyleBackColor = False
        '
        'BtBuscar
        '
        Me.BtBuscar.BackColor = System.Drawing.Color.White
        Me.BtBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtBuscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.BtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtBuscar.Location = New System.Drawing.Point(12, 346)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(100, 40)
        Me.BtBuscar.TabIndex = 5
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = False
        '
        'BtIngresar
        '
        Me.BtIngresar.BackColor = System.Drawing.Color.White
        Me.BtIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtIngresar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.BtIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtIngresar.Location = New System.Drawing.Point(374, 346)
        Me.BtIngresar.Name = "BtIngresar"
        Me.BtIngresar.Size = New System.Drawing.Size(100, 40)
        Me.BtIngresar.TabIndex = 6
        Me.BtIngresar.Text = "Ingresar"
        Me.BtIngresar.UseVisualStyleBackColor = False
        '
        'BtActualizar
        '
        Me.BtActualizar.BackColor = System.Drawing.Color.White
        Me.BtActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtActualizar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.BtActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtActualizar.Location = New System.Drawing.Point(268, 300)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(206, 40)
        Me.BtActualizar.TabIndex = 7
        Me.BtActualizar.Text = "Actualizar"
        Me.BtActualizar.UseVisualStyleBackColor = False
        '
        'BtEliminar
        '
        Me.BtEliminar.BackColor = System.Drawing.Color.White
        Me.BtEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.BtEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtEliminar.Location = New System.Drawing.Point(268, 346)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(100, 40)
        Me.BtEliminar.TabIndex = 8
        Me.BtEliminar.Text = "Eliminar"
        Me.BtEliminar.UseVisualStyleBackColor = False
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.ForeColor = System.Drawing.Color.Teal
        Me.TxtApellido.Location = New System.Drawing.Point(12, 160)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(100, 21)
        Me.TxtApellido.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.Teal
        Me.TxtEmail.Location = New System.Drawing.Point(12, 212)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 21)
        Me.TxtEmail.TabIndex = 11
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.ForeColor = System.Drawing.Color.Teal
        Me.TxtTelefono.Location = New System.Drawing.Point(12, 238)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 21)
        Me.TxtTelefono.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(118, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(118, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(118, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Edad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(118, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Email"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(118, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Telefono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGV
        '
        Me.DataGV.AllowUserToAddRows = False
        Me.DataGV.AllowUserToDeleteRows = False
        Me.DataGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Location = New System.Drawing.Point(268, 107)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.ReadOnly = True
        Me.DataGV.Size = New System.Drawing.Size(447, 151)
        Me.DataGV.TabIndex = 18
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.Teal
        Me.txtId.Location = New System.Drawing.Point(12, 108)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 21)
        Me.txtId.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(118, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Id"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 40)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(12, 187)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdad.TabIndex = 24
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(727, 512)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.BtEliminar)
        Me.Controls.Add(Me.BtActualizar)
        Me.Controls.Add(Me.BtIngresar)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.BtMostrar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtMostrar As Button
    Friend WithEvents BtBuscar As Button
    Friend WithEvents BtIngresar As Button
    Friend WithEvents BtActualizar As Button
    Friend WithEvents BtEliminar As Button
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGV As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtEdad As NumericUpDown
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
