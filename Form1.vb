Public Class Form1
    Dim Answer1 As Integer
    Dim Answer2 As Integer
    Dim hasOperator As Boolean
    Dim operatorUsed As Boolean = False
    Dim equalsUsed As Boolean = False
    Dim whichOperator As Integer
    Dim Answer1Used As Boolean = False
    Dim result As Integer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Sub calculation()
        If Answer1Used = False Then
            lblOutput.Text = Answer1 & Val(lblOutput.Text)
        Else
            Answer1 = Val(lblOutput.Text)
            Answer2 = lblOutput.Text.Substring(lblOutput.Text.Length )
            lblOutput.Text = Answer1 + Answer2
        End If
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        lblOutput.Text = lblOutput.Text & btn0.Text
        calculation()
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lblOutput.Text = lblOutput.Text & btn1.Text
        calculation()
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lblOutput.Text = lblOutput.Text & btn2.Text
        calculation()
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblOutput.Text = lblOutput.Text & btn3.Text
        calculation()
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblOutput.Text = lblOutput.Text & btn4.Text
        calculation()
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lblOutput.Text = lblOutput.Text & btn5.Text
        calculation()
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lblOutput.Text = lblOutput.Text & btn6.Text
        calculation()
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lblOutput.Text = lblOutput.Text & btn7.Text
        calculation()
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lblOutput.Text = lblOutput.Text & btn8.Text
        calculation()
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lblOutput.Text = lblOutput.Text & btn9.Text
        calculation()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        lblOutput.Text = lblOutput.Text & btnEquals.Text
        If equalsUsed = False Then
            lblOutput.Text = lblOutput.Text & btnEquals.Text
            If whichOperator = btnPlus.Text Then
                result = Answer1 + Answer2
                lblOutput.Text = result
            ElseIf whichOperator = btnMinus.Text Then
                result = Answer1 - Answer2
                lblOutput.Text = result
            ElseIf whichOperator = btnMultiply.Text Then
                result = Answer1 * Answer2
                lblOutput.Text = result
            ElseIf whichOperator = btnDivide.Text Then
                result = Answer1 / Answer2
                lblOutput.Text = result
            End If
            equalsUsed = True
        Else

        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Answer1Used = True
        lblOutput.Text = lblOutput.Text & btnPlus.Text
        hasOperator = True
        operatorUsed = True
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Answer1Used = True
        lblOutput.Text = lblOutput.Text & btnMinus.Text
        hasOperator = True
        operatorUsed = True
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Answer1Used = True
        lblOutput.Text = lblOutput.Text & btnMultiply.Text
        hasOperator = True
        operatorUsed = True
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Answer1Used = True
        lblOutput.Text = lblOutput.Text & btnDivide.Text
        hasOperator = True
        operatorUsed = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
        Answer1 = 0
        Answer2 = 0
    End Sub
End Class
