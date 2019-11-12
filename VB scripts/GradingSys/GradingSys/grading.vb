Module grading
    Sub Main()
        Dim name(0, 3), grade, remark As String
        Dim subject(0,3) As Double
        Dim sum, average As Double

        For i = 0 To name.Length - 1
            Console.Write("Please enter a student{0} name: ", i + 1)
            name(0, i) = Console.ReadLine()
            For n = 0 To name.Length - 1
                Console.Write("Enter marks for subject{0}:", n + 1)
                subject(0, n) = Console.ReadLine()
            Next
        Next

        For n = 0 To name.Length - 1
            sum = subject(0,0) + Subject(0,1) + subject(0,2) + subject(0,3)
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

            Console.WriteLine(vbLf + "The results of:  subject1:  subject2:   subject3:  subject4:   Sum:  Average:   Grade:   Remark: " + vbLf)
            Console.WriteLine(vbLf + name(0, n) + " " + CStr(sum) + "  " + CStr(subject(0, 0)) + "   " + CStr(subject(0, 1)) + "  " + CStr(subject(0, 2)) + "  " + CStr(subject(0, 3)) + "  " + CStr(sum) + "  " + CStr(average) + "  " + CStr(grade) + "  " + CStr(remark) + vbLf)
        Next
        Console.ReadLine()
    End Sub
End Module