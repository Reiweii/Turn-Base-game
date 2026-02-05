Public Class Form3

    '===========================
    ' ENEMY DAMAGE SETTINGS (SET FROM DIFFICULTY)
    '===========================
    Public enemyDamageMin As Integer
    Public enemyDamageMax As Integer

    Dim playerHP As Integer
    Dim enemyHP As Integer
    Dim playerTurn As Boolean
    Dim rng As New Random() ' Random generator ng numbers 

    '===========================
    ' FORM LOAD - START BATTLE AUTOMATICALLY
    '===========================
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartBattle()
    End Sub

    '===========================
    ' START BATTLE METHOD
    '===========================
    Sub StartBattle()
        playerHP = 100
        enemyHP = 100
        playerTurn = True
        lblTurn.Text = "Your Turn!"

        prgPlayerHP.Value = 100
        prgEnemyHP.Value = 100

        btnAttack.Enabled = True
        btnSpecial.Enabled = True
        btnHeal.Enabled = True

        UpdateHP()
    End Sub

    '===========================
    ' UPDATE HP & PROGRESS BARS
    '===========================
    Sub UpdateHP()
        If playerHP < 0 Then playerHP = 0
        If enemyHP < 0 Then enemyHP = 0
        If playerHP > 100 Then playerHP = 100

        lblPlayerHp.Text = "Player HP: " & playerHP
        lblEnemyHP.Text = "Enemy HP: " & enemyHP

        prgPlayerHP.Value = playerHP
        prgEnemyHP.Value = enemyHP
    End Sub

    '===========================
    ' PLAYER ATTACK BUTTON
    '===========================
    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If Not playerTurn Then Exit Sub

        ' Calculate damage
        Dim damage As Integer = rng.Next(5, 16)
        enemyHP -= damage

        ' ⭐ Show player damage in label
        lblTurn.Text = "You attacked and dealt " & damage & " damage to the enemy!"

        UpdateHP() ' Update HP bars immediately so player sees change

        ' ⭐ Pause lang saglit para makita yung dama
        Application.DoEvents()
        Threading.Thread.Sleep(700)

        playerTurn = False
        CheckWinner()

        If enemyHP > 0 Then EnemyTurn()
    End Sub

    '===========================
    ' PLAYER SPECIAL ATTACK
    '===========================
    Private Sub btnSpecial_Click(sender As Object, e As EventArgs) Handles btnSpecial.Click
        If Not playerTurn Then Exit Sub

        ' Calculate special damage
        Dim damage As Integer = rng.Next(10, 31)
        enemyHP -= damage

        ' ⭐ Show special attack damage
        lblTurn.Text = "SPECIAL ATTACK! You dealt " & damage & " damage to the enemy!"

        UpdateHP()
        Application.DoEvents()
        Threading.Thread.Sleep(700) ' Pause so message is visible

        playerTurn = False
        CheckWinner()

        If enemyHP > 0 Then EnemyTurn()
    End Sub

    '===========================
    ' PLAYER HEAL BUTTON
    '===========================
    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        If Not playerTurn Then Exit Sub

        ' Calculate heal amount
        Dim healAmount As Integer = rng.Next(5, 21)
        playerHP += healAmount
        If playerHP > 100 Then playerHP = 100

        ' ⭐ Show how much player healed
        lblTurn.Text = "You healed " & healAmount & " HP!"

        UpdateHP()
        Application.DoEvents()
        Threading.Thread.Sleep(700)

        playerTurn = False
        EnemyTurn()
    End Sub

    '===========================
    ' ENEMY TURN
    '===========================
    Sub EnemyTurn()
        lblTurn.Text = "Enemy's Turn..."
        Application.DoEvents()
        Threading.Thread.Sleep(800)

        ' Random choice: 30% heal, 70% attack
        Dim actionChoice As Integer = rng.Next(1, 101) ' 1–100

        If actionChoice <= 30 And enemyHP > 20 Then
            ' ⭐ Enemy heals
            Dim healAmount As Integer = rng.Next(5, 16)
            enemyHP += healAmount
            If enemyHP > 100 Then enemyHP = 100

            lblTurn.Text = "Enemy healed " & healAmount & " HP!"
        Else
            ' ⭐ Enemy attacks
            Dim damage As Integer = rng.Next(enemyDamageMin, enemyDamageMax + 1)
            playerHP -= damage

            ' ⭐ Show exact damage enemy dealt
            lblTurn.Text = "Enemy attacked and dealt " & damage & " damage to you!"
        End If

        UpdateHP()
        Application.DoEvents()
        Threading.Thread.Sleep(700) ' Pang pause lang saglit para makita lang ng ilang seconds yung sa label

        CheckWinner()
        playerTurn = True
    End Sub

    '===========================
    ' CHECK WINNER
    '===========================
    Sub CheckWinner()
        If playerHP <= 0 Then
            lblTurn.Text = "You Lost!"
            DisableButtons()
        ElseIf enemyHP <= 0 Then
            lblTurn.Text = "You Won!"
            DisableButtons()
        End If
    End Sub

    '===========================
    ' DISABLE BUTTONS KAPAG NANALO or NATALO
    '===========================
    Sub DisableButtons()
        btnAttack.Enabled = False
        btnSpecial.Enabled = False
        btnHeal.Enabled = False
    End Sub

    '===========================
    ' BALIK SA MENU
    '===========================
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub


End Class
