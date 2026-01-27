<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBLTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Productos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTicketDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEmpeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComandaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetComandaDetalles = New RETO_AD.DataSetComandaDetalles()
        Me.LBLDesdeFecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LBLHastaFecha = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.ComandaTableAdapter = New RETO_AD.DataSetComandaDetallesTableAdapters.ComandaTableAdapter()
        Me.DetallesTableAdapter = New RETO_AD.DataSetComandaDetallesTableAdapters.DetallesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComandaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetComandaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1540, 98)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RETO_AD.My.Resources.Resources.unnamed_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(39, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PictureBox1.Location = New System.Drawing.Point(39, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Productos, Me.Cantidad, Me.Precio, Me.Total, Me.Empleado, Me.IDTicketDataGridViewTextBoxColumn, Me.IDEmpeDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.PrecioTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComandaBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(22, 195)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1412, 553)
        Me.DataGridView1.TabIndex = 31
        '
        'Productos
        '
        Me.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.Productos.DefaultCellStyle = DataGridViewCellStyle2
        Me.Productos.HeaderText = "Ticket ID"
        Me.Productos.MinimumWidth = 6
        Me.Productos.Name = "Productos"
        Me.Productos.Visible = False
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cantidad.HeaderText = "Fecha"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Visible = False
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Hora"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.Visible = False
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.Visible = False
        '
        'Empleado
        '
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.MinimumWidth = 6
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Visible = False
        '
        'IDTicketDataGridViewTextBoxColumn
        '
        Me.IDTicketDataGridViewTextBoxColumn.DataPropertyName = "IDTicket"
        Me.IDTicketDataGridViewTextBoxColumn.HeaderText = "IDTicket"
        Me.IDTicketDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDTicketDataGridViewTextBoxColumn.Name = "IDTicketDataGridViewTextBoxColumn"
        '
        'IDEmpeDataGridViewTextBoxColumn
        '
        Me.IDEmpeDataGridViewTextBoxColumn.DataPropertyName = "IDEmpe"
        Me.IDEmpeDataGridViewTextBoxColumn.HeaderText = "IDEmpe"
        Me.IDEmpeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDEmpeDataGridViewTextBoxColumn.Name = "IDEmpeDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'PrecioTotalDataGridViewTextBoxColumn
        '
        Me.PrecioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal"
        Me.PrecioTotalDataGridViewTextBoxColumn.HeaderText = "PrecioTotal"
        Me.PrecioTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioTotalDataGridViewTextBoxColumn.Name = "PrecioTotalDataGridViewTextBoxColumn"
        '
        'ComandaBindingSource
        '
        Me.ComandaBindingSource.DataMember = "Comanda"
        Me.ComandaBindingSource.DataSource = Me.DataSetComandaDetalles
        '
        'DataSetComandaDetalles
        '
        Me.DataSetComandaDetalles.DataSetName = "DataSetComandaDetalles"
        Me.DataSetComandaDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBLDesdeFecha
        '
        Me.LBLDesdeFecha.AutoSize = True
        Me.LBLDesdeFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDesdeFecha.Location = New System.Drawing.Point(177, 135)
        Me.LBLDesdeFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLDesdeFecha.Name = "LBLDesdeFecha"
        Me.LBLDesdeFecha.Size = New System.Drawing.Size(131, 39)
        Me.LBLDesdeFecha.TabIndex = 32
        Me.LBLDesdeFecha.Text = "Desde:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 146)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 22)
        Me.DateTimePicker1.TabIndex = 33
        '
        'LBLHastaFecha
        '
        Me.LBLHastaFecha.AutoSize = True
        Me.LBLHastaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHastaFecha.Location = New System.Drawing.Point(551, 135)
        Me.LBLHastaFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLHastaFecha.Name = "LBLHastaFecha"
        Me.LBLHastaFecha.Size = New System.Drawing.Size(121, 39)
        Me.LBLHastaFecha.TabIndex = 34
        Me.LBLHastaFecha.Text = "Hasta:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(707, 146)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 22)
        Me.DateTimePicker2.TabIndex = 35
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(1348, 793)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(147, 36)
        Me.BTNSalir.TabIndex = 36
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'ComandaTableAdapter
        '
        Me.ComandaTableAdapter.ClearBeforeFill = True
        '
        'DetallesTableAdapter
        '
        Me.DetallesTableAdapter.ClearBeforeFill = True
        '
        'HistorialVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1540, 849)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.LBLHastaFecha)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LBLDesdeFecha)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HistorialVentas"
        Me.Text = "Historial Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComandaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetComandaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LBLDesdeFecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LBLHastaFecha As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents BTNSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents DataSetComandaDetalles As DataSetComandaDetalles
    Friend WithEvents ComandaBindingSource As BindingSource
    Friend WithEvents ComandaTableAdapter As DataSetComandaDetallesTableAdapters.ComandaTableAdapter
    Friend WithEvents IDTicketDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetallesTableAdapter As DataSetComandaDetallesTableAdapters.DetallesTableAdapter
End Class
