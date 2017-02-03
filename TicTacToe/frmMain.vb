' Class: DWD255 Intermediate Programming with Visual Basic
' Author: Danielle Yontz
' Summer 2016
' Project: Final Class Project
' September 8, 2016

Public Class frmMain
    Dim thePlayer As Integer = 1
    Dim theBoard(2, 2) As Integer

    'begin button initiates gameplay...
    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        For row As Integer = 0 To 2
            For col As Integer = 0 To 2
                theBoard(row, col) = 0
            Next col
        Next row

        btnOne.BackColor = SystemColors.Control
        btnOne.Text = ""
        btnOne.Enabled = True
        btnTwo.BackColor = SystemColors.Control
        btnTwo.Text = ""
        btnTwo.Enabled = True
        btnThree.BackColor = SystemColors.Control
        btnThree.Text = ""
        btnThree.Enabled = True
        btnFour.BackColor = SystemColors.Control
        btnFour.Text = ""
        btnFour.Enabled = True
        btnFive.BackColor = SystemColors.Control
        btnFive.Text = ""
        btnFive.Enabled = True
        btnSix.BackColor = SystemColors.Control
        btnSix.Text = ""
        btnSix.Enabled = True
        btnSeven.BackColor = SystemColors.Control
        btnSeven.Text = ""
        btnSeven.Enabled = True
        btnEight.BackColor = SystemColors.Control
        btnEight.Text = ""
        btnEight.Enabled = True
        btnNine.BackColor = SystemColors.Control
        btnNine.Text = ""
        btnNine.Enabled = True

        thePlayer = 1
        lblDirections.Text = "Player 1 GO!"

    End Sub

    'gives each player a X and an O for each square they click
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If (thePlayer = 1) Then
            btnOne.Text = "X"
            btnOne.BackColor = Color.LightSeaGreen
        Else
            btnOne.Text = "O"
            btnOne.BackColor = Color.Coral
        End If
        theBoard(0, 0) = thePlayer
        btnOne.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If (thePlayer = 1) Then
            btnTwo.Text = "X"
            btnTwo.BackColor = Color.LightSeaGreen
        Else
            btnTwo.Text = "O"
            btnTwo.BackColor = Color.Coral
        End If
        theBoard(0, 1) = thePlayer
        btnTwo.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If (thePlayer = 1) Then
            btnThree.Text = "X"
            btnThree.BackColor = Color.LightSeaGreen
        Else
            btnThree.Text = "O"
            btnThree.BackColor = Color.Coral
        End If
        theBoard(0, 2) = thePlayer
        btnThree.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If (thePlayer = 1) Then
            btnFour.Text = "X"
            btnFour.BackColor = Color.LightSeaGreen
        Else
            btnFour.Text = "O"
            btnFour.BackColor = Color.Coral
        End If
        theBoard(1, 0) = thePlayer
        btnFour.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If (thePlayer = 1) Then
            btnFive.Text = "X"
            btnFive.BackColor = Color.LightSeaGreen
        Else
            btnFive.Text = "O"
            btnFive.BackColor = Color.Coral
        End If
        theBoard(1, 1) = thePlayer
        btnFive.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If (thePlayer = 1) Then
            btnSix.Text = "X"
            btnSix.BackColor = Color.LightSeaGreen
        Else
            btnSix.Text = "O"
            btnSix.BackColor = Color.Coral
        End If
        theBoard(1, 2) = thePlayer
        btnSix.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If (thePlayer = 1) Then
            btnSeven.Text = "X"
            btnSeven.BackColor = Color.LightSeaGreen
        Else
            btnSeven.Text = "O"
            btnSeven.BackColor = Color.Coral
        End If
        theBoard(2, 0) = thePlayer
        btnSeven.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If (thePlayer = 1) Then
            btnEight.Text = "X"
            btnEight.BackColor = Color.LightSeaGreen
        Else
            btnEight.Text = "O"
            btnEight.BackColor = Color.Coral
        End If
        theBoard(2, 1) = thePlayer
        btnEight.Enabled = True
        EvaluateGame()
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If (thePlayer = 1) Then
            btnNine.Text = "X"
            btnNine.BackColor = Color.LightSeaGreen
        Else
            btnNine.Text = "O"
            btnNine.BackColor = Color.Coral
        End If
        theBoard(2, 2) = thePlayer
        btnNine.Enabled = True
        EvaluateGame()

    End Sub

    'checks for a winner or a tie game
    Private Sub EvaluateGame()
        If IsWinner() Then
            lblDirections.Text = "Player " & CStr(thePlayer) & " Wins!"
            btnOne.Enabled = False
            btnTwo.Enabled = False
            btnThree.Enabled = False
            btnFour.Enabled = False
            btnFive.Enabled = False
            btnSix.Enabled = False
            btnSeven.Enabled = False
            btnEight.Enabled = False
            btnNine.Enabled = False
        Else
            If (lblDirections.Text <> "Tie Game!") Then
                thePlayer = thePlayer + 1
                If (thePlayer > 2) Then
                    thePlayer = 1
                End If
                lblDirections.Text = "Player " & CStr(thePlayer) & " GO!"
            End If
        End If
    End Sub

    Private Function IsWinner()
        Dim Result As Boolean = False


        'checks all the rows to see if there is a winner
        If ((theBoard(0, 0) > 0) And (theBoard(0, 1) > 0) And (theBoard(0, 2) > 0)) Then
            If ((theBoard(0, 0) = theBoard(0, 1)) And (theBoard(0, 1) = theBoard(0, 2))) Then
                Result = True
            End If
        End If

        If Result = False Then
            If ((theBoard(1, 0) > 0) And (theBoard(1, 1) > 0) And (theBoard(1, 2) > 0)) Then
                If ((theBoard(1, 0) = theBoard(1, 1)) And (theBoard(1, 1) = theBoard(1, 2))) Then
                    Result = True
                End If
            End If
        End If

        If Result = False Then
            If ((theBoard(2, 0) > 0) And (theBoard(2, 1) > 0) And (theBoard(2, 2) > 0)) Then
                If ((theBoard(2, 0) = theBoard(2, 1)) And (theBoard(2, 1) = theBoard(2, 2))) Then
                    Result = True
                End If
            End If
        End If


        'checks all the columns to see if there is a winner
        If Result = False Then
            If ((theBoard(0, 0) > 0) And (theBoard(1, 0) > 0) And (theBoard(2, 0) > 0)) Then
                If ((theBoard(0, 0) = theBoard(1, 0)) And (theBoard(1, 0) = theBoard(2, 0))) Then
                    Result = True
                End If
            End If
        End If


        If Result = False Then
            If ((theBoard(0, 1) > 0) And (theBoard(1, 1) > 0) And (theBoard(2, 1) > 0)) Then
                If ((theBoard(0, 1) = theBoard(1, 1)) And (theBoard(1, 1) = theBoard(2, 1))) Then
                    Result = True
                End If
            End If
        End If

        If Result = False Then
            If ((theBoard(0, 2) > 0) And (theBoard(1, 2) > 0) And (theBoard(2, 2) > 0)) Then
                If ((theBoard(0, 2) = theBoard(1, 2)) And (theBoard(1, 2) = theBoard(2, 2))) Then
                    Result = True
                End If
            End If
        End If


        'checks for the two diagonal winners
        If Result = False Then
            If ((theBoard(0, 0) > 0) And (theBoard(1, 1) > 0) And (theBoard(2, 2) > 0)) Then
                If ((theBoard(0, 0) = theBoard(1, 1)) And (theBoard(1, 1) = theBoard(2, 2))) Then
                    Result = True
                End If
            End If
        End If

        If Result = False Then
            If ((theBoard(2, 0) > 0) And (theBoard(1, 1) > 0) And (theBoard(0, 2) > 0)) Then
                If ((theBoard(2, 0) = theBoard(1, 1)) And (theBoard(1, 1) = theBoard(0, 2))) Then
                    Result = True
                End If
            End If
        End If

        'checks for a tie game
        If Result = False Then
            If ((theBoard(0, 0) > 0) And (theBoard(0, 1) > 0) And (theBoard(0, 2) > 0) And (theBoard(1, 0) > 0) And (theBoard(1, 1) > 0) And (theBoard(1, 2) > 0) And (theBoard(2, 0) > 0) And (theBoard(2, 1) > 0) And (theBoard(2, 2) > 0)) Then
                lblDirections.Text = "Tie Game!"
            End If
        End If

        Return Result
    End Function

    'Done closes the window
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
End Class
