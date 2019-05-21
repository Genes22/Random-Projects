Module vbCalculator
    Dim result As String
    Function Addition(ByRef num1 As Double, ByRef num2 As Double) As Double
        result = num1 + num2
        Return result
    End Function

    Function Minus(ByRef num1 As Double, ByRef num2 As Double) As Double
        result = num1 - num2
        Return result
    End Function

    Function Multiplication(ByRef num1 As Double, ByRef num2 As Double) As Double
        result = num1 * num2
        Return result
    End Function

    Function Division(ByRef num1 As Double, ByRef num2 As Double) As Double
        result = num1 / num2
        Return result
    End Function
    Sub Main()
        Do
            Dim num1, num2, num3 As Double
            Dim operation, result As String
            Console.Write("Enter the first number: ")
            num1 = Console.ReadLine()
            Console.WriteLine("Enter the operation you want to perform: " + vbLf + " + : " + vbLf + " - : " + vbLf + " * : " + vbLf + "/ :")
            operation = Console.ReadLine()
            Console.Write("Enter the second number: ")
            num2 = Console.ReadLine()

            'case statement for making the calculations
            Select Case operation
                Case "+"
                    result = Addition(num1, num2)
                    Console.WriteLine("The sum of {0} and {1} is: {2}" + vbLf, num1, num2, result)
                Case "-"
                    result = Minus(num1, num2)
                    Console.WriteLine("The solution  of {0} minus {1} is: {2}" + vbLf, num1, num2, result)
                Case "*"
                    result = Multiplication(num1, num2)
                    Console.WriteLine("The product of {0} and {1} is: {2}" + vbLf, num1, num2, result)
                Case "/"
                    If num2 = 0 Then
                        Console.WriteLine("the second number cannot be zero " + vbLf)
                        Console.Write("Enter a non-zero dividing number again: ")
                        num3 = Console.ReadLine()
                        result = Division(num1, num3)
                        Console.WriteLine("The result of {0} divided by {1} is: {2}" + vbLf, num1, num3, result)
                    Else
                        result = Division(num1, num2)
                        Console.WriteLine("The solution of {0} divided by {1} is: {2}" + vbLf, num1, num2, result)
                    End If
                Case Else
                    Console.WriteLine("The operation did not execute please try again" + vbLf)
            End Select
        Loop
    End Sub
End Module






'a calculator by using conditional statement instead of case select statement.
'Dim num1, num2 As Double
'Dim operation, result As String
'Console.Write("Enter the first number: ")
'num1 = Console.ReadLine()
'Console.WriteLine("Enter the operation you want to perform: " + vbLf + " + or add: " + vbLf + " - or sub: " + vbLf + " * or mult: " + vbLf + "/ or div:")
'operation = Console.ReadLine()
'Console.Write("Enter the second number: ")
'num2 = Console.ReadLine()

'If operation.Contains("+") Or operation.Contains("add") Then
'result = Addition(num1, num2)
'Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result)
'ElseIf operation.Contains("-") Or operation.Contains("sub") Then
'result = Minus(num1, num2)
'Console.WriteLine("The solution  of {0} minus {1} is: {2}", num1, num2, result)
'ElseIf operation.Contains("*") Or operation.Contains("mult") Then
'result = Multiplication(num1, num2)
'Console.WriteLine("The product of {0} and {1} is: {2}", num1, num2, result)
'ElseIf operation.Contains("/") Or operation.Contains("div") Then
'If num2 = 0 Then
'Dim num3, num4 As Double
'Console.WriteLine("The divider cannot be zero ")
'Console.Write("Enter the first number again: ")
'num3 = Console.ReadLine()
'Console.Write("Enter a non zero second number: ")
'num4 = Console.ReadLine()
'result = num3 / num4
'Console.WriteLine("The result of {0} divided by {1} is: {2}", num3, num4, result)
'Else
'result = Division(num1, num2)
'Console.WriteLine("The solution of {0} divided by {1} is: {2}", num1, num2, result)
'End If
'Else
'Console.WriteLine("Enter valid values")
'End If
'Console.ReadLine()