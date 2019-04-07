Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports CompiladoresPrimerParcial
Imports CompiladoresPrimerParcial.TablaSimbolosParsing

Public Class SimbolosCompiladores

    Public Sub New()

    End Sub

    Public Property objetoEntrada As New CompiladoresPrimerParcial.Entrada
    Public Property auxEntradaObjeto As New Entrada
    Public Property auxTabla As New TablaSimbolosParsing
    Public Property utiilidades As New Utilidades

    Public Sub esSimbolo(caracter As String, posicion As Integer)
        Select Case caracter
            Case "="
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = CompiladoresPrimerParcial.DefinicionesCompilador.OP_RELACION
            Case ":"
                If caracter = "=" Then
                    objetoEntrada = auxTabla.buscarEntrada(caracter)
                    objetoEntrada.Complex = DefinicionesCompilador.OPASIGNACION
                Else
                    objetoEntrada = auxTabla.buscarEntrada(caracter)
                    objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
                End If
            Case "+"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.OPSUM
            Case "-"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.OPSUM
            Case "*"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.OPMULT
            Case "/"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.OPMULT
            Case ","
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case ";"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case "."
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case "["
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case "]"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case "("
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                'Utilizo un auxiliar de objeto para realizar el siguiente elemento para hacer la comparacion
                Dim auxObjetoSiguente As Entrada = auxTabla.SiguenteCaracter(objetoEntrada.idEntrada + 1)
                If auxObjetoSiguente.Lexema = "*" Then
                    auxEntradaObjeto = auxTabla.SiguenteCaracter(auxObjetoSiguente.idEntrada + 1)
                    If auxEntradaObjeto.Lexema = "*" Then
                        auxEntradaObjeto = auxTabla.SiguenteCaracter(auxEntradaObjeto.idEntrada + 1)
                        If auxEntradaObjeto.Lexema = ")" Then
                            objetoEntrada = auxEntradaObjeto
                        ElseIf auxEntradaObjeto.Lexema = "\n" Then
                            utiilidades.IncrementarLinea(auxEntradaObjeto.Lexema)
                        End If
                    End If
                Else
                    objetoEntrada = auxTabla.buscarEntrada(caracter)
                    objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
                End If
            Case = ")"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
            Case = "{"
                objetoEntrada = auxTabla.buscarEntrada(caracter)
                utiilidades.id = objetoEntrada.idEntrada
                utiilidades.Caracter = objetoEntrada.Lexema
                auxEntradaObjeto = auxTabla.SiguenteCaracter(utiilidades.id + 1)
                If auxEntradaObjeto.Lexema = "}" Then
                    objetoEntrada = auxTabla.buscarEntrada(caracter)
                    objetoEntrada.Complex = DefinicionesCompilador.PR_SIMBOLOS
                ElseIf auxEntradaObjeto.Lexema = "\n" Then
                    utiilidades.IncrementarLinea(auxEntradaObjeto.Lexema)
                End If
        End Select
    End Sub

End Class
