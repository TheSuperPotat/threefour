Public Class SingleGame
    ' Constants for chessboard dimensions
    Const BoardSize As Integer = 8
    Const SquareSize As Integer = 50 ' Size of each square in pixels

    ' Colors for chessboard squares
    Dim LightColor As Color = Color.LightGray
    Dim DarkColor As Color = Color.DarkGray

    ' 2D array to store the positions of each square on the chessboard
    Dim chessboardArray(BoardSize - 1, BoardSize - 1) As String

    'Current players turn and resignation check
    Dim PlayersTurn As Integer = 0 '0 for white, 1 for black
    Dim resigned As Integer = 0 '0 for no 1 for yes

    Private Sub Singlegame_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PictureBox size to fit the chessboard
        ChessBoard.Width = BoardSize * SquareSize
        ChessBoard.Height = BoardSize * SquareSize
    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles ChessBoard.Paint
        DrawChessboard(e.Graphics)
        DrawWhitePawns(e.Graphics)
        DrawBlackPawns(e.Graphics)
    End Sub

    Private Sub DrawChessboard(g As Graphics)
        For row As Integer = 0 To BoardSize - 1
            For col As Integer = 0 To BoardSize - 1

                Dim x As Integer = col * SquareSize
                Dim y As Integer = row * SquareSize

                Dim DrawColor As Color
                If ((row + col) Mod 2 = 0) Then
                    DrawColor = LightColor
                Else
                    DrawColor = DarkColor
                End If

                DrawSquare(g, x, y, DrawColor)
                chessboardArray(row, col) = ConvertToChessNotation(col, row)

            Next
        Next

        TurnLabel.Text = "Whites turn"

    End Sub


    Private Sub DrawSquare(g As Graphics, x As Integer, y As Integer, color As Color)
        Using brush As New SolidBrush(color)
            g.FillRectangle(brush, x, y, SquareSize, SquareSize)
        End Using
    End Sub

    Private Function ConvertToChessNotation(col As Integer, row As Integer) As String
        Dim file As Char = Convert.ToChar(97 + col)
        Dim rank As String = (BoardSize - row).ToString()
        Return file & rank
    End Function

    Private Sub ChessBoard_MouseClick(sender As Object, e As MouseEventArgs) Handles ChessBoard.MouseClick
        If resigned = 0 Then
            Dim col As Integer = e.X \ SquareSize
            Dim row As Integer = e.Y \ SquareSize
            Dim squareValue As String = chessboardArray(row, col)
            MessageBox.Show("Clicked Square: " & squareValue, "Chessboard Square", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'need to check if square has a piece, if not do nothing, if it does select that piece and allow it to move
            ' to do this, need classes of pieces and then need to place them
        End If

    End Sub


    Private Sub ResignButton_Click(sender As Object, e As EventArgs) Handles ResignButton.Click
        resigned = 1
        If PlayersTurn = 0 Then
            MsgBox("Black wins by resignation!")
            Me.Dispose()
            MainMenu.Show()
        ElseIf PlayersTurn = 1 Then
            MsgBox("White wins by resignation!")
            Me.Dispose()
            MainMenu.Show()
        End If
    End Sub




    'Private Sub DisplayChessboardArrayValues()
    'Dim allValues As String = ""
    'For row As Integer = 0 To BoardSize - 1
    'For col As Integer = 0 To BoardSize - 1
    'Dim value As String = chessboardArray(row, col)
    '           allValues &= value & " "
    'Next
    '       allValues &= vbCrLf ' Add a new line after each row
    'Next
    '
    'MessageBox.Show(allValues, "Chessboard Array Values", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub



    'draw pawns test

    Private Sub DrawWhitePawns(g As Graphics)

        Dim WhitePawns As New List(Of Pawn)
        For FileNumber = Asc("a") To Asc("h")
            Dim file As Char = Chr(FileNumber) 'finds the file (A-H)
            Dim whitepawn = New Pawn("white", file & "2") 'gives colour and position. all start at 2
            WhitePawns.Add(whitepawn)
        Next

        Dim pawnSize As Integer = SquareSize / 2 'currently represents pawn as green square
        Dim pawnBrush As New SolidBrush(Color.Green)

        For Each whitePawn As Pawn In WhitePawns
            Dim file As Char = whitePawn.position(0)
            Dim rank As Integer = Integer.Parse(whitePawn.position(1).ToString())
            Dim x As Integer = (Asc(file) - Asc("a")) * SquareSize + SquareSize / 4
            Dim y As Integer = (BoardSize - rank) * SquareSize + SquareSize / 4

            g.FillRectangle(pawnBrush, x, y, pawnSize, pawnSize)
        Next
    End Sub

    Private Sub DrawBlackPawns(g As Graphics)
        Dim BlackPawns As New List(Of Pawn)
        For FileNumber = Asc("a") To Asc("h")
            Dim file As Char = Chr(FileNumber)
            Dim BlackPawn = New Pawn("black", file & "7")
            BlackPawns.Add(BlackPawn)
        Next

        Dim pawnsize As Integer = SquareSize / 2 'current pawn size/colour
        Dim pawnbrush As New SolidBrush(Color.Blue)

        For Each blackPawn As Pawn In BlackPawns
            Dim file As Char = blackPawn.position(0)
            Dim rank As Integer = Integer.Parse(blackPawn.position(1).ToString())
            Dim x As Integer = (Asc(file) - Asc("a")) * SquareSize + SquareSize / 4
            Dim y As Integer = (BoardSize - rank) * SquareSize + SquareSize / 4
            g.FillRectangle(pawnbrush, x, y, pawnsize, pawnsize)
        Next
    End Sub



    'TODO - add an array so that game knows when a square contains a piece.
    ' add all other pieces
    ' add logic to pieces - moves and captures
    ' find a better way to end the game?
End Class