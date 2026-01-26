Imports MySql.Data.MySqlClient

Public Class NuevaComanda

    Private IDEmpe As Integer
    Private ProductosLista As List(Of Producto)
    Private IDTicket As Integer
    Private NombreUsuario As String

    Public Sub New(empleadoID As Integer, nombreUsuario As String)
        InitializeComponent()
        IDEmpe = empleadoID
        Me.NombreUsuario = nombreUsuario
    End Sub

    Private Sub NuevaComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearComanda()
        CargarProductos("Todos")

        dgvComanda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComanda.MultiSelect = False
        dgvComanda.AllowUserToResizeRows = False
        dgvComanda.AllowUserToAddRows = False
        dgvComanda.ReadOnly = True
        dgvComanda.RowTemplate.Height = 30
    End Sub

    Private Sub CrearComanda()
        Dim cs As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"
        Dim q As String =
        "INSERT INTO Comanda (IDEmpe, Fecha, Estado, PrecioTotal)
         VALUES (@IDEmpe, @Fecha, 'Abierta', 0);
         SELECT LAST_INSERT_ID();"

        Using conn As New MySqlConnection(cs)
            conn.Open()
            Using cmd As New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("@IDEmpe", IDEmpe)
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now)
                IDTicket = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Sub


    Private Sub CargarProductos(Optional tipoFiltro As String = "Todos")
        ProductosLista = ObtenerProductos()
        flowLayoutPanelProductos.Controls.Clear()

        Dim lista = ProductosLista
        If tipoFiltro <> "Todos" Then
            lista = ProductosLista.Where(Function(p) p.Tipo = tipoFiltro).ToList()
        End If

        For Each prod In lista
            Dim btn As New Button With {
                .Text = $"{prod.Descripcion} €{prod.Precio}",
                .Width = 150,
                .Height = 50,
                .Tag = prod
            }

            Select Case prod.Tipo
                Case "Comida" : btn.BackColor = Color.LightGreen
                Case "Bebida" : btn.BackColor = Color.LightBlue
                Case Else : btn.BackColor = Color.LightYellow
            End Select

            AddHandler btn.Click, AddressOf Btn_Click
            flowLayoutPanelProductos.Controls.Add(btn)
        Next
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Dim prod As Producto = CType(CType(sender, Button).Tag, Producto)

        For Each row As DataGridViewRow In dgvComanda.Rows
            If row.Cells("Productos").Value = prod.Descripcion Then
                row.Cells("Cantidad").Value += 1
                row.Cells("Precio").Value = row.Cells("Cantidad").Value * prod.Precio
                ActualizarTotal()
                Return
            End If
        Next

        dgvComanda.Rows.Add(prod.Descripcion, 1, prod.Precio)
        ActualizarTotal()
    End Sub

    Private Function ObtenerProductos() As List(Of Producto)
        Dim lista As New List(Of Producto)
        Dim cs As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"
        Dim q As String = "SELECT * FROM Producto"

        Using conn As New MySqlConnection(cs)
            conn.Open()
            Using cmd As New MySqlCommand(q, conn)
                Using rd = cmd.ExecuteReader()
                    While rd.Read()
                        lista.Add(New Producto(
                            rd.GetInt32("IDProd"),
                            rd.GetString("Descripcion"),
                            rd.GetInt32("Stock"),
                            rd.GetInt32("StockMinimo"),
                            rd.GetDecimal("Precio"),
                            rd.GetString("Tipo")
                        ))
                    End While
                End Using
            End Using
        End Using

        Return lista
    End Function

    Private Sub ActualizarTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvComanda.Rows
            If Not row.IsNewRow Then
                total += CDec(row.Cells("Precio").Value)
            End If
        Next

        LBLTotalPrecio.Text = $"{total:F2}€"
    End Sub

    Private Sub BTNBorrar_Click(sender As Object, e As EventArgs) Handles BTNBorrar.Click
        If dgvComanda.SelectedRows.Count = 0 Then Return

        Dim row = dgvComanda.SelectedRows(0)
        Dim cantidad = CInt(row.Cells("Cantidad").Value)
        Dim precioUnit = CDec(row.Cells("Precio").Value) / cantidad

        If cantidad > 1 Then
            row.Cells("Cantidad").Value = cantidad - 1
            row.Cells("Precio").Value = (cantidad - 1) * precioUnit
        Else
            dgvComanda.Rows.Remove(row)
        End If

        ActualizarTotal()
    End Sub

    Private Sub InsertarDetalles()
        Dim cs As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"

        Using conn As New MySqlConnection(cs)
            conn.Open()

            For Each row As DataGridViewRow In dgvComanda.Rows
                If row.IsNewRow Then Continue For

                Dim descp = row.Cells("Productos").Value.ToString()
                Dim cant = CInt(row.Cells("Cantidad").Value)
                Dim subtotal = CDec(row.Cells("Precio").Value)
                Dim precio = subtotal / cant
                Dim idProd = ObtenerIDProducto(descp, conn)

                Dim q As String =
                    "INSERT INTO Detalles (IDTicket, IDProd, Cantidad, PrecioTotal)
                     VALUES (@IDTicket, @IDProd, @Cantidad, @PrecioTotal)"

                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@IDTicket", IDTicket)
                    cmd.Parameters.AddWithValue("@IDProd", idProd)
                    cmd.Parameters.AddWithValue("@Cantidad", cant)
                    cmd.Parameters.AddWithValue("@PrecioTotal", precio * cant)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub

    Private Sub BTNComida_Click(sender As Object, e As EventArgs) Handles BTNComidas.Click
        CargarProductos("Comida")
    End Sub

    Private Sub BTNBebida_Click(sender As Object, e As EventArgs) Handles BTNBebidas.Click
        CargarProductos("Bebida")
    End Sub

    Private Sub BTNOtros_Click(sender As Object, e As EventArgs) Handles BTNOtros.Click
        CargarProductos("Otros")
    End Sub

    Private Sub BTNTodos_Click(sender As Object, e As EventArgs) Handles BTNTodo.Click
        CargarProductos("Todos")
    End Sub
    Private Function ObtenerIDProducto(descripcion As String, conn As MySqlConnection) As Integer
        Dim q As String = "SELECT IDProd FROM Producto WHERE Descripcion = @Desc LIMIT 1"
        Using cmd As New MySqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@Desc", descripcion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub ActualizarEstado(estado As String)
        Dim total As Decimal = ObtenerTotal()

        Dim cs As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"
        Dim q As String =
        "UPDATE Comanda
         SET Estado = @Estado, PrecioTotal = @PrecioTotal
         WHERE IDTicket = @IDTicket"

        Using conn As New MySqlConnection(cs)
            conn.Open()
            Using cmd As New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("@Estado", estado)
                cmd.Parameters.AddWithValue("@PrecioTotal", total)
                cmd.Parameters.AddWithValue("@IDTicket", IDTicket)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub BTNCobrar_Click(sender As Object, e As EventArgs) Handles BTNCobrar.Click
        MsgBox("Comanda completada, Gracias!!")
        InsertarDetalles()
        ActualizarEstado("Completada")
        Me.Hide()
        Dim p As New Principal(IDEmpe, NombreUsuario)
        p.Show()
    End Sub

    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        ActualizarEstado("Cancelada")
        Me.Hide()
        Dim p As New Principal(IDEmpe, NombreUsuario)
        p.Show()
    End Sub

    Private Function ObtenerTotal() As Decimal
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvComanda.Rows
            If Not row.IsNewRow Then
                total += CDec(row.Cells("Precio").Value)
            End If
        Next
        Return total
    End Function

End Class
