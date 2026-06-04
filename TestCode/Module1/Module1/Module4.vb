Module Module4

    ' Define a simple class to represent an enterprise entity
    Public Class Employee
        Public Property Name As String
        Public Property Department As String
        Public Property PerformanceRating As Integer ' Scale of 1 to 5
        Public Property IsActive As Boolean
        Public Property Bonus As Decimal
    End Class

    Sub Main()
        Console.WriteLine("=== ENTERPRISE HR BONUS PROCESSING SYSTEM ===")
        Console.WriteLine()

        ' 1. SETUP: Create a collection of employees
        ' We use a List(Of T) which is the standard for dynamic collections in .NET
        Dim employees As New List(Of Employee) From {
            New Employee With {.Name = "Alice", .Department = "Engineering", .PerformanceRating = 5, .IsActive = True},
            New Employee With {.Name = "Bob", .Department = "Sales", .PerformanceRating = 3, .IsActive = True},
            New Employee With {.Name = "Charlie", .Department = "HR", .PerformanceRating = 4, .IsActive = False}, ' Inactive employee
            New Employee With {.Name = "Diana", .Department = "Executive", .PerformanceRating = 5, .IsActive = True}
        }

        ' 2. FOR EACH LOOP: Iterate through every item in the collection
        ' This is the most common loop you will use in business applications.
        For Each emp In employees

            ' 3. WITH...END WITH: Cleanly reference the current object's properties
            ' Instead of typing "emp.Name", "emp.Department" every time, we use "With emp"
            With emp

                ' 4. DECISION MAKING (If): Skip inactive employees
                If Not .IsActive Then
                    Console.WriteLine($"[SKIPPED] Inactive employee: { .Name}")

                    ' 5. LOOP CONTROL (Continue): Skip the rest of this iteration and move to the next employee
                    Continue For
                End If

                ' 6. LOOP CONTROL (Exit): Simulate a critical business rule
                ' If we hit the Executive department, we process them and stop the loop entirely 
                ' to simulate a specialized, separate workflow for executives.
                If .Department = "Executive" Then
                    Console.WriteLine($"[CRITICAL] Executive found: { .Name}. Halting standard batch processing.")
                    .Bonus = 10000D ' Flat executive bonus
                    Console.WriteLine($"Processed: { .Name} | Bonus: ${ .Bonus}")

                    ' Exit the loop entirely
                    Exit For
                End If

                ' 7. DECISION MAKING (Select Case): Determine bonus based on performance rating
                ' Much cleaner than using multiple ElseIf statements
                Select Case .PerformanceRating
                    Case 5
                        .Bonus = 5000D
                    Case 4
                        .Bonus = 3000D
                    Case 3
                        .Bonus = 1000D
                    Case Else
                        .Bonus = 0D
                End Select

                Console.WriteLine($"[PROCESSED] { .Name} ({ .Department}) | Rating: { .PerformanceRating} | Bonus: ${ .Bonus}")
            End With
        Next

        Console.WriteLine()
        Console.WriteLine("=== SYSTEM SYNCHRONIZATION MODULE ===")

        ' 8. DO...LOOP / WHILE: Used when the number of iterations is unknown, 
        ' but the stopping condition is clear (e.g., network retries).
        Dim retryCount As Integer = 0
        Dim syncSuccess As Boolean = False

        Do While retryCount < 3 And Not syncSuccess
            retryCount += 1
            Console.WriteLine($"Attempting database sync... (Attempt {retryCount})")

            ' Simulate a failure on the first try, success on the second
            If retryCount = 2 Then
                syncSuccess = True
                Console.WriteLine("SUCCESS: Database synchronized.")
            Else
                Console.WriteLine("FAILED: Connection timeout. Retrying...")
            End If
        Loop

        Console.WriteLine()
        Console.WriteLine("Press any key to exit the application...")
        Console.ReadKey()
    End Sub

End Module