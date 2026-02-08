Public Class Form3

    Public enemyDamageMin As Integer
    Public enemyDamageMax As Integer

    Dim playerHP As Integer
    Dim enemyHP As Integer
    Dim playerTurn As Boolean
    Dim rng As New Random()

    Dim specialCooldown As Integer = 0
    Dim healCooldown As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartBattle()
    End Sub

    Sub StartBattle()
        playerHP = 100
        enemyHP = 100
        playerTurn = True

        specialCooldown = 0
        healCooldown = 0

        lblTurn.Text = "Your Turn!"
        lblCooldown.Text = ""

        prgPlayerHP.Value = 100
        prgEnemyHP.Value = 100

        btnAttack.Enabled = True
        btnSpecial.Enabled = True
        btnHeal.Enabled = True

        UpdateHP()
        UpdateCooldownLabel()
    End Sub

    Sub UpdateHP()
        If playerHP < 0 Then playerHP = 0
        If enemyHP < 0 Then enemyHP = 0
        If playerHP > 100 Then playerHP = 100

        lblPlayerHP.Text = "Player HP: " & playerHP
        lblEnemyHP.Text = "Enemy HP: " & enemyHP

        prgPlayerHP.Value = playerHP
        prgEnemyHP.Value = enemyHP
    End Sub

    Sub UpdateCooldownLabel()
        lblCooldown.Text = ""

        If specialCooldown > 0 Then
            lblCooldown.Text &= "Special: " & specialCooldown & " turn(s) left" & vbNewLine
        End If

        If healCooldown > 0 Then
            lblCooldown.Text &= "Heal: " & healCooldown & " turn(s) left"
        End If
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If Not playerTurn Then Exit Sub

        Dim damage As Integer = rng.Next(5, 16)
        enemyHP -= damage

        lblTurn.Text = "You attacked and dealt " & damage & " damage!"

        UpdateHP()
        Application.DoEvents()
        Threading.Thread.Sleep(700)

        playerTurn = False

        If CheckWinner() Then Exit Sub
        EnemyTurn()
    End Sub

    Private Sub btnSpecial_Click(sender As Object, e As EventArgs) Handles btnSpecial.Click
        If Not playerTurn Then Exit Sub
        If specialCooldown > 0 Then Exit Sub

        Dim damage As Integer = rng.Next(10, 31)
        enemyHP -= damage

        lblTurn.Text = "SPECIAL ATTACK! You dealt " & damage & " damage!"

        specialCooldown = 2
        btnSpecial.Enabled = False

        UpdateHP()
        UpdateCooldownLabel()

        Application.DoEvents()
        Threading.Thread.Sleep(700)

        playerTurn = False

        If CheckWinner() Then Exit Sub
        EnemyTurn()
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        If Not playerTurn Then Exit Sub
        If healCooldown > 0 Then Exit Sub

        Dim healAmount As Integer = rng.Next(5, 21)
        playerHP += healAmount
        If playerHP > 100 Then playerHP = 100

        lblTurn.Text = "You healed " & healAmount & " HP!"

        healCooldown = 3
        btnHeal.Enabled = False

        UpdateHP()
        UpdateCooldownLabel()

        Application.DoEvents()
        Threading.Thread.Sleep(700)

        playerTurn = False

        EnemyTurn()
    End Sub

    Sub EnemyTurn()
        lblTurn.Text = "Enemy's Turn..."
        Application.DoEvents()
        Threading.Thread.Sleep(800)

        Dim actionChoice As Integer = rng.Next(1, 101)

        If actionChoice <= 30 And enemyHP > 20 Then
            Dim healAmount As Integer = rng.Next(5, 16)
            enemyHP += healAmount
            If enemyHP > 100 Then enemyHP = 100

            lblTurn.Text = "Enemy healed " & healAmount & " HP!"
        Else
            Dim damage As Integer = rng.Next(enemyDamageMin, enemyDamageMax + 1)
            playerHP -= damage

            lblTurn.Text = "Enemy attacked and dealt " & damage & " damage!"
        End If

        UpdateHP()

        If specialCooldown > 0 Then
            specialCooldown -= 1
            If specialCooldown = 0 Then btnSpecial.Enabled = True
        End If

        If healCooldown > 0 Then
            healCooldown -= 1
            If healCooldown = 0 Then btnHeal.Enabled = True
        End If

        UpdateCooldownLabel()

        Application.DoEvents()
        Threading.Thread.Sleep(700)

        If CheckWinner() Then Exit Sub

        playerTurn = True
        lblTurn.Text = "Your Turn!"
    End Sub

    Function CheckWinner() As Boolean
        If playerHP <= 0 Then
            lblTurn.Text = "You Lost!"
            DisableButtons()
            Return True
        ElseIf enemyHP <= 0 Then
            lblTurn.Text = "You Won!"
            DisableButtons()
            Return True
        End If
        Return False
    End Function

    Sub DisableButtons()
        btnAttack.Enabled = False
        btnSpecial.Enabled = False
        btnHeal.Enabled = False
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class
