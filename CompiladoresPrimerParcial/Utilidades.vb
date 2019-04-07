Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

Public Class Utilidades

    Public Sub New()

    End Sub
    Public Function eliminarEspacioBlanco(caracter As String) As Boolean
        Dim confirmarEliminar As Boolean = False
        If caracter = " " Or caracter = "\t" Then
            confirmarEliminar = True
        End If
        Return confirmarEliminar
    End Function

    Public Function IncrementarLinea(caracter As String) As Boolean
        Dim confirmarIncrementar As Boolean = False
        If caracter = "\n" Then
            confirmarIncrementar = True
        End If
        Return confirmarIncrementar
    End Function

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

    Private Property _Caracter As Integer

    Public Property Caracter() As Integer
        Get
            Return _Caracter
        End Get
        Set(ByVal value As Integer)
            If _Caracter <> value Then
                IsChanged = True
                _Caracter = value
            End If
        End Set
    End Property


    Private Property _id As Integer

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            If _id <> value Then
                IsChanged = True
                _id = value
            End If
        End Set
    End Property
End Class
