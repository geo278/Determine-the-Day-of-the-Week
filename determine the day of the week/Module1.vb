Module Module1

    Sub Main()

        Dim firstDay As New System.DateTime(1, 1, 7, 0, 0, 0)
        'Format: (yyyy, mm, dd, hh, mm, ss)



        Console.WriteLine("Please enter a date in this specific format: #mm/dd/yyyy#")
        Dim userRawInput As Date = Console.ReadLine()

        Dim timeDifference As System.TimeSpan
        timeDifference = userRawInput.Subtract(firstDay)

        Dim dayDifference As Integer = timeDifference.TotalDays


        If dayDifference Mod 7 = 0 Then
            Console.WriteLine("Sunday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 1 Then
            Console.WriteLine("Monday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 2 Then
            Console.WriteLine("Tuesday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 3 Then
            Console.WriteLine("Wednessday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 4 Then
            Console.WriteLine("Thursday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 5 Then
            Console.WriteLine("Friday")
            Console.ReadLine()
        ElseIf dayDifference Mod 7 = 6 Then
            Console.WriteLine("Saturday")
            Console.ReadLine()
        End If

    End Sub

End Module

