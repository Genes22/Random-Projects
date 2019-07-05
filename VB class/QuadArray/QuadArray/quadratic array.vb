Module Module1
    Sub Main()
        Dim data(0, 2) As Double
        Dim square, X, X1, X2 As Double

        For n As Double = 0 To 5
            Do While data(0, 0) = 0
                Console.Write("a: ")
                data(0, 0) = Console.ReadLine()
            Loop

            Console.Write("b: ")
                data(0, 1) = Console.ReadLine()
            Console.Write("c: ")
            data(0, 2) = Console.ReadLine()

            square = data(0, 1) * data(0, 1) - 4 * data(0, 0) * data(0, 2)
            If square >= 0 Then
                X1 = (-data(0, 1) + square) / (2 * data(0, 0))
                X2 = (-data(0, 1) - square) / (2 * data(0, 0))

                Console.WriteLine(" X1= " & X1)
                Console.WriteLine(" X2= " & X2)
                data(0, 0) = 0
                Console.ReadLine()
            ElseIf square = 0 Then
                X = (-data(0, 1)) / (2 * data(0, 0))
                Console.WriteLine("The value of X1 and X2 is {0}", X)
                data(0, 0) = 0
            End If
            Console.ReadLine()
        Next
    End Sub
End Module
