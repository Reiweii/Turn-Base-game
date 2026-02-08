<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.btnSpecial = New System.Windows.Forms.Button()
        Me.btnHeal = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.prgPlayerHP = New System.Windows.Forms.ProgressBar()
        Me.prgEnemyHP = New System.Windows.Forms.ProgressBar()
        Me.lblPlayerHP = New System.Windows.Forms.Label()
        Me.lblEnemyHP = New System.Windows.Forms.Label()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblCooldown = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Turn_Base_game.My.Resources.Resources.aaronmainchar
        Me.PictureBox1.Location = New System.Drawing.Point(88, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 498)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Turn_Base_game.My.Resources.Resources.abe
        Me.PictureBox2.Location = New System.Drawing.Point(1375, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(464, 498)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnAttack
        '
        Me.btnAttack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAttack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAttack.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.Location = New System.Drawing.Point(726, 977)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(152, 86)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = False
        '
        'btnSpecial
        '
        Me.btnSpecial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSpecial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpecial.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecial.Location = New System.Drawing.Point(1016, 977)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(152, 86)
        Me.btnSpecial.TabIndex = 3
        Me.btnSpecial.Text = "Special"
        Me.btnSpecial.UseVisualStyleBackColor = False
        '
        'btnHeal
        '
        Me.btnHeal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnHeal.BackColor = System.Drawing.Color.Lime
        Me.btnHeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHeal.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeal.Location = New System.Drawing.Point(1307, 977)
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(152, 86)
        Me.btnHeal.TabIndex = 4
        Me.btnHeal.Text = "Heal"
        Me.btnHeal.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.DarkGray
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(1837, 1048)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(93, 42)
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'prgPlayerHP
        '
        Me.prgPlayerHP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.prgPlayerHP.Location = New System.Drawing.Point(88, 170)
        Me.prgPlayerHP.Name = "prgPlayerHP"
        Me.prgPlayerHP.Size = New System.Drawing.Size(464, 40)
        Me.prgPlayerHP.TabIndex = 6
        Me.prgPlayerHP.Value = 100
        '
        'prgEnemyHP
        '
        Me.prgEnemyHP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.prgEnemyHP.Location = New System.Drawing.Point(1375, 179)
        Me.prgEnemyHP.Name = "prgEnemyHP"
        Me.prgEnemyHP.Size = New System.Drawing.Size(464, 40)
        Me.prgEnemyHP.TabIndex = 7
        Me.prgEnemyHP.Value = 100
        '
        'lblPlayerHP
        '
        Me.lblPlayerHP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPlayerHP.AutoSize = True
        Me.lblPlayerHP.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerHP.Font = New System.Drawing.Font("Calisto MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerHP.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblPlayerHP.Location = New System.Drawing.Point(84, 121)
        Me.lblPlayerHP.Name = "lblPlayerHP"
        Me.lblPlayerHP.Size = New System.Drawing.Size(284, 46)
        Me.lblPlayerHP.TabIndex = 8
        Me.lblPlayerHP.Text = "Player HP: 100"
        '
        'lblEnemyHP
        '
        Me.lblEnemyHP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEnemyHP.AutoSize = True
        Me.lblEnemyHP.BackColor = System.Drawing.Color.Transparent
        Me.lblEnemyHP.Font = New System.Drawing.Font("Calisto MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyHP.ForeColor = System.Drawing.Color.Red
        Me.lblEnemyHP.Location = New System.Drawing.Point(1370, 121)
        Me.lblEnemyHP.Name = "lblEnemyHP"
        Me.lblEnemyHP.Size = New System.Drawing.Size(295, 46)
        Me.lblEnemyHP.TabIndex = 9
        Me.lblEnemyHP.Text = "Enemy HP: 100"
        '
        'lblTurn
        '
        Me.lblTurn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTurn.BackColor = System.Drawing.Color.Transparent
        Me.lblTurn.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.ForeColor = System.Drawing.Color.LightYellow
        Me.lblTurn.Location = New System.Drawing.Point(550, 0)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(812, 109)
        Me.lblTurn.TabIndex = 10
        Me.lblTurn.Text = "START!!!"
        Me.lblTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(248, 717)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 48)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Aaron"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(1451, 726)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 48)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ABE THE DESTROYER"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Turn_Base_game.My.Resources.Resources.Sword_icon
        Me.PictureBox3.Location = New System.Drawing.Point(603, 977)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 86)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Turn_Base_game.My.Resources.Resources.Special_icon
        Me.PictureBox4.Location = New System.Drawing.Point(901, 977)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(109, 86)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.Turn_Base_game.My.Resources.Resources.Heal_icon
        Me.PictureBox5.Location = New System.Drawing.Point(1192, 977)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(109, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'lblCooldown
        '
        Me.lblCooldown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCooldown.AutoSize = True
        Me.lblCooldown.BackColor = System.Drawing.Color.Transparent
        Me.lblCooldown.Font = New System.Drawing.Font("Impact", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCooldown.ForeColor = System.Drawing.Color.LightYellow
        Me.lblCooldown.Location = New System.Drawing.Point(892, 813)
        Me.lblCooldown.Name = "lblCooldown"
        Me.lblCooldown.Size = New System.Drawing.Size(50, 54)
        Me.lblCooldown.TabIndex = 16
        Me.lblCooldown.Text = "..."
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Turn_Base_game.My.Resources.Resources.stunning_lava_volcano_backdrop_perfect_fantasy_themed_projects_visuals_894067_53712
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.Controls.Add(Me.lblCooldown)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.lblEnemyHP)
        Me.Controls.Add(Me.lblPlayerHP)
        Me.Controls.Add(Me.prgEnemyHP)
        Me.Controls.Add(Me.prgPlayerHP)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnHeal)
        Me.Controls.Add(Me.btnSpecial)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAttack As Button
    Friend WithEvents btnSpecial As Button
    Friend WithEvents btnHeal As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents prgPlayerHP As ProgressBar
    Friend WithEvents prgEnemyHP As ProgressBar
    Friend WithEvents lblPlayerHP As Label
    Friend WithEvents lblEnemyHP As Label
    Friend WithEvents lblTurn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblCooldown As Label
End Class
