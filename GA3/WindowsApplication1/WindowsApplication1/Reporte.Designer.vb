<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PC3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loginVSDataSet1 = New WindowsApplication1.loginVSDataSet1()
        Me.PC3TableAdapter = New WindowsApplication1.loginVSDataSet1TableAdapters.PC3TableAdapter()
        CType(Me.PC3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginVSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ReportW"
        ReportDataSource1.Value = Me.PC3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(769, 343)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!)
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(12, 361)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 42)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PC3BindingSource
        '
        Me.PC3BindingSource.DataMember = "PC3"
        Me.PC3BindingSource.DataSource = Me.loginVSDataSet1
        '
        'loginVSDataSet1
        '
        Me.loginVSDataSet1.DataSetName = "loginVSDataSet1"
        Me.loginVSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PC3TableAdapter
        '
        Me.PC3TableAdapter.ClearBeforeFill = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 498)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.PC3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginVSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PC3BindingSource As BindingSource
    Friend WithEvents loginVSDataSet1 As loginVSDataSet1
    Friend WithEvents PC3TableAdapter As loginVSDataSet1TableAdapters.PC3TableAdapter
    Friend WithEvents Button3 As Button
End Class
