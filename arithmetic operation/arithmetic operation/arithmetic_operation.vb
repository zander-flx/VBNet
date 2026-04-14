Public Class arithmetic_operation
    Dim firstOperand As Decimal = 0
    Dim secondOperand As Decimal = 0
    Dim currentOperator As String = ""
    Dim isOperatorClicked As Boolean = False
    Dim expression As String = ""

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles _
        btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
        btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        If txtDisplay.Text = "0" Or isOperatorClicked Then
            txtDisplay.Clear()
        End If




        isOperatorClicked = False
        expression &= CType(sender, Button).Text
        txtDisplay.Text = expression
    End Sub

    Private Sub btn_period_Click(sender As Object, e As EventArgs) Handles btn_period.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles _
        btnAdd.Click, btnSub.Click, btnMul.Click, btnDiv.Click, btnMod.Click

        If currentOperator <> "" AndAlso Not isOperatorClicked Then
            MessageBox.Show("Only one operation allowed.")
            btnAC.PerformClick()
            Exit Sub
        End If

        firstOperand = Decimal.Parse(txtDisplay.Text)
        currentOperator = CType(sender, Button).Text
        expression &= " " & currentOperator & " "
        isOperatorClicked = True
    End Sub
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Dim parts() As String = expression.Split(" "c)
        If parts.Length < 3 Then Exit Sub

        firstOperand = Val(parts(0))
        currentOperator = parts(1)
        secondOperand = Val(parts(2))

        Dim result As Double = 0

        Select Case currentOperator
            Case "+"
                result = firstOperand + secondOperand
            Case "-"
                result = firstOperand - secondOperand
            Case "X", "*"
                result = firstOperand * secondOperand
            Case "/"
                If secondOperand <> 0 Then
                    result = firstOperand / secondOperand
                Else
                    MessageBox.Show("Cannot divide by zero")
                    Exit Sub
                End If
            Case "Mod"
                result = firstOperand Mod secondOperand
        End Select

        txtDisplay.Text = result.ToString()

        expression = result.ToString()
        currentOperator = ""

    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txtDisplay.Text = "0"
        expression = ""
        firstOperand = 0
        secondOperand = 0
        currentOperator = ""
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If

        If txtDisplay.Text = "" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub
End Class
