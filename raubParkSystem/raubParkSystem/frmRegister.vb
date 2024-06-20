Public Class frmRegister
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load
        'frmLogin.Hide()
    End Sub
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Dim oForm As New frmLogin
        oForm.Show()
        Me.Hide()

    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

    End Sub

End Class