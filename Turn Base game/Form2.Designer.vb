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
        Me.btnEasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEasy.Location = New System.Drawing.Point(335, 173)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(112, 52)
        Me.btnEasy.TabIndex = 0
        Me.btnEasy.Text = "EASY"
        Me.btnEasy.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMedium.Location = New System.Drawing.Point(335, 243)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(112, 52)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "MEDIUM"
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnHard
        '
        Me.btnHard.BackColor = System.Drawing.Color.Red
        Me.btnHard.Location = New System.Drawing.Point(335, 316)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(112, 52)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "HARD"
        Me.btnHard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CHOOSE DIFFICULTY:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 411)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 27)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Turn_Base_game.My.Resources.Resources.volcano_background_z3ouk41h3zvw2vyg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnEasy)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEasy As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
