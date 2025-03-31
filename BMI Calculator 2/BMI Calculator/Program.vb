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

        If BMI <= 18.5 Then
            Console.WriteLine("You are Underweight")
        ElseIf BMI >= 18.5 And 24.9 Then
            Console.WriteLine("You are Normal Weight")
        ElseIf BMI <= 25 And 29.9 Then
            Console.WriteLine("You are Overweight")
        Else
            Console.WriteLine("You are Obese")
        End If
    End Sub
End Module
