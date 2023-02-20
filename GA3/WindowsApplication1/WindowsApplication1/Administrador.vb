'Librerias para conectar a Sql'
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text.RegularExpressions
Public Class Administrador
    'Variables para conectar'
    Dim con As New SqlConnection(My.Settings.loginVSConnectionString)
    Dim proceso, mensaje As String
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
    'Ocultar el form'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    'Ocultar todos los botones cuando cargue el form'
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtActualizar.Visible = False
        BtBuscar.Visible = False
        BtEliminar.Visible = False
        BtIngresar.Visible = False
        BtMostrar.Visible = False
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet

            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Proceso de buscar'
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        If TxtNombre.Text = "" Then
            MsgBox("Ingrese un nombre para buscar")
        Else
            Try
                Dim da As New SqlDataAdapter("select* from Curd where Nombre = '" + TxtNombre.Text + "'", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Me.DataGV.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    'Proceso de actualizar'
    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click
        If txtId.Text = "" And TxtNombre.Text = "" And TxtApellido.Text = "" And TxtEdad.Text = "" And TxtEmail.Text = "" And TxtTelefono.Text = "" Then
            MsgBox("Faltan datos.")
        Else
            Try
                Dim da As New SqlDataAdapter("update Curd set Nombre = '" + TxtNombre.Text + "', Apellido = '" + TxtApellido.Text + "', Edad = '" + TxtEdad.Text + "', Email = '" + TxtEmail.Text + "', Telefono = '" + TxtTelefono.Text + "' where Id = '" + txtId.Text + "'", con)
                Dim ds As New DataSet
                da.Fill(ds)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim da As New SqlDataAdapter("select* from Curd", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Me.DataGV.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    'Proceso de ingresar'
    Private Sub BtIngresar_Click(sender As Object, e As EventArgs) Handles BtIngresar.Click
        Dim formato As String = "^[\w._%-]+@[\w.-]+\.[a-zA/Z]{2,4}$"
        If txtId.Text = "" And TxtNombre.Text = "" And TxtApellido.Text = "" And TxtEdad.Text = "" And TxtEmail.Text = "" And TxtTelefono.Text = "" Then
            MsgBox("Faltan datos.")
        Else
            If TxtNombre.TextLength > 15 Or TxtApellido.TextLength > 15 Then
                MsgBox("Limite de caracter para nombre y edad es de 15")
            Else
                If TxtEdad.Value < 1 Then
                    MsgBox("Edad Erronea")
                Else
                    If Regex.IsMatch(TxtEmail.Text, formato) Then
                        Try
                            Dim da As New SqlDataAdapter("insert into Curd values ('" + txtId.Text + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + TxtEdad.Text + "','" + TxtEmail.Text + "','" + TxtTelefono.Text + "')", con)
                            Dim ds As New DataSet
                            da.Fill(ds)

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        Try
                            Dim da As New SqlDataAdapter("select* from Curd", con)
                            Dim ds As New DataSet
                            da.Fill(ds)
                            Me.DataGV.DataSource = ds.Tables(0)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        MsgBox("Correo invalido.")
                    End If
                End If
            End If

            End If


    End Sub
    'Proceso de eliminar'
    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click
        If txtId.Text = "" Then
            MsgBox("Necesita ingresar una Id.")
        Else
            Try
                Dim da As New SqlDataAdapter("delete curd where Id = '" + txtId.Text + "'", con)
                Dim ds As New DataSet
                da.Fill(ds)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim da As New SqlDataAdapter("select* from Curd", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Me.DataGV.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'Limpiar textbox'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtId.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtEdad.Text = ""
        TxtEmail.Text = ""
        TxtTelefono.Text = ""
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If ModifierKeys = Keys.Control Then
            e.Handled = True
            MsgBox("No se puede usar el portapapeles.")
        End If

        If Char.IsSymbol(e.KeyChar) Then
            MsgBox("Solo se permiten letras y numeros.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Char.IsSymbol(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            MsgBox("Solo se permiten letras.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress
        If Char.IsSymbol(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            MsgBox("Solo se permiten letras.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Solo se permiten numeros.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            MsgBox("Solo se permiten numeros.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    'Proceso de mostrar'
    Private Sub BtMostrar_Click(sender As Object, e As EventArgs) Handles BtMostrar.Click
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class