Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

Public Class Entrada

    Public Sub New()

    End Sub

#Region "DefinicionVariablesEntrada"

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

    Private Property _idEntrada As Integer

    Public Property idEntrada() As Integer
        Get
            Return _idEntrada
        End Get
        Set(ByVal value As Integer)
            If _idEntrada <> value Then
                IsChanged = True
                _idEntrada = value
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

    Private Property _Lexema As String = ""

    Public Property Lexema() As Integer
        Get
            Return _Lexema
        End Get
        Set(ByVal value As Integer)
            If _Lexema <> value Then
                IsChanged = True
                _Lexema = value
            End If
        End Set
    End Property

#End Region


End Class
