Public Class Producto

    ' Atributos
    Private pIDProd As Integer
    Private pDescripcion As String
    Private pStock As Integer
    Private pStockMinimo As Integer
    Private pPrecio As Decimal
    Private pTipo As String

    ' Constructor
    Public Sub New(IDProd As Integer, Descripcion As String, Stock As Integer, StockMinimo As Integer, Precio As Decimal, Tipo As String)
        Me.pIDProd = IDProd
        Me.pDescripcion = Descripcion
        Me.pStock = Stock
        Me.pStockMinimo = StockMinimo
        Me.pPrecio = Precio
        Me.pTipo = Tipo
    End Sub

    ' Getters / Setters
    Public Property IDProd As Integer
        Get
            Return pIDProd
        End Get
        Set(value As Integer)
            pIDProd = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return pDescripcion
        End Get
        Set(value As String)
            pDescripcion = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return pStock
        End Get
        Set(value As Integer)
            pStock = value
        End Set
    End Property

    Public Property StockMinimo As Integer
        Get
            Return pStockMinimo
        End Get
        Set(value As Integer)
            pStockMinimo = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return pPrecio
        End Get
        Set(value As Decimal)
            pPrecio = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return pTipo
        End Get
        Set(value As String)
            pTipo = value
        End Set
    End Property

End Class
