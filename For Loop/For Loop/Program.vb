Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())
        Dim num As Integer

        For num = 1 To 10
            If num Mod 2 = 0 Then
                Console.WriteLine("Even " & num)
            End If
        Next num
    End Sub
End Module
