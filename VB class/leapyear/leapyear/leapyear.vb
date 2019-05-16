Module leapyear
    'to check for leap year
    Sub Main()
        Do
            Console.Write("Enter the year: ")
            Dim year As Integer = Console.ReadLine()

            If year Mod 4 = 0 And year Mod 100 <> 0 Then
                Console.WriteLine(CStr(year) + " is a leap year")
                Console.ReadLine()
            Else
                Console.WriteLine(CStr(year) + "  Is not")
                Console.ReadLine()
            End If
        Loop
    End Sub
End Module