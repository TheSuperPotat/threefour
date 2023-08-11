Public Class MultiMenu
    Private Sub MultiMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BackButton = New Button ''creates the button that will allow the user to close the game
        BackButton.Width = 200
        BackButton.Height = 80
        BackButton.Left = 25
        BackButton.Top = 350
        BackButton.Text = "Back"
        BackButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Me.Controls.Add(BackButton)
        AddHandler BackButton.MouseClick, AddressOf ReturnToMain

        WindowState = FormWindowState.Maximized ''opens the from in a maximised view instead of a small window

    End Sub

    Private Sub ReturnToMain()
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class