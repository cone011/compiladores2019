Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

''' <summary>
''' Creacion de la Clase Analizador Lexico 
''' </summary>

Public Class AnalizadorLexico
    Public Sub New()

    End Sub

#Region "Datos del AnalizadorLexico"
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

    Private Property _Token As Token

    Private Property Token() As Token
        Get
            Return _Token
        End Get
        Set(ByVal value As Token)
            If _Token IsNot Nothing Then
                IsChanged = True
                _Token = value
            End If
        End Set
    End Property

    Public Property DefinicionCompilador As DefinicionesCompilador
#End Region

End Class
