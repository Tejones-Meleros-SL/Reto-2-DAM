Public Class Stock

    Private IDEmpleado As Integer
    Private NombreUsuario As String
    Private TotalEmpleado As Double

    ' Constructor
    Public Sub New(empleadoID As Integer)
        InitializeComponent()
        Me.IDEmpleado = empleadoID
    End Sub
    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Me.Hide()
        Dim p As New Principal(IDEmpleado, NombreUsuario, TotalEmpleado)
        p.Show()
    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetStock.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DataSetStock.Producto)

    End Sub
End Class
