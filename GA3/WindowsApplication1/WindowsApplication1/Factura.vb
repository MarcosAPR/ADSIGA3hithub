Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Public Class Factura
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim da As New SqlDataAdapter("select* from PC3", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim con As New SqlConnection(My.Settings.loginVSConnectionString)
    Dim proceso, mensaje As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim da As New SqlDataAdapter("select* from PC3", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim da As New SqlDataAdapter("select* from PC3 where Nombre = '" + NoFactura.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New SqlDataAdapter("insert into PC3 values ('" + NoFactura.Text + "', '" + Fecha.Text + "', '" + CodCliente.Text + "', '" + Nombre.Text + "', '" + Direccion.Text + "', " + CodigoPostal.Text + ", '" + Provincia.Text + "', '" + Cif.Text + "', '" + Apellido.Text + "', '" + Poblacion.Text + "', " + Telefono.Text + ", '" + DireccionEmision.Text + "', '" + LugarEmision.Text + "', '" + NombreEmisor.Text + "', '" + ApellidoEmisor.Text + "', '" + HoraEmision.Text + "', '" + CodigoProducto.Text + "', '" + TipoProducto.Text + "', '" + NombreProducto.Text + "', " + Cantidad.Text + " , " + Precio.Text + " , '" + OrigenProducto.Text + "' , '" + Proveedor.Text + "' , '" + NombreEmpresa.Text + "' , '" + FechaEntrega.Text + "')", con)
        Try
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim da As New SqlDataAdapter("delete PC3 where NoFactura='" + NoFactura.Text + "'", con)
        Try
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim da As New SqlDataAdapter("update PC3 set Fecha = '" + Fecha.Text + "', CodCliente = '" + CodCliente.Text + "', nombre = '" + Nombre.Text + "', 
direccion ='" + Direccion.Text + "', CodigoPostal = " + CodigoPostal.Text + ", provincia = '" + Provincia.Text + "', Cif = '" + Cif.Text + "', 
apellido = '" + Apellido.Text + "', poblacion = '" + Poblacion.Text + "', telefono = " + Telefono.Text + ", DireccionEmision = '" + DireccionEmision.Text + "', 
NombreLugarEmision = '" + LugarEmision.Text + "', NombreEmisor = '" + NombreEmisor.Text + "', ApellidoEmisor = '" + ApellidoEmisor.Text + "', HoraEmision = '" + HoraEmision.Text + "', 
CodigoProducto = '" + CodigoProducto.Text + "', TipoProducto = '" + TipoProducto.Text + "', NombreProducto = '" + NombreProducto.Text + "', Cantidad = " + Cantidad.Text + " , 
Precio = " + Precio.Text + " , OrigenProducto = '" + OrigenProducto.Text + "' , ProveedorProducto = '" + Proveedor.Text + "' , NombreEmpresa = '" + NombreEmpresa.Text + "' , 
FechaEntradaDelProducto = '" + FechaEntrega.Text + "' where NoFactura = '" + NoFactura.Text + "'", con)
        Try
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If NoFactura.Text = "" Then
            MsgBox("Necesita un numero de factura (No. Factura)")
        Else
            Reporte.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form1.Show()
    End Sub




    'conectar a Sql'
    Sub EjecutarEnSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class