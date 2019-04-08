Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data

''' <summary>
''' Lee un archivo y retorna un txt
''' </summary>
Module Main

    Public Property objetoEntrada As New CompiladoresPrimerParcial.Entrada
    Public Property auxTabla As New TablaSimbolosParsing
    Public Property utiilidades As New Utilidades
    Public Property numerico As New NumericoCompilador
    Public Property simbolos As New SimbolosCompiladores
    Public Property alfanumerico As New AlfaNumeroCompilador
    Public Property listaObjeto As List(Of Entrada)

    Public Property contador As Integer = 0

    Public Const fic As String = "E:\tmp\Prueba.txt" 'lugar donde se coloca el archivo json para ver su contenido

    Sub Main()

        Dim sr As New System.IO.StreamReader(fic) 'para leer el fichero 
        Dim sw As New System.IO.StreamWriter(fic) 'para leer el fichero 
        Dim texto As String = sr.ReadToEnd()
        For Each aux As String In texto
            'Pregunta si es numero alfanumerico o simbolo retorna el valor 
            'en una lista de objeto y lo guarda tambien en un txt
            numerico.esSimboloNumero(aux, contador)
            simbolos.esSimbolo(aux, contador)
            alfanumerico.esAlfaNumerico(aux, contador)
            If Not IsNothing(numerico.objetoEntrada.Lexema) Then
                listaObjeto.Add(numerico.objetoEntrada)
                sw.WriteLine(numerico.objetoEntrada)
            End If
            If Not IsNothing(simbolos.objetoEntrada.Lexema) Then
                listaObjeto.Add(simbolos.objetoEntrada)
                sw.WriteLine(simbolos.objetoEntrada)
            End If
            If Not IsNothing(alfanumerico.objetoEntrada.Lexema) Then
                listaObjeto.Add(alfanumerico.objetoEntrada)
                sw.WriteLine(alfanumerico.objetoEntrada)
            End If
            contador += 1

        Next
        sw.Close()
    End Sub

End Module
