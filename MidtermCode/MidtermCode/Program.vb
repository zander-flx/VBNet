Module Program

    Sub Main()
        ' ==========================================
        ' PART 1: DECISION MAKING (Week 6)
        ' ==========================================
        Console.WriteLine("--- PART 1: DECISION MAKING ---")

        Dim score As Integer = 85
        Dim grade As String

        ' 1. Select Case: Cleanly maps a value to a specific outcome
        ' This is much easier to read than multiple "ElseIf" statements.
        Select Case score
            Case Is >= 90
                grade = "A"
            Case Is >= 80
                grade = "B"
            Case Is >= 70
                grade = "C"
            Case Else
                grade = "F"
        End Select

        ' 2. If...Then...Else: Evaluates a simple True/False condition
        If grade <> "F" Then
            Console.WriteLine($"Result: Score is {score}, Grade is {grade}. You Passed!")
        Else
            Console.WriteLine($"Result: Score is {score}, Grade is {grade}. You Failed.")
        End If

        Console.WriteLine() ' Prints a blank line for readability

        ' ==========================================
        ' PART 2: LOOPS (Week 7-8)
        ' ==========================================
        Console.WriteLine("--- PART 2: LOOPS ---")

        ' 3. For...Next Loop: Use when you know EXACTLY how many times to repeat.
        ' Here, we want to repeat the action exactly 3 times.
        Console.WriteLine("Counting steps:")
        For i As Integer = 1 To 3
            Console.WriteLine($"  Processing step {i}...")
        Next

        Console.WriteLine()

        ' 4. For Each...Next Loop: Use when you want to look at every item in a list/array.
        ' We don't need to count; we just want to visit each name.
        Dim students() As String = {"Alice", "Bob", "Charlie"}

        Console.WriteLine("Class Roster:")
        For Each student In students
            Console.WriteLine($"  - {student}")
        Next

        Console.WriteLine()
        Console.WriteLine("Press any key to exit the application...")
        Console.ReadKey()
    End Sub

End Module