Public Class HistorialVentas

    Private IDEmpe As Integer
    Private NombreUsuario As String

    ' Constructor
    Public Sub New(empleadoID As Integer)
        InitializeComponent()
        Me.IDEmpe = empleadoID
    End Sub
    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Me.Hide()
        Dim p As New Principal(IDEmpe, NombreUsuario)
        p.Show()
    End Sub

    Private Sub HistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetComandaDetalles.Comanda' Puede moverla o quitarla según sea necesario.
        Me.ComandaTableAdapter.Fill(Me.DataSetComandaDetalles.Comanda)
        'TODO: esta línea de código carga datos en la tabla 'DataSetComandaDetalles.Detalles' Puede moverla o quitarla según sea necesario.
        Me.DetallesTableAdapter.Fill(Me.DataSetComandaDetalles.Detalles)
        'TODO: esta línea de código carga datos en la tabla 'DataSetComandaDetalles.Comanda' Puede moverla o quitarla según sea necesario.
        Me.ComandaTableAdapter.Fill(Me.DataSetComandaDetalles.Comanda)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ComandaTableAdapter.Fill(Me.DataSetComandaDetalles.Comanda)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
