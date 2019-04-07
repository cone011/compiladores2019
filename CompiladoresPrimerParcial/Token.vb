Public Class Token

    Public Sub New()

    End Sub

#Region "Datos del Token"

    Private Property _IsChanged As Boolean = False

    Public Property IsChanged() As Boolean
        Get
            Return _IsChanged
        End Get
        Set(ByVal value As Boolean)
            If _IsChanged <> value Then
                _IsChanged = value
            End If
        End Set
    End Property

    Private Property _Complex As Integer

    Public Property Complex() As Integer
        Get
            Return _Complex
        End Get
        Set(ByVal value As Integer)
            If _Complex <> value Then
                IsChanged = True
                _Complex = value
            End If
        End Set
    End Property

    Private Property _Entrada As Entrada

    Private Property Entrada() As Entrada
        Get
            Return _Entrada
        End Get
        Set(ByVal value As Entrada)
            If _Entrada IsNot Nothing Then
                IsChanged = True
                _Entrada = value
            End If
        End Set
    End Property


#End Region


End Class
