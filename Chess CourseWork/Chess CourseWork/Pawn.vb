Public Class Pawn
    Private Colour As String 'black/white
    Private Value = 1 'piece value
    Private Image 'based on given colour
    Public position As String '1 = A, 2 = B and so on
    Public HasMoved As Boolean = false 'for the first move where it is able to move 2
    'Public IsPromoted as boolean 'is this needed? if a pawn becomes promoted why not just remove and replace (is promoted could be used to remove and replace)
    Public LegalMoves As List(Of String) 'should this be integer? first 1-8 is a-h, second is just 1-8

    Public Sub New(iColour As String, iPosition As String)
        Colour = iColour
        position = iPosition

        If Colour.ToLower() = "white" Then
            'make image the white image
        Else
            'make image black image
        End If

    End Sub

    Public Function GetColour()
        Return Colour
    End Function

    Public Sub MovePiece(NewPosition)
        If LegalMoves.Contains(NewPosition) Then
            position = NewPosition
        End If
    End Sub

End Class
