Imports System
Imports System.Numerics
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Dim fnum, secnum As Integer

        Console.WriteLine("Simple Arithmetic Operation")
        Console.Write("Enter the First Number: ")
        fnum = Console.ReadLine()
        Console.Write("Enter the Second Number: ")
        secnum = Console.ReadLine()

        Dim sum As Integer = fnum + secnum
        Dim prod As Integer = fnum * secnum
        Dim quot As Double = fnum / secnum
        Dim diff As Integer = fnum - secnum

        Console.WriteLine("====OUTPUT=====")
        Console.WriteLine("The sum of two number: " & sum)
        Console.WriteLine("The product of two number: " & prod)
        Console.WriteLine("The difference number: " & diff)
        Console.WriteLine("The quotient number: " & quot)

    End Sub
End Module
