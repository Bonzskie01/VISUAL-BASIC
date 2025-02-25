Imports System

Module Program
    Sub Main(args As String())
        Dim weight, height As Double

        Console.WriteLine("Body Mass Index Calculator")
        Console.Write("What is your weight? : ")
        weight = Console.ReadLine()
        Console.Write("What is your height? : ")
        height = Console.ReadLine()

        Dim BMI As Double = weight / (height * height)

        Console.WriteLine("You're BMI is: " & BMI)

    End Sub
End Module
