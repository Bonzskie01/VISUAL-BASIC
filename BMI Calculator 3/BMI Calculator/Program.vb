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

        Select Case BMI
            Case <= 18.5
                Console.WriteLine(BMI & " You are Underweight")
            Case 18.6 To 24.9
                Console.WriteLine(BMI & " You are Normal Weight")
            Case 25 To 29.9
                Console.WriteLine(BMI & " You are Overweight")
            Case Else
                Console.WriteLine(BMI & " You are Obese")
        End Select
    End Sub
End Module
