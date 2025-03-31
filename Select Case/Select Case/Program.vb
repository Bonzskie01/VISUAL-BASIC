Imports System

Module Program
    Sub Main(args As String())
        Dim age As Double

        Console.WriteLine("Age Group Identifier")
        Console.Write("What is your age? : ")
        age = Console.ReadLine()

        Select Case age
            Case < 13
                Console.WriteLine("You're " & age & " and You are Child")
            Case 13 To 19
                Console.WriteLine("You're " & age & " and You are Teen")
            Case 20 To 64
                Console.WriteLine("You're " & age & "and You are Adult")
            Case Else
                Console.WriteLine("You're " & age & "and You are Senior")
        End Select
    End Sub
End Module
