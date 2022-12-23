Imports System.IO
Public Class Blackjack

    'Dealer holds on 17+
    'Dealer wins on push

    'Call read to update score


    'Declare random number variable 
    Dim randomCardIndex As New Random()

    'Declare player card counter to increment
    Dim intPlayerCardCounter As Integer = 0
    Dim intDealerCardCounter As Integer = 1

    'Score counter for player and dealer
    Dim intPlayerScore As Integer = 0
    Dim intDealerScore As Integer = 0
    'Booleans for Score and 5 card charlie
    Dim ScoreFlag As Boolean
    Dim CharlieFlag As Boolean


    'Individual card variables
    Dim intPlayerCard1Value As Integer
    Dim intPlayerCard2Value As Integer
    Dim intPlayerCard3Value As Integer
    Dim intPlayerCard4Value As Integer
    Dim intPlayerCard5Value As Integer
    Dim intDealerCard1Value As Integer
    Dim intDealerCard2Value As Integer
    Dim intDealerCard3Value As Integer
    Dim intDealerCard4Value As Integer
    Dim intDealerCard5Value As Integer

    'Write / read variables 
    'Text file name
    Dim strFileBlackjack As String = "Blackjack.txt"
    'Text file info
    Dim strFileInfo As String = ""
    'Win, loss counters
    Dim intWinCounter As Integer
    Dim intLossCounter As Integer
    'Win Loss as string for printing
    Dim strWinLoss As String

    'Class scope array declarations
    'Declare imgCardImages as an array of images and intCardValue as array of scores
    Dim imgCardImages() As Image = {My.Resources.AceofClubs, My.Resources.AceofDiamonds, My.Resources.AceofHearts, My.Resources.AceofSpades, My.Resources.TwoofClubs, My.Resources.TwoofDiamonds, My.Resources.TwoofHearts, My.Resources.TwoofSpades, My.Resources.ThreeofClubs, My.Resources.ThreeofDiamonds, My.Resources.ThreeofHearts, My.Resources.ThreeofSpades, My.Resources.FourofClubs, My.Resources.FourofDiamonds, My.Resources.FourofHearts, My.Resources.FourofSpades, My.Resources.FiveofClubs, My.Resources.FiveofDiamonds, My.Resources.FiveofHearts, My.Resources.FiveofSpades, My.Resources.SixofClubs, My.Resources.SixofDiamonds, My.Resources.SixofHearts, My.Resources.SixofSpades, My.Resources.SevenofClubs, My.Resources.SevenofDiamonds, My.Resources.SevenofHearts, My.Resources.SevenofSpades, My.Resources.EightofClubs, My.Resources.EightofDiamonds, My.Resources.EightofHearts, My.Resources.EightofSpades, My.Resources.NineofClubs, My.Resources.NineofDiamonds, My.Resources.NineofHearts, My.Resources.NineofSpades, My.Resources.TenofClubs, My.Resources.TenofDiamonds, My.Resources.TenofHearts, My.Resources.TenofSpades, My.Resources.JackofClubs, My.Resources.JackofDiamonds, My.Resources.JackofHearts, My.Resources.JackofSpades, My.Resources.QueenofClubs, My.Resources.QueenofDiamonds, My.Resources.QueenofHearts, My.Resources.QueenofSpades, My.Resources.KingofClubs, My.Resources.KingofDiamonds, My.Resources.KingofHearts, My.Resources.KingofSpades}
    Dim intCardValue As Array = {1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10}

    'Function to create random number between 1-52 (0 and 51)
    Function RandomCard()
        'Array length variables for deck size
        Dim intMaxCard As Integer = 51
        Dim intMinCard As Integer = 0
        'Random number variable
        Dim intCardNumber As Integer
        'random card number is equal to random card index position, which is a number between 0 and 51.
        intCardNumber = randomCardIndex.Next(intMinCard, intMaxCard)

        'Return random card number when function is called
        Return intCardNumber
    End Function


    'Bust procedure
    Sub Bust()
        'Show messagebox to indicate bust
        MessageBox.Show("BUST!")
        'Show deal button
        btnDeal.Visible = True
        'Hide button hit
        btnHit.Visible = False
        'Hide button hold 
        btnHold.Visible = False
        'Increment loss counter
        intLossCounter += 1
    End Sub

    Sub DealerPlay()
        'Hide deal button
        btnDeal.Visible = False
        'Show dealer score
        lblDealerScore.Visible = True

        'If dealer cards less than 5 then

        'if dealer cards = 1 and dealer score < 17 and dealerscore <= 21 and playerscore > dealerscore
        If intDealerCardCounter = 1 And intDealerScore < 17 And intDealerScore <= 21 And intPlayerScore > intDealerScore Then
            'Show dealer card 1
            picDealerCard1.Visible = True
            'Set dealer card 1 to random card
            picDealerCard1.Image = imgCardImages(intDealerCard1Value)
            'increment dealer score by card value of card 1
            intDealerScore += intCardValue(intDealerCard1Value)
            'increment dealer card counter
            intDealerCardCounter += 1
            'update score
            UpdateScore()

            'If dealer cards = 2
        ElseIf intDealerCardCounter = 2 Then
            'Show dealer card 2
            picDealerCard2.Visible = True
            'Set dealer card 2 to random card
            picDealerCard2.Image = imgCardImages(intDealerCard2Value)
            'increment dealer score
            intDealerScore += intCardValue(intDealerCard2Value)
            'Increment dealer card counter
            intDealerCardCounter += 1
            'Increment dealer card counter
            UpdateScore()


            'If dealer cards = 3 and dealer score < 17 
        ElseIf intDealerCardCounter = 3 And intDealerScore < 17 Then
            'Show dealer card 3
            picDealerCard3.Visible = True
            'Set dealer card 3 to random card
            picDealerCard3.Image = imgCardImages(intDealerCard3Value)
            'Increment dealer score
            intDealerScore += intCardValue(intDealerCard3Value)
            'Increment dealer card counter
            intDealerCardCounter += 1
            'Update score
            UpdateScore()


        ElseIf intDealerCardCounter = 4 And intDealerScore < 17 Then
            'Show dealer card 4 
            picDealerCard4.Visible = True
            'Set dealer card 4 to random card
            picDealerCard4.Image = imgCardImages(intDealerCard4Value)
            'Increment dealer score
            intDealerScore += intCardValue(intDealerCard4Value)
            'Increment dealer card counter
            intDealerCardCounter += 1
            'Update score
            UpdateScore()

        ElseIf intDealerCardCounter = 5 And intDealerScore < 17 Then
            'Show dealer card 4 
            picDealerCard5.Visible = True
            'Set dealer card 4 to random card
            picDealerCard5.Image = imgCardImages(intDealerCard5Value)
            'Increment dealer score
            intDealerScore += intCardValue(intDealerCard5Value)
            'Increment dealer card counter
            'Update score
            UpdateScore()
        End If

    End Sub

    'Sub for 5 card Charlie
    Sub Charlie()
        'Show messagebox displaying charlie win
        MessageBox.Show("Five Card Charlie! You win!")
        'Set charlie flag to true
        CharlieFlag = True
        'Increment win counter by 1
        intWinCounter += 1
        'save info to file
        Write()
        'Show ace high rad button and uncheck
        radAceHigh.Visible = True
        radAceHigh.Checked = False
        'Show deal button
        btnDeal.Visible = True
        'Hide hold button
        btnHold.Visible = False

    End Sub

    'Hide card images procedure
    Sub HideCards()
        picCard1.Visible = False
        picCard2.Visible = False
        picCard3.Visible = False
        picCard4.Visible = False
        picCard5.Visible = False
        picDealerCard1.Visible = False
        picDealerCard2.Visible = False
        picDealerCard3.Visible = False
        picDealerCard4.Visible = False
        picDealerCard5.Visible = False
    End Sub

    'Procedure to read file with messagebox of record
    Sub Read()
        'Declare fileReader variable
        Dim fileReader As StreamReader
        'Try block
        Try
            'Open file
            fileReader = File.OpenText(strFileBlackjack)
            'declare string to store info from blackjack.txt
            Dim strLine As String = "Record from session " & vbCrLf
            'loop to read file one line at a time
            Do Until fileReader.EndOfStream()
                'Save lines in file to strLine
                strLine &= fileReader.ReadLine() & vbCrLf
                'End loop
            Loop
            'Close file
            fileReader.Close()
            'Show messagebox with win/loss record
            MessageBox.Show(strLine)
        Catch ex As Exception
        End Try
    End Sub

    Sub ReadStart()
        'Declare fileReader variable
        Dim fileReader As StreamReader
        'Try block
        Try
            'Open file
            fileReader = File.OpenText(strFileBlackjack)
            'declare string to store info from blackjack.txt
            Dim strLine As String = "Win loss Record: " & vbCrLf
            'loop to read file one line at a time
            Do Until fileReader.EndOfStream()
                'Save lines in file to strLine
                strLine &= fileReader.ReadLine() & vbCrLf
                'End loop
            Loop
            'Close file
            fileReader.Close()
            'Show messagebox with win/loss record
        Catch ex As Exception
        End Try

    End Sub


    'Reset procedure
    Sub ResetTable()
        'Set score flag to false
        ScoreFlag = False
        'Set charlie flag to false
        CharlieFlag = False
        'Set dealer score to 0
        intDealerScore = 0
        'Set player score to 0
        intPlayerScore = 0
        'Set dealer card counter to 0 -- Actually 1.
        intDealerCardCounter = 1
        'Set player card counter to 0
        intPlayerCardCounter = 0
    End Sub

    'Procedure to shuffle deck. Reassign random values to the cards. Call during "Deal"
    Sub Shuffle()
        intPlayerCard1Value = RandomCard()
        intPlayerCard2Value = RandomCard()
        intPlayerCard3Value = RandomCard()
        intPlayerCard4Value = RandomCard()
        intPlayerCard5Value = RandomCard()
        intDealerCard1Value = RandomCard()
        intDealerCard2Value = RandomCard()
        intDealerCard3Value = RandomCard()
        intDealerCard4Value = RandomCard()
        intDealerCard5Value = RandomCard()
    End Sub

    'Score update procedure
    Sub UpdateScore()
        'Declare player and dealer scores as string
        Dim strPlayerScore As String
        Dim strDealerScore As String
        'Format player score string 
        strPlayerScore = "Your score: " & intPlayerScore
        'set player score label to player score
        lblYourScore.Text = strPlayerScore
        'Format dealer score string
        strDealerScore = "Dealer score: " & intDealerScore
        'set dealer score label to dealer score
        lblDealerScore.Text = strDealerScore

    End Sub

    'Procedure to write to file
    Sub Write()
        'Set file info strings
        strFileInfo = "Blackjack Wins: " & intWinCounter & vbCrLf
        strFileInfo &= "Blackjack Losses: " & intLossCounter
        'Declare file writer as streamWriter
        Dim fileWriter As StreamWriter
        Try
            'Open file
            fileWriter = File.CreateText(strFileBlackjack)
            'Write to file
            fileWriter.WriteLine(strFileInfo)
            'Close file
            fileWriter.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Deal button 
    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        'Hide Ace High rad button
        radAceHigh.Visible = False
        'Hide all cards
        ResetTable()
        'Reset table
        HideCards()
        'Shuffle deck
        Shuffle()
        'Show card 1
        picCard1.Visible = True
        'Set card 1 to random card
        picCard1.Image = imgCardImages(intPlayerCard1Value)
        'Increment player score by card value
        intPlayerScore += intCardValue(intPlayerCard1Value)
        'update score
        UpdateScore()
        'set player card counter to 1
        intPlayerCardCounter = 1
        'if player card counter = 1
        If intPlayerCardCounter = 1 Then
            'Show button deal
            btnDeal.Visible = False
            'Show player score
            lblYourScore.Visible = True
        End If
        'if player card counter is > 1 
        If intPlayerCardCounter >= 1 Then
            'Show hit button
            btnHit.Visible = True
            'Show hold button
            btnHold.Visible = True
        End If

    End Sub

    'button for hit
    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        'if player score > 21 then call Bust
        If intPlayerScore > 21 Then
            Bust()
            'if player cards >= 5 and player score <= 21 then 5 card charlie (Win)
        ElseIf intPlayerCardCounter = 5 And intPlayerScore <= 21 Then
            Charlie()
        End If

        'if player cards = 1
        If intPlayerCardCounter = 1 Then
            'show player card 2
            picCard2.Visible = True
            'Set card 2 to random card
            picCard2.Image = imgCardImages(intPlayerCard2Value)
            'Increment player score by card value
            intPlayerScore += intCardValue(intPlayerCard2Value)
            'Increment player card counter
            intPlayerCardCounter += 1
            'Update score
            UpdateScore()

            'ElseIf player cards = 2 and player score <= 21 
        ElseIf intPlayerCardCounter = 2 And intPlayerScore <= 21 Then
            'Show card 3
            picCard3.Visible = True
            'Set card 3 to random card
            picCard3.Image = imgCardImages(intPlayerCard3Value)
            'Increment player score by card value
            intPlayerScore += intCardValue(intPlayerCard3Value)
            'Update score
            UpdateScore()
            'Increment player card counter by 1
            intPlayerCardCounter += 1

            'ElseIf player card counter = 3 and intplayerScore <= 21
        ElseIf intPlayerCardCounter = 3 And intPlayerScore <= 21 Then
            'Show card 4
            picCard4.Visible = True
            'Set card 4 to random card
            picCard4.Image = imgCardImages(intPlayerCard4Value)
            'Increment player score by card value
            intPlayerScore += intCardValue(intPlayerCard4Value)
            'Increment player card counter by 1
            intPlayerCardCounter += 1
            'Update score
            UpdateScore()

            'ElseIF player Card counter = 4 and intPlayerScore <= 21
        ElseIf intPlayerCardCounter = 4 And intPlayerScore <= 21 Then
            'Show card 5
            picCard5.Visible = True
            'Set card 5 to random card
            picCard5.Image = imgCardImages(intPlayerCard5Value)
            'Increment card score by card value
            intPlayerScore += intCardValue(intPlayerCard5Value)
            'Increment player card counter by 1
            intPlayerCardCounter += 1
            'Update score
            UpdateScore()
        End If
    End Sub

    'Button for hold
    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        'Hide button hit
        btnHit.Visible = False
        'Hide button hold
        btnHold.Visible = False
        'if player score > 21 then call Bust
        If intPlayerScore > 21 Then
            Bust()
            'Write to file
            Write()
            'Show ace high rad button and uncheck
            radAceHigh.Visible = True
            radAceHigh.Checked = False
            'Else
        ElseIf intPlayerCardCounter = 5 And intPlayerScore <= 21 Then
            Charlie()

        Else
            'if Score flag boolean = false and Charlie flag = false then
            If ScoreFlag = False And CharlieFlag = False Then
                'if dealer card counter < 5 
                'For loop for dealer to play 5 times
                For Index As Integer = 1 To 5
                    DealerPlay()
                Next
                'if player score = dealer score and dealer score <= 21
                If intPlayerScore = intDealerScore And intDealerScore <= 21 Then
                    'Messagebox push goes to dealer
                    MessageBox.Show("Push goes to the house!")
                    'Set scoreFlag to true
                    ScoreFlag = True
                    'Show button deal
                    btnDeal.Visible = True
                    'Increment loss counter by 1
                    intLossCounter += 1
                    'Write to file
                    Write()
                    'Show ace high rad button and uncheck
                    radAceHigh.Visible = True
                    radAceHigh.Checked = False

                    'ElseIf player score > dealer score and dealer score <= 21
                ElseIf intPlayerScore < intDealerScore And intDealerScore <= 21 Then
                    'Messagebox house wins
                    MessageBox.Show("House wins!")
                    'Score flag = true
                    ScoreFlag = True
                    'Show button deal
                    btnDeal.Visible = True
                    'Increment loss counter
                    intLossCounter += 1
                    'Save to file
                    Write()
                    'Show ace high rad button and uncheck
                    radAceHigh.Visible = True
                    radAceHigh.Checked = False

                    'Elseif player score > dealer score or dealer score > 21 then
                ElseIf intPlayerScore > intDealerScore Or intDealerScore > 21 Then
                    'Player wins - messagebox
                    MessageBox.Show("You win!")
                    'Score flag = true
                    ScoreFlag = True
                    'Show button deal
                    btnDeal.Visible = True
                    'Increment win counter by 1
                    intWinCounter += 1
                    'Save to file
                    Write()
                    'Show ace high rad button and uncheck
                    radAceHigh.Visible = True
                    radAceHigh.Checked = False
                End If
            End If
        End If
    End Sub

    'Win loss button for win/loss record for this session
    Private Sub btnWinLoss_Click(sender As Object, e As EventArgs) Handles btnWinLoss.Click
        'Call Read()
        Read()
    End Sub

    'Info button
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        'Messagebox with welcome and info about Ace High button
        MessageBox.Show("Welcome to EZ Blackjack. The ace high button changes the value of Aces from 1 to 11! This can only be changed between hands, and will be reset for the next hand!")
    End Sub

    'Ace high radio button
    Private Sub radAceHigh_CheckedChanged(sender As Object, e As EventArgs) Handles radAceHigh.CheckedChanged
        'if ace high button is checked, then switch the ace positions in value array to 11
        If radAceHigh.Checked Then
            intCardValue(1) = 11
            intCardValue(3) = 11
            intCardValue(5) = 11
            intCardValue(7) = 11
            'Else set to default of 1 (Do I need to do this? Experiment!)
        Else
            intCardValue(1) = 1
            intCardValue(3) = 1
            intCardValue(5) = 1
            intCardValue(7) = 1
        End If
    End Sub

    'Loader
    Private Sub Blackjack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ReadStart call to load previous scores
        ReadStart()
    End Sub
End Class


