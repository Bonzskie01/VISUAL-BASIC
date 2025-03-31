Imports System

Module My_Details
    Sub Main(args As String())

        Console.WriteLine("Input your Details")
        Console.Write("Enter your first name is: ")
        Dim fName As String = Console.ReadLine()
        Console.Write("Enter your last name is: ")
        Dim lName As String = Console.ReadLine()
        Console.Write("Enter your address is: ")
        Dim address = Console.ReadLine()
        Console.Write("Enter your Phone Number is: ")
        Dim phoneNum = Console.ReadLine()
        Console.Write("Enter your course is: ")
        Dim course = Console.ReadLine()
        Console.Write("What is your motto: ")
        Dim motto = Console.ReadLine()
        Console.Write("Enter your age is: ")
        Dim age = Console.ReadLine()


        Console.WriteLine("=====My Details=====")
        Console.WriteLine("My Name is: " & fName & " " & lName)
        Console.WriteLine("My Age is: " & age)
        Console.WriteLine("My Phone Number is: " & phoneNum)
        Console.WriteLine("My Address is: " & address)
        Console.WriteLine("My Course is: " & course)
        Console.WriteLine("My Motto is: " & motto)
        Console.WriteLine("=====End=====")



    End Sub
End Module
