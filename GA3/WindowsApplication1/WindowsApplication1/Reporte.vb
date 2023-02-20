Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'loginVSDataSet1.PC3' table. You can move, or remove it, as needed.
        Me.PC3TableAdapter.Fill(Me.loginVSDataSet1.PC3)
        Dim F = Factura
        Me.PC3TableAdapter.FillBy(Me.loginVSDataSet1.PC3, F.NoFactura.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Factura.Show()
        Me.Close()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class