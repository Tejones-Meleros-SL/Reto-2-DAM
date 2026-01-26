Imports MySql.Data.MySqlClient

Public Class Login
    Private TotalEmpleado As Double

    Private Sub BTNIniciarSesion_Click(sender As Object, e As EventArgs) Handles BTNIniciarSesion.Click
        Dim connectionString As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"
        Dim query As String = "SELECT IDEmpe FROM Empleado WHERE Nombre = @usuario AND DNI = @pass"

        If TBUsuario.Text = "" Or TBPassword.Text = "" Then
            MessageBox.Show("Rellena todos los campos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try
                Using conexion As New MySqlConnection(connectionString)
                    conexion.Open()

                    Using comando As New MySqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@usuario", TBUsuario.Text)
                        comando.Parameters.AddWithValue("@pass", TBPassword.Text)

                        Dim resultado As Object = comando.ExecuteScalar()

                        If resultado IsNot Nothing Then
                            Dim empleadoID As Integer = Convert.ToInt32(resultado)
                            MessageBox.Show("¡Bienvenido " & TBUsuario.Text & "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Abrir Principal pasando el empleado logeado
                            Dim principalForm As New Principal(empleadoID, TBUsuario.Text, TotalEmpleado)
                            principalForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error de MySQL: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error general: " & ex.Message)
            End Try
            TBUsuario.Clear()
            TBPassword.Clear()
        End If
    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        MessageBox.Show("Gracias por usar nuestro programa", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Application.Exit()
    End Sub
End Class
