Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports CompiladoresPrimerParcial

Public Class AlfaNumeroCompilador

    Public Sub New()

    End Sub

#Region "Definicion de Variables AlfaNumeroCompilador"
    Public Property objetoEntrada As New CompiladoresPrimerParcial.Entrada
    Public Property auxEntradaObjeto As New Entrada
    Public Property auxTabla As New TablaSimbolosParsing
    Public Property utiilidades As New Utilidades
    Public Property numericoCompilador As New NumericoCompilador


#End Region

#Region "Funciones&Procedimientos AlfaNumeroCompilador"

    Public Sub esAlfaNumerico(caracter As String, numero As Integer)

        If String.IsNullOrEmpty(caracter) Then
            If IsNumeric(caracter) Then
                numericoCompilador.esSimboloNumero(caracter, numero)
            Else
                objetoEntrada = auxTabla.buscarEntrada(caracter)
            End If
        End If
    End Sub


#End Region




End Class
