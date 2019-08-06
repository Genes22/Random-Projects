Module Calculator
    Dim firstnum, zeroerr As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim mathOperator As String


    Sub Main()
        Console.WriteLine("Console Calculator Tutorial" + vbNewLine)

        Console.WriteLine("Enter the first number" + vbNewLine)
        firstnum = Double.Parse(Console.ReadLine)

        Console.WriteLine("Select any operator:+,-,*,/" + vbNewLine)
        mathOperator = Console.ReadLine

        Console.WriteLine("Enter the second number" + vbNewLine)
        secondnum = Double.Parse(Console.ReadLine)

        Select Case mathOperator

            Case ("+")
                answer = firstnum + secondnum

            Case ("-")
                answer = firstnum - secondnum

            Case ("*")
                answer = firstnum * secondnum

            Case ("/")


                If secondnum = 0 Then
                    Console.WriteLine("Retry second number")
                    zeroerr = Console.ReadLine()
                    answer = firstnum / zeroerr

                Else
                    answer = firstnum / secondnum

                End If

        End Select
        Console.Write(answer)
        Console.Write(vbNewLine + "press any key to exit.....")
        Console.ReadKey()

    End Sub

End Module
