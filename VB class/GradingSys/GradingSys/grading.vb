Module grading
    Sub Main()
        Dim name(3), grade, remark As String
        Dim subject1(3), Subject2(3), subject3(3), subject4(3), subject5(3) As Double
        Dim sum, average As Double

        For i = 0 To name.Length - 1
            Console.Write("Please enter a student{0} name: ", i + 1)
            name(i) = Console.ReadLine()
            Console.Write("Enter marks for subject1: ")
            subject1(i) = Console.ReadLine()
            Console.Write("Enter marks for subject2: ")
            Subject2(i) = Console.ReadLine()
            Console.Write("Enter marks for subject3: ")
            subject3(i) = Console.ReadLine()
            Console.Write("Enter marks for subject4: ")
            subject4(i) = Console.ReadLine()
            Console.Write("Enter marks for subject5: ")
            subject5(i) = Console.ReadLine()
        Next
        For n = 0 To name.Length - 1
            sum = subject1(n) + Subject2(n) + subject3(n) + subject4(n) + subject5(n)
            average = sum / 5
            If (average >= 81 And average <= 100) Then
                grade = "A"
                remark = "Excellent"
            ElseIf (average >= 61 And average <= 80) Then
                grade = "B"
                remark = "Very Good"
            ElseIf (average >= 45 And average <= 60) Then
                grade = "C"
                remark = "Good"
            ElseIf (average >= 21 And average <= 44) Then
                grade = "D"
                remark = "Fair"
            ElseIf (average >= 0 And average <= 20) Then
                grade = "E"
                remark = "Poor"
            End If

            Console.WriteLine(vbLf + "The results of: " + name(n) + " Sum is: " + CStr(sum) + " and Average is: " + CStr(average) + " Grade: " + grade + " Remark: " + remark + vbLf)
        Next
        Console.ReadLine()
    End Sub
End Module