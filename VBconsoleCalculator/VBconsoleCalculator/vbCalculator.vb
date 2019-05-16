Module vbCalculator
    Dim  result As string
    Function Addition(ByRef num1 As Integer, ByRef num2 As Integer) As Integer
        result = num1 + num2
        Return result
    End Function

    Function Substraction(ByRef num1 As Integer, ByRef num2 As Integer) As Integer
        result = num1 - num2
        Return result
    End Function

    Function Multiplication(ByRef num1 As Integer, ByRef num2 As Integer) As Integer
        result = num1 * num2
        Return result
    End Function

    Function Division(ByRef num1 As Integer, ByRef num2 As Integer) As Integer
        result = num1 / num2
        Return result
    End Function
    Sub Main()
        Dim num1, num2 As Integer
        Dim operation, result As String
        Console.Write("Enter the first number: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter the operation you want to perform: " + vbLf + " + or Add: " + vbLf + " - or sub: " + vbLf + " * or mult: " + vbLf + "/ or div:")
        operation = Console.ReadLine()
        Console.Write("Enter the second number: ")
        num2 = Console.ReadLine()

        Select Case operation
            Case operation = "+" Or operation = "add"
                result = Addition(num1, num2)
                Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result)
            Case operation = "-" Or operation = "sub"
                result = Substraction(num1, num2)
                Console.WriteLine("The solution  of {0} minus {1} is: {2}", num1, num2, result)
                Console.WriteLine("The subst is {0}", result)
            Case operation = "*" Or operation = "mult"
                result = Multiplication(num1, num2)
                Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, result)
            Case operation = "/" Or operation = "div"
                If num2 = 0 Then
                    Dim num3, num4 As Integer
                    Console.WriteLine("the second number cannot be zero ")
                    Console.Write("Enter the first number again: ")
                    num1 = Console.ReadLine()
                    Console.Write("Enter a non zero second number: ")
                    num2 = Console.ReadLine()
                    result = Division(num3, num4)
                    Console.WriteLine("The result of {0} divided by {1} is: {2}", num3, num4, result)
                Else
                    result = Division(num1, num2)
                    Console.WriteLine("The solution of {0} divided by {1} is: {2}", num1, num2, result)
                End If
            Case Else
                Console.WriteLine()
        End Select
        Console.ReadLine()
    End Sub
End Module
