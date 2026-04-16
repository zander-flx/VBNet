Public Class arithmetic_operation

    Private firstNumber As Double = 0
    Private currentOperator As String = ""
    Private isError As Boolean = False
    Private justPressedOperator As Boolean = False
    Private justPressedEquals As Boolean = False

    Private Sub AppendDigit(digit As String)
        If isError Then Return

        If justPressedEquals Then
            txtDisplay.Text = digit
            justPressedEquals = False
            Return
        End If

        If justPressedOperator Then
            txtDisplay.Text &= " " & digit
            justPressedOperator = False
        ElseIf txtDisplay.Text = "0" Then
            txtDisplay.Text = digit
        Else
            txtDisplay.Text &= digit
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        AppendDigit("0")
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        AppendDigit("1")
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        AppendDigit("2")
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        AppendDigit("3")
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        AppendDigit("4")
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        AppendDigit("5")
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        AppendDigit("6")
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        AppendDigit("7")
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        AppendDigit("8")
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        AppendDigit("9")
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If isError Then Return

        If justPressedOperator Then
            txtDisplay.Text &= " 0."
            justPressedOperator = False
            Return
        End If

        If justPressedEquals Then
            txtDisplay.Text = "0."
            justPressedEquals = False
            Return
        End If

        Dim parts() As String = txtDisplay.Text.Split(" ")
        Dim lastPart As String = parts(parts.Length - 1)
        If Not lastPart.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub HandleOperator(op As String)
        If isError Then Return

        If currentOperator <> "" AndAlso Not justPressedOperator Then
            ShowError("Error: Only one operator allowed!")
            Return
        End If

        firstNumber = Double.Parse(txtDisplay.Text.Split(" ")(0))
        currentOperator = op
        justPressedOperator = True
        justPressedEquals = False

        Dim displayFirst As String = If(firstNumber = Math.Floor(firstNumber) AndAlso Math.Abs(firstNumber) < 1.0E+15, CType(firstNumber, Long).ToString(), firstNumber.ToString("G10"))
        txtDisplay.Text = displayFirst & " " & op
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        HandleOperator("+")
    End Sub
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        HandleOperator("-")
    End Sub
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        HandleOperator("x")
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        HandleOperator("/")
    End Sub
    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click
        HandleOperator("%")
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If isError Then Return
        If currentOperator = "" Then Return

        Dim parts() As String = txtDisplay.Text.Split(" ")
        If parts.Length < 3 Then Return

        Dim secondNumber As Double
        If Not Double.TryParse(parts(parts.Length - 1), secondNumber) Then
            ShowError("Error: Invalid number")
            Return
        End If

        Dim result As Double = 0

        Try
            Select Case currentOperator
                Case "+"
                    result = firstNumber + secondNumber
                Case "-"
                    result = firstNumber - secondNumber
                Case "x"
                    result = firstNumber * secondNumber
                Case "/"
                    If secondNumber = 0 Then
                        ShowError("Error: Division by zero!")
                        Return
                    End If
                    result = firstNumber / secondNumber
                Case "%"
                    If secondNumber = 0 Then
                        ShowError("Error: Modulo by zero!")
                        Return
                    End If
                    result = firstNumber Mod secondNumber
            End Select

            If result = Math.Floor(result) AndAlso Math.Abs(result) < 1.0E+15 Then
                txtDisplay.Text = CType(result, Long).ToString()
            Else
                txtDisplay.Text = result.ToString("G10")
            End If

            currentOperator = ""
            justPressedEquals = True
            justPressedOperator = False

        Catch ex As Exception
            ShowError("Error: Invalid operation")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetAll()
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If isError Then
            ResetAll()
            Return
        End If
        If justPressedOperator Then Return
        If txtDisplay.Text.Length > 1 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1).TrimEnd()
        Else
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub ShowError(message As String)
        txtDisplay.Text = message
        txtDisplay.ForeColor = Color.Red
        isError = True
        currentOperator = ""
    End Sub

    Private Sub ResetAll()
        txtDisplay.Text = "0"
        txtDisplay.ForeColor = Color.Black
        firstNumber = 0
        currentOperator = ""
        isError = False
        justPressedOperator = False
        justPressedEquals = False
    End Sub



End Class