Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'frmRegister.Hide()
    End Sub
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Dim oForm As New frmRegister
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

End Class