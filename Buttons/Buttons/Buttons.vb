Public Class Buttons

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNumA As Integer
        Dim intNumB As Integer
        intNumA = 27
        intNumB = 55
        MessageBox.Show("The sum of the two numbers is: " & intNumA + intNumB.ToString, _
           "Giovanna Monteiro")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnString.Click
        Dim StrA As String
        Dim StrB As String
        StrA = "Hello"
        StrB = "World!"
        MessageBox.Show("The two strings concatenated are: " & StrA + " " + StrB.ToString, _
                        "Giovanna Monteiro")
    End Sub
End Class
