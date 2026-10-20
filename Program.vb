Imports System

Module Program
    Sub Main(args As String())
        Dim score as Integer = 0

        For index = 1 to 5
            Console.Write("Enter a score: ")
            score = score + Console.ReadLine()
        Next index

        Console.WriteLine("The total score was: " & score)
        Console.WriteLine("The average score was: " & score / 5)
    End Sub
End Module
