Module Module2

    Sub Main()
        ' ==========================================
        ' SCENARIO 1: Do While (Condition at the TOP)
        ' ==========================================
        Console.WriteLine("--- SCENARIO 1: Do While (Checks condition FIRST) ---")

        Dim attempts As Integer = 0
        Dim maxAttempts As Integer = 5
        Dim isConnected As Boolean = False

        ' The loop will ONLY run if attempts < 5 AND we are not yet connected.
        ' If isConnected was already True, this loop would run 0 times.
        Do While attempts < maxAttempts And Not isConnected
            attempts += 1
            Console.WriteLine($"  Attempting connection... (Attempt {attempts})")

            ' Simulate a successful connection on the 3rd try
            If attempts = 3 Then
                isConnected = True
                Console.WriteLine("  SUCCESS: Connected to the server!")
            Else
                Console.WriteLine("  FAILED: Connection timed out.")
            End If
        Loop

        Console.WriteLine()

        ' ==========================================
        ' SCENARIO 2: Do...Loop Until (Condition at the BOTTOM)
        ' ==========================================
        Console.WriteLine("--- SCENARIO 2: Do...Loop Until (Runs AT LEAST ONCE) ---")

        ' Reset our variables for a fresh start
        attempts = 0
        isConnected = False

        Do
            attempts += 1
            Console.WriteLine($"  Pinging server... (Ping {attempts})")

            ' Simulate success on the 2nd try
            If attempts = 2 Then
                isConnected = True
                Console.WriteLine("  SUCCESS: Server responded!")
            End If

            ' ENTERPRISE BEST PRACTICE: The "Emergency Brake"
            ' Even if the main condition isn't met, we must prevent an infinite loop.
            ' Exit Do immediately breaks out of the loop, no questions asked.
            If attempts >= maxAttempts Then
                Console.WriteLine("  WARNING: Maximum attempts reached. Forcing Exit Do.")
                Exit Do
            End If

            ' The loop stops when isConnected becomes True, OR if Exit Do is triggered above.
        Loop Until isConnected

        Console.WriteLine()
        Console.WriteLine($"Final System Status: Connected = {isConnected} | Total Attempts = {attempts}")

        Console.WriteLine()
        Console.WriteLine("Press any key to exit the application...")
        Console.ReadKey()
    End Sub

End Module