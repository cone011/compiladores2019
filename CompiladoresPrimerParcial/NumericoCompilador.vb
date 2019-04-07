Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

Public Class NumericoCompilador

    Public Property objetoEntrada As New CompiladoresPrimerParcial.Entrada
    Public Property auxEntradaObjeto As New Entrada
    Public Property auxTabla As New TablaSimbolosParsing
    Public Property utiilidades As New Utilidades
    Public Property estado As Integer

    Public Sub New()

    End Sub

    Public Function simboloNumero(caracter As String) As Integer
        Select Case caracter
            Case IsNumeric(caracter)
                estado = 0
            Case "."
                estado = 1
            Case "e"
                estado = 2
            Case Else
                estado = 10
        End Select
        Return estado
    End Function

    Public Sub esSimboloNumero(caracter As String, posicion As Integer)
        Dim estadoActual As Integer = simboloNumero(caracter)
        Select Case estadoActual
            Case 0
                If IsNumeric(caracter) Then
                    estado = simboloNumero(caracter)
                ElseIf caracter = "e" Then
                    estado = simboloNumero(caracter)
                Else
                    estado = simboloNumero(caracter)
                End If
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
            Case 1
                If IsNumeric(caracter) Then
                    estado = simboloNumero(caracter)
                ElseIf caracter = "." Then
                    estado = simboloNumero(caracter)
                Else
                    estado = simboloNumero(caracter)
                End If
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
            Case 2
                If IsNumeric(caracter) Then
                    estado = simboloNumero(caracter)
                ElseIf caracter = "e" Then
                    estado = simboloNumero(caracter)
                Else
                    estado = simboloNumero(caracter)
                End If
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
            Case 3
                If IsNumeric(caracter) Then
                    estado = simboloNumero(caracter)
                ElseIf caracter = "+" Or caracter = "-" Then
                    estado = simboloNumero(caracter)
                Else
                    estado = simboloNumero(caracter)
                End If
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
            Case 4
                If IsNumeric(caracter) Then
                    estado = simboloNumero(caracter)
                End If
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
            Case 10
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.NUM
        End Select
    End Sub

End Class
