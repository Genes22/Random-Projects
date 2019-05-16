Module vbCalculator

    Sub Main()
        Dim num1, num2 As Integer
        Dim operation As String
        Console.Write("Enter the first number: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter the operation you want to perform: " + vbLf + " + or Add: " + vbLf + " - or sub: " + vbLf + " * or mult: " + vbLf + "/ or div:")
        operation = Console.ReadLine()
        Console.Write("Enter the second number: ")
        num2 = Console.WriteLine()

        Select Case operation
            Case "+" Or "add"
                additionfun()
            Case "-" Or "sub"
                substractionfuc()
            Case "*" Or "mult"
                multiplication()
            Case "/" Or "div"
                If num2 == 0 Then
                    Console.WriteLine("the second number cannot be zero ")
                    Console.Write("Enter the first number again: ")
                    num1 = Console.ReadLine()
                    Console.Write("Enter a non zero second number: ")
                    num2 = Console.ReadLine()
                Else
                    division()


                    Case Else
                    Console.WriteLine()
        End Select
        Console.ReadLine()
    End Sub
End Module
