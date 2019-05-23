Module quadratic
    Sub Main()
        Do
            Dim a, b, c As Integer
            Dim x1, x2, x, num As Double

            Console.WriteLine("Enter a: ")
            a = Console.ReadLine()

            Console.WriteLine("Enter b:")
            b = Console.ReadLine()

            Console.WriteLine("Enter c:")
            c = Console.ReadLine()

            If a = 0 Then
                Console.WriteLine("No solution.!!.." + vbLf + "The value of A cannot be 0 in Quadratic equations")
            Else
                num = Math.Sqrt((b ^ 2) - (4 * a * c))
                If num > 0 Then
                    x1 = ((-b) + num) / (2 * a)
                    x2 = ((-b) - num) / (2 * a)
                    Console.WriteLine("The value of x1 is {0}", x1)
                    Console.WriteLine("The value of x2 is {0}", x2)
                ElseIf num = 0 Then
                    x = (-b) / (2 * a)
                    Console.WriteLine("The value of X1 and X2 is {0}", x)
                End If
            End If
            Console.ReadLine()
        Loop
    End Sub
End Module