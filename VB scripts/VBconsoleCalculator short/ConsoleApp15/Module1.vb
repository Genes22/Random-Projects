Module Module1
    Dim firstnum, zeroerr As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim mathOperator As String
    Dim result As String

    Function Addition(ByVal num1 As Double, ByVal num2 As Double) As Double
        result = num1 + num2
        Return result
    End Function

    Function Minus(ByVal num1 As Double, ByVal num2 As Double) As Double
        result = num1 - num2
        Return result
    End Function

    Function Multiplication(ByVal num1 As Double, ByVal num2 As Double) As Double
        result = num1 * num2
        Return result
    End Function

    Function Division(ByVal num1 As Double, ByVal num2 As Double) As Double
        result = num1 / num2
        Return result
    End Function

    Function Remainder(ByVal num1 As Double, ByVal num2 As Double) As Double
        result = num1 Mod num2
        Return result
    End Function

    Sub Main()

        Console.WriteLine("Console Calculator Tutorial" + vbNewLine)

            Console.WriteLine("Enter the first number" + vbNewLine)
            firstnum = Double.Parse(Console.ReadLine)

            Console.WriteLine("Select any operator:+,-,*,/" + vbNewLine)
            mathOperator = Console.ReadLine

            Console.WriteLine("Enter the second number" + vbNewLine)
        secondnum = Double.Parse(Console.ReadLine)

        If secondnum = 0 Then
            Console.WriteLine("Retry second number")
            zeroerr = Console.ReadLine()
            answer = firstnum / zeroerr

        Else
            answer = firstnum / secondnum

        End If


        Select Case mathOperator

                Case ("+")
                    answer = firstnum + secondnum

                Case ("-")
                    answer = firstnum - secondnum

                Case ("*")
                    answer = firstnum * secondnum

                Case ("/")



        End Select
            Console.Write(answer)
            Console.Write(vbNewLine + "press any key to exit.....")
            Console.ReadKey()



    End Sub

End Module
