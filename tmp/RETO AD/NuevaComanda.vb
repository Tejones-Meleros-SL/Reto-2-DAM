Imports MySql.Data.MySqlClient

Public Class NuevaComanda

    ' Id empleado
    Private IDEmpe As Integer

    ' Lista productos
    Private ProductosLista As List(Of Producto)

    ' Id comanda
    Private IDTicket As Integer

    ' Nombre empleado
    Private NombreUsuario As String

    ' Cadena de conexión
    Private ReadOnly cs As String = "Server=193.203.168.4;Database=u237486760_AccesoDatods;Uid=u237486760_admin;Pwd=lK7>##J3~M;"

    ' Constructor
    Public Sub New(empleadoID As Integer, nombreUsuario As String)
        InitializeComponent()
        IDEmpe = empleadoID
        Me.NombreUsuario = nombreUsuario
    End Sub

    ' Evento al cargar el formulario
    Private Sub NuevaComanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearComanda()
        CargarProductos("Todos")

        ' Configuración visual del DataGridView
        dgvComanda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComanda.MultiSelect = False
        dgvComanda.AllowUserToResizeRows = False
        dgvComanda.AllowUserToAddRows = False
        dgvComanda.ReadOnly = True
        dgvComanda.RowTemplate.Height = 30
    End Sub

    ' Crea una nueva comanda en la base de datos
    Private Sub CrearComanda()
        Dim q As String = "INSERT INTO Comanda (IDEmpe, Fecha, Estado, PrecioTotal) VALUES (@IDEmpe, @Fecha, 'Abierta', 0); SELECT LAST_INSERT_ID();"

        Using conn As New MySqlConnection(cs)
            conn.Open()
            Using cmd As New MySqlCommand(q, conn)
                cmd.Parameters.AddWithValue("@IDEmpe", IDEmpe)
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now)
                IDTicket = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Sub

    ' Cargar productos al panel
    Private Sub CargarProductos(Optional tipoFiltro As String = "Todos")
        ' Lista total de los productos
        ProductosLista = ObtenerProductos()

        ' Borrar botones de productos que estaban antes
        flowLayoutPanelProductos.Controls.Clear()

        ' Lista que vamos a ir modificando para mostrar los productos según filtro
        Dim lista = ProductosLista

        ' Si se selecciona un filtro distinto de "Todos", filtra la lista por tipo
        If tipoFiltro <> "Todos" Then
            lista = ProductosLista.Where(Function(p) p.Tipo = tipoFiltro).ToList()
        End If

        For Each prod In lista
            Dim btn As New Button With {
                .Text = $"{prod.Descripcion} €{prod.Precio}",
                .Width = 150,
                .Height = 50,
                .Tag = prod 'Guarda el propio producto  
            }

            Select Case prod.Tipo
                Case "Comida" : btn.BackColor = Color.LightGreen
                Case "Bebida" : btn.BackColor = Color.LightBlue
                Case Else : btn.BackColor = Color.Yellow
            End Select

            ' Asocia el evento click del botón a la función Btn_Click
            AddHandler btn.Click, AddressOf Btn_Click

            ' Añade el botón al panel de productos para mostrarlo en la pantalla
            flowLayoutPanelProductos.Controls.Add(btn)
        Next
    End Sub

    ' Evento para agregar producto a la comanda
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

    ' Obtener productos desde la bd
    Private Function ObtenerProductos() As List(Of Producto)
        Dim lista As New List(Of Producto)
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

    ' Calcular precio total 
    Private Sub ActualizarTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvComanda.Rows
            total += CDec(row.Cells("Precio").Value)
        Next
        LBLTotalPrecio.Text = $"{total:F2}€"
    End Sub

    ' Borrar o reducir la cantidad del producto seleccionado
    Private Sub BTNBorrar_Click(sender As Object, e As EventArgs) Handles BTNBorrar.Click
        If dgvComanda.SelectedRows.Count = 0 Then Return

        Dim row = dgvComanda.SelectedRows(0)
        Dim cantidad = CInt(row.Cells("Cantidad").Value)
        Dim precio = CDec(row.Cells("Precio").Value) / cantidad

        If cantidad > 1 Then
            row.Cells("Cantidad").Value = cantidad - 1
            row.Cells("Precio").Value = (cantidad - 1) * precio
        Else
            dgvComanda.Rows.Remove(row)
        End If

        ActualizarTotal()
    End Sub

    ' Filtrar productos
    Private Sub FiltrarProductos(tipo As String)
        CargarProductos(tipo)
    End Sub

    ' Eventos botones filtro
    Private Sub BTNComidas_Click(sender As Object, e As EventArgs) Handles BTNComidas.Click
        FiltrarProductos("Comida")
    End Sub

    Private Sub BTNBebidas_Click(sender As Object, e As EventArgs) Handles BTNBebidas.Click
        FiltrarProductos("Bebida")
    End Sub

    Private Sub BTNOtros_Click(sender As Object, e As EventArgs) Handles BTNOtros.Click
        FiltrarProductos("Otros")
    End Sub

    Private Sub BTNTodo_Click(sender As Object, e As EventArgs) Handles BTNTodo.Click
        FiltrarProductos("Todos")
    End Sub

    ' Comprobar stock antes de cobrar
    Private Function ComprobarStockComanda() As Boolean
        Using conn As New MySqlConnection(cs)
            conn.Open()

            For Each row As DataGridViewRow In dgvComanda.Rows
                Dim descp = row.Cells("Productos").Value.ToString()
                Dim cant = CInt(row.Cells("Cantidad").Value)
                Dim idProd = ObtenerIDProducto(descp, conn)

                Dim stockActual As Integer
                Using cmd As New MySqlCommand("SELECT Stock FROM Producto WHERE IDProd = @IDProd", conn)
                    cmd.Parameters.AddWithValue("@IDProd", idProd)
                    stockActual = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If cant > stockActual Then
                    MsgBox($"No hay suficiente stock para '{descp}'. Stock disponible: {stockActual}")
                    Return False
                End If
            Next
        End Using

        Return True
    End Function

    ' Inserter detalles de la comanda y actualizar stock
    Private Sub InsertarDetalles()
        Using conn As New MySqlConnection(cs)
            conn.Open()

            For Each row As DataGridViewRow In dgvComanda.Rows
                If row.IsNewRow Then Continue For

                Dim descp = row.Cells("Productos").Value.ToString()
                Dim cant = CInt(row.Cells("Cantidad").Value)
                Dim subtotal = CDec(row.Cells("Precio").Value)
                Dim precio = subtotal / cant
                Dim idProd = ObtenerIDProducto(descp, conn)

                ' Insertar detalle
                Dim q As String = "INSERT INTO Detalles (IDTicket, IDProd, Cantidad, PrecioTotal) VALUES (@IDTicket, @IDProd, @Cantidad, @PrecioTotal)"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@IDTicket", IDTicket)
                    cmd.Parameters.AddWithValue("@IDProd", idProd)
                    cmd.Parameters.AddWithValue("@Cantidad", cant)
                    cmd.Parameters.AddWithValue("@PrecioTotal", subtotal)
                    cmd.ExecuteNonQuery()
                End Using

                ' Actualizar stock
                Dim qStock As String = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE IDProd = @IDProd"
                Using cmdStock As New MySqlCommand(qStock, conn)
                    cmdStock.Parameters.AddWithValue("@Cantidad", cant)
                    cmdStock.Parameters.AddWithValue("@IDProd", idProd)
                    cmdStock.ExecuteNonQuery()
                End Using

            Next
        End Using
    End Sub

    ' Obtener ID de producto
    Private Function ObtenerIDProducto(descripcion As String, conn As MySqlConnection) As Integer
        Dim q As String = "SELECT IDProd FROM Producto WHERE Descripcion = @Desc LIMIT 1"
        Using cmd As New MySqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@Desc", descripcion)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' Actualizar estado y total de la comanda
    Private Sub ActualizarEstado(estado As String)
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvComanda.Rows
            If Not row.IsNewRow Then total += CDec(row.Cells("Precio").Value)
        Next

        Dim q As String = "UPDATE Comanda SET Estado = @Estado, PrecioTotal = @PrecioTotal WHERE IDTicket = @IDTicket"

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

    ' Cobrar comanda
    Private Sub BTNCobrar_Click(sender As Object, e As EventArgs) Handles BTNCobrar.Click
        If (dgvComanda.RowCount = 0) Then
            MsgBox("Ningún producto en la comanda")
            Exit Sub
        End If

        If Not ComprobarStockComanda() Then Exit Sub

        InsertarDetalles()
        ActualizarEstado("Completada")
        MsgBox("Comanda completada, Gracias!!")
        Me.Hide()
        Dim p As New Principal(IDEmpe, NombreUsuario)
        p.Show()
    End Sub

    ' Cancelar comanda
    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        ActualizarEstado("Cancelada")
        Me.Hide()
        Dim p As New Principal(IDEmpe, NombreUsuario)
        p.Show()
    End Sub

End Class
