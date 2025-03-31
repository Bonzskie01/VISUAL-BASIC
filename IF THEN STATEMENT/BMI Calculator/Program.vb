Imports System

Module Program
    Sub Main(args As String())
        Dim num1 As Integer

        Console.WriteLine("NUMBER CHECKER")
        Console.Write("Type a number: ")
        num1 = Console.ReadLine()

        If num1 < 0 Then
            Console.WriteLine("Negative")
        ElseIf num1 > 0 Then
            Console.WriteLine("Positive")
        Else
            Console.WriteLine("Zero")
        End If
    End Sub
End Module
