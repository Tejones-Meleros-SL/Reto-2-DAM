<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBLTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNEliminar = New System.Windows.Forms.Button()
        Me.BTNModificar = New System.Windows.Forms.Button()
        Me.BTNNuevoProducto = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.DataSetStock = New RETO_AD.DataSetStock()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New RETO_AD.DataSetStockTableAdapters.ProductoTableAdapter()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LBLTitulo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 98)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RETO_AD.My.Resources.Resources.unnamed_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(39, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
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
        Me.PictureBox1.Image = Global.RETO_AD.My.Resources.Resources.TejonesLogo
        Me.PictureBox1.Location = New System.Drawing.Point(39, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BTNEliminar
        '
        Me.BTNEliminar.BackColor = System.Drawing.Color.Black
        Me.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEliminar.ForeColor = System.Drawing.Color.White
        Me.BTNEliminar.Location = New System.Drawing.Point(39, 310)
        Me.BTNEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNEliminar.Name = "BTNEliminar"
        Me.BTNEliminar.Size = New System.Drawing.Size(240, 38)
        Me.BTNEliminar.TabIndex = 10
        Me.BTNEliminar.Text = "Eliminar"
        Me.BTNEliminar.UseVisualStyleBackColor = False
        '
        'BTNModificar
        '
        Me.BTNModificar.BackColor = System.Drawing.Color.Black
        Me.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNModificar.ForeColor = System.Drawing.Color.White
        Me.BTNModificar.Location = New System.Drawing.Point(39, 247)
        Me.BTNModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNModificar.Name = "BTNModificar"
        Me.BTNModificar.Size = New System.Drawing.Size(240, 38)
        Me.BTNModificar.TabIndex = 9
        Me.BTNModificar.Text = "Modificar"
        Me.BTNModificar.UseVisualStyleBackColor = False
        '
        'BTNNuevoProducto
        '
        Me.BTNNuevoProducto.BackColor = System.Drawing.Color.Black
        Me.BTNNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNNuevoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNuevoProducto.ForeColor = System.Drawing.Color.White
        Me.BTNNuevoProducto.Location = New System.Drawing.Point(39, 182)
        Me.BTNNuevoProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNNuevoProducto.Name = "BTNNuevoProducto"
        Me.BTNNuevoProducto.Size = New System.Drawing.Size(240, 38)
        Me.BTNNuevoProducto.TabIndex = 8
        Me.BTNNuevoProducto.Text = "Nuevo Producto"
        Me.BTNNuevoProducto.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Producto, Me.Categoria, Me.Stock_Actual, Me.IDProdDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.StockMinimoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(337, 118)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(627, 412)
        Me.DataGridView1.TabIndex = 31
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(833, 554)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(147, 36)
        Me.BTNSalir.TabIndex = 37
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'DataSetStock
        '
        Me.DataSetStock.DataSetName = "DataSetStock"
        Me.DataSetStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.DataSetStock
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Producto.HeaderText = "PRODUCTO"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.Visible = False
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Categoria.HeaderText = "CATEGORIA"
        Me.Categoria.MinimumWidth = 6
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Visible = False
        '
        'Stock_Actual
        '
        Me.Stock_Actual.HeaderText = "STOCK ACTUAL"
        Me.Stock_Actual.MinimumWidth = 6
        Me.Stock_Actual.Name = "Stock_Actual"
        Me.Stock_Actual.Visible = False
        Me.Stock_Actual.Width = 125
        '
        'IDProdDataGridViewTextBoxColumn
        '
        Me.IDProdDataGridViewTextBoxColumn.DataPropertyName = "IDProd"
        Me.IDProdDataGridViewTextBoxColumn.HeaderText = "IDProd"
        Me.IDProdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDProdDataGridViewTextBoxColumn.Name = "IDProdDataGridViewTextBoxColumn"
        Me.IDProdDataGridViewTextBoxColumn.Visible = False
        Me.IDProdDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'StockMinimoDataGridViewTextBoxColumn
        '
        Me.StockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo"
        Me.StockMinimoDataGridViewTextBoxColumn.HeaderText = "StockMinimo"
        Me.StockMinimoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockMinimoDataGridViewTextBoxColumn.Name = "StockMinimoDataGridViewTextBoxColumn"
        Me.StockMinimoDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.Width = 125
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Width = 125
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(996, 604)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNEliminar)
        Me.Controls.Add(Me.BTNModificar)
        Me.Controls.Add(Me.BTNNuevoProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNEliminar As Button
    Friend WithEvents BTNModificar As Button
    Friend WithEvents BTNNuevoProducto As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTNSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataSetStock As DataSetStock
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As DataSetStockTableAdapters.ProductoTableAdapter
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Actual As DataGridViewTextBoxColumn
    Friend WithEvents IDProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
