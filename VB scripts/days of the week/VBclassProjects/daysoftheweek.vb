Module daysoftheweek

    Sub Main()
        'calculating the day of the week'
        Do
            Console.Write("Enter a number 1 to 7 to display its day: ")
            Dim num As Integer = Console.ReadLine()
            Select Case num
                Case 1
                    Console.WriteLine("Sunday")
                    Console.ReadLine()
                Case 2
                    Console.WriteLine("Monday")
                    Console.ReadLine()
                Case 3
                    Console.WriteLine("Tuesday")
                    Console.ReadLine()
                Case 4
                    Console.WriteLine("Wednesday")
                    Console.ReadLine()
                Case 5
                    Console.WriteLine("Thursday")
                    Console.ReadLine()
                Case 6
                    Console.WriteLine("Friday")
                    Console.ReadLine()
                Case 7
                    Console.WriteLine("Saturday")
                    Console.ReadLine()
                Case Else
                    Console.WriteLine("Please enter a number between 1 to 7 only")
                    Console.ReadLine()
            End Select
        Loop
    End Sub

End Module
