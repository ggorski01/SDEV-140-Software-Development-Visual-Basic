Public Class HelloUser

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles IblName.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Display  a message box greeting to the user 
        MessageBox.Show("Hello, " & txtName.Text & _
        "! Welcome to Visual Basic 2012.", _
        "Hello User Message")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'End the program  and close the form 
        Me.Close()
    End Sub
End Class
