<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEasy
        '
        Me.btnEasy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEasy.Font = New System.Drawing.Font("Segoe Print", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEasy.Location = New System.Drawing.Point(202, 132)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(399, 90)
        Me.btnEasy.TabIndex = 0
        Me.btnEasy.Text = "EASY"
        Me.btnEasy.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMedium.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMedium.Font = New System.Drawing.Font("Segoe Print", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedium.Location = New System.Drawing.Point(202, 228)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(399, 90)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "MEDIUM"
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnHard
        '
        Me.btnHard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHard.BackColor = System.Drawing.Color.Red
        Me.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHard.Font = New System.Drawing.Font("Segoe Print", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHard.Location = New System.Drawing.Point(202, 324)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(399, 90)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "HARD"
        Me.btnHard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(715, 120)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CHOOSE DIFFICULTY:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.DarkGray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 51)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Turn_Base_game.My.Resources.Resources.volcano_background_z3ouk41h3zvw2vyg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEasy As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
