Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports CompiladoresPrimerParcial

Public Class TablaSimbolosParsing

    Public Sub New()

    End Sub

#Region "Definicion de Variables TablaSimbolosParsing"

    Public Property ListaEntrada As New List(Of Entrada)


#End Region

#Region "Funciones&Procedimientos TablaSimbolosParsing"


    Public Function esPrimo(numero As Integer) As Boolean
        Dim retornor As Boolean = False
        For aux As Integer = 3 To numero Step 2
            If retornor / aux <> 0 Then
                aux = True
            End If
        Next
        Return retornor
    End Function

    Public Function SiguientePrimo(numero As Integer) As Boolean
        Dim esNumeroPrimo As Boolean = False
        If numero / 2 = 0 Then
            numero += 1
        End If
        esNumeroPrimo = esPrimo(numero)
        Return esNumeroPrimo
    End Function

    Public Sub insertarEntrada(objetoEntrada As CompiladoresPrimerParcial.Entrada)
        ListaEntrada.Add(objetoEntrada)
    End Sub

    Public Function buscarEntrada(buscarClave As String) As CompiladoresPrimerParcial.Entrada
        Dim objetoEntradaDevolver As New CompiladoresPrimerParcial.Entrada
        For Each auxEntrada As CompiladoresPrimerParcial.Entrada In ListaEntrada
            If auxEntrada.Lexema = buscarClave Then
                objetoEntradaDevolver = auxEntrada
            End If
        Next
        Return objetoEntradaDevolver
    End Function

    Public Function SiguenteCaracter(idEntrada As Integer) As CompiladoresPrimerParcial.Entrada
        Dim objetoEntradaDevolver As New CompiladoresPrimerParcial.Entrada
        For Each auxEntrada As CompiladoresPrimerParcial.Entrada In ListaEntrada
            If idEntrada = auxEntrada.idEntrada Then
                objetoEntradaDevolver = auxEntrada
            End If
        Next
        Return objetoEntradaDevolver
    End Function

    Public Sub instertarTablaSimbolos(Simbolo As String, aux As Integer)
        Dim auxEntrada As New CompiladoresPrimerParcial.Entrada
        auxEntrada.Complex = aux
        auxEntrada.Lexema = Simbolo
        insertarEntrada(auxEntrada)
    End Sub


    Public Sub inicializarTablaSimbolos()
        Dim listaObjeto As String() = {TablaSimbolos.program,
                                       TablaSimbolos.PR_BOOLEAN,
                                       TablaSimbolos.PR_CASE,
                                       TablaSimbolos.PR_CHAR,
                                       TablaSimbolos.PR_CONST,
                                       TablaSimbolos.PR_DO,
                                       TablaSimbolos.PR_ELSE,
                                       TablaSimbolos.PR_End,
                                       TablaSimbolos.PR_FOR,
                                       TablaSimbolos.PR_FUNCITION,
                                       TablaSimbolos.PR_IF,
                                       TablaSimbolos.PR_INTEGER,
                                       TablaSimbolos.PR_OF,
                                       TablaSimbolos.PR_PROCEDURE,
                                       TablaSimbolos.PR_RECORD,
                                       TablaSimbolos.PR_REPEAT,
                                       TablaSimbolos.PR_THEN,
                                       TablaSimbolos.PR_TO,
                                       TablaSimbolos.PR_UNTIL,
                                       TablaSimbolos.PR_WHILE,
                                       TablaSimbolos.PR_WRITE,
                                       TablaSimbolos.PR_WRITELN,
                                       TablaSimbolos.array,
                                       TablaSimbolos.begin,
                                       TablaSimbolos.downto,
                                       TablaSimbolos.program,
                                       TablaSimbolos.var,
                                       TablaSimbolos.type}

        For aux As Integer = 0 To listaObjeto.Count()
            instertarTablaSimbolos(listaObjeto(aux), aux + DefinicionesCompilador.PROGRAM)
        Next

        instertarTablaSimbolos(",", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos(".", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos(":", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos(";", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos("(", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos(")", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos("[", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos("]", DefinicionesCompilador.PR_SIMBOLOS)
        instertarTablaSimbolos("true", DefinicionesCompilador.PR_BOOLEAN)
        instertarTablaSimbolos("false", DefinicionesCompilador.PR_BOOLEAN)
        instertarTablaSimbolos("not", DefinicionesCompilador.PR_NOT)
        instertarTablaSimbolos("<", DefinicionesCompilador.OP_RELACION)
        instertarTablaSimbolos("<=", DefinicionesCompilador.OP_RELACION)
        instertarTablaSimbolos("<>", DefinicionesCompilador.OP_RELACION)
        instertarTablaSimbolos(">", DefinicionesCompilador.OP_RELACION)
        instertarTablaSimbolos(">=", DefinicionesCompilador.OP_RELACION)
        instertarTablaSimbolos("=", DefinicionesCompilador.OPASIGNACION)
        instertarTablaSimbolos("+", DefinicionesCompilador.OPSUM)
        instertarTablaSimbolos("-", DefinicionesCompilador.OPSUM)
        instertarTablaSimbolos("or", DefinicionesCompilador.OPSUM)
        instertarTablaSimbolos("*", DefinicionesCompilador.OPMULT)
        instertarTablaSimbolos("/", DefinicionesCompilador.OPMULT)
        instertarTablaSimbolos("div", DefinicionesCompilador.OPMULT)
        instertarTablaSimbolos("mod", DefinicionesCompilador.OPMULT)
        instertarTablaSimbolos(":=", DefinicionesCompilador.OPSUM)
    End Sub
#End Region
End Class
