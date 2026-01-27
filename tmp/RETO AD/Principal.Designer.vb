<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.BTNComanda = New System.Windows.Forms.Button()
        Me.BTNStock = New System.Windows.Forms.Button()
        Me.BTNHistorial = New System.Windows.Forms.Button()
        Me.BTNCierre = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBLTitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLNumVentas = New System.Windows.Forms.Label()
        Me.LBLVentas = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBLNumTickets = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLNombreEmpleado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNComanda
        '
        Me.BTNComanda.BackColor = System.Drawing.Color.Black
        Me.BTNComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNComanda.ForeColor = System.Drawing.Color.White
        Me.BTNComanda.Location = New System.Drawing.Point(29, 110)
        Me.BTNComanda.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNComanda.Name = "BTNComanda"
        Me.BTNComanda.Size = New System.Drawing.Size(180, 31)
        Me.BTNComanda.TabIndex = 0
        Me.BTNComanda.Text = "Nueva Comanda"
        Me.BTNComanda.UseVisualStyleBackColor = False
        '
        'BTNStock
        '
        Me.BTNStock.BackColor = System.Drawing.Color.Black
        Me.BTNStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStock.ForeColor = System.Drawing.Color.White
        Me.BTNStock.Location = New System.Drawing.Point(29, 163)
        Me.BTNStock.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNStock.Name = "BTNStock"
        Me.BTNStock.Size = New System.Drawing.Size(180, 31)
        Me.BTNStock.TabIndex = 1
        Me.BTNStock.Text = "Gestion de Stock"
        Me.BTNStock.UseVisualStyleBackColor = False
        '
        'BTNHistorial
        '
        Me.BTNHistorial.BackColor = System.Drawing.Color.Black
        Me.BTNHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHistorial.ForeColor = System.Drawing.Color.White
        Me.BTNHistorial.Location = New System.Drawing.Point(29, 214)
        Me.BTNHistorial.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNHistorial.Name = "BTNHistorial"
        Me.BTNHistorial.Size = New System.Drawing.Size(180, 31)
        Me.BTNHistorial.TabIndex = 2
        Me.BTNHistorial.Text = "Historial de Ventas"
        Me.BTNHistorial.UseVisualStyleBackColor = False
        '
        'BTNCierre
        '
        Me.BTNCierre.BackColor = System.Drawing.Color.Black
        Me.BTNCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCierre.ForeColor = System.Drawing.Color.White
        Me.BTNCierre.Location = New System.Drawing.Point(29, 261)
        Me.BTNCierre.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNCierre.Name = "BTNCierre"
        Me.BTNCierre.Size = New System.Drawing.Size(180, 31)
        Me.BTNCierre.TabIndex = 3
        Me.BTNCierre.Text = "Cierre Caja"
        Me.BTNCierre.UseVisualStyleBackColor = False
        '
        'BTNSalir
        '
        Me.BTNSalir.BackColor = System.Drawing.Color.Red
        Me.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSalir.ForeColor = System.Drawing.Color.White
        Me.BTNSalir.Location = New System.Drawing.Point(29, 313)
        Me.BTNSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(180, 31)
        Me.BTNSalir.TabIndex = 4
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLNombreEmpleado)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LBLTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 80)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RETO_AD.My.Resources.Resources.unnamed_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'LBLTitulo
        '
        Me.LBLTitulo.AutoSize = True
        Me.LBLTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitulo.Location = New System.Drawing.Point(115, 27)
        Me.LBLTitulo.Name = "LBLTitulo"
        Me.LBLTitulo.Size = New System.Drawing.Size(268, 29)
        Me.LBLTitulo.TabIndex = 1
        Me.LBLTitulo.Text = "Tejones Meleros TPV"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LBLNumVentas)
        Me.Panel2.Controls.Add(Me.LBLVentas)
        Me.Panel2.Location = New System.Drawing.Point(347, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 6
        '
        'LBLNumVentas
        '
        Me.LBLNumVentas.AutoSize = True
        Me.LBLNumVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNumVentas.Location = New System.Drawing.Point(64, 53)
        Me.LBLNumVentas.Name = "LBLNumVentas"
        Me.LBLNumVentas.Size = New System.Drawing.Size(83, 25)
        Me.LBLNumVentas.TabIndex = 1
        Me.LBLNumVentas.Text = "Label2"
        '
        'LBLVentas
        '
        Me.LBLVentas.AutoSize = True
        Me.LBLVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVentas.Location = New System.Drawing.Point(30, 18)
        Me.LBLVentas.Name = "LBLVentas"
        Me.LBLVentas.Size = New System.Drawing.Size(143, 24)
        Me.LBLVentas.TabIndex = 0
        Me.LBLVentas.Text = "VENTAS HOY"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LBLNumTickets)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(347, 244)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 7
        '
        'LBLNumTickets
        '
        Me.LBLNumTickets.AutoSize = True
        Me.LBLNumTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNumTickets.Location = New System.Drawing.Point(64, 52)
        Me.LBLNumTickets.Name = "LBLNumTickets"
        Me.LBLNumTickets.Size = New System.Drawing.Size(83, 25)
        Me.LBLNumTickets.TabIndex = 2
        Me.LBLNumTickets.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TICKETS"
        '
        'LBLNombreEmpleado
        '
        Me.LBLNombreEmpleado.AutoSize = True
        Me.LBLNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNombreEmpleado.Location = New System.Drawing.Point(320, 27)
        Me.LBLNombreEmpleado.Name = "LBLNombreEmpleado"
        Me.LBLNombreEmpleado.Size = New System.Drawing.Size(0, 29)
        Me.LBLNombreEmpleado.TabIndex = 10
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.BTNCierre)
        Me.Controls.Add(Me.BTNHistorial)
        Me.Controls.Add(Me.BTNStock)
        Me.Controls.Add(Me.BTNComanda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNComanda As Button
    Friend WithEvents BTNStock As Button
    Friend WithEvents BTNHistorial As Button
    Friend WithEvents BTNCierre As Button
    Friend WithEvents BTNSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLTitulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLVentas As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLNumTickets As Label
    Friend WithEvents LBLNumVentas As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LBLNombreEmpleado As Label
End Class
