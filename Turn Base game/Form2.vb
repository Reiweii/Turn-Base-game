Public Class Form2


    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Form3.enemyDamageMin = 7
        Form3.enemyDamageMax = 15
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Form3.enemyDamageMin = 10
        Form3.enemyDamageMax = 20
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Form3.enemyDamageMin = 15
        Form3.enemyDamageMax = 25
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub


End Class