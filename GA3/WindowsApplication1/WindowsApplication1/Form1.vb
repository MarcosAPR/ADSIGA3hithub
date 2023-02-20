'Librerias para onectar a Sql'
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    'Variables para conectar a Sql'
    Dim con As New SqlConnection(My.Settings.loginVSConnectionString)
    Dim proceso, mensaje As String
    'Conectar a Sql'
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
    'Variable para espesificar el tipo de cuenta'
    Dim TipoDeCuenta As String

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        TipoDeCuenta = ""
        'condiciones para iniciar sesiòn'
        If Vereficar.Text = Contraseña.Text Then
            If NombreDeUsuario.Text <> "" And Contraseña.Text <> "" Then
                Try
                    Dim da As New SqlDataAdapter("IF EXISTS (SELECT * FROM Administrativo1 WHERE NombreA = 'A" + NombreDeUsuario.Text + "' and ContrasenaA = '" + Contraseña.Text + "') select* from Administrativo1;", con)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    Me.dtgv.DataSource = ds.Tables(0)
                    TipoDeCuenta = "1"
                Catch ex As Exception
                End Try


                Try
                    Dim da As New SqlDataAdapter("IF EXISTS (SELECT * FROM Administrativo1 WHERE NombreA = 'S" + NombreDeUsuario.Text + "' and ContrasenaA = '" + Contraseña.Text + "') select* from Administrativo1;", con)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    Me.dtgv.DataSource = ds.Tables(0)
                    TipoDeCuenta = "2"
                Catch ex As Exception
                End Try


                Try
                    Dim da As New SqlDataAdapter("IF EXISTS (SELECT * FROM Administrativo1 WHERE NombreA = 'C" + NombreDeUsuario.Text + "' and ContrasenaA = '" + Contraseña.Text + "') select* from Administrativo1;", con)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    Me.dtgv.DataSource = ds.Tables(0)
                    TipoDeCuenta = "3"
                Catch ex As Exception
                End Try
                'condiciones para ocultar botones de cada roll'

                If TipoDeCuenta = "1" Then
                    Me.Hide()
                    Crud1Crud2.Show()
                    Administrador.Label1.Text = "Eres Administrador"
                    Administrador.BtActualizar.Visible = True
                    Administrador.BtBuscar.Visible = True
                    Administrador.BtEliminar.Visible = True
                    Administrador.BtIngresar.Visible = True
                    Administrador.BtMostrar.Visible = True

                ElseIf TipoDeCuenta = "2" Then
                    Me.Hide()
                    Administrador.Show()
                    Administrador.Label1.Text = "Eres Secretaria"
                    Administrador.BtActualizar.Visible = True
                    Administrador.BtBuscar.Visible = True
                    Administrador.BtMostrar.Visible = True
                ElseIf TipoDeCuenta = "3" Then
                    Me.Hide()
                    Administrador.Show()
                    Administrador.Label1.Text = "Eres Cliente"
                    Administrador.BtBuscar.Visible = True
                    Administrador.BtMostrar.Visible = True
                Else
                    MsgBox("Contraseña o nombre de usuario incorrecto")
                End If

            Else
                MsgBox("Faltan Datos")
            End If
        Else
            MsgBox("La contraseña no es igual.")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cerrar el form'
        Me.Close()
    End Sub

    Private Sub NombreDeUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreDeUsuario.KeyPress
        If Char.IsSymbol(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            MsgBox("Solo se permiten letras.")
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Vereficar.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgv.Visible = False
    End Sub
End Class
