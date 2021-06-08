Public Class frmHome
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        frmCategoryModule.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenuModule.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
