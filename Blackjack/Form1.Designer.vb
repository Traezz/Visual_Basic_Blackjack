<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blackjack
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
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.lblYourScore = New System.Windows.Forms.Label()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.picDealerCard1 = New System.Windows.Forms.PictureBox()
        Me.picDealerCard2 = New System.Windows.Forms.PictureBox()
        Me.picDealerCard3 = New System.Windows.Forms.PictureBox()
        Me.picDealerCard5 = New System.Windows.Forms.PictureBox()
        Me.picDealerCard4 = New System.Windows.Forms.PictureBox()
        Me.lblDealerScore = New System.Windows.Forms.Label()
        Me.btnWinLoss = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.radAceHigh = New System.Windows.Forms.RadioButton()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(155, 517)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(75, 23)
        Me.btnDeal.TabIndex = 0
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'picCard1
        '
        Me.picCard1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCard1.Location = New System.Drawing.Point(104, 391)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(65, 87)
        Me.picCard1.TabIndex = 2
        Me.picCard1.TabStop = False
        Me.picCard1.Visible = False
        '
        'picCard2
        '
        Me.picCard2.Location = New System.Drawing.Point(175, 391)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(65, 87)
        Me.picCard2.TabIndex = 3
        Me.picCard2.TabStop = False
        Me.picCard2.Visible = False
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(236, 517)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(75, 23)
        Me.btnHit.TabIndex = 4
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        Me.btnHit.Visible = False
        '
        'picCard3
        '
        Me.picCard3.Location = New System.Drawing.Point(246, 391)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(65, 87)
        Me.picCard3.TabIndex = 5
        Me.picCard3.TabStop = False
        Me.picCard3.Visible = False
        '
        'picCard4
        '
        Me.picCard4.Location = New System.Drawing.Point(317, 391)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(65, 87)
        Me.picCard4.TabIndex = 6
        Me.picCard4.TabStop = False
        Me.picCard4.Visible = False
        '
        'picCard5
        '
        Me.picCard5.Location = New System.Drawing.Point(388, 391)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(65, 87)
        Me.picCard5.TabIndex = 7
        Me.picCard5.TabStop = False
        Me.picCard5.Visible = False
        '
        'btnHold
        '
        Me.btnHold.Location = New System.Drawing.Point(317, 517)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(75, 23)
        Me.btnHold.TabIndex = 8
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = True
        Me.btnHold.Visible = False
        '
        'lblYourScore
        '
        Me.lblYourScore.Location = New System.Drawing.Point(459, 391)
        Me.lblYourScore.Name = "lblYourScore"
        Me.lblYourScore.Size = New System.Drawing.Size(89, 30)
        Me.lblYourScore.TabIndex = 9
        Me.lblYourScore.Text = "Your Score: "
        Me.lblYourScore.Visible = False
        '
        'picDeck
        '
        Me.picDeck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDeck.Image = Global.Blackjack.My.Resources.Resources.cardback
        Me.picDeck.Location = New System.Drawing.Point(15, 12)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(65, 87)
        Me.picDeck.TabIndex = 10
        Me.picDeck.TabStop = False
        '
        'picDealerCard1
        '
        Me.picDealerCard1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDealerCard1.Location = New System.Drawing.Point(104, 12)
        Me.picDealerCard1.Name = "picDealerCard1"
        Me.picDealerCard1.Size = New System.Drawing.Size(65, 87)
        Me.picDealerCard1.TabIndex = 11
        Me.picDealerCard1.TabStop = False
        Me.picDealerCard1.Visible = False
        '
        'picDealerCard2
        '
        Me.picDealerCard2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDealerCard2.Location = New System.Drawing.Point(175, 12)
        Me.picDealerCard2.Name = "picDealerCard2"
        Me.picDealerCard2.Size = New System.Drawing.Size(65, 87)
        Me.picDealerCard2.TabIndex = 12
        Me.picDealerCard2.TabStop = False
        Me.picDealerCard2.Visible = False
        '
        'picDealerCard3
        '
        Me.picDealerCard3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDealerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDealerCard3.Location = New System.Drawing.Point(246, 12)
        Me.picDealerCard3.Name = "picDealerCard3"
        Me.picDealerCard3.Size = New System.Drawing.Size(65, 87)
        Me.picDealerCard3.TabIndex = 13
        Me.picDealerCard3.TabStop = False
        Me.picDealerCard3.Visible = False
        '
        'picDealerCard5
        '
        Me.picDealerCard5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDealerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDealerCard5.Location = New System.Drawing.Point(388, 12)
        Me.picDealerCard5.Name = "picDealerCard5"
        Me.picDealerCard5.Size = New System.Drawing.Size(65, 87)
        Me.picDealerCard5.TabIndex = 14
        Me.picDealerCard5.TabStop = False
        Me.picDealerCard5.Visible = False
        '
        'picDealerCard4
        '
        Me.picDealerCard4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picDealerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDealerCard4.Location = New System.Drawing.Point(317, 12)
        Me.picDealerCard4.Name = "picDealerCard4"
        Me.picDealerCard4.Size = New System.Drawing.Size(65, 87)
        Me.picDealerCard4.TabIndex = 15
        Me.picDealerCard4.TabStop = False
        Me.picDealerCard4.Visible = False
        '
        'lblDealerScore
        '
        Me.lblDealerScore.Location = New System.Drawing.Point(459, 448)
        Me.lblDealerScore.Name = "lblDealerScore"
        Me.lblDealerScore.Size = New System.Drawing.Size(89, 30)
        Me.lblDealerScore.TabIndex = 16
        Me.lblDealerScore.Text = "Dealer Score:"
        Me.lblDealerScore.Visible = False
        '
        'btnWinLoss
        '
        Me.btnWinLoss.Location = New System.Drawing.Point(398, 517)
        Me.btnWinLoss.Name = "btnWinLoss"
        Me.btnWinLoss.Size = New System.Drawing.Size(100, 23)
        Me.btnWinLoss.TabIndex = 18
        Me.btnWinLoss.Text = "Show Win / Loss"
        Me.btnWinLoss.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(49, 517)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 23)
        Me.btnInfo.TabIndex = 21
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'radAceHigh
        '
        Me.radAceHigh.AutoSize = True
        Me.radAceHigh.Location = New System.Drawing.Point(8, 461)
        Me.radAceHigh.Name = "radAceHigh"
        Me.radAceHigh.Size = New System.Drawing.Size(74, 17)
        Me.radAceHigh.TabIndex = 22
        Me.radAceHigh.TabStop = True
        Me.radAceHigh.Text = "Aces High"
        Me.radAceHigh.UseVisualStyleBackColor = True
        '
        'Blackjack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blackjack.My.Resources.Resources.table
        Me.ClientSize = New System.Drawing.Size(551, 566)
        Me.Controls.Add(Me.radAceHigh)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnWinLoss)
        Me.Controls.Add(Me.lblDealerScore)
        Me.Controls.Add(Me.picDealerCard4)
        Me.Controls.Add(Me.picDealerCard5)
        Me.Controls.Add(Me.picDealerCard3)
        Me.Controls.Add(Me.picDealerCard2)
        Me.Controls.Add(Me.picDealerCard1)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.lblYourScore)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Controls.Add(Me.btnDeal)
        Me.Name = "Blackjack"
        Me.Text = "BlackJack"
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeal As System.Windows.Forms.Button
    Friend WithEvents picCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHit As System.Windows.Forms.Button
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents lblYourScore As System.Windows.Forms.Label
    Friend WithEvents picDeck As System.Windows.Forms.PictureBox
    Friend WithEvents picDealerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDealerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDealerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDealerCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents picDealerCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDealerScore As System.Windows.Forms.Label
    Friend WithEvents btnWinLoss As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents radAceHigh As System.Windows.Forms.RadioButton

End Class
