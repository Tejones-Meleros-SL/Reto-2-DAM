<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaComanda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNComidas = New System.Windows.Forms.Button()
        Me.BTNOtros = New System.Windows.Forms.Button()
        Me.BTNBebidas = New System.Windows.Forms.Button()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.LBLTotalPrecio = New System.Windows.Forms.Label()
        Me.dgvComanda = New System.Windows.Forms.DataGridView()
        Me.Productos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNCobrar = New System.Windows.Forms.Button()
        Me.BTNBorrar = New System.Windows.Forms.Button()
        Me.BTNCancelar = New System.Windows.Forms.Button()
        Me.flowLayoutPanelProductos = New System.Windows.Forms.FlowLayoutPanel()
        Me.BTNTodo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLTitulo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1461, 98)
        Me.Panel1.TabIndex = 6
        '
        'LBLTitulo
        '
        Me.LBLTitulo.AutoSize = True
        Me.LBLTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitulo.Location = New System.Drawing.Point(253, 31)
        Me.LBLTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTitulo.Name = "LBLTitulo"
        Me.LBLTitulo.Size = New System.Drawing.Size(321, 36)
        Me.LBLTitulo.TabIndex = 1
        Me.LBLTitulo.Text = "Tejones Meleros TPV"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RETO_AD.My.Resources.Resources.unnamed_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(39, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BTNComidas
        '
        Me.BTNComidas.BackColor = System.Drawing.Color.Black
        Me.BTNComidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNComidas.ForeColor = System.Drawing.Color.White
        Me.BTNComidas.Location = New System.Drawing.Point(39, 150)
        Me.BTNComidas.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNComidas.Name = "BTNComidas"
        Me.BTNComidas.Size = New System.Drawing.Size(145, 75)
        Me.BTNComidas.TabIndex = 7
        Me.BTNComidas.Text = "Comida"
        Me.BTNComidas.UseVisualStyleBackColor = False
        '
        'BTNOtros
        '
        Me.BTNOtros.BackColor = System.Drawing.Color.Black
        Me.BTNOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNOtros.ForeColor = System.Drawing.Color.White
        Me.BTNOtros.Location = New System.Drawing.Point(345, 150)
        Me.BTNOtros.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNOtros.Name = "BTNOtros"
        Me.BTNOtros.Size = New System.Drawing.Size(145, 75)
        Me.BTNOtros.TabIndex = 8
        Me.BTNOtros.Text = "Otros"
        Me.BTNOtros.UseVisualStyleBackColor = False
        '
        'BTNBebidas
        '
        Me.BTNBebidas.BackColor = System.Drawing.Color.Black
        Me.BTNBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBebidas.ForeColor = System.Drawing.Color.White
        Me.BTNBebidas.Location = New System.Drawing.Point(192, 150)
        Me.BTNBebidas.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNBebidas.Name = "BTNBebidas"
        Me.BTNBebidas.Size = New System.Drawing.Size(145, 75)
        Me.BTNBebidas.TabIndex = 10
        Me.BTNBebidas.Text = "Bebidas"
        Me.BTNBebidas.UseVisualStyleBackColor = False
        '
        'LBLTotal
        '
        Me.LBLTotal.AutoSize = True
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(704, 576)
        Me.LBLTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(126, 46)
        Me.LBLTotal.TabIndex = 0
        Me.LBLTotal.Text = "Total:"
        Me.LBLTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLTotalPrecio
        '
        Me.LBLTotalPrecio.AutoSize = True
        Me.LBLTotalPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotalPrecio.Location = New System.Drawing.Point(842, 576)
        Me.LBLTotalPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTotalPrecio.Name = "LBLTotalPrecio"
        Me.LBLTotalPrecio.Size = New System.Drawing.Size(78, 46)
        Me.LBLTotalPrecio.TabIndex = 1
        Me.LBLTotalPrecio.Text = "0.0"
        Me.LBLTotalPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvComanda
        '
        Me.dgvComanda.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComanda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComanda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Productos, Me.Cantidad, Me.Precio})
        Me.dgvComanda.EnableHeadersVisualStyles = False
        Me.dgvComanda.Location = New System.Drawing.Point(712, 127)
        Me.dgvComanda.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvComanda.Name = "dgvComanda"
        Me.dgvComanda.RowHeadersVisible = False
        Me.dgvComanda.RowHeadersWidth = 51
        Me.dgvComanda.Size = New System.Drawing.Size(641, 412)
        Me.dgvComanda.TabIndex = 30
        '
        'Productos
        '
        Me.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.Productos.DefaultCellStyle = DataGridViewCellStyle2
        Me.Productos.HeaderText = "Productos"
        Me.Productos.MinimumWidth = 6
        Me.Productos.Name = "Productos"
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        '
        'BTNCobrar
        '
        Me.BTNCobrar.BackColor = System.Drawing.Color.SeaGreen
        Me.BTNCobrar.ForeColor = System.Drawing.Color.White
        Me.BTNCobrar.Location = New System.Drawing.Point(1077, 562)
        Me.BTNCobrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCobrar.Name = "BTNCobrar"
        Me.BTNCobrar.Size = New System.Drawing.Size(276, 60)
        Me.BTNCobrar.TabIndex = 2
        Me.BTNCobrar.Text = "COBRAR"
        Me.BTNCobrar.UseVisualStyleBackColor = False
        '
        'BTNBorrar
        '
        Me.BTNBorrar.BackColor = System.Drawing.Color.Firebrick
        Me.BTNBorrar.ForeColor = System.Drawing.Color.White
        Me.BTNBorrar.Location = New System.Drawing.Point(1077, 657)
        Me.BTNBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNBorrar.Name = "BTNBorrar"
        Me.BTNBorrar.Size = New System.Drawing.Size(276, 60)
        Me.BTNBorrar.TabIndex = 3
        Me.BTNBorrar.Text = "BORRAR COMANDA"
        Me.BTNBorrar.UseVisualStyleBackColor = False
        '
        'BTNCancelar
        '
        Me.BTNCancelar.Location = New System.Drawing.Point(711, 657)
        Me.BTNCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNCancelar.Name = "BTNCancelar"
        Me.BTNCancelar.Size = New System.Drawing.Size(276, 60)
        Me.BTNCancelar.TabIndex = 37
        Me.BTNCancelar.Text = "CANCELAR COMANDA"
        Me.BTNCancelar.UseVisualStyleBackColor = True
        '
        'flowLayoutPanelProductos
        '
        Me.flowLayoutPanelProductos.AutoScroll = True
        Me.flowLayoutPanelProductos.Location = New System.Drawing.Point(28, 248)
        Me.flowLayoutPanelProductos.Name = "flowLayoutPanelProductos"
        Me.flowLayoutPanelProductos.Size = New System.Drawing.Size(657, 469)
        Me.flowLayoutPanelProductos.TabIndex = 38
        '
        'BTNTodo
        '
        Me.BTNTodo.BackColor = System.Drawing.Color.Black
        Me.BTNTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTodo.ForeColor = System.Drawing.Color.White
        Me.BTNTodo.Location = New System.Drawing.Point(498, 150)
        Me.BTNTodo.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNTodo.Name = "BTNTodo"
        Me.BTNTodo.Size = New System.Drawing.Size(145, 75)
        Me.BTNTodo.TabIndex = 39
        Me.BTNTodo.Text = "Todo"
        Me.BTNTodo.UseVisualStyleBackColor = False
        '
        'NuevaComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1461, 826)
        Me.Controls.Add(Me.BTNTodo)
        Me.Controls.Add(Me.flowLayoutPanelProductos)
        Me.Controls.Add(Me.BTNCancelar)
        Me.Controls.Add(Me.dgvComanda)
        Me.Controls.Add(Me.BTNBorrar)
        Me.Controls.Add(Me.LBLTotalPrecio)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.BTNCobrar)
        Me.Controls.Add(Me.BTNBebidas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNOtros)
        Me.Controls.Add(Me.BTNComidas)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NuevaComanda"
        Me.Text = "Altas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNComidas As Button
    Friend WithEvents BTNOtros As Button
    Friend WithEvents BTNBebidas As Button
    Friend WithEvents LBLTotal As Label
    Friend WithEvents LBLTotalPrecio As Label
    Friend WithEvents dgvComanda As DataGridView
    Friend WithEvents BTNCobrar As Button
    Friend WithEvents BTNBorrar As Button
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents flowLayoutPanelProductos As FlowLayoutPanel
    Friend WithEvents BTNTodo As Button
End Class
