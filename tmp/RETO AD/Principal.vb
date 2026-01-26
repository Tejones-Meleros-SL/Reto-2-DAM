Public Class Principal
    Private IDEmpe As Integer
    Private NombreUser As String
    Private Total As Double

    ' Constructor recibe el empleado logeado
    Public Sub New(empleadoID As Integer, nombreUsuario As String, TotalEmpleado As Double)
        InitializeComponent()
        Me.IDEmpe = empleadoID
        Me.NombreUser = nombreUsuario
        Me.Total = TotalEmpleado
        LBLNombreEmpleado.Text = nombreUsuario
        LBLNumVentas.Text = TotalEmpleado
    End Sub
    Private Sub BTNComanda_Click(sender As Object, e As EventArgs) Handles BTNComanda.Click
        Me.Close()
        Dim NuevaComanda As New NuevaComanda(IDEmpe, NombreUser)
        NuevaComanda.Show()
    End Sub

    Private Sub BTNStock_Click(sender As Object, e As EventArgs) Handles BTNStock.Click
        Me.Close()
        Dim Stock As New Stock(IDEmpe)
        Stock.Show()
    End Sub


    Private Sub BTNHistorial_Click(sender As Object, e As EventArgs) Handles BTNHistorial.Click
        Me.Close()
        Dim HistorialVentas As New HistorialVentas(IDEmpe)
        HistorialVentas.Show()
    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        MessageBox.Show("Gracias por usar el sistema", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Dim Login As New Login()
        Login.Show()
    End Sub

    Private Sub BTNCierre_Click(sender As Object, e As EventArgs) Handles BTNCierre.Click

    End Sub
End Class

